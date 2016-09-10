using System;
using System.IO;
using System.Reflection;

namespace HRM.Services
{
    public class Services
    {
        protected static Type LoadServices(string assembly, string services)
        {
            assembly = Path.Combine(AssemblyDirectory, assembly);
            return Assembly.LoadFrom(assembly).GetType(services);
        }
        protected static MethodInfo LoadMethod(Type service, string method)
        {
            return service.GetMethod(method, BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic);
        }
        public static string AssemblyDirectory
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }

        public static void LoadAllServices()
        {
            Webpages.LoadServices();
            Extension.LoadServices();
            QLDanhMuc.LoadServices();
            QLTTNhanSu.LoadServices();
        }
    }
}
