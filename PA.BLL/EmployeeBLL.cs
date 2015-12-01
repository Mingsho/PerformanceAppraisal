using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using PA.DAL.PaDataSetTableAdapters;
using PA.BLL.DTO;
using System.Data;




namespace PA.BLL
{
    public enum EmployeeType
    {
        CASUAL, PERMANENT, INTERN
    }

    public class EmployeeBLL
    {
        private tbl_EmployeeTableAdapter employeeTableAdapter = null;

        protected tbl_EmployeeTableAdapter Adapter
        {
            get
            {
                if (employeeTableAdapter == null)
                    employeeTableAdapter = new tbl_EmployeeTableAdapter();

                return employeeTableAdapter;
            }
        }

        public static readonly string[] VALID_IMAGE_EXTENSIONS =
            new string[4] { ".jpg", ".png", ".gif", ".jpeg" };

        public static readonly string STORED_IMAGE = "SessionImage";

        /// <summary>
        /// Get all employees
        /// </summary>
        /// <returns>Employee Datatable</returns>
        public PA.DAL.PaDataSet.tbl_EmployeeDataTable GetEmployees()
        {
            return Adapter.GetData();
        }

        /// <summary>
        /// Return the Employee Object by Employee ID
        /// </summary>
        /// <returns>Employee Object</returns>
        /// <param name="nEmpId">The required employee ID.</param>
        public Employee GetEmployee(int nEmpId)
        {
            PA.DAL.PaDataSet.tbl_EmployeeDataTable empDataTable = Adapter.GetEmployeeByID(nEmpId);

            Employee employee;

            if (empDataTable.Rows.Count > 0)
            {
                employee = new Employee();

                employee.EmployeeID = int.Parse(empDataTable.Rows[0]["EmpID"].ToString());

                employee.Firstname = empDataTable.Rows[0]["Firstname"].ToString();
                employee.Middlename = empDataTable.Rows[0]["Middlename"].ToString();
                employee.Lastname = empDataTable.Rows[0]["Lastname"].ToString();

                if (empDataTable.Rows[0]["DateOfBirth"] != DBNull.Value)
                    employee.DateofBirth = DateTime.Parse(empDataTable.Rows[0]["DateOfBirth"].ToString());
                else
                    employee.DateofBirth = null;

                employee.HouseUnitNo = empDataTable.Rows[0]["HouseUnitNo"].ToString();
                employee.Streetname = empDataTable.Rows[0]["Streetname"].ToString();
                employee.Suburb = empDataTable.Rows[0]["Suburb"].ToString();
                employee.City = empDataTable.Rows[0]["City"].ToString();

                if (empDataTable.Rows[0]["Postcode"] != DBNull.Value)
                    employee.Postcode = int.Parse(empDataTable.Rows[0]["Postcode"].ToString());
                else
                    employee.Postcode = null;

                employee.ContactNumber = empDataTable.Rows[0]["ContactNumber"].ToString();

                employee.Email = empDataTable.Rows[0]["Email"].ToString();

                employee.EmployeeType = empDataTable.Rows[0]["EmployeeType"].ToString();

                if (empDataTable.Rows[0]["StartDate"] != DBNull.Value)
                    employee.StartDate = DateTime.Parse(empDataTable.Rows[0]["StartDate"].ToString());
                else
                    employee.StartDate = null;

                if (empDataTable.Rows[0]["ManagerID"] != DBNull.Value)
                    employee.ManagerID = int.Parse(empDataTable.Rows[0]["ManagerID"].ToString());
                else
                    employee.ManagerID = null;

                employee.UserAccountID = Guid.Parse(empDataTable.Rows[0]["UserAccountID"].ToString());

                if (empDataTable.Rows[0]["DeptID"] != DBNull.Value)
                    employee.DepartmentID = int.Parse(empDataTable.Rows[0]["DeptID"].ToString());
                else
                    employee.DepartmentID = null;

                if (empDataTable.Rows[0]["ProfileImage"] != DBNull.Value)
                    employee.ProfileImage = (byte[])empDataTable.Rows[0]["ProfileImage"];
                else
                    employee.ProfileImage = null;

                employee.TitleID = int.Parse(empDataTable.Rows[0]["TitleID"].ToString());



            }
            else
                employee = null;

            return employee;
        }

        /// <summary>
        /// Get all employees from a department
        /// </summary>
        /// <param name="nDepartmentID">The selected department Id</param>
        /// <returns>Employee Datatable</returns>
        public PA.DAL.PaDataSet.tbl_EmployeeDataTable GetEmployees(int nDepartmentID)
        {
            return Adapter.GetEmployeesByDepartmentID(nDepartmentID);
        }

        public int GetEmployeeID(string strUserAccountID)
        {
            int nEmployeeID=0;

            PA.DAL.PaDataSet.tbl_EmployeeDataTable employeeDataTable = GetEmployees();

            foreach(DataRow dtrow in employeeDataTable.Rows)
            {
                if(dtrow["UserAccountID"].ToString()== strUserAccountID)
                {
                    nEmployeeID = (int)dtrow["EmpID"];
                    break;
                }
            }
            return nEmployeeID;
            
        }

