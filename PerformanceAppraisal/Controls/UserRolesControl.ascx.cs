using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using PA.BLL;
using PA.BLL.DTO;

namespace PerformanceAppraisal.Controls
{
    public partial class UserRolesControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmployeeBLL empLogic = new EmployeeBLL();
            DepartmentBLL deptLogic=new DepartmentBLL();

            if(!Page.IsPostBack)
            {
                //get employee id from the query string.
                if(Request.QueryString["Id"]!=null)
                {
                    int nEmpId = int.Parse(Request.QueryString["Id"]);

                    Employee employee = empLogic.GetEmployee(nEmpId);
                   
                    Department department = deptLogic.GetDepartment(employee.DepartmentID.GetValueOrDefault());

                    lblEmpId.Text = employee.EmployeeID.ToString();
                    lblEmpName.Text = employee.Firstname + " " + employee.Lastname;
                    lblDepartment.Text = department.Departmentname;

                    MembershipUser user = Membership.GetUser(employee.UserAccountID.GetValueOrDefault());

                    string[] userRoles = Roles.GetRolesForUser(user.UserName);

                    string[] arrRoles = Roles.GetAllRoles();

                    foreach(string role in arrRoles)
                    {
                        
                        int nIndex=0;

                        CheckBox chkTemp = new CheckBox();
                        chkTemp.ID = "chkRole" + nIndex;
                        chkTemp.Text = role;

                        foreach(string userRole in userRoles)
                        {
                            if (userRole.Equals(role))
                                chkTemp.Checked = true;
                            
                        }

                        pnlRoles.Controls.Add(chkTemp);

                        nIndex++;
                    }
                 
                }
            }
        }
    }
}