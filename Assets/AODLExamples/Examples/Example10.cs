using AODL.Document.TextDocuments;
using AODL.Document.Content.Text;

public partial class ExampleUI
{
    void Example10()
    {
        //some text e.g read from a TextBox
        string someText = "Max Mustermann\nMustermann Str. 300\n22222 Hamburg\n\n\n\n"
                                + "Heinz Willi\nDorfstr. 1\n22225 Hamburg\n\n\n\n"
                                + "Offer for 200 Intel Pentium 4 CPU's\n\n\n\n"
                                + "Dear Mr. Willi,\n\n\n\n"
                                + "thank you for your request. \tWe can "
                                + "offer you the 200 Intel Pentium IV 3 Ghz CPU's for a price of "
                                + "79,80 € per unit."
                                + "This special offer is valid to 31.10.2005. If you accept, we "
                                + "can deliver within 24 hours.\n\n\n\n"
                                + "Best regards \nMax Mustermann";

        //Create new TextDocument
        TextDocument document = new TextDocument();
        document.New();
        //Use the ParagraphBuilder to split the string into ParagraphCollection
        ParagraphCollection pCollection = ParagraphBuilder.CreateParagraphCollection(
                                             document,
                                             someText,
                                             true,
                                             ParagraphBuilder.ParagraphSeperator);
        //Add the paragraph collection
        foreach (Paragraph paragraph in pCollection)
            document.Content.Add(paragraph);
        //save
        document.SaveTo("example10_Letter.odt");
    }
}
