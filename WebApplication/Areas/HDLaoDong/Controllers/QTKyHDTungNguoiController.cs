using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRM.Databases_HDLaoDong.Models;


namespace HRM.HDLaoDong.Controllers
{
    public class QTKyHDTungNguoiController : Controller
    {
        private HRMDB2Entities db = new HRMDB2Entities();

        //
        // GET: /QTKyHDTungNguoi/

        public ActionResult Index(int NLD_id)
        {
            var hdchitiethdlds = db.hdChiTietHDLD.Where(ct => ct.NLD_id == NLD_id).OrderByDescending(ct => ct.NgayhetHL).ToList();
            return View(hdchitiethdlds);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}