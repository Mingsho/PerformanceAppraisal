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
        EmployeeBLL empLogic = new EmployeeBLL();
        DepartmentBLL deptLogic = new DepartmentBLL();

        //Array enumNames = System.Enum.GetNames(typeof(EmployeeType));

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {

                dListDepartment.DataTextField = "Departmentname";
                dListDepartment.DataValueField = "DepartmentID";
                dListDepartment.DataSource = deptLogic.getDepartments();
                dListDepartment.DataBind();

                Array itemValues = System.Enum.GetValues(typeof(EmployeeType));
                Array itemNames = System.Enum.GetNames(typeof(EmployeeType));

                for(int i=0; i<=itemNames.Length-1;i++)
                {
                    ListItem item = new ListItem(itemNames.GetValue(i).ToString(),
                        itemValues.GetValue(i).ToString());
                    dListEmpType.Items.Add(item);
                }

                dListManager.DataSource = empLogic.getEmployees();
                dListManager.DataTextField = "Firstname";
                dListManager.DataValueField = "EmpID";

               
            }

        }

        protected void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                Employee employee = new Employee();

                try
                {
                    //store detail in employee DTO
                    employee.Firstname = txtFirstname.Text;
                    employee.Middlename = txtMiddlename.Text;
                    employee.Lastname = txtLastname.Text;
                    employee.DateofBirth = DateTime.Parse(txtDateofbirth.Text);
                    employee.HouseUnitNo = txtHouseno.Text;
                    employee.Streetname = txtStreetname.Text;
                    employee.Suburb = txtSuburb.Text;
                    employee.City = txtCity.Text;
                    employee.Postcode = int.Parse(txtPostcode.Text);
                    employee.ContactNumber = txtContactnumber.Text;
                    employee.Email = txtEmail.Text;
                    employee.EmployeeType = dListEmpType.SelectedValue;
                    employee.StartDate = DateTime.Parse(txtStartdate.Text);
                    employee.ManagerID = int.Parse(dListManager.SelectedValue.ToString());
                    employee.DepartmentID = int.Parse(dListDepartment.SelectedValue.ToString());

                    //store in session
                    Session["objEmployee"] = employee;
 
                    
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