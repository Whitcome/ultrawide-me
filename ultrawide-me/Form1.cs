using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace ultrawide_me
{
    public partial class Form1 : Form
    {
        readonly ConversionService conversionService;
        
        private byte[] fileBytes;

        public Form1()
        {
            InitializeComponent();
            conversionService = new ConversionService();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void GetFileInformation(object sender, CancelEventArgs e)
        {
            // TODO: Error handling
            fileBytes = File.ReadAllBytes(openFileDialog.FileName);
            GC.Collect();
            openFileNameLabel.Text = openFileDialog.SafeFileName;
            convertButton.Enabled = true;
        }

        private void ProcessFile(object sender, EventArgs e)
        {
            conversionService.ProcessFile(fileBytes, 3440, 1440);
            saveButton.Enabled = true;
        }

        private void ShowSaveDialog(object sender, EventArgs e)
        {
            saveFileDialog.FileName = openFileDialog.SafeFileName;
            saveFileDialog.ShowDialog();
        }

        private void SaveFile(object sender, CancelEventArgs e)
        {
            File.WriteAllBytes(saveFileDialog.FileName, fileBytes);
            Reset();
        }

        private void Reset()
        {
            openFileNameLabel.Text = "No file selected";
            convertButton.Enabled = false;
            saveButton.Enabled = false;
            fileBytes = null;
        }
    }
}
