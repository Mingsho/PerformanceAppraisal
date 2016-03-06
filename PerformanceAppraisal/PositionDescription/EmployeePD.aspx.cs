using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PerformanceAppraisal.Utilities;

namespace PerformanceAppraisal.PositionDescription
{
    public partial class EmployeePD : ThemedPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                this.Master.PageHeading = "Position Description";
            }
        }
    }
}