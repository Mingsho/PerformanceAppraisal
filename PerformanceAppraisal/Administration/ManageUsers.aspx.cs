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

        private void InitializeComponents()
        {
            dListDepartment.DataSource = deptLogic.GetDepartments();
            dListDepartment.DataTextField = "Departmentname";
            dListDepartment.DataValueField = "DepartmentID";
            dListDepartment.DataBind();

            int nDeptId = int.Parse(dListDepartment.SelectedValue);

            ViewState["deptId"] = nDeptId;

            BindGridView(nDeptId);
        }

        private void BindGridView(int nDeptId)
        {
            grdEmployees.DataSource = empLogic.GetEmployees(nDeptId);
            grdEmployees.DataBind();
        }

        protected void dListDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nDepartmentID = int.Parse(dListDepartment.SelectedValue);

            BindGridView(nDepartmentID);
          
        }

        protected void grdEmployees_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "Delete")
            {

                int nRowindex = Convert.ToInt32(e.CommandArgument);

                string val = (string)this.grdEmployees.DataKeys[nRowindex]["EmpID"].ToString();

            }
        }

        protected void grdEmployees_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int nEmpID = Convert.ToInt32(grdEmployees.DataKeys[e.RowIndex].Value);

            string strUsername = empLogic.GetUsernameByEmployeeId(nEmpID);

            if(Membership.DeleteUser(strUsername,true))
                empLogic.DeleteEmployee(nEmpID);

            if(ViewState["deptId"]!=null)
            {
                int nDeptId = int.Parse(ViewState["deptId"].ToString());
                BindGridView(nDeptId);
            }


        }

        
    }
}