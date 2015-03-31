using System.Web;
using System.Web.Optimization;

namespace TXWomen
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/Sleek-Theme").Include(
          "~/Scripts/Sleek-Theme/bootstrap.min.js", "~/Scripts/Sleek-Theme/contact.js",
          "~/Scripts/Sleek-Theme/gmaps.js", "~/Scripts/Sleek-Theme/jquery.countdown.min.js",
          "~/Scripts/Sleek-Theme/jquery.easing.min.js", "~/Scripts/Sleek-Theme/jquery.flexslider.js",
          "~/Scripts/Sleek-Theme/jquery.js", "~/Scripts/Sleek-Theme/jquery.ketchup.all.min.js",
          "~/Scripts/Sleek-Theme/jquery.prettyphoto.js", "~/Scripts/Sleek-Theme/main.js",
          "~/Scripts/Sleek-Theme/modernizr.custom.js", "~/Scripts/Sleek-Theme/owl.carousel.js",
          "~/Scripts/Sleek-Theme/owl.carousel.min.js", "~/Scripts/Sleek-Theme/shBrushCss.js",
          "~/Scripts/Sleek-Theme/shBrushJScript.js", "~/Scripts/Sleek-Theme/shBrushXml.js",
          "~/Scripts/Sleek-Theme/shCore.js", "~/Scripts/Sleek-Theme/styleswitch.js"
          ));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));

              bundles.Add(new StyleBundle("~/Content/sleek-theme").Include(
                      "~/Content/sleek-theme/bootstrap.css", "~/Content/sleek-theme/flexslider.css",
                      "~/Content/sleek-theme/font-awesome.css", "~/Content/sleek-theme/font-awesome.min.css", 
                      "~/Content/sleek-theme/forms.css", "~/Content/sleek-theme/grid.css", "~/Content/sleek-theme/ie.css", 
                      "~/Content/sleek-theme/owl.carousel.css", "~/Content/sleek-theme/owl.theme.css", 
                      "~/Content/sleek-theme/owl.transitions.css", "~/Content/sleek-theme/prettyphoto.css", 
                      "~/Content/sleek-theme/print.css", "~/Content/sleek-theme/reset.css", 
                      "~/Content/sleek-theme/screen.css", "~/Content/sleek-theme/slick.css", 
                      "~/Content/sleek-theme/style.css", "~/Content/sleek-theme/SyntaxHighlighter.css", 
                      "~/Content/sleek-theme/typography.css"
                      ));
        }
    }
}
