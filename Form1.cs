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
            Stream myStream = null;

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
                    if (openFileDialog.OpenFile() != null) {

                        using (StreamReader fileReader = new StreamReader(openFileDialog.OpenFile()))
                        {
                            myStream = fileReader.ReadToEnd();
                        }
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {

        }
    }
}
