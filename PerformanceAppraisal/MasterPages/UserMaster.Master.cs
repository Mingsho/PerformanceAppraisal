using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PerformanceAppraisal.MasterPages
{
    public partial class UserMaster : System.Web.UI.MasterPage
    {
        //page heading
        public string PageHeading
        {
            get;
            set;
        }

        //Page title
        public string PageTitle
        {
            get
            {
                return this.Page.Title;
            }
            set
            {
                this.Page.Title = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}