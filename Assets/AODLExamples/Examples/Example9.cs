using AODL.Document.TextDocuments;
using AODL.Document.Content.Text;
using AODL.Document.Styles;

public partial class ExampleUI
{
	void Example9 ()
	{
		TextDocument document = new TextDocument ();
		document.New ();
		//Find a Header template
		IStyle style = document.CommonStyles.GetStyleByName ("Heading_20_1");
		//Assert.IsNotNull (style, "Style with name Heading_20_1 must exist");
		//Assert.IsTrue (style is ParagraphStyle, "style must be a ParagraphStyle");
		((ParagraphStyle)style).TextProperties.FontName = FontFamilies.BroadwayBT;
		//Create a header that use the standard style Heading_20_1
		Header header = new Header (document, Headings.Heading_20_1);
		//Add some text
		header.TextContent.Add (new SimpleText (document, "I am the header text and my style template was modified :)"));
		//Add header to the document
		document.Content.Add (header);
		//save the document
		document.SaveTo ("example9_modifiedCommonStyle.odt");
	}
}
