using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PA.BLL;
using PA.BLL.DTO;

namespace PerformanceAppraisal.Handlers
{
    /// <summary>
    /// Summary description for Handler1
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
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
                if(emp.ProfileImage!=null)
                    context.Response.BinaryWrite(emp.ProfileImage);
            }
            catch (Exception)
            {
                
                throw;
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