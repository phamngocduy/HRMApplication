using System;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using System.Reflection;

using HRM.QLDanhMuc.Models;
using HRM.Databases.Models;
namespace HRM.QLDanhMuc.Controllers
{
    public class DanhMucController : Controller
    {
        private HRMDBEntities db = new HRMDBEntities();

        public ActionResult List()
        {
            return View(db.listDanhMuc());
        }

        public ActionResult Index(string dm)
        {
            if (Assembly.GetExecutingAssembly().GetTypes()
                        .Select(type => type.Name).ToList()
                        .Contains(String.Format("{0}Controller", dm)))
                return RedirectToAction("Index", dm, new { dm = dm });
            ViewBag.DanhMuc = dm;
            return PartialView(db.loadDanhMuc(dm));
        }

        public PartialViewResult Create(string dm)
        {
            ViewBag.DanhMuc = dm;
            return PartialView();
        }

        [HttpPost]
        public string Create(string dm, DanhMuc model)
        {
            if (ModelState.IsValid)
            {
                var danhmuc = db.makeDanhMuc(dm, model);
                TryValidateModel(danhmuc);
                if (ModelState.IsValid)
                {
                    if (model.stt.HasValue)
                        db.updateSTT(dm, model.stt.Value);
                    db.Entry(danhmuc).State = EntityState.Added;
                    db.SaveChanges();
                    // for unit testing
                    model.id = (int)danhmuc.GetType().GetProperty("id").GetValue(danhmuc, null);
                    return "OK";
                }
            }
            foreach (var state in ModelState.Values)
                if (state.Errors.Count > 0)
                    return state.Errors[0].ErrorMessage;
            return "ModelState Invalid!";
        }

        public PartialViewResult Edit(string dm, int id)
        {
            ViewBag.DanhMuc = dm;
            return PartialView(new DanhMuc(dm, db.findDanhMuc(dm, id)));
        }

        [HttpPost]
        public string Edit(string dm, DanhMuc model)
        {
            if (ModelState.IsValid)
            {
                var danhmuc = db.findDanhMuc(dm, model.id);
                var type = danhmuc.GetType();
                type.GetProperty("stt").SetValue(danhmuc, model.stt, null);
                type.GetProperty("ma" + dm).SetValue(danhmuc, model.maDanhMuc, null);
                type.GetProperty("ten" + dm).SetValue(danhmuc, model.tenDanhMuc, null);
                TryValidateModel(danhmuc);
                if (ModelState.IsValid)
                {
                    if (model.stt.HasValue)
                    {
                        db.updateSTT(dm, model.stt.Value); // override the current
                        type.GetProperty("stt").SetValue(danhmuc, model.stt, null);
                    }
                    db.Entry(danhmuc).State = EntityState.Modified;
                    db.SaveChanges();
                    return "OK";
                }
            }
            foreach (var state in ModelState.Values)
                if (state.Errors.Count > 0)
                    return state.Errors[0].ErrorMessage;
            return "ModelState Invalid!";
        }

        [HttpPost]
        public string Delete(string dm, int id)
        {
            db.Entry(db.findDanhMuc(dm, id)).State = EntityState.Deleted;
            db.SaveChanges();
            return "OK";
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        // for unit testing
        new private void TryValidateModel(object model)
        {
            try
            {
                base.TryValidateModel(model);
            }
            catch (Exception)
            {
            }
        }
    }
}
