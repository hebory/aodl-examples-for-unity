using AODL.Document.TextDocuments;
using AODL.Document.Content.Text;

public partial class ExampleUI
{
    void Example12()
    {
        //Create new TextDocument
        TextDocument document = new TextDocument();
        document.New();
        //Create a new Paragraph
        Paragraph para = new Paragraph(document, "P1");
        //Create some simple text
        SimpleText stext = new SimpleText(document, "Some simple text ");
        //Create a XLink
        XLink xlink = new XLink(document, "http://www.OpenOffice.org", "OpenOffice.org");
        //Add the textcontent
        para.TextContent.Add(stext);
        para.TextContent.Add(xlink);
        //Add paragraph to the document content
        document.Content.Add(para);
        //Save
        document.SaveTo("example12_XLink.odt");
    }
}
