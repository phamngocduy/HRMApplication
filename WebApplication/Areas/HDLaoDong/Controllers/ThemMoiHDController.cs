using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRM.Databases_HDLaoDong.Models;
using HRM.Databases.Models;
using System.IO;
using System.Web.UI;
using System.Data.Objects;

namespace HRM.HDLaoDong.Controllers
{
    public class ThemMoiHDController : Controller
    {
        private HRMDB2Entities db = new HRMDB2Entities();
        private HRMDB0Entities db0 = new HRMDB0Entities();
        // chose calatory type of contract
        public ActionResult Create_ChonLoaiHD(int DSNLDCanTaoHD_id, int? loaiHopDong)
        {
            ViewBag.DSNLDCanTaoHD_id = DSNLDCanTaoHD_id;
            if (!loaiHopDong.HasValue) return View();
            var mauHopDong = Request.Form["MauHopDong"];
            if (String.IsNullOrEmpty(mauHopDong)) return View();
            Session["MauHopDong"] = mauHopDong;
            var LoaiHopDong = db.dmLoaiHopDong.Find(loaiHopDong);
            if (LoaiHopDong.maLoaiHD.Contains("HĐCH"))
            {
                return RedirectToAction("Create_HDCoHuu", "ThemMoiHD", new { DSNLDCanTaoHD_id = DSNLDCanTaoHD_id, LoaiHD_id = loaiHopDong });
            }
            if (LoaiHopDong.maLoaiHD.Contains("HĐTV"))
            {
                return RedirectToAction("Create_HDThuViec", "ThemMoiHD", new { DSNLDCanTaoHD_id = DSNLDCanTaoHD_id, LoaiHD_id = loaiHopDong });
            }
            if (LoaiHopDong.maLoaiHD.Contains("HĐDH"))
            {
                return RedirectToAction("Create_HDDaiHan", "ThemMoiHD", new { DSNLDCanTaoHD_id = DSNLDCanTaoHD_id, LoaiHD_id = loaiHopDong });
            }
            return View();
        }
        public ActionResult TruyenID(int DSNLDCanTaoHD_id)
        {
            return RedirectToAction("Create_ChonLoaiHD", "ThemMoiHD", new { DSNLDCanTaoHD_id = DSNLDCanTaoHD_id });
        }

        // create exeption
        // POST: /

        public ActionResult Create_Exeption(int NLD_id)
        {
            var hdNLD = db.hdNLD.Where(nl => nl.id == NLD_id).FirstOrDefault();
            var hdcantao = new hdCanTaoHDLD();
            hdcantao.Hoten = hdNLD.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().HotenNLD;
            hdcantao.GioiTinh_id = hdNLD.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().Gioitinh_id;
            hdcantao.Quoctich_id = hdNLD.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().Quoctich_id;
            hdcantao.Ngaysinh = hdNLD.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().Ngaysinh;
            hdcantao.Noisinh = hdNLD.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().Noisinh;
            hdcantao.Nghenghiep_id = hdNLD.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().Nghenghiep_id;
            hdcantao.Diachithuongtru = hdNLD.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().Diachithuongtru;
            hdcantao.soCMND = hdNLD.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().soCMND;
            hdcantao.cmndNgaycap = hdNLD.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().cmndNgaycap;
            hdcantao.cmndNoicap = hdNLD.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().cmndNoicap;
            hdcantao.VitriCT_id = hdNLD.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().Chucdanh_id;
            hdcantao.Lydo = "Trường hợp ngoại lệ";
            hdcantao.Donvi_id = hdNLD.hdChiTietHDLDs.OrderByDescending(ct => ct.NgayhetHL).FirstOrDefault().Donvi_id;
            hdcantao.MaNV = hdNLD.NV_id;
            hdcantao.MaTD = hdNLD.TD_id;

            db.hdCanTaoHDLD.Add(hdcantao);
            db.SaveChanges();

            return RedirectToAction("TruyenID", "ThemMoiHD", new { DSNLDCanTaoHD_id = hdcantao.id });
        }

        //hd thu viec
        // GET: /ThemMoiHD/Create

        public ActionResult Create_HDThuViec(int DSNLDCanTaoHD_id, int LoaiHD_id)
        {
            ViewBag.DSNLDCanTaoHD_id = DSNLDCanTaoHD_id;
            return View(new hdChiTietHDLD { LoaiHD_id = LoaiHD_id });
        }

        //hd thu viec
        // POST: /ThemMoiHD/Create

