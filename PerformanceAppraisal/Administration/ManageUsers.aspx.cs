using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using PA.BLL;
using PA.DAL.PaDataSetTableAdapters;
using PerformanceAppraisal.Utilities;

namespace PerformanceAppraisal.Administration
{
    public partial class ManageUsers : ThemedPage
    {
        EmployeeBLL empLogic = new EmployeeBLL();
        DepartmentBLL deptLogic = new DepartmentBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                InitializeComponents();
                this.Master.PageHeading = "Manage Users";
            }
                
        }

        private int DepartmentSelectedID
        {
            get
            {
                return (int)ViewState["DeptSelectedID"];
            }
            set
            {
                ViewState["DeptSelectedID"] = value;
            }

        }

        private void InitializeComponents()
        {
            dListDepartment.DataSource = deptLogic.GetDepartments();
            dListDepartment.DataTextField = "Departmentname";
            dListDepartment.DataValueField = "DepartmentID";
            dListDepartment.DataBind();

            int nDeptId = int.Parse(dListDepartment.SelectedValue);

            this.DepartmentSelectedID = nDeptId;

            BindGridView(nDeptId);
        }

        private void BindGridView(int nDeptId)
        {
            grdEmployees.DataSource = empLogic.GetEmployees(nDeptId);
            grdEmployees.DataBind();
        }

        protected void dListDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DepartmentSelectedID = int.Parse(dListDepartment.SelectedValue);

            BindGridView(this.DepartmentSelectedID);
          
        }

        protected void grdEmployees_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int nEmpID = Convert.ToInt32(grdEmployees.DataKeys[e.RowIndex].Value);

            string strUsername = empLogic.GetUsernameByEmployeeId(nEmpID);

            if (Membership.DeleteUser(strUsername, true))
                empLogic.DeleteEmployee(nEmpID);

            //display the employee list based on default selected dept id.
            BindGridView(this.DepartmentSelectedID);


        }

        protected void lnkBtnCreateEmployee_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/Administration/CreateEmployee.aspx");
        }


    }
}