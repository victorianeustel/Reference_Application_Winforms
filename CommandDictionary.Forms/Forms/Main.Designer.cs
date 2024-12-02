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
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
        DictionaryListView = new ListView();
        Commands = new GroupBox();
        DeleteButton = new Button();
        EditButton = new Button();
        NewButton = new Button();
        copyButton = new Button();
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
        DictionaryListView.Location = new Point(16, 26);
        DictionaryListView.MultiSelect = false;
        DictionaryListView.Name = "DictionaryListView";
        DictionaryListView.Size = new Size(611, 323);
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
        Commands.Location = new Point(22, 34);
        Commands.Name = "Commands";
        Commands.Size = new Size(640, 409);
        Commands.TabIndex = 1;
        Commands.TabStop = false;
        Commands.Text = "Commands";
        // 
        // DeleteButton
        // 
        DeleteButton.Location = new Point(533, 360);
        DeleteButton.Name = "DeleteButton";
        DeleteButton.Size = new Size(94, 29);
        DeleteButton.TabIndex = 4;
        DeleteButton.Text = "&Delete";
        DeleteButton.UseVisualStyleBackColor = true;
        DeleteButton.Click += DeleteButton_Click;
        // 
        // EditButton
        // 
        EditButton.Location = new Point(433, 360);
        EditButton.Name = "EditButton";
        EditButton.Size = new Size(94, 29);
        EditButton.TabIndex = 3;
        EditButton.Text = "&Edit...";
        EditButton.UseVisualStyleBackColor = true;
        EditButton.Click += EditButton_Click;
        // 
        // NewButton
        // 
        NewButton.Location = new Point(333, 360);
        NewButton.Name = "NewButton";
        NewButton.Size = new Size(94, 29);
        NewButton.TabIndex = 2;
        NewButton.Text = "&New...";
        NewButton.UseVisualStyleBackColor = true;
        NewButton.Click += NewButton_Click;
        // 
        // copyButton
        // 
        copyButton.Location = new Point(16, 360);
        copyButton.Name = "copyButton";
        copyButton.Size = new Size(153, 29);
        copyButton.TabIndex = 1;
        copyButton.Text = "&Copy Command";
        copyButton.UseVisualStyleBackColor = true;
        copyButton.Click += copyButton_Click;
        // 
        // CancelButton
        // 
        CancelButton.Location = new Point(568, 467);
        CancelButton.Name = "CancelButton";
        CancelButton.Size = new Size(94, 29);
        CancelButton.TabIndex = 2;
        CancelButton.Text = "&Cancel";
        CancelButton.UseVisualStyleBackColor = true;
        CancelButton.Click += CancelButton_Click;
        // 
        // Main
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(684, 516);
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
}
