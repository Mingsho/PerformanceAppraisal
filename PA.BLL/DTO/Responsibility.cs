using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA.BLL.DTO
{
    public class Responsibility
    {
        public int? ResponsibilityID { get; set; }

        public string ResponsibilityDesc { get; set; }

        public int EmpID { get; set; }

        private List<Duty> lstDuties;

        public List<Duty> LstDuties
        {
            get
            {
                if (lstDuties == null)
                    lstDuties = new List<Duty>();
                return lstDuties;
            }
            set
            {
                this.lstDuties = value;
            }
        }
    }
}
