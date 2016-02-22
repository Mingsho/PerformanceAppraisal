using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace PerformanceAppraisal.Utilities
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //The core css styles
            bundles.Add(new StyleBundle("~/CoreStyles").Include("~/Content/bootstrap.min.css",
                "~/Content/metisMenu.min.css",
                "~/Content/sb-admin-2.css",
                "~/Content/font-awesome.min.css"));

            bundles.Add(new StyleBundle("~/LessStyles").Include("~/Content/mixins.less",
                "~/Content/sb-admin-2.less", "~/Content/variables.ess"));

            bundles.Add(new StyleBundle("~/CustomStyles").Include("~/Content/jquery-ui.css"));

            //The core javascripts
            bundles.Add(new ScriptBundle("~/CoreScripts").Include("~/Scripts/jquery-{version}.js",
                "~/Scripts/bootstrap.min.js",
                "~/Scripts/metisMenu.min.js",
                "~/Scripts/sb-admin-2.js",
                "~/Scripts/modernizr-{version}.js"));

            bundles.Add(new ScriptBundle("~/CustomScripts").Include("~/Scripts/jquery-ui.js"));

            bundles.Add(new ScriptBundle("~/ValidationScripts").Include("~/Scripts/Validation/jquery.validate.min.js"));
            
        }
    }
}