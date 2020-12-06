using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace ElliotJDNaylor.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //Scripts
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/Scripts/app.js",
                "~/Scripts/font-awesome.js"));

            //Styles
            bundles.Add(new StyleBundle("~/bundles/animated-button").Include(
                "~/Content/animated-button.css"));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                "~/Content/Site.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}