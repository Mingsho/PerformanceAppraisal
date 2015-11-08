using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.IO;
using PA.BLL;
using PerformanceAppraisal.Utilities;
using System.Drawing.Imaging;

namespace PerformanceAppraisal.Handlers
{
    /// <summary>
    /// A generic handler to return image from an object in the session state.
    /// </summary>
    public class ImageHandler : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Clear();
            
            if(context.Session[EmployeeBLL.STORED_IMAGE]!=null)
            {
                var storedImage = context.Session[EmployeeBLL.STORED_IMAGE] as byte[];

                if(storedImage!=null)
                {
                    
                    System.Drawing.Image image = ImageUtilities.ConvertByteArrayToImage(storedImage);

                    if(image!=null)
                    {
                        //get image mime-type
                        ImageFormat format = image.RawFormat;
                        ImageCodecInfo codec = ImageCodecInfo.GetImageDecoders().First(c => c.FormatID == format.Guid);
                        string mimeType = codec.MimeType;

                        context.Response.ContentType = mimeType;
                        image.Save(context.Response.OutputStream, format);
                        
                    }
                }
            }
            
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}