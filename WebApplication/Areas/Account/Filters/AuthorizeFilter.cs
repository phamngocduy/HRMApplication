using System;
using System.Linq;
using System.Web.Mvc;
using HRM.Accounts.Models;
namespace HRM.Accounts.Filters
{
    public class AuthorizeFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.ActionDescriptor.ControllerDescriptor.ControllerName == "Home" ||
                filterContext.HttpContext.Request.Path.Contains("/Account/") ||
                filterContext.ActionDescriptor.ControllerDescriptor.ControllerName == "Login" ||
                filterContext.ActionDescriptor.ControllerDescriptor.ControllerName == "Logout")
            {
                base.OnActionExecuting(filterContext);
                return;
            }

            if (!filterContext.HttpContext.User.Identity.IsAuthenticated)
                filterContext.Result = new EmptyResult();
            else
            {
                if (Membership.IsAdmin(filterContext.HttpContext.User.Identity.Name))
                {
                    base.OnActionExecuting(filterContext);
                    return;
                }
                var action = filterContext.ActionDescriptor.ActionName;
                var controller = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName + "Controller";
                if (filterContext.RequestContext.HttpContext.Request.HttpMethod == "POST")
                    action = action + "P";
                using (var context = new UsersContext())
                {
                    var user = context.UserProfiles.Single(u => u.UserName == filterContext.HttpContext.User.Identity.Name);
                    foreach (var role in user.GetRoles())
                        foreach (var behavior in role.GetBehaviors())
                            if (behavior.Controller.Split(':').Contains(controller)
                                && (behavior.Action.Equals("*") ||
                                behavior.Action.Split('/').Contains(action)))
                            {
                                base.OnActionExecuting(filterContext);
                                return;
                            }
                }
                filterContext.Result = new EmptyResult();
            }
        }
    }
}
