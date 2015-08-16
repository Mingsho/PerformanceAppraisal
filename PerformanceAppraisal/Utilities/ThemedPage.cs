using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace PerformanceAppraisal.Utilities
{
    public class ThemedPage: Page
    {
        protected override void OnPreInit(EventArgs e)
        {
            base.OnPreInit(e);

            if(Session["SelectedTheme"]!=null)
            {
                Page.Theme = (string)Session["SelectedTheme"];
            }
            else
            {
                Session.Add("SelectedTheme", "DefaultTheme");
                Page.Theme = (string)Session["SelectedTheme"];
            }
        }
    }
}