using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PA.BLL;
using System.Web.Security;

namespace PerformanceAppraisal.Admin
{
    public partial class CreateUserAccount : System.Web.UI.Page
    {
        EmployeeBLL empLogic = new EmployeeBLL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void createPaUserWizard_CreatedUser(object sender, EventArgs e)
        {
            Employee employee = new Employee();

            if (Session["objEmployee"] != null)
                employee = (Employee)Session["objEmployee"];

            Roles.AddUserToRole((sender as CreateUserWizard).UserName, "User");

            Guid userAccountID = (Guid)Membership.GetUser(HttpContext.Current.User.Identity.Name).ProviderUserKey;

            employee.UserAccountID = userAccountID;

            if (empLogic.addEmployee(employee))
                Response.Write("User created Successfully!");

        }
    }
}