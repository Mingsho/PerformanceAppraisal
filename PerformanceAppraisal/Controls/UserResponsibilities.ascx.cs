using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PerformanceAppraisal.Controls
{
    public partial class UserResponsibilities : System.Web.UI.UserControl
    {
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
                this.NumberOfControls = 1;
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

        }
    }
}