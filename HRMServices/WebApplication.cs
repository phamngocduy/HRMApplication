using System;
using System.Web;
using System.Reflection;

using HRM.Databases.Models;
namespace HRM.Services
{
    public class Webpages : Services
    {
        private static Type Library = null;
        public static void LoadServices()
        {
            Library = LoadServices("HRM.Webpages.dll", // library
                                    "HRM.Webpages.Services.AuthenticationServices");
        }

        public static string[] getUsernames()
        {
            return LoadMethod(Library, "getUsernames")
                .Invoke(null, new object[] { }) as string[];
        }
    }
}
