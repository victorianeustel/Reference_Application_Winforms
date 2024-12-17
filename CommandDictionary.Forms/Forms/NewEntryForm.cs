using CommandDictionary.Forms.Models;
using CommandDictionary.Data.Repository;
using CommandDictionary.Forms.Models.Mappings;

namespace CommandDictionary;

public partial class NewEntryForm : Form
{
    readonly Main mainForm;
    private readonly ICommandsContextRepository context;
    public NewEntryForm(Main _mainForm, ICommandsContextRepository _context)
    {
        InitializeComponent();
        context = _context;
        mainForm = _mainForm;
        CategoryComboBox.DataSource = context.GetCategoryTypes();
        ApplicationComboBox.DataSource = context.GetApplicationTypes();
    }

    private void CancelButton_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void OkButton_Click(object sender, EventArgs e)
    {
        var newCommand = new NewCommandEntry()
        {
            ApplicationId = GetComboboxSelectedValue(ApplicationComboBox),
            CategoryId = GetComboboxSelectedValue(CategoryComboBox),
            Description = DescriptionTextBox.Text,
            CommandString = CommandTextBox.Text
        };

        var databaseEntry = context.InsertOrUpdate(newCommand.ToDataCommandEntry());

        if (databaseEntry != null) {
            mainForm.AddCommandToList(databaseEntry.MapToCommandEntry());
            this.Close();
        }
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
