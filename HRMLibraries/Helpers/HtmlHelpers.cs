using System;
using System.Web;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Threading;
using System.Collections;
using System.Web.Mvc.Html;
using System.Globalization;
using System.ComponentModel;
using System.Linq.Expressions;

using HRM.Libraries;
using HRM.Webpages.Models.Trirand;
namespace HRM.Webpages.Helpers
{
    public static class HtmlHelpers
    {
        public static int[] ToIntList(this HtmlHelper helper, object data)
        {
            if (String.IsNullOrEmpty(data as string)) return new int[] { 0 };
            return (from s in data.ToString().Split(',') select int.Parse(s)).ToArray();
        }

        public static string Root(this HtmlHelper helper)
        {
            var path = HttpRuntime.AppDomainAppVirtualPath;
            if (path.Trim() == "/") path = "";
            return path;
        }

        #region Html
        public static string ReturnUrl(this HtmlHelper helper)
        {
            if (helper.ViewContext.RouteData.Values["Controller"].Equals("Login"))
                return helper.ViewData["ReturnUrl"] as string;
            return helper.ViewContext.HttpContext.Request.RawUrl;
        }

        public static IHtmlString ValidationInfo(this HtmlHelper helper)
        {
            return MvcHtmlString.Create(new StringBuilder()
                .Append(@"<div class=""validation-summary-valid"" data-valmsg-summary=""true"">")
                .Append(@"<ul><li style=""display:none""></li></ul></div>").ToString());

        }

        public static IHtmlString StatusMessage(this HtmlHelper helper)
        {
            return MvcHtmlString.Create(new StringBuilder()
                .Append(@"<p class=""message-success"">")
                .Append(helper.ViewData["StatusMessage"])
                .Append(@"</p>").ToString());
        }
        public static IHtmlString StatusMessage(this HtmlHelper helper, object message)
        {
            return MvcHtmlString.Create(String.Format(@"<p class=""message-success"">{0}</p>", VN(helper, message as string)));
        }
        public static IHtmlString ValidationSummary(this HtmlHelper helper, object modelState)
        {
            var ModelState = modelState as ModelStateDictionary;
            if (ModelState != null)
                foreach (var key in ModelState.Keys)
                    foreach (var error in ModelState[key].Errors)
                        helper.ViewData.ModelState.AddModelError(key, error.ErrorMessage);
            return helper.ValidationSummary(false, String.Empty);
        }

        public static IHtmlString LocationAnchor(this HtmlHelper helper, string id)
        {
            return MvcHtmlString.Create(String.Format(@"<script>window.location.hash=""#{0}""</script>", id));
        }

        public static IHtmlString BeginDiv(this HtmlHelper helper)
        {
            return MvcHtmlString.Create(@"<div style=""box-shadow: 10px 10px 5px #888888; margin-left: 20%; margin-right: 20%;"">");
        }
        public static IHtmlString EndDiv(this HtmlHelper helper)
        {
            return MvcHtmlString.Create(@"</div>");
        }

