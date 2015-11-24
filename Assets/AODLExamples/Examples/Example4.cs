using AODL.Document.Content.Draw;
using AODL.Document.Content.Text;
using AODL.Document.TextDocuments;

public partial class ExampleUI
{
    void Example4()
    {
        string imagePath = @"Assets\ODFSample\Examples\example3.png";
        TextDocument textdocument = new TextDocument();
        textdocument.New();
        Paragraph pOuter = ParagraphBuilder.CreateStandardTextParagraph(textdocument);
        DrawTextBox drawTextBox = new DrawTextBox(textdocument);
        Frame frameTextBox = new Frame(textdocument, "fr_txt_box");
        frameTextBox.DrawName = "fr_txt_box";
        frameTextBox.ZIndex = "0";
        Paragraph p = ParagraphBuilder.CreateStandardTextParagraph(textdocument);
        p.StyleName = "Illustration";
        Frame frame = new Frame(textdocument, "frame1", "graphic1", imagePath);
        frame.ZIndex = "1";
        p.Content.Add(frame);
        p.TextContent.Add(new SimpleText(textdocument, "Illustration"));
        drawTextBox.Content.Add(p);
        frameTextBox.SvgWidth = frame.SvgWidth;
        drawTextBox.MinWidth = frame.SvgWidth;
        drawTextBox.MinHeight = frame.SvgHeight;
        frameTextBox.Content.Add(drawTextBox);
        pOuter.Content.Add(frameTextBox);
        textdocument.Content.Add(pOuter);
        textdocument.SaveTo("example4_drawTextbox.odt");
    }
}
