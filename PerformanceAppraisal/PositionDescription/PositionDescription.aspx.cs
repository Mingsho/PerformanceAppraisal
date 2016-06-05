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
                this.LastLoadedControl = "UserResponsibilities.ascx";

            LoadControl();
            
        }

        protected void LoadControl()
        {
            
            switch(this.LastLoadedControl)
            {
                case "UserResponsibilities.ascx":
                {
                    this.Master.PageHeading = "Add Employee Responsibilities";
                    Control ctrl = Page.LoadControl(BASE_PATH + LastLoadedControl);
                    ((PerformanceAppraisal.Controls.UserResponsibilities)ctrl).EmployeeID = this.EmployeeID;
                    ((PerformanceAppraisal.Controls.UserResponsibilities)ctrl).onAddResponsibilityClickEvent += new PerformanceAppraisal.Controls.
                        UserResponsibilities.onAddResponsibilityClickEventHandler(catchResponsibilityClickEvent);
                    pHolderUserControls.Controls.Clear();
                    pHolderUserControls.Controls.Add(ctrl);
                    break;
                }


                case "UserDuties.ascx":
                {
                    this.Master.PageHeading = "Add Employee Duties";
                    Control ctrl = Page.LoadControl(BASE_PATH + LastLoadedControl);
                    pHolderUserControls.Controls.Clear();
                    pHolderUserControls.Controls.Add(ctrl);
                    break;
                }


                case "UserKpis.ascx":
                {
                    this.Master.PageHeading = "Add Work Standards";
                    break;
                }
                
            }
        }

        void catchResponsibilityClickEvent(object sender, EventArgs e)
        {
            pHolderUserControls.Controls.Remove((Control)sender);

            this.LastLoadedControl = "UserDuties.ascx";

            LoadControl();
        }

    }
}