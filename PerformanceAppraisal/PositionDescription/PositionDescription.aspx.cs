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

        public enum PositionDescriptionStage
        {
            Responsibility,
            Duties,
            WorkStandards
        };

        public int EmployeeID
        {
            get
            {
                if (Request.QueryString["EmpID"] != null)
                    return Convert.ToInt32(Request.QueryString["EmpID"]);
                else
                    return 0;
            }
        }

       protected void Page_Init(object sender, EventArgs e)
       {
           //LoadControl(viewstate
        
       }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.Master.PageHeading = "Employee Position Description";
                ViewState["pdStage"] = PositionDescriptionStage.Responsibility;

                LoadControl((PositionDescriptionStage)ViewState["pdStage"]);

            }
            else //if page is not a postback, reload the control based on the positiondescription stage
                LoadControl((PositionDescriptionStage)ViewState["pdStage"]);
            
        }

        protected void LoadControl(PositionDescriptionStage pdStage)
        {
            switch(pdStage)
            {
                case PositionDescriptionStage.Responsibility:
                    {
                        Control ctrl = Page.LoadControl("~/Controls/UserResponsibilities.ascx");
                        ((PerformanceAppraisal.Controls.UserResponsibilities)ctrl).EmployeeID = this.EmployeeID;
                        ((PerformanceAppraisal.Controls.UserResponsibilities)ctrl).onAddResponsibilityClickEvent += new PerformanceAppraisal.Controls.
                            UserResponsibilities.onAddResponsibilityClickEventHandler(catchResponsibilityClickEvent);
                        pHolderUserControls.Controls.Clear();
                        pHolderUserControls.Controls.Add(ctrl);
                        break;
                    }

                case PositionDescriptionStage.Duties:
                    {
                        Control ctrl = Page.LoadControl("~/Controls/UserDuties.ascx");
                        pHolderUserControls.Controls.Clear();
                        pHolderUserControls.Controls.Add(ctrl);
                        break;
                    }

                case PositionDescriptionStage.WorkStandards:
                    {
                        break;
                }
            }
        }

        void catchResponsibilityClickEvent(object sender, EventArgs e)
        {
            pHolderUserControls.Controls.Remove((Control)sender);

            LoadControl(PositionDescriptionStage.Duties);
        }

    }
}