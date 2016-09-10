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
    public class HDNguoiLaoDongController : Controller
    {
        private HRMDB2Entities db = new HRMDB2Entities();
        private HRMDB0Entities db0 = new HRMDB0Entities();
        //
        // GET: /HDNguoiLaoDong/

        public ActionResult Index()
        {
            int count = 0;
            foreach (var item in db.hdNLD.ToList()){
                if (item.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().NgayhetHL != null)
                {
                    System.TimeSpan diffDate = (DateTime)item.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().NgayhetHL - DateTime.Today;
                    if ((diffDate.Days <= db.hdCauHinh.FirstOrDefault().NgayHDTV && item.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().LoaiHD == "Thử việc") || (diffDate.Days <= db.hdCauHinh.FirstOrDefault().NgayHDCT && item.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().LoaiHD == "Hợp đồng dài hạn") || (diffDate.Days <= db.hdCauHinh.FirstOrDefault().NgayHDCT && item.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().LoaiHD == "Hợp đồng cơ hữu"))
                    {
                        if (diffDate.Days > 0)
                        {
                            count = count + 1;
                        }
                        if (diffDate.Days <= 0)
                        {
                            if (item.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().LoaiHD != "Thử việc")
                            {
                                if (db.hdCanTaoHDLD.Count() <= 0)
                                {
                                    var hdcantao = new hdCanTaoHDLD();
                                    hdcantao.Hoten = item.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().HotenNLD;
                                    hdcantao.GioiTinh_id = item.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().Gioitinh_id;
                                    hdcantao.Quoctich_id = item.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().Quoctich_id;
                                    hdcantao.Ngaysinh = item.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().Ngaysinh;
                                    hdcantao.Noisinh = item.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().Noisinh;
                                    hdcantao.Nghenghiep_id = item.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().Nghenghiep_id;
                                    hdcantao.Diachithuongtru = item.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().Diachithuongtru;
                                    hdcantao.soCMND = item.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().soCMND;
                                    hdcantao.cmndNgaycap = item.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().cmndNgaycap;
                                    hdcantao.cmndNoicap = item.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().cmndNoicap;
                                    hdcantao.VitriCT_id = item.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().Chucdanh_id;
                                    if (item.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().LoaiHD == "Hợp đồng dài hạn")
                                    {
                                        hdcantao.Lydo = "Hợp đồng dài hạn hết hạn";
                                    }
                                    if (item.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().LoaiHD == "Hợp đồng cơ hữu")
                                    {
                                        hdcantao.Lydo = "Hợp đồng cơ hữu hết hạn";
                                    }
                                    hdcantao.Donvi_id = item.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().Donvi_id;
                                    hdcantao.MaNV = item.NV_id;
                                    hdcantao.MaTD = item.TD_id;

                                    db.hdCanTaoHDLD.Add(hdcantao);
                                    db.SaveChanges();
                                }
                                else
                                {
                                    bool isHas = false;
                                    foreach (var it in db.hdCanTaoHDLD.ToList())
                                    {
                                        if (it.MaNV != null)
                                        {
                                            if (item.NV_id == it.MaNV)
                                            {
                                                isHas = true;
                                            }
                                        }
                                        if (it.MaTD != null)
                                        {
                                            if (item.TD_id == it.MaTD)
                                            {
                                                isHas = true;
                                            }
                                        }
                                    }
                                    if (isHas == false)
                                    {
                                        var hdcantao = new hdCanTaoHDLD();
                                        hdcantao.Hoten = item.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().HotenNLD;
                                        hdcantao.GioiTinh_id = item.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().Gioitinh_id;
                                        hdcantao.Quoctich_id = item.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().Quoctich_id;
                                        hdcantao.Ngaysinh = item.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().Ngaysinh;
                                        hdcantao.Noisinh = item.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().Noisinh;
                                        hdcantao.Nghenghiep_id = item.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().Nghenghiep_id;
                                        hdcantao.Diachithuongtru = item.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().Diachithuongtru;
                                        hdcantao.soCMND = item.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().soCMND;
                                        hdcantao.cmndNgaycap = item.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().cmndNgaycap;
                                        hdcantao.cmndNoicap = item.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().cmndNoicap;
                                        hdcantao.VitriCT_id = item.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().Chucdanh_id;
                                        if (item.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().LoaiHD == "Hợp đồng dài hạn")
                                        {
                                            hdcantao.Lydo = "Hợp đồng dài hạn hết hạn";
                                        }
                                        if (item.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().LoaiHD == "Hợp đồng cơ hữu")
                                        {
                                            hdcantao.Lydo = "Hợp đồng cơ hữu hết hạn";
                                        }
                                        hdcantao.Donvi_id = item.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().Donvi_id;
                                        hdcantao.MaNV = item.NV_id;
                                        hdcantao.MaTD = item.TD_id;

                                        db.hdCanTaoHDLD.Add(hdcantao);
                                        db.SaveChanges();
                                    }
                                }
                            }
                        }
                    } 
                }
            }
            if (db.hdCanTaoHDLD.Count() > 0)
            {
                TempData["MessageNLDCT"] = db.hdCanTaoHDLD.Count();
            }
            if (count > 0)
            {
                TempData["MessageHDHH"] = count;
            }

            //check nghi viec
            var listNVNghiViec = new List<string>();
            foreach (var item in db0.NhanVien.ToList())
            {
                if (item.ngayNghiViec != null)
                {
                    listNVNghiViec.Add(item.MaNV);
                }
            }
            foreach (var item in db.hdNLD.ToList())
            {
                for (int i = 0; i < listNVNghiViec.Count; i++)
                {
                    if (item.NV_id == listNVNghiViec[i])
                    {
                        var hdnld = new hdNLD();
                        hdnld.id = item.id;
                        hdnld.NV_id = item.NV_id;
                        hdnld.TD_id = item.TD_id;
                        hdnld.hidden = true;
                        db.Entry(item).CurrentValues.SetValues(hdnld);
                        db.SaveChanges();
                    }
                }
            }
            //check nhan vien moi
            if (db0.dsNhanVienMoi.ToList().Count > 0)
            {
                var listnvmoi_id = new List<int>();
                foreach (var item in db0.dsNhanVienMoi.ToList())
                {
                    if (String.IsNullOrEmpty(item.HoVaTen))
                        continue;

                    var hdnldct = new hdCanTaoHDLD();

                    hdnldct.MaNV = item.MaNV;
                    hdnldct.MaTD = item.MaTV;
                    hdnldct.Hoten = item.HoVaTen ?? "";
                    hdnldct.GioiTinh_id = item.GioiTinh_id;
                    hdnldct.Quoctich_id = item.QuocTich_id;
                    hdnldct.Ngaysinh = item.NgaySinh;
                    hdnldct.Noisinh = item.NoiSinh_tenTinhThanh;
                    if (item.DiaChi_tenPhuongXa != null)
                    {
                        hdnldct.Diachithuongtru = item.DiaChi_tenPhuongXa;
                    }
                    if (item.DiaChi_tenQuanHuyen != null)
                    {
                        hdnldct.Diachithuongtru = hdnldct.Diachithuongtru + ", " + item.DiaChi_tenQuanHuyen;
                    }
                    if (item.DiaChi_tenTinhThanh != null)
                    {
                        hdnldct.Diachithuongtru = hdnldct.Diachithuongtru + ", " + item.DiaChi_tenTinhThanh;
                    }
                    hdnldct.soCMND = item.CMND_SoThe;
                    hdnldct.cmndNgaycap = item.CMND_NgayCap;
                    hdnldct.cmndNoicap = item.CMND_NoiCap_id;
                    hdnldct.VitriCT_id = item.ChucDanhChucVu_id;
                    hdnldct.Donvi_id = item.DonVi_id;
                    hdnldct.Nghenghiep_id = item.NgheNghiep_id;
                    hdnldct.Lydo = "Nhân viên mới";
                    db.hdCanTaoHDLD.Add(hdnldct);
                    db.SaveChanges();
                    HRM.Services.QLTTNhanSu.ketThucNhanVienMoi(new int[]{item.nid});
                }   
            }
            var aaaa = db.hdNLD.Where(ld => ld.hidden == false).ToList();
            return View(db.hdNLD.Where(ld => ld.hidden == false).ToList());
        }

        public void XemTatCa(string value = "")
        {
            TempData["XemTatCa"] = value;
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}