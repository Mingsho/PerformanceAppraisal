using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PA.BLL.DTO;

namespace PerformanceAppraisal.Controls
{
    public partial class UserDuties : System.Web.UI.UserControl
    {
        public int NumberOfControls
        {
            get
            {
                return (int)ViewState["ControlCount"];

            }
            set
            {
                ViewState["ControlCount"] = value;
            }
        }


        public PA.BLL.DTO.PositionDescription PosDescription
        {
            get
            {
                if (Session["PDResponsibility"] != null)
                    return (PA.BLL.DTO.PositionDescription)Session["PDResponsibility"];
                else
                    return null;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.NumberOfControls = 1;

            }
            else
                RecreateControls();

            if (Session["PDResponsibility"] != null)
            {
                PA.BLL.DTO.PositionDescription pDescription = (PA.BLL.DTO.PositionDescription)Session["PDResponsibility"];

                rptrEmpResponsibilities.DataSource = pDescription.Responsibilities;
                rptrEmpResponsibilities.DataBind();
               
            }
        }

        private void CreateControls(string strControlText, int nControlCount)
        {
            string strLabelText = "Duty";

            Label lblTemp = new Label();
            lblTemp.Text = "lbl" + strLabelText + nControlCount;
            lblTemp.AssociatedControlID = strControlText + nControlCount;

            TextBox txtTemp = new TextBox();
            txtTemp.ID = strControlText + nControlCount;
            txtTemp.TextMode = TextBoxMode.MultiLine;

            PlaceHolder pHolderTemp = (PlaceHolder)rptrEmpResponsibilities.FindControl("pHolderDuties");

            pHolderTemp.Controls.Add(lblTemp);
            pHolderTemp.Controls.Add(txtTemp);

            if (btnAddDuties.Enabled == false)
                btnAddDuties.Enabled = true;

        }

        private void RecreateControls()
        {
            List<string> Keys = Request.Form.AllKeys.Where(key => key.Contains("txtDuties")).ToList();

            int i = 1;

            foreach(string key in Keys)
            {
                this.CreateControls("txtDuties", i);
                i++;
            }
        }

        protected void lnkBtnCreateDuties_Click(object sender, EventArgs e)
        {
            this.CreateControls("txtDuties", this.NumberOfControls);
            this.NumberOfControls++;
        }

        protected void rptrEmpResponsibilities_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if(e.CommandName=="Create")
            {
                Response.Write("You clicked the button");
            }
        }
    }
}