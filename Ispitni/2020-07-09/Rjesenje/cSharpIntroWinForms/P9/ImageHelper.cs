using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroWinForms.P9
{
    public class ImageHelper
    {
        public static byte[] FromImageToByte(Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }
        public static Image FromByteToImage(byte[] image)
        {
            MemoryStream ms = new MemoryStream(image);
            return Image.FromStream(ms);
        }
    }
}
