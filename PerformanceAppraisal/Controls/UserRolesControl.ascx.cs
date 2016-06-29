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

        private Employee Employee
        {
            get
            {
                return (Employee)ViewState["Employee"];
            }
            set
            {
                ViewState["Employee"] = value;
            }
        }

        private MembershipUser User
        {
            get
            {
                return (MembershipUser)ViewState["User"];
            }
            set
            {
                ViewState["User"] = value;
            }
        }

        private List<string> UserRoles
        {
            get
            {
                return (List<string>)ViewState["UserRoles"];
            }
            set
            {
                ViewState["UserRoles"] = value;
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

            this.Employee = empLogic.GetEmployee(this.EmployeeID);

            Department department = deptLogic.GetDepartment(this.Employee.DepartmentID.GetValueOrDefault());

            lblEmpId.Text = Employee.EmployeeID.ToString();

            if (!string.IsNullOrEmpty(Employee.Middlename))
                lblEmpName.Text = Employee.Firstname + " " + Employee.Middlename + " " + Employee.Lastname;
            else
                lblEmpName.Text = Employee.Firstname + " " + Employee.Lastname;

            lblDepartment.Text = department.Departmentname;

            this.User = Membership.GetUser(Employee.UserAccountID.GetValueOrDefault());

            string[] userRoles = Roles.GetRolesForUser(User.UserName);//get roles that user already is in

            string[] arrRoles = Roles.GetAllRoles();//get all roles

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
            {
                UserRoles.Add("SuperAdmin");
            }
            
        }

        protected void btnAssignRoles_Click(object sender, EventArgs e)
        {
            PlaceHolder pHolderTemp = pHolderRoles.FindControl("pHolderRoles") as PlaceHolder;
            UserRoles = new List<string>();

            foreach(Control ctrl in pHolderTemp.Controls)
            {
                if(ctrl is CheckBox)
                {
                    CheckBox chkTemp = (CheckBox)ctrl;

                    if (chkTemp.Checked)
                        UserRoles.Add(chkTemp.Text);

                    
                }
            }

            try
            {
                if (!(UserRoles.Count == 0))
                {
                    foreach (string str in UserRoles)
                    {
                        if (!Roles.IsUserInRole(User.UserName, str))
                        {
                            Roles.AddUserToRole(User.UserName, str);
                        }
                        else
                            Response.Write("User is already in the role: " + str);
                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        
    }
}