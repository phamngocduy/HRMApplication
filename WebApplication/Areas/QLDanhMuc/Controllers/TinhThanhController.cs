using System;
using System.Data;
using System.Linq;
using System.Web.Mvc;

using HRM.Databases.Models;
using HRM.Webpages.Helpers;
namespace HRM.QLDanhMuc.Controllers
{
    public class TinhThanhController : Controller
    {
        private HRMDBEntities db = new HRMDBEntities();
        public PartialViewResult Index()
        {
            ViewBag.db = db;
            return PartialView(db.dmTinhThanh.ToList());
        }

        public PartialViewResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public string Create(dmTinhThanh model)
        {
            if (ModelState.IsValid)
            {
                db.dmTinhThanh.Add(model);
                db.SaveChanges();
                return "OK";
            }
            return ModelState.getErrorMessage();
        }

        public PartialViewResult Edit(int id)
        {
            return PartialView(db.dmTinhThanh.Find(id));
        }

        [HttpPost]
        public string Edit(dmTinhThanh model)
        {
            if (ModelState.IsValid)
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                return "OK";
            }
            return ModelState.getErrorMessage();
        }

        [HttpPost]
        public string Delete(int id)
        {
            db.dmTinhThanh.Remove(db.dmTinhThanh.Find(id));
            db.SaveChanges();
            return "OK";
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}