using System;
using System.Data;
using System.Linq;
using System.Web.Mvc;

using HRM.Databases.Models;
namespace HRM.QLDanhMuc.Controllers
{
    public class DonViController : Controller
    {
        private HRMDBEntities db = new HRMDBEntities();

        public PartialViewResult Index()
        {
            var model = (from donvi in db.dmDonVi
                         orderby donvi.stt
                         select donvi).ToList();
            for (int i=0, c=1; i<model.Count; i++, c++)
                if (model[i].stt != c)
                {
                    model[i].stt = c;
                    db.Entry(model[i]).State = EntityState.Modified;
                }
            db.SaveChanges();
            return PartialView(model);
        }

        public PartialViewResult Create()
        {
            ViewBag.idDonViChuQuan = new SelectList(db.dmDonVi, "id", "tenDonVi");
            return PartialView();
        }

        [HttpPost]
        public string Create(dmDonVi model)
        {
            if (model.stt <= 0)
                return "STT phải lớn hơn 0!";
            if (ModelState.IsValid)
            {
                db.dmDonVi.Add(model);
                db.SaveChanges();
                return "OK";
            }

            return "ModelState Invalid!";
        }

        public PartialViewResult Edit(int id)
        {
            dmDonVi donvi = db.dmDonVi.Find(id);
            ViewBag.idDonViChuQuan = new SelectList(db.dmDonVi, "id", "tenDonVi", donvi.idDonViChuQuan);
            return PartialView(donvi);
        }

        [HttpPost]
        public string Edit(dmDonVi model)
        {
            if (model.stt <= 0)
                return "STT phải lớn hơn 0!";
            if (ModelState.IsValid)
            {
                var donvi = db.dmDonVi.Single(dv => dv.id == model.id);
                if (donvi.stt != model.stt)
                    db.dmDonVi.Where(dv => dv.stt >= model.stt).ToList().ForEach(
                        dv => { dv.stt++;
                            db.Entry(dv).State = EntityState.Modified;
                        });
                donvi.maDonVi = model.maDonVi;
                donvi.tenDonVi = model.tenDonVi;
                donvi.idDonViChuQuan = model.idDonViChuQuan;
                donvi.stt = model.stt;
                db.Entry(donvi).State = EntityState.Modified;
                db.SaveChanges();
                return "OK";
            }
            return "ModelState Invalid!";
        }

        [HttpPost]
        public string Delete(int id)
        {
            dmDonVi dmdonvi = db.dmDonVi.Find(id);
            db.dmDonVi.Remove(dmdonvi);
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