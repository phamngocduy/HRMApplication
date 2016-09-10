using System;
using System.Web.Mvc;
using HRM.Webpages.Helpers;
namespace HRM.QLTTNhanSu.Controllers
{
    public class QTLamViecController : HoSoController
    {
        private string table = "nvQTLamViec";

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
        public string CurrentS(int CT_id)
        {
            try
            {
                db.SqlExecute(String.Format(@"
                    update NhanVien set qtlvCongTac_id=nvQTLamViec.id
                    from NhanVien inner join nvQTLamViec on nvQTLamViec.NV_id=NhanVien.id
                    where nvQTLamViec.id={0}", CT_id));
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return null;
        }
    }
}