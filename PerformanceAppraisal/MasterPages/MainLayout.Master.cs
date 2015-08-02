﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace PerformanceAppraisal.MasterPages
{
    public partial class MainLayout : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Header.DataBind();

            if(System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
            {
                MembershipUser user = Membership.GetUser();

                string[] roles = Roles.GetRolesForUser(user.UserName);

                dlistRoles.DataSource = roles;
                dlistRoles.DataBind();
            }
        }

        //page heading for content pages
        public string PageHeading
        {
            get
            {
                return this.lblPageHeader.Text;
            }
            set
            {
                this.lblPageHeader.Text = value;
            }
        }

        protected void lnkUserLogout_Click(object sender, EventArgs e)
        {
            //signout the currently logged in user.
            FormsAuthentication.SignOut();

            //redirect to the login page.
            FormsAuthentication.RedirectToLoginPage();

            //clear all sessions.
            Session.Clear();
        }

    }
}