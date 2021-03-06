﻿using System.Web;
using System.Web.Optimization;

namespace APMT_D.o.T_Team
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery.min.js",
                        "~/Scripts/jquery.easing.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/agency").Include(
                        "~/Scripts/agency.min.js",
                        "~/Scripts/jqBootstrapValidation.js",
                        "~/Scripts/contact-me.js",
                         "~/Scripts/agency.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(

                      "~/Scripts/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/css/agency.min.css",
                      "~/Content/css/font.css",
                      "~/Content/site.css"));
        }
    }
}
