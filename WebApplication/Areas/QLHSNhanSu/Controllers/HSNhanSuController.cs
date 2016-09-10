using System;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;

using HRM.Databases.Models;
using HRM.Webpages.Helpers;
namespace HRM.QLTTNhanSu.Controllers
{
    public class HSNhanSuController : Controller
    {
        private HRMDBEntities db = new HRMDBEntities();

        public ActionResult Menu()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Download()
        {
            ViewBag.DB = db;
            return PartialView();
        }

        public ActionResult Details(int id, string tab, string nat)
        {
            ViewBag.DB = db;
            ViewBag.Tab = tab;
            ViewBag.Nat = nat;
            return View(id);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
