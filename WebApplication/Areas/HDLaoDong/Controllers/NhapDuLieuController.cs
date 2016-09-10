using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRM.Databases_HDLaoDong.Models;
using HRM.Databases.Models;
using System.Data.OleDb;

namespace HRM.HDLaoDong.Controllers
{
    public class NhapDuLieuController : Controller
    {
        private HRMDB2Entities db = new HRMDB2Entities();
        private HRMDB0Entities db0 = new HRMDB0Entities();
        //
        // GET: /NhapDuLieu/

        public ActionResult Index()
        {
            var hdchitiethdlds = db.hdChiTietHDLD.ToList();
            return View(hdchitiethdlds);
        }

        public ActionResult ImportToExcel()
        {
            if (Request.Files["FileUpload1"].ContentLength > 0)
            {
                string extension = System.IO.Path.GetExtension(Request.Files["FileUpload1"].FileName);
                string path1 = string.Format("{0}/{1}", Server.MapPath("~/Areas/HDLaoDong/Contents/UploadedFolder"), Request.Files["FileUpload1"].FileName);
                if (System.IO.File.Exists(path1))
                    System.IO.File.Delete(path1);
                Request.Files["FileUpload1"].SaveAs(path1);
                //Create connection string to Excel work book
                string excelConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path1 + ";Extended Properties=Excel 12.0;Persist Security Info=False";
                //Create Connection to Excel work book
                OleDbConnection excelConnection = new OleDbConnection(excelConnectionString);
                //Create OleDbCommand to fetch data from Excel
                OleDbCommand cmd = new OleDbCommand("Select * from [Sheet1$]", excelConnection);
                try
                {
                    excelConnection.Open();
                }
                catch {
                    TempData["Message_Error"] = "Vui lòng chỉ nhập file excel!";
                    excelConnection.Close();
                    return RedirectToAction("Index", "NhapDuLieu");
                }
                OleDbDataReader dReader;
                dReader = cmd.ExecuteReader();
                int count = 0;
                int total = 0;
                if (Request.Form["view"] == null || Request.Form["view"] == "")
                {
                    while (dReader.Read())
                    {
                        total += 1;
                        try
                        {
                            var hdcthdld = new hdChiTietHDLD();
                            bool IsHad = false;
                            int NLD_id = 0;
                            var MaNV = dReader.GetValue(0).ToString();
                            foreach (var item in db.hdNLD.ToList())
                            {
                                if (item.NV_id == MaNV)
                                {
                                    IsHad = true;
                                    NLD_id = item.id;
                                    break;
                                }
                            }
                            if (IsHad == true)
                            {

                                hdcthdld.NLD_id = NLD_id;
                                hdcthdld.HotenNLD = dReader.GetValue(1).ToString();
                                var dm = db0.NhanVien.ToList();
                                var NV_id = db0.NhanVien.Where(nv => nv.MaNV == MaNV).FirstOrDefault().id;

                                hdcthdld.Gioitinh_id = db0.nvSoYeuLyLich.Where(sy => sy.NV_id == NV_id).FirstOrDefault().GioiTinh_id;
                                hdcthdld.Quoctich_id = db0.nvSoYeuLyLich.Where(sy => sy.NV_id == NV_id).FirstOrDefault().QuocTich_id;
                                hdcthdld.Ngaysinh = db0.nvSoYeuLyLich.Where(sy => sy.NV_id == NV_id).FirstOrDefault().NgaySinh;
                                int? NoiSinh_id = db0.nvSoYeuLyLich.Where(sy => sy.NV_id == NV_id).FirstOrDefault().NoiSinh_TinhThanh_id;
                                hdcthdld.Noisinh = db0.dmTinhThanh.Where(tt => tt.id == NoiSinh_id).FirstOrDefault().tenTinhThanh;
                                hdcthdld.Nghenghiep_id = db0.nvQTLamViec.Where(qt => qt.NV_id == NV_id).FirstOrDefault().NgheNghiep_id;
                                int? ttTinhThanh_id = db0.nvDiaChiNha.Where(sy => sy.NV_id == NV_id).FirstOrDefault().TinhThanh_id;
                                int? ttQuanHuyen_id = db0.nvDiaChiNha.Where(sy => sy.NV_id == NV_id).FirstOrDefault().QuanHuyen_id;
                                int? ttPhuongXa_id = db0.nvDiaChiNha.Where(sy => sy.NV_id == NV_id).FirstOrDefault().PhuongXa_id;
                                var ttTinhThanh = "";
                                var ttQuanHuyen = "";
                                var ttPhuongXa = "";
                                try
                                {
                                    ttTinhThanh = db0.dmTinhThanh.Where(tt => tt.id == ttTinhThanh_id).FirstOrDefault().tenTinhThanh;
                                }
                                catch { }
                                try
                                {
                                    ttQuanHuyen = db0.dmQuanHuyen.Where(qh => qh.id == ttQuanHuyen_id).FirstOrDefault().tenQuanHuyen;
                                }
                                catch { }
                                try
                                {
                                    ttPhuongXa = db0.dmPhuongXa.Where(qh => qh.id == ttPhuongXa_id).FirstOrDefault().tenPhuongXa;
                                }
                                catch { }
                                hdcthdld.Diachithuongtru = ttTinhThanh;
                                if (ttQuanHuyen != "")
                                {
                                    hdcthdld.Diachithuongtru = ttQuanHuyen + ", " + ttTinhThanh;
                                }
                                if (ttPhuongXa != "")
                                {
                                    hdcthdld.Diachithuongtru = ttPhuongXa + ", " + ttQuanHuyen + ", " + ttTinhThanh;
                                }
                                hdcthdld.soCMND = db0.nvTheDinhDanh.Where(sy => sy.NV_id == NV_id).FirstOrDefault().SoThe;
                                hdcthdld.cmndNoicap = db0.nvTheDinhDanh.Where(sy => sy.NV_id == NV_id).FirstOrDefault().NoiCap_id;
                                hdcthdld.cmndNgaycap = db0.nvTheDinhDanh.Where(sy => sy.NV_id == NV_id).FirstOrDefault().NgayCap;

                                hdcthdld.Donvi_id = db0.nvQTLamViec.Where(sy => sy.NV_id == NV_id).FirstOrDefault().DonVi_id;
                                hdcthdld.Chucdanh_id = db0.nvQTLamViec.Where(sy => sy.NV_id == NV_id).FirstOrDefault().ChucDanhChucVu_id;

                                hdcthdld.SoHD = dReader.GetValue(2).ToString();
                                hdcthdld.LoaiHD = dReader.GetValue(3).ToString();
                                string THHD = dReader.GetValue(4).ToString();
                                int ThoiHanHD_id = db.dmThoiHanHD.Where(th => th.tenThoiHanHD == THHD).FirstOrDefault().id;
                                hdcthdld.ThoihanHD_id = ThoiHanHD_id;
                                hdcthdld.NgayHL = DateTime.Parse(dReader.GetValue(5).ToString());
                                try
                                {
                                    hdcthdld.NgayhetHL = DateTime.Parse(dReader.GetValue(6).ToString());
                                }
                                catch { }
                                hdcthdld.Congviec = dReader.GetValue(7).ToString();
                                string TGLV = dReader.GetValue(8).ToString();
                                int ThoiGioLV_id = db.dmThoiGioLamViec.Where(th => th.tenThoiGioLamViec == TGLV).FirstOrDefault().id;
                                hdcthdld.ThoigioLV_id = ThoiGioLV_id;
                                if (dReader.GetValue(9).ToString().Count() > 0)
                                {
                                    hdcthdld.BHXH = true;
                                }
                                else
                                {
                                    hdcthdld.BHXH = false;
                                }
                                hdcthdld.Mucluongchinh = dReader.GetValue(10).ToString();
                                try
                                {
                                    hdcthdld.Tyleluong = int.Parse(dReader.GetValue(11).ToString());
                                }
                                catch { }
                                var Nhom = dReader.GetValue(15).ToString();
                                var Ngach = dReader.GetValue(14).ToString();
                                var Bac = dReader.GetValue(13).ToString();
                                var HSLuong = dReader.GetValue(12).ToString();
                                int? Nhom_id = db0.dmNhomNgachVienChuc.Where(nn => nn.tenNhomNgachVienChuc == Nhom || nn.maNhomNgachVienChuc == Nhom).FirstOrDefault().id;
                                int? Ngach_id = db0.dmNgachVienChuc.Where(n => n.tenNgachVienChuc == Ngach).FirstOrDefault().id;
                                int? Bac_id = db0.dmBangLuong.Where(bl => bl.idNhomNgach == Nhom_id && bl.bacLuong == Bac).FirstOrDefault().id;

                                hdcthdld.HSLuong_id = Bac_id;
                                hdcthdld.Bac_id = Bac_id;
                                hdcthdld.Ngach_id = Ngach_id;
                                hdcthdld.Nhom_id = Nhom_id;
                                hdcthdld.Bangluong_id = dReader.GetValue(16).ToString();
                                try
                                {
                                    hdcthdld.QT_NgayNLDky = DateTime.Parse(dReader.GetValue(17).ToString());
                                }
                                catch
                                {
                                    hdcthdld.QT_NLDky = dReader.GetValue(17).ToString();
                                }
                                try
                                {
                                    hdcthdld.QT_NgayTrinhHT = DateTime.Parse(dReader.GetValue(18).ToString());
                                }
                                catch
                                {
                                    hdcthdld.QT_TrinhHT = dReader.GetValue(18).ToString();
                                }
                                try
                                {
                                    hdcthdld.QT_NgayHTky = DateTime.Parse(dReader.GetValue(19).ToString());
                                }
                                catch
                                {
                                    hdcthdld.QT_HTky = dReader.GetValue(19).ToString();
                                }
                                try
                                {
                                    hdcthdld.QT_NgayLuuHS = DateTime.Parse(dReader.GetValue(20).ToString());
                                }
                                catch
                                {
                                    hdcthdld.QT_LuuHS = dReader.GetValue(20).ToString();
                                }
                                try
                                {
                                    hdcthdld.QT_NgayTraNLD = DateTime.Parse(dReader.GetValue(21).ToString());
                                }
                                catch
                                {
                                    hdcthdld.QT_TraNLD = dReader.GetValue(21).ToString();
                                }
                                db.hdChiTietHDLD.Add(hdcthdld);
                                db.SaveChanges();
                                count += 1;
                            }
                            else if (dReader.GetValue(0).ToString() != "" && dReader.GetValue(1).ToString() != "" && dReader.GetValue(2).ToString() != "" && dReader.GetValue(3).ToString() != "" && dReader.GetValue(4).ToString() != "" && dReader.GetValue(5).ToString() != "" && dReader.GetValue(8).ToString() != "" && dReader.GetValue(10).ToString() != "")
                            {
                                int hdnldidDatao = 0;
                                try
                                {
                                    var hdnld = new hdNLD();
                                    hdnld.NV_id = MaNV;
                                    hdnld.hidden = false;
                                    db.hdNLD.Add(hdnld);
                                    db.SaveChanges();
                                    //test
                                    hdnldidDatao = hdnld.id;

                                    var dm = db0.NhanVien.ToList();
                                    var NV_id = db0.NhanVien.Where(nv => nv.MaNV == MaNV).FirstOrDefault().id;
                                    hdcthdld.NLD_id = hdnld.id;
                                    hdcthdld.HotenNLD = dReader.GetValue(1).ToString();

                                    hdcthdld.Gioitinh_id = db0.nvSoYeuLyLich.Where(sy => sy.NV_id == NV_id).FirstOrDefault().GioiTinh_id;
                                    hdcthdld.Quoctich_id = db0.nvSoYeuLyLich.Where(sy => sy.NV_id == NV_id).FirstOrDefault().QuocTich_id;
                                    hdcthdld.Ngaysinh = db0.nvSoYeuLyLich.Where(sy => sy.NV_id == NV_id).FirstOrDefault().NgaySinh;
                                    int? NoiSinh_id = db0.nvSoYeuLyLich.Where(sy => sy.NV_id == NV_id).FirstOrDefault().NoiSinh_TinhThanh_id;
                                    hdcthdld.Noisinh = db0.dmTinhThanh.Where(tt => tt.id == NoiSinh_id).FirstOrDefault().tenTinhThanh;
                                    hdcthdld.Nghenghiep_id = db0.nvQTLamViec.Where(qt => qt.NV_id == NV_id).FirstOrDefault().NgheNghiep_id;
                                    int? ttTinhThanh_id = db0.nvDiaChiNha.Where(sy => sy.NV_id == NV_id).FirstOrDefault().TinhThanh_id;
                                    int? ttQuanHuyen_id = db0.nvDiaChiNha.Where(sy => sy.NV_id == NV_id).FirstOrDefault().QuanHuyen_id;
                                    int? ttPhuongXa_id = db0.nvDiaChiNha.Where(sy => sy.NV_id == NV_id).FirstOrDefault().PhuongXa_id;
                                    var ttTinhThanh = "";
                                    var ttQuanHuyen = "";
                                    var ttPhuongXa = "";
                                    try
                                    {
                                        ttTinhThanh = db0.dmTinhThanh.Where(tt => tt.id == ttTinhThanh_id).FirstOrDefault().tenTinhThanh;
                                    }
                                    catch { }
                                    try
                                    {
                                        ttQuanHuyen = db0.dmQuanHuyen.Where(qh => qh.id == ttQuanHuyen_id).FirstOrDefault().tenQuanHuyen;
                                    }
                                    catch { }
                                    try
                                    {
                                        ttPhuongXa = db0.dmPhuongXa.Where(qh => qh.id == ttPhuongXa_id).FirstOrDefault().tenPhuongXa;
                                    }
                                    catch { }
                                    hdcthdld.Diachithuongtru = ttTinhThanh;
                                    if (ttQuanHuyen != "")
                                    {
                                        hdcthdld.Diachithuongtru = ttQuanHuyen + ", " + ttTinhThanh;
                                    }
                                    if (ttPhuongXa != "")
                                    {
                                        hdcthdld.Diachithuongtru = ttPhuongXa + ", " + ttQuanHuyen + ", " + ttTinhThanh;
                                    }
                                    hdcthdld.soCMND = db0.nvTheDinhDanh.Where(sy => sy.NV_id == NV_id).FirstOrDefault().SoThe;
                                    hdcthdld.cmndNoicap = db0.nvTheDinhDanh.Where(sy => sy.NV_id == NV_id).FirstOrDefault().NoiCap_id;
                                    hdcthdld.cmndNgaycap = db0.nvTheDinhDanh.Where(sy => sy.NV_id == NV_id).FirstOrDefault().NgayCap;

                                    hdcthdld.Donvi_id = db0.nvQTLamViec.Where(sy => sy.NV_id == NV_id).FirstOrDefault().DonVi_id;
                                    hdcthdld.Chucdanh_id = db0.nvQTLamViec.Where(sy => sy.NV_id == NV_id).FirstOrDefault().ChucDanhChucVu_id;

                                    hdcthdld.SoHD = dReader.GetValue(2).ToString();
                                    hdcthdld.LoaiHD = dReader.GetValue(3).ToString();
                                    string THHD = dReader.GetValue(4).ToString();
                                    int ThoiHanHD_id = db.dmThoiHanHD.Where(th => th.tenThoiHanHD == THHD).FirstOrDefault().id;
                                    hdcthdld.ThoihanHD_id = ThoiHanHD_id;
                                    hdcthdld.NgayHL = DateTime.Parse(dReader.GetValue(5).ToString());
                                    try
                                    {
                                        hdcthdld.NgayhetHL = DateTime.Parse(dReader.GetValue(6).ToString());
                                    }
                                    catch { }
                                    hdcthdld.Congviec = dReader.GetValue(7).ToString();
                                    string TGLV = dReader.GetValue(8).ToString();
                                    int ThoiGioLV_id = db.dmThoiGioLamViec.Where(th => th.tenThoiGioLamViec == TGLV).FirstOrDefault().id;
                                    hdcthdld.ThoigioLV_id = ThoiGioLV_id;
                                    if (dReader.GetValue(9).ToString().Count() > 0)
                                    {
                                        hdcthdld.BHXH = true;
                                    }
                                    else
                                    {
                                        hdcthdld.BHXH = false;
                                    }
                                    hdcthdld.Mucluongchinh = dReader.GetValue(10).ToString();
                                    try
                                    {
                                        hdcthdld.Tyleluong = int.Parse(dReader.GetValue(11).ToString());
                                    }
                                    catch { }
                                    var Nhom = dReader.GetValue(15).ToString();
                                    var Ngach = dReader.GetValue(14).ToString();
                                    var Bac = dReader.GetValue(13).ToString();
                                    var HSLuong = dReader.GetValue(12).ToString();
                                    int? Nhom_id = db0.dmNhomNgachVienChuc.Where(nn => nn.tenNhomNgachVienChuc == Nhom || nn.maNhomNgachVienChuc == Nhom).FirstOrDefault().id;
                                    int? Ngach_id = db0.dmNgachVienChuc.Where(n => n.tenNgachVienChuc == Ngach).FirstOrDefault().id;
                                    int? Bac_id = db0.dmBangLuong.Where(bl => bl.idNhomNgach == Nhom_id && bl.bacLuong == Bac).FirstOrDefault().id;

                                    hdcthdld.HSLuong_id = Bac_id;
                                    hdcthdld.Bac_id = Bac_id;
                                    hdcthdld.Ngach_id = Ngach_id;
                                    hdcthdld.Nhom_id = Nhom_id;
                                    hdcthdld.Bangluong_id = dReader.GetValue(16).ToString();
                                    try
                                    {
                                        hdcthdld.QT_NgayNLDky = DateTime.Parse(dReader.GetValue(17).ToString());
                                    }
                                    catch
                                    {
                                        hdcthdld.QT_NLDky = dReader.GetValue(17).ToString();
                                    }
                                    try
                                    {
                                        hdcthdld.QT_NgayTrinhHT = DateTime.Parse(dReader.GetValue(18).ToString());
                                    }
                                    catch
                                    {
                                        hdcthdld.QT_TrinhHT = dReader.GetValue(18).ToString();
                                    }
                                    try
                                    {
                                        hdcthdld.QT_NgayHTky = DateTime.Parse(dReader.GetValue(19).ToString());
                                    }
                                    catch
                                    {
                                        hdcthdld.QT_HTky = dReader.GetValue(19).ToString();
                                    }
                                    try
                                    {
                                        hdcthdld.QT_NgayLuuHS = DateTime.Parse(dReader.GetValue(20).ToString());
                                    }
                                    catch
                                    {
                                        hdcthdld.QT_LuuHS = dReader.GetValue(20).ToString();
                                    }
                                    try
                                    {
                                        hdcthdld.QT_NgayTraNLD = DateTime.Parse(dReader.GetValue(21).ToString());
                                    }
                                    catch
                                    {
                                        hdcthdld.QT_TraNLD = dReader.GetValue(21).ToString();
                                    }
                                    db.hdChiTietHDLD.Add(hdcthdld);
                                    db.SaveChanges();
                                    count += 1;
                                    hdnldidDatao = 0;
                                }
                                catch
                                {
                                    if (hdnldidDatao != 0)
                                    {
                                        var hdnld = db.hdNLD.Where(ld => ld.id == hdnldidDatao).FirstOrDefault();
                                        db.hdNLD.Remove(hdnld);
                                        db.SaveChanges();
                                    }
                                }
                            }
                        }
                        catch { }
                    }
                    TempData["Message_NhapDuLieu"] = "Bạn đã import thành công " + count + "/" + (total-1) + " hợp đồng!";
                    excelConnection.Close();
                }
                else
                {
                    var lisHDCTHDLD = new List<hdChiTietHDLD>();
                    while (dReader.Read())
                    {
                        try
                        {
                            var hdcthdld = new hdChiTietHDLD();
                            var MaNV = dReader.GetValue(0).ToString();
                            hdcthdld.HotenNLD = dReader.GetValue(1).ToString();
                            var dm = db0.NhanVien.ToList();
                            var NV_id = db0.NhanVien.Where(nv => nv.MaNV == MaNV).FirstOrDefault().id;

                            hdcthdld.Gioitinh_id = db0.nvSoYeuLyLich.Where(sy => sy.NV_id == NV_id).FirstOrDefault().GioiTinh_id;
                            hdcthdld.Quoctich_id = db0.nvSoYeuLyLich.Where(sy => sy.NV_id == NV_id).FirstOrDefault().QuocTich_id;
                            hdcthdld.Ngaysinh = db0.nvSoYeuLyLich.Where(sy => sy.NV_id == NV_id).FirstOrDefault().NgaySinh;
                            int? NoiSinh_id = db0.nvSoYeuLyLich.Where(sy => sy.NV_id == NV_id).FirstOrDefault().NoiSinh_TinhThanh_id;
                            hdcthdld.Noisinh = db0.dmTinhThanh.Where(tt => tt.id == NoiSinh_id).FirstOrDefault().tenTinhThanh;
                            hdcthdld.Nghenghiep_id = db0.nvQTLamViec.Where(qt => qt.NV_id == NV_id).FirstOrDefault().NgheNghiep_id;
                            int? ttTinhThanh_id = db0.nvDiaChiNha.Where(sy => sy.NV_id == NV_id).FirstOrDefault().TinhThanh_id;
                            int? ttQuanHuyen_id = db0.nvDiaChiNha.Where(sy => sy.NV_id == NV_id).FirstOrDefault().QuanHuyen_id;
                            int? ttPhuongXa_id = db0.nvDiaChiNha.Where(sy => sy.NV_id == NV_id).FirstOrDefault().PhuongXa_id;
                            var ttTinhThanh = "";
                            var ttQuanHuyen = "";
                            var ttPhuongXa = "";
                            try
                            {
                                ttTinhThanh = db0.dmTinhThanh.Where(tt => tt.id == ttTinhThanh_id).FirstOrDefault().tenTinhThanh;
                            }
                            catch { }
                            try
                            {
                                ttQuanHuyen = db0.dmQuanHuyen.Where(qh => qh.id == ttQuanHuyen_id).FirstOrDefault().tenQuanHuyen;
                            }
                            catch { }
                            try
                            {
                                ttPhuongXa = db0.dmPhuongXa.Where(qh => qh.id == ttPhuongXa_id).FirstOrDefault().tenPhuongXa;
                            }
                            catch { }
                            hdcthdld.Diachithuongtru = ttTinhThanh;
                            if (ttQuanHuyen != "")
                            {
                                hdcthdld.Diachithuongtru = ttQuanHuyen + ", " + ttTinhThanh;
                            }
                            if (ttPhuongXa != "")
                            {
                                hdcthdld.Diachithuongtru = ttPhuongXa + ", " + ttQuanHuyen + ", " + ttTinhThanh;
                            }
                            hdcthdld.soCMND = db0.nvTheDinhDanh.Where(sy => sy.NV_id == NV_id).FirstOrDefault().SoThe;
                            hdcthdld.cmndNoicap = db0.nvTheDinhDanh.Where(sy => sy.NV_id == NV_id).FirstOrDefault().NoiCap_id;
                            hdcthdld.cmndNgaycap = db0.nvTheDinhDanh.Where(sy => sy.NV_id == NV_id).FirstOrDefault().NgayCap;

                            hdcthdld.Donvi_id = db0.nvQTLamViec.Where(sy => sy.NV_id == NV_id).FirstOrDefault().DonVi_id;
                            hdcthdld.Chucdanh_id = db0.nvQTLamViec.Where(sy => sy.NV_id == NV_id).FirstOrDefault().ChucDanhChucVu_id;

                            hdcthdld.SoHD = dReader.GetValue(2).ToString();
                            hdcthdld.LoaiHD = dReader.GetValue(3).ToString();
                            string THHD = dReader.GetValue(4).ToString();
                            int ThoiHanHD_id = db.dmThoiHanHD.Where(th => th.tenThoiHanHD == THHD).FirstOrDefault().id;
                            hdcthdld.ThoihanHD_id = ThoiHanHD_id;
                            hdcthdld.NgayHL = DateTime.Parse(dReader.GetValue(5).ToString());
                            try
                            {
                                hdcthdld.NgayhetHL = DateTime.Parse(dReader.GetValue(6).ToString());
                            }
                            catch { }
                            hdcthdld.Congviec = dReader.GetValue(7).ToString();
                            string TGLV = dReader.GetValue(8).ToString();
                            int ThoiGioLV_id = db.dmThoiGioLamViec.Where(th => th.tenThoiGioLamViec == TGLV).FirstOrDefault().id;
                            hdcthdld.ThoigioLV_id = ThoiGioLV_id;
                            if (dReader.GetValue(9).ToString().Count() > 0)
                            {
                                hdcthdld.BHXH = true;
                            }
                            else
                            {
                                hdcthdld.BHXH = false;
                            }
                            hdcthdld.Mucluongchinh = dReader.GetValue(10).ToString();
                            try
                            {
                                hdcthdld.Tyleluong = int.Parse(dReader.GetValue(11).ToString());
                            }
                            catch { }
                            var Nhom = dReader.GetValue(15).ToString();
                            var Ngach = dReader.GetValue(14).ToString();
                            var Bac = dReader.GetValue(13).ToString();
                            var HSLuong = dReader.GetValue(12).ToString();
                            int? Nhom_id = db0.dmNhomNgachVienChuc.Where(nn => nn.tenNhomNgachVienChuc == Nhom || nn.maNhomNgachVienChuc == Nhom).FirstOrDefault().id;
                            int? Ngach_id = db0.dmNgachVienChuc.Where(n => n.tenNgachVienChuc == Ngach).FirstOrDefault().id;
                            int? Bac_id = db0.dmBangLuong.Where(bl => bl.idNhomNgach == Nhom_id && bl.bacLuong == Bac).FirstOrDefault().id;

                            hdcthdld.HSLuong_id = Bac_id;
                            hdcthdld.Bac_id = Bac_id;
                            hdcthdld.Ngach_id = Ngach_id;
                            hdcthdld.Nhom_id = Nhom_id;
                            hdcthdld.Bangluong_id = dReader.GetValue(16).ToString();
                            try
                            {
                                hdcthdld.QT_NgayNLDky = DateTime.Parse(dReader.GetValue(17).ToString());
                            }
                            catch
                            {
                                hdcthdld.QT_NLDky = dReader.GetValue(17).ToString();
                            }
                            try
                            {
                                hdcthdld.QT_NgayTrinhHT = DateTime.Parse(dReader.GetValue(18).ToString());
                            }
                            catch
                            {
                                hdcthdld.QT_TrinhHT = dReader.GetValue(18).ToString();
                            }
                            try
                            {
                                hdcthdld.QT_NgayHTky = DateTime.Parse(dReader.GetValue(19).ToString());
                            }
                            catch
                            {
                                hdcthdld.QT_HTky = dReader.GetValue(19).ToString();
                            }
                            try
                            {
                                hdcthdld.QT_NgayLuuHS = DateTime.Parse(dReader.GetValue(20).ToString());
                            }
                            catch
                            {
                                hdcthdld.QT_LuuHS = dReader.GetValue(20).ToString();
                            }
                            try
                            {
                                hdcthdld.QT_NgayTraNLD = DateTime.Parse(dReader.GetValue(21).ToString());
                            }
                            catch
                            {
                                hdcthdld.QT_TraNLD = dReader.GetValue(21).ToString();
                            }
                            lisHDCTHDLD.Add(hdcthdld);
                        }
                        catch { }
                    }
                    excelConnection.Close();
                    TempData["lisHDCTHDLD"] = lisHDCTHDLD;
                    TempData["path"] = path1;
                    return RedirectToAction("Index", "NhapDuLieu");
                }
            }
            else if (Request.Form["path"] != null)
            {
                string path1 = Request.Form["path"].ToString();
                //Create connection string to Excel work book
                string excelConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path1 + ";Extended Properties=Excel 12.0;Persist Security Info=False";
                //Create Connection to Excel work book
                OleDbConnection excelConnection = new OleDbConnection(excelConnectionString);
                //Create OleDbCommand to fetch data from Excel
                OleDbCommand cmd = new OleDbCommand("Select * from [Sheet1$]", excelConnection);

                try
                {
                    excelConnection.Open();
                }
                catch
                {
                    TempData["Message_Error"] = "Vui lòng chỉ nhập file excel!";
                    excelConnection.Close();
                    return RedirectToAction("Index", "NhapDuLieu");
                }
                OleDbDataReader dReader;
                dReader = cmd.ExecuteReader();
                int count = 0;
                int total = 0;
                while (dReader.Read())
                {
                    total += 1;
                    try
                    {
                        var hdcthdld = new hdChiTietHDLD();
                        bool IsHad = false;
                        int NLD_id = 0;
                        var MaNV = dReader.GetValue(0).ToString();
                        foreach (var item in db.hdNLD.ToList())
                        {
                            if (item.NV_id == MaNV)
                            {
                                IsHad = true;
                                NLD_id = item.id;
                                break;
                            }
                        }
                        if (IsHad == true)
                        {
                            
                            hdcthdld.NLD_id = NLD_id;
                            hdcthdld.HotenNLD = dReader.GetValue(1).ToString();
                            var dm = db0.NhanVien.ToList();
                            var NV_id = db0.NhanVien.Where(nv => nv.MaNV == MaNV).FirstOrDefault().id;

                            hdcthdld.Gioitinh_id = db0.nvSoYeuLyLich.Where(sy => sy.NV_id == NV_id).FirstOrDefault().GioiTinh_id;
                            hdcthdld.Quoctich_id = db0.nvSoYeuLyLich.Where(sy => sy.NV_id == NV_id).FirstOrDefault().QuocTich_id;
                            hdcthdld.Ngaysinh = db0.nvSoYeuLyLich.Where(sy => sy.NV_id == NV_id).FirstOrDefault().NgaySinh;
                            int? NoiSinh_id = db0.nvSoYeuLyLich.Where(sy => sy.NV_id == NV_id).FirstOrDefault().NoiSinh_TinhThanh_id;
                            hdcthdld.Noisinh = db0.dmTinhThanh.Where(tt => tt.id == NoiSinh_id).FirstOrDefault().tenTinhThanh;
                            hdcthdld.Nghenghiep_id = db0.nvQTLamViec.Where(qt => qt.NV_id == NV_id).FirstOrDefault().NgheNghiep_id;
                            int? ttTinhThanh_id = db0.nvDiaChiNha.Where(sy => sy.NV_id == NV_id).FirstOrDefault().TinhThanh_id;
                            int? ttQuanHuyen_id = db0.nvDiaChiNha.Where(sy => sy.NV_id == NV_id).FirstOrDefault().QuanHuyen_id;
                            int? ttPhuongXa_id = db0.nvDiaChiNha.Where(sy => sy.NV_id == NV_id).FirstOrDefault().PhuongXa_id;
                            var ttTinhThanh = "";
                            var ttQuanHuyen = "";
                            var ttPhuongXa = "";
                            try
                            {
                                ttTinhThanh = db0.dmTinhThanh.Where(tt => tt.id == ttTinhThanh_id).FirstOrDefault().tenTinhThanh;
                            }
                            catch { }
                            try
                            {
                                ttQuanHuyen = db0.dmQuanHuyen.Where(qh => qh.id == ttQuanHuyen_id).FirstOrDefault().tenQuanHuyen;
                            }
                            catch { }
                            try
                            {
                                ttPhuongXa = db0.dmPhuongXa.Where(qh => qh.id == ttPhuongXa_id).FirstOrDefault().tenPhuongXa;
                            }
                            catch { }
                            hdcthdld.Diachithuongtru = ttTinhThanh;
                            if (ttQuanHuyen != "")
                            {
                                hdcthdld.Diachithuongtru = ttQuanHuyen + ", " + ttTinhThanh;
                            }
                            if (ttPhuongXa != "")
                            {
                                hdcthdld.Diachithuongtru = ttPhuongXa + ", " + ttQuanHuyen + ", " + ttTinhThanh;
                            }
                            hdcthdld.soCMND = db0.nvTheDinhDanh.Where(sy => sy.NV_id == NV_id).FirstOrDefault().SoThe;
                            hdcthdld.cmndNoicap = db0.nvTheDinhDanh.Where(sy => sy.NV_id == NV_id).FirstOrDefault().NoiCap_id;
                            hdcthdld.cmndNgaycap = db0.nvTheDinhDanh.Where(sy => sy.NV_id == NV_id).FirstOrDefault().NgayCap;

                            hdcthdld.Donvi_id = db0.nvQTLamViec.Where(sy => sy.NV_id == NV_id).FirstOrDefault().DonVi_id;
                            hdcthdld.Chucdanh_id = db0.nvQTLamViec.Where(sy => sy.NV_id == NV_id).FirstOrDefault().ChucDanhChucVu_id;

                            hdcthdld.SoHD = dReader.GetValue(2).ToString();
                            hdcthdld.LoaiHD = dReader.GetValue(3).ToString();
                            string THHD = dReader.GetValue(4).ToString();
                            int ThoiHanHD_id = db.dmThoiHanHD.Where(th => th.tenThoiHanHD == THHD).FirstOrDefault().id;
                            hdcthdld.ThoihanHD_id = ThoiHanHD_id;
                            hdcthdld.NgayHL = DateTime.Parse(dReader.GetValue(5).ToString());
                            try
                            {
                                hdcthdld.NgayhetHL = DateTime.Parse(dReader.GetValue(6).ToString());
                            }
                            catch { }
                            hdcthdld.Congviec = dReader.GetValue(7).ToString();
                            string TGLV = dReader.GetValue(8).ToString();
                            int ThoiGioLV_id = db.dmThoiGioLamViec.Where(th => th.tenThoiGioLamViec == TGLV).FirstOrDefault().id;
                            hdcthdld.ThoigioLV_id = ThoiGioLV_id;
                            if (dReader.GetValue(9).ToString().Count() > 0)
                            {
                                hdcthdld.BHXH = true;
                            }
                            else
                            {
                                hdcthdld.BHXH = false;
                            }
                            hdcthdld.Mucluongchinh = dReader.GetValue(10).ToString();
                            try
                            {
                                hdcthdld.Tyleluong = int.Parse(dReader.GetValue(11).ToString());
                            }
                            catch { }
                            var Nhom = dReader.GetValue(15).ToString();
                            var Ngach = dReader.GetValue(14).ToString();
                            var Bac = dReader.GetValue(13).ToString();
                            var HSLuong = dReader.GetValue(12).ToString();
                            int? Nhom_id = db0.dmNhomNgachVienChuc.Where(nn => nn.tenNhomNgachVienChuc == Nhom || nn.maNhomNgachVienChuc == Nhom).FirstOrDefault().id;
                            int? Ngach_id = db0.dmNgachVienChuc.Where(n => n.tenNgachVienChuc == Ngach).FirstOrDefault().id;
                            int? Bac_id = db0.dmBangLuong.Where(bl => bl.idNhomNgach == Nhom_id && bl.bacLuong == Bac).FirstOrDefault().id;

                            hdcthdld.HSLuong_id = Bac_id;
                            hdcthdld.Bac_id = Bac_id;
                            hdcthdld.Ngach_id = Ngach_id;
                            hdcthdld.Nhom_id = Nhom_id;
                            hdcthdld.Bangluong_id = dReader.GetValue(16).ToString();
                            try
                            {
                                hdcthdld.QT_NgayNLDky = DateTime.Parse(dReader.GetValue(17).ToString());
                            }
                            catch
                            {
                                hdcthdld.QT_NLDky = dReader.GetValue(17).ToString();
                            }
                            try
                            {
                                hdcthdld.QT_NgayTrinhHT = DateTime.Parse(dReader.GetValue(18).ToString());
                            }
                            catch
                            {
                                hdcthdld.QT_TrinhHT = dReader.GetValue(18).ToString();
                            }
                            try
                            {
                                hdcthdld.QT_NgayHTky = DateTime.Parse(dReader.GetValue(19).ToString());
                            }
                            catch
                            {
                                hdcthdld.QT_HTky = dReader.GetValue(19).ToString();
                            }
                            try
                            {
                                hdcthdld.QT_NgayLuuHS = DateTime.Parse(dReader.GetValue(20).ToString());
                            }
                            catch
                            {
                                hdcthdld.QT_LuuHS = dReader.GetValue(20).ToString();
                            }
                            try
                            {
                                hdcthdld.QT_NgayTraNLD = DateTime.Parse(dReader.GetValue(21).ToString());
                            }
                            catch
                            {
                                hdcthdld.QT_TraNLD = dReader.GetValue(21).ToString();
                            }
                            db.hdChiTietHDLD.Add(hdcthdld);
                            db.SaveChanges();
                            count += 1;
                        }
                        else if (dReader.GetValue(0).ToString() != "" && dReader.GetValue(1).ToString() != "" && dReader.GetValue(2).ToString() != "" && dReader.GetValue(3).ToString() != "" && dReader.GetValue(4).ToString() != "" && dReader.GetValue(5).ToString() != "" && dReader.GetValue(8).ToString() != "" && dReader.GetValue(10).ToString() != "")
                        {

                            int hdnldidDatao = 0;
                            try
                            {
                                var hdnld = new hdNLD();
                                hdnld.NV_id = MaNV;
                                hdnld.hidden = false;
                                db.hdNLD.Add(hdnld);
                                db.SaveChanges();
                                //test
                                hdnldidDatao = hdnld.id;

                                var dm = db0.NhanVien.ToList();
                                var NV_id = db0.NhanVien.Where(nv => nv.MaNV == MaNV).FirstOrDefault().id;
                                hdcthdld.NLD_id = hdnld.id;
                                hdcthdld.HotenNLD = dReader.GetValue(1).ToString();

                                hdcthdld.Gioitinh_id = db0.nvSoYeuLyLich.Where(sy => sy.NV_id == NV_id).FirstOrDefault().GioiTinh_id;
                                hdcthdld.Quoctich_id = db0.nvSoYeuLyLich.Where(sy => sy.NV_id == NV_id).FirstOrDefault().QuocTich_id;
                                hdcthdld.Ngaysinh = db0.nvSoYeuLyLich.Where(sy => sy.NV_id == NV_id).FirstOrDefault().NgaySinh;
                                int? NoiSinh_id = db0.nvSoYeuLyLich.Where(sy => sy.NV_id == NV_id).FirstOrDefault().NoiSinh_TinhThanh_id;
                                hdcthdld.Noisinh = db0.dmTinhThanh.Where(tt => tt.id == NoiSinh_id).FirstOrDefault().tenTinhThanh;
                                hdcthdld.Nghenghiep_id = db0.nvQTLamViec.Where(qt => qt.NV_id == NV_id).FirstOrDefault().NgheNghiep_id;
                                int? ttTinhThanh_id = db0.nvDiaChiNha.Where(sy => sy.NV_id == NV_id).FirstOrDefault().TinhThanh_id;
                                int? ttQuanHuyen_id = db0.nvDiaChiNha.Where(sy => sy.NV_id == NV_id).FirstOrDefault().QuanHuyen_id;
                                int? ttPhuongXa_id = db0.nvDiaChiNha.Where(sy => sy.NV_id == NV_id).FirstOrDefault().PhuongXa_id;
                                var ttTinhThanh = "";
                                var ttQuanHuyen = "";
                                var ttPhuongXa = "";
                                try
                                {
                                    ttTinhThanh = db0.dmTinhThanh.Where(tt => tt.id == ttTinhThanh_id).FirstOrDefault().tenTinhThanh;
                                }
                                catch { }
                                try
                                {
                                    ttQuanHuyen = db0.dmQuanHuyen.Where(qh => qh.id == ttQuanHuyen_id).FirstOrDefault().tenQuanHuyen;
                                }
                                catch { }
                                try
                                {
                                    ttPhuongXa = db0.dmPhuongXa.Where(qh => qh.id == ttPhuongXa_id).FirstOrDefault().tenPhuongXa;
                                }
                                catch { }
                                hdcthdld.Diachithuongtru = ttTinhThanh;
                                if (ttQuanHuyen != "")
                                {
                                    hdcthdld.Diachithuongtru = ttQuanHuyen + ", " + ttTinhThanh;
                                }
                                if (ttPhuongXa != "")
                                {
                                    hdcthdld.Diachithuongtru = ttPhuongXa + ", " + ttQuanHuyen + ", " + ttTinhThanh;
                                }
                                hdcthdld.soCMND = db0.nvTheDinhDanh.Where(sy => sy.NV_id == NV_id).FirstOrDefault().SoThe;
                                hdcthdld.cmndNoicap = db0.nvTheDinhDanh.Where(sy => sy.NV_id == NV_id).FirstOrDefault().NoiCap_id;
                                hdcthdld.cmndNgaycap = db0.nvTheDinhDanh.Where(sy => sy.NV_id == NV_id).FirstOrDefault().NgayCap;

                                hdcthdld.Donvi_id = db0.nvQTLamViec.Where(sy => sy.NV_id == NV_id).FirstOrDefault().DonVi_id;
                                hdcthdld.Chucdanh_id = db0.nvQTLamViec.Where(sy => sy.NV_id == NV_id).FirstOrDefault().ChucDanhChucVu_id;

                                hdcthdld.SoHD = dReader.GetValue(2).ToString();
                                hdcthdld.LoaiHD = dReader.GetValue(3).ToString();
                                string THHD = dReader.GetValue(4).ToString();
                                int ThoiHanHD_id = db.dmThoiHanHD.Where(th => th.tenThoiHanHD == THHD).FirstOrDefault().id;
                                hdcthdld.ThoihanHD_id = ThoiHanHD_id;
                                hdcthdld.NgayHL = DateTime.Parse(dReader.GetValue(5).ToString());
                                try
                                {
                                    hdcthdld.NgayhetHL = DateTime.Parse(dReader.GetValue(6).ToString());
                                }
                                catch { }
                                hdcthdld.Congviec = dReader.GetValue(7).ToString();
                                string TGLV = dReader.GetValue(8).ToString();
                                int ThoiGioLV_id = db.dmThoiGioLamViec.Where(th => th.tenThoiGioLamViec == TGLV).FirstOrDefault().id;
                                hdcthdld.ThoigioLV_id = ThoiGioLV_id;
                                if (dReader.GetValue(9).ToString().Count() > 0)
                                {
                                    hdcthdld.BHXH = true;
                                }
                                else
                                {
                                    hdcthdld.BHXH = false;
                                }
                                hdcthdld.Mucluongchinh = dReader.GetValue(10).ToString();
                                try
                                {
                                    hdcthdld.Tyleluong = int.Parse(dReader.GetValue(11).ToString());
                                }
                                catch { }
                                var Nhom = dReader.GetValue(15).ToString();
                                var Ngach = dReader.GetValue(14).ToString();
                                var Bac = dReader.GetValue(13).ToString();
                                var HSLuong = dReader.GetValue(12).ToString();
                                int? Nhom_id = db0.dmNhomNgachVienChuc.Where(nn => nn.tenNhomNgachVienChuc == Nhom || nn.maNhomNgachVienChuc == Nhom).FirstOrDefault().id;
                                int? Ngach_id = db0.dmNgachVienChuc.Where(n => n.tenNgachVienChuc == Ngach).FirstOrDefault().id;
                                int? Bac_id = db0.dmBangLuong.Where(bl => bl.idNhomNgach == Nhom_id && bl.bacLuong == Bac).FirstOrDefault().id;

                                hdcthdld.HSLuong_id = Bac_id;
                                hdcthdld.Bac_id = Bac_id;
                                hdcthdld.Ngach_id = Ngach_id;
                                hdcthdld.Nhom_id = Nhom_id;
                                hdcthdld.Bangluong_id = dReader.GetValue(16).ToString();
                                try
                                {
                                    hdcthdld.QT_NgayNLDky = DateTime.Parse(dReader.GetValue(17).ToString());
                                }
                                catch
                                {
                                    hdcthdld.QT_NLDky = dReader.GetValue(17).ToString();
                                }
                                try
                                {
                                    hdcthdld.QT_NgayTrinhHT = DateTime.Parse(dReader.GetValue(18).ToString());
                                }
                                catch
                                {
                                    hdcthdld.QT_TrinhHT = dReader.GetValue(18).ToString();
                                }
                                try
                                {
                                    hdcthdld.QT_NgayHTky = DateTime.Parse(dReader.GetValue(19).ToString());
                                }
                                catch
                                {
                                    hdcthdld.QT_HTky = dReader.GetValue(19).ToString();
                                }
                                try
                                {
                                    hdcthdld.QT_NgayLuuHS = DateTime.Parse(dReader.GetValue(20).ToString());
                                }
                                catch
                                {
                                    hdcthdld.QT_LuuHS = dReader.GetValue(20).ToString();
                                }
                                try
                                {
                                    hdcthdld.QT_NgayTraNLD = DateTime.Parse(dReader.GetValue(21).ToString());
                                }
                                catch
                                {
                                    hdcthdld.QT_TraNLD = dReader.GetValue(21).ToString();
                                }
                                db.hdChiTietHDLD.Add(hdcthdld);
                                db.SaveChanges();
                                count += 1;
                                hdnldidDatao = 0;
                            }
                            catch
                            {
                                if (hdnldidDatao != 0)
                                {
                                    var hdnld = db.hdNLD.Where(ld => ld.id == hdnldidDatao).FirstOrDefault();
                                    db.hdNLD.Remove(hdnld);
                                    db.SaveChanges();
                                }
                            }
                        }
                    }
                    catch { }
                }
                TempData["Message_NhapDuLieu"] = "Bạn đã import thành công " + count + "/" + (total-1) + " hợp đồng!";
                excelConnection.Close();
            }
            return RedirectToAction("Index", "HDNguoiLaoDong");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}