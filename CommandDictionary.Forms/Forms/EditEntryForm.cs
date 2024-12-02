using CommandDictionary.Helpers;
using CommandDictionary.Models;
using Application = CommandDictionary.Models.Application;

namespace CommandDictionary.Forms;
public partial class EditEntryForm : Form
{
    private readonly Main mainForm;
    private readonly CommandEntry originalCommand;
    private readonly int selectedIndex;

    public EditEntryForm(Main _mainForm)
    {
        InitializeComponent();
        CategoryComboBox.DataSource = Enum.GetValues<Category>();
        ApplicationComboBox.DataSource = Enum.GetValues<Application>();
        mainForm = _mainForm;
        var selectedItem = mainForm.GetSelectedItem();

        if (selectedItem?.Tag is not CommandEntry selectedCommand)
        {
            this.Close();
            return;
        }

        originalCommand = selectedCommand;

        selectedIndex = selectedItem.Index;

        CategoryComboBox.SelectedIndex = (int)originalCommand.Category;
        ApplicationComboBox.SelectedIndex = (int)originalCommand.Application;
        DescriptionTextBox.Text = originalCommand.Description;
        CommandTextBox.Text = originalCommand.Command.CommandString;

    }

    private void CancelButton_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void SaveChangesButton_Click(object sender, EventArgs e)
    {
        if (originalCommand == null)
        {
            return;
        }
        var editedCommand = new CommandEntry()
        {
            Application = originalCommand.Application,
            Category = originalCommand.Category,
            Description = originalCommand.Description,
            Command = originalCommand.Command
        };
        if (editedCommand == null) return;
        editedCommand.Application = GetApplicationComboBoxSelection();
        editedCommand.Category = GetCategoryComboBoxSelection();
        editedCommand.Description = DescriptionTextBox.Text;
        editedCommand.Command = new Command() {CommandString = CommandTextBox.Text };

        mainForm.Entries.RemoveAt(selectedIndex);
        mainForm.Entries.Insert(selectedIndex, editedCommand);
        mainForm.FillListView();

        JsonDataHelper.UpdateJsonFile(mainForm.Entries);
        this.Close();
    }

    private Category GetCategoryComboBoxSelection()
    {
        var selectedValue = CategoryComboBox.SelectedItem;

        if (selectedValue is Category selectedCategory)
        {
            return selectedCategory;
        }

        throw new ArgumentNullException(nameof(selectedCategory));
    }

    private Application GetApplicationComboBoxSelection()
    {
        var selectedValue = ApplicationComboBox.SelectedItem;

        if (selectedValue is Application selectedApplication)
        {
            return selectedApplication;
        }

        throw new ArgumentNullException(nameof(selectedApplication));
    }
}
