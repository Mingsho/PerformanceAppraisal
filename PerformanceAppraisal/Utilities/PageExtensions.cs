using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;


namespace PerformanceAppraisal.Utilities
{
    public static class PageExtensions
    {
        /// <summary>
        /// Extension Method.
        /// Can be called during the Page.PreInit stage to
        /// make the child controls available when using Master Pages.
        /// </summary>
        /// <remarks>
        /// This is needed to fire the getter on the top level Master property,
        /// which in turn causes the ITemplate to be instantiated for the content placeholders,
        /// which in turn makes the controls accessible so that we can make the calls below.
        /// </remarks>
        /// <param name="page">
        /// The Page object.
        /// </param>
        public static void PrepareChildControlsDuringPreint(this Page page)
        {
            MasterPage master = page.Master;
            while (master != null) master = master.Master;
        }
       
    }
}