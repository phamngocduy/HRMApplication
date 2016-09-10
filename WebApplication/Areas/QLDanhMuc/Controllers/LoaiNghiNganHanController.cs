using System;
using System.Data;
using System.Linq;
using System.Web.Mvc;

using HRM.Databases.Models;
namespace HRM.QLDanhMuc.Controllers
{
    public class LoaiNghiNganHanController : Controller
    {
        private HRMDBEntities db = new HRMDBEntities();

        public PartialViewResult Index()
        {
            return PartialView(db.dmLoaiNghiNganHan.OrderBy(dm => dm.stt).ToList());
        }

        public PartialViewResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public string Create(dmLoaiNghiNganHan model)
        {
            if (model.stt <= 0)
                return "STT phải lớn hơn 0!";
            if (ModelState.IsValid)
            {
                db.dmLoaiNghiNganHan.Add(model);
                db.SaveChanges();
                return "OK";
            }

            return "ModelState Invalid!";
        }

        public PartialViewResult Edit(int id)
        {
            return PartialView(db.dmLoaiNghiNganHan.Find(id));
        }

        [HttpPost]
        public string Edit(dmLoaiNghiNganHan model)
        {
            if (model.stt <= 0)
                return "STT phải lớn hơn 0!";
            if (ModelState.IsValid)
            {
                var nghi = db.dmLoaiNghiNganHan.AsNoTracking().Single(dm => dm.id == model.id);
                if (nghi.stt != model.stt)
                    db.dmLoaiNghiNganHan.Where(dm => dm.stt >= model.stt).ToList().ForEach(
                        dm => { dm.stt++;
                            db.Entry(dm).State = EntityState.Modified;
                        });
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                return "OK";
            }
            return "ModelState Invalid!";
        }

        [HttpPost]
        public string Delete(int id)
        {
            db.dmLoaiNghiNganHan.Remove(db.dmLoaiNghiNganHan.Find(id));
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