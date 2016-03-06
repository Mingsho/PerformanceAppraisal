using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PerformanceAppraisal.Utilities;
using PA.BLL;

namespace PerformanceAppraisal.PositionDescription
{
    public partial class EmployeeList : ThemedPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
                this.Master.PageHeading = "Employee List";

        }

        protected void grdUserList_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName=="ViewPD")
            {
                int nRowIndex = Convert.ToInt32(e.CommandArgument);

                GridViewRow selectedRow = grdUserList.Rows[nRowIndex];

                int nEmpID = Convert.ToInt32(selectedRow.Cells[0].Text);

                Response.Redirect("~/PositionDescription/EmployeePD.aspx?EmpID=" + nEmpID);


            }
        }

    }
}