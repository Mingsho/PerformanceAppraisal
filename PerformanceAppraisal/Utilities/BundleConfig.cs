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
                "~/Content/sb-admin-2.css",
                "~/Content/font-awesome.min.css"));

            //The core javascripts
            bundles.Add(new ScriptBundle("~/CoreScripts").Include("~/Scripts/jquery-{version}.js",
                "~/Scripts/bootstrap.min.js",
                "~/Scripts/modernizr-{version}.js"));
            
        }
    }
}