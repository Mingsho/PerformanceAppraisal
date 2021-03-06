﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA.BLL.DTO
{
    /// <summary>
    /// A simple Employee Business object
    /// </summary>
    public class Employee
    {

        //string strManagerName = "";
        string strDepartmentName = "";
        string strTitleName = "";

        public int? EmployeeID { get; set; }
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

        public string DepartmentName
        {
            get
            {
                return strDepartmentName;
            }
            set
            {
                strDepartmentName = value;
            }
        }

        public string TitleName
        {
            get
            {
                return strTitleName;
            }
            set
            {
                strTitleName = value;
            }

        }

        public Guid? UserAccountID { get; set; }
        public int? DepartmentID { get; set; }
        public byte[] ProfileImage { get; set; }
        public int TitleID { get; set; }

    }
}
