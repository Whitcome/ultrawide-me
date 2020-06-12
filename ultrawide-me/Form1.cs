using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ultrawide_me
{
    public partial class Form1 : Form
    {
        private const string sixteenByNineHexValue = "39-8E-E3-3F";

        private byte[] openedFileBytes;
        private byte[] newFileBytes;

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void GetFileInformation(object sender, CancelEventArgs e)
        {
            // TODO: Error handling
            openedFileBytes = File.ReadAllBytes(openFileDialog.FileName);
            openFileNameLabel.Text = openFileDialog.SafeFileName;
            convertButton.Enabled = true;
        }

        private void ProcessFile(object sender, EventArgs e)
        {
            if (openedFileBytes != null && openedFileBytes.Length > 0)
            {
                var openedFileHexValue = BitConverter.ToString(openedFileBytes);
                if (openedFileHexValue.Contains(sixteenByNineHexValue))
                {
                    // TODO: Support other monitor sizes
                    // TODO: Modify to support other games
                    openedFileHexValue = openedFileHexValue.Replace(sixteenByNineHexValue, "8E-E3-18-40");
                    newFileBytes = openedFileHexValue.Split('-').Select(hexValue => Convert.ToByte(hexValue, 16)).ToArray();
                    saveButton.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Could not convert");
                }
            }
        }

        private void ShowSaveDialog(object sender, EventArgs e)
        {
            saveFileDialog.FileName = openFileDialog.SafeFileName;
            saveFileDialog.ShowDialog();
        }

        private void SaveFile(object sender, CancelEventArgs e)
        {
            File.WriteAllBytes(saveFileDialog.FileName, newFileBytes);
        }
    }
}
