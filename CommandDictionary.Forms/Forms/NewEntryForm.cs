using CommandDictionary.Helpers;
using CommandDictionary.Forms.Models;
using Application = CommandDictionary.Forms.Models.Application;
using Microsoft.EntityFrameworkCore;
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
        var newCommand = new CommandEntry()
        {
            Application = GetApplicationComboBoxSelection(),
            Category = GetCategoryComboBoxSelection(),
            Description = DescriptionTextBox.Text,
            Command = new Command() { CommandString = CommandTextBox.Text }
        };

        var wasAddSuccessful= context.AddCommand(newCommand.MapToDataCommandEntry());
        //JsonDataHelper.AddAndUpdateEntries(newCommand, mainForm.Entries);
        if (wasAddSuccessful) {
            mainForm.AddCommandToList(newCommand);
            this.Close();
        }
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
