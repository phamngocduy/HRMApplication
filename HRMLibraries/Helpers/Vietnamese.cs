using System;
using System.IO;
using System.Web;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace HRM.Webpages.Helpers
{
    public class Themes
    {
        static Themes()
        {
            list = new List<string[]>();
            var path = HttpContext.Current.Request.PhysicalApplicationPath;
            path += @"\Content\themes\themes.list";
            try
            {
                using (var reader = new StreamReader(path))
                    foreach (var theme in reader.ReadToEnd().Split('\n'))
                        if (!theme.Trim().Equals(""))
                            list.Add(theme.Split(';'));
            }
            catch (Exception) { }
        }

        private static List<string[]> list;
        public static List<string[]> List
        {
            get { return list; }
        }
    }

    public class Vietnamese
    {
        public static bool IsLoaded { get; private set; }

        private static string filename = "";
        public static void Reload() { Initialize(filename); }

        public static void Initialize(string path)
        {
            filename = path;
            Hashtable table = null;
            using (var file = new StreamReader(path))
                new List<string>(file.ReadToEnd().Split('\n')).ForEach(
                    line =>
                    {
                        line = line.Trim();
                        if (!String.IsNullOrEmpty(line))
                        {
                            if (Regex.Match(line.ToLower(), @"\[([a-z0-9]+)/([a-z0-9]+)\]", RegexOptions.IgnoreCase).Success)
                                local[line.ToLower()] = (table = new Hashtable());
                            else
                            {
                                var tuble = line.Split('=');
                                if (tuble.Length == 2)
                                {
                                    tuble[0] = tuble[0].Trim();
                                    tuble[1] = tuble[1].Trim();
                                    global[tuble[0]] = tuble[1];
                                    if (table != null)
                                        table[tuble[0]] = tuble[1];
                                }
                            }
                        }
                    });
            Vietnamese.IsLoaded = true;
        }

        private static Hashtable global = new Hashtable();
        private static Hashtable local = new Hashtable();

        public static string T(string controller, string action, string text)
        {
            text = text.Trim();
            string value = null;
            var route = String.Format(@"[{0}/{1}]", controller, action).ToLower();
            if (local[route] != null)
                value = (local[route] as Hashtable)[text] as string;
            if (value != null) return value;
            if (global[text] != null)
                return global[text].ToString();
            return text;
        }
    }
}