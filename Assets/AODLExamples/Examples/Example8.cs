using AODL.Document.TextDocuments;
using AODL.Document.Content.Text;
using AODL.Document.Styles;

public partial class ExampleUI
{
    void Example8()
    {
        TextDocument document = new TextDocument();
        document.New();
        Paragraph paragraph = ParagraphBuilder.CreateStandardTextParagraph(document);
        paragraph.TextContent.Add(new SimpleText(document, "Some text"));
        Paragraph paragraphClone = (Paragraph)paragraph.Clone();
        ParagraphStyle paragraphStyle = new ParagraphStyle(document, "P1");
        paragraphStyle.TextProperties.Bold = "bold";
        //Add paragraph style to the document, 
        //only automaticaly created styles will be added also automaticaly
        document.Styles.Add(paragraphStyle);
        paragraphClone.ParagraphStyle = paragraphStyle;
        //Clone the clone
        Paragraph paragraphClone2 = (Paragraph)paragraphClone.Clone();
        document.Content.Add(paragraph);
        document.Content.Add(paragraphClone);
        document.Content.Add(paragraphClone2);
        document.SaveTo("example8_clonedParagraphs.odt");
    }
}
