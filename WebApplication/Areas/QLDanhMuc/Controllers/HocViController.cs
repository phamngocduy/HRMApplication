using System;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using System.Web.Script.Serialization;

using HRM.Databases.Models;
namespace HRM.QLDanhMuc.Controllers
{
    public class HocViController : Controller
    {
        private HRMDBEntities db = new HRMDBEntities();

        public string tenTrinhDo(int idHocVi)
        {
            var HocVi = db.dmHocVi.Find(idHocVi);
            return db.dmTrinhDo.Find(HocVi.idTrinhDo).tenTrinhDo;
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}