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

namespace HRM.QLTTNhanSu.Views.nvQTHocTap
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    
    #line 1 "..\..\Views\nvQTHocTap\Download.cshtml"
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
    
    #line 3 "..\..\Views\nvQTHocTap\Download.cshtml"
    using HRM.Databases.Models;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\nvQTHocTap\Download.cshtml"
    using HRM.Webpages.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/nvQTHocTap/Download.cshtml")]
    public partial class Download : System.Web.Mvc.WebViewPage<IEnumerable<nvQTHocTap>>
    {
        public Download()
        {
        }
        public override void Execute()
        {




WriteLiteral("{\r\n    var excel = new StringBuilder();\r\n    using (var writer=new ExcelWriter(ex" +
"cel))\r\n    {\r\n        writer.WriteStartDocument();\r\n        writer.WriteStartWor" +
"ksheet(\"Sheet1\");\r\n        writer.WriteStartRow();\r\n        writer.WriteExcelUns" +
"tyledCell(\"Mã NV\");\r\n        writer.WriteExcelUnstyledCell(\"Họ\");\r\n        write" +
"r.WriteExcelUnstyledCell(\"Tên\");\r\n        writer.WriteExcelUnstyledCell(\"Họ và t" +
"ên\");\r\n        writer.WriteExcelUnstyledCell(\"Đơn vị\");\r\n        writer.WriteExc" +
"elUnstyledCell(\"Văn bằng\");\r\n        writer.WriteExcelUnstyledCell(\"Nhóm ngành\")" +
";\r\n        writer.WriteExcelUnstyledCell(\"Chuyên ngành\");\r\n        writer.WriteE" +
"xcelUnstyledCell(\"Tên trường\");\r\n        writer.WriteExcelUnstyledCell(\"Nơi học\"" +
");\r\n        writer.WriteExcelUnstyledCell(\"NN\");\r\n        writer.WriteExcelUnsty" +
"ledCell(\"Loại hình đào tạo\");\r\n        writer.WriteExcelUnstyledCell(\"Số QĐ\");\r\n" +
"        writer.WriteExcelUnstyledCell(\"Ngày cấp QĐ\");\r\n        writer.WriteExcel" +
"UnstyledCell(\"Cam kết\");\r\n        writer.WriteExcelUnstyledCell(\"Chế độ\");\r\n    " +
"    writer.WriteExcelUnstyledCell(\"Thời gian bắt đầu\");\r\n        writer.WriteExc" +
"elUnstyledCell(\"Kết thúc dự kiến\");\r\n        writer.WriteExcelUnstyledCell(\"Kết " +
"thúc chính thức\");\r\n        writer.WriteExcelUnstyledCell(\"Xếp loại tốt nghiệp\")" +
";\r\n        writer.WriteExcelUnstyledCell(\"Học phí\");\r\n        writer.WriteExcelU" +
"nstyledCell(\"Chi phí khác\");\r\n        writer.WriteExcelUnstyledCell(\"Nhà trường " +
"hỗ trợ\");\r\n        writer.WriteExcelUnstyledCell(\"Thưởng hoàn thành\");\r\n        " +
"writer.WriteExcelUnstyledCell(\"Điều chỉnh lương\");\r\n        writer.WriteExcelUns" +
"tyledCell(\"Hiện trạng\");\r\n        writer.WriteExcelUnstyledCell(\"Ghi chú\");\r\n   " +
"     writer.WriteEndRow();\r\n        var D = new Func<Nullable<DateTime>, object>" +
"(d => d.HasValue ? (object)d.Value : null);\r\n        foreach(var item in Model){" +
"\r\n            writer.WriteStartRow();\r\n            writer.WriteExcelAutoStyledCe" +
"ll(item.NhanVien.MaNV);\r\n            var HoTen = item.NhanVien.nvSoYeuLyLiches.S" +
"ingle().HoVaTen.Trim();\r\n            var Ten = HoTen.Trim().Split(\' \').Last().Tr" +
"im();\r\n            writer.WriteExcelAutoStyledCell(HoTen.Substring(0, HoTen.Last" +
"IndexOf(Ten)));\r\n            writer.WriteExcelAutoStyledCell(Ten);\r\n            " +
"writer.WriteExcelAutoStyledCell(item.NhanVien.nvSoYeuLyLiches.Single().HoVaTen.T" +
"rim());\r\n            writer.WriteExcelAutoStyledCell(item.dmDonVi.tenDonVi);\r\n  " +
"          if(item.LoaiBangCap_id.HasValue){\r\n            writer.WriteExcelAutoSt" +
"yledCell(item.dmLoaiBangCap.tenLoaiBangCap);\r\n            }\r\n            else{\r\n" +
"                writer.WriteExcelAutoStyledCell(\"\");\r\n            }\r\n           " +
"  if(item.ChuyenNganh_id.HasValue){\r\n            writer.WriteExcelAutoStyledCell" +
"(item.dmChuyenNganh.TenChuyenNganh);\r\n             }\r\n             else\r\n       " +
"      {\r\n                 writer.WriteExcelAutoStyledCell(\"\");\r\n             }\r\n" +
"            if(item.ChuyenNganh !=null){\r\n            writer.WriteExcelAutoStyle" +
"dCell(item.ChuyenNganh);\r\n            }\r\n            else\r\n            {\r\n      " +
"          writer.WriteExcelAutoStyledCell(\"\");\r\n            }\r\n              if(" +
"item.TenTruong !=null){\r\n            writer.WriteExcelAutoStyledCell(item.TenTru" +
"ong);\r\n              }\r\n              else\r\n              {\r\n                  w" +
"riter.WriteExcelAutoStyledCell(\"\");\r\n              }\r\n            if (item.QuocG" +
"ia_id.HasValue != null)\r\n            {\r\n                writer.WriteExcelAutoSty" +
"ledCell(item.dmQuocGia.tenQuocGia);\r\n            }\r\n            else\r\n          " +
"  {\r\n                writer.WriteExcelAutoStyledCell(\"\");\r\n            }\r\n      " +
"        if(item.NoiHoc_id !=null){\r\n            writer.WriteExcelAutoStyledCell(" +
"item.dmNoiHoc.tenNoiHoc);\r\n              }\r\n              else\r\n              {\r" +
"\n                  writer.WriteExcelAutoStyledCell(\"\");\r\n              }\r\n      " +
"        if(item.LoaiHinhDaoTao_id.HasValue){\r\n            writer.WriteExcelAutoS" +
"tyledCell(item.dmLoaiHinhDaoTao.tenLoaiHinhDaoTao);\r\n              }\r\n          " +
"    else\r\n              {\r\n                  writer.WriteExcelAutoStyledCell(\"\")" +
";\r\n              }\r\n              if(item.SoQuyetDinh !=null){\r\n            writ" +
"er.WriteExcelAutoStyledCell(item.SoQuyetDinh);\r\n              }\r\n              e" +
"lse\r\n              {\r\n                  writer.WriteExcelAutoStyledCell(\"\");\r\n  " +
"            }\r\n              if(item.NgayCapQuyetDinh !=null){\r\n            writ" +
"er.WriteExcelAutoStyledCell(item.NgayCapQuyetDinh);\r\n              }\r\n          " +
"    else\r\n              {\r\n                  writer.WriteExcelAutoStyledCell(\"\")" +
";\r\n              }\r\n              if(item.CamKet !=null){\r\n            writer.Wr" +
"iteExcelAutoStyledCell(item.CamKet);\r\n              }\r\n              else\r\n     " +
"         {\r\n                  writer.WriteExcelAutoStyledCell(\"\");\r\n            " +
"  }\r\n              if(item.CheDo_id.HasValue){\r\n            writer.WriteExcelAut" +
"oStyledCell(item.dmCheDoHoc.TenCheDo);\r\n              }\r\n              else\r\n   " +
"           {\r\n                  writer.WriteExcelAutoStyledCell(\"\");\r\n          " +
"    }\r\n              if(item.BatDau !=null){\r\n            writer.WriteExcelAutoS" +
"tyledCell(item.BatDau.Value.ToShortDateString());\r\n              }\r\n            " +
"  else\r\n              {\r\n                  writer.WriteExcelAutoStyledCell(\"\");\r" +
"\n              }\r\n              if(item.KetThucDuKien !=null){\r\n            writ" +
"er.WriteExcelAutoStyledCell(item.KetThucDuKien.Value.ToShortDateString());\r\n    " +
"          }\r\n              else\r\n              {\r\n                  writer.Write" +
"ExcelAutoStyledCell(\"\");\r\n              }\r\n              if(item.KetThucChinhThu" +
"c !=null){\r\n            writer.WriteExcelAutoStyledCell(item.KetThucChinhThuc.Va" +
"lue.ToShortDateString());\r\n              }\r\n              else\r\n              {\r" +
"\n                  writer.WriteExcelAutoStyledCell(\"\");\r\n              }\r\n      " +
"        if(item.XepLoaiTotNghiep_id.HasValue){\r\n            writer.WriteExcelAut" +
"oStyledCell(item.dmXepLoaiTotNghiep.tenXepLoaiTotNghiep);\r\n              }\r\n    " +
"          else\r\n              {\r\n                  writer.WriteExcelAutoStyledCe" +
"ll(\"\");\r\n              }\r\n              if(item.HocPhi !=null){\r\n            wri" +
"ter.WriteExcelAutoStyledCell(item.HocPhi);\r\n              }\r\n              else\r" +
"\n              {\r\n                  writer.WriteExcelAutoStyledCell(\"\");\r\n      " +
"        }\r\n              if(item.KinhPhiKhac !=null){\r\n            writer.WriteE" +
"xcelAutoStyledCell(item.KinhPhiKhac);\r\n              }\r\n              else\r\n    " +
"          {\r\n                  writer.WriteExcelAutoStyledCell(\"\");\r\n           " +
"   }\r\n              if(item.KinhPhiHoTro !=null){\r\n            writer.WriteExcel" +
"AutoStyledCell(item.KinhPhiHoTro);\r\n              }\r\n              else\r\n       " +
"       {\r\n                  writer.WriteExcelAutoStyledCell(\"\");\r\n              " +
"}\r\n              if(item.ThuongHoanThanh !=null){\r\n            writer.WriteExcel" +
"AutoStyledCell(item.ThuongHoanThanh);\r\n              }\r\n              else\r\n    " +
"          {\r\n                  writer.WriteExcelAutoStyledCell(\"\");\r\n           " +
"   }\r\n            if(item.DieuChinhLuong==true)\r\n            {\r\n                " +
"writer.WriteExcelAutoStyledCell(\"x\");\r\n            }\r\n            else{\r\n       " +
"         writer.WriteExcelAutoStyledCell(\"\");\r\n            }\r\n              if(i" +
"tem.HienTrang_id.HasValue){\r\n            writer.WriteExcelAutoStyledCell(item.dm" +
"HienTrangDiHoc.TenHienTrang);\r\n              }\r\n              else\r\n            " +
"  {\r\n                  writer.WriteExcelAutoStyledCell(\"\");\r\n              }\r\n  " +
"            if(item.GhiChu !=null){\r\n            writer.WriteExcelAutoStyledCell" +
"(item.GhiChu);\r\n              }\r\n              else\r\n              {\r\n          " +
"        writer.WriteExcelAutoStyledCell(\"\");\r\n              }\r\n            write" +
"r.WriteEndRow();\r\n    }\r\n    writer.WriteEndWorksheet();\r\n    writer.WriteEndDoc" +
"ument();\r\n    }\r\n\r\n    Response.AddHeader(\"content-disposition\", \"attachment; fi" +
"lename=Book1.xls\");\r\n    Response.ContentType = \"application/ms-excel\";\r\n    Res" +
"ponse.Write(excel.ToString());\r\n    Response.End();\r\n    }\r\n");


        }
    }
}
#pragma warning restore 1591