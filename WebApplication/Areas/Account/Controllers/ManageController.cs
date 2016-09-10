using System;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Script.Serialization;

using HRM.Accounts.Models;
using HRM.Accounts.Filters;
namespace HRM.Accounts.Controllers
{
    public class ManageController : Controller
    {
        public ActionResult Index()
        {
            return View(new ManageViewModel(User.Identity.Name));
        }

        [HttpPost, ActionName("Index")]
        public ActionResult Manage()
        {
            return View("Manage");
        }

        [HttpPost]
        public ActionResult ChangeUserName(ChangeUserNameModel model)
        {
            if (ModelState.IsValid)
            {
                if (Membership.ValidateUser(User.Identity.Name, model.Password))
                    using (var context = new UsersContext())
                    {
                        var user = context.UserProfiles.SingleOrDefault(u => u.UserName == model.UserName);
                        if (user == null)
                        {
                            user = context.UserProfiles.SingleOrDefault(u => u.UserName == User.Identity.Name);
                            if (user != null)
                            {
                                user.UserName = model.UserName;
                                context.Entry(user).State = EntityState.Modified;
                                context.SaveChanges();
                                Membership.Logout();
                                Membership.Login(model.UserName, model.Password);
                                ViewBag.StatusMessage = "Your user name has been changed.";
                            }
                        }
                        else ModelState.AddModelError("", "The current user name is duplicate or incorrect.");
                    }
                else ModelState.AddModelError("", "The current password provided is incorrect.");
            }
            return View("Index", new ManageViewModel(model.UserName));
        }

        [HttpPost]
        public ActionResult ChangePassword(ChangePasswordModel model)
        {
            if (ModelState.IsValid)
            {
                // ChangePassword will throw an exception rather than return false in certain failure scenarios.
                bool changePasswordSucceeded;
                try
                {
                    changePasswordSucceeded = Membership.ChangePassword(User.Identity.Name, model.OldPassword, model.NewPassword);
                }
                catch (Exception)
                {
                    changePasswordSucceeded = false;
                }

                if (changePasswordSucceeded)
                    ViewBag.StatusMessage = "Your password has been changed.";
                else
                    ModelState.AddModelError("", "The current password is incorrect or the new password is invalid.");
            }
            return View("Index", new ManageViewModel(User.Identity.Name));
        }

        [HttpPost]
        public ActionResult ResetPassword(ResetPasswordModel model)
        {
            if (ModelState.IsValid)
                using (var context = new UsersContext())
                {
                    var user = context.UserProfiles.SingleOrDefault(u => u.UserId == model.UserId);
                    if (user != null)
                    {
                        var token = Membership.GeneratePasswordResetToken(user.UserName);
                        if (Membership.ResetPassword(token, model.NewPassword))
                            ViewData["Message"] = "The password has been reset.";
                        else ViewData["Message"] = "The new password is invalid.";
                    }
                }
            FormToViewData();
            return View("Manage");
        }

        [HttpPost]
        public ActionResult DeleteAccount(DeleteAccountModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.UserId == 1)
                    ModelState.AddModelError("DeleteAccount", "Cannot delete 1st administrator.");
                else
                    using (var context = new UsersContext())
                    {
                        var user = context.UserProfiles.SingleOrDefault(u => u.UserId == model.UserId);
                        if (user != null)
                        {
                            Membership.DeleteUser(user.UserName, true);
                            ViewData["Message"] = "User has been successfully deleted.";
                        }
                    }
            }
            FormToViewData();
            return View("Manage");
        }

        [HttpPost]
        public ActionResult RegisterUser(RegisterUserModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Membership.CreateUserAndAccount(model.Account, model.Password, new { CreationDate = DateTime.Now, LastActivityDate = DateTime.Now });
                    ViewData["Message"] = "Account created successfully and ready to use.";
                }
                catch (System.Web.Security.MembershipCreateUserException e)
                {
                    ModelState.AddModelError("RegisterUser", ErrorCodeToString(e.StatusCode));
                }
            }
            ViewBag.Account = model.Account;
            FormToViewData();
            return View("Manage");
        }

        [HttpPost]
        public ActionResult SetPermission(SetPermissionModel model)
        {
            if (ModelState.IsValid)
                using (var context = new UsersContext())
                {
                    var insert = model.Permissions.Trim().Split(' ').Where(s => !String.IsNullOrEmpty(s));
                    model.Permissions = String.IsNullOrEmpty(model.Permissions) ? "" : model.Permissions;
                    var delete = context.UsersInRoles.Where(p => p.UserId == model.UserId);
                    foreach (var permission in delete)
                        context.UsersInRoles.Remove(permission);
                    foreach (var permission in insert)
                        context.UsersInRoles.Add(new UserInRole() { UserId = model.UserId, RoleId = int.Parse(permission) });
                    context.SaveChanges();
                }
            ViewBag.Permissions = model.Permissions;
            FormToViewData();
            return View("Manage");
        }

        public string ListPermissions()
        {
            using (var context = new UsersContext())
                return new JavaScriptSerializer().Serialize(
                    (from role in context.RoleProfiles select role)
                    .AsEnumerable().Select(role => new { RoleId = role.RoleId, RoleName = role.RoleName }));
        }

        #region Helpers
        private void FormToViewData()
        {
            if (Request != null) // for testing
                foreach (var key in Request.Form.AllKeys)
                    ViewData[key] = Request.Form[key];
        }
        private static string ErrorCodeToString(System.Web.Security.MembershipCreateStatus createStatus)
        {
            // See http://go.microsoft.com/fwlink/?LinkID=177550 for
            // a full list of status codes.
            switch (createStatus)
            {
                case System.Web.Security.MembershipCreateStatus.DuplicateUserName:
                    return "User name already exists. Please enter a different user name.";

                case System.Web.Security.MembershipCreateStatus.DuplicateEmail:
                    return "A user name for that e-mail address already exists. Please enter a different e-mail address.";

                case System.Web.Security.MembershipCreateStatus.InvalidPassword:
                    return "The password provided is invalid. Please enter a valid password value.";

                case System.Web.Security.MembershipCreateStatus.InvalidEmail:
                    return "The e-mail address provided is invalid. Please check the value and try again.";

                case System.Web.Security.MembershipCreateStatus.InvalidAnswer:
                    return "The password retrieval answer provided is invalid. Please check the value and try again.";

                case System.Web.Security.MembershipCreateStatus.InvalidQuestion:
                    return "The password retrieval question provided is invalid. Please check the value and try again.";

                case System.Web.Security.MembershipCreateStatus.InvalidUserName:
                    return "The user name provided is invalid. Please check the value and try again.";

                case System.Web.Security.MembershipCreateStatus.ProviderError:
                    return "The authentication provider returned an error. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                case System.Web.Security.MembershipCreateStatus.UserRejected:
                    return "The user creation request has been canceled. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                default:
                    return "An unknown error occurred. Please verify your entry and try again. If the problem persists, please contact your system administrator.";
            }
        }
        #endregion
    }
}
