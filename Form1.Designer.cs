
namespace Pliczki
{
    partial class Form1
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
            this.FileContentBox = new System.Windows.Forms.TextBox();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.withoutFormat = new System.Windows.Forms.TabPage();
            this.withFormat = new System.Windows.Forms.TabPage();
            this.FontBox = new System.Windows.Forms.GroupBox();
            this.italicBoldFontButton = new System.Windows.Forms.RadioButton();
            this.regularFontButton = new System.Windows.Forms.RadioButton();
            this.italicFontButton = new System.Windows.Forms.RadioButton();
            this.boldFontButton = new System.Windows.Forms.RadioButton();
            this.ColorButton = new System.Windows.Forms.Button();
            this.SaveFileButton_RTF = new System.Windows.Forms.Button();
            this.OpenFileButton_RTF = new System.Windows.Forms.Button();
            this.FontButton = new System.Windows.Forms.Button();
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.tabControl.SuspendLayout();
            this.withoutFormat.SuspendLayout();
            this.withFormat.SuspendLayout();
            this.FontBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileContentBox
            // 
            this.FileContentBox.Location = new System.Drawing.Point(23, 28);
            this.FileContentBox.Multiline = true;
            this.FileContentBox.Name = "FileContentBox";
            this.FileContentBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FileContentBox.Size = new System.Drawing.Size(478, 344);
            this.FileContentBox.TabIndex = 0;
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(605, 129);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(75, 23);
            this.OpenFileButton.TabIndex = 1;
            this.OpenFileButton.Text = "Open";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Location = new System.Drawing.Point(605, 215);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(75, 23);
            this.SaveFileButton.TabIndex = 2;
            this.SaveFileButton.Text = "Save";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.withoutFormat);
            this.tabControl.Controls.Add(this.withFormat);
            this.tabControl.Location = new System.Drawing.Point(12, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 425);
            this.tabControl.TabIndex = 3;
            // 
            // withoutFormat
            // 
            this.withoutFormat.Controls.Add(this.FileContentBox);
            this.withoutFormat.Controls.Add(this.SaveFileButton);
            this.withoutFormat.Controls.Add(this.OpenFileButton);
            this.withoutFormat.Location = new System.Drawing.Point(4, 24);
            this.withoutFormat.Name = "withoutFormat";
            this.withoutFormat.Padding = new System.Windows.Forms.Padding(3);
            this.withoutFormat.Size = new System.Drawing.Size(768, 397);
            this.withoutFormat.TabIndex = 0;
            this.withoutFormat.Text = "Without formatting";
            this.withoutFormat.UseVisualStyleBackColor = true;
            // 
            // withFormat
            // 
            this.withFormat.Controls.Add(this.FontBox);
            this.withFormat.Controls.Add(this.ColorButton);
            this.withFormat.Controls.Add(this.SaveFileButton_RTF);
            this.withFormat.Controls.Add(this.OpenFileButton_RTF);
            this.withFormat.Controls.Add(this.FontButton);
            this.withFormat.Controls.Add(this.RichTextBox);
            this.withFormat.Location = new System.Drawing.Point(4, 24);
            this.withFormat.Name = "withFormat";
            this.withFormat.Padding = new System.Windows.Forms.Padding(3);
            this.withFormat.Size = new System.Drawing.Size(768, 397);
            this.withFormat.TabIndex = 1;
            this.withFormat.Text = "With formatting";
            this.withFormat.UseVisualStyleBackColor = true;
            // 
            // FontBox
            // 
            this.FontBox.Controls.Add(this.italicBoldFontButton);
            this.FontBox.Controls.Add(this.regularFontButton);
            this.FontBox.Controls.Add(this.italicFontButton);
            this.FontBox.Controls.Add(this.boldFontButton);
            this.FontBox.Location = new System.Drawing.Point(637, 20);
            this.FontBox.Name = "FontBox";
            this.FontBox.Size = new System.Drawing.Size(116, 124);
            this.FontBox.TabIndex = 8;
            this.FontBox.TabStop = false;
            this.FontBox.Text = "Font";
            // 
            // italicBoldFontButton
            // 
            this.italicBoldFontButton.AutoSize = true;
            this.italicBoldFontButton.Location = new System.Drawing.Point(10, 98);
            this.italicBoldFontButton.Name = "italicBoldFontButton";
            this.italicBoldFontButton.Size = new System.Drawing.Size(100, 19);
            this.italicBoldFontButton.TabIndex = 8;
            this.italicBoldFontButton.TabStop = true;
            this.italicBoldFontButton.Text = "Bold and Italic";
            this.italicBoldFontButton.UseVisualStyleBackColor = true;
            this.italicBoldFontButton.CheckedChanged += new System.EventHandler(this.FontButton_CheckedChanged);
            // 
            // regularFontButton
            // 
            this.regularFontButton.AutoSize = true;
            this.regularFontButton.Location = new System.Drawing.Point(10, 22);
            this.regularFontButton.Name = "regularFontButton";
            this.regularFontButton.Size = new System.Drawing.Size(65, 19);
            this.regularFontButton.TabIndex = 5;
            this.regularFontButton.TabStop = true;
            this.regularFontButton.Text = "Regular";
            this.regularFontButton.UseVisualStyleBackColor = true;
            this.regularFontButton.CheckedChanged += new System.EventHandler(this.FontButton_CheckedChanged);
            // 
            // italicFontButton
            // 
            this.italicFontButton.AutoSize = true;
            this.italicFontButton.Location = new System.Drawing.Point(10, 73);
            this.italicFontButton.Name = "italicFontButton";
            this.italicFontButton.Size = new System.Drawing.Size(50, 19);
            this.italicFontButton.TabIndex = 7;
            this.italicFontButton.TabStop = true;
            this.italicFontButton.Text = "Italic";
            this.italicFontButton.UseVisualStyleBackColor = true;
            this.italicFontButton.CheckedChanged += new System.EventHandler(this.FontButton_CheckedChanged);
            // 
            // boldFontButton
            // 
            this.boldFontButton.AutoSize = true;
            this.boldFontButton.Location = new System.Drawing.Point(10, 47);
            this.boldFontButton.Name = "boldFontButton";
            this.boldFontButton.Size = new System.Drawing.Size(49, 19);
            this.boldFontButton.TabIndex = 6;
            this.boldFontButton.TabStop = true;
            this.boldFontButton.Text = "Bold";
            this.boldFontButton.UseVisualStyleBackColor = true;
            this.boldFontButton.CheckedChanged += new System.EventHandler(this.FontButton_CheckedChanged);
            // 
            // ColorButton
            // 
            this.ColorButton.Location = new System.Drawing.Point(522, 150);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(95, 22);
            this.ColorButton.TabIndex = 4;
            this.ColorButton.Text = "Change color";
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // SaveFileButton_RTF
            // 
            this.SaveFileButton_RTF.Location = new System.Drawing.Point(522, 57);
            this.SaveFileButton_RTF.Name = "SaveFileButton_RTF";
            this.SaveFileButton_RTF.Size = new System.Drawing.Size(95, 23);
            this.SaveFileButton_RTF.TabIndex = 3;
            this.SaveFileButton_RTF.Text = "Save";
            this.SaveFileButton_RTF.UseVisualStyleBackColor = true;
            this.SaveFileButton_RTF.Click += new System.EventHandler(this.SaveFileButton_RTF_Click);
            // 
            // OpenFileButton_RTF
            // 
            this.OpenFileButton_RTF.Location = new System.Drawing.Point(522, 16);
            this.OpenFileButton_RTF.Name = "OpenFileButton_RTF";
            this.OpenFileButton_RTF.Size = new System.Drawing.Size(95, 23);
            this.OpenFileButton_RTF.TabIndex = 2;
            this.OpenFileButton_RTF.Text = "Open";
            this.OpenFileButton_RTF.UseVisualStyleBackColor = true;
            this.OpenFileButton_RTF.Click += new System.EventHandler(this.OpenFileButton_RTF_Click);
            // 
            // FontButton
            // 
            this.FontButton.Location = new System.Drawing.Point(522, 105);
            this.FontButton.Name = "FontButton";
            this.FontButton.Size = new System.Drawing.Size(95, 23);
            this.FontButton.TabIndex = 1;
            this.FontButton.Text = "Change font";
            this.FontButton.UseVisualStyleBackColor = true;
            this.FontButton.Click += new System.EventHandler(this.FontButton_Click);
            // 
            // RichTextBox
            // 
            this.RichTextBox.Location = new System.Drawing.Point(26, 16);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RichTextBox.Size = new System.Drawing.Size(478, 366);
            this.RichTextBox.TabIndex = 0;
            this.RichTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.withoutFormat.ResumeLayout(false);
            this.withoutFormat.PerformLayout();
            this.withFormat.ResumeLayout(false);
            this.FontBox.ResumeLayout(false);
            this.FontBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox FileContentBox;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage withoutFormat;
        private System.Windows.Forms.TabPage withFormat;
        private System.Windows.Forms.Button FontButton;
        private System.Windows.Forms.RichTextBox RichTextBox;
        private System.Windows.Forms.Button SaveFileButton_RTF;
        private System.Windows.Forms.Button OpenFileButton_RTF;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.RadioButton regularFontButton;
        private System.Windows.Forms.RadioButton boldFontButton;
        private System.Windows.Forms.RadioButton italicFontButton;
        private System.Windows.Forms.GroupBox FontBox;
        private System.Windows.Forms.RadioButton italicBoldFontButton;
    }
}

