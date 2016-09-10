using System;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using HRM.Webpages.Helpers;
using HRM.Extension.Services;
using HRM.Extension.Databases.Models;
namespace HRM.Extension.Controllers
{
    public class MessageController : Controller
    {
        private string Username
        {
            get
            {
                return String.Format("|{0}|", User.Identity.Name.ToLower());
            }
        }

        HRMDB0Entities db = new HRMDB0Entities();

        public ActionResult Index()
        {
            return View(db.Message.Where(m => m.Users.Contains(Username)));
        }
        public PartialViewResult Partial(string all)
        {
            return PartialView("Index", db.Message.Where(m => all == "1" || m.Users.Contains(Username)));
        }

        public PartialViewResult Details(int id)
        {
            var msg = db.Message.Find(id);
            msg.Read += Username;
            db.Entry(msg).State = EntityState.Modified;
            db.SaveChanges();
            return PartialView(msg);
        }

        [HttpPost]
        public string Unread(int id)
        {
            try
            {
                var msg = db.Message.Find(id);
                msg.Read = (msg.Read ?? "").Replace(Username, "");
                db.Entry(msg).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return null;
        }

        [HttpPost]
        public string Delete(int id)
        {
            try
            {
                var msg = db.Message.Find(id);
                msg.Users = (msg.Users ?? "").Replace(Username, "");
                db.Entry(msg).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return null;
        }

        public PartialViewResult Compose()
        {
            return PartialView();
        }
        [HttpPost]
        public string Send(Message model)
        {
            try
            {
                ExtensionServices.SendMessage(model.Users, model.Content);
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return null;
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
