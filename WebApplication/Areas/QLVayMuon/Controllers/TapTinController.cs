using System.Web.Script.Serialization;
using HRM.Webpages.Helpers;
using System;
using System.IO;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Transactions;
using HRM.QLVayMuon.Models;
using System.Collections.Generic;


namespace HRM.QLVayMuon.Controllers
{
    public class TapTinController : Controller
    {
        private HRMDB1Entities db = new HRMDB1Entities();


        public PartialViewResult Index(string parent)
        {
            ViewBag.tenkhoanvay = parent;
            var models = db.TapTin.Where(tt => tt.tenThuMuc == parent);
            return PartialView(models.ToList());
        }

        //
        // GET: /TapTin/Details/5


        public ActionResult Create(string kv)
        {
            var mucdich = (from m in db.KhoanVay
                          where m.SoChungTu == kv
                          select m.idMucDichSuDung).First();
            
            var tengiay = from h in db.dmGiayTo
                          where h.idMucDichSuDung == (int) mucdich
                          select new SelectListItem { Value = h.TenGiayTo, Text = h.TenGiayTo };
            var md_id = (from v in db.dmGiayTo where v.idMucDichSuDung == mucdich select v.id).First();
            ViewBag.mdid = md_id;
            ViewBag.tengiay = tengiay;
            ViewBag.khoanvay = kv;
            string id_kv = kv;
            TempData["sochungtu"] = kv;
            int idkv = (from h in db.KhoanVay
                        where h.SoChungTu == id_kv
                        select h.id).First();
            ViewBag.idkhoanvay = idkv;
            return View();
        }
        [HttpPost]
        public ActionResult Create(TapTin model)
        {
            string kv;
            var sochungtu = TempData["sochungtu"].ToString();
            kv = sochungtu;
            var mucdich = (from m in db.KhoanVay
                           where m.SoChungTu == kv
                           select m.idMucDichSuDung).First();
            var tengiay = from h in db.dmGiayTo
                          where h.idMucDichSuDung == (int)mucdich
                          select new SelectListItem { Value = h.TenGiayTo, Text = h.TenGiayTo };
            ViewBag.tengiay = tengiay;
            int idkv = (from h in db.KhoanVay where h.SoChungTu == sochungtu select h.id).First();
            var file1 = Request.Files[0];
            if (db.TapTin.FirstOrDefault(nv => (nv.tepDinhKem == file1.FileName)) != null)
            { TempData["Message"] = "File đã tồn tại"; return Redirect("../taptin/Create?kv=" + sochungtu); }
            else
            {
                if (ModelState.IsValid)
                {
                    using (var scope = new TransactionScope())
                    {
                        db.TapTin.Add(model);
                        db.SaveChanges();
                        try
                        {
                            if (!String.IsNullOrEmpty(model.tepDinhKem))
                            {
                                var file = Request.Files[0];
                                model.tepDinhKem = file.FileName;
                                db.SaveChanges();
                                Upload(file);
                            }
                            scope.Complete();
                            return Redirect("../khoanvay/details?id=" + idkv);
                        }
                        catch (Exception e)
                        {
                            ModelState.AddModelError("tepDinhKem", e.Message);
                        }
                    }
                }
            }
            return View();
        }

        //kiem tra ton tai manv
        public static void UpdateModel(ModelStateDictionary ModelState, string tenfile)
        {
            if (ModelState.IsValid)
            {
                tenfile = tenfile.Trim();
                using (var db = new HRMDB1Entities())
                {
                    if (db.TapTin.FirstOrDefault(tt=>(tt.tenThuMuc== tenfile)) != null)
                        ModelState.AddModelError("tengiayto", "File đã tồn tại");
                }
            }
        }

        public ActionResult Upload(int id)
        {
            return View(db.TapTin.Find(id));
        }
        [HttpPost]
        public ActionResult Upload(TapTin model)
        {
            var TapTin = db.TapTin.Find(model.id);
            using (var scope = new TransactionScope())
                try
                {
                    var file = Request.Files[0];
                    TapTin.tepDinhKem = file.FileName;
                    db.Entry(TapTin).State = EntityState.Modified;
                    db.SaveChanges();
                    if (!String.IsNullOrEmpty(model.tepDinhKem))
                        Upload(file);
                    scope.Complete();
                    return RedirectToAction("Index", new { parent = TapTin.idTapTin });
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("tepDinhKem", e.Message);
                }
            return View(model);
        }

        public ActionResult Download(int id)
        {
            var TapTin = db.TapTin.Find(id);
            var root = Server.MapPath(App_Root);

            var file = TapTin.tepDinhKem;
            return File(new StreamReader(Path.Combine(root, file)).BaseStream, "data", file);
        }

        public ActionResult Delete(int id)
        {
            ViewBag.idtt = id;
            return View(db.TapTin.Find(id));
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {

            string soct = (from h in db.TapTin
                           where h.id == id
                           select h.tenThuMuc).First();

            int idkv = (from h in db.KhoanVay
                        where h.SoChungTu == soct
                        select h.id).First();


            var TapTin = db.TapTin.Find(id);
            string tenfile = db.TapTin.Find(id).tepDinhKem;
            db.TapTin.Remove(TapTin);
            db.SaveChanges();
            Delete(tenfile);
            return Redirect("../khoanvay/details?id=" + idkv);
        }


        private const string App_Root = @"~/App_Data/HRM1/TAPTIN";

        //private void Create1(string path)
        //{
        //    var root = Server.MapPath(App_Root);

        //    path = Path.Combine(root, path);

        //    Directory.CreateDirectory(path);
        //}
        private void Upload(HttpPostedFileBase file)
        {
            var root = Server.MapPath(App_Root);
            string path = Path.Combine(root, file.FileName);
            file.SaveAs(path);
        }
        //private void Rename(string src, string dst)
        //{
        //    var root = Server.MapPath(App_Root);
        //    Directory.Move(Path.Combine(root, src), Path.Combine(root, dst));
        //}
        private void Delete(string file)
        {
            var root = Server.MapPath(App_Root);
            System.IO.File.Delete(Path.Combine(root, file));
        }


        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}