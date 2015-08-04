using System;
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

        protected void sideBarMenu_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            //must also include AlternatingItem
            //the second node is the alternating item in the sitemapnode
            if(e.Item.ItemType==ListItemType.Item || e.Item.ItemType==ListItemType.AlternatingItem)
            {
                SiteMapNode node = (SiteMapNode)e.Item.DataItem;

                switch(node.Title)
                {
                    case "Dashboard":
                        Literal lit = (Literal)e.Item.FindControl("litIcon");
                        lit.Text = @"<i class=""fa fa-dashboard fa-fw""></i>";
                        break;
                }

                if(node.HasChildNodes)
                {
                    Literal lit = (Literal)e.Item.FindControl("litCaret");
                    lit.Text = @"<span class=""fa arrow""></span>";
                }
            }
        }

    }
}