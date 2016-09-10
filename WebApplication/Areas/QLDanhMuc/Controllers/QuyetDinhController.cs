using System;
using System.Data;
using System.Linq;
using System.Web.Mvc;

using HRM.Databases.Models;
namespace HRM.QLDanhMuc.Controllers
{
    public class QuyetDinhController : Controller
    {
        private HRMDBEntities db = new HRMDBEntities();

        public PartialViewResult Index(int loai = 0)
        {
            ViewBag.loaiQuyetDinh = new SelectList(db.dmLoaiQuyetDinh, "id", "tenLoaiQuyetDinh", loai);
            return PartialView(db.dmQuyetDinh.Where(hs => hs.LoaiQuyetDinh_id == loai).ToList());
        }

        public PartialViewResult Create(int loai)
        {
            ViewBag.LoaiQuyetDinh_id = new SelectList(db.dmLoaiQuyetDinh, "id", "tenLoaiQuyetDinh", loai);
            return PartialView();
        }

        [HttpPost]
        public string Create(dmQuyetDinh model)
        {
            if (ModelState.IsValid)
            {
                db.dmQuyetDinh.Add(model);
                db.SaveChanges();
                return "OK";
            }
            return "ModelState Invalid!";
        }

        public PartialViewResult Edit(int id)
        {
            var model = db.dmQuyetDinh.Find(id);
            ViewBag.LoaiQuyetDinh_id = new SelectList(db.dmLoaiQuyetDinh, "id", "tenLoaiQuyetDinh", model.LoaiQuyetDinh_id);
            return PartialView(model);
        }

        [HttpPost]
        public string Edit(dmQuyetDinh model)
        {
            if (ModelState.IsValid)
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                return "OK";
            }
            return "ModelState Invalid!";
        }

        [HttpPost]
        public string Delete(int id)
        {
            db.dmQuyetDinh.Remove(db.dmQuyetDinh.Find(id));
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