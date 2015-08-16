using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PA.BLL;

namespace PerformanceAppraisal.Administration
{
    public partial class CreateTitle : System.Web.UI.Page
    {
        TitleBLL titleLogic = new TitleBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                Master.PageHeading = "Create Title";
        }

        protected void btnCreateTitle_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                if (titleLogic.AddTitle(txtTitleName.Text, txtTitlePurpose.Text))
                {
                    Response.Write("Title added successfull!");
                    ClearFields();
                }
                    

            }
        }

        private void ClearFields()
        {
            txtTitleName.Text = "";
            txtTitlePurpose.Text = "";
        }
    }
}