using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PA.BLL.DTO
{
    public class PositionDescription
    {
        
        public int PdID { get; set; }
        public int EmpID { get; set; }
        public string PositionPurpose { get; set; }

        List<Responsibility> lstResponsibility;

        public List<Responsibility> Responsibilities
        {
            get
            {
                if (lstResponsibility == null)
                    lstResponsibility = new List<Responsibility>();
                return lstResponsibility;
            }
            set
            {
                this.lstResponsibility = value;
            }
        }

    }
}
