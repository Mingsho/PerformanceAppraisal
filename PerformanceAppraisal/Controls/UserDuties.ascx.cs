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
            if (Session["PDResponsibility"] != null)
            {
                PA.BLL.DTO.PositionDescription pDescription = (PA.BLL.DTO.PositionDescription)Session["PDResponsibility"];

                rptrEmpResponsibilities.DataSource = pDescription.Responsibilities;
                rptrEmpResponsibilities.DataBind();
               
            }
        }

        protected void lnkBtnCreateDuties_Click(object sender, EventArgs e)
        {

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