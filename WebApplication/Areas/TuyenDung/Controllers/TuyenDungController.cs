using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRM.Databases.Models;
using HRM.Databases_TuyenDung.Models;
using HRM.Libraries.Helpers;
namespace HRM.TuyenDung.Controllers
{
    public class TuyenDungController : Controller
    {
        private HRMDB2Entities db = new HRMDB2Entities();
        private HRMDB0Entities db0 = new HRMDB0Entities();
        //
        // GET: /TuyenDung/

        public ActionResult Index()
        {
            var listCD_id = new List<int>();
            foreach(var item in db0.dmChucDanhChuyenMon.ToList())
            {
                if(item.tenChucDanhChuyenMon == "Trợ giảng 1" || item.tenChucDanhChuyenMon == "Trợ giảng 2" ||item.tenChucDanhChuyenMon == "Giảng viên" ||item.tenChucDanhChuyenMon == "Giảng viên chính" ||item.tenChucDanhChuyenMon == "Giảng viên cao cấp" || item.tenChucDanhChuyenMon == "Giáo viên"|| item.tenChucDanhChuyenMon == "Giáo viên thực hành")
                {
                    listCD_id.Add(item.id);
                }
            }
            foreach (var item in db.tdTTUngCuVien.ToList())
            {
                if (item.hidden == false && item.KetQuaTuyenDung == true)
                {
                    bool isHad = false;
                    for(int i=0;i<listCD_id.Count;i++)
                    {
                        if(item.tdThongTinUngTuyens.FirstOrDefault().ViTriUngTuyen_id == listCD_id[i])
                        {
                            isHad = true;
                        }
                    }
                    if (isHad == false)
                    {
                        var hdnldct = new hdCanTaoHDLD();
                        hdnldct.MaTD = item.id.ToString();
                        hdnldct.Hoten = item.HoVaTen;
                        hdnldct.GioiTinh_id = item.GioiTinh_id;
                        hdnldct.Quoctich_id = item.QuocTich_id;
                        hdnldct.Ngaysinh = item.NgaySinh;
                        int? NoiSinh_id = item.tdNoiSinhs.FirstOrDefault().TinhThanh_id;
                        try
                        {
                            hdnldct.Noisinh = db0.dmTinhThanh.Where(tt => tt.id == NoiSinh_id).FirstOrDefault().tenTinhThanh;
                        }
                        catch { }
                        int? ttTinhThanh_id = item.tdThongTinLienHes.FirstOrDefault().tdHoKhauThuongTrus.FirstOrDefault().hkTinhThanh_id;
                        int? ttQuanHuyen_id = item.tdThongTinLienHes.FirstOrDefault().tdHoKhauThuongTrus.FirstOrDefault().hkQuanHuyen_id;
                        int? ttPhuongXa_id = item.tdThongTinLienHes.FirstOrDefault().tdHoKhauThuongTrus.FirstOrDefault().hkPhuongXa_id;
                        string ttTinhThanh = "";
                        string ttQuanHuyen = "";
                        string ttPhuongXa = "";
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
                            ttPhuongXa = db0.dmPhuongXa.Where(px => px.id == ttPhuongXa_id).FirstOrDefault().tenPhuongXa;
                        }
                        catch { }

                        if (ttPhuongXa != "")
                        {
                            hdnldct.Diachithuongtru = ttPhuongXa;
                        }
                        if (ttQuanHuyen != "")
                        {
                            hdnldct.Diachithuongtru = hdnldct.Diachithuongtru + ", " + ttQuanHuyen;
                        }
                        if (ttTinhThanh != null)
                        {
                            hdnldct.Diachithuongtru = hdnldct.Diachithuongtru + ", " + ttTinhThanh;
                        }
                        hdnldct.soCMND = item.tdTheDinhDanhs.FirstOrDefault().SoThe;
                        hdnldct.cmndNgaycap = item.tdTheDinhDanhs.FirstOrDefault().NgayCap;
                        hdnldct.cmndNoicap = item.tdTheDinhDanhs.FirstOrDefault().NoiCap_id;
                        hdnldct.VitriCT_id = item.tdThongTinUngTuyens.FirstOrDefault().ViTriUngTuyen_id;
                        hdnldct.Donvi_id = item.tdThongTinUngTuyens.FirstOrDefault().DonViUngTuyen_id;
                        hdnldct.Lydo = "Thử việc";

                        db.hdCanTaoHDLD.Add(hdnldct);
                        db.SaveChanges();

                        var newTTUngCV = new tdTTUngCuVien();

                        newTTUngCV.id = item.id;
                        newTTUngCV.HoVaTen = item.HoVaTen;
                        newTTUngCV.GioiTinh_id = item.GioiTinh_id;
                        newTTUngCV.NgaySinh = item.NgaySinh;
                        newTTUngCV.TTHonNhan = item.TTHonNhan;
                        newTTUngCV.TPGiaDinh_id = item.TPGiaDinh_id;
                        newTTUngCV.DanToc_id = item.DanToc_id;
                        newTTUngCV.TonGiao_id = item.TonGiao_id;
                        newTTUngCV.QuocTich_id = item.QuocTich_id;
                        newTTUngCV.hidden = true;
                        newTTUngCV.KetQuaTuyenDung = item.KetQuaTuyenDung;

                        db.Entry(item).CurrentValues.SetValues(newTTUngCV);
                        db.SaveChanges();
                    }
                }
            }
            var tdttungcuviens = db.tdTTUngCuVien;
            ViewBag.DB0 = db0;
            return View();
        }

