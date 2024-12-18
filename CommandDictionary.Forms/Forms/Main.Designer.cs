namespace CommandDictionary;

partial class Main
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
        DictionaryListView = new ListView();
        Commands = new GroupBox();
        DeleteButton = new Button();
        EditButton = new Button();
        NewButton = new Button();
        copyButton = new Button();
        button1 = new Button();
        CancelButton = new Button();
        Commands.SuspendLayout();
        SuspendLayout();
        // 
        // DictionaryListView
        // 
        DictionaryListView.Cursor = Cursors.Hand;
        DictionaryListView.FullRowSelect = true;
        DictionaryListView.GridLines = true;
        DictionaryListView.LabelEdit = true;
        DictionaryListView.Location = new Point(18, 30);
        DictionaryListView.MultiSelect = false;
        DictionaryListView.Name = "DictionaryListView";
        DictionaryListView.Size = new Size(687, 371);
        DictionaryListView.TabIndex = 0;
        DictionaryListView.UseCompatibleStateImageBehavior = false;
        DictionaryListView.ColumnClick += DictionaryListView_ColumnClick;
        // 
        // Commands
        // 
        Commands.Controls.Add(DeleteButton);
        Commands.Controls.Add(EditButton);
        Commands.Controls.Add(NewButton);
        Commands.Controls.Add(copyButton);
        Commands.Controls.Add(DictionaryListView);
        Commands.Location = new Point(25, 39);
        Commands.Name = "Commands";
        Commands.Size = new Size(720, 470);
        Commands.TabIndex = 1;
        Commands.TabStop = false;
        Commands.Text = "Commands";
        // 
        // DeleteButton
        // 
        DeleteButton.Location = new Point(600, 414);
        DeleteButton.Name = "DeleteButton";
        DeleteButton.Size = new Size(106, 33);
        DeleteButton.TabIndex = 4;
        DeleteButton.Text = "&Delete";
        DeleteButton.UseVisualStyleBackColor = true;
        DeleteButton.Click += DeleteButton_Click;
        // 
        // EditButton
        // 
        EditButton.Location = new Point(487, 414);
        EditButton.Name = "EditButton";
        EditButton.Size = new Size(106, 33);
        EditButton.TabIndex = 3;
        EditButton.Text = "&Edit...";
        EditButton.UseVisualStyleBackColor = true;
        EditButton.Click += EditButton_Click;
        // 
        // NewButton
        // 
        NewButton.Location = new Point(375, 414);
        NewButton.Name = "NewButton";
        NewButton.Size = new Size(106, 33);
        NewButton.TabIndex = 2;
        NewButton.Text = "&New...";
        NewButton.UseVisualStyleBackColor = true;
        NewButton.Click += NewButton_Click;
        // 
        // copyButton
        // 
        copyButton.Location = new Point(18, 414);
        copyButton.Name = "copyButton";
        copyButton.Size = new Size(172, 33);
        copyButton.TabIndex = 1;
        copyButton.Text = "&Copy Command";
        copyButton.UseVisualStyleBackColor = true;
        copyButton.Click += copyButton_Click;
        // 
        // button1
        // 
        button1.BackColor = SystemColors.ControlLight;
        button1.FlatStyle = FlatStyle.Flat;
        button1.Image = Forms.Properties.Resources.refresh_icon_small;
        button1.Location = new Point(698, 10);
        button1.Name = "button1";
        button1.Size = new Size(32, 33);
        button1.TabIndex = 3;
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // CancelButton
        // 
        CancelButton.Location = new Point(639, 537);
        CancelButton.Name = "CancelButton";
        CancelButton.Size = new Size(106, 33);
        CancelButton.TabIndex = 2;
        CancelButton.Text = "&Cancel";
        CancelButton.UseVisualStyleBackColor = true;
        CancelButton.Click += CancelButton_Click;
        // 
        // Main
        // 
        AutoScaleDimensions = new SizeF(9F, 23F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(770, 593);
        Controls.Add(button1);
        Controls.Add(CancelButton);
        Controls.Add(Commands);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "Main";
        Text = "Command Dictionary";
        Commands.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    public ListView DictionaryListView;
    private GroupBox Commands;
    private Button copyButton;
    private Button CancelButton;
    private Button DeleteButton;
    private Button EditButton;
    private Button NewButton;
    private Button button1;
}
