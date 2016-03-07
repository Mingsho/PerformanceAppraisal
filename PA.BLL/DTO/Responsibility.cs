using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA.BLL.DTO
{
    public class Responsibility
    {
        public int ResponsibilityID { get; set; }

        public int PosID { get; set; }

        public string ResponsibilityDesc { get; set; }

        private List<Duty> lstDuties;

        public List<Duty> Duties
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
