using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class Processing
    {
        public Processing()
        {

        }
        public static bool ConvertToGrey(Bitmap bitmap)
        {
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color color = bitmap.GetPixel(i, j);
                    //int grey = (byte)(128 * color.R + 128 * color.G + 128 * color.B);
                    int grey = (byte)(.299 * color.R + .587 * color.G + .114 * color.B);
                    bitmap.SetPixel(i, j, Color.FromArgb(grey, grey, grey));
                }
            }

            return true;

        }
    }
}
