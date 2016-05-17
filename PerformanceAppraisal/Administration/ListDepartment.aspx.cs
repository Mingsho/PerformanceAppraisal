using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PerformanceAppraisal.Administration
{
    public partial class ListDepartment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                this.Master.PageHeading = "Department List";
                  
        }

        protected void grdDepartment_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdDepartment.EditIndex = e.NewEditIndex;
        }

        protected void grdDepartment_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            e.Cancel = true;
            grdDepartment.EditIndex = -1;
        }

        protected void grdDepartment_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow grdRow = grdDepartment.Rows[e.RowIndex];

            try
            {
                string strDeptName = ((TextBox)grdRow.FindControl("txtDepartmentName")).Text;
                string strDeptDesc = ((TextBox)grdRow.FindControl("txtDescription")).Text;

                sqlDSourceDepartments.UpdateParameters["deptName"].DefaultValue = strDeptName;
                sqlDSourceDepartments.UpdateParameters["desc"].DefaultValue = strDeptDesc;
                sqlDSourceDepartments.UpdateParameters["dId"].DefaultValue = grdDepartment.DataKeys[e.RowIndex].Value.ToString();

                grdDepartment.EditIndex = -1;
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }

        protected void lnkBtnCreateDepartment_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/Administration/AddDepartment.aspx");
        }
    }
}