using System.Web.Optimization;

namespace PortfolioSite.WebUI
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.Bundles.UseCdn = true;
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.min.css",
                "~/Content/font-awesome.min.css",
                "~/Content/Site.css"));
            bundles.Add(new ScriptBundle("~/Scripts/scripts").Include(
                "~/Scripts/jquery-3.2.1.min.js",
                "~/Scripts/jquery-site.js",
                "~/Scripts/modernizr-2.8.3.js",
                "~/Scripts/bootstrap.min.js",
                "~/Scripts/Site.js"));

            BundleTable.EnableOptimizations = true;
        }
    }
}