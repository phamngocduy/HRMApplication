using System;
using System.Data;
using System.Linq;

using HRM.Webpages;
using HRM.Accounts.Models;
namespace HRM.Accounts.Filters
{
    public class DatabaseInitializer
    {
        public static void InitializeAdministrator()
        {
            Membership.CreateUserAndAccount(Resources.AdminUserName, Resources.AdminPassword,
                new { CreationDate = DateTime.Now, LastActivityDate = DateTime.Now });
            Membership.CreateRole(Resources.AdminRoleName);
            Membership.AddUserToRole(Resources.AdminUserName, Resources.AdminRoleName);
        }

        public static void InitializePermissions()
        {
            using (var context = new UsersContext())
            {
                context.RoleProfiles.Add(new RoleProfile("Administration"));
                context.UsersInRoles.Add(new UserInRole() { UserId = 1, RoleId = 1 });
                var role = new RoleProfile("Quản trị danh mục");
                context.RoleProfiles.Add(role);
                context.SaveChanges();
            }
        }
    }
}
