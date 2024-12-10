using CommandDictionary.Data.Repository;
using CommandDictionary.Forms.Models;
using CommandDictionary.Forms.Models.Mappings;
using Application = CommandDictionary.Forms.Models.Application;

namespace CommandDictionary.Forms;
public partial class EditEntryForm : Form
{
    private readonly Main mainForm;
    private readonly CommandEntry originalCommand;
    private readonly ICommandsContextRepository context;
    private readonly int selectedIndex;

    public EditEntryForm(Main _mainForm, ICommandsContextRepository _context)
    {
        context = _context;
        InitializeComponent();
        CategoryComboBox.DataSource = context.GetCategoryTypes();
        ApplicationComboBox.DataSource = context.GetApplicationTypes();

        mainForm = _mainForm;
        var selectedItem = mainForm.GetSelectedItem();

        if (selectedItem?.Tag is not CommandEntry selectedCommand)
        {
            this.Close();
            return;
        }

        originalCommand = selectedCommand;

        selectedIndex = selectedItem.Index;

        CategoryComboBox.SelectedIndex = (int)originalCommand.Category.Id;
        ApplicationComboBox.SelectedIndex = (int)originalCommand.Application.Id;
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

        var updateWasSuccessful = context.UpdateCommand(editedCommand.MapToDataCommandEntry());

        if (updateWasSuccessful)
        {
            mainForm.FillListView();
        }

        //JsonDataHelper.UpdateJsonFile(mainForm.Entries);
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
