using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRM.Databases_HDLaoDong.Models;
using HRM.Databases.Models;

namespace HRM.HDLaoDong.Controllers
{
    public class BaoCaoController : Controller
    {
        private HRMDB2Entities db = new HRMDB2Entities();

        //
        // GET: /BaoCao/

        public ActionResult Index()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}