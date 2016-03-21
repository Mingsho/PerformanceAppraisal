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

        public int NumberOfControls
        {
            get
            {
                return (int)ViewState["countOfControls"];
            }
            set
            {
                ViewState["countOfControls"] = value;
            }
        }


        protected void CreateResponsibilityControls(string strKey, int nCount)
        {
            Label lblTemp = new Label();
            lblTemp.Text = "Responsibility" + nCount;
            lblTemp.ID = "lblResponsibility" + nCount;
            lblTemp.AssociatedControlID = "txtResponsibility" + nCount;

            TextBox txtBoxTemp = new TextBox();
            txtBoxTemp.ID = "txtResponsibility" + nCount;
            txtBoxTemp.TextMode = TextBoxMode.MultiLine;

            PlaceHolder pHolderTemp = (PlaceHolder)pHolderResponsibilities;

            pHolderTemp.Controls.Add(lblTemp);
            pHolderTemp.Controls.Add(txtBoxTemp);
            
        }

        protected void RecreateControls()
        {
            this.PrepareChildControlsDuringPreint();

            List<string> keys = Request.Form.AllKeys.Where(key => key.Contains("txtResponsibility")).ToList();

            int i = 1;

            foreach(string key in keys)
            {
                this.CreateResponsibilityControls("txtResponsibility", i);
                i++;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.Master.PageHeading = "Employee Position Description";
                this.NumberOfControls = 1;
            }
            else
                RecreateControls();

        }


        protected void btnAddResponsibility_Click(object sender, EventArgs e)
        {
            this.CreateResponsibilityControls("txtResponsibility", this.NumberOfControls);
            this.NumberOfControls++;
        }
    }
}