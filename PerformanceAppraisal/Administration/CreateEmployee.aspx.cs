using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using AjaxControlToolkit;
using PA.BLL;
using PA.BLL.DTO;
using PerformanceAppraisal.Utilities;


namespace PerformanceAppraisal.Administration
{
    public partial class CreateEmployee : ThemedPage
    {
        EmployeeBLL empLogic = new EmployeeBLL();
        DepartmentBLL deptLogic = new DepartmentBLL();
        TitleBLL titleLogic = new TitleBLL();

        Employee employee;

        private const string userProfileImageUrl = "sessionImageUrl";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                initializeComponents();
                Master.PageHeading = "Create Employee Profile";
            }

            
        }

        private void initializeComponents()
        {
            dListDepartment.DataTextField = "Departmentname";
            dListDepartment.DataValueField = "DepartmentID";
            dListDepartment.DataSource = deptLogic.GetDepartments();
            dListDepartment.DataBind();

            dListDepartment.Items.Insert(0, new ListItem("Configure Department Later", "-1"));

            Array itemValues = System.Enum.GetValues(typeof(EmployeeType));
            Array itemNames = System.Enum.GetNames(typeof(EmployeeType));

            for (int i = 0; i <= itemNames.Length - 1; i++)
            {
                ListItem item = new ListItem(itemNames.GetValue(i).ToString(),
                    itemValues.GetValue(i).ToString());
                dListEmpType.Items.Add(item);
            }

            dListEmpType.Items.Insert(0, new ListItem("Configure Employee Type Later", "-1"));

            dListManager.DataSource = empLogic.GetEmployees();
            dListManager.DataTextField = "Firstname";
            dListManager.DataValueField = "EmpID";
            dListManager.Items.Insert(0, new ListItem("Configure Manager Later", "-1"));
            dListManager.DataBind();

            dListEmployeeTitle.DataSource = titleLogic.GetTitles();
            dListEmployeeTitle.DataTextField = "JobTitle";
            dListEmployeeTitle.DataValueField = "TitleID";
            dListEmployeeTitle.DataBind();

        }

        /// <summary>
        /// btnCreateEmployee OnClick eventhandler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                employee = new Employee();

                try
                {
                    //store detail in employee DTO
                    employee.Firstname = txtFirstname.Text;
                    employee.Middlename = txtMiddlename.Text;
                    employee.Lastname = txtLastname.Text;

                    if (string.IsNullOrEmpty(txtDateofbirth.Text))
                        employee.DateofBirth = null;
                    else
                        employee.DateofBirth = DateTime.Parse(txtDateofbirth.Text);

                    employee.HouseUnitNo = txtHouseno.Text;
                    employee.Streetname = txtStreetname.Text;
                    employee.Suburb = txtSuburb.Text;
                    employee.City = txtCity.Text;

                    if (string.IsNullOrEmpty(txtPostcode.Text))
                        employee.Postcode = null;
                    else
                        employee.Postcode = int.Parse(txtPostcode.Text);

                    employee.ContactNumber = txtContactnumber.Text;
                    employee.Email = txtEmail.Text;
                    employee.EmployeeType = dListEmpType.SelectedValue;
                    employee.StartDate = DateTime.Parse(txtStartdate.Text);

                    if (fUploadProfilePic.PostedFile!=null)
                    {
                        employee.ProfileImage = Session[EmployeeBLL.STORED_IMAGE] as byte[];
                    }
                        
                    else
                        employee.ProfileImage = null;

                    int nManagerId = int.Parse(dListManager.SelectedValue);

                    if (nManagerId != -1)
                        employee.ManagerID = int.Parse(dListManager.SelectedValue);
                    else
                        employee.ManagerID = null;

                    int nDepartmentID=int.Parse(dListDepartment.SelectedValue);

                    if(nDepartmentID!=-1)
                        employee.DepartmentID = int.Parse(dListDepartment.SelectedValue);
                    else
                        employee.DepartmentID=null;

                    employee.TitleID = int.Parse(dListEmployeeTitle.SelectedValue);

                    //store in session
                    Session["objEmployee"] = employee;

                    //redirect to create user login
                    Response.Redirect("~/Administration/CreateUserAccount.aspx");
 
                    
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

       
        protected void fUploadProfilePic_UploadedComplete(object sender,
            AjaxControlToolkit.AsyncFileUploadEventArgs e)
        {

            if(fUploadProfilePic.PostedFile!=null)
            {
                HttpPostedFile file = fUploadProfilePic.PostedFile;

                byte[] data = ImageUtilities.ReadFile(file);
               
                Session[EmployeeBLL.STORED_IMAGE] = data;

            }

        }

              
    }
}