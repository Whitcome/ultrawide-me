using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (hex.Contains(sixteenByNineHexValue))
            {
                hex.Replace(sixteenByNineHexValue, "8E-E3-18-40");
            }
            MessageBox.Show("Opened " + openFileDialog.FileName);
        }
    }
}
