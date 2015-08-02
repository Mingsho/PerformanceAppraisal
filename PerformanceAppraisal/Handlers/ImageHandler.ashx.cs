using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.IO;
using PA.BLL;
using PerformanceAppraisal.Utilities;

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
                    System.Drawing.Image image = ImageUtil.ConvertByteArrayToImage(storedImage);

                    if(image!=null)
                    {
                        context.Response.ContentType = "image/jpeg";
                        image.Save(context.Response.OutputStream, System.Drawing.Imaging.ImageFormat.Jpeg);
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