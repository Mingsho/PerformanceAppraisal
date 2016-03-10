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
        private void CreateResponsibility(string strId, int nIndex)
        {
            Label lblTemp = new Label();
            lblTemp.ID = "lblResponsibility" + nIndex;
            lblTemp.Text = "Responsibility" + nIndex;
            lblTemp.AssociatedControlID = strId + nIndex;

            PlaceHolder pHolderTemp = (PlaceHolder)frmViewPd.FindControl("pholderResponsibilities");
            pHolderTemp.Controls.Add(lblTemp);

            TextBox textBoxTemp = new TextBox();
            textBoxTemp.ID = strId + nIndex;
            textBoxTemp.TextMode = TextBoxMode.MultiLine;
            

            pHolderTemp.Controls.Add(textBoxTemp);
        }

        /// <summary>
        /// recreating the controls that are created dynamically
        /// All controls with the matching key is retrieved from the Request.Forms Collection
        /// foreach of these keys, the CreateResponsibility method is called
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPreInit(EventArgs e)
        {
            //Child controls init event is fired before that of the parents.
            //this method is called to prevent that.
            this.PrepareChildControlsDuringPreint();

            List<string> keys = Request.Form.AllKeys.Where(key => key.Contains("txtResponsibility")).ToList();

            int i = 1;

            foreach(string key in keys)
            {
                this.CreateResponsibility("txtResponsibility", i);
                i++;
            }

            base.OnPreInit(e);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                this.Master.PageHeading = "Position Description";

                //frmViewPd.DefaultMode = FormViewMode.ReadOnly;
            }
        }

        protected void sqlPdDataSource_Selected(object sender, SqlDataSourceStatusEventArgs e)
        {
            frmViewPd.DefaultMode = FormViewMode.Insert;
        }

        protected void frmViewPd_DataBound(object sender, EventArgs e)
        {
            if(frmViewPd.PageCount==0)
            {
                frmViewPd.ChangeMode(FormViewMode.Insert);
            }
        }

        protected void btnAddResponsibility_Click(object sender, EventArgs e)
        {
            PlaceHolder pHolderTemp = frmViewPd.FindControl("pholderResponsibilities") as PlaceHolder;

            int nIndex = pHolderTemp.Controls.OfType<TextBox>().ToList().Count + 1;
            this.CreateResponsibility("txtResponsibility", nIndex);
        }
    }
}