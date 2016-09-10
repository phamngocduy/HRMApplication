using System;
using System.Web.Mvc;

using HRM.Accounts.Models;
using HRM.Accounts.Filters;
namespace HRM.Accounts.Controllers
{
    [InitializeMembership]
    public class LoginController : Controller
    {
        [AllowAnonymous]
        public Object Index(string returnUrl, string statusMessage, bool partial = false)
        {
            ViewBag.ReturnUrl = returnUrl;
            ViewBag.StatusMessage = statusMessage;
            return partial ? (object)PartialView() : (object)View();
        }

        [HttpPost]
        public ActionResult Index(LoginModel model, string returnUrl)
        {
            if (ModelState.IsValid && Membership.Login(model.UserName, model.Password, persistCookie: model.RememberMe))
            {
                return RedirectToLocal(returnUrl);
            }

            // If we got this far, something failed, redisplay form
            ModelState.AddModelError("", "The user name or password provided is incorrect.");
            return View(model);
        }

        #region Helpers
        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
                return Redirect(returnUrl);
            else return Redirect("~/");
        }
        #endregion
    }
}
