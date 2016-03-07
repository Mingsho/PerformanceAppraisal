using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA.BLL.DTO
{
    public class Duty
    {
        public int DutyID { get; set; }
        public string DutyDescription { get; set; }
        public int ResponsibilityID { get; set; }
    }
}
