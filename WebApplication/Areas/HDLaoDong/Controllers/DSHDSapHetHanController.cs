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
    public class DSHDSapHetHanController : Controller
    {
        private HRMDB2Entities db = new HRMDB2Entities();

        //
        // GET: /DSHDSapHetHan/

        public ActionResult Index()
        {
            List<hdChiTietHDLD> hdchitiethdlds = new List<hdChiTietHDLD>();
            foreach (var ittem in db.hdNLD)
            {
                foreach (var item in ittem.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL))
                {
                    if (item.NgayhetHL != null)
                    {
                        System.TimeSpan diffDate = (DateTime)item.NgayhetHL - DateTime.Today;
                        if ((diffDate.Days <= db.hdCauHinh.FirstOrDefault().NgayHDTV && item.LoaiHD == "Thử việc") || (diffDate.Days <= db.hdCauHinh.FirstOrDefault().NgayHDCT && item.LoaiHD == "Hợp đồng dài hạn") || (diffDate.Days <= db.hdCauHinh.FirstOrDefault().NgayHDCT && item.LoaiHD == "Hợp đồng cơ hữu"))
                        {
                            if (diffDate.Days > 0)
                            {
                                hdchitiethdlds.Add(item);
                            }
                        }
                    }
                    break;
                }
            }
            return View(hdchitiethdlds);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}