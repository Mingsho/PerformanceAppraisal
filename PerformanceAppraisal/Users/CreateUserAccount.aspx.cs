using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PA.BLL;
using PA.BLL.DTO;
using System.Web.Security;

namespace PerformanceAppraisal.Users
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

            MembershipUser createdUser = Membership.GetUser(createPaUserWizard.UserName);

            Guid userAccountID = (Guid)createdUser.ProviderUserKey;
            

            employee.UserAccountID = userAccountID;

            if (empLogic.AddEmployee(employee))
                Response.Write("User created Successfully!");

        }
    }
}