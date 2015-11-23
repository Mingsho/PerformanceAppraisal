using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using PerformanceAppraisal.Utilities;

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
            UserProfile profile = UserProfile.GetUserProfile(lgnUser.UserName);
            
            if (returnUrl == null)
            {
                
                string[] userRoles=Roles.GetRolesForUser(lgnUser.UserName);

                if (string.IsNullOrEmpty(profile.RolePriority))
                {
                    foreach(string str in userRoles)
                    {
                        if (str == "SuperAdmin")
                        {
                            profile.RolePriority = "SuperAdmin";
                            break;
                        }
                        else
                            profile.RolePriority = "User";
                            
                    }
                }

                switch(profile.RolePriority)
                {
                    case "SuperAdmin":
                        Response.Redirect("~/Administration/AdminIndex.aspx");
                        break;
                    case "User":
                        Response.Redirect("~/UserPages/UserIndex.aspx");
                        break;
                }

            }
            else
                Response.Redirect(returnUrl);
            
        }
        

    }
}