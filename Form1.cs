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
                ShowApply = true,
                ShowColor = true,
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

        }
    }
}
