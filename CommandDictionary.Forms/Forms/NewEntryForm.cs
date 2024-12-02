using CommandDictionary.Helpers;
using CommandDictionary.Models;
using Application = CommandDictionary.Models.Application;

namespace CommandDictionary;
public partial class NewEntryForm : Form
{
    readonly Main mainForm;
    public NewEntryForm(Main _mainForm)
    {
        InitializeComponent();
        mainForm = _mainForm;
        CategoryComboBox.DataSource = Enum.GetValues<Category>();
        ApplicationComboBox.DataSource = Enum.GetValues<Application>();
    }

    private void CancelButton_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void OkButton_Click(object sender, EventArgs e)
    {
        var newCommand = new CommandEntry()
        {
            Application = GetApplicationComboBoxSelection(),
            Category = GetCategoryComboBoxSelection(),
            Description = DescriptionTextBox.Text,
            Command = new Command() { CommandString = CommandTextBox.Text }
        };

        JsonDataHelper.AddAndUpdateEntries(newCommand, mainForm.Entries);
        mainForm.AddCommandToList(newCommand);
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

    private static string GetEnumValueName<T>(T value) where T : Enum
    {
        string? stringValue = value.ToString() ?? throw new ArgumentNullException(nameof(value));

        return stringValue;
    }

    private static T GetEnumValueFromString<T>(string value) where T : Enum
    {
        var enumValue = (T)Enum.Parse(typeof(T), value);
        return enumValue;
    }
}
