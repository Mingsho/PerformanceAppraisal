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
            if (!Page.IsPostBack)
                this.Master.PageHeading = "Position Description";
          

        }

        protected void sqlPdDataSource_Selected(object sender, SqlDataSourceStatusEventArgs e)
        {
            frmViewPd.DefaultMode = FormViewMode.Insert;
        }

        
        protected void btnCreatePD_Click(object sender, EventArgs e)
        {

            if(Request.QueryString["EmpID"]!=null)
            {
                int nEmployeeID = 0;
                nEmployeeID = int.Parse(Request.QueryString["EmpID"].ToString());

                Response.Redirect("~/PositionDescription/PositionDescription.aspx?EmpID=" + nEmployeeID);
            }

        }
    }
}