using System;
using System.Linq;
using HRM.Accounts.Models;
namespace HRM.Webpages.Services
{
    public class AuthenticationServices
    {
        public static string[] getUsernames()
        {
            return new UsersContext().UserProfiles.Select(u => u.UserName).ToArray();
        }
    }
}