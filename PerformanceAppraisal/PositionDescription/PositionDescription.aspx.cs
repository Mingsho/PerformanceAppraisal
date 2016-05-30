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

        private const string BASE_PATH = "~/Controls/";

        public enum PositionDescriptionStage
        {
            Responsibility,
            Duties,
            WorkStandards
        };

        public string LastLoadedControl
        {
            get
            {
                return ViewState["LastLoadedControl"].ToString();
            }
            set
            {
                ViewState["LastLoadedControl"] = value;
            }
        }

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

               
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                ViewState["pdStage"] = PositionDescriptionStage.Responsibility;

            LoadControl((PositionDescriptionStage)ViewState["pdStage"]);

            //if (!Page.IsPostBack)
            //    LastLoadedControl = BASE_PATH + "UserResponsibilities.ascx";

            //LoadUserControl();
            
        }

        //protected void LoadUserControl()
        //{
        //    string controlPath = LastLoadedControl;

        //    if (!string.IsNullOrEmpty(controlPath))
        //    {
        //        pHolderUserControls.Controls.Clear();
        //        UserControl uControl = (UserControl)LoadControl(controlPath);
        //        pHolderUserControls.Controls.Add(uControl);
        //    }
        //}

        protected void LoadControl(PositionDescriptionStage pdStage)
        {
            //string strControlPath = LastLoadedControl;

            switch(pdStage)
            {
                case PositionDescriptionStage.Responsibility:
                {
                    this.Master.PageHeading = "Add Employee Responsibilities";
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
                    this.Master.PageHeading = "Add Employee Duties";
                    Control ctrl = Page.LoadControl("~/Controls/UserDuties.ascx");
                    pHolderUserControls.Controls.Clear();
                    pHolderUserControls.Controls.Add(ctrl);
                    break;
                }


                case PositionDescriptionStage.WorkStandards:
                {
                    this.Master.PageHeading = "Add Work Standards";
                    break;
                }
                
            }
        }

        void catchResponsibilityClickEvent(object sender, EventArgs e)
        {
            pHolderUserControls.Controls.Remove((Control)sender);

            ViewState["pdStage"] = PositionDescriptionStage.Duties;

            //string controlPath = BASE_PATH + "UserDuties.ascx";

            //LastLoadedControl = controlPath;
            //LoadUserControl();


            LoadControl(PositionDescriptionStage.Duties);
        }

    }
}