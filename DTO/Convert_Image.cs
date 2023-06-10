using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.DTO
{
    public class Convert_Image
    {
        public static byte[] ConvertByte(Image img)
        {
            if (img != null)
            {
                MemoryStream ms = new MemoryStream();
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
            else return null;
        }

        public static Image ConvertImage(byte[] arr)
        {
            if (arr != null)
            {
                MemoryStream ms = new MemoryStream(arr);
                Image image = Image.FromStream(ms);
                return image;
            }
            else return null;
        }
 

    }
}
