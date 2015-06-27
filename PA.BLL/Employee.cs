using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA.BLL
{
    /// <summary>
    /// A simple Employee Business object
    /// </summary>
    public class Employee
    {
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public DateTime? DateofBirth { get; set; }
        public string HouseUnitNo { get; set; }
        public string Streetname { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public int? Postcode { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string EmployeeType { get; set; }
        public DateTime? StartDate { get; set; }
        public int? ManagerID { get; set; }
        public Guid? UserAccountID { get; set; }
        public int? DepartmentID { get; set; }
        public byte[] ProfileImage { get; set; }


    }
}
