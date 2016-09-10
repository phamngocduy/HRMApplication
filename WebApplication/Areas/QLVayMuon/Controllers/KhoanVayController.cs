using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRM.QLVayMuon.Models;

namespace HRM.QLVayMuon.Controllers
{
    public class KhoanVayController : Controller
    {

        private HRMDB1Entities db = new HRMDB1Entities();

        //
        // GET: /KhoanVay/

        public ActionResult Index(int NV_id = 0)
        {   
            ViewBag.NV_id = NV_id;
            //var n = ViewBag.NV_id;
            TempData["NV_ID"] = ViewBag.NV_id;
            //lay het khoanvay
            var khoanvay = from h in db.KhoanVay
                           where h.idNhanVienVayMuon == NV_id
                           orderby h.id descending
                           select h;
            return View(khoanvay.ToList());
        }

        //
        // GET: /KhoanVay/Details/5

        public ActionResult Details(int id = 0)
        {
            ViewBag.NV_id = id;
            ViewBag.IDKV = TempData["NV_ID"];
            var giayto = from g in db.HoSoVayMuon where g.idKhoanVay == id select g;
            //lay ra id nv cua khoanvay co id=id
            int idkv = (from v in db.KhoanVay where v.id == id select v.idNhanVienVayMuon).First();
            TempData["ID_KV"] = idkv;
            //return View(giayto);
            return View(giayto);
        }




        [HttpPost]
        public ActionResult Details(FormCollection m)
        {
            int i = 0;
            var someValue = TempData["ID_KV"];
            if (ModelState.IsValid)
            {
                //lay gia tri cua checkbox
                string[] a = m.Get("item.TrangThai").Replace("true,false", "true").Split(',');
                var id = m.GetValues("item.id");
                //luu gia tri checkbox xong database
                for (i = 0; i < id.Count(); i++)
                {
                    HoSoVayMuon hs = db.HoSoVayMuon.Find(Convert.ToInt32(id[i]));
                    hs.TrangThai = Convert.ToBoolean(a[i]);
                }
                db.SaveChanges();
                //chuyen huong den index cua khoanvay co NV_id = someValue
                return RedirectToAction("Index", new { NV_id = someValue });
            }
            return View(m);
        }





        //
        // GET: /KhoanVay/Create

        public ActionResult Create(int id = 0)
        {
            var mdsd = (from m in db.dmMucDichSuDung select m.id).First();
            ViewBag.mdsd = mdsd;
            ViewBag.NV_id = id;
            var nhanvien = from n in db.NhanVienVayMuon
                           where n.id == id
                           select n;
            ViewBag.idNhanVienVayMuon = new SelectList(nhanvien, "id", "HoVaTen", id);
            ViewBag.idMucDichSuDung = new SelectList(db.dmMucDichSuDung, "id", "TenMucDich");
            return View();
        }

        //
        // POST: /KhoanVay/Create

        [HttpPost]
        public ActionResult Create(KhoanVay khoanvay)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.KhoanVay.Add(khoanvay);
                    db.SaveChanges();
                    TempData["Message"] = "Thêm mới khoản vay thành công";
                    return RedirectToAction("Index", new { NV_id = khoanvay.idNhanVienVayMuon });
                }
            }
            catch (Exception e)
            {
                TempData["Message"] = "Thêm mới khoản vay không thành công";
            }

            ViewBag.idMucDichSuDung = new SelectList(db.dmMucDichSuDung, "id", "TenMucDich", khoanvay.idMucDichSuDung);
            ViewBag.idNhanVienVayMuon = new SelectList(db.NhanVienVayMuon, "id", "MaNV", khoanvay.idNhanVienVayMuon);
            return View(khoanvay);
        }

        //
        // GET: /KhoanVay/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ViewBag.HV_id = id;
            KhoanVay khoanvay = db.KhoanVay.Find(id);
            if (khoanvay == null)
            {
                return HttpNotFound();
            }
            ViewBag.idMucDichSuDung = new SelectList(db.dmMucDichSuDung, "id", "TenMucDich", khoanvay.idMucDichSuDung);
            ViewBag.idNhanVienVayMuon = new SelectList(db.NhanVienVayMuon, "id", "MaNV", khoanvay.idNhanVienVayMuon);
            return View(khoanvay);
        }

        //
        // POST: /KhoanVay/Edit/5

        [HttpPost]
        public ActionResult Edit(KhoanVay khoanvay)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(khoanvay).State = EntityState.Modified;
                    db.SaveChanges();
                    TempData["Message"] = "Chỉnh sửa khoản vay thành công";
                    return RedirectToAction("Index", new { NV_id = khoanvay.idNhanVienVayMuon });
                }
            }
            catch (Exception e)
            {
                TempData["Message"] = "Chỉnh sửa khoản vay không thành công";
            }
            ViewBag.idMucDichSuDung = new SelectList(db.dmMucDichSuDung, "id", "MaMucDich", khoanvay.idMucDichSuDung);
            ViewBag.idNhanVienVayMuon = new SelectList(db.NhanVienVayMuon, "id", "MaNV", khoanvay.idNhanVienVayMuon);
            return View(khoanvay);
        }

        //
        // GET: /KhoanVay/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ViewBag.KV_id = id;
            KhoanVay khoanvay = db.KhoanVay.Find(id);
            if (khoanvay == null)
            {
                return HttpNotFound();
            }
            return View(khoanvay);
        }

        //
        // POST: /KhoanVay/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            KhoanVay khoanvay = db.KhoanVay.Find(id);
            var hoanvay = from h in db.HoanVay
                          where h.idKhoanVay == id
                          select h;
            int nvid = khoanvay.idNhanVienVayMuon;
            try
            {
                db.KhoanVay.Remove(khoanvay);
                db.SaveChanges();
                TempData["Message"] = "Xóa khoản vay thành công";
            }
            catch (Exception e)
            {
                TempData["Message"] = "Xóa khoản vay không thành công";
            }
            return RedirectToAction("Index", new { NV_id = nvid });
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }


        //
        // GET: HoanVayDetails
        public ActionResult HoanVayDetails(int id = 0)
        {

            ViewBag.KV_id = id;
            var n = ViewBag.KV_id;
            //TempData["NV_ID"] = n;
            var hoanvay = from h in db.HoanVay
                          where h.idKhoanVay == id
                          select h;
            return View(hoanvay.ToList());

        }

    }
}