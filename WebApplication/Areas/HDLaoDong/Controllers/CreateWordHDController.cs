using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRM.Databases_HDLaoDong.Models;
using HRM.Databases.Models;
using HRM.Services;

namespace HRM.HDLaoDong.Controllers
{
    public class CreateWordHDController : Controller
    {
        private HRMDB2Entities db = new HRMDB2Entities();

        //
        // GET: /CreateWordHD/Details/CH_HD

        public ActionResult Details_DHCH(int id = 0)
        {
            hdChiTietHDLD hdchitiethdld = db.hdChiTietHDLD.Find(id);
            if (hdchitiethdld == null)
            {
                return HttpNotFound();
            }
            return View(hdchitiethdld);
        }

        //
        // GET: /CreateWordHD/Details/TV

        public ActionResult Details_TV(int id = 0)
        {
            hdChiTietHDLD hdchitiethdld = db.hdChiTietHDLD.Find(id);
            if (hdchitiethdld == null)
            {
                return HttpNotFound();
            }
            return View(hdchitiethdld);
        }

        //
        // GET: /CreateWordHD/Details/PL2

        public ActionResult Details_PL2(int id = 0)
        {
            hdPhuLucHD2 hdphuluchd2 = db.hdPhuLucHD2.Find(id);
            if (hdphuluchd2 == null)
            {
                return HttpNotFound();
            }
            return View(hdphuluchd2);
        } 

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}