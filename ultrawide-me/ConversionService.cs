using System;

namespace ultrawide_me
{
    class ConversionService
    {
        private readonly byte[] bytesToReplace;

        public ConversionService()
        {
            float width = 1920;
            float height = 1080;
            bytesToReplace = BitConverter.GetBytes(width / height);
        }

        public void ProcessFile(byte[] openedFileBytes, float width, float height)
        {
            var resolutionBytes = BitConverter.GetBytes(width / height);
            for (int i = 0; i < openedFileBytes.Length - 3; i++)
            {
                if (openedFileBytes[i] == bytesToReplace[0] &&
                    openedFileBytes[i + 1] == bytesToReplace[1] &&
                    openedFileBytes[i + 2] == bytesToReplace[2] &&
                    openedFileBytes[i + 3] == bytesToReplace[3])
                {
                    openedFileBytes[i] = resolutionBytes[0];
                    openedFileBytes[i + 1] = resolutionBytes[1];
                    openedFileBytes[i + 2] = resolutionBytes[2];
                    openedFileBytes[i + 3] = resolutionBytes[3];
                }
            }
        }
    }
}
