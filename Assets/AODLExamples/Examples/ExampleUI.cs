// https://wiki.openoffice.org/wiki/AODL_examples

using UnityEngine;

public partial class ExampleUI : MonoBehaviour
{
    Vector2 scroll_pos;
    void OnGUI()
    {
        scroll_pos = GUILayout.BeginScrollView(scroll_pos);
        if (GUILayout.Button("Example1 - Create a Spreadsheet document and add a table with formated cells")) Example1();
        if (GUILayout.Button("Example2 - Create a spreadsheet document and add a table")) Example2();
        if (GUILayout.Button("Example3 - Add Image Maps to your document")) Example3();
        if (GUILayout.Button("Example4 - Add a graphic as a illustration to your text document")) Example4();
        if (GUILayout.Button("Example5 - Add graphics to your document")) Example5();
        if (GUILayout.Button("Example6 - Create a table and use cell merging")) Example6();
        if (GUILayout.Button("Example7 - Create a simple text table by using the TableBuilder class")) Example7();
        if (GUILayout.Button("Example8 - Don't do things twice. Create deep clones of any IContent object")) Example8();
        if (GUILayout.Button("Example9 - Accessing and manipulating common styles (style templates)")) Example9();
        if (GUILayout.Button("Example10 - Create a Paragraph Collection from a long string by using the ParagraphBuilder")) Example10();
        if (GUILayout.Button("Example11 - Creating Footnotes and Endnotes")) Example11();
        if (GUILayout.Button("Example12 - Create any type of hyperlinks by using the XLink class")) Example12();
        if (GUILayout.Button("Example13 - Using the Header object and fill the heading text using the TextBuilder class")) Example13();
        if (GUILayout.Button("Example14 - Create a List with List Item objects")) Example14();
        if (GUILayout.Button("Example15 - Create a standard Paragraph with formated text")) Example15();
        if (GUILayout.Button("Example16 - Create a simple Paragraph using the ParagraphBuilder")) Example16();
        GUILayout.EndScrollView();
    }
}
