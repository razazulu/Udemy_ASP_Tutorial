using System.Web.Optimization;
using NHibernate.Mapping.ByCode;

namespace SimpleBlog
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //Admin area bundles
            bundles.Add(new StyleBundle("~/admin/styles").Include(
                "~/content/styles/bootstrap.css",
                "~/content/styles/admin.css"));

            //Main bundles
            bundles.Add(new StyleBundle("~/styles").Include(
                "~/content/styles/bootstrap.css",
                "~/content/styles/site.css"));

            //Admin area scripts
            bundles.Add(new ScriptBundle("~/admin/scripts").Include(
                "~/scripts/jquery-3.1.0.js",
                "~/scripts/jquery-validate.js",
                "~/scripts/jquery-validate.unobtrusive.js",
                "~/scripts/bootstrap.js",
                "~/areas/admin/scripts/forms.js"));

            //Admin area post scripts
            bundles.Add(new ScriptBundle("~/admin/post/scripts").Include(
                "~/areas/admin/scripts/posteditor.js"));

            //Main scripts
            bundles.Add(new ScriptBundle("~/scripts").Include(
                "~/scripts/jquery-3.1.0.js",
                "~/scripts/jquery-validate.js",
                "~/scripts/jquery-validate.unobtrusive.js",
                "~/scripts/bootstrap.js"));
        }
    }
}