using AODL.Document.TextDocuments;
using AODL.Document.Content.Text;

public partial class ExampleUI
{
    void Example15()
    {
        //Create a new text document
        TextDocument document = new TextDocument();
        document.New();
        //Create a standard paragraph using the ParagraphBuilder
        Paragraph paragraph = ParagraphBuilder.CreateStandardTextParagraph(document);
        //Add some formated text
        FormatedText formText = new FormatedText(document, "T1", "Some formated text!");
        formText.TextStyle.TextProperties.Bold = "bold";
        paragraph.TextContent.Add(formText);
        //Add the paragraph to the document
        document.Content.Add(paragraph);
        //Save 
        document.SaveTo("example15_formated.odt");
    }
}
