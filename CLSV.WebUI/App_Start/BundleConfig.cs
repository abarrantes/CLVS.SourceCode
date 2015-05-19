using System.Web;
using System.Web.Optimization;

namespace CLVS.WebUI
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/Scripts").Include(
                        "~/Scripts/jquery/jquery-2.1.3.min.js",
                        "~/Scripts/bootstrap/bootstrap.min.js",
                        "~/Scripts/app/Common.js",
                        "~/Scripts/jquery/jquery-ui.js",
                        "~/Scripts/libraries/bootstrap-combobox.js",
                        "~/Scripts/libraries/linq.min.js"
                        //"~/Scripts/libraries/bootstrap-datetimepicker.min.js",
                        //"~/Scripts/libraries/jquery.jqplot.min.js"
                        //"~/Scripts/libraries/massautocomplete.min.js"
                        //"~/Scripts/angular/angular.min.js",
                        //"~/Scripts/app/Module.js",
                        //"~/Scripts/app/Service.js",
                        //"~/Scripts/app/Controller.js"

                ));

            //bundles.Add(new ScriptBundle("~/bundles/Angular").Include(
            //            "~/Scripts/angular/angular.min.js",
            //            "~/Scripts/app/Module.js",
            //            "~/Scripts/app/Service.js",
            //            "~/Scripts/app/Controller.js"
            //    ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/site.css",
                      "~/Content/jquery-ui.css",
                      //"~/Content/metro-bootstrap.min.css",
                     // "~/Content/massautocomplete.theme.css",
                      "~/Content/bootstrap-combobox.css"
                     // "~/Content/bootstrap-datetimepicker.min.css",
                     // "~/Content/jquery.jqplot.css"
                      ));
            BundleTable.EnableOptimizations = true;
        }
    }
}
