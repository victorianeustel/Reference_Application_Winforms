﻿namespace CommandDictionary.Forms;

partial class EditEntryForm
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
        DescriptionTextBox = new TextBox();
        ApplicationComboBox = new ComboBox();
        CategoryComboBox = new ComboBox();
        CancelButton = new Button();
        SaveChangesButton = new Button();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        CommandTextBox = new TextBox();
        SuspendLayout();
        // 
        // DescriptionTextBox
        // 
        DescriptionTextBox.Location = new Point(124, 107);
        DescriptionTextBox.Name = "DescriptionTextBox";
        DescriptionTextBox.Size = new Size(641, 27);
        DescriptionTextBox.TabIndex = 19;
        // 
        // ApplicationComboBox
        // 
        ApplicationComboBox.FormattingEnabled = true;
        ApplicationComboBox.Location = new Point(124, 30);
        ApplicationComboBox.Name = "ApplicationComboBox";
        ApplicationComboBox.Size = new Size(204, 28);
        ApplicationComboBox.TabIndex = 18;
        // 
        // CategoryComboBox
        // 
        CategoryComboBox.FormattingEnabled = true;
        CategoryComboBox.Location = new Point(124, 69);
        CategoryComboBox.Name = "CategoryComboBox";
        CategoryComboBox.Size = new Size(147, 28);
        CategoryComboBox.TabIndex = 17;
        // 
        // CancelButton
        // 
        CancelButton.Location = new Point(658, 179);
        CancelButton.Name = "CancelButton";
        CancelButton.Size = new Size(94, 29);
        CancelButton.TabIndex = 16;
        CancelButton.Text = "Cancel";
        CancelButton.UseVisualStyleBackColor = true;
        CancelButton.Click += CancelButton_Click;
        // 
        // SaveChangesButton
        // 
        SaveChangesButton.Location = new Point(527, 179);
        SaveChangesButton.Name = "SaveChangesButton";
        SaveChangesButton.Size = new Size(125, 29);
        SaveChangesButton.TabIndex = 15;
        SaveChangesButton.Text = "&Save Changes";
        SaveChangesButton.UseVisualStyleBackColor = true;
        SaveChangesButton.Click += SaveChangesButton_Click;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label4.Location = new Point(33, 146);
        label4.Name = "label4";
        label4.Size = new Size(85, 20);
        label4.TabIndex = 14;
        label4.Text = "Command:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label3.Location = new Point(25, 107);
        label3.Name = "label3";
        label3.Size = new Size(93, 20);
        label3.TabIndex = 13;
        label3.Text = "Description:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label2.Location = new Point(41, 72);
        label2.Name = "label2";
        label2.Size = new Size(77, 20);
        label2.TabIndex = 12;
        label2.Text = "Category:";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label1.Location = new Point(25, 34);
        label1.Name = "label1";
        label1.Size = new Size(93, 20);
        label1.TabIndex = 11;
        label1.Text = "Application:";
        // 
        // CommandTextBox
        // 
        CommandTextBox.Location = new Point(124, 143);
        CommandTextBox.Name = "CommandTextBox";
        CommandTextBox.Size = new Size(641, 27);
        CommandTextBox.TabIndex = 0;
        // 
        // EditEntryForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 220);
        Controls.Add(DescriptionTextBox);
        Controls.Add(ApplicationComboBox);
        Controls.Add(CategoryComboBox);
        Controls.Add(CancelButton);
        Controls.Add(SaveChangesButton);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(CommandTextBox);
        Name = "EditEntryForm";
        Text = "Edit Command";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox DescriptionTextBox;
    private ComboBox ApplicationComboBox;
    private ComboBox CategoryComboBox;
    private Button CancelButton;
    private Button SaveChangesButton;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private TextBox CommandTextBox;
}