using System;
using System.Web;
using System.Reflection;

using HRM.Databases.Models;
namespace HRM.Services
{
    public class Extension : Services
    {
        private static Type Library = null;
        public static void LoadServices()
        {
            Library = LoadServices("HRM.Extension.dll", // library
                                   "HRM.Extension.Services.ExtensionServices");
        }

        public static void SendMessage(string users, string content)
        {
            LoadMethod(Library, "SendMessage")
                .Invoke(null, new object[] { users, content });
        }
    }
}
