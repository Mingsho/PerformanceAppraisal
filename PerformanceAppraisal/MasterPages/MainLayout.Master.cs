using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PerformanceAppraisal.MasterPages
{
    public partial class MainLayout : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //page heading for content pages
        public string PageHeading
        {
            get
            {
                return this.lblPageHeader.Text;
            }
            set
            {
                this.lblPageHeader.Text = value;
            }
        }
    }
}