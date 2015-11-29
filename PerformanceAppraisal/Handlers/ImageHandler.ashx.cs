using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.IO;
using PA.BLL;
using PerformanceAppraisal.Utilities;
using System.Drawing.Imaging;
using PA.BLL.DTO;

namespace PerformanceAppraisal.Handlers
{
    /// <summary>
    /// A generic handler to return image
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
                //clear this session.
                context.Session.Remove(EmployeeBLL.STORED_IMAGE);
            }

            else if(context.Request.QueryString["empId"]!=null)
            {
                string employeeID = context.Request.QueryString["empId"];

                EmployeeBLL empLogic = new EmployeeBLL();
                Employee emp = new Employee();

                try
                {
                    if (!string.IsNullOrEmpty(employeeID))
                    {
                        int nEmpID = int.Parse(employeeID);

                        emp = empLogic.GetEmployee(nEmpID);
                    }

                    //context.Response.ContentType = "image/jpeg";
                    if (emp.ProfileImage != null)
                        context.Response.BinaryWrite(emp.ProfileImage);
                }
                catch (Exception)
                {

                    throw;
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