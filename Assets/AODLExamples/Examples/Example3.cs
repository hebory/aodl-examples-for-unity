using AODL.Document.Content.Draw;
using AODL.Document.Content.Text;
using AODL.Document.TextDocuments;

public partial class ExampleUI
{
    void Example3()
    {
        string imagePath = @"Assets\ODFSample\Examples\example3.png";
        TextDocument document = new TextDocument();
        document.New();
        //Create standard paragraph
        Paragraph paragraphOuter = ParagraphBuilder.CreateStandardTextParagraph(document);
        //Create the frame with graphic
        Frame frame = new Frame(document, "frame1", "graphic1", imagePath);
        //Create a Draw Area Rectangle
        DrawAreaRectangle drawAreaRec = new DrawAreaRectangle(
            document, "0cm", "0cm", "1.5cm", "2.5cm", null);
        drawAreaRec.Href = "http://OpenDocument4all.com";
        //Create a Draw Area Circle
        DrawAreaCircle drawAreaCircle = new DrawAreaCircle(
            document, "4cm", "4cm", "1.5cm", null);
        drawAreaCircle.Href = "http://AODL.OpenDocument4all.com";
        DrawArea[] drawArea = new DrawArea[2] { drawAreaRec, drawAreaCircle };
        //Create a Image Map
        ImageMap imageMap = new ImageMap(document, drawArea);
        //Add Image Map to the frame
        frame.Content.Add(imageMap);
        //Add frame to paragraph
        paragraphOuter.Content.Add(frame);
        //Add paragraph to document
        document.Content.Add(paragraphOuter);
        //Save the document
        document.SaveTo(@"example3_simpleImageMap.odt");
    }
}