        //
        // GET: /TuyenDung/Details/5

        public ActionResult Details(string tab,string nat, int id)
        {
            //tdTTUngCuVien tdttungcuvien = db.tdTTUngCuVien.Find(id);
            //if (tdttungcuvien == null)
            //{
            //    return HttpNotFound();
            //}
            ViewBag.UngVien_id = id;
            ViewBag.Tab = tab;
            ViewBag.Nat = nat;
            TempData["UngVien_id"] = id;
            return View();
        }

        //
        // GET: /TuyenDung/Create

        public ActionResult Create( string tab, int UV_id)
        {
            ViewBag.UngVien_id = UV_id;
            ViewBag.UngVien = db.tdTTUngCuVien.Find(UV_id);
            ViewBag.Tab = tab;
            return View();
        }
        //
        // GET: /TuyenDung/Edit/5

        public ActionResult Edit(int id = 0)
        {
            tdTTUngCuVien tdttungcuvien = db.tdTTUngCuVien.Find(id);
            if (tdttungcuvien == null)
            {
                return HttpNotFound();
            }
            return View(tdttungcuvien);
        }

        //
        // GET: /TuyenDung/Delete/5

        public ActionResult Delete(int id = 0)
        {
            tdTTUngCuVien tdttungcuvien = db.tdTTUngCuVien.Find(id);
            if (tdttungcuvien == null)
            {
                return HttpNotFound();
            }
            return View(tdttungcuvien);
        }

        //
        // POST: /TuyenDung/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            tdKiemTraH tdkiemtrah = db.tdKiemTraH.Where(kt => kt.UngVien_id == id).First();
            tdNoiSinh tdnoisinh = db.tdNoiSinh.Where(ns => ns.UngVien_id == id).First();
            tdTheDinhDanh tdthedinhdanh = db.tdTheDinhDanh.Where(dd => dd.UngVien_id == id).First();
            tdThongTinUngTuyen tdthongtinungtuyen = db.tdThongTinUngTuyen.Where(ut => ut.UngVien_id == id).First();
            tdThongTinLienHe tdthongtinlienhe = db.tdThongTinLienHe.Where(lh => lh.UngVien_id == id).First();
            tdHoKhauThuongTru tdhokhauthuongtru = db.tdHoKhauThuongTru.Where(tt => tt.TTLienHe_id == tdthongtinlienhe.id).First();
            tdDiaChiLienLac tddiachilienlac = db.tdDiaChiLienLac.Where(ll => ll.TTLienHe_id == tdthongtinlienhe.id).First();
            tdTTUngCuVien tdttungcuvien = db.tdTTUngCuVien.Find(id);
            

