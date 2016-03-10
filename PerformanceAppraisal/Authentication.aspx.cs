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

            Page.Form.DefaultFocus = lgnUser.FindControl("Username").ClientID;

        }

        protected void lgnUser_Authenticate(object sender, AuthenticateEventArgs e)
        {
            e.Authenticated = false;

            if (Membership.ValidateUser(lgnUser.UserName, lgnUser.Password))
                e.Authenticated = true;
            else
            {
                //ClientScript.RegisterStartupScript(this.GetType(),
                //    "ShowErrorDiv", "$('#errorDiv').show();", true);


            }
                
        }

        //event handler after the user is authenticated.
        protected void lgnUser_LoggedIn(object sender, EventArgs e)
        {
            //retrive a return Url from Query string if any
            string returnUrl = Request.QueryString["ReturnUrl"];
            UserProfile profile = UserProfile.GetUserProfile(lgnUser.UserName);

            if (returnUrl == null)// if no return url in the query string.
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

                switch (profile.RolePriority) // redirect user to corresponding index pages based on role priority
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