using System.Web;
using System.Web.Optimization;

namespace AnguarjsHepler
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));


            bundles.Add(new ScriptBundle("~/js/rubik-angular").Include(
              "~/Assets/angular/angular.js",
              "~/Assets/angular/ui-select.js",
              "~/Assets/angular/angular-messages.min.js",
              "~/Assets/angular/angular-sanitize.js",
              "~/Assets/rubikjs/js/rubikjs-directive.js"
          ));

            bundles.Add(new ScriptBundle("~/js/myapp")
                 .Include("~/Assets/myapp/app.js")
                 .IncludeDirectory("~/Assets/myapp/controller/", "*.js", true));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
