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

namespace HRM.QLVayMuon.Views.NhanVienVayMuon
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 2 "..\..\Views\NhanVienVayMuon\Details.cshtml"
    using HRM.QLVayMuon.Models;
    
    #line default
    #line hidden
    
    #line 1 "..\..\Views\NhanVienVayMuon\Details.cshtml"
    using HRM.Webpages.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/NhanVienVayMuon/Details.cshtml")]
    public partial class Details : System.Web.Mvc.WebViewPage<IEnumerable<HRM.QLVayMuon.Models.ChiTietVayMuon>>
    {
        public Details()
        {
        }
        public override void Execute()
        {



WriteLiteral("\r\n");


            
            #line 5 "..\..\Views\NhanVienVayMuon\Details.cshtml"
  
    ViewBag.Title = "Details";
    var db = new HRMDB1Entities();
    var NV_id = (int)ViewBag.NV_id;


            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\r\n");


            
            #line 13 "..\..\Views\NhanVienVayMuon\Details.cshtml"
Write(Html.ActionLink("Trở về danh sách nhân viên vay mượn", "index"));

            
            #line default
            #line hidden
WriteLiteral("\r\n<h3 align=center><font>Chi Tiết Vay Mượn</font></h3>\r\n\r\n\r\n<table id=\"ThongTinCh" +
"ung\" align=center >\r\n<tr >\r\n<td>Đơn vị: </td>\r\n<td><b> ");


            
            #line 20 "..\..\Views\NhanVienVayMuon\Details.cshtml"
   Write(db.NhanVienVayMuon.FirstOrDefault(kv => kv.id == NV_id).DonVi);

            
            #line default
            #line hidden
WriteLiteral(" </b></td>\r\n</tr>\r\n<tr>\r\n<td>Họ và tên:  </td>\r\n<td><b>");


            
            #line 24 "..\..\Views\NhanVienVayMuon\Details.cshtml"
  Write(db.NhanVienVayMuon.FirstOrDefault(kv => kv.id == NV_id).HoVaTen);

            
            #line default
            #line hidden
WriteLiteral("</b></td>\r\n</tr>\r\n\r\n<tr>\r\n<td>Mã nhân viên:  </td>\r\n<td><b>");


            
            #line 29 "..\..\Views\NhanVienVayMuon\Details.cshtml"
  Write(db.NhanVienVayMuon.FirstOrDefault(kv => kv.id == NV_id).MaNV);

            
            #line default
            #line hidden
WriteLiteral("</b></td>\r\n</tr>\r\n\r\n<tr>\r\n<td>Tổng số tiền vay: </td>\r\n<td><b>    ");


            
            #line 34 "..\..\Views\NhanVienVayMuon\Details.cshtml"
      Write(String.Format("{0:#,##0}",@db.NhanVienVayMuon.FirstOrDefault(kv => kv.id == NV_id).TongSoTienVay));

            
            #line default
            #line hidden
WriteLiteral("</b></td>\r\n</tr>\r\n\r\n<tr>\r\n<td> Tổng số tiền hoàn:</td>\r\n<td><b>    ");


            
            #line 39 "..\..\Views\NhanVienVayMuon\Details.cshtml"
      Write(String.Format("{0:#,##0}",@db.NhanVienVayMuon.FirstOrDefault(kv => kv.id == NV_id).TongSoTienHoan));

            
            #line default
            #line hidden
WriteLiteral("</b> </td>\r\n</tr>\r\n\r\n<tr>\r\n<td> Tổng số tiền lãi: </td>\r\n<td><b>     ");


            
            #line 44 "..\..\Views\NhanVienVayMuon\Details.cshtml"
       Write(String.Format("{0:#,##0}",@db.NhanVienVayMuon.FirstOrDefault(kv => kv.id == NV_id).TongSoTienLai));

            
            #line default
            #line hidden
WriteLiteral("</b></td>\r\n</tr>\r\n\r\n<tr>\r\n<td>Số dư nợ cuối kì: </td>\r\n<td><b>    ");


            
            #line 49 "..\..\Views\NhanVienVayMuon\Details.cshtml"
      Write(String.Format("{0:#,##0}", @db.NhanVienVayMuon.FirstOrDefault(kv => kv.id == NV_id).SoDuNoCuoiKy));

            
            #line default
            #line hidden
WriteLiteral("</b></td>\r\n</tr>\r\n\r\n<tr>\r\n<td width =\"200\">Số tháng còn lại phải trả:</td>\r\n<td w" +
"idth =\"200\"><b> ");


            
            #line 54 "..\..\Views\NhanVienVayMuon\Details.cshtml"
                Write(db.NhanVienVayMuon.FirstOrDefault(kv => kv.id == NV_id).SoThangConLaiPhaiTra);

            
            #line default
            #line hidden
WriteLiteral("</b></td>\r\n</tr>\r\n\r\n</table>\r\n\r\n\r\n\r\n\r\n<table id = \"VayMuonChiTiet\">\r\n<thead>\r\n   " +
" <tr>\r\n        <th>");


            
            #line 65 "..\..\Views\NhanVienVayMuon\Details.cshtml"
       Write(Html.VN("ID khoản vay"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n        <th>");


            
            #line 66 "..\..\Views\NhanVienVayMuon\Details.cshtml"
       Write(Html.VN("Số chứng từ"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n        <th>");


            
            #line 67 "..\..\Views\NhanVienVayMuon\Details.cshtml"
       Write(Html.VN("Ngày chứng từ"));

            
            #line default
            #line hidden
WriteLiteral("</th>       \r\n        <th>");


            
            #line 68 "..\..\Views\NhanVienVayMuon\Details.cshtml"
       Write(Html.VN("Diễn giải"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n        <th>");


            
            #line 69 "..\..\Views\NhanVienVayMuon\Details.cshtml"
       Write(Html.VN("Mục đích sử dụng"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n        <th>");


            
            #line 70 "..\..\Views\NhanVienVayMuon\Details.cshtml"
       Write(Html.VN("Định mức"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n        <th>");


            
            #line 71 "..\..\Views\NhanVienVayMuon\Details.cshtml"
       Write(Html.VN("Số tiền vay"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n        <th>");


            
            #line 72 "..\..\Views\NhanVienVayMuon\Details.cshtml"
       Write(Html.VN("Số tiền hoàn"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n        <th>");


            
            #line 73 "..\..\Views\NhanVienVayMuon\Details.cshtml"
       Write(Html.VN("Số tiền lãi"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n    </tr>\r\n</thead>\r\n  <tbody>\r\n  \r\n");


            
            #line 78 "..\..\Views\NhanVienVayMuon\Details.cshtml"
 foreach (var item in Model) {

            
            #line default
            #line hidden
WriteLiteral("    <tr>\r\n    \r\n         <td>\r\n  \r\n            ");


            
            #line 83 "..\..\Views\NhanVienVayMuon\Details.cshtml"
       Write(Html.DisplayFor(modelItem => item.idVm));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 86 "..\..\Views\NhanVienVayMuon\Details.cshtml"
       Write(Html.DisplayFor(modelItem => item.SoChungTu));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 89 "..\..\Views\NhanVienVayMuon\Details.cshtml"
       Write(item.NgayChungTu.ToShortDateString());

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n         \r\n        <td>\r\n            ");


            
            #line 93 "..\..\Views\NhanVienVayMuon\Details.cshtml"
       Write(Html.DisplayFor(modelItem => item.DienGiai));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n         <td>\r\n            ");


            
            #line 96 "..\..\Views\NhanVienVayMuon\Details.cshtml"
       Write(Html.DisplayFor(modelItem => item.dmMucDichSuDung.TenMucDich));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n         <td disabled=\"disabled\" >\r\n");


            
            #line 99 "..\..\Views\NhanVienVayMuon\Details.cshtml"
                 if (item.Dinhmuc == true)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <span >\r\n                    Định mức\r\n                    </" +
"span>\r\n");


            
            #line 104 "..\..\Views\NhanVienVayMuon\Details.cshtml"
                }

            
            #line default
            #line hidden

            
            #line 105 "..\..\Views\NhanVienVayMuon\Details.cshtml"
                 if (item.Dinhmuc == false)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <span >\r\n                    Ngoài định mức\r\n                " +
"    </span>\r\n");


            
            #line 110 "..\..\Views\NhanVienVayMuon\Details.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            \r\n        </td>\r\n        <td>\r\n          \r\n             ");


            
            #line 115 "..\..\Views\NhanVienVayMuon\Details.cshtml"
        Write(String.Format("{0:#,##0}", item.SoTienVay));

            
            #line default
            #line hidden
WriteLiteral("\r\n      \r\n        </td>\r\n         <td>\r\n              ");


            
            #line 119 "..\..\Views\NhanVienVayMuon\Details.cshtml"
         Write(String.Format("{0:#,##0}", item.SotienHoan));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n               ");


            
            #line 122 "..\..\Views\NhanVienVayMuon\Details.cshtml"
          Write(String.Format("{0:#,##0}",item.SotienLai));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>   \r\n    </tr>\r\n");


            
            #line 125 "..\..\Views\NhanVienVayMuon\Details.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("  \r\n</tbody>\r\n</table>\r\n\r\n");



WriteLiteral("\r\n<script>\r\n    $(document).ready(function () {\r\n        $(\"#VayMuonChiTiet\").dat" +
"aTable({\r\n            \"bAutoWidth\": true,\r\n            \"bStateSave\": true,\r\n    " +
"        \"aLengthMenu\": [[10, 25, 50, -1], [10, 25, 50, \"All\"]]\r\n        });\r\n   " +
"    \r\n        \r\n\r\n       \r\n    });\r\n\r\n\r\n\r\n//    $(document).ready(function () {\r" +
"\n\r\n//        function exportTableToCSV($table, filename) {\r\n\r\n//            var " +
"$rows = $table.find(\'tr:has(td)\'),\r\n\r\n//            // Temporary delimiter chara" +
"cters unlikely to be typed by keyboard\r\n//            // This is to avoid accide" +
"ntally splitting the actual contents\r\n//            tmpColDelim = String.fromCha" +
"rCode(11), // vertical tab character\r\n//            tmpRowDelim = String.fromCha" +
"rCode(0), // null character\r\n\r\n//            // actual delimiter characters for " +
"CSV format\r\n//            colDelim = \'\",\"\',\r\n//            rowDelim = \'\"\\r\\n\"\',\r" +
"\n\r\n//            // Grab text from table into CSV formatted string\r\n//          " +
"  csv = \'\"\' + $rows.map(function (i, row) {\r\n//                var $row = $(row)" +
",\r\n//                    $cols = $row.find(\'td\');\r\n\r\n//                return $c" +
"ols.map(function (j, col) {\r\n//                    var $col = $(col),\r\n//       " +
"                 text = $col.text();\r\n\r\n//                    return text.replac" +
"e(\'\"\', \'\"\"\'); // escape double quotes\r\n\r\n//                }).get().join(tmpColD" +
"elim);\r\n\r\n//            }).get().join(tmpRowDelim)\r\n//                .split(tmp" +
"RowDelim).join(rowDelim)\r\n//                .split(tmpColDelim).join(colDelim) +" +
" \'\"\',\r\n\r\n//            // Data URI\r\n//            csvData = \'data:application/cs" +
"v;charset=utf-8,\' + encodeURIComponent(csv);\r\n\r\n//            $(this)\r\n//       " +
"     .attr({\r\n//                \'download\': filename,\r\n//                \'href\':" +
" csvData,\r\n//                \'target\': \'_blank\'\r\n//            });\r\n//        }\r" +
"\n\r\n//        // This must be a hyperlink\r\n//        $(\".export\").on(\'click\', fun" +
"ction (event) {\r\n//            // CSV\r\n//            exportTableToCSV.apply(this" +
", [$(\'#VayMuonChiTiet>table\'), \'export.xls\']);\r\n\r\n//            // IF CSV, don\'t" +
" do event.preventDefault() or return false\r\n//            // We actually need th" +
"is to be a typical hyperlink\r\n//        });\r\n//    });\r\n\r\n \r\n</script>");


        }
    }
}
#pragma warning restore 1591
