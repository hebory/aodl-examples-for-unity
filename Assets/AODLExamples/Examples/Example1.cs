using AODL.Document.SpreadsheetDocuments;
using AODL.Document.Content.Tables;
using AODL.Document.Content.Text;
using AODL.Document.Styles;

public partial class ExampleUI
{
    void Example1()
    {
        //Create new spreadsheet document
        SpreadsheetDocument spreadsheetDocument = new SpreadsheetDocument();
        spreadsheetDocument.New();
        //Create a new table
        Table table = new Table(spreadsheetDocument, "First", "tablefirst");
        //Create a new cell, without any extra styles 
        Cell cell = table.CreateCell();
        //Add a paragraph to this cell
        Paragraph paragraph = ParagraphBuilder.CreateSpreadsheetParagraph(spreadsheetDocument);
        //Create some Formated text
        FormatedText fText = new FormatedText(spreadsheetDocument, "T1", "Some Text");
        //fText.TextStyle.TextProperties.Bold = "bold";
        fText.TextStyle.TextProperties.Underline = LineStyles.dotted;
        //Add formated text
        paragraph.TextContent.Add(fText);
        //Add paragraph to the cell
        cell.Content.Add(paragraph);
        //Insert the cell at row index 2 and column index 3
        //All need rows, columns and cells below the given
        //indexes will be build automatically.
        table.InsertCellAt(2, 3, cell);
        //Insert table into the spreadsheet document
        spreadsheetDocument.TableCollection.Add(table);
        spreadsheetDocument.SaveTo("example1_formated.ods");
    }
}
