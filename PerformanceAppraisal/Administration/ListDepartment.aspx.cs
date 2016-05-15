using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PerformanceAppraisal.Administration
{
    public partial class ListDepartment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                this.Master.PageHeading = "Department List";
                  
        }

        protected void lnkBtnCreateDepartment_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/Administration/AddDepartment.aspx");
        }
    }
}