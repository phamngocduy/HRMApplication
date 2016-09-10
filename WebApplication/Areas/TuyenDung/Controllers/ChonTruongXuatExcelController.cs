using HRM.Databases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRM.Databases.Models;
using HRM.Databases_TuyenDung.Models;
using System.Text;
using System.Reflection;
using HRM.Webpages.Helpers;

namespace HRM.TuyenDung.Controllers
{
    public class ChonTruongXuatExcelController : Controller
    {
        //
        // GET: /ChonTruongXuatExcel/

        public ActionResult Index()
        {
            ViewBag.tdXuatExcel = TempData["tdXuatExcel"];
            return View();
        }
        public ActionResult XuatExcel(FormCollection form)
        {
            // field selected to export
            var con = new List<string>();
            if (form.AllKeys.FirstOrDefault() == "XuatTatCa")
            {
                for (int k = 1; k < form.Count; k++)
                {
                    con.Add(form.AllKeys[k]);
                }
            }
            else
            {
                con = form.AllKeys.ToList();
            }
            // add header
            var hed = new List<string>();
            for (int j = 0; j < con.Count; j++)
            {
                if (con[j] == "HoTenUngVien")
                {
                    hed.Add("Họ và tên ứng viên");
                }
            }
            for (int j = 0; j < con.Count; j++)
            {
                if (con[j] == "GioiTinh")
                {
                    hed.Add("Giới tính");
                }
            }
            for (int j = 0; j < con.Count; j++)
            {
                if (con[j] == "NgaySinh")
                {
                    hed.Add("Ngày sinh");
                }
            }
            for (int j = 0; j < con.Count; j++)
            {
                if (con[j] == "NoiSinh")
                {
                    hed.Add("Nơi sinh");
                }
            }
            for (int j = 0; j < con.Count; j++)
            {
                if (con[j] == "SoTheDinhDanh")
                {
                    hed.Add("Số thẻ định danh");
                }
            }
            for (int j = 0; j < con.Count; j++)
            {
                if (con[j] == "DienThoai")
                {
                    hed.Add("Điện thoại");
                }
            }
            for (int j = 0; j < con.Count; j++)
            {
                if (con[j] == "Email")
                {
                    hed.Add("Email");
                }
            }
            for (int j = 0; j < con.Count; j++)
            {
                if (con[j] == "DiaChiLienLac")
                {
                    hed.Add("Địa chỉ liên lạc");
                }
            }
            for (int j = 0; j < con.Count; j++)
            {
                if (con[j] == "BangCap")
                {
                    hed.Add("Bằng cấp");
                }
            }
            for (int j = 0; j < con.Count; j++)
            {
                if (con[j] == "ViTriUngTuyen")
                {
                    hed.Add("Vị trí ứng tuyển");
                }
            }
            for (int j = 0; j < con.Count; j++)
            {
                if (con[j] == "DonViUngTuyen")
                {
                    hed.Add("Đơn vị ứng tuyển");
                }
            }
            for (int j = 0; j < con.Count; j++)
            {
                if (con[j] == "KinhNghiemLamViec")
                {
                    hed.Add("Kinh nghiệm làm việc");
                }
            }
            for (int j = 0; j < con.Count; j++)
            {
                if (con[j] == "KetQuaTuyenDung")
                {
                    hed.Add("Kết quả tuyển dụng");
                }
            }
            for (int j = 0; j < con.Count; j++)
            {
                if (con[j] == "NhanXet")
                {
                    hed.Add("Nhận xét");
                }
            }

            // data list need export
            var ori = (List<tdXuatExcel>)TempData["tdXuatExcel"];
            // find number max of bang cap columm
            int maxColummBangCap = 1;
            foreach(var item in ori){
                if(maxColummBangCap <= item.BangCap.Count){
                    maxColummBangCap = item.BangCap.Count;
                }
            }
            //var cus = new List<CustomObject2>();

            //var i = 0;
            //foreach (var item in ori)
            //{
            //    var tmp = new CustomObject2();

            //    foreach (var key in con)
            //    {
            //        PropertyInfo prop = tmp.GetType().GetProperty(con1[i++], BindingFlags.Public | BindingFlags.Instance);
            //        if (null != prop && prop.CanWrite)
            //        {
            //            prop.SetValue(tmp, GetPropertyValue(item, key), null);
            //        }
            //    }
            //    cus.Add(tmp);
            //    i = 0;
            //}

            //CreateExcelFile.CreateExcelDocument(cus, hed, con.Count, "C:\\Users\\vodan_000\\Desktop\\Report.xlsx");\
            

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
                    if (item != "Bằng cấp")
                    {
                        writer.WriteExcelUnstyledCell(item);
                    }
                    else
                    {
                        for (int i = 0; i < maxColummBangCap; i++)
                        {
                            writer.WriteExcelUnstyledCell(item);
                        }
                    }
                }
                writer.WriteEndRow();
                // writing content
                var D = new Func<Nullable<DateTime>, object>(d => d.HasValue ? (object)d.Value : null);
                foreach (var item in ori)
                {
                    writer.WriteStartRow();
                    for (int col = 0; col < hed.Count; col++)
                    {
                        if (hed[col] == "Họ và tên ứng viên")
                        {
                            writer.WriteExcelAutoStyledCell(item.HoTenUngVien);
                        }
                        if (hed[col] == "Giới tính")
                        {
                            writer.WriteExcelAutoStyledCell(item.GioiTinh);
                        }
                        if (hed[col] == "Ngày sinh")
                        {
                            writer.WriteExcelAutoStyledCell(item.NgaySinh);
                        }
                        if (hed[col] == "Nơi sinh")
                        {
                            writer.WriteExcelAutoStyledCell(item.NoiSinh);
                        }
                        if (hed[col] == "Số thẻ định danh")
                        {
                            writer.WriteExcelAutoStyledCell(item.SoTheDinhDanh);
                        }
                        if (hed[col] == "Điện thoại")
                        {
                            writer.WriteExcelAutoStyledCell(item.DienThoai);
                        }
                        if (hed[col] == "Email")
                        {
                            writer.WriteExcelAutoStyledCell(item.Email);
                        }
                        if (hed[col] == "Địa chỉ liên lạc")
                        {
                            writer.WriteExcelAutoStyledCell(item.DiaChiLienLac);
                        }
                        if (hed[col] == "Bằng cấp")
                        {
                            foreach (var im in item.BangCap)
                            {
                                writer.WriteExcelAutoStyledCell(im);
                            }
                        }
                        if (hed[col] == "Vị trí ứng tuyển")
                        {
                            writer.WriteExcelAutoStyledCell(item.ViTriUngTuyen);
                        }
                        if (hed[col] == "Đơn vị ứng tuyển")
                        {
                            writer.WriteExcelAutoStyledCell(item.DonViUngTuyen);
                        }
                        if (hed[col] == "Kinh nghiệm làm việc")
                        {
                            writer.WriteExcelAutoStyledCell(item.KinhNghiemLamViec);
                        }
                        if (hed[col] == "Kết quả tuyển dụng")
                        {
                            writer.WriteExcelAutoStyledCell(item.KetQuaTuyenDung);
                        }
                        if (hed[col] == "Nhận xét")
                        {
                            writer.WriteExcelAutoStyledCell(item.NhanXet);
                        }
                    }
                    writer.WriteEndRow();
                }
                // complete writing to excel
                writer.WriteEndWorksheet();
                writer.WriteEndDocument();
            }
            Response.AddHeader("content-disposition", "attachment; filename=HRM_TD_Export.xls");
            Response.ContentType = "application/xls";
            Response.Write(excel.ToString());
            Response.End();
            return RedirectToAction("Index","TuyenDung");
        }

    }
}
