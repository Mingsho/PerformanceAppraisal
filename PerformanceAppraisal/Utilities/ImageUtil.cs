using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.IO;


namespace PerformanceAppraisal.Utilities
{
    public class ImageUtil
    {

        public static byte[] ReadFile(HttpPostedFile file)
        {
            byte[] data = new Byte[file.ContentLength];

            file.InputStream.Read(data, 0, file.ContentLength);

            return data;

        }

        public static System.Drawing.Image ConvertByteArrayToImage(byte[] bytArray)
        {
            MemoryStream ms = new MemoryStream(bytArray);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
            return image;
        }

        public static bool IsByteArrayValid(byte[] bytArr)
        {
            if (bytArr == null) return false;

            
            for(int i=0; i<bytArr.Length;i++)
            {
                if (bytArr[i] == 0) return false;   
            }
            
            return true;
        }
    }
}