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

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void ProcessFile(object sender, CancelEventArgs e)
        {
            // TODO: Move all this logic
            var hex = BitConverter.ToString(File.ReadAllBytes(openFileDialog.FileName));

            MessageBox.Show("Opened " + openFileDialog.FileName);

            openFileNameLabel.Text = openFileDialog.SafeFileName;

            if (hex.Contains(sixteenByNineHexValue))
            {
                hex = hex.Replace(sixteenByNineHexValue, "8E-E3-18-40");
            }

            var newFileBytes = hex.Split('-').Select(hexValue => Convert.ToByte(hexValue, 16)).ToArray();

            saveFileDialog.FileName = openFileDialog.SafeFileName;
            saveFileDialog.ShowDialog();

            File.WriteAllBytes(saveFileDialog.FileName, newFileBytes);

            MessageBox.Show("Saved " + saveFileDialog.FileName);
        }
    }
}
