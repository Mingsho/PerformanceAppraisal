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

                frmViewPd.DefaultMode = FormViewMode.ReadOnly;
            }
        }

        protected void sqlPdDataSource_Selected(object sender, SqlDataSourceStatusEventArgs e)
        {
            frmViewPd.DefaultMode = FormViewMode.Insert;
        }

        protected void frmViewPd_DataBound(object sender, EventArgs e)
        {
            if(frmViewPd.PageCount==0)
            {
                frmViewPd.ChangeMode(FormViewMode.Insert);
            }
        }
    }
}