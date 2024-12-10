using CommandDictionary.Data.Repository;
using CommandDictionary.Forms;
using CommandDictionary.Forms.Comparers;
using CommandDictionary.Forms.Models;
using CommandDictionary.Forms.Models.Mappings;

namespace CommandDictionary;

public partial class Main : Form
{
    public IEnumerable<CommandEntry> Entries { get; set; }
    private readonly ListViewColumnSorter columnSorter;
    private readonly ICommandsContextRepository context;

    public Main(ICommandsContextRepository _context)
    {
        try
        {
            context = _context;
            Entries = context
                .GetCommandEntries()
                .MapToCommandEntries();

            InitializeComponent();
            columnSorter = new ListViewColumnSorter();
            this.DictionaryListView.ListViewItemSorter = columnSorter;
            InitializeAttachmentListView();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message );
            throw;
        }
    }
    private void InitializeAttachmentListView()
    {
        // ListView configuration
        this.DictionaryListView.LabelEdit = true;
        this.DictionaryListView.View = View.Details;

        // Adding column headers
        this.DictionaryListView.Columns.Add("Application");
        this.DictionaryListView.Columns.Add("Category");
        this.DictionaryListView.Columns.Add("Description");
        this.DictionaryListView.Columns.Add("Command");

        // Filling in default data
        FillListView();

        this.DictionaryListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

    }

    public void AddCommandToList(CommandEntry command)
    {
        var listItem = command.ToListViewItem();
        this.DictionaryListView.Items.Add(listItem).SubItems.AddRange([command.Category.Name, command.Description, command.Command.CommandString]);
    }

    private void copyButton_Click(object sender, EventArgs e)
    {
        var selectedItem = GetSelectedItem();

        if (selectedItem == null) return;

        if (selectedItem.Tag is not CommandEntry itemTag) return;

        Clipboard.SetText(itemTag.Command.CommandString);
    }

    public ListViewItem? GetSelectedItem()
    {
        try
        {
            var item = DictionaryListView.SelectedItems[0];

            return item;
        }
        catch (Exception)
        {
            return null;
        }
    }

    public void FillListView()
    {
        DictionaryListView.Items.Clear();

        var listItems = Entries.Select(x => x.ToListViewItem()).ToList();

        foreach (var item in Entries)
        {
            AddCommandToList(item);
        }
    }

    private void CancelButton_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void NewButton_Click(object sender, EventArgs e)
    {
        var newForm = new NewEntryForm(this, context);
        newForm.ShowDialog();
    }

    private void DictionaryListView_ColumnClick(object sender, ColumnClickEventArgs e)
    {
        // Determine if clicked column is already the column that is being sorted.
        if (e.Column == columnSorter.SortColumn)
        {
            // Reverse the current sort direction for this column.
            if (columnSorter.Order == SortOrder.Ascending)
            {
                columnSorter.Order = SortOrder.Descending;
                //ListViewExtension.SetSortArrow(this.DictionaryListView.Columns[e.Column], SortOrder.Descending);
            }
            else
            {
                columnSorter.Order = SortOrder.Ascending;
                //ListViewExtension.SetSortArrow(this.DictionaryListView.Columns[e.Column], SortOrder.Ascending);

            }
        }
        else
        {
            // Set the column number that is to be sorted; default to ascending.
            columnSorter.SortColumn = e.Column;
            columnSorter.Order = SortOrder.Ascending;
        }

        // Perform the sort with these new sort options.
        this.DictionaryListView.Sort();
    }

    private void EditButton_Click(object sender, EventArgs e)
    {
        var newForm = new EditEntryForm(this, context);
        newForm.ShowDialog();
    }

    private void DeleteButton_Click(object sender, EventArgs e)
    {
        var tag = GetSelectedItem()?.Tag;

        if (tag == null)
        {
            return;
        }
        var command = (CommandEntry)tag;
        var deleteWasSuccessful = context.DeleteCommand(command.Id);
        if (deleteWasSuccessful)
        {
            FillListView();
        }
    }
}
