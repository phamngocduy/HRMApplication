using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using HRM.QLThinhGiang.Models;
using System;
using System.Web.Script.Serialization;
using HRMDB0Entities = HRM.Databases.Models.HRMDB0Entities;
namespace HRM.QLThinhGiang.Controllers
{
    public class nvBangCapController : Controller
    {
        private HRMDB_Entities db = new HRMDB_Entities();
        private HRMDB0Entities d0 = new HRMDB0Entities();
        public ActionResult Index(int id)
        {
            ViewBag.DB = db;
            var model = TempData["Model"];
            var cn1 = (from x in d0.dmChuyenNganh
                       select x);
            ViewBag.cn1 = new SelectList(cn1,"id","tenchuyennganh");
            try
            {
                var a = (from x in db.nvBangCap
                         join c in d0.dmChuyenNganh on x.ChuyenNganh_id equals c.id
                         join dmChuyenNganh in d0.dmChuyenNganh on x.ChuyenNganh_id equals dmChuyenNganh.id
                         where x.Chuyennganhchinh == true && x.NV_id == id
                         select dmChuyenNganh.tenChuyenNganh).SingleOrDefault();
                var b = (from x in db.nvBangCap
                         join c in d0.dmLoaiBangCap on x.LoaiBangCap_id equals c.id
                         join dmLoaiBangCap in d0.dmLoaiBangCap on x.LoaiBangCap_id equals dmLoaiBangCap.id
                         where x.NV_id == id
                         orderby c.stt
                         select dmLoaiBangCap.tenLoaiBangCap).First();
                ViewBag.trinhdo = b;
                ViewBag.chuyennganh = a;
            }
            catch { }
            return PartialView(model != null ? model : new nvBangCap() { NV_id = id });
        }


        [HttpPost]
        public ActionResult Update(int? BC_id)
        {
            var model = BC_id.HasValue ? db.nvBangCap.Find(BC_id) : new nvBangCap();
            var prefix = "" + Request.Form["Prefix"];
            TryUpdateModel(model, !BC_id.HasValue ? prefix : prefix + ".item");
            if (ModelState.IsValid)
            {
                if (!BC_id.HasValue) db.nvBangCap.Add(model);
                else db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                TempData["Message"] = "Thành công";
                
              
            }
            else
                TempData["Model"] = model;
            TempData["ModelState"] = ModelState;
            return RedirectToAction("Details/" + model.NV_id, "HSNhanSu", new { tab = "QTHocTap" }); 
        }
        public ActionResult capNhatChuyenNganh(int id)
        {
            var model = db.nvBangCap.Find(id);
          //  var nvid= from p in db.nvBangCap where p.id==id select p.NV_id;
         //   int mt = Convert.ToInt32(nvid);
            var tmp = from p in db.nvBangCap where p.NV_id==(from k in db.nvBangCap where k.id==id select k.NV_id).FirstOrDefault() select p;
            foreach (var nv in tmp)
            {
                nv.Chuyennganhchinh = false;
                //      db.SaveChanges();
            }
            model.Chuyennganhchinh = true;
            db.SaveChanges();

            return RedirectToAction("Details/" + model.NV_id, "HSNhanSu", new { tab = "QTHocTap" });
        }
        public ActionResult Delete(int id)
        {
            nvBangCap model = db.nvBangCap.Find(id);
           // db.nvBangCap.Remove(model);
            model.Xoa = true;
            db.SaveChanges();
            TempData["Message"] = "CapNhatThanhCong";
            return RedirectToAction("Details/" + model.NV_id, "HSNhanSu", new { tab = "QTHocTap" });
        }
        public string List(int CN_id)
        {
            return new JavaScriptSerializer().Serialize(
                d0.dmChuyenNganh
                  .OrderBy(qh => qh.stt).AsEnumerable()
                  .Select(qh => new { key = qh.tenChuyenNganh, value = qh.id })
                );
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

    }
}