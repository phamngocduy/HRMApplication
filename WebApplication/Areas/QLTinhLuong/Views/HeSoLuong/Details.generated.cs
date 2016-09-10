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

namespace HRM.QLTinhLuong.Views.HeSoLuong
{
    using System;
    using System.Collections.Generic;
    
    #line 1 "..\..\Views\HeSoLuong\Details.cshtml"
    using System.Data;
    
    #line default
    #line hidden
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
    
    #line 3 "..\..\Views\HeSoLuong\Details.cshtml"
    using HRM.Databases.Models;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\HeSoLuong\Details.cshtml"
    using HRM.Webpages.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/HeSoLuong/Details.cshtml")]
    public partial class Details : System.Web.Mvc.WebViewPage<int>
    {
        public Details()
        {
        }
        public override void Execute()
        {





            
            #line 5 "..\..\Views\HeSoLuong\Details.cshtml"
  
    ViewBag.Title = "Details";
    var HeSoLuong = "HeSoLuong";
    var GiuBacLuong = "GiuBacLuong";
    var db = ViewBag.db as HRMDBEntities;
    var nv = db.NhanViens.All.Find(Model);
    var dt = db.SqlQuery("select * from dsDienBienLuong where NV_id=@p0 order by NgayBatDau desc", Model);
    var hash = new HashSet<object>();
    var rand = new Random().Next();



            
            #line default
            #line hidden
WriteLiteral("\r\n<p class=\"ui-state-highlight\">\r\n    Diễn biến hệ số lương ");


            
            #line 18 "..\..\Views\HeSoLuong\Details.cshtml"
                     Write(nv.nvSoYeuLyLiches.Single().HoVaTen);

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 19 "..\..\Views\HeSoLuong\Details.cshtml"
Write(nv.nvQTLamViec != null && nv.nvQTLamViec.DonVi != null ? "- " + nv.nvQTLamViec.DonVi.tenDonVi : null);

            
            #line default
            #line hidden
WriteLiteral("\r\n</p>\r\n\r\n<table id=\"");


            
            #line 22 "..\..\Views\HeSoLuong\Details.cshtml"
      Write(rand);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"table table-bordered table-hover\">\r\n<thead class=\"ui-widget-header\">\r\n  " +
"  <tr>\r\n        <th>\r\n            ");


            
            #line 26 "..\..\Views\HeSoLuong\Details.cshtml"
       Write(Html.Editor4C("~/QLTinhLuong/"+HeSoLuong+"/EditP?NV_id=" + Model));

            
            #line default
            #line hidden
WriteLiteral(@"
        </th>
        <th>Giai đoạn</th>
        <th>Nhóm</th>
        <th>Ngạch</th>
        <th>Bậc</th>
        <th><mark data-tip=""Hệ số lương"">HSL</mark></th>
        <th title=""Số quyết định"">QĐ</th>
        <th>Lý do</th>
        <th>Ghi chú</th>
    </tr>
</thead>
<tbody class=""ui-widget-content"">
");


            
            #line 39 "..\..\Views\HeSoLuong\Details.cshtml"
 foreach (DataRow dr in dt.Rows)
{
    if (hash.Add(dr["id"]))
    {

            
            #line default
            #line hidden
WriteLiteral("        <tr style=\"");


            
            #line 43 "..\..\Views\HeSoLuong\Details.cshtml"
               Write(dr["HienTai"].ToString().Equals("1") ? "background:lightblue" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n            <td>\r\n                <button class=\"select\" style=\"width:16px\"><" +
"/button>\r\n                <ul style=\"z-index:1000\">\r\n                    <li>");


            
            #line 47 "..\..\Views\HeSoLuong\Details.cshtml"
                   Write(Html.Link4U("~/QLTinhLuong/"+HeSoLuong+"/EditP?id="+dr["id"], "Edit"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                    <li>");


            
            #line 48 "..\..\Views\HeSoLuong\Details.cshtml"
                   Write(Html.Link4S("~/QLTinhLuong/"+HeSoLuong+"/CurrentS?HSL_id="+dr["id"], "Là hiện tại"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                    <li>");


            
            #line 49 "..\..\Views\HeSoLuong\Details.cshtml"
                   Write(Html.Link4U("~/QLTinhLuong/"+GiuBacLuong+"/EditP?HSL_id="+dr["id"], "Điều chỉnh TG giữ bậc"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                </ul>\r\n            </td>\r\n            <td>\r\n              " +
"  ");


            
            #line 53 "..\..\Views\HeSoLuong\Details.cshtml"
           Write(Html.Display(dr, dt.Columns["NgayBatDau"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <span>-</span><br />\r\n");


            
            #line 55 "..\..\Views\HeSoLuong\Details.cshtml"
             if (dr["NgayKetThuc"] is DBNull) {

            
            #line default
            #line hidden
WriteLiteral("                <span>(</span>\r\n");


            
            #line 57 "..\..\Views\HeSoLuong\Details.cshtml"
                
            
            #line default
            #line hidden
            
            #line 57 "..\..\Views\HeSoLuong\Details.cshtml"
           Write(Html.Display(dr, dt.Columns["KetThucDuKien"]));

            
            #line default
            #line hidden
            
            #line 57 "..\..\Views\HeSoLuong\Details.cshtml"
                                                              

            
            #line default
            #line hidden
WriteLiteral("                <span>)</span>\r\n");


            
            #line 59 "..\..\Views\HeSoLuong\Details.cshtml"
            } else {
                
            
            #line default
            #line hidden
            
            #line 60 "..\..\Views\HeSoLuong\Details.cshtml"
           Write(Html.Display(dr, dt.Columns["NgayKetThuc"]));

            
            #line default
            #line hidden
            
            #line 60 "..\..\Views\HeSoLuong\Details.cshtml"
                                                            
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <mark data-tip=\"");


            
            #line 65 "..\..\Views\HeSoLuong\Details.cshtml"
                           Write(Html.Display(dr, dt.Columns["tenNhomNgachVienChuc"]));

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 65 "..\..\Views\HeSoLuong\Details.cshtml"
                                                                                  Write(Html.Display(dr, dt.Columns["maNhomNgachVienChuc"]));

            
            #line default
            #line hidden
WriteLiteral("</mark>\r\n            </td>\r\n            <td>\r\n                ");


            
            #line 68 "..\..\Views\HeSoLuong\Details.cshtml"
           Write(Html.Display(dr, dt.Columns["tenNgachVienChuc"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");


            
            #line 71 "..\..\Views\HeSoLuong\Details.cshtml"
           Write(Html.Display(dr, dt.Columns["BacLuong"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");


            
            #line 74 "..\..\Views\HeSoLuong\Details.cshtml"
           Write(Html.Display(dr, dt.Columns["HeSoLuong"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");


            
            #line 77 "..\..\Views\HeSoLuong\Details.cshtml"
           Write(Html.Display(dr, dt.Columns["SoQuyetDinh"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");


            
            #line 80 "..\..\Views\HeSoLuong\Details.cshtml"
           Write(Html.Display(dr, dt.Columns["LyDoThayDoi"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");


            
            #line 83 "..\..\Views\HeSoLuong\Details.cshtml"
           Write(Html.Display(dr, dt.Columns["GhiChu"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");


            
            #line 86 "..\..\Views\HeSoLuong\Details.cshtml"
    }
    if (!(dr["G_id"] is DBNull))
    {

            
            #line default
            #line hidden
WriteLiteral("        <tr style=\"background:lightgray;font-style:italic\">\r\n            <td>\r\n  " +
"              ");


            
            #line 91 "..\..\Views\HeSoLuong\Details.cshtml"
           Write(Html.Editor4U("~/QLTinhLuong/"+GiuBacLuong+"/EditP?id=" + dr["G_id"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <span>SQĐ:</span>\r\n       " +
"         ");


            
            #line 95 "..\..\Views\HeSoLuong\Details.cshtml"
           Write(Html.Display(dr, dt.Columns["G_SoQuyetDinh"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n            <td colspan=3>\r\n                ");


            
            #line 98 "..\..\Views\HeSoLuong\Details.cshtml"
           Write(Html.Display(dr, dt.Columns["G_tenLoaiThayDoi"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n            <td colspan=2>\r\n");


            
            #line 101 "..\..\Views\HeSoLuong\Details.cshtml"
              
                var thang = (int)dr["G_SoThangThayDoi"];

            
            #line default
            #line hidden
WriteLiteral("                <span>");


            
            #line 103 "..\..\Views\HeSoLuong\Details.cshtml"
                  Write(thang < 0 ? "Giảm" : "Tăng");

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");



WriteLiteral("                <span>");


            
            #line 104 "..\..\Views\HeSoLuong\Details.cshtml"
                 Write(Math.Abs(thang));

            
            #line default
            #line hidden
WriteLiteral(" tháng</span>\r\n");


            
            #line 105 "..\..\Views\HeSoLuong\Details.cshtml"
            

            
            #line default
            #line hidden
WriteLiteral("            </td>\r\n            <td colspan=2>\r\n                ");


            
            #line 108 "..\..\Views\HeSoLuong\Details.cshtml"
           Write(Html.Display(dr, dt.Columns["G_LyDoThayDoi"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");


            
            #line 111 "..\..\Views\HeSoLuong\Details.cshtml"
    }
}

            
            #line default
            #line hidden
WriteLiteral("</tbody>\r\n</table>\r\n\r\n<script>\r\n    $(function () {\r\n        $(\"#");


            
            #line 118 "..\..\Views\HeSoLuong\Details.cshtml"
       Write(rand);

            
            #line default
            #line hidden
WriteLiteral("\").find(\"th\").attr(\"nowrap\", true);\r\n        $(\"#");


            
            #line 119 "..\..\Views\HeSoLuong\Details.cshtml"
       Write(rand);

            
            #line default
            #line hidden
WriteLiteral(@""").find("".select"").button({
            text: false,
            icons: { primary: ""ui-icon-circle-triangle-s"" }
        }).click(function () {
            var menu = $(this).next().show().position({
                my: ""left top"",
                at: ""left bottom"",
                of: this
            });
            $(document).one(""click"", function () { menu.hide(); });
            return false;
        }).next().hide().menu();
    });
</script>
");


        }
    }
}
#pragma warning restore 1591
