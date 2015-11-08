using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using PA.BLL;



namespace PerformanceAppraisal.Controls
{
    public partial class UserprofileControl : System.Web.UI.UserControl
    {
        EmployeeBLL empLogic = new EmployeeBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if(!Page.IsPostBack)
            {
                Guid userGuid = (Guid)Membership.GetUser().ProviderUserKey;

                if(userGuid!=null)
                {
                    int nUserId = empLogic.GetEmployeeID(userGuid.ToString());
                    frmViewUserDetails.DataSource = empLogic.GetEmployeeByID(nUserId);
                    frmViewUserDetails.DataBind();
                    
                }
            }
        }

        //public string GetImage(object img)
        //{
        //    if (img!=System.DBNull.Value)
        //        return "data:image/jpg;base64," + Convert.ToBase64String((byte[])img);
        //    else
        //        return "~/Images/defaultProfileImage1.png";
        //}
    }
}