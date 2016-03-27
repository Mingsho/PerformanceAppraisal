using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PA.BLL;
using PA.BLL.DTO;
using PerformanceAppraisal.Utilities;

namespace PerformanceAppraisal.PositionDescription
{
    public partial class PositionDescription : ThemedPage
    {
        protected enum PositionDescriptionStage
        {
            Responsibility,
            Duties,
            WorkStandards
        };

        protected int EmployeeID
        {
            get
            {
                //if (Request.QueryString["EmpID"] != null)
                return Convert.ToInt32(Request.QueryString["EmpID"]);
            }
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.Master.PageHeading = "Employee Position Description";
                ViewState["pdStage"] = PositionDescriptionStage.Responsibility;

                LoadControl((PositionDescriptionStage)ViewState["pdStage"]);

            }
        }

        protected void LoadControl(PositionDescriptionStage pdStage)
        {
            switch(pdStage)
            {
                case PositionDescriptionStage.Responsibility:
                    {
                        Control ctrl = Page.LoadControl("~/Controls/UserResponsibilities.ascx");
                        pHolderUserControls.Controls.Clear();
                        pHolderUserControls.Controls.Add(ctrl);
                        break;
                    }

                case PositionDescriptionStage.Duties:
                    {
                        break;
                    }

                case PositionDescriptionStage.WorkStandards:
                    {
                        break;
                }
            }
        }

    }
}