using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahora_si.clases
{
    internal class ImagenConvert
    {
        public static int peso = 40;
        public byte[] imagenToByte(Image img)
        {
            if(img == null)
            {
                return null;
            }
            MemoryStream memoria = new MemoryStream();
            img.Save(memoria, ImageFormat.Png);
            return memoria.ToArray();
        
        }

        public Image bitmapToimagen(Bitmap bmp)
        {
            MemoryStream memoria = new MemoryStream();
            bmp.Save(memoria, ImageFormat.Png);
            return Image.FromStream(memoria);
        }
    }
}
