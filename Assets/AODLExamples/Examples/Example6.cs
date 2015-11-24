using AODL.Document.Content.Tables;
using AODL.Document.Content.Text;
using AODL.Document.TextDocuments;

public partial class ExampleUI
{
    void Example6()
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

        //Fill the cells
        foreach (Row row in table.RowCollection)
        {
            foreach (Cell cell in row.CellCollection)
            {
                //Create a standard paragraph
                Paragraph paragraph = ParagraphBuilder.CreateStandardTextParagraph(document);
                //Add some simple text
                paragraph.TextContent.Add(new SimpleText(document, "Cell text"));
                cell.Content.Add(paragraph);
            }
        }
        //Merge some cells. Notice this is only available in text documents!
        table.RowCollection[1].MergeCells(document, 1, 2, true);
        //Add table to the document
        document.Content.Add(table);
        //Save the document
        document.SaveTo("example6_simpleTableWithMergedCells.odt");
    }
}
