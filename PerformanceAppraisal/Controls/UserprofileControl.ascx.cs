using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using PA.BLL;
using PA.BLL.DTO;



namespace PerformanceAppraisal.Controls
{
    public partial class UserprofileControl : System.Web.UI.UserControl
    {
        EmployeeBLL empLogic = new EmployeeBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if(!Page.IsPostBack)
                FormViewBind();
        }

        /// <summary>
        /// Method to bind the FormView with the details of the
        /// currently logged in user
        /// </summary>
        private void FormViewBind()
        {
            Guid userGuid = (Guid)Membership.GetUser().ProviderUserKey;

            if (userGuid != null)
            {
                int nUserId = empLogic.GetEmployeeID(userGuid.ToString());
                Session["currentEmpID"] = nUserId;
                frmViewUserDetails.DataSource = empLogic.GetEmployeeByID(nUserId);
                frmViewUserDetails.DataBind();

            }
        }

        protected void frmViewUserDetails_ModeChanging(object sender, FormViewModeEventArgs e)
        {
            frmViewUserDetails.ChangeMode(e.NewMode);
            FormViewBind();
        }

        protected void frmViewUserDetails_ItemUpdating(object sender, FormViewUpdateEventArgs e)
        {
            Employee employee = new Employee();

            DataKey dtKey = frmViewUserDetails.DataKey;

            Image tempImgUserProfilePic=(Image)frmViewUserDetails.FindControl("imgUserProfileEdit");

            TextBox tempTxtFirstname = (TextBox)frmViewUserDetails.FindControl("txtFname");
            TextBox tempTxtMiddlename = (TextBox)frmViewUserDetails.FindControl("txtMname");
            TextBox tempTxtLastname = (TextBox)frmViewUserDetails.FindControl("txtLname");
            TextBox tempTxtDob = (TextBox)frmViewUserDetails.FindControl("txtDob");
            TextBox tempTxtHouseUnitNo = (TextBox)frmViewUserDetails.FindControl("txtHouseUnitNo");
            TextBox tempTxtStreetname = (TextBox)frmViewUserDetails.FindControl("txtStreetname");
            TextBox tempTxtSuburb = (TextBox)frmViewUserDetails.FindControl("txtSuburb");
            TextBox tempTxtCity = (TextBox)frmViewUserDetails.FindControl("txtCity");
            TextBox tempTxtPostcode = (TextBox)frmViewUserDetails.FindControl("txtPostCode");
            TextBox tempTxtContactNo = (TextBox)frmViewUserDetails.FindControl("txtContactNo");
            TextBox tempTxtEmail = (TextBox)frmViewUserDetails.FindControl("txtEmail");

            if (Session["currentEmpID"] != null)
                employee.EmployeeID = int.Parse(Session["currentEmpID"].ToString());

            employee.Firstname = tempTxtFirstname.Text;
            employee.Middlename = tempTxtMiddlename.Text;
            employee.Lastname = tempTxtLastname.Text;
            employee.DateofBirth = DateTime.Parse(tempTxtDob.Text);
            employee.HouseUnitNo = tempTxtHouseUnitNo.Text;
            employee.Streetname = tempTxtStreetname.Text;
            employee.Suburb = tempTxtSuburb.Text;
            employee.City = tempTxtCity.Text;
            employee.Postcode = Int32.Parse(tempTxtPostcode.Text);
            employee.ContactNumber = tempTxtContactNo.Text;
            employee.Email = tempTxtEmail.Text;

            bool bSuccessfulUpdate = empLogic.UpdateEmployee(employee);

            if (bSuccessfulUpdate)
            {
                FormViewBind();
            }

        }

        protected void frmViewUserDetails_ItemUpdated(object sender, FormViewUpdatedEventArgs e)
        {
            frmViewUserDetails.ChangeMode(FormViewMode.ReadOnly);
        }

        protected void fUploadProfilePic_UploadedComplete(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
        {

        }

       

    }
}