        [HttpPost]
        public ActionResult Create_HDThuViec(hdChiTietHDLD hdchitiethdld, hdNLD hdnld, int DSNLDCanTaoHD_id)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.DSNLDCanTaoHD_id = DSNLDCanTaoHD_id;
                TempData["Message_CreateHDThuViec"] = ModelState.Values.First(v => v.Errors.Count > 0).Errors[0].ErrorMessage;
                return View(hdchitiethdld);
            }
            UpdatehdChiTietHDLD(hdchitiethdld);
            var DSNLDCanTaoHD = (hdCanTaoHDLD)TempData["DSNLDCanTaoHD"];
            ViewBag.DSNLDCanTaoHD_id = DSNLDCanTaoHD_id;
            if (ModelState.IsValid)
            {
                if (DSNLDCanTaoHD.MaNV == null && DSNLDCanTaoHD.MaTD != null)
                {
                    hdnld.TD_id = DSNLDCanTaoHD.MaTD;
                    hdnld.hidden = false;
                    db.hdNLD.Add(hdnld);
                    db.SaveChanges();
                    hdchitiethdld.NLD_id = hdnld.id;
                    db.hdChiTietHDLD.Add(hdchitiethdld);    
                    db.SaveChanges();
                    var dsnldcantaohd = db.hdCanTaoHDLD.Where(ct => ct.id == DSNLDCanTaoHD.id).First();
                    db.hdCanTaoHDLD.Remove(dsnldcantaohd);
                    db.SaveChanges();
                    // chuyen sang quan ly thu viec
                    if (hdchitiethdld.QT_NgayNLDky != null && hdchitiethdld.QT_NgayTrinhHT != null && hdchitiethdld.QT_NgayHTky != null)
                    {
                        var nld = db.hdNLD.Where(ld => ld.id == hdchitiethdld.NLD_id).FirstOrDefault();
                        HRM.Services.QLTTNhanSu.themQuanLyThuViec(nld.TD_id, hdchitiethdld.HotenNLD, hdchitiethdld.NgayHL, hdchitiethdld.Donvi_id, null);
                    }
                }
                String PrintAndSave = "";
                if (Request.Form["PrintAndSave"] != null)
                {
                    PrintAndSave = "PrintAndSave";
                }
                TempData["Message_EditHDThuViec"] = "Thêm mới thành công!";
                return RedirectToAction("Edit_HDThuViec", "ThemMoiHD", new { id = hdchitiethdld.id, Print_yes_no = PrintAndSave});
            }
            TempData["Message_CreateHDThuViec"] = "Thêm mới thất bại!";
            return View(hdchitiethdld);
        }

        //hd co huu
        // GET: /ThemMoiHD/Create
        public ActionResult Create_HDCoHuu(int DSNLDCanTaoHD_id, int LoaiHD_id)
        {
            ViewBag.DSNLDCanTaoHD_id = DSNLDCanTaoHD_id;
            return View(new hdChiTietHDLD { LoaiHD_id = LoaiHD_id });
        }

        //hd co huu
        // POST: /ThemMoiHD/Create

        [HttpPost]
        public ActionResult Create_HDCoHuu(hdChiTietHDLD hdchitiethdld, hdNLD hdnld, int DSNLDCanTaoHD_id)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.DSNLDCanTaoHD_id = DSNLDCanTaoHD_id;
                TempData["Message_CreateHDCoHuu"] = ModelState.Values.First(v => v.Errors.Count > 0).Errors[0].ErrorMessage;
                return View(hdchitiethdld);
            }
            UpdatehdChiTietHDLD(hdchitiethdld);
            var DSNLDCanTaoHD = (hdCanTaoHDLD)TempData["DSNLDCanTaoHD"];
            ViewBag.DSNLDCanTaoHD_id = DSNLDCanTaoHD_id;
            DSNLDCanTaoHD = DSNLDCanTaoHD ?? db.hdCanTaoHDLD.Find(DSNLDCanTaoHD_id);
            if (hdchitiethdld.HotenNLD != null && hdchitiethdld.Gioitinh_id !=null && hdchitiethdld.Donvi_id !=null && hdchitiethdld.Chucdanh_id !=null && hdchitiethdld.SoHD !=null && hdchitiethdld.LoaiHD !=null && hdchitiethdld.ThoihanHD_id !=null && hdchitiethdld.NgayHL !=null && hdchitiethdld.ThoigioLV_id !=null && hdchitiethdld.Mucluongchinh !=null)
            {
                // is had matd and manv 
                if (DSNLDCanTaoHD.MaNV != null && DSNLDCanTaoHD.MaTD != null)
                {
                    int nld_id = 0;
                    foreach (var item in db.hdNLD)
                    {
                        if (item.TD_id == DSNLDCanTaoHD.MaTD)
                        {
                            nld_id = item.id;
                            break;
                        }
                    }
                    if (nld_id == 0)
                        foreach (var item in db.hdNLD)
                            if (item.NV_id == DSNLDCanTaoHD.MaNV)
                            {
                                nld_id = item.id;
                                break;
                            }
                    var nld = db.hdNLD.Where(ld => ld.id == nld_id).First();
                    hdnld.id = nld_id;
                    hdnld.TD_id = nld.TD_id;
                    hdnld.NV_id = DSNLDCanTaoHD.MaNV;
                    hdnld.hidden = false;
                    db.Entry(nld).CurrentValues.SetValues(hdnld);
                    db.SaveChanges();
                    hdchitiethdld.NLD_id = hdnld.id;
                    db.hdChiTietHDLD.Add(hdchitiethdld);
                    db.SaveChanges();
                    var dsnldcantaohd = db.hdCanTaoHDLD.Where(ct => ct.id == DSNLDCanTaoHD.id).First();
                    db.hdCanTaoHDLD.Remove(dsnldcantaohd);
                    db.SaveChanges();
                }
                // isn't had matd with giang vien
                else if (DSNLDCanTaoHD.MaNV != null && DSNLDCanTaoHD.MaTD == null)
                {
                    bool isHad = false;
                    int nv_id = 0;
                    foreach (var item in db.hdNLD)
                    {
                        if (item.NV_id == DSNLDCanTaoHD.MaNV)
                        {
                            isHad = true;
                            nv_id = item.id;
                            break;
                        }
                    }
                    if (isHad == true)
                    {
                        var nld = db.hdNLD.Where(ld => ld.id == nv_id).First();
                        hdnld.id = nv_id;
                        hdnld.TD_id = nld.TD_id;
                        hdnld.NV_id = DSNLDCanTaoHD.MaNV;
                        hdnld.hidden = false;
                        db.Entry(nld).CurrentValues.SetValues(hdnld);
                        db.SaveChanges();
                        hdchitiethdld.NLD_id = hdnld.id;
                        db.hdChiTietHDLD.Add(hdchitiethdld);
                        db.SaveChanges();
                        var dsnldcantaohd = db.hdCanTaoHDLD.Where(ct => ct.id == DSNLDCanTaoHD.id).First();
                        db.hdCanTaoHDLD.Remove(dsnldcantaohd);
                        db.SaveChanges();
                    }
                    else
                    {
                        hdnld.NV_id = DSNLDCanTaoHD.MaNV;
                        hdnld.hidden = false;
                        db.hdNLD.Add(hdnld);
                        db.SaveChanges();
                        hdchitiethdld.NLD_id = hdnld.id;
                        db.hdChiTietHDLD.Add(hdchitiethdld);
                        db.SaveChanges();
                        var dsnldcantaohd = db.hdCanTaoHDLD.Where(ct => ct.id == DSNLDCanTaoHD.id).First();
                        db.hdCanTaoHDLD.Remove(dsnldcantaohd);
                        db.SaveChanges();
                    }

                }
                TempData["Object"] = "DSNLDCanTaoHD";
                String PrintAndSave = "";
                if(Request.Form["PrintAndSave"] != null){
                    PrintAndSave = "PrintAndSave";
                }
                TempData["Message_EditHDCoHuu"] = "Thêm mới thành công!";
                return RedirectToAction("Edit_HDCoHuu", "ThemMoiHD", new { id = hdchitiethdld.id, Print_yes_no = PrintAndSave });
            }
            TempData["Message_CreateHDCoHuu"] = "Thêm mới thất bại!";
            return View(hdchitiethdld);
        }

        //hd dai han
        // POST: /ThemMoiHD/Create
        public ActionResult Create_HDDaiHan(int DSNLDCanTaoHD_id, int LoaiHD_id)
        {
            ViewBag.DSNLDCanTaoHD_id = DSNLDCanTaoHD_id;
            return View(new hdChiTietHDLD { LoaiHD_id = LoaiHD_id });
        }

        //hd dai han
        // POST: /ThemMoiHD/Create

        [HttpPost]
        public ActionResult Create_HDDaiHan(hdChiTietHDLD hdchitiethdld, hdNLD hdnld, int DSNLDCanTaoHD_id)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.DSNLDCanTaoHD_id = DSNLDCanTaoHD_id;
                TempData["Message_CreateHDDaiHan"] = ModelState.Values.First(v => v.Errors.Count > 0).Errors[0].ErrorMessage;
                return View(hdchitiethdld);
            }
            UpdatehdChiTietHDLD(hdchitiethdld);
            var DSNLDCanTaoHD = (hdCanTaoHDLD)TempData["DSNLDCanTaoHD"];
            ViewBag.DSNLDCanTaoHD_id = DSNLDCanTaoHD_id;
            DSNLDCanTaoHD = DSNLDCanTaoHD ?? db.hdCanTaoHDLD.Find(DSNLDCanTaoHD_id);
            if (hdchitiethdld.HotenNLD != null && hdchitiethdld.Gioitinh_id != null && hdchitiethdld.Donvi_id != null && hdchitiethdld.Chucdanh_id != null && hdchitiethdld.SoHD != null && hdchitiethdld.LoaiHD != null && hdchitiethdld.ThoihanHD_id != null && hdchitiethdld.NgayHL != null && hdchitiethdld.ThoigioLV_id != null && hdchitiethdld.Mucluongchinh != null)
            {
                // is had matd and manv 
                if (DSNLDCanTaoHD.MaNV != null && DSNLDCanTaoHD.MaTD != null)
                {
                    int nld_id = 0;
                    foreach (var item in db.hdNLD)
                    {
                        if (item.TD_id == DSNLDCanTaoHD.MaTD)
                        {
                            nld_id = item.id;
                            break;
                        }
                    }
                    if (nld_id == 0)
                        foreach (var item in db.hdNLD)
                            if (item.NV_id == DSNLDCanTaoHD.MaNV)
                            {
                                nld_id = item.id;
                                break;
                            }
                    var nld = db.hdNLD.Where(ld => ld.id == nld_id).First();
                    hdnld.id = nld_id;
                    hdnld.TD_id = nld.TD_id;
                    hdnld.NV_id = DSNLDCanTaoHD.MaNV;
                    hdnld.hidden = false;
                    db.Entry(nld).CurrentValues.SetValues(hdnld);
                    db.SaveChanges();
                    hdchitiethdld.NLD_id = hdnld.id;
                    db.hdChiTietHDLD.Add(hdchitiethdld);
                    db.SaveChanges();
                    var dsnldcantaohd = db.hdCanTaoHDLD.Where(ct => ct.id == DSNLDCanTaoHD.id).First();
                    db.hdCanTaoHDLD.Remove(dsnldcantaohd);
                    db.SaveChanges();
                }
                // isn't had matd with giang vien
                else if (DSNLDCanTaoHD.MaNV != null && DSNLDCanTaoHD.MaTD == null)
                {
                    bool isHad = false;
                    int nv_id = 0;
                    foreach (var item in db.hdNLD)
                    {
                        if (item.NV_id == DSNLDCanTaoHD.MaNV)
                        {
                            isHad = true;
                            nv_id = item.id;
                            break;
                        }
                    }
                    if (isHad == true)
                    {
                        if (hdchitiethdld.BHXH == null)
                        {
                            hdchitiethdld.BHXH = false;
                        }
                        var nld = db.hdNLD.Where(ld => ld.id == nv_id).First();
                        hdnld.id = nv_id;
                        hdnld.TD_id = nld.TD_id;
                        hdnld.NV_id = DSNLDCanTaoHD.MaNV;
                        hdnld.hidden = false;
                        db.Entry(nld).CurrentValues.SetValues(hdnld);
                        db.SaveChanges();
                        hdchitiethdld.NLD_id = hdnld.id;
                        db.hdChiTietHDLD.Add(hdchitiethdld);
                        db.SaveChanges();
                        var dsnldcantaohd = db.hdCanTaoHDLD.Where(ct => ct.id == DSNLDCanTaoHD.id).First();
                        db.hdCanTaoHDLD.Remove(dsnldcantaohd);
                        db.SaveChanges();
                    }
                    else
                    {
                        if (hdchitiethdld.BHXH == null)
                        {
                            hdchitiethdld.BHXH = false;
                        }
                        hdnld.NV_id = DSNLDCanTaoHD.MaNV;
                        hdnld.hidden = false;
                        db.hdNLD.Add(hdnld);
                        db.SaveChanges();
                        hdchitiethdld.NLD_id = hdnld.id;
                        db.hdChiTietHDLD.Add(hdchitiethdld);
                        db.SaveChanges();
                        var dsnldcantaohd = db.hdCanTaoHDLD.Where(ct => ct.id == DSNLDCanTaoHD.id).First();
                        db.hdCanTaoHDLD.Remove(dsnldcantaohd);
                        db.SaveChanges();
                    }

                }
                TempData["Object"] = "DSNLDCanTaoHD";
                String PrintAndSave = "";
                if (Request.Form["PrintAndSave"] != null)
                {
                    PrintAndSave = "PrintAndSave";
                }
                TempData["Message_EditHDDaiHan"] = "Thêm mới thành công!";
                return RedirectToAction("Edit_HDDaiHan", "ThemMoiHD", new { id = hdchitiethdld.id, Print_yes_no = PrintAndSave });
            }
            TempData["Message_CreateHDDaiHan"] = "Thêm mới thất bại!";
            return View(hdchitiethdld);
        }

        //edit hd thu viec
        // GET: /ThemMoiHD/Edit/5

        public ActionResult Edit_HDThuViec(int id = 0)
        {
            hdChiTietHDLD hdchitiethdld = db.hdChiTietHDLD.Where(ct => ct.id == id).FirstOrDefault();
            if (hdchitiethdld == null)
            {
                return HttpNotFound();
            }
            return View(hdchitiethdld);
        }

        //
        // POST: /ThemMoiHD/Edit/5

        [HttpPost]
        public ActionResult Edit_HDThuViec(hdChiTietHDLD hdchitiethdld)
        {
            UpdatehdChiTietHDLD(hdchitiethdld);
            var old = db.hdChiTietHDLD.Where(ct => ct.id == hdchitiethdld.id).First();
            if (Request.Form["BHXH.Value"] == "true,false")
            {
                hdchitiethdld.BHXH = true;
            }
            else
            {
                hdchitiethdld.BHXH = false;
            }
            if ((old.QT_NgayNLDky != null && old.QT_NgayTrinhHT != null && old.QT_NgayHTky != null) || (old.QT_NLDky != null && old.QT_TrinhHT != null && old.QT_HTky != null))
                {
                    AssignhdChiTietHDLD(hdchitiethdld, old);
                    hdchitiethdld.HotenNLD = old.HotenNLD;
                    hdchitiethdld.Gioitinh_id = old.Gioitinh_id;
                    hdchitiethdld.Donvi_id = old.Donvi_id;
                    hdchitiethdld.SoHD = old.SoHD;
                    hdchitiethdld.ThoihanHD_id = old.ThoihanHD_id;
                    hdchitiethdld.NgayHL = old.NgayHL;
                    hdchitiethdld.NgayhetHL = old.NgayhetHL;
                    hdchitiethdld.Chucdanh_id = old.Chucdanh_id;
                    hdchitiethdld.Chucvu_id = old.Chucvu_id;
                    hdchitiethdld.ChucvutruongDV = old.ChucvutruongDV;
                    hdchitiethdld.Congviec = old.Congviec;
                    hdchitiethdld.ThoigioLV_id = old.ThoigioLV_id;
                    hdchitiethdld.Mucluongchinh = old.Mucluongchinh;
                    hdchitiethdld.Tyleluong = old.Tyleluong;
                    hdchitiethdld.HSLuong_id = old.HSLuong_id;
                    hdchitiethdld.Bac_id = old.Bac_id;
                    hdchitiethdld.Ngach_id = old.Ngach_id;
                    hdchitiethdld.Nhom_id = old.Nhom_id;
                    hdchitiethdld.Bangluong_id = old.Bangluong_id;
                    hdchitiethdld.QT_NgayNLDky = old.QT_NgayNLDky;
                    hdchitiethdld.QT_NgayTrinhHT = old.QT_NgayTrinhHT;
                    hdchitiethdld.QT_NgayHTky = old.QT_NgayHTky;
                    hdchitiethdld.QT_NLDky = old.QT_NLDky;
                    hdchitiethdld.QT_TrinhHT = old.QT_TrinhHT;
                    hdchitiethdld.QT_HTky = old.QT_HTky;
                    hdchitiethdld.QT_TraNLD = old.QT_TraNLD;
                    hdchitiethdld.QT_LuuHS = old.QT_LuuHS;
            }
            if (ModelState.IsValid)
            {
                hdchitiethdld.NLD_id = old.NLD_id;
                if (hdchitiethdld.NgayhetHL == null)
                {
                    hdchitiethdld.NgayhetHL = old.NgayhetHL;
                }

                db.Entry(old).CurrentValues.SetValues(hdchitiethdld);
                db.SaveChanges();
                // chuyen sang quan ly thu viec
                if (hdchitiethdld.QT_NgayNLDky != null && hdchitiethdld.QT_NgayTrinhHT != null && hdchitiethdld.QT_NgayHTky != null)
                {
                    var nld = db.hdNLD.Where(ld => ld.id == hdchitiethdld.NLD_id).FirstOrDefault();
                    bool isHadTV = false;
                    foreach (var item in db0.nvQLThuViec.ToList())
                    {
                        if (item.maThuViec == nld.TD_id)
                        {
                            isHadTV = true;
                        }
                    }
                    if (isHadTV == false)
                    {
                        HRM.Services.QLTTNhanSu.themQuanLyThuViec(nld.TD_id, hdchitiethdld.HotenNLD, hdchitiethdld.NgayHL, hdchitiethdld.Donvi_id, null);
                    }
                }
                //print
                if (Request.Form["PrintAndSave"] != null)
                {
                    return RedirectToAction("Details_TV", "CreateWordHD", new { id = hdchitiethdld.id, Back = "Edit_HDThuViec" });
                }
                TempData["Message_EditHDThuViec"] = "Cập nhật thành công!";
                return RedirectToAction("Edit_HDThuViec", "ThemMoiHD", new { id = hdchitiethdld.id});
            }
            else if (hdchitiethdld.SoHD != null && hdchitiethdld.Donvi_id != null && hdchitiethdld.HotenNLD != null && hdchitiethdld.ThoihanHD_id != 0 && hdchitiethdld.NgayHL != null && hdchitiethdld.ThoigioLV_id != 0 && hdchitiethdld.Mucluongchinh != null)
            {
                hdchitiethdld.NLD_id = old.NLD_id;
                if (hdchitiethdld.NgayhetHL == null)
                {
                    hdchitiethdld.NgayhetHL = old.NgayhetHL;
                }

                db.Entry(old).CurrentValues.SetValues(hdchitiethdld);
                db.SaveChanges();
                // chuyen sang quan ly thu viec
                if (hdchitiethdld.QT_NgayNLDky != null && hdchitiethdld.QT_NgayTrinhHT != null && hdchitiethdld.QT_NgayHTky != null)
                {
                    var nld = db.hdNLD.Where(ld => ld.id == hdchitiethdld.NLD_id).FirstOrDefault();
                    bool isHadTV = false;
                    foreach (var item in db0.nvQLThuViec.ToList())
                    {
                        if (item.maThuViec == nld.TD_id)
                        {
                            isHadTV = true;
                        }
                    }
                    if (isHadTV == false)
                    {
                        HRM.Services.QLTTNhanSu.themQuanLyThuViec(nld.TD_id, hdchitiethdld.HotenNLD, hdchitiethdld.NgayHL, hdchitiethdld.Donvi_id, null);
                    }
                }
                // print 
                if (Request.Form["PrintAndSave"] != null)
                {
                    return RedirectToAction("Details_TV", "CreateWordHD", new { id = hdchitiethdld.id, Back = "Edit_HDThuViec" });
                }
                TempData["Message_EditHDThuViec"] = "Cập nhật thành công!";
                return RedirectToAction("Edit_HDThuViec", "ThemMoiHD", new { id = hdchitiethdld.id});
            }
            TempData["Message_EditHDThuViec"] = "Cập nhật thất bại!";
            return View(hdchitiethdld);
        }

        //
        // GET: /ThemMoiHD/Edit/5

        public ActionResult Edit_HDCoHuu(int id = 0)
        {
            hdChiTietHDLD hdchitiethdld = db.hdChiTietHDLD.Where(ct => ct.id == id).FirstOrDefault();
            if (hdchitiethdld == null)
            {
                return HttpNotFound();
            }
            return View(hdchitiethdld);
        }

        //
        // POST: /ThemMoiHD/Edit/5

        [HttpPost]
        public ActionResult Edit_HDCoHuu(hdChiTietHDLD hdchitiethdld)
        {
            UpdatehdChiTietHDLD(hdchitiethdld);
            var old = db.hdChiTietHDLD.Where(ct => ct.id == hdchitiethdld.id).First();
            if (Request.Form["BHXH.Value"] == "true,false")
            {
                hdchitiethdld.BHXH = true;
            }
            else
            {
                hdchitiethdld.BHXH = false;
            }
            if ((old.QT_NgayNLDky != null && old.QT_NgayTrinhHT != null && old.QT_NgayHTky != null) || (old.QT_NLDky != null && old.QT_TrinhHT != null && old.QT_HTky != null))
            {
                AssignhdChiTietHDLD(hdchitiethdld, old);
                hdchitiethdld.HotenNLD = old.HotenNLD;
                hdchitiethdld.Gioitinh_id = old.Gioitinh_id;
                hdchitiethdld.Donvi_id = old.Donvi_id;
                hdchitiethdld.SoHD = old.SoHD;
                hdchitiethdld.ThoihanHD_id = old.ThoihanHD_id;
                hdchitiethdld.NgayHL = old.NgayHL;
                hdchitiethdld.NgayhetHL = old.NgayhetHL;
                hdchitiethdld.Chucdanh_id = old.Chucdanh_id;
                hdchitiethdld.Chucvu_id = old.Chucvu_id;
                hdchitiethdld.ChucvutruongDV = old.ChucvutruongDV;
                hdchitiethdld.Congviec = old.Congviec;
                hdchitiethdld.ThoigioLV_id = old.ThoigioLV_id;
                hdchitiethdld.Mucluongchinh = old.Mucluongchinh;
                hdchitiethdld.BHXH = old.BHXH;
                hdchitiethdld.HSLuong_id = old.HSLuong_id;
                hdchitiethdld.Bac_id = old.Bac_id;
                hdchitiethdld.Ngach_id = old.Ngach_id;
                hdchitiethdld.Nhom_id = old.Nhom_id;
                hdchitiethdld.Bangluong_id = old.Bangluong_id;
                hdchitiethdld.QT_NgayNLDky = old.QT_NgayNLDky;
                hdchitiethdld.QT_NgayTrinhHT = old.QT_NgayTrinhHT;
                hdchitiethdld.QT_NgayHTky = old.QT_NgayHTky;
                hdchitiethdld.QT_NLDky = old.QT_NLDky;
                hdchitiethdld.QT_TrinhHT = old.QT_TrinhHT;
                hdchitiethdld.QT_HTky = old.QT_HTky;
                hdchitiethdld.QT_TraNLD = old.QT_TraNLD;
                hdchitiethdld.QT_LuuHS = old.QT_LuuHS;
            }
            if (ModelState.IsValid)
            {
                hdchitiethdld.NLD_id = old.NLD_id;
                if (Request.Form["BHXH.Value"] == "true,false")
                {
                    hdchitiethdld.BHXH = true;
                }
                else
                {
                    hdchitiethdld.BHXH = false;
                }

                db.Entry(old).CurrentValues.SetValues(hdchitiethdld);
                db.SaveChanges();
                if (Request.Form["PrintAndSave"] != null)
                {
                    return RedirectToAction("Details_DHCH", "CreateWordHD", new { id = hdchitiethdld.id, Back = "Edit_HDCoHuu" });
                }
                TempData["Message_EditHDCoHuu"] = "Cập nhật thành công!";
                return RedirectToAction("Edit_HDCoHuu", "ThemMoiHD", new { id = hdchitiethdld.id});
            }
            else if (hdchitiethdld.SoHD != null && hdchitiethdld.Donvi_id != null && hdchitiethdld.HotenNLD != null && hdchitiethdld.ThoihanHD_id != 0 && hdchitiethdld.NgayHL != null && hdchitiethdld.ThoigioLV_id != 0 && hdchitiethdld.Mucluongchinh != null)
            {
                hdchitiethdld.NLD_id = old.NLD_id;
                if (Request.Form["BHXH.Value"] == "true,false")
                {
                    hdchitiethdld.BHXH = true;
                }
                else
                {
                    hdchitiethdld.BHXH = false;
                }

                db.Entry(old).CurrentValues.SetValues(hdchitiethdld);
                db.SaveChanges();
                if (Request.Form["PrintAndSave"] != null)
                {
                    return RedirectToAction("Details_DHCH", "CreateWordHD", new { id = hdchitiethdld.id, Back = "Edit_HDCoHuu" });
                }
                TempData["Message_EditHDCoHuu"] = "Cập nhật thành công!";
                return RedirectToAction("Edit_HDCoHuu", "ThemMoiHD", new { id = hdchitiethdld.id});
            }
            TempData["Message_EditHDCoHuu"] = "Cập nhật thất bại!";
            return View(hdchitiethdld);
        }

        //
        // GET: /ThemMoiHD/Edit/5

        public ActionResult Edit_HDDaiHan(int id = 0)
        {
            hdChiTietHDLD hdchitiethdld = db.hdChiTietHDLD.Where(ct => ct.id == id).FirstOrDefault();
            if (hdchitiethdld == null)
            {
                return HttpNotFound();
            }
            return View(hdchitiethdld);
        }

        //
        // POST: /ThemMoiHD/Edit/5

        [HttpPost]
        public ActionResult Edit_HDDaiHan(hdChiTietHDLD hdchitiethdld)
        {
            UpdatehdChiTietHDLD(hdchitiethdld);
            var old = db.hdChiTietHDLD.Where(ct => ct.id == hdchitiethdld.id).First();
            if (Request.Form["BHXH.Value"] == "true,false")
            {
                hdchitiethdld.BHXH = true;
            }
            else
            {
                hdchitiethdld.BHXH = false;
            }
            if ((old.QT_NgayNLDky != null && old.QT_NgayTrinhHT != null && old.QT_NgayHTky != null) || (old.QT_NLDky != null && old.QT_TrinhHT != null && old.QT_HTky != null))
            {
                AssignhdChiTietHDLD(hdchitiethdld, old);
                hdchitiethdld.HotenNLD = old.HotenNLD;
                hdchitiethdld.Gioitinh_id = old.Gioitinh_id;
                hdchitiethdld.Donvi_id = old.Donvi_id;
                hdchitiethdld.SoHD = old.SoHD;
                hdchitiethdld.ThoihanHD_id = old.ThoihanHD_id;
                hdchitiethdld.NgayHL = old.NgayHL;
                hdchitiethdld.NgayhetHL = old.NgayhetHL;
                hdchitiethdld.Chucdanh_id = old.Chucdanh_id;
                hdchitiethdld.Chucvu_id = old.Chucvu_id;
                hdchitiethdld.ChucvutruongDV = old.ChucvutruongDV;
                hdchitiethdld.Congviec = old.Congviec;
                hdchitiethdld.ThoigioLV_id = old.ThoigioLV_id;
                hdchitiethdld.Mucluongchinh = old.Mucluongchinh;
                hdchitiethdld.BHXH = old.BHXH;
                hdchitiethdld.HSLuong_id = old.HSLuong_id;
                hdchitiethdld.Bac_id = old.Bac_id;
                hdchitiethdld.Ngach_id = old.Ngach_id;
                hdchitiethdld.Nhom_id = old.Nhom_id;
                hdchitiethdld.Bangluong_id = old.Bangluong_id;
                hdchitiethdld.QT_NgayNLDky = old.QT_NgayNLDky;
                hdchitiethdld.QT_NgayTrinhHT = old.QT_NgayTrinhHT;
                hdchitiethdld.QT_NgayHTky = old.QT_NgayHTky;
                hdchitiethdld.QT_NLDky = old.QT_NLDky;
                hdchitiethdld.QT_TrinhHT = old.QT_TrinhHT;
                hdchitiethdld.QT_HTky = old.QT_HTky;
                hdchitiethdld.QT_TraNLD = old.QT_TraNLD;
                hdchitiethdld.QT_LuuHS = old.QT_LuuHS;
            }
            if (ModelState.IsValid)
            {
                hdchitiethdld.NLD_id = old.NLD_id;
                if (Request.Form["BHXH.Value"] == "true,false")
                {
                    hdchitiethdld.BHXH = true;
                }
                else
                {
                    hdchitiethdld.BHXH = false;
                }

                db.Entry(old).CurrentValues.SetValues(hdchitiethdld);
                db.SaveChanges();
                if (Request.Form["PrintAndSave"] != null)
                {
                    return RedirectToAction("Details_DHCH", "CreateWordHD", new { id = hdchitiethdld.id, Back = "Edit_HDDaiHan" });
                }
                TempData["Message_EditHDDaiHan"] = "Cập nhật thành công!";
                return RedirectToAction("Edit_HDDaiHan", "ThemMoiHD", new { id = hdchitiethdld.id});
            }
            else if (hdchitiethdld.SoHD != null && hdchitiethdld.Donvi_id != null && hdchitiethdld.HotenNLD != null && hdchitiethdld.ThoihanHD_id != 0 && hdchitiethdld.NgayHL != null && hdchitiethdld.ThoigioLV_id != 0 && hdchitiethdld.Mucluongchinh != null)
            {
                hdchitiethdld.NLD_id = old.NLD_id;
                if (Request.Form["BHXH.Value"] == "true,false")
                {
                    hdchitiethdld.BHXH = true;
                }
                else
                {
                    hdchitiethdld.BHXH = false;
                }

                db.Entry(old).CurrentValues.SetValues(hdchitiethdld);
                db.SaveChanges();
                if (Request.Form["PrintAndSave"] != null)
                {
                    return RedirectToAction("Details_DHCH", "CreateWordHD", new { id = hdchitiethdld.id, Back = "Edit_HDDaiHan" });
                }
                TempData["Message_EditHDDaiHan"] = "Cập nhật thành công!";
                return RedirectToAction("Edit_HDDaiHan", "ThemMoiHD", new { id = hdchitiethdld.id});
            }
            TempData["Message_EditHDDaiHan"] = "Cập nhật thất bại!";
            return View(hdchitiethdld);
        }
        // details hd thu viec
        public ActionResult Details_HDThuViec(int id = 0)
        {
            hdChiTietHDLD hdchitiethdld = db.hdChiTietHDLD.Where(ct => ct.id == id).FirstOrDefault();
            if (hdchitiethdld == null)
            {
                return HttpNotFound();
            }
            return View(hdchitiethdld);
        }
        // details hd co huu
        public ActionResult Details_HDCoHuu(int id = 0)
        {
            hdChiTietHDLD hdchitiethdld = db.hdChiTietHDLD.Where(ct => ct.id == id).FirstOrDefault();
            if (hdchitiethdld == null)
            {
                return HttpNotFound();
            }
            return View(hdchitiethdld);
        }
        // details hd dai han
        public ActionResult Details_HDDaiHan(int id = 0)
        {
            hdChiTietHDLD hdchitiethdld = db.hdChiTietHDLD.Where(ct => ct.id == id).FirstOrDefault();
            if (hdchitiethdld == null)
            {
                return HttpNotFound();
            }
            return View(hdchitiethdld);
        }

        // Export to word
        [HttpPost]
        public void ExportGridToword()
        {
            Response.Clear();
            Response.Buffer = true;
            Response.ClearContent();
            Response.ClearHeaders();
            Response.Charset = "";
            string FileName = "Contract" + DateTime.Now + ".doc";
            StringWriter strwritter = new StringWriter();
            HtmlTextWriter htmltextwrtter = new HtmlTextWriter(strwritter);
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = "application/msword";
            Response.AddHeader("Content-Disposition", "attachment;filename=" + FileName);
            htmltextwrtter.AddStyleAttribute("MarginLeft", "20pt");
            htmltextwrtter.Write("BỘ GIÁO DỤC VÀ ĐÀO TẠO");
            htmltextwrtter.Write("CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM");

            Response.Write(strwritter.ToString());
            Response.End();

        }

        private void UpdatehdChiTietHDLD(hdChiTietHDLD hdld)
        {
            var old = db.hdChiTietHDLD.Find(hdld.id);
            hdld.LoaiHD = db.dmLoaiHopDong.Find(hdld.LoaiHD_id).tenLoaiHD;
            hdld.NgheNghiep = (db0.dmNgheNghiep.Find(hdld.Nghenghiep_id) ?? new dmNgheNghiep()).tenNgheNghiep;
            hdld.DonVi = (db0.dmDonVi.Find(hdld.Donvi_id) ?? new dmDonVi()).tenDonVi;
            hdld.ChucDanh = (db0.dmChucDanhChuyenMon.Find(hdld.Chucdanh_id) ?? new dmChucDanhChuyenMon()).tenChucDanhChuyenMon;
            hdld.ThoiHanHD = (db.dmThoiHanHD.Find(hdld.ThoihanHD_id) ?? new dmThoiHanHD()).tenThoiHanHD;
            hdld.ThoiGioLV = (db.dmThoiGioLamViec.Find(hdld.ThoigioLV_id) ?? new dmThoiGioLamViec()).tenThoiGioLamViec;
            var hsl = db0.dmBangLuong.Find(hdld.HSLuong_id) ?? new dmBangLuong();
            hdld.HSLuong = hsl.hesoLuong; hdld.Bac = hsl.bacLuong;
            hdld.Ngach = (db0.dmNgachVienChuc.Find(hdld.Ngach_id) ?? new dmNgachVienChuc()).tenNgachVienChuc;
            var nhom = db0.dmNhomNgachVienChuc.Find(hdld.Nhom_id) ?? new dmNhomNgachVienChuc();
            hdld.Nhom = nhom.tenNhomNgachVienChuc; hdld.MaNhom = nhom.maNhomNgachVienChuc;
            if (old != null)
            {
                hdld.mauHopDong = old.mauHopDong;
                hdld.banHopDong = old.banHopDong;
            }
        }
        private void AssignhdChiTietHDLD(hdChiTietHDLD hdld, hdChiTietHDLD old)
        {
            hdld.NgheNghiep = old.NgheNghiep;
            hdld.DonVi = old.DonVi;
            hdld.ChucDanh = old.ChucDanh;
            hdld.ChucVu = old.ChucVu;
            hdld.ThoiHanHD = old.ThoiHanHD;
            hdld.ThoiGioLV = old.ThoiGioLV;
            hdld.HSLuong = old.HSLuong;
            hdld.Bac = old.Bac;
            hdld.Ngach = old.Ngach;
            hdld.Nhom = old.Nhom;
            hdld.MaNhom = old.MaNhom;
            hdld.mauHopDong = old.mauHopDong;
            hdld.banHopDong = old.banHopDong;
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        public ActionResult View_MauHopDong(int id)
        {
            return View(db.hdChiTietHDLD.Find(id));
        }
        [HttpPost]
        public ActionResult View_MauHopDong(int id, string mauHopDong)
        {
            var model = db.hdChiTietHDLD.Find(id);
            model.mauHopDong = mauHopDong;
            db.Entry(model).State = EntityState.Modified;
            db.SaveChanges();
            return View(model);
        }

        public ActionResult View_BanHopDong(int id)
        {
            return View(db.hdChiTietHDLD.Find(id));
        }
        [HttpPost]
        public ActionResult View_BanHopDong(int id, string banHopDong)
        {
            var model = db.hdChiTietHDLD.Find(id);
            model.banHopDong = banHopDong;
            db.Entry(model).State = EntityState.Modified;
            db.SaveChanges();
            return View(model);
        }
    }
}