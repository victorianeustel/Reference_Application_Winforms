namespace CommandDictionary.Extensions;
public class ListViewExtension
{
    public static void SetSortArrow(ColumnHeader head, SortOrder order)
    {
        const string ascArrow = " ▲";
        const string descArrow = " ▼";

        // remove arrow
        if (head.Text.EndsWith(ascArrow) || head.Text.EndsWith(descArrow))
            head.Text = head.Text.Substring(0, head.Text.Length - 2);

        // add arrow
        switch (order)
        {
            case SortOrder.Ascending: head.Text += ascArrow; break;
            case SortOrder.Descending: head.Text += descArrow; break;
        }
    }
}
