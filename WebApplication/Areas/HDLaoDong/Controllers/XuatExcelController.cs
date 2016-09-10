using HRM.Databases_HDLaoDong.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using System.Reflection;
using HRM.Webpages.Helpers;
using HRM.Databases.Models;

namespace HRM.HDLaoDong.Controllers
{
    public class XuatExcelController : Controller
    {
        private HRMDB2Entities db = new HRMDB2Entities();
        private HRMDB0Entities db0 = new HRMDB0Entities();
        //
        // GET: /XuatExcel/

        public ActionResult Index()
        {
            var listXuatExcel = TempData["listXuatExcel"];
            return View(listXuatExcel);
        }

        //
        // Ex: /XuatExcel/

        public ActionResult Export()
        {
            // field selected to export
            var con = new List<string>();
            if (Request.Form["XuatTatCa"] == "on")
            {
                for (int k = 1; k < Request.Form.Count; k++)
                {
                    con.Add(Request.Form.AllKeys[k]);
                }
            }
            else
            {
                con = Request.Form.AllKeys.ToList();
            }
            //add header
            var hed = new List<string>();
            hed.Add("Mã NV");
            for (int j = 0; j < con.Count; j++)
            {
                if (con[j] == "HoVaTen")
                {
                    hed.Add("Họ và tên");
                }
            }
            for (int j = 0; j < con.Count; j++)
            {
                if (con[j] == "DonVi")
                {
                    hed.Add("Đơn vị");
                }
            }
            for (int j = 0; j < con.Count; j++)
            {
                if (con[j] == "ChucDanhCM")
                {
                    hed.Add("Chức danh CM");
                }
            }
            for (int j = 0; j < con.Count; j++)
            {
                if (con[j] == "SoHD")
                {
                    hed.Add("Số HĐ");
                }
            }
            for (int j = 0; j < con.Count; j++)
            {
                if (con[j] == "LoaiHD")
                {
                    hed.Add("Loại HĐ");
                }
            }
            for (int j = 0; j < con.Count; j++)
            {
                if (con[j] == "ThoiHanHD")
                {
                    hed.Add("Thời hạn HĐ");
                }
            }
            for (int j = 0; j < con.Count; j++)
            {
                if (con[j] == "NgayHieuLuc")
                {
                    hed.Add("Ngày hiệu lực");
                }
            }
            for (int j = 0; j < con.Count; j++)
            {
                if (con[j] == "NgayHetHieuLuc")
                {
                    hed.Add("Ngày hết hiệu lực");
                }
            }
            for (int j = 0; j < con.Count; j++)
            {
                if (con[j] == "NgayNLDKy")
                {
                    hed.Add("Ngày NLĐ ký");
                }
            }
            for (int j = 0; j < con.Count; j++)
            {
                if (con[j] == "NgayTrinh")
                {
                    hed.Add("Ngày trình");
                }
            }
            for (int j = 0; j < con.Count; j++)
            {
                if (con[j] == "NgayHTKy")
                {
                    hed.Add("Ngày HT ký");
                }
            }
            for (int j = 0; j < con.Count; j++)
            {
                if (con[j] == "NgayLuu")
                {
                    hed.Add("Ngày lưu");
                }
            }
            for (int j = 0; j < con.Count; j++)
            {
                if (con[j] == "NgayTra")
                {
                    hed.Add("Ngày trả");
                }
            }
            for (int j = 0; j < con.Count; j++)
            {
                if (con[j] == "LuongCoBan")
                {
                    hed.Add("Lương cơ bản");
                }
            }
            for (int j = 0; j < con.Count; j++)
            {
                if (con[j] == "HeSoLuong")
                {
                    hed.Add("Hệ số lương");
                }
            }
            for (int j = 0; j < con.Count; j++)
            {
                if (con[j] == "Bac")
                {
                    hed.Add("Bậc");
                }
            }
            for (int j = 0; j < con.Count; j++)
            {
                if (con[j] == "Ngach")
                {
                    hed.Add("Ngạch");
                }
            }
            for (int j = 0; j < con.Count; j++)
            {
                if (con[j] == "Nhom")
                {
                    hed.Add("Nhóm");
                }
            }
            for (int j = 0; j < con.Count; j++)
            {
                if (con[j] == "BangLuong")
                {
                    hed.Add("Bảng lương");
                }
            }

            // data list need export
            var ori = (List<hdChiTietHDLD>)TempData["listXuatExcel"];
            // writing to excel
            var excel = new StringBuilder();
            using (var writer = new ExcelWriter(excel))
            {
                writer.WriteStartDocument();
                writer.WriteStartWorksheet("Sheet1");
                // writing header
                writer.WriteStartRow();
                foreach (var item in hed)
                {
                    writer.WriteExcelUnstyledCell(item);
                }
                writer.WriteEndRow();
                // writing content
                foreach (var item in ori)
                {
                    writer.WriteStartRow();
                    for (int col = 0; col < hed.Count; col++)
                    {
                        if (hed[col] == "Mã NV")
                        {
                            writer.WriteExcelAutoStyledCell(item.hdNLD1.NV_id);
                        }

                        if (hed[col] == "Họ và tên")
                        {
                            writer.WriteExcelAutoStyledCell(item.HotenNLD);
                        }
                        if (hed[col] == "Đơn vị")
                        {
                            int? DV_id = item.Donvi_id;
                            var tenDonVi = db0.dmDonVi.Where(dv => dv.id == DV_id).FirstOrDefault().tenDonVi;
                            writer.WriteExcelAutoStyledCell(tenDonVi);
                        }
                        if (hed[col] == "Chức danh CM")
                        {
                            int? CD_id = item.Chucdanh_id;
                            var tenChucDanh = db0.dmChucDanhChuyenMon.Where(cd => cd.id == CD_id).FirstOrDefault().tenChucDanhChuyenMon;
                            writer.WriteExcelAutoStyledCell(tenChucDanh);
                        }
                        if (hed[col] == "Số HĐ")
                        {
                            writer.WriteExcelAutoStyledCell(item.SoHD);
                        }
                        if (hed[col] == "Loại HĐ")
                        {
                            writer.WriteExcelAutoStyledCell(item.LoaiHD);
                        }
                        if (hed[col] == "Thời hạn HĐ")
                        {
                            int THHD_id = item.ThoihanHD_id;
                            var tenThoiHan = db.dmThoiHanHD.Where(th => th.id == THHD_id).FirstOrDefault().tenThoiHanHD;
                            writer.WriteExcelAutoStyledCell(tenThoiHan);
                        }
                        if (hed[col] == "Ngày hiệu lực")
                        {
                            writer.WriteExcelAutoStyledCell(item.NgayHL);
                        }
                        if (hed[col] == "Ngày hết hiệu lực")
                        {
                            writer.WriteExcelAutoStyledCell(item.NgayhetHL);
                        }
                        if (hed[col] == "Ngày NLĐ ký")
                        {
                            if (item.QT_NgayNLDky == null)
                            {
                                writer.WriteExcelAutoStyledCell(item.QT_NLDky);
                            }
                            else
                            {
                                writer.WriteExcelAutoStyledCell(item.QT_NgayNLDky);
                            }
                        }
                        if (hed[col] == "Ngày trình")
                        {
                            if (item.QT_NgayTrinhHT == null)
                            {
                                writer.WriteExcelAutoStyledCell(item.QT_TrinhHT);
                            }
                            else
                            {
                                writer.WriteExcelAutoStyledCell(item.QT_NgayTrinhHT);
                            }
                        }
                        if (hed[col] == "Ngày HT ký")
                        {
                            if (item.QT_NgayHTky == null)
                            {
                                writer.WriteExcelAutoStyledCell(item.QT_HTky);
                            }
                            else
                            {
                                writer.WriteExcelAutoStyledCell(item.QT_NgayHTky);
                            }
                        }
                        if (hed[col] == "Ngày lưu")
                        {
                            if (item.QT_NgayLuuHS == null)
                            {
                                writer.WriteExcelAutoStyledCell(item.QT_LuuHS);
                            }
                            else
                            {
                                writer.WriteExcelAutoStyledCell(item.QT_NgayLuuHS);
                            }
                        }
                        if (hed[col] == "Ngày trả")
                        {
                            if (item.QT_NgayTraNLD == null)
                            {
                                writer.WriteExcelAutoStyledCell(item.QT_TraNLD);
                            }
                            else
                            {
                                writer.WriteExcelAutoStyledCell(item.QT_NgayTraNLD);
                            }
                        }
                        if (hed[col] == "Lương cơ bản")
                        {
                            writer.WriteExcelAutoStyledCell(item.Mucluongchinh);
                        }
                        double? HeSo = null;
                        var Bac = "";
                        var Ngach = "";
                        var Nhom = "";


                        int? nHSLuong_id = item.HSLuong_id;
                        int? nNgach_id = item.Ngach_id;
                        int? nNhom_id = item.Nhom_id;
                        try
                        {
                            HeSo = db0.dmBangLuong.Where(bl => bl.id == nHSLuong_id).FirstOrDefault().hesoLuong;
                        }
                        catch
                        {
                        }
                        try
                        {
                            Bac = db0.dmBangLuong.Where(bl => bl.id == nHSLuong_id).FirstOrDefault().bacLuong;
                        }
                        catch
                        {
                        }
                        try
                        {
                            Ngach = db0.dmNgachVienChuc.Where(bl => bl.id == nNgach_id).FirstOrDefault().tenNgachVienChuc;
                        }
                        catch
                        {
                        }
                        try
                        {
                            Nhom = db0.dmNhomNgachVienChuc.Where(bl => bl.id == nNhom_id).FirstOrDefault().tenNhomNgachVienChuc;
                        }
                        catch
                        {
                        }
                        if (hed[col] == "Hệ số lương")
                        {
                            writer.WriteExcelAutoStyledCell(HeSo);
                        }
                        if (hed[col] == "Bậc")
                        {
                            writer.WriteExcelAutoStyledCell(Bac);
                        }
                        if (hed[col] == "Ngạch")
                        {
                            writer.WriteExcelAutoStyledCell(Ngach);
                        }
                        if (hed[col] == "Nhóm")
                        {
                            writer.WriteExcelAutoStyledCell(Nhom);
                        }
                        if (hed[col] == "Bảng lương")
                        {
                            writer.WriteExcelAutoStyledCell(item.Bangluong_id);
                        }
                    }
                    writer.WriteEndRow();
                }
                // complete writing to excel
                writer.WriteEndWorksheet();
                writer.WriteEndDocument();
            }
            Response.AddHeader("content-disposition", "attachment; filename=Report.xls");
            Response.ContentType = "application/xls";
            Response.Write(excel.ToString());
            Response.End();
            return RedirectToAction("Index", "BaoCao");
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}