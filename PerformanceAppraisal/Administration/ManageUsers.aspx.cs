using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
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
                InitializeComponents();

        }

        private void InitializeComponents()
        {
            dListDepartment.DataSource = deptLogic.GetDepartments();
            dListDepartment.DataTextField = "Departmentname";
            dListDepartment.DataValueField = "DepartmentID";
            dListDepartment.DataBind();

            int nDeptId = int.Parse(dListDepartment.SelectedValue);

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

        
    }
}