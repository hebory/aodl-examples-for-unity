using AODL.Document.TextDocuments;
using AODL.Document.Content.Text;
using AODL.Document.Content.Draw;

public partial class ExampleUI
{
    void Example5()
    {
        TextDocument textdocument = new TextDocument();
        textdocument.New();
        Paragraph p = ParagraphBuilder.CreateStandardTextParagraph(textdocument);
        Frame frame = new Frame(textdocument, "frame1", "graphic1", @"Assets\ODFSample\Examples\example3.png");
        p.Content.Add(frame);
        textdocument.Content.Add(p);
        textdocument.SaveTo("example5_grapic.odt");
    }
}
