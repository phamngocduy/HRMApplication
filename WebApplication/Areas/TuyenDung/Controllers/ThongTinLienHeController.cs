using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRM.Databases.Models;
using HRM.Databases_TuyenDung.Models;
using System.Web.Script.Serialization;

namespace HRM.TuyenDung.Controllers
{
    public class ThongTinLienHeController : Controller
    {
        private HRMDB2Entities db = new HRMDB2Entities();

        //
        // GET: /ThongTinLienHe/

        public ActionResult Index()
        {
            var tdthongtinlienhes = db.tdThongTinLienHe.Include(t => t.tdTTUngCuVien);
            
            return View(tdthongtinlienhes.ToList());
        }

        //
        // GET: /ThongTinLienHe/Details/5

        public ActionResult Details(int UngVien_id = 0)
        {
            tdThongTinLienHe tdthongtinlienhe = db.tdThongTinLienHe.Where(lh => lh.UngVien_id == UngVien_id).FirstOrDefault();
            if (tdthongtinlienhe == null)
            {
                return HttpNotFound();
            }
            ViewBag.UngVien_id = UngVien_id;
            ViewBag.UngVien = db.tdTTUngCuVien.Find(UngVien_id);
            return View(tdthongtinlienhe);
        }

        //
        // GET: /ThongTinLienHe/Create

        public ActionResult Create(int UV_id)
        {
            tdThongTinLienHe tdthongtinlienhe = db.tdThongTinLienHe.Where(lh => lh.UngVien_id == UV_id).First();
            if (tdthongtinlienhe == null)
            {
                return HttpNotFound();
            }
            ViewBag.UngVien_id = tdthongtinlienhe.UngVien_id;
            ViewBag.Id = tdthongtinlienhe.id;
            return View(); 
        }
        //
        // POST: /ThongTinLienHe/Create

        [HttpPost]
        public ActionResult Create(tdThongTinLienHe tdthongtinlienhe, tdHoKhauThuongTru tdhokhauthuongtru, tdDiaChiLienLac tddiachilienlac)
        {
            if (ModelState.IsValid)
            {
                // edit thong tin lien he
                db.Entry(tdthongtinlienhe).State = EntityState.Modified;
                db.SaveChanges();
                // edit ho khau thuong 
                var ttold = db.tdHoKhauThuongTru.Where(tt => tt.TTLienHe_id == tdthongtinlienhe.id).First();
                tdhokhauthuongtru.id = ttold.id;
                tdhokhauthuongtru.TTLienHe_id = tdthongtinlienhe.id;
                db.Entry(ttold).CurrentValues.SetValues(tdhokhauthuongtru);
                db.SaveChanges();
                // edit dia chi lien lac
                var llold = db.tdDiaChiLienLac.Where(ll => ll.TTLienHe_id == tdthongtinlienhe.id).First();
                tddiachilienlac.id = llold.id;
                tddiachilienlac.TTLienHe_id = tdthongtinlienhe.id;
                db.Entry(llold).CurrentValues.SetValues(tddiachilienlac);
                db.SaveChanges();
                return RedirectToAction("Create", "TuyenDung", new { tab = "ThongTinUngTuyen", UV_id = tdthongtinlienhe.UngVien_id });
            }
            return View(tdthongtinlienhe);
        }

        //
        // GET: /ThongTinLienHe/Edit/5

        public ActionResult Edit(int UV_id )
        {
            tdThongTinLienHe tdthongtinlienhe = db.tdThongTinLienHe.Where(lh => lh.UngVien_id == UV_id).First();
            if (tdthongtinlienhe == null)
            {
                return HttpNotFound();
            }
            ViewBag.UngVien_id = tdthongtinlienhe.UngVien_id;
            ViewBag.Id = tdthongtinlienhe.id;
            return View(tdthongtinlienhe);    
        }

        //
        // POST: /ThongTinLienHe/Edit/5

        [HttpPost]
        public ActionResult Edit(tdThongTinLienHe tdthongtinlienhe, tdHoKhauThuongTru tdhokhauthuongtru, tdDiaChiLienLac tddiachilienlac)
        {
            if (ModelState.IsValid)
            {
                // edit thong tin lien he
                db.Entry(tdthongtinlienhe).State = EntityState.Modified;
                db.SaveChanges();
                // edit ho khau thuong 
                var ttold = db.tdHoKhauThuongTru.Where(tt => tt.TTLienHe_id == tdthongtinlienhe.id).First();
                tdhokhauthuongtru.id = ttold.id;
                tdhokhauthuongtru.TTLienHe_id = tdthongtinlienhe.id;
                db.Entry(ttold).CurrentValues.SetValues(tdhokhauthuongtru);
                db.SaveChanges();
                // edit dia chi lien lac
                var llold = db.tdDiaChiLienLac.Where(ll => ll.TTLienHe_id == tdthongtinlienhe.id).First();
                tddiachilienlac.id = llold.id;
                tddiachilienlac.TTLienHe_id = tdthongtinlienhe.id;
                db.Entry(llold).CurrentValues.SetValues(tddiachilienlac);
                db.SaveChanges();
                return RedirectToAction("Details", "TuyenDung", new { tab = "ThongTinLienHe", nat = "Edit", id = tdthongtinlienhe.UngVien_id });
            }
            return View(tdthongtinlienhe);
        }

        ////
        //// GET: /ThongTinLienHe/Delete/5

        //public ActionResult Delete(int id = 0)
        //{
        //    tdThongTinLienHe tdthongtinlienhe = db.tdThongTinLienHe.Find(id);
        //    if (tdthongtinlienhe == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(tdthongtinlienhe);
        //}

        ////
        //// POST: /ThongTinLienHe/Delete/5

        //[HttpPost, ActionName("Delete")]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    tdThongTinLienHe tdthongtinlienhe = db.tdThongTinLienHe.Find(id);
        //    db.tdThongTinLienHe.Remove(tdthongtinlienhe);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //public string llqhList(int idTinhThanh)
        //{
        //    return new JavaScriptSerializer().Serialize(
        //        db.dmQuanHuyen.Where(qh => qh.idTinhThanh == idTinhThanh)
        //          .OrderBy(qh => qh.stt).AsEnumerable()
        //          .Select(qh => new { key = qh.tenQuanHuyen, value = qh.id })
        //        );
        //}
        //public string hkqhList(int idTinhThanh)
        //{
        //    return new JavaScriptSerializer().Serialize(
        //        db.dmQuanHuyen.Where(qh => qh.idTinhThanh == idTinhThanh)
        //          .OrderBy(qh => qh.stt).AsEnumerable()
        //          .Select(qh => new { key = qh.tenQuanHuyen, value = qh.id })
        //        );
        //}
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}