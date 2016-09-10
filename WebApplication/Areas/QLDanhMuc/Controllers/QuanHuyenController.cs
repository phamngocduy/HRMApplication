using System;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using System.Web.Script.Serialization;

using HRM.Databases.Models;
using HRM.Webpages.Helpers;
namespace HRM.QLDanhMuc.Controllers
{
    public class QuanHuyenController : Controller
    {
        private HRMDBEntities db = new HRMDBEntities();

        public PartialViewResult Index()
        {
            ViewBag.db = db;
            return PartialView(db.dmQuanHuyen.Include("dmTinhThanh").ToList());
        }

        public PartialViewResult Create(int id)
        {
            ViewBag.idTinhThanh = new SelectList(db.dmTinhThanh, "id", "tenTinhThanh", id);
            return PartialView();
        }

        [HttpPost]
        public string Create(dmQuanHuyen model)
        {
            if (ModelState.IsValid)
            {
                db.dmQuanHuyen.Add(model);
                db.SaveChanges();
                return "OK";
            }
            return ModelState.getErrorMessage();
        }

        public PartialViewResult Edit(int id)
        {
            var model = db.dmQuanHuyen.Find(id);
            ViewBag.idTinhThanh = new SelectList(db.dmTinhThanh, "id", "tenTinhThanh", model.idTinhThanh);
            return PartialView(model);
        }

        [HttpPost]
        public string Edit(dmQuanHuyen model)
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
            db.dmQuanHuyen.Remove(db.dmQuanHuyen.Find(id));
            db.SaveChanges();
            return "OK";
        }

        public string List(int idTinhThanh)
        {
            return new JavaScriptSerializer().Serialize(
                db.dmQuanHuyen.Where(qh => qh.idTinhThanh == idTinhThanh)
                  .OrderBy(qh => qh.stt).AsEnumerable()
                  .Select(qh => new { key = qh.tenQuanHuyen, value = qh.id })
                );
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}