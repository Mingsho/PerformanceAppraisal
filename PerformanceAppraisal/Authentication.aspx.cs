using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PerformanceAppraisal
{
    public partial class Authentication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.lgnUser.Focus();
        }

        protected void lgnUser_LoggedIn(object sender, EventArgs e)
        {
            string returnUrl = Request.QueryString["ReturnUrl"];

            if (returnUrl == null)
            {
                if (Roles.IsUserInRole(lgnUser.UserName, "SuperAdmin"))
                    Response.Redirect("~/Admin/AdminIndex.aspx");
                else
                    Response.Redirect("~/UserPages/UserIndex.aspx");
            }
            else
                Response.Redirect(returnUrl);
            
        }
        

    }
}