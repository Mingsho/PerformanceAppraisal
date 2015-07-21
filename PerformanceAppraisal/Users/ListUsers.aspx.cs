using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PA.BLL;


namespace PerformanceAppraisal.Users
{
    public partial class ListUsers : System.Web.UI.Page
    {
        EmployeeBLL empLogic = new EmployeeBLL();
        DepartmentBLL deptLogic = new DepartmentBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                InitializeComponents();
            }
        }

        private void InitializeComponents()
        {
            dListDepartment.DataSource = deptLogic.GetDepartments();
            dListDepartment.DataTextField = "Departmentname";
            dListDepartment.DataValueField = "DepartmentID";
            dListDepartment.DataBind();

            int nDeptId = int.Parse(dListDepartment.SelectedValue);

            grdEmployees.DataSource = empLogic.GetEmployees(nDeptId);
            grdEmployees.DataBind();


        }

        private void BindGrid(int nDeptID)
        {
            grdEmployees.DataSource = empLogic.GetEmployees(nDeptID);
            grdEmployees.DataBind();
        }

        protected void dListDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nDeptId = int.Parse(dListDepartment.SelectedValue);

            BindGrid(nDeptId);
        }
    }
}