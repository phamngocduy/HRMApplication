using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRM.Webpages.Helpers;
using HRM.QLThinhGiang.Models;
namespace HRM.QLThinhGiang.Helpers
{
    public class HoSo_Controller : Controller
    {
        protected HRMDB_Entities db = new HRMDB_Entities();

        protected virtual ActionResult Index(int NV_id)
        {
            ViewBag.db = db;
            return View(NV_id);
        }
        protected virtual PartialViewResult IndexP(int NV_id)
        {
            ViewBag.db = db;
            return PartialView("Index", NV_id);
        }

        protected virtual ActionResult Edit(int? NV_id, int? id)
        {
            ViewBag.db = db;
            ViewBag.NV_id = NV_id;
            return View(id);
        }
        protected virtual PartialViewResult EditP(int? NV_id, int? id)
        {
            ViewBag.db = db;
            ViewBag.NV_id = NV_id;
            return PartialView("Edit", id);
        }

        [HttpPost]
        protected virtual ActionResult Create(string name)
        {
            db.SqlCreate(name, Request.Form);
            return Redirect(Request.UrlReferrer.AbsoluteUri);
        }
        [HttpPost]
        protected virtual string CreateS(string name)
        {
            return db.SqlCreate(name, Request.Form);
        }

        [HttpPost]
        protected virtual ActionResult Update(string name)
        {
            db.SqlUpdate(name, Request.Form);
            return Redirect(Request.UrlReferrer.AbsoluteUri);
        }
        [HttpPost]
        protected virtual string UpdateS(string name)
        {
            return db.SqlUpdate(name, Request.Form);
        }

        [HttpPost]
        protected virtual string DeleteS(string name, int id)
        {
            return db.SqlDelete(name, id);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}