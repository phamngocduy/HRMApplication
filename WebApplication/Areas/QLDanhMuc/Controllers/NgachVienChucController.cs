using System;
using System.Data;
using System.Linq;
using System.Web.Mvc;

using HRM.Databases.Models;
namespace HRM.QLDanhMuc.Controllers
{
    public class NgachVienChucController : Controller
    {
        private HRMDBEntities db = new HRMDBEntities();

        public PartialViewResult Index()
        {
            var model = (from ngach in db.dmNgachVienChuc
                         orderby ngach.stt
                         select ngach).ToList();
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
            ViewBag.nhomNgachVienChuc = new SelectList(db.dmNhomNgachVienChuc, "id", "tenNhomNgachVienChuc");
            return PartialView();
        }

        [HttpPost]
        public string Create(dmNgachVienChuc model)
        {
            if (model.stt <= 0)
                return "STT phải lớn hơn 0!";
            if (ModelState.IsValid)
            {
                db.dmNgachVienChuc.Add(model);
                db.SaveChanges();
                return "OK";
            }

            return "ModelState Invalid!";
        }

        public PartialViewResult Edit(int id)
        {
            var model = db.dmNgachVienChuc.Find(id);
            ViewBag.nhomNgachVienChuc = new SelectList(db.dmNhomNgachVienChuc, "id", "tenNhomNgachVienChuc", model.nhomNgachVienChuc);
            return PartialView(model);
        }

        [HttpPost]
        public string Edit(dmNgachVienChuc model)
        {
            if (model.stt <= 0)
                return "STT phải lớn hơn 0!";
            if (ModelState.IsValid)
            {
                var ngach = db.dmNgachVienChuc.Single(pt => pt.id == model.id);
                if (ngach.stt != model.stt)
                    db.dmNgachVienChuc.Where(pt => pt.stt >= model.stt).ToList().ForEach(
                        pt => { pt.stt++;
                            db.Entry(pt).State = EntityState.Modified;
                        });
                ngach.maNgachVienChuc = model.maNgachVienChuc;
                ngach.tenNgachVienChuc = model.tenNgachVienChuc;
                ngach.nhomNgachVienChuc = model.nhomNgachVienChuc;
                ngach.stt = model.stt;
                db.Entry(ngach).State = EntityState.Modified;
                db.SaveChanges();
                return "OK";
            }
            return "ModelState Invalid!";
        }

        [HttpPost]
        public string Delete(int id)
        {
            var model = db.dmNgachVienChuc.Find(id);
            db.dmNgachVienChuc.Remove(model);
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