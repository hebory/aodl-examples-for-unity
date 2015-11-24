using AODL.Document.TextDocuments;
using AODL.Document.Content.Text;
using AODL.Document.Styles;

public partial class ExampleUI
{
    void Example14()
    {
        //Create a new text document
        TextDocument document = new TextDocument();
        document.New();
        //Create a numbered list
        List li = new List(document, "L1", ListStyles.Bullet, "L1P1");
        //Create a new list item
        ListItem lit = new ListItem(li);
        //Create a paragraph	
        Paragraph paragraph = ParagraphBuilder.CreateStandardTextParagraph(document);
        //Add some text
        paragraph.TextContent.Add(new SimpleText(document, "First item"));
        //Add paragraph to the list item
        lit.Content.Add(paragraph);
        //Add the list item
        li.Content.Add(lit);
        //Add the list
        document.Content.Add(li);
        //Save document
        document.SaveTo("example14_list.odt");
    }
}
