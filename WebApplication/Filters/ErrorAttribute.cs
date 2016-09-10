using System;
using System.Text;
using System.Web.Mvc;
using log4net;

namespace HRM.Webpages.Filters
{
    public class ErrorAttribute : HandleErrorAttribute
    {
        private static readonly ILog log = LogManager.GetLogger("LOG");

        public override void OnException(ExceptionContext filterContext)
        {
            var error = new StringBuilder();
            error.AppendLine(filterContext.Exception.Message);
            foreach (var param in filterContext.RouteData.Values.Keys)
                error.AppendFormat(@"/{0}={1}", param, filterContext.RouteData.Values[param]);
            if (filterContext.RouteData.Values.Keys.Count > 0) error.AppendLine();
            foreach (string name in filterContext.RequestContext.HttpContext.Request.Form.Keys)
                error.AppendFormat(@"/{0}={1}", name, filterContext.RequestContext.HttpContext.Request.Form[name]);
            if (filterContext.RequestContext.HttpContext.Request.Form.Keys.Count > 0) error.AppendLine();
            error.Append(filterContext.Exception.StackTrace);
            log.Error(error);
            base.OnException(filterContext);
        }
    }
}