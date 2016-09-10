using System;
using System.Web.Mvc;
using HRM.Webpages.Helpers;
namespace HRM.QLTTNhanSu.Controllers
{
    public class QHGiaDinhController : HoSoController
    {
        private string table = "nvQHGiaDinh";

        public new PartialViewResult IndexP(int NV_id)
        {
            return base.IndexP(NV_id);
        }

        public new PartialViewResult EditP(int? NV_id, int? id)
        {
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