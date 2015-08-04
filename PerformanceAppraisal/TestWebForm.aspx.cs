using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PerformanceAppraisal.Utilities;

namespace PerformanceAppraisal
{
    public partial class TestWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void testParentRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if(e.Item.ItemType==ListItemType.Item)
            {
                SiteMapNode node = (SiteMapNode)e.Item.DataItem;
                if(node.HasChildNodes)
                {
                    HyperLink tempHyperlink = (HyperLink)e.Item.FindControl("hLnkFirstLvl");
                    tempHyperlink.Text = "<span>SomeText</span>";
                    //Literal lc = new Literal();
                    //lc.Text = "<span>sometext</span>";

                    //Repeater tempRepeater = (Repeater)e.Item.FindControl("hLnkSecondLvl");
                    //tempRepeater.DataSource = node.ChildNodes;
                    //tempRepeater.DataBind();
                }
            }
        }
    }
}