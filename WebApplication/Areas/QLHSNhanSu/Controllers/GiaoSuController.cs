using System;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using System.Transactions;
using HRM.Databases.Models;
using HRM.Webpages.Helpers;
namespace HRM.QLTTNhanSu.Controllers
{
    public class GiaoSuController : HoSoController
    {
        private string table = "nvHocHam";

        public ActionResult Index()
        {
            return base.Index(0);
        }

        public new PartialViewResult EditP(int? id, int? NV_id, int? HH_id)
        {
            ViewBag.HH_id = HH_id;
            return base.EditP(NV_id, id);
        }

        [HttpPost]
        public string CreateS()
        {
            return base.CreateS(table);
        }

        [HttpPost]
        public string UpdateS()
        {
            return base.UpdateS(table);
        }

        [HttpPost]
        public string DeleteS(int id)
        {
            return base.DeleteS(table, id);
        }
    }
}