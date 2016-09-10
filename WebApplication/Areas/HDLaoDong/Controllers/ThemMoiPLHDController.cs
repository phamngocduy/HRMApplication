using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRM.Databases_HDLaoDong.Models;
using System.IO;
using HRM.Databases.Models;
namespace HRM.HDLaoDong.Controllers
{
    public class ThemMoiPLHDController : Controller
    {
        private HRMDB2Entities db = new HRMDB2Entities();
        private HRMDB0Entities db0 = new HRMDB0Entities();
        //
        // GET: /ThemMoiPLHD/

        public ActionResult Index()
        {
            var hdphuluchd2 = db.hdPhuLucHD2.Include(h => h.hdChiTietHDLD);
            return View(hdphuluchd2.ToList());
        }

        //
        // GET: /ThemMoiPLHD/Details/5

        public ActionResult Details(int id = 0)
        {
            hdPhuLucHD2 hdphuluchd2 = db.hdPhuLucHD2.Find(id);
            if (hdphuluchd2 == null)
            {
                return HttpNotFound();
            }
            return View(hdphuluchd2);
        }

        //
        // GET: /ThemMoiPLHD/Create

        public ActionResult Create_PLHDSo2(int HD_id = 0)
        {
            TempData["Details"] = TempData["Details"];
            ViewBag.HD_id = HD_id;
            var HD = db.hdChiTietHDLD.Where(ct => ct.id == HD_id).FirstOrDefault();
            TempData["SoHD"] = HD.SoHD;
            int? HSLuong_id = HD.HSLuong_id;
            double? HSLuong = null;
            try
            {
                HSLuong = db0.dmBangLuong.Where(bl => bl.id == HSLuong_id).FirstOrDefault().hesoLuong;
            }
            catch { }
            TempData["HeSoLuong"] = HSLuong;
            return View();
        }

        //
        // POST: /ThemMoiPLHD/Create

        [HttpPost]
        public ActionResult Create_PLHDSo2(hdPhuLucHD2 hdphuluchd2)
        {
            if (ModelState.IsValid)
            {
                db.hdPhuLucHD2.Add(hdphuluchd2);
                db.SaveChanges();
                TempData["Details"] = Request.Form["Details"];
                return RedirectToAction("Details_PLHDSo2", "ThemMoiPLHD", new { id = hdphuluchd2.id});
            }
            return View(hdphuluchd2);
        }

        public ActionResult Details_PLHDSo2(int id = 0)
        {
            var hdphuluchd2 = db.hdPhuLucHD2.Where(pl => pl.id == id).FirstOrDefault();
            return View(hdphuluchd2);
        }

        //
        // GET: /ThemMoiPLHD/Create

        public ActionResult Attach_PLHDSo1(int HD_id = 0)
        {
            TempData["Details"] = TempData["Details"];
            ViewBag.HD_id = HD_id;
            var HD = db.hdChiTietHDLD.Where(ct => ct.id == HD_id).FirstOrDefault();
            TempData["SoHD"] = HD.SoHD;
            return View();
        }

        //
        // POST: /ThemMoiPLHD/Create

        [HttpPost]
        public ActionResult Attach_PLHDSo1(hdPhuLucHD12LuuFile hdphuluchd12luufile)
        {
            if (ModelState.IsValid == false && Request.Files.Count > 0)
            {
                foreach (string upload in Request.Files)
                {
                    //if (Request.Files[upload].ContentLength > 0) continue;

                    string mimeType = Request.Files[upload].ContentType;
                    Stream fileStream = Request.Files[upload].InputStream;
                    string fileName = Path.GetFileName(Request.Files[upload].FileName);
                    int fileLength = Request.Files[upload].ContentLength;
                    byte[] fileData = new byte[fileLength];
                    fileStream.Read(fileData, 0, fileLength);
                    hdphuluchd12luufile.FileAnh = fileData;
                    hdphuluchd12luufile.MimeType = mimeType;
                    hdphuluchd12luufile.FileName = fileName;
                    db.hdPhuLucHD12LuuFile.Add(hdphuluchd12luufile);
                    db.SaveChanges();
                }
                TempData["Message_EditHDDaiHan"] = "Đính kèm PLHĐ số 1 thành công!";
                TempData["Message_EditHDCoHuu"] = "Đính kèm PLHĐ số 1 thành công!";
                TempData["Message_EditHDThuViec"] = "Đính kèm PLHĐ số 1 thành công!";
                return RedirectToAction(Request.Form["Details"], "ThemMoiHD", new { id = hdphuluchd12luufile.HD_id});
            }
            return View(hdphuluchd12luufile);
        }

