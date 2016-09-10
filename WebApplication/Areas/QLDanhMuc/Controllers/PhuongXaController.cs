using System;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using System.Web.Script.Serialization;

using HRM.Databases.Models;
using HRM.Webpages.Helpers;
namespace HRM.QLDanhMuc.Controllers
{

    public class PhuongXaController : Controller
    {
        private HRMDBEntities db = new HRMDBEntities();

        public PartialViewResult Index()
        {
            ViewBag.db = db;
            return PartialView(db.dmPhuongXa.Include("dmQuanHuyen").ToList());
        }

        public PartialViewResult Create(int id)
        {
            ViewBag.QuanHuyen = db.dmQuanHuyen.Find(id);
            return PartialView();
        }

        [HttpPost]
        public string Create(dmPhuongXa model)
        {
            if (ModelState.IsValid)
            {
                db.dmPhuongXa.Add(model);
                db.SaveChanges();
                return "OK";
            }
            return ModelState.getErrorMessage();
        }

        public PartialViewResult Edit(int id)
        {
            var model = db.dmPhuongXa.Find(id);
            ViewBag.idQuanHuyen = new SelectList(db.dmQuanHuyen, "id", "tenQuanHuyen", model.idQuanHuyen);
            return PartialView(model);
        }

        [HttpPost]
        public string Edit(dmPhuongXa model)
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
            db.dmPhuongXa.Remove(db.dmPhuongXa.Find(id));
            db.SaveChanges();
            return "OK";
        }

        public string List(int idQuanHuyen)
        {
            return new JavaScriptSerializer().Serialize(
                db.dmPhuongXa.Where(px => px.idQuanHuyen == idQuanHuyen)
                  .OrderBy(px => px.stt).AsEnumerable()
                  .Select(px => new { key = px.tenPhuongXa, value = px.id })
                );
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}