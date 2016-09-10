using System;
using System.Linq;

using HRM.Webpages;
using HRM.Accounts.Models;
namespace HRM.Accounts.Filters
{
    public class Membership
    {
        public static void Initialize(bool autoCreateTables = false)
        {
            if (WebMatrix.WebData.WebSecurity.Initialized == false)
                WebMatrix.WebData.WebSecurity.InitializeDatabaseConnection(Resources.AuthConnection, "UserProfile", "UserId", "UserName", autoCreateTables);
        }

        public static void CreateUserAndAccount(string userName, string password, object propertyValues = null, bool requireConfirmationToken = false)
        {
            Initialize();
            WebMatrix.WebData.WebSecurity.CreateUserAndAccount(userName, password, propertyValues, requireConfirmationToken);
        }

        public static void CreateRole(string roleName)
        {
            Initialize();
            System.Web.Security.Roles.CreateRole(roleName);
        }

        public static void AddUserToRole(string username, string roleName)
        {
            Initialize();
            System.Web.Security.Roles.AddUserToRole(username, roleName);
        }

        public static bool Login(string userName, string password, bool persistCookie = false)
        {
            Initialize();
            return WebMatrix.WebData.WebSecurity.Login(userName, password, persistCookie);
        }

        public static void Logout()
        {
            Initialize();
            WebMatrix.WebData.WebSecurity.Logout();
        }

        public static bool ValidateUser(string username, string password)
        {
            Initialize();
            return System.Web.Security.Membership.ValidateUser(username, password);
        }

        public static bool ChangePassword(string userName, string currentPassword, string newPassword)
        {
            Initialize();
            return WebMatrix.WebData.WebSecurity.ChangePassword(userName, currentPassword, newPassword);
        }

        public static string GeneratePasswordResetToken(string userName)
        {
            Initialize();
            return WebMatrix.WebData.WebSecurity.GeneratePasswordResetToken(userName);
        }

        public static bool ResetPassword(string passwordResetToken, string newPassword)
        {
            Initialize();
            return WebMatrix.WebData.WebSecurity.ResetPassword(passwordResetToken, newPassword);
        }

        public static void DeleteUser(string userName, bool deleteAllRelatedData)
        {
            Initialize();
            System.Web.Security.Membership.Provider.DeleteUser(userName, deleteAllRelatedData);
        }
        /*
        private static UsersContext usersContext;
        public static UsersContext UsersContext
        {
            get
            {
                if (usersContext == null)
                    usersContext = new UsersContext();
                return usersContext;
            }
        }
        */
        public static bool IsAdmin(string userName)
        {
            using (var context = new UsersContext())
            {
                var user = context.UserProfiles.SingleOrDefault(u => u.UserName == userName);
                if (user == null) return false;
                return user.GetRoles().Where(r => r.RoleId == 1).Count() > 0;
            }
        }

        public static System.Web.Security.MembershipUser GetUser(string userName)
        {
            return System.Web.Security.Membership.GetUser(userName);
        }
        public static int GetUserId(string userName)
        {
            return (int)GetUser(userName).ProviderUserKey;
        }
    }
}