        //
        // GET: /ThemMoiPLHD/Create

        public ActionResult Attach_PLHDSo2(int HD_id = 0)
        {

            ViewBag.HD_id = HD_id;
            TempData["Details"] = TempData["Details"];
            var HD = db.hdChiTietHDLD.Where(ct => ct.id == HD_id).FirstOrDefault();
            TempData["SoHD"] = HD.SoHD;
            return View();
        }

        //
        // POST: /ThemMoiPLHD/Create

        [HttpPost]
        public ActionResult Attach_PLHDSo2(hdPhuLucHD12LuuFile hdphuluchd12luufile)
        {
            if (ModelState.IsValid == false && Request.Files.Count > 0)
            {
                foreach (string upload in Request.Files)
                {
                    //if (Request.Files[upload].ContentLength > 0) continue;

                    string mimeType = Request.Files[upload].ContentType;
                    Stream fileStream = Request.Files[upload].InputStream;
                    string fileName = Path.GetFileName(Request.Files[upload].FileName);
                    int fileLength = Request.Files[upload].ContentLength;
                    byte[] fileData = new byte[fileLength];
                    fileStream.Read(fileData, 0, fileLength);
                    hdphuluchd12luufile.FileAnh = fileData;
                    hdphuluchd12luufile.MimeType = mimeType;
                    hdphuluchd12luufile.FileName = fileName;
                    db.hdPhuLucHD12LuuFile.Add(hdphuluchd12luufile);
                    db.SaveChanges();
                }
                TempData["Message_EditHDDaiHan"] = "Đính kèm PLHĐ số 2 thành công!";
                TempData["Message_EditHDCoHuu"] = "Đính kèm PLHĐ số 2 thành công!";
                TempData["Message_EditHDThuViec"] = "Đính kèm PLHĐ số 2 thành công!";
                return RedirectToAction(Request.Form["Details"], "ThemMoiHD", new { id = hdphuluchd12luufile.HD_id });
            }
            return View(hdphuluchd12luufile);
        }

        // get file
        public FileContentResult GetFile(int id)
        {
            byte[] fileContent = null; 
            string mimeType = "";
            string fileName = "";
            var plhdfile = db.hdPhuLucHD12LuuFile.Where(pl => pl.id == id).FirstOrDefault();
            fileContent = (byte[])plhdfile.FileAnh;
            mimeType = plhdfile.MimeType;
            fileName = plhdfile.FileName;
            return File(fileContent, mimeType, fileName);
        }


        //
        // GET: /ThemMoiPLHD/Edit/5

        public ActionResult Edit(int id = 0)
        {
            hdPhuLucHD2 hdphuluchd2 = db.hdPhuLucHD2.Find(id);
            if (hdphuluchd2 == null)
            {
                return HttpNotFound();
            }
            ViewBag.HD_id = new SelectList(db.hdChiTietHDLD, "id", "HotenNLD", hdphuluchd2.HD_id);
            return View(hdphuluchd2);
        }

        //
        // POST: /ThemMoiPLHD/Edit/5

        [HttpPost]
        public ActionResult Edit(hdPhuLucHD2 hdphuluchd2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hdphuluchd2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.HD_id = new SelectList(db.hdChiTietHDLD, "id", "HotenNLD", hdphuluchd2.HD_id);
            return View(hdphuluchd2);
        }

        //
        // GET: /ThemMoiPLHD/Delete/5

        public ActionResult Delete(int id = 0)
        {
            hdPhuLucHD2 hdphuluchd2 = db.hdPhuLucHD2.Find(id);
            if (hdphuluchd2 == null)
            {
                return HttpNotFound();
            }
            return View(hdphuluchd2);
        }

        //
        // POST: /ThemMoiPLHD/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            hdPhuLucHD2 hdphuluchd2 = db.hdPhuLucHD2.Find(id);
            db.hdPhuLucHD2.Remove(hdphuluchd2);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}