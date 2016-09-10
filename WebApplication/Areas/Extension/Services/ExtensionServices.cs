using System;
using System.Linq;
using HRM.Extension.Databases.Models;
namespace HRM.Extension.Services
{
    public class ExtensionServices
    {
        public static void SendMessage(string users, string content)
        {
            using (var db = new HRMDB0Entities())
            {
                var message = new Message
                {
                    Date = DateTime.Now,
                    Content = content,
                    Read = "", Star = ""
                };
                if (users.Contains("*"))
                    users = String.Join(",", HRM.Services.Webpages.getUsernames());
                message.Users = String.Join("", users.Split(',')
                    .Select(u => String.Format("|{0}|", u.Trim().ToLower())).ToArray());
                db.Message.Add(message);
                db.SaveChanges();

            }
        }
    }
}