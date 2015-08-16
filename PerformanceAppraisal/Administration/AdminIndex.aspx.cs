using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using PerformanceAppraisal.Utilities;

namespace PerformanceAppraisal.Administration
{
    public partial class AdminIndex : ThemedPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                Master.PageHeading = "Dashboard";

        }
    }
}