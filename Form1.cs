using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pliczki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            Stream stream = null;

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                RestoreDirectory = true,
                Title = "Open Text Files",
                DefaultExt = "txt",
                Filter = "Txt files (*.txt)|*.txt|All files (*.*)|*.*",
                CheckFileExists = true,
                CheckPathExists = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((stream = openFileDialog.OpenFile()) != null) {

                        using (StreamReader fileReader = new StreamReader(openFileDialog.FileName))
                        {
                            string line;

                            FileContentBox.Text = "";

                            while((line = fileReader.ReadLine()) != null)
                            { 
                                FileContentBox.Text += line + "\r\n";
                            }

                            fileReader.Close();
                        }
                    }
                    stream.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                    stream.Close();
                }
            }
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = @"C:\",
                RestoreDirectory = true,
                Title = "Open Text Files",
                DefaultExt = "txt",
                Filter = "Txt files (*.txt)|*.txt|All files (*.*)|*.*",
                CheckPathExists = true
            };

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter fileWriter = new StreamWriter(saveFileDialog.OpenFile());

                    if (FileContentBox.Text != null)
                    {
                        fileWriter.Write(FileContentBox.Text);
                    }

                    fileWriter.Flush();
                    fileWriter.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }
        }

        private void FontButton_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog
            {
                ShowEffects = true,
                ShowHelp = true,
                MinSize = 6,
                MaxSize = 100,
            };

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                RichTextBox.SelectionFont = dialog.Font;
                RichTextBox.SelectionColor = dialog.Color;
            }
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog
            {
                AllowFullOpen = true,
                AnyColor = true,
                SolidColorOnly = false,
                Color = Color.Black
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                RichTextBox.SelectionColor = dialog.Color;
            }
        }

        private void OpenFileButton_RTF_Click(object sender, EventArgs e)
        {
            Stream stream = null;

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                RestoreDirectory = true,
                Title = "Open Rtf Files",
                DefaultExt = "rtf",
                Filter = "Rtf files (*.rtf)|*.rtf|All files (*.*)|*.*",
                CheckFileExists = true,
                CheckPathExists = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((stream = openFileDialog.OpenFile()) != null)
                    {
                        RichTextBox.Text = "";
                        RichTextBox.LoadFile(openFileDialog.FileName);
                    }
                    stream.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                    stream.Close();
                }
            }
        }

        private void SaveFileButton_RTF_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = @"C:\",
                RestoreDirectory = true,
                Title = "Open Rtf Files",
                DefaultExt = "rtf",
                Filter = "Rtf files (*.rtf)|*.rtf|All files (*.*)|*.*",
                CheckPathExists = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter fileWriter = new StreamWriter(saveFileDialog.OpenFile());

                    if (RichTextBox.Rtf != null)
                    {
                        fileWriter.Write(RichTextBox.Rtf);
                    }

                    fileWriter.Flush();
                    fileWriter.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }
        }

        private void FontButton_CheckedChanged(object sender, EventArgs e)
        {
            var selectedFont = FontBox.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);

            int selStart = RichTextBox.SelectionStart;
            int selLength = RichTextBox.SelectionLength;

            switch (selectedFont.Name)
            {
                case "regularFontButton":
                    {
                        RichTextBox.SelectionFont = new Font(RichTextBox.Font, FontStyle.Regular);
                        break;
                    }

                case "boldFontButton":
                    {
                        RichTextBox.SelectionFont = new Font(RichTextBox.Font, FontStyle.Bold);
                        break;
                    }

                case "italicFontButton":
                    {
                        RichTextBox.SelectionFont = new Font(RichTextBox.Font, FontStyle.Italic);
                        break;
                    }


                case "italicBoldFontButton":
                    {
                        RichTextBox.SelectionFont = new Font(RichTextBox.Font, FontStyle.Italic | FontStyle.Bold);
                        break;
                    }
            }

            RichTextBox.SelectionStart = RichTextBox.SelectionStart + RichTextBox.SelectionLength;
            RichTextBox.SelectionLength = 0;
            RichTextBox.SelectionFont = RichTextBox.Font;
            RichTextBox.Select(selStart, selLength);
        }
    }
}

/*
 * int selstart = richTextBox1.SelectionStart;
 * int sellength = richTextBox1.SelectionLength;
 * 
 * richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
 * richTextBox1.SelectionStart = richTextBox1.SelectionStart + richTextBox1.SelectionLength;
 * richTextBox1.SelectionLength = 0;
 * richTextBox1.SelectionFont = richTextBox1.Font;
 * 
 * richTextBox1.Select(selstart, sellength);
 */