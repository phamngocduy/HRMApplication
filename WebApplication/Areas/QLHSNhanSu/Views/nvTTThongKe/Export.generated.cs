﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRM.QLTTNhanSu.Views.nvTTThongKe
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    
    #line 1 "..\..\Views\nvTTThongKe\Export.cshtml"
    using System.Text;
    
    #line default
    #line hidden
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 4 "..\..\Views\nvTTThongKe\Export.cshtml"
    using HRM.Databases.Models;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\nvTTThongKe\Export.cshtml"
    using HRM.Services;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\nvTTThongKe\Export.cshtml"
    using HRM.Webpages.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/nvTTThongKe/Export.cshtml")]
    public partial class Export : System.Web.Mvc.WebViewPage<dynamic>
    {
        public Export()
        {
        }
        public override void Execute()
        {





            
            #line 5 "..\..\Views\nvTTThongKe\Export.cshtml"
  
    var excel = new StringBuilder();
    using (var writer = new ExcelWriter(excel))
    {
        writer.WriteStartDocument();
        writer.WriteStartWorksheet("Sheet1");

        writer.WriteStartRow();
        writer.WriteExcelUnstyledCell("[MaNV]");
        writer.WriteExcelUnstyledCell("Họ");
        writer.WriteExcelUnstyledCell("Tên");
        writer.WriteExcelUnstyledCell("Họ và tên");
        writer.WriteExcelUnstyledCell("Mã Đơn vị");
        writer.WriteExcelUnstyledCell("Đơn vị");
        writer.WriteExcelUnstyledCell("[PhanLoaiCBGVNV]");
        writer.WriteExcelUnstyledCell("[KhoaGiangDayChinh]");
        writer.WriteExcelUnstyledCell("[KhoaGiangDay]");
        writer.WriteExcelUnstyledCell("[NganhGiangDayChinh]");
        writer.WriteExcelUnstyledCell("[NganhGiangDay]");
        writer.WriteEndRow();

        using (var db = new HRMDBEntities()) {
        foreach (var item in db.nvTTThongKe)
        {
            writer.WriteStartRow();
            writer.WriteExcelAutoStyledCell(item.NhanVien.MaNV);
            var HoTen = item.NhanVien.nvSoYeuLyLiches.Single().HoVaTen.Trim();
            var Ten = HoTen.Trim().Split(' ').Last().Trim();
            writer.WriteExcelAutoStyledCell(HoTen.Substring(0, HoTen.LastIndexOf(Ten)));
            writer.WriteExcelAutoStyledCell(Ten);
            writer.WriteExcelAutoStyledCell(item.NhanVien.nvSoYeuLyLiches.Single().HoVaTen);
            var maDonVis = String.Empty; var tenDonVis = String.Empty;
            /*
            foreach (var donvi in QLTTNhanSu.getDonVisCongTac(db, item.NhanVien.id)) {
                maDonVis = String.Format("{0}{1}{2}", maDonVis,
                         String.IsNullOrEmpty(maDonVis) ? "" : @",&#10;", donvi.maDonVi);
                tenDonVis = String.Format("{0}{1}{2}", tenDonVis,
                         String.IsNullOrEmpty(tenDonVis) ? "" : @",&#10;", donvi.tenDonVi);
            }*/
            writer.WriteExcelRawStyleCell(maDonVis);
            writer.WriteExcelRawStyleCell(tenDonVis);
            writer.WriteExcelAutoStyledCell(item.PhanLoaiCBGVNV.HasValue ? item.dmPhanLoaiCBGVNV.maPhanLoaiCBGVNV : null);
            writer.WriteExcelAutoStyledCell(item.KhoaGiangDayChinh.HasValue ? item.dmKhoaGiangDay.maKhoaGiangDay : null);
            var Khoas = String.Empty;
            foreach (var khoa in item.NhanVien.nvKhoaGiangDays) {
                Khoas = String.Format("{0}{1}{2}", Khoas,
                        String.IsNullOrEmpty(Khoas) ? "" : @",", khoa.dmKhoaGiangDay.maKhoaGiangDay);
            }
            writer.WriteExcelRawStyleCell(Khoas);
            writer.WriteExcelAutoStyledCell(item.NganhGiangDayChinh.HasValue ? item.dmNganhGiangDay.maNganhGiangDay : null);
            var Nganhs = String.Empty;
            foreach (var nganh in item.NhanVien.nvNganhGiangDays) {
                Nganhs = String.Format("{0}{1}{2}", Nganhs,
                        String.IsNullOrEmpty(Nganhs) ? "" : @",", nganh.dmNganhGiangDay.maNganhGiangDay);
            }
            writer.WriteExcelRawStyleCell(Nganhs);
            writer.WriteEndRow();
        } }

        writer.WriteEndWorksheet();
        writer.WriteEndDocument();
    }
    
    Response.AddHeader("content-disposition", "attachment; filename=Book1.xml");
    Response.ContentType = "application/xls";
    Response.Write(excel.ToString());
    Response.End();


            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
