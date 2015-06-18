using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PA.DAL.PaDataSetTableAdapters;



namespace PA.BLL
{
    enum EmployeeType
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

        public PA.DAL.PaDataSet.tbl_EmployeeDataTable getEmployees()
        {
            return Adapter.GetData();
        }

        public bool addEmployee(string firstname, string middlename, string lastname,
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
            employee.ProfileImage = profileImage;

            employees.Addtbl_EmployeeRow(employee);

            int nAffectedRows = Adapter.Update(employees);

            if (nAffectedRows > 0)
                bRetVal = true;

            return bRetVal;
        }

    }
}
