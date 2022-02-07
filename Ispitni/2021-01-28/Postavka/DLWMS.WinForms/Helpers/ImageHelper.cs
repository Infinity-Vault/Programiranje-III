using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace DLWMS.WinForms.Helpers
{
    public class ImageHelper
    {
        public static byte[] FromImageToByte(Image slika)
        {
            MemoryStream ms = new MemoryStream();
            slika.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }
        public static Image FromByteToImage(byte[] slika)
        {
            MemoryStream ms = new MemoryStream(slika);
            return Image.FromStream(ms);           
        }
    }
}
