using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRM.QLThinhGiang.Models;
namespace HRM.QLThinhGiang.Controllers
{
    public class DuLieuGioGiangController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Upload()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Confirm()
        {
            return View("Upload");
        }
    }
}
