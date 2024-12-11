using CommandDictionary.Data.Repository;
using CommandDictionary.Forms.Models;

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
        ApplicationComboBox.SelectedIndex = (int)originalCommand.Application.Id - 1;
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
        var editedCommand = new NewCommandEntry()
        {
            Id = originalCommand.Id,
            ApplicationId = GetComboboxSelectedValue(ApplicationComboBox),
            CategoryId = GetComboboxSelectedValue(ApplicationComboBox),
            CommandId = originalCommand.Command.Id,
            Description = DescriptionTextBox.Text,
            CommandString = CommandTextBox.Text
        };

        if (editedCommand == null) return;

        context.InsertOrUpdate(editedCommand.ToDataCommandEntry());
        //var updateWasSuccessful = context.UpdateCommand(editedCommand.ToDataCommandEntry());

        mainForm.FillListView();
        

        this.Close();
    }

    private long GetComboboxSelectedValue(ComboBox comboBox)
    {
        var selectedValue = comboBox.SelectedValue;

        if (selectedValue is long id)
        {
            return id;
        }

        throw new ArgumentNullException(nameof(id));
    }
}
