using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PA.BLL;

namespace PerformanceAppraisal.Admin
{
    public partial class CreateEmployee : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                Employee employee = new Employee();

                try
                {
                    employee.Firstname = txtFirstname.Text;
                    employee.Middlename = txtMiddlename.Text;
                    employee.Lastname = txtLastname.Text;
                    employee.DateofBirth = DateTime.Parse(txtDateofbirth.Text);
                    employee.HouseUnitNo = txtHouseno.Text;
                    employee.Streetname = txtStreetname.Text;
                    employee.Suburb = txtSuburb.Text;
                    employee.City = txtCity.Text;
                    
                    
                }
                catch (ArgumentException)
                {
                    
                    throw;
                }
                catch(Exception)
                {
                    throw;
                }
                

                


            }
        }
    }
}