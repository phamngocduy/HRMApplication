using System;
using System.IO;
using System.Web;
using System.Web.Optimization;

namespace HRM.Webpages
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.cookie.js",
                        "~/Scripts/jquery.form.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.min.js",
                        "~/Scripts/jquery-ui.block.js",
                        "~/Scripts/jquery-ui.combobox.js",
                        "~/Scripts/jquery-ui.datepicker-vi.js",
                        "~/Scripts/jquery-ui.multicomplete.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate.js",
                        "~/Scripts/jquery.validate.unobtrusive.js",
                        "~/Scripts/jquery.unobtrusive-ajax.js",
                        "~/Scripts/jquery.date.validate-vi.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/site.css",
                        "~/Content/tooltips.css",
                        "~/Content/combobox.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));

            try
            {
                var path = HttpContext.Current.Request.PhysicalApplicationPath;
                path += @"\Content\themes\themes.list";
                using (var reader = new StreamReader(path))
                    foreach (var theme in reader.ReadToEnd().Split('\n'))
                        if (!theme.Trim().Equals(""))
                        {
                            var name = theme.Split(';')[0].Trim();
                            bundles.Add(new StyleBundle("~/Content/themes/" + name)
                                   .Include("~/Content/themes/" + name + "/jquery-ui.min.css",
                                            "~/Content/themes/" + name + "/jquery-ui.theme.css"));
                        }
            }
            catch (Exception)
            {
                bundles.Add(new StyleBundle("~/Content/themes/redmond")
                       .Include("~/Content/themes/redmond/jquery-ui.min.css",
                                "~/Content/themes/redmond/jquery-ui.theme.css"));
            }

            bundles.Add(new StyleBundle("~/Content/jqsuite/css").Include(
                        "~/Content/jqsuite/ui.jqgrid.css",
                        "~/Content/jqsuite/ui.jqtreeview.css",
                        "~/Content/jqsuite/ui.jqdropdownlist.css"));

            bundles.Add(new ScriptBundle("~/bundles/jqsuite").Include(
                       "~/Scripts/jqsuite/i18n/grid.locale-en.js",
                       "~/Scripts/jqsuite/jquery.jqgrid.min.js"));

            bundles.Add(new StyleBundle("~/Content/datatables/css").Include(
                        "~/Content/datatables/jquery.datatables.css",
                        "~/Content/datatables/jquery.tabletools.css"));

            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                       "~/Scripts/datatables/DataTablesWithFilter.js",
                       "~/Scripts/datatables/ColReorderWithResize.js",
                       "~/Scripts/datatables/RowReorderingDragDrop.js",
                       "~/Scripts/datatables/DataTablesDDMMYYYY.js",
                       "~/Scripts/datatables/DataTablesZeroClipboard.js",
                       "~/Scripts/datatables/DataTablesTableTools.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/bootstrap/bootstrap.js"));
            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                        "~/Content/bootstrap/bootstrap.css"));
        }
    }
}