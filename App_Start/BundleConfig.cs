using System.Web;
using System.Web.Optimization;

namespace KenticoMVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region CSS

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/mystyles.css",
                "~/Content/site.css"));

            #endregion

            #region JS

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-*"));

            #endregion
        }
    }
}
