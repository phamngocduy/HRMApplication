using System;
using System.Web.Mvc;

using HRM.Accounts.Filters;
namespace HRM.Accounts.Controllers
{
    public class LogoutController : Controller
    {
        [HttpPost]
        public ActionResult Index()
        {
            Membership.Logout();
            return Redirect("~/");
        }
    }
}
