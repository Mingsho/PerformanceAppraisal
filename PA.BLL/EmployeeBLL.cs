using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using PA.DAL.PaDataSetTableAdapters;




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

        public PA.DAL.PaDataSet.tbl_EmployeeDataTable GetEmployees()
        {
            return Adapter.GetData();
        }

        public PA.DAL.PaDataSet.tbl_EmployeeDataTable GetEmployees(int nDepartmentID)
        {
            return Adapter.GetEmployeesByDepartmentID(nDepartmentID);
        }

        public bool AddEmployee(string firstname, string middlename, string lastname,
            DateTime? dateofbirth, string houseno, string streetname, string suburb,
            string city, int? postcode, string contactno, string email, string employeetype,
            DateTime? startdate, int? managerid, Guid? useraccountid, int? deptid,
            byte[] profileImage)
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

            employeeDtTable.Addtbl_EmployeeRow(employeeRow);

            int nAffectedRows = Adapter.Update(employeeDtTable);

            if (nAffectedRows > 0)
                bRetVal = true;

            return bRetVal;
        }

        
    }
}
