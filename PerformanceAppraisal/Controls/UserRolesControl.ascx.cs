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

            Employee employee=null;
            Department department=null;

            int nEmpId = 0;

            if(!Page.IsPostBack)
            {
                //get employee id from the query string.
                if(Request.QueryString["Id"]!=null)
                {
                    nEmpId = int.Parse(Request.QueryString["Id"]);
                    ViewState["EmpId"] = nEmpId;

                }
            }

            if (nEmpId == 0)
                nEmpId = int.Parse(ViewState["EmpId"].ToString());

            employee = empLogic.GetEmployee(nEmpId);

            department = deptLogic.GetDepartment(employee.DepartmentID.GetValueOrDefault());

            lblEmpId.Text = employee.EmployeeID.ToString();
            lblEmpName.Text = employee.Firstname + " " + employee.Lastname;
            lblDepartment.Text = department.Departmentname;

            MembershipUser user = Membership.GetUser(employee.UserAccountID.GetValueOrDefault());

            string[] userRoles = Roles.GetRolesForUser(user.UserName);

            string[] arrRoles = Roles.GetAllRoles();

            int nIndex = 0;

            foreach(string role in arrRoles)
            {
                  
                CheckBox chkTemp = new CheckBox();
                chkTemp.ID = "chkRole" + nIndex;
                chkTemp.Text = role;
                chkTemp.AutoPostBack = true;
                chkTemp.CheckedChanged += chkTemp_CheckedChanged;

                foreach(string userRole in userRoles)
                {
                    if (userRole.Equals(role))
                        chkTemp.Checked = true;
                }
                        
                pnlRoles.Controls.Add(chkTemp);

                nIndex++;
            }
                 
        }
            
        

        void chkTemp_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;

            if (chk.Text.Equals("SuperAdmin"))
                Response.Write("SuperAdmin");
            else
                Response.Write("User");
        }

        
    }
}