            db.tdKiemTraH.Remove(tdkiemtrah);
            db.tdNoiSinh.Remove(tdnoisinh);
            db.tdTheDinhDanh.Remove(tdthedinhdanh);
            db.tdThongTinUngTuyen.Remove(tdthongtinungtuyen);
            db.tdHoKhauThuongTru.Remove(tdhokhauthuongtru);
            db.tdDiaChiLienLac.Remove(tddiachilienlac);
            db.tdThongTinLienHe.Remove(tdthongtinlienhe);
            try
            {
                tdXemVaXepLichHen tdquanlylh = db.tdXemVaXepLichHen.Where(qllh => qllh.UngCuVien_id == id).First();
                db.tdXemVaXepLichHen.Remove(tdquanlylh);
            }
            catch
            {
            }
            try
            {
                var lisqttd = new List<tdQuaTrinhTuyenDung>();
                lisqttd = db.tdQuaTrinhTuyenDung.Where(qttd => qttd.UngVien_id == id).ToList();
                foreach (var item in lisqttd)
                {
                    db.tdQuaTrinhTuyenDung.Remove(item);
                }
                
            }
            catch
            {
            }
            try
            {
                var listdbc = new List<tdBangCap>();
                listdbc = db.tdBangCap.Where(qttd => qttd.UngVien_id == id).ToList();
                foreach (var item in listdbc)
                {
                    db.tdBangCap.Remove(item);
                }

            }
            catch
            {
            }
            db.tdTTUngCuVien.Remove(tdttungcuvien);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult UpdateKQTuyenDung(FormCollection form)
        {
            var id = int.Parse(form[0]);
            var kq = form[1];
            var tdttungcuvien = db.tdTTUngCuVien.Find(id);
            var kqtd = new Nullable<bool>();
            if (kq == "Trúng tuyển") kqtd = true;
            if (kq == "Không trúng tuyển") kqtd = false;
            if (kq == "Chưa trúng tuyển") kqtd = null;
            var newData = new tdTTUngCuVien { id = id,HoVaTen = tdttungcuvien.HoVaTen,GioiTinh_id = tdttungcuvien.GioiTinh_id, NgaySinh = tdttungcuvien.NgaySinh,TTHonNhan = tdttungcuvien.TTHonNhan,TPGiaDinh_id=tdttungcuvien.TPGiaDinh_id,DanToc_id=tdttungcuvien.DanToc_id,TonGiao_id=tdttungcuvien.TonGiao_id,QuocTich_id=tdttungcuvien.QuocTich_id,hidden=tdttungcuvien.hidden, KetQuaTuyenDung = kqtd };
            db.Entry(tdttungcuvien).CurrentValues.SetValues(newData);
            db.SaveChanges();
            if (tdttungcuvien.KetQuaTuyenDung == true)
            {
                /*
                if ((db0.dmChucDanhChuyenMon.Find(tdttungcuvien.tdThongTinUngTuyens.FirstOrDefault().ViTriUngTuyen_id).dmChucDanh ?? new dmChucDanh()).maChucDanh == "NV") //chỉnh sửa khi thay đổi db
                {
                    try
                    {
                        HRM.Services.QLTTNhanSu.themQuanLyThuViec("TV" + id, tdttungcuvien.HoVaTen, Convert.ToDateTime(tdttungcuvien.tdThongTinUngTuyens.FirstOrDefault().NgayBatDauLamViec), tdttungcuvien.tdThongTinUngTuyens.FirstOrDefault().DonViUngTuyen_id, tdttungcuvien.tdThongTinUngTuyens.FirstOrDefault().ViTriUngTuyen_id);
                    }
                    catch
                    {
                        HRM.Services.QLTTNhanSu.themQuanLyThuViec("TV" + id, tdttungcuvien.HoVaTen, Convert.ToDateTime("01/01/1990"), tdttungcuvien.tdThongTinUngTuyens.FirstOrDefault().DonViUngTuyen_id, tdttungcuvien.tdThongTinUngTuyens.FirstOrDefault().ViTriUngTuyen_id);
                    }
                }
                */
                //if ((db0.dmChucDanhChuyenMon.Find(tdttungcuvien.tdThongTinUngTuyens.FirstOrDefault().ViTriUngTuyen_id).dmChucDanh ?? new dmChucDanh()).maChucDanh == "GV")
                //    return RedirectToAction("CreateGV", new { UV_id = id });
            }
            return RedirectToAction("Index");
        }

        public ActionResult CreateGV(int UV_id)
        {
            return View(UV_id);
        }
        [HttpPost]
        public ActionResult CreateGV(int UV_id, NhanVien model)
        {
            TryUpdateModel<NhanVien>(model, "NhanVien");
            var uv = db.tdTTUngCuVien.Find(UV_id);
            HRM.Services.QLTTNhanSu.taoNhanVienMoi_Ten(model.MaHS, model.MaNV, uv.HoVaTen);
            return RedirectToAction("Index");
        }

        public ActionResult XemTheoNam(string value)
        {
            TempData["XemNam"] = value;
            return null;
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}