        public static MvcHtmlString LabelForVN<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression)
        {
            return html.LabelFor(expression, html.VN((expression.Body as MemberExpression).Member.Name));
        }
        public static MvcHtmlString LabelForVN<TModel, TValue>(this HtmlHelper<TModel> html, string prefix, Expression<Func<TModel, TValue>> expression, string suffix)
        {
            return html.LabelFor(expression, prefix + html.VN((expression.Body as MemberExpression).Member.Name) + suffix);
        }
        public static MvcHtmlString DisplayNameForVN<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression)
        {
            return MvcHtmlString.Create(html.VN((expression.Body as MemberExpression).Member.Name));
        }
        #endregion

        #region jqUI
        public static IHtmlString jqTabs(this HtmlHelper helper, string id)
        {
            return MvcHtmlString.Create(new StringBuilder()
                .AppendLine(@"<script>")
                .AppendFormat(@"$(""#{0}"").tabs();", id).AppendLine()
                .Append(@"</script>").ToString());
        }

        public static IHtmlString jqTabs(this HtmlHelper helper, string id, string callback)
        {
            return MvcHtmlString.Create(new StringBuilder()
                .AppendLine(@"<script>")
                .AppendFormat(@"$(""#{0}"").tabs({{", id).AppendLine()
                .Append("\t").AppendLine(@"activate: function (e, ui) {")
                .Append("\t\t").AppendFormat(@"{0}(ui.newTab);", callback).AppendLine()
                .Append("\t").AppendLine(@"}});")
                .Append(@"</script>").ToString());
        }

        public static IHtmlString jqButton(this HtmlHelper helper, string id)
        {
            return MvcHtmlString.Create(new StringBuilder()
                .AppendLine(@"<script>")
                .AppendFormat(@"$(""#{0}"").button();", id).AppendLine()
                .Append(@"</script>").ToString());
        }

        public static IHtmlString jqButton(this HtmlHelper helper, string id, string callback)
        {
            return MvcHtmlString.Create(new StringBuilder()
                .AppendLine(@"<script>")
                .AppendFormat(@"$(""#{0}"").button().click(function (event) {{", id).AppendLine()
                .Append("\t").AppendLine(@"event.preventDefault();")
                .Append("\t").Append(callback).AppendLine(@"(event);")
                .Append(@"</script>").ToString());
        }
        #endregion

        #region jqGrid
        public static IHtmlString jqGrid(this HtmlHelper helper, string id, Grid grid, object model)
        {
            var html = new StringBuilder();
            html.AppendLine(@"<style type=""text/css"">")
                .AppendLine(@".ui-pg-input { width: auto; height: auto; padding: 3px; }")
                .AppendLine(@"</style>")
                .AppendLine(@"<script>")
                .AppendFormat(@"$(""#{0}"").jqGrid({{", id).AppendLine();
            if (model is String)
                html.Append("\t").AppendFormat(@"url: ""{0}"",", model).AppendLine()
                    .Append("\t").AppendLine(@"datatype: ""json"",");
            else
                html.Append("\t").AppendLine(@"datatype: ""local"",");
            html.Append("\t").AppendFormat(@"colNames: [{0}],", grid.GetColumnNames()).AppendLine()
                .Append("\t").AppendLine(@"colModel: [");
            foreach (var column in grid.Columns)
                html.Append("\t").AppendLine(grid.GetColumnModel(column));
            html.Append("\t").AppendLine(@"],")
                .Append(grid.GetPropertyValues())
                .Append(grid.GetEventHandlers(id))
                .AppendFormat(@"}}){0};", grid.GetNavigatorValues()).AppendLine();
            if (model is IEnumerable && !(model is String))
            {
                html.AppendFormat(@"var {0}Data = [", id).AppendLine();
                var cultureInfo = Thread.CurrentThread.CurrentCulture;
                Thread.CurrentThread.CurrentCulture = new CultureInfo(Resources.CultureInfo);
                foreach (var data in model as IEnumerable)
                {
                    html.Append(@"{");
                    foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(data))
                        if (!descriptor.ComponentType.GetProperty(descriptor.Name).GetGetMethod().IsVirtual)
                            html.AppendFormat(@" {0}: ""{1}"",", descriptor.Name, descriptor.GetValue(data));
                    html.AppendLine(@" },");
                }
                Thread.CurrentThread.CurrentCulture = cultureInfo;
                html.AppendLine(@"];")
                    .AppendFormat(@"for (i=0; i<{0}Data.length; i++)", id).AppendLine().Append("\t")
                    .AppendFormat(@"$(""#{0}"").jqGrid(""addRowData"", i+1, {0}Data[i]);", id).AppendLine();
            }
            if (grid.Selected != null)
            {
                html.AppendFormat(@"$(""#{0}"").resetSelection();", id).AppendLine();
                foreach (var row in grid.Selected)
                    html.AppendFormat(@"$(""#{0}"").setSelection({1}, true);", id, row).AppendLine();
            }
            html.AppendFormat(@"$(""input#cb_{0}.cbox"").hide();", id).AppendLine()
                .AppendLine(@"</script>");
            return MvcHtmlString.Create(html.ToString());
        }

        public static IHtmlString jqGridInfo(this HtmlHelper helper, string caption, string message)
        {
            return MvcHtmlString.Create(String.Format(@"$.jgrid.info_dialog({0}, {1}, $.jgrid.edit.bClose);", caption, message));
        }
        public static IHtmlString jqGridError(this HtmlHelper helper, string message)
        {
            return MvcHtmlString.Create(String.Format(@"$.jgrid.info_dialog($.jgrid.errors.errcap, ""<div class='ui-state-error'>""+{0}+""</div>"", $.jgrid.edit.bClose);", message));
        }
        #endregion

        #region dataTables
        public static IHtmlString dataTables(this HtmlHelper helper, string id)
        {
            return MvcHtmlString.Create(String.Format(@"$(""#{0}"").dataTable({{ ""bStateSave"": true, ""bJQueryUI"": true, ""sDom"": ""Rlfrtip"", ""aLengthMenu"": [[10, 25, 50, -1], [10, 25, 50, ""All""]] }});", id));
        }

        public static IHtmlString Datatable(this HtmlHelper helper, string id)
        {
            return MvcHtmlString.Create(String.Format(@"$(function(){{$(""#{0}"").dataTable({{""bAutoWidth"":true,""bStateSave"":true,""aLengthMenu"":[[10,25,50,-1],[10,25,50,""All""]]}});}});", id));
        }
        #endregion

        #region Vietnamese
        public static string VN(this HtmlHelper helper, string text)
        {
            if (String.IsNullOrEmpty(text)) return String.Empty;
            if (!Vietnamese.IsLoaded)
                Vietnamese.Initialize(HttpContext.Current.Server.MapPath(Resources.Vietnamese));
            return Vietnamese.T(helper.ViewContext.RouteData.Values["controller"].ToString(),
                                helper.ViewContext.RouteData.Values["action"].ToString(), text);
        }
        #endregion

        public static string ToShortDateString(this DateTime? date)
        {
            return date.HasValue ? date.Value.ToShortDateString() : null;
        }
    }
}