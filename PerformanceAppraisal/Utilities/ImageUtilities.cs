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
            
            try
            {
                MemoryStream ms = new MemoryStream(bytArray);
                System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
                return image;
                
            }
            catch (ArgumentException ex)
            {
                
                throw ex;
            }

        }

       
    }
}