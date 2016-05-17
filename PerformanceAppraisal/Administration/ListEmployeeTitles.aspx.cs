using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PA.BLL;
using PA.BLL.DTO;

namespace PerformanceAppraisal.Administration
{
    public partial class ListEmployeeTitles : System.Web.UI.Page
    {
        TitleBLL titleLogic = new TitleBLL();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                this.Master.PageHeading = "Employee Titles";
        }

        protected void grdEmployeeTitles_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdEmployeeTitles.EditIndex = e.NewEditIndex;


        }

        protected void grdEmployeeTitles_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            e.Cancel = true;
            grdEmployeeTitles.EditIndex = -1;

        }

        

        protected void grdEmployeeTitles_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            GridViewRow grRow = grdEmployeeTitles.Rows[e.RowIndex];

            try
            {
                string strJobTitle = ((TextBox)grRow.FindControl("txtTitleName")).Text;
                string strTitlePurpose = ((TextBox)grRow.FindControl("txtTitlePurpose")).Text;

                sqlDSourceEmpTitles.UpdateParameters["jobTitle"].DefaultValue = strJobTitle;
                sqlDSourceEmpTitles.UpdateParameters["titlePurpose"].DefaultValue = strTitlePurpose;
                sqlDSourceEmpTitles.UpdateParameters["tId"].DefaultValue = grdEmployeeTitles.DataKeys[e.RowIndex].Value.ToString();
                

                grdEmployeeTitles.EditIndex = -1;
                
            }
            catch (Exception ex)
            {
                
                throw;
            }

        }

        protected void lnkCreateEmpTitle_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/Administration/CreateTitle.aspx");
        }
    }
}