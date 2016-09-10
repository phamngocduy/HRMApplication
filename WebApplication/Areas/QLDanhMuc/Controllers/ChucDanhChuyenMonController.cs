using System;
using System.Data;
using System.Linq;
using System.Web.Mvc;

using HRM.Databases.Models;
namespace HRM.QLDanhMuc.Controllers
{/*
    public class ChucDanhChuyenMonController : Controller
    {
        private HRMDBEntities db = new HRMDBEntities();

        public PartialViewResult Index()
        {
            var model = (from cdcm in db.dmChucDanhChuyenMon
                         orderby cdcm.stt
                         select cdcm).ToList();
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
            ViewBag.loaiChucDanh = new SelectList(db.dmChucDanh, "id", "tenChucDanh");
            return PartialView();
        }

        [HttpPost]
        public string Create(dmChucDanhChuyenMon model)
        {
            if (model.stt <= 0)
                return "STT phải lớn hơn 0!";
            if (ModelState.IsValid)
            {
                db.dmChucDanhChuyenMon.Add(model);
                db.SaveChanges();
                return "OK";
            }

            return "ModelState Invalid!";
        }

        public PartialViewResult Edit(int id)
        {
            dmChucDanhChuyenMon cdcm = db.dmChucDanhChuyenMon.Find(id);
            //ViewBag.loaiChucDanh = new SelectList(db.dmChucDanh, "id", "tenChucDanh", cdcm.loaiChucDanh);
            return PartialView(cdcm);
        }

        [HttpPost]
        public string Edit(dmChucDanhChuyenMon model)
        {
            if (model.stt <= 0)
                return "STT phải lớn hơn 0!";
            if (ModelState.IsValid)
            {
                var cdcm = db.dmChucDanhChuyenMon.Single(cd => cd.id == model.id);
                if (cdcm.stt != model.stt)
                    db.dmChucDanhChuyenMon.Where(cd => cd.stt >= model.stt).ToList().ForEach(
                        cd => { cd.stt++;
                            db.Entry(cd).State = EntityState.Modified;
                        });
                cdcm.maChucDanhChuyenMon = model.maChucDanhChuyenMon;
                cdcm.tenChucDanhChuyenMon = model.tenChucDanhChuyenMon;
                cdcm.qlTapSu = model.qlTapSu;
                //cdcm.loaiChucDanh = model.loaiChucDanh;
                cdcm.stt = model.stt;
                db.Entry(cdcm).State = EntityState.Modified;
                db.SaveChanges();
                return "OK";
            }
            return "ModelState Invalid!";
        }

        [HttpPost]
        public string Delete(int id)
        {
            dmChucDanhChuyenMon cdcm = db.dmChucDanhChuyenMon.Find(id);
            db.dmChucDanhChuyenMon.Remove(cdcm);
            db.SaveChanges();
            return "OK";
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }*/
}