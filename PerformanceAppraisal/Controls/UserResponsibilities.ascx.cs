using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PA.BLL;
using PA.BLL.DTO;

namespace PerformanceAppraisal.Controls
{
    public partial class UserResponsibilities : System.Web.UI.UserControl
    {

        public delegate void onAddResponsibilityClickEventHandler(object sender, EventArgs e);
        public event onAddResponsibilityClickEventHandler onAddResponsibilityClickEvent;

        int nEmployeeID = 0;

        public int EmployeeID
        {
            get
            {
                return nEmployeeID;
            }
            set
            {
                nEmployeeID = value;
            }
        }

        protected int NumberOfControls
        {

            get
            {
                return (int)ViewState["noOfControls"];
            }
            set
            {
                ViewState["noOfControls"] = value;
            }
        
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.NumberOfControls = 1;
                Page.Form.DefaultFocus = txtPosPurpose.ClientID;
            }
            else
                RecreateControls();
        }

        /// <summary>
        /// Method to create the dynamic controls for responsibilities
        /// </summary>
        /// <param name="strControlText"></param>
        /// <param name="nControlCount"></param>
        private void CreateControls(string strControlText, int nControlCount)
        {
            string strTemptext="Responsibility";
            Label lblTemp = new Label();
            lblTemp.ID = "lbl"+strTemptext + nControlCount;
            lblTemp.Text = strTemptext + " " + nControlCount;
            lblTemp.AssociatedControlID = strControlText + nControlCount;

            TextBox txtTemp = new TextBox();
            txtTemp.ID = strControlText + nControlCount;
            txtTemp.TextMode = TextBoxMode.MultiLine;

            PlaceHolder pHolder = (PlaceHolder)pHolderResponsibilities;

            pHolder.Controls.Add(lblTemp);
            pHolder.Controls.Add(txtTemp);

            if (btnAddResponsibility.Enabled == false)
                btnAddResponsibility.Enabled = true;
        }


        /// <summary>
        /// Method to recreate the controls after postback
        /// </summary>
        private void RecreateControls()
        {
            List<string> Keys = Request.Form.AllKeys.Where(key => key.Contains("txtResponsibility")).ToList();

            int i = 1;

            foreach(string key in Keys)
            {
                this.CreateControls("txtResponsibility", i);
                i++;
            }
        }

        protected void lnkBtnCreateResponsibility_Click(object sender, EventArgs e)
        {
            this.CreateControls("txtResponsibility", this.NumberOfControls);
            this.NumberOfControls++;
        }

        protected void btnAddResponsibility_Click(object sender, EventArgs e)
        {
            PositionDescriptionBLL pdLogic = new PositionDescriptionBLL();
            PerformanceAppraisal.PositionDescription.PositionDescription pg = this.Parent as 
                PerformanceAppraisal.PositionDescription.PositionDescription;

            PA.BLL.DTO.PositionDescription pdBO = new PA.BLL.DTO.PositionDescription();

            pdBO.EmpID = this.EmployeeID;

            pdBO.PositionPurpose = txtPosPurpose.Text;

            foreach(Control cnt in pHolderResponsibilities.Controls)
            {
                Responsibility responsibilityBO = new Responsibility();

                if(cnt is TextBox)
                {
                    responsibilityBO.ResponsibilityDesc = ((TextBox)cnt).Text;
                    pdBO.Responsibilities.Add(responsibilityBO);
                }

            }

            Session["PDResponsibility"] = pdBO;

            //Null Checks makes sure the parent/main page is attached to the event.
            if (onAddResponsibilityClickEvent != null)
                this.onAddResponsibilityClickEvent(this, new EventArgs());
            
        }
    }
}