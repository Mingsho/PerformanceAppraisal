using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace PerformanceAppraisal.Utilities
{
    public class MenuRepeaterTemplate: ITemplate
    {
        static int itemCount;

        public void InstantiateIn(Control container)
        {
            
            
            LiteralControl lc = new LiteralControl();
            lc.Text = "ItemNumber:" + itemCount.ToString() + "<br>";
            itemCount += 1;
            container.Controls.Add(lc);
        }
    }
}