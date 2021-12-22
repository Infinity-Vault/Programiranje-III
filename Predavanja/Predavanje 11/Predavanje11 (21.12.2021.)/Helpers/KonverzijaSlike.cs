using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Helpers
{
    internal static  class KonverzijaSlike//Klasa je static jer nema svrhe da postoje entiteti ove klase;
    {
        //Konverzija iz Image u byte[]:
        public static byte[] ImageToByte(Image slika)
        {
            var memoryStream=new MemoryStream();//Kreiramo empty memory stream;
            slika.Save(memoryStream,ImageFormat.Jpeg);//Spasimo sliku u memory stream koji smo napravili, u Jpeg formatu;
            return memoryStream.ToArray();//Vratimo stream u obliku niza;
        }
        //Konverzija iz byte[] u Image:
        public static Image ByteToImage(byte[] ulazniStream)
        {
            var memoryStream=new MemoryStream(ulazniStream);//Kreiramo memory stream na osnovu ulaznog niza bajta;
            return Image.FromStream(memoryStream);//Kreiramo sliku od niza bajta i vratimo je;
        }
    }

}
