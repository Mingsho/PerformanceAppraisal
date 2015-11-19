using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.IO;


namespace PerformanceAppraisal.Utilities
{
    public class ImageUtilities
    {

        public static byte[] ReadFile(HttpPostedFile file)
        {

            byte[] buffer = new Byte[file.ContentLength];
            file.InputStream.Read(buffer, 0, file.ContentLength);

            return buffer;

            
        }

        public static System.Drawing.Image ConvertByteArrayToImage(byte[] bytArray)
        {
            MemoryStream ms = new MemoryStream(bytArray);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
            return image;
        }

        //public static bool IsByteArrayValid(byte[] bytArr)
        //{
        //    if (bytArr == null) return false;

            
        //    for(int i=0; i<bytArr.Length;i++)
        //    {
        //        if (bytArr[i] == 0) return false;   
        //    }
            
        //    return true;
        //}
    }
}