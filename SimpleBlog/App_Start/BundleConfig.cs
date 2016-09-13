using System.Web.Optimization;
using NHibernate.Mapping.ByCode;

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

            //Scripts
            bundles.Add(new ScriptBundle("~/admin/scripts")
                .Include("~/scripts/jquery-3.1.0.js")
                .Include("~/scripts/jquery-validate.js")
                .Include("~/scripts/jquery-validate.unobtrusive.js")
                .Include("~/scripts/bootstrap.js")
                .Include("~/areas/admin/scripts/forms.js"));
           
            bundles.Add(new ScriptBundle("~/scripts")
                .Include("~/scripts/jquery-3.1.0.js")
                .Include("~/scripts/jquery-validate.js")
                .Include("~/scripts/jquery-validate.unobtrusive.js")
                .Include("~/scripts/bootstrap.js"));
        }
    }
}