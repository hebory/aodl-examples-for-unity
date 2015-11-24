using AODL.Document.TextDocuments;
using AODL.Document.Content.Text;

public partial class ExampleUI
{
    void Example11()
    {
        //Create new TextDocument
        TextDocument document = new TextDocument();
        document.New();
        //Create a new Paragph
        Paragraph para = ParagraphBuilder.CreateStandardTextParagraph(document);
        //Create some simple Text
        para.TextContent.Add(new SimpleText(document, "Some simple text. And I have a footnode"));
        //Create a Footnote
        para.TextContent.Add(new Footnote(document, "Footer Text", "1", FootnoteType.footnode));
        //Add the paragraph
        document.Content.Add(para);
        //Save
        document.SaveTo("example11_footnote.odt");
    }
}