        public PA.DAL.PaDataSet.tbl_EmployeeDataTable GetEmployeeByID(int nEmpID)
        {
            return Adapter.GetEmployeeByID(nEmpID);
        }

        public bool AddEmployee(string firstname, string middlename, string lastname,
            DateTime? dateofbirth, string houseno, string streetname, string suburb,
            string city, int? postcode, string contactno, string email, string employeetype,
            DateTime? startdate, int? managerid, Guid? useraccountid, int? deptid,
            byte[] profileImage, int nTitleID)
        {
            bool bRetVal = false;

            PA.DAL.PaDataSet.tbl_EmployeeDataTable employees = new DAL.PaDataSet.tbl_EmployeeDataTable();
            PA.DAL.PaDataSet.tbl_EmployeeRow employee = employees.Newtbl_EmployeeRow();

            employee.Firstname = firstname;
            employee.Middlename = middlename;
            employee.Lastname = lastname;
            if (dateofbirth == null) employee.SetDateOfBirthNull();
            else
                employee.DateOfBirth = dateofbirth.Value;
            employee.HouseUnitNo = houseno;
            employee.Streetname = streetname;
            employee.Suburb = suburb;
            employee.City = city;
            if (postcode == null) employee.SetPostcodeNull();
            else
                employee.Postcode = postcode.Value;
            employee.ContactNumber = contactno;
            employee.Email = email;
            employee.EmployeeType = employeetype;
            if (startdate == null) employee.SetStartDateNull();
            else
                employee.StartDate = startdate.Value;
            if (managerid == null) employee.SetManagerIDNull();
            else
                employee.ManagerID = managerid.Value;
            if (useraccountid == null) employee.SetUserAccountIDNull();
            else
                employee.UserAccountID = useraccountid.Value;
            if (deptid == null) employee.SetDeptIDNull();
            else
                employee.DeptID = deptid.Value;

            if (profileImage == null) employee.SetProfileImageNull();
            else
                employee.ProfileImage = profileImage;

            employee.TitleID = nTitleID;

            employees.Addtbl_EmployeeRow(employee);

            int nAffectedRows = Adapter.Update(employees);

            if (nAffectedRows > 0)
                bRetVal = true;

            return bRetVal;
        }

        public bool AddEmployee(Employee employee)
        {
            bool bRetVal = false;

            PA.DAL.PaDataSet.tbl_EmployeeDataTable employeeDtTable = new DAL.PaDataSet.tbl_EmployeeDataTable();
            PA.DAL.PaDataSet.tbl_EmployeeRow employeeRow = employeeDtTable.Newtbl_EmployeeRow();

            employeeRow.Firstname = employee.Firstname;
            employeeRow.Middlename = employee.Middlename;
            employeeRow.Lastname = employee.Lastname;

            if (employee.DateofBirth == null) employeeRow.SetDateOfBirthNull();
            else
                employeeRow.DateOfBirth = (DateTime)employee.DateofBirth;

            employeeRow.HouseUnitNo = employee.HouseUnitNo;
            employeeRow.Streetname = employee.Streetname;
            employeeRow.Suburb = employee.Suburb;
            employeeRow.City = employee.City;

            if (employee.Postcode == null) employeeRow.SetPostcodeNull();
            else
                employeeRow.Postcode = (int)employee.Postcode;

            employeeRow.ContactNumber = employee.ContactNumber;
            employeeRow.Email = employee.Email;
            employeeRow.EmployeeType = employee.EmployeeType;

            if (employee.StartDate == null) employeeRow.SetStartDateNull();
            else
                employeeRow.StartDate = (DateTime)employee.StartDate;

            if (employee.ManagerID == null) employeeRow.SetManagerIDNull();
            else
                employeeRow.ManagerID = (int)employee.ManagerID;

            if (employee.UserAccountID == null) employeeRow.SetUserAccountIDNull();
            else
                employeeRow.UserAccountID = (Guid)employee.UserAccountID;

            if (employee.DepartmentID == null) employeeRow.SetDeptIDNull();
            else
                employeeRow.DeptID = (int)employee.DepartmentID;

            if (employee.ProfileImage == null) employeeRow.SetProfileImageNull();
            else
                employeeRow.ProfileImage = employee.ProfileImage;

            employeeRow.TitleID = employee.TitleID;

            employeeDtTable.Addtbl_EmployeeRow(employeeRow);

            int nAffectedRows = Adapter.Update(employeeDtTable);

            if (nAffectedRows > 0)
                bRetVal = true;

            return bRetVal;
        }

        public bool DeleteEmployee(int nEmployeeID)
        {
            bool bRetVal = false;

            PA.DAL.PaDataSet.tbl_EmployeeDataTable empDtTable = new DAL.PaDataSet.tbl_EmployeeDataTable();
            PA.DAL.PaDataSet.tbl_EmployeeRow empRow = empDtTable.Rows.Find(nEmployeeID) as PA.DAL.PaDataSet.tbl_EmployeeRow;

            if(empRow!=null)
            {
                empRow.Delete();
                empDtTable.AcceptChanges();
                bRetVal = true;
            }

            return bRetVal;

        }

        public bool UpdateEmployee(Employee employee)
        {
            bool retVal = false;

            return retVal;
        }
        
    }
}
