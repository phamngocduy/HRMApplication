using System;
using System.Text;
using System.Web.Mvc;
using log4net;

namespace HRM.Webpages.Filters
{
    public class LogAttribute : ActionFilterAttribute
    {
        private static readonly ILog log = LogManager.GetLogger("LOG");

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var info = new StringBuilder();
            info.AppendFormat("{0}/{1}", filterContext.RouteData.Values["controller"], filterContext.RouteData.Values["action"]);
            foreach (string name in filterContext.RequestContext.HttpContext.Request.QueryString.Keys)
                if (name.ToLower().Contains("id"))
                    info.AppendFormat(@"&{0}={1}", name, filterContext.RequestContext.HttpContext.Request.QueryString[name]);
            foreach (string name in filterContext.RequestContext.HttpContext.Request.Form.Keys)
                if (name.ToLower().Contains("id"))
                    info.AppendFormat(@"&{0}={1}", name, filterContext.RequestContext.HttpContext.Request.Form[name]);
            log.Info(info.ToString());
        }
    }
}