using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PA.BLL;
using PA.BLL.DTO;

namespace PerformanceAppraisal.Controls
{
    public partial class UserRolesControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmployeeBLL empLogic = new EmployeeBLL();

            if(!Page.IsPostBack)
            {
                //get employee id from the query string.
                if(Request.QueryString["Id"]!=null)
                {
                    int nEmpId = int.Parse(Request.QueryString["Id"]);

                    Employee employee = empLogic.GetEmployee(nEmpId);

                    lblEmpId.Text = employee.EmployeeID.ToString();
                    lblEmpName.Text = employee.Firstname + " " + employee.Lastname;
                    
                }
            }
        }
    }
}