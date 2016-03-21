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

        private int NumberOfControls
        {
            get
            {
                return (int)ViewState["controlCount"];
            }
            set
            {
                ViewState["controlCount"] = value;
            }
        }

        /// <summary>
        /// Method to recreate the individual controls
        /// </summary>
        /// <param name="strId"></param>
        /// <param name="nIndex"></param>
        private void CreateResponsibility(string strId, int nIndex)
        {
            Label lblTemp = new Label();
            lblTemp.ID = "lblResponsibility" + nIndex;
            lblTemp.Text = "Responsibility" + nIndex;
            lblTemp.AssociatedControlID = strId + nIndex;

            TextBox textBoxTemp = new TextBox();
            textBoxTemp.ID = strId + nIndex;
            textBoxTemp.TextMode = TextBoxMode.MultiLine;


            PlaceHolder pHolderTemp = (PlaceHolder)frmViewPd.FindControl("pholderResponsibilities");

            if (pHolderTemp == null)
                pHolderTemp = (PlaceHolder)Session["pHolder"];
            
            pHolderTemp.Controls.Add(lblTemp);
            pHolderTemp.Controls.Add(textBoxTemp);

        }

        /// <summary>
        /// Method to recreate the controls after a postback.
        /// </summary>
        protected void RecreateControls()
        {
            this.PrepareChildControlsDuringPreint();

            List<string> keys = Request.Form.AllKeys.Where(key => key.Contains("txtResponsibility")).ToList();

            int i = 1;

            foreach (string key in keys)
            {
                this.CreateResponsibility("txtResponsibility", i);
                i++;
            }
        }

        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.Master.PageHeading = "Position Description";
                this.NumberOfControls = 1;
            }
            else
                RecreateControls();

        }

        protected void sqlPdDataSource_Selected(object sender, SqlDataSourceStatusEventArgs e)
        {
            frmViewPd.DefaultMode = FormViewMode.Insert;
        }

        //protected void frmViewPd_DataBound(object sender, EventArgs e)
        //{
        //    if(frmViewPd.PageCount==0)
        //    {
        //        frmViewPd.ChangeMode(FormViewMode.Insert);
        //    }
        //}

        protected void btnAddResponsibility_Click(object sender, EventArgs e)
        {
            
            this.CreateResponsibility("txtResponsibility", this.NumberOfControls);
            this.NumberOfControls++;
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