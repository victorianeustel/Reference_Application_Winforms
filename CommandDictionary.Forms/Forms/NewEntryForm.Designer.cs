namespace CommandDictionary;

partial class NewEntryForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        CommandTextBox = new TextBox();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        OkButton = new Button();
        CancelButton = new Button();
        CategoryComboBox = new ComboBox();
        categoryBindingSource = new BindingSource(components);
        ApplicationComboBox = new ComboBox();
        applicationBindingSource = new BindingSource(components);
        DescriptionTextBox = new TextBox();
        ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)applicationBindingSource).BeginInit();
        SuspendLayout();
        // 
        // CommandTextBox
        // 
        CommandTextBox.Location = new Point(140, 164);
        CommandTextBox.Name = "CommandTextBox";
        CommandTextBox.Size = new Size(721, 30);
        CommandTextBox.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label1.Location = new Point(28, 39);
        label1.Name = "label1";
        label1.Size = new Size(93, 20);
        label1.TabIndex = 1;
        label1.Text = "Application:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label2.Location = new Point(46, 83);
        label2.Name = "label2";
        label2.Size = new Size(77, 20);
        label2.TabIndex = 2;
        label2.Text = "Category:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label3.Location = new Point(28, 123);
        label3.Name = "label3";
        label3.Size = new Size(93, 20);
        label3.TabIndex = 3;
        label3.Text = "Description:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label4.Location = new Point(37, 168);
        label4.Name = "label4";
        label4.Size = new Size(85, 20);
        label4.TabIndex = 4;
        label4.Text = "Command:";
        // 
        // OkButton
        // 
        OkButton.Location = new Point(637, 207);
        OkButton.Name = "OkButton";
        OkButton.Size = new Size(106, 33);
        OkButton.TabIndex = 5;
        OkButton.Text = "OK";
        OkButton.UseVisualStyleBackColor = true;
        OkButton.Click += OkButton_Click;
        // 
        // CancelButton
        // 
        CancelButton.Location = new Point(749, 207);
        CancelButton.Name = "CancelButton";
        CancelButton.Size = new Size(106, 33);
        CancelButton.TabIndex = 6;
        CancelButton.Text = "Cancel";
        CancelButton.UseVisualStyleBackColor = true;
        CancelButton.Click += CancelButton_Click;
        // 
        // CategoryComboBox
        // 
        CategoryComboBox.DataSource = categoryBindingSource;
        CategoryComboBox.DisplayMember = "Name";
        CategoryComboBox.FormattingEnabled = true;
        CategoryComboBox.Location = new Point(140, 79);
        CategoryComboBox.Name = "CategoryComboBox";
        CategoryComboBox.Size = new Size(165, 31);
        CategoryComboBox.TabIndex = 7;
        CategoryComboBox.ValueMember = "Id";
        // 
        // categoryBindingSource
        // 
        categoryBindingSource.DataSource = typeof(Forms.Models.Category);
        // 
        // ApplicationComboBox
        // 
        ApplicationComboBox.DataSource = applicationBindingSource;
        ApplicationComboBox.DisplayMember = "Name";
        ApplicationComboBox.FormattingEnabled = true;
        ApplicationComboBox.Location = new Point(140, 36);
        ApplicationComboBox.Name = "ApplicationComboBox";
        ApplicationComboBox.Size = new Size(229, 31);
        ApplicationComboBox.TabIndex = 8;
        ApplicationComboBox.ValueMember = "Id";
        // 
        // applicationBindingSource
        // 
        applicationBindingSource.DataSource = typeof(Forms.Models.Application);
        // 
        // DescriptionTextBox
        // 
        DescriptionTextBox.Location = new Point(140, 123);
        DescriptionTextBox.Name = "DescriptionTextBox";
        DescriptionTextBox.Size = new Size(721, 30);
        DescriptionTextBox.TabIndex = 9;
        // 
        // NewEntryForm
        // 
        AutoScaleDimensions = new SizeF(9F, 23F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(900, 253);
        Controls.Add(DescriptionTextBox);
        Controls.Add(ApplicationComboBox);
        Controls.Add(CategoryComboBox);
        Controls.Add(CancelButton);
        Controls.Add(OkButton);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(CommandTextBox);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Name = "NewEntryForm";
        Text = "Add New Command";
        ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
        ((System.ComponentModel.ISupportInitialize)applicationBindingSource).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox CommandTextBox;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Button OkButton;
    private Button CancelButton;
    private ComboBox CategoryComboBox;
    private ComboBox ApplicationComboBox;
    private TextBox DescriptionTextBox;
    private BindingSource applicationBindingSource;
    private BindingSource categoryBindingSource;
}