using System.Web;
using System.Web.Optimization;

namespace Web.Journey
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/libs").Include(
                "~/Scripts/libs/knockout-2.1.0.js",
                "~/Scripts/libs/jquery-1.7.1.js",
                "~/Scripts/libs/modernizr-2.5.3.js"));
            bundles.Add(new ScriptBundle("~/Scripts/PJourneyJavaScripts").Include(
                "~/Scripts/PJourneyJavaScripts/script.js",
                "~/Scripts/PJourneyJavaScripts/ErrorMessages.js",
                "~/Scripts/PJourneyJavaScripts/PersonalDetails.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));




        }
    }
}