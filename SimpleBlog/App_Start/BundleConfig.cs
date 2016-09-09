using System.Web.Optimization;

namespace SimpleBlog
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //Admin bundles
            bundles.Add(new StyleBundle("~/admin/styles")
                .Include("~/content/styles/bootstrap.css")
                .Include("~/content/styles/admin.css"));

            //Frontend bundles
            bundles.Add(new StyleBundle("~/styles")
                .Include("~/content/styles/bootstrap.css")
                .Include("~/content/styles/site.css"));

            bundles.Add(new ScriptBundle("~/admin/scripts")
                .Include("~/scripts/styles/jquery-3.1.0.js")
                .Include("~/scripts/styles/jquery-validate.js")
                .Include("~/scripts/styles/jquery-validate.unobtrusive.js")
                .Include("~/scripts/styles/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/scripts")
                .Include("~/scripts/styles/jquery-3.1.0.js")
                .Include("~/scripts/styles/jquery-validate.js")
                .Include("~/scripts/styles/jquery-validate.unobtrusive.js")
                .Include("~/scripts/styles/bootstrap.js"));
        }
    }
}