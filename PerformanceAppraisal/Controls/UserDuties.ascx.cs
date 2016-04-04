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
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["PDResponsibility"]!=null)
            {
                PA.BLL.DTO.PositionDescription pDescription = (PA.BLL.DTO.PositionDescription)Session["PDResponsibility"];

                testRepeater.DataSource = pDescription.Responsibilities;
                testRepeater.DataBind();
               
            }
        }

        protected void lnkBtnCreateDuties_Click(object sender, EventArgs e)
        {

        }
    }
}