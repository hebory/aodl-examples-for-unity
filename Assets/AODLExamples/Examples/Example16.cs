using AODL.Document.TextDocuments;
using AODL.Document.Content.Text;

public partial class ExampleUI
{
    void Example16()
    {
        //Create a new text document
        TextDocument document = new TextDocument();
        document.New();
        //Create a standard paragraph using the ParagraphBuilder
        Paragraph paragraph = ParagraphBuilder.CreateStandardTextParagraph(document);
        //Add some simple text
        paragraph.TextContent.Add(new SimpleText(document, "Some simple text!"));
        //Add the paragraph to the document
        document.Content.Add(paragraph);
        //Save 
        document.SaveTo("example16_simple.odt");
    }
}
