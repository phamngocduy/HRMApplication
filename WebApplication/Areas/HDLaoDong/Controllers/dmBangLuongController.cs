using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using HRM.Databases_HDLaoDong.Models;
using HRM.Databases.Models;
namespace HRM.HDLaoDong.Controllers
{
    public class dmBangLuongController : Controller
    {
        private HRMDB2Entities db = new HRMDB2Entities();
        private HRMDB0Entities db0 = new HRMDB0Entities();
        //
        // GET: /dmBangLuong/
        public string List_Nhom(string BangLuong)
        {
            if (BangLuong == "Bảng 3")
            {
                return new JavaScriptSerializer().Serialize(
                    db0.dmNhomNgachVienChuc.Where(n => n.bangLuong == 3)
                      .OrderBy(n => n.stt).AsEnumerable()
                      .Select(n => new { key = n.maNhomNgachVienChuc, value = n.id })
                    );
            }
            else
            {
                return new JavaScriptSerializer().Serialize(
                    db0.dmNhomNgachVienChuc.Where(n => n.bangLuong == 4)
                      .OrderBy(n => n.stt).AsEnumerable()
                      .Select(n => new { key = n.maNhomNgachVienChuc, value = n.id })
                    );
            }
        }
        public string List_Ngach(int? idNhomNgach)
        {
            return new JavaScriptSerializer().Serialize(
                db0.dmNgachVienChuc.Where(n => n.nhomNgachVienChuc == idNhomNgach)
                  .OrderBy(n => n.stt).AsEnumerable()
                  .Select(n => new { key = n.tenNgachVienChuc, value = n.id })
                );
        }
        public string List_Bac(int? idNhomNgach)
        {
            return new JavaScriptSerializer().Serialize(
                db0.dmBangLuong.Where(b => b.idNhomNgach == idNhomNgach)
                  .OrderBy(n => n.stt).AsEnumerable()
                  .Select(n => new { key = n.bacLuong, value = n.id })
                );
        }
        public string List_HSLuong(int? idBac)
        {
            return new JavaScriptSerializer().Serialize(
                db0.dmBangLuong.Where(b => b.id == idBac)
                  .OrderBy(n => n.stt).AsEnumerable()
                  .Select(n => new { key = n.hesoLuong, value = n.id })
                );
        }
    }
}
