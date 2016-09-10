using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using HRM.Databases.Models;
using HRM.Databases_TuyenDung.Models;
using System.Web.UI;

namespace HRM.TuyenDung.Controllers
{
    public class ImportTuFileExcelController : Controller
    {
        private HRMDB2Entities db = new HRMDB2Entities();
        private HRMDB0Entities db0 = new HRMDB0Entities();
        //
        // GET: /ImportTuFileExcel/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ImportToExcel()
        {

            if (Request.Form["import"] != null)
            {
                var listview = new List<tdImportExcel>();
                listview = (List<tdImportExcel>)TempData["listImport"];
                int countSuccess = 0;
                int countFail = 0;
                try
                {
                    foreach (var dReader in listview)
                    {
                        countFail++;
                        var HoVaTen = dReader.HoVaTen;
                        var gttempt = dReader.GioiTinh;
                        var GioiTinh = db0.dmGioiTinh.Where(gt => gt.tenGioiTinh.ToLower() == gttempt.ToLower()).First().id;
                        var NgaySinh = DateTime.Parse(dReader.NgaySinh);
                        var nstempt = dReader.NoiSinh;
                        var NoiSinh = db0.dmTinhThanh.Where(tt => tt.tenTinhThanh.ToLower().Contains(nstempt.ToLower())).First().id;
                        var loaithetempt = dReader.LoaiTheDinhDanh;
                        var LoaiTheDD = db.tdLoaiTheDinhDanh.Where(dd => dd.LoaiTheDinhDanh.ToLower() == loaithetempt.ToLower()).First().id;
                        var SoTheDD = dReader.SoThe;
                        var noicaptempt = dReader.NoiCap;
                        var NoiCap = db0.dmTinhThanh.Where(tt => tt.tenTinhThanh.ToLower().Contains(noicaptempt.ToLower())).First().id;
                        var NgayCap = DateTime.Parse(dReader.NgayCap);
                        var NgayHetHan = new DateTime();
                        try
                        {
                            NgayHetHan = DateTime.Parse(dReader.NgayHetHan);
                        }
                        catch
                        {
                        }
                        var DTDiDong = dReader.DTDiDong;
                        var DTNha = dReader.DTNha;
                        var Email = dReader.Email;
                        var DiaChiLienHe = dReader.DiaChiLienHe;


                        var ViTriUngTuyen = dReader.ViTriUngTuyen;
                        var dvtempt = dReader.DonViUngTuyen;
                        var DonViUngTuyen = db0.dmDonVi.Where(dv => dv.tenDonVi.ToLower() == dvtempt.ToLower()).First().id;
                        var NgayNhanHoSo = DateTime.Parse(dReader.NgayNhanHoSo);
                        var KetQuaTuyenDung = dReader.KetQuaTuyenDung;
                        var GhiChu = dReader.GhiChu;
                        var QuocGia = db0.dmQuocGia.Where(qg => qg.tenQuocGia.ToLower() == "Việt Nam".ToLower()).First().id;
                        //save thong tin ung vien
                        var tdttungcuvien = new tdTTUngCuVien { HoVaTen = HoVaTen, GioiTinh_id = GioiTinh, NgaySinh = NgaySinh, QuocTich_id = QuocGia, KetQuaTuyenDung = KetQuaTuyenDung };
                        db.tdTTUngCuVien.Add(tdttungcuvien);
                        db.SaveChanges();

                        // get ung vien id
                        var UngVien_id = db.tdTTUngCuVien.ToList().Last().id;

                        //save bang cap
                        foreach (var im in dReader.BangCap)
                        {
                            try
                            {
                                string[] ttdbangcap = im.Split(",".ToArray());
                                string trinhdo = ttdbangcap[0];
                                string chuyennganh = ttdbangcap[1];
                                string noihoc = ttdbangcap[2];
                                int? namtn;
                                try
                                {
                                    namtn = int.Parse(ttdbangcap[3]);
                                }
                                catch
                                {
                                    namtn = null;
                                }
                                string xeploai = ttdbangcap[4];

                                var TrinhDo_id = db0.dmHocVi.Where(hv => hv.tenHocVi.ToLower() == trinhdo.ToLower()).First().id;
                                var ChuyenNganh_id = db0.dmChuyenNganh.Where(cn => cn.tenChuyenNganh.ToLower() == chuyennganh.ToLower()).First().id;
                                var XepLoai_id = db0.dmXepLoaiTotNghiep.Where(tn => tn.tenXepLoaiTotNghiep.ToLower() == xeploai.ToLower()).First().id;

                                var tdbangcapCrete = new tdBangCap { UngVien_id = UngVien_id, TrinhDo_id = TrinhDo_id, ChuyenNganh_id = ChuyenNganh_id, NoiDaoTao = noihoc, NamTotNghiep = namtn, XepLoai_id = XepLoai_id, SetDefault = false };
                                db.tdBangCap.Add(tdbangcapCrete);
                                db.SaveChanges();
                            }
                            catch
                            {
                            }
                        }
                        //save noi sinh, the dinh danh, kiem tra du thieu hs, qua trinh tuyendung, quan ly lich hen
                        var tdnoisinh = new tdNoiSinh { UngVien_id = UngVien_id, QuocGia_id = QuocGia, TinhThanh_id = NoiSinh };
                        db.tdNoiSinh.Add(tdnoisinh);
                        var tdthedinhdanh = new tdTheDinhDanh { UngVien_id = UngVien_id, LoaiThe_id = LoaiTheDD, SoThe = SoTheDD, NoiCap_id = NoiCap, NgayCap = NgayCap, NgayHetHan = NgayHetHan };
                        db.tdTheDinhDanh.Add(tdthedinhdanh);
                        var hsmodel = new tdKiemTraH() { UngVien_id = UngVien_id, DonXinViec = false, SoYeuLyLich = false, TheDinhDanh = false, SoHoKhau = false, GiayKhamSucKhoe = false, BangCapBangDiem = false, Hinh = false, GiayToKhac = false };
                        db.tdKiemTraH.Add(hsmodel);
                        //var tdqttuyendung = new tdQuaTrinhTuyenDung { UngVien_id = UngVien_id };
                        //db.tdQuaTrinhTuyenDung.Add(tdqttuyendung);
                        //var tdqllichhen = new tdXemVaXepLichHen { UngCuVien_id = UngVien_id, DaBaoChoUngCuVien = false };
                        //db.tdXemVaXepLichHen.Add(tdqllichhen);
                        db.SaveChanges();

                        // save tt lien he
                        var tdttlienhe = new tdThongTinLienHe { UngVien_id = UngVien_id, DTDiDong1 = DTDiDong, DTNha = DTNha, Email = Email };
                        db.tdThongTinLienHe.Add(tdttlienhe);
                        db.SaveChanges();

                        // get TT lien he id
                        var TTLienHe_id = db.tdThongTinLienHe.ToList().Last().id;

                        //save dia chi lien lac & ho khau thuong tru
                        string[] ttlienhe = DiaChiLienHe.Split(",".ToArray());
                        string tend = ttlienhe[0];
                        string pxa = ttlienhe[1];
                        string qhu = ttlienhe[2];
                        string tth = ttlienhe[3];
                        try
                        {
                            var PhuongXa = db0.dmPhuongXa.Where(px => px.tenPhuongXa.ToLower().Contains(pxa.ToLower())).First().id;
                            var QuanHuyen = db0.dmQuanHuyen.Where(qh => qh.tenQuanHuyen.ToLower().Contains(qhu.ToLower())).First().id;
                            var TinhThanh = db0.dmTinhThanh.Where(tt => tt.tenTinhThanh.ToLower().Contains(tth.ToLower())).First().id;
                            var tddiachilienlac = new tdDiaChiLienLac { TTLienHe_id = TTLienHe_id, llQuocGia_id = QuocGia, llTinhThanh_id = TinhThanh, llQuanHuyen_id = QuanHuyen, llPhuongXa_id = PhuongXa, llTenDuong = tend };
                            db.tdDiaChiLienLac.Add(tddiachilienlac);
                        }
                        catch
                        {
                            var tddiachilienlac = new tdDiaChiLienLac { TTLienHe_id = TTLienHe_id };
                            db.tdDiaChiLienLac.Add(tddiachilienlac);
                        }
                        var tdhokhauthuongtru = new tdHoKhauThuongTru { TTLienHe_id = TTLienHe_id };
                        db.tdHoKhauThuongTru.Add(tdhokhauthuongtru);
                        db.SaveChanges();

                        //save thong tin ung tuyen
                        var ViTriUngTuyen_id = db0.dmChucDanhChuyenMon.Where(cm => cm.tenChucDanhChuyenMon.ToLower() == ViTriUngTuyen.ToLower()).First().id;
                        var tdttungtuyen = new tdThongTinUngTuyen { UngVien_id = UngVien_id, ViTriUngTuyen_id = ViTriUngTuyen_id, DonViUngTuyen_id = DonViUngTuyen, NgayNhanHS = NgayNhanHoSo, GhiChu = GhiChu };
                        db.tdThongTinUngTuyen.Add(tdttungtuyen);
                        db.SaveChanges();
                        countSuccess++;
                    }
                    countFail = countFail;
                    TempData["Message"] = "Bạn đã import thành công thông tin " + countSuccess + "/" + countFail + " ứng viên";

                }
                catch
                {
                    if (Request.Files["FileUpload1"].ContentLength > 0)
                    {
                        string extension = System.IO.Path.GetExtension(Request.Files["FileUpload1"].FileName);
                        string path1 = string.Format("{0}/{1}", Server.MapPath("~/Areas/TuyenDung/Contents/UploadedFolder"), Request.Files["FileUpload1"].FileName);
                        if (System.IO.File.Exists(path1))
                            System.IO.File.Delete(path1);
                        Request.Files["FileUpload1"].SaveAs(path1);


                        //Create connection string to Excel work book
                        string excelConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path1 + ";Extended Properties=Excel 12.0;Persist Security Info=False";
                        //Create Connection to Excel work book
                        OleDbConnection excelConnection = new OleDbConnection(excelConnectionString);
                        //Create OleDbCommand to fetch data from Excel
                        OleDbCommand cmd = new OleDbCommand("Select * from [Sheet1$]", excelConnection);

                        excelConnection.Open();
                        OleDbDataReader dReader;
                        dReader = cmd.ExecuteReader();

                        while (dReader.Read())
                        {
                            try
                            {
                                countFail++;
                                var HoVaTen = dReader.GetValue(0).ToString();
                                if (HoVaTen == "")
                                {
                                    dReader.NextResult();
                                }
                                else
                                {
                                    var gttempt = dReader.GetValue(1).ToString();
                                    var GioiTinh = db0.dmGioiTinh.Where(gt => gt.tenGioiTinh.ToLower() == gttempt.ToLower()).First().id;
                                    var NgaySinh = DateTime.Parse(dReader.GetValue(2).ToString());
                                    var nstempt = dReader.GetValue(3).ToString();
                                    var NoiSinh = db0.dmTinhThanh.Where(tt => tt.tenTinhThanh.ToLower().Contains(nstempt.ToLower())).First().id;
                                    var loaithetempt = dReader.GetValue(4).ToString();
                                    var LoaiTheDD = db.tdLoaiTheDinhDanh.Where(dd => dd.LoaiTheDinhDanh.ToLower() == loaithetempt.ToLower()).First().id;
                                    var SoTheDD = dReader.GetValue(5).ToString();
                                    var noicaptempt = dReader.GetValue(6).ToString();
                                    var NoiCap = db0.dmTinhThanh.Where(tt => tt.tenTinhThanh.ToLower().Contains(noicaptempt.ToLower())).First().id;
                                    var NgayCap = DateTime.Parse(dReader.GetValue(7).ToString());
                                    DateTime? NgayHetHan = new DateTime();
                                    try
                                    {
                                        NgayHetHan = DateTime.Parse(dReader.GetValue(8).ToString());
                                    }
                                    catch
                                    {
                                        NgayHetHan = null;
                                    }
                                    var DTDiDong = dReader.GetValue(9).ToString();
                                    var DTNha = dReader.GetValue(10).ToString();
                                    var Email = dReader.GetValue(11).ToString();
                                    var DiaChiLienHe = dReader.GetValue(12).ToString();
                                    var BangCapList = new List<string>();
                                    int co = dReader.FieldCount - 18;
                                    int i = 0;
                                    var list = new List<string>();
                                    for (i = 0; i < co; i++)
                                    {
                                        list.Add(dReader.GetValue(13 + i).ToString());
                                    }
                                    BangCapList = list;
                                    var ViTriUngTuyen = dReader.GetValue(13 + i).ToString();
                                    var dvtempt = dReader.GetValue(13 + i + 1).ToString();
                                    var DonViUngTuyen = db0.dmDonVi.Where(dv => dv.tenDonVi.ToLower() == dvtempt.ToLower()).First().id;
                                    var NgayNhanHoSo = DateTime.Parse(dReader.GetValue(13 + i + 2).ToString());
                                    var KetQuaTuyenDung = dReader.GetValue(13 + i + 3).ToString();
                                    var GhiChu = dReader.GetValue(13 + i + 4).ToString();
                                    var QuocGia = db0.dmQuocGia.Where(qg => qg.tenQuocGia.ToLower() == "Việt Nam".ToLower()).First().id;

                                    //save thong tin ung vien
                                    var kqtd = new Nullable<bool>();
                                    if (KetQuaTuyenDung == "Trúng tuyển") kqtd = true;
                                    if (KetQuaTuyenDung == "Không trúng tuyển") kqtd = false;
                                    if (KetQuaTuyenDung == "Chưa có kết quả") kqtd = null;
                                    var tdttungcuvien = new tdTTUngCuVien { HoVaTen = HoVaTen, GioiTinh_id = GioiTinh, NgaySinh = NgaySinh, QuocTich_id = QuocGia, KetQuaTuyenDung = kqtd };
                                    db.tdTTUngCuVien.Add(tdttungcuvien);
                                    db.SaveChanges();

                                    // get ung vien id
                                    var UngVien_id = db.tdTTUngCuVien.ToList().Last().id;

                                    // save bang cap
                                    foreach (var im in BangCapList)
                                    {
                                        try
                                        {
                                            string[] ttdbangcap = im.Split(",".ToArray());
                                            string trinhdo = ttdbangcap[0];
                                            string chuyennganh = ttdbangcap[1];
                                            string noihoc = ttdbangcap[2];
                                            int? namtn;
                                            try
                                            {
                                                namtn = int.Parse(ttdbangcap[3]);
                                            }
                                            catch
                                            {
                                                namtn = null;
                                            }
                                            string xeploai = ttdbangcap[4];

                                            var TrinhDo_id = db0.dmHocVi.Where(td => td.tenHocVi.ToLower() == trinhdo.ToLower()).First().id;
                                            var ChuyenNganh_id = db0.dmChuyenNganh.Where(td => td.tenChuyenNganh.ToLower() == chuyennganh.ToLower()).First().id;
                                            var XepLoai_id = db0.dmXepLoaiTotNghiep.Where(td => td.tenXepLoaiTotNghiep.ToLower() == xeploai.ToLower()).First().id;

                                            var tdbangcapCrete = new tdBangCap { UngVien_id = UngVien_id, TrinhDo_id = TrinhDo_id, ChuyenNganh_id = ChuyenNganh_id, NoiDaoTao = noihoc, NamTotNghiep = namtn, XepLoai_id = XepLoai_id, SetDefault = false };
                                            db.tdBangCap.Add(tdbangcapCrete);
                                            db.SaveChanges();
                                        }
                                        catch
                                        {
                                        }
                                    }


                                    //save noi sinh, the dinh danh, kiem tra du thieu hs, qua trinh tuyendung, quan ly lich hen
                                    var tdnoisinh = new tdNoiSinh { UngVien_id = UngVien_id, QuocGia_id = QuocGia, TinhThanh_id = NoiSinh };
                                    db.tdNoiSinh.Add(tdnoisinh);
                                    var tdthedinhdanh = new tdTheDinhDanh { UngVien_id = UngVien_id, LoaiThe_id = LoaiTheDD, SoThe = SoTheDD, NoiCap_id = NoiCap, NgayCap = NgayCap, NgayHetHan = NgayHetHan };
                                    db.tdTheDinhDanh.Add(tdthedinhdanh);
                                    var hsmodel = new tdKiemTraH() { UngVien_id = UngVien_id, DonXinViec = false, SoYeuLyLich = false, TheDinhDanh = false, SoHoKhau = false, GiayKhamSucKhoe = false, BangCapBangDiem = false, Hinh = false, GiayToKhac = false };
                                    db.tdKiemTraH.Add(hsmodel);
                                    //var tdqttuyendung = new tdQuaTrinhTuyenDung { UngVien_id = UngVien_id };
                                    //db.tdQuaTrinhTuyenDung.Add(tdqttuyendung);
                                    //var tdqllichhen = new tdXemVaXepLichHen { UngCuVien_id = UngVien_id, DaBaoChoUngCuVien = false };
                                    //db.tdXemVaXepLichHen.Add(tdqllichhen);
                                    db.SaveChanges();

                                    // save tt lien he
                                    var tdttlienhe = new tdThongTinLienHe { UngVien_id = UngVien_id, DTDiDong1 = DTDiDong, DTNha = DTNha, Email = Email };
                                    db.tdThongTinLienHe.Add(tdttlienhe);
                                    db.SaveChanges();

                                    // get TT lien he id
                                    var TTLienHe_id = db.tdThongTinLienHe.ToList().Last().id;

                                    //save dia chi lien lac & ho khau thuong tru
                                    string[] ttlienhe = DiaChiLienHe.Split(",".ToArray());
                                    string tend = ttlienhe[0];
                                    string pxa = ttlienhe[1];
                                    string qhu = ttlienhe[2];
                                    string tth = ttlienhe[3];
                                    try
                                    {
                                        var PhuongXa = db0.dmPhuongXa.Where(px => px.tenPhuongXa.ToLower() == pxa.ToString().ToLower()).First().id;
                                        var QuanHuyen = db0.dmQuanHuyen.Where(qh => qh.tenQuanHuyen.ToLower().Contains(qhu.ToLower())).First().id;
                                        var TinhThanh = db0.dmTinhThanh.Where(tt => tt.tenTinhThanh.ToLower().Contains(tth.ToLower())).First().id;
                                        var tddiachilienlac = new tdDiaChiLienLac { TTLienHe_id = TTLienHe_id, llQuocGia_id = QuocGia, llTinhThanh_id = TinhThanh, llQuanHuyen_id = QuanHuyen, llPhuongXa_id = PhuongXa, llTenDuong = tend };
                                        db.tdDiaChiLienLac.Add(tddiachilienlac);
                                    }
                                    catch
                                    {
                                        var tddiachilienlac = new tdDiaChiLienLac { TTLienHe_id = TTLienHe_id };
                                        db.tdDiaChiLienLac.Add(tddiachilienlac);
                                    }
                                    var tdhokhauthuongtru = new tdHoKhauThuongTru { TTLienHe_id = TTLienHe_id };
                                    db.tdHoKhauThuongTru.Add(tdhokhauthuongtru);
                                    db.SaveChanges();

                                    //save thong tin ung tuyen
                                    var ViTriUngTuyen_id = db0.dmChucDanhChuyenMon.Where(cm => cm.tenChucDanhChuyenMon.ToLower() == ViTriUngTuyen.ToLower()).First().id;
                                    var tdttungtuyen = new tdThongTinUngTuyen { UngVien_id = UngVien_id, ViTriUngTuyen_id = ViTriUngTuyen_id, DonViUngTuyen_id = DonViUngTuyen, NgayNhanHS = NgayNhanHoSo, GhiChu = GhiChu };
                                    db.tdThongTinUngTuyen.Add(tdttungtuyen);
                                    db.SaveChanges();
                                    countSuccess++;
                                }
                            }
                            catch
                            {
                            }
                        }
                        excelConnection.Close();
                        countFail = countFail - 1;
                        TempData["Message"] = "Bạn đã import thành công thông tin " + countSuccess + "/" + countFail + " ứng viên";
                    }
                }
                
                return RedirectToAction("Index", "TuyenDung");
            }
            else
            {
                if (Request.Files["FileUpload1"].ContentLength > 0)
                {
                    string extension = System.IO.Path.GetExtension(Request.Files["FileUpload1"].FileName);
                    string path1 = string.Format("{0}/{1}", Server.MapPath("~/Areas/TuyenDung/Contents/UploadedFolder"), Request.Files["FileUpload1"].FileName);
                    if (System.IO.File.Exists(path1))
                        System.IO.File.Delete(path1);
                    Request.Files["FileUpload1"].SaveAs(path1);


                    //Create connection string to Excel work book
                    string excelConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path1 + ";Extended Properties=Excel 12.0;Persist Security Info=False";
                    //Create Connection to Excel work book
                    OleDbConnection excelConnection = new OleDbConnection(excelConnectionString);
                    //Create OleDbCommand to fetch data from Excel
                    OleDbCommand cmd = new OleDbCommand("Select * from [Sheet1$]", excelConnection);

                    excelConnection.Open();
                    OleDbDataReader dReader;
                    dReader = cmd.ExecuteReader();

                    var listview = new List<tdImportExcel>();

                    while (dReader.Read())
                    {
                        var tduv = new tdImportExcel();
                        var HoVaTen = dReader.GetValue(0).ToString();
                        if (HoVaTen == "")
                        {
                            dReader.NextResult();
                        }
                        else
                        {
                            tduv.HoVaTen = HoVaTen;
                            var gttempt = dReader.GetValue(1).ToString();
                            var gioitinhtempt = db0.dmGioiTinh.Where(gt => gt.tenGioiTinh.ToLower() == gttempt.ToLower()).First().tenGioiTinh;
                            tduv.GioiTinh = gioitinhtempt;
                            tduv.NgaySinh = DateTime.Parse(dReader.GetValue(2).ToString()).ToShortDateString();
                            var nstempt = dReader.GetValue(3).ToString();
                            tduv.NoiSinh = db0.dmTinhThanh.Where(tt => tt.tenTinhThanh.ToLower().Contains(nstempt.ToLower())).First().tenTinhThanh;
                            var loaithetempt = dReader.GetValue(4).ToString();
                            tduv.LoaiTheDinhDanh = db.tdLoaiTheDinhDanh.Where(dd => dd.LoaiTheDinhDanh.ToLower() == loaithetempt.ToLower()).First().LoaiTheDinhDanh;
                            tduv.SoThe = dReader.GetValue(5).ToString();
                            var noicaptempt = dReader.GetValue(6).ToString();
                            tduv.NoiCap = db0.dmTinhThanh.Where(tt => tt.tenTinhThanh.ToLower().Contains(noicaptempt.ToLower())).First().tenTinhThanh;
                            tduv.NgayCap = DateTime.Parse(dReader.GetValue(7).ToString()).ToShortDateString();
                            DateTime? NgayHetHan = new DateTime();
                            try
                            {
                                NgayHetHan = DateTime.Parse(dReader.GetValue(8).ToString());
                                tduv.NgayHetHan = NgayHetHan.Value.ToShortDateString();
                            }
                            catch
                            {
                                NgayHetHan = null;
                            }

                            tduv.DTDiDong = dReader.GetValue(9).ToString();
                            tduv.DTNha = dReader.GetValue(10).ToString();
                            tduv.Email = dReader.GetValue(11).ToString();
                            tduv.DiaChiLienHe = dReader.GetValue(12).ToString();
                            int co = dReader.FieldCount - 18;
                            int i = 0;
                            var list = new List<string>();
                            for (i = 0; i < co; i++)
                            {
                                list.Add(dReader.GetValue(13 + i).ToString());
                            }
                            tduv.BangCap = list;
                            tduv.ViTriUngTuyen = dReader.GetValue(13 + i).ToString(); 
                            var dvtempt = dReader.GetValue(13+i+1).ToString();
                            tduv.DonViUngTuyen = db0.dmDonVi.Where(dv => dv.tenDonVi.ToLower() == dvtempt.ToLower()).First().tenDonVi;
                            tduv.NgayNhanHoSo = DateTime.Parse(dReader.GetValue(13+i+2).ToString()).ToShortDateString();
                            var KetQuaTuyenDung = dReader.GetValue(13 + i + 3).ToString();
                            if (KetQuaTuyenDung == "Trúng tuyển") tduv.KetQuaTuyenDung = true;
                            if (KetQuaTuyenDung == "Không trúng tuyển") tduv.KetQuaTuyenDung = false;
                            if (KetQuaTuyenDung == "Chưa có kết quả") tduv.KetQuaTuyenDung = null;
                            //tduv.KetQuaTuyenDung = dReader.GetValue(13+i+3).ToString();
                            tduv.GhiChu = dReader.GetValue(13+i+4).ToString();
                            listview.Add(tduv);
                        }

                    }
                    excelConnection.Close();
                    TempData["tdttungvien"] = listview;
                    TempData["filepath"] = Request.Files["FileUpload1"].FileName;
                }

                return RedirectToAction("Index");
            }
        }

    }
}
