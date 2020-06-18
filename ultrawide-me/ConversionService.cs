using System;
using System.Linq;
using System.Windows.Forms;

namespace ultrawide_me
{
    class ConversionService
    {
        private const string sixteenByNineHexValue = "39-8E-E3-3F";

        public byte[] ProcessFile(byte[] openedFileBytes)
        {
            var openedFileHexValue = BitConverter.ToString(openedFileBytes);
            if (openedFileHexValue.Contains(sixteenByNineHexValue))
            {
                // TODO: Support other monitor sizes
                // TODO: Modify to support other games
                openedFileHexValue = openedFileHexValue.Replace(sixteenByNineHexValue, "8E-E3-18-40");
                return openedFileHexValue.Split('-').Select(hexValue => Convert.ToByte(hexValue, 16)).ToArray();
            }
            else
            {
                MessageBox.Show("Could not convert");
                return openedFileBytes;
            }
        }
    }
}
