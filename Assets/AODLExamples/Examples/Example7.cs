using AODL.Document.TextDocuments;
using AODL.Document.Content.Tables;
using AODL.Document.Content.Text;

public partial class ExampleUI
{
    void Example7()
    {
        //Create a new text document
        TextDocument document = new TextDocument();
        document.New();
        //Create a table for a text document using the TableBuilder
        Table table = TableBuilder.CreateTextDocumentTable(
            document,
            "table1",
            "table1",
            3,
            3,
            16.99,
            false,
            false);
        //Create a standard paragraph
        Paragraph paragraph = ParagraphBuilder.CreateStandardTextParagraph(document);
        //Add some simple text
        paragraph.TextContent.Add(new SimpleText(document, "Some cell text"));
        //Insert paragraph into the first cell
        table.RowCollection[0].CellCollection[0].Content.Add(paragraph);
        //Add table to the document
        document.Content.Add(table);
        //Save the document
        document.SaveTo("example7_simpleTable.odt");
    }
}
