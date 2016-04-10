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

        private int EmployeeID
        {
            get
            {
                return (int)ViewState["EmpID"];
            }
            set
            {
                ViewState["EmpID"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if(!Page.IsPostBack)
                this.EmployeeID = int.Parse(Request.QueryString["Id"]);

            LoadEmployeeDefaultValues();
     
        }

        public void LoadEmployeeDefaultValues()
        {
            EmployeeBLL empLogic = new EmployeeBLL();
            DepartmentBLL deptLogic = new DepartmentBLL();

            Employee employee = empLogic.GetEmployee(this.EmployeeID);

            Department department = deptLogic.GetDepartment(employee.DepartmentID.GetValueOrDefault());

            lblEmpId.Text = employee.EmployeeID.ToString();

            if (!string.IsNullOrEmpty(employee.Middlename))
                lblEmpName.Text = employee.Firstname + " " + employee.Middlename + " " + employee.Lastname;
            else
                lblEmpName.Text = employee.Firstname + " " + employee.Lastname;

            lblDepartment.Text = department.Departmentname;

            MembershipUser user = Membership.GetUser(employee.UserAccountID.GetValueOrDefault());

            string[] userRoles = Roles.GetRolesForUser(user.UserName);

            string[] arrRoles = Roles.GetAllRoles();

            int nIndex = 0;

            foreach (string role in arrRoles)
            {

                CheckBox chkTemp = new CheckBox();
                chkTemp.ID = "chkRole" + nIndex;
                chkTemp.Text = role;
                chkTemp.AutoPostBack = true;
                chkTemp.CheckedChanged += chkTemp_CheckedChanged;

                foreach (string userRole in userRoles)
                {
                    if (userRole.Equals(role))
                        chkTemp.Checked = true;
                }

                pHolderRoles.Controls.Add(chkTemp);

                nIndex++;
            }
        }
        
        //get the selected roles for the user
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