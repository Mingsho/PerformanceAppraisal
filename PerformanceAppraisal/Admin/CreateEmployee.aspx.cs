using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using PA.BLL;

namespace PerformanceAppraisal.Admin
{
    public partial class CreateEmployee : System.Web.UI.Page
    {
        EmployeeBLL empLogic = new EmployeeBLL();
        DepartmentBLL deptLogic = new DepartmentBLL();
        Employee employee;

        //Array enumNames = System.Enum.GetNames(typeof(EmployeeType));

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                initializeComponents();

           
        }

        private void initializeComponents()
        {
            dListDepartment.DataTextField = "Departmentname";
            dListDepartment.DataValueField = "DepartmentID";
            dListDepartment.DataSource = deptLogic.getDepartments();
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

            dListManager.DataSource = empLogic.getEmployees();
            dListManager.DataTextField = "Firstname";
            dListManager.DataValueField = "EmpID";
            dListManager.Items.Insert(0, new ListItem("Configure Manager Later", "-1"));
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

                    int nManagerId = int.Parse(dListManager.SelectedValue.ToString());

                    if (nManagerId != -1)
                        employee.ManagerID = int.Parse(dListManager.SelectedValue.ToString());
                    else
                        employee.ManagerID = null;

                    int nDepartmentID=int.Parse(dListDepartment.SelectedValue.ToString());

                    if(nDepartmentID!=-1)
                        employee.DepartmentID = int.Parse(dListDepartment.SelectedValue.ToString());
                    else
                        employee.DepartmentID=null;

                    //store in session
                    Session["objEmployee"] = employee;

                    Response.Redirect("~/Admin/CreateUserAccount.aspx");
 
                    
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

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            //employee = new Employee();

            //if(!string.IsNullOrEmpty(txtProfilePic.PostedFile.FileName))
            //{
            //    int contentLength = txtProfilePic.PostedFile.ContentLength;
            //    string contentType = txtProfilePic.PostedFile.ContentType;
            //    string fileName = txtProfilePic.PostedFile.FileName;

            //    switch(contentType.ToLower())
            //    {
            //        case "image/png":
            //            employee.ProfileImage=empLogic.convertImageToByteArray(txtProfilePic.PostedFile.
            //    }
            //}
            

        }
    }
}