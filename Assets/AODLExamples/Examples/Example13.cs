using AODL.Document.TextDocuments;
using AODL.Document.Content.Text;

public partial class ExampleUI
{
    void Example13()
    {
        string headingText = "Some    Heading with\n styles\t,line breaks, tab stops and extra whitspaces";
        //Create a new text document
        TextDocument document = new TextDocument();
        document.New();
        //Create a new Heading
        Header header = new Header(document, Headings.Heading);
        //Create a TextCollection from headingText using the TextBuilder
        //You can conert every string incl. control character \n, \t, .. into
        //a ItextCollection using the TextBuilder
        ITextCollection textCol = TextBuilder.BuildTextCollection(document, headingText);
        //Add text collection
        header.TextContent = textCol;
        //Add header
        document.Content.Add(header);
        document.SaveTo("example13_HeadingWithControlCharacter.odt");
    }
}
