using System.Web;
using System.Web.Optimization;

namespace eSecretaria
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
                      "~/Scripts/datatables.js",
                      "~/Scripts/jquery.unobtrusive-ajax.js",
                      "~/Scripts/jquery.mask.js",
                      "~/Scripts/bootstrap.js",
                       "~/Scripts/select2.min.js",
                      "~/Scripts/fullcalendar.js",
                      "~/Scripts/pt-br.js",
                       "~/Scripts/moment.min.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/select2.min.css",
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/fullcalendar.css",
                      "~/Content/datatables.css"));
        }
    }
}
