﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRM.QLTTNhanSu.Views.QLThuViec
{
    using System;
    using System.Collections.Generic;
    
    #line 1 "..\..\Views\QLThuViec\Index.cshtml"
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
    
    #line 3 "..\..\Views\QLThuViec\Index.cshtml"
    using HRM.Databases.Models;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\QLThuViec\Index.cshtml"
    using HRM.Webpages.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/QLThuViec/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<dynamic>
    {
        public Index()
        {
        }
        public override void Execute()
        {




            
            #line 4 "..\..\Views\QLThuViec\Index.cshtml"
  
    const string LOC = "loc", ALL = "ALL";
    ViewBag.Title = "Index";
    var db = ViewBag.db as HRMDBEntities;
    var query = "select * from dsQLThuViec ";
    if (Request.QueryString[LOC] != ALL) {
        //query += "where ThoiGianKetThuc is not null and MaNV is not null";
        query += "where ThoiGianKetThuc is not null and MaNV is null";
    }
    var dt = db.SqlQuery(query);
    var rand = new Random().Next();


            
            #line default
            #line hidden
WriteLiteral("\r\n<p class=\"ui-state-highlight\">\r\n    Danh sách nhân viên thử việc trường ĐHDL Vă" +
"n Lang\r\n    <span style=\"float:right\">\r\n        <input type=\"checkbox\" id=\"");


            
            #line 20 "..\..\Views\QLThuViec\Index.cshtml"
                              Write(LOC);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n            ");


            
            #line 21 "..\..\Views\QLThuViec\Index.cshtml"
        Write(Request.QueryString[LOC] == ALL ? "checked" : null);

            
            #line default
            #line hidden
WriteLiteral(" />\r\n        Hiển thị tất cả...\r\n    </span>\r\n</p>\r\n\r\n<table id=\"");


            
            #line 26 "..\..\Views\QLThuViec\Index.cshtml"
      Write(rand);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"table table-bordered table-hover\">\r\n<thead class=\"ui-widget-header\">\r\n  " +
"  <tr>\r\n        <th>\r\n            ");


            
            #line 30 "..\..\Views\QLThuViec\Index.cshtml"
       Write(Html.Editor4C("~/QLTTNhanSu/QLThuViec/EditP"));

            
            #line default
            #line hidden
WriteLiteral(@"
        </th>
        <th>Họ và tên</th>
        <th>Đơn vị</th>
        <th>Vị trí<br />công tác</th>
        <th>Thời gian<br />bắt đầu</th>
        <th>Thời gian<br />đến hạn</th>
        <th><mark data-tip=""Số ngày làm việc"">N</mark></th>
        <th>Ngày<br />thông báo</th>
        <th>Ngày nhận<br />hồ sơ</th>
        <th>Ngày lập<br />tờ trình</th>
    </tr>
</thead>
<tbody class=""ui-widget-content"">
");


            
            #line 44 "..\..\Views\QLThuViec\Index.cshtml"
 foreach (DataRow dr in dt.Rows)
{

            
            #line default
            #line hidden
WriteLiteral("    <tr>\r\n        <td>\r\n            <button class=\"select\" style=\"width:16px\"></b" +
"utton>\r\n            <ul style=\"z-index:1000\">\r\n                <li>");


            
            #line 50 "..\..\Views\QLThuViec\Index.cshtml"
               Write(Html.Link4U("~/QLTTNhanSu/QLThuViec/EditP?id=" + dr["id"], "Edit"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                <li>");


            
            #line 51 "..\..\Views\QLThuViec\Index.cshtml"
               Write(Html.Link4D("~/QLTTNhanSu/QLThuViec/DeleteS?id=" + dr["id"], "Delete"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                <li>");


            
            #line 52 "..\..\Views\QLThuViec\Index.cshtml"
               Write(Html.Link4U("~/QLTTNhanSu/QLThuViec/EditNOP?id=" + dr["id"], "Không hoàn thành"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                <li>");


            
            #line 53 "..\..\Views\QLThuViec\Index.cshtml"
               Write(Html.Link4U("~/QLTTNhanSu/QLThuViec/EditOKP?id=" + dr["id"], "Hoàn thành thử việc"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n            </ul>\r\n        </td>\r\n        <td>\r\n");


            
            #line 57 "..\..\Views\QLThuViec\Index.cshtml"
              
                var span = !(dr["MaNV"] is DBNull) ? "strong"
                    //: ((!dr["ThoiGianKetThuc"] is DBNull) ? "strike" : "span");
                     : ((dr["ThoiGianKetThuc"] is DBNull) ? "strike" : "span");
            

            
            #line default
            #line hidden
WriteLiteral("            ");


            
            #line 62 "..\..\Views\QLThuViec\Index.cshtml"
       Write(Html.Raw(String.Format("<{0}>", span)));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 63 "..\..\Views\QLThuViec\Index.cshtml"
       Write(Html.Display(dr, dt.Columns["HoVaTen"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 64 "..\..\Views\QLThuViec\Index.cshtml"
       Write(Html.Raw(String.Format("</{0}>", span)));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            <mark data-tip=\"");


            
            #line 67 "..\..\Views\QLThuViec\Index.cshtml"
                       Write(Html.Display(dr, dt.Columns["tenDonVi"]));

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 67 "..\..\Views\QLThuViec\Index.cshtml"
                                                                  Write(Html.Display(dr, dt.Columns["maDonVi"]));

            
            #line default
            #line hidden
WriteLiteral("</mark>\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 70 "..\..\Views\QLThuViec\Index.cshtml"
       Write(Html.Display(dr, dt.Columns["tenChucDanhChuyenMon"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 73 "..\..\Views\QLThuViec\Index.cshtml"
       Write(Html.Display(dr, dt.Columns["ThoiGianBatDau"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            <b>");


            
            #line 76 "..\..\Views\QLThuViec\Index.cshtml"
          Write(Html.Display(dr, dt.Columns["ThoiGianDenHan"]));

            
            #line default
            #line hidden
WriteLiteral("</b>\r\n        </td>\r\n        <td>\r\n            <mark data-tip=\"(ngày)\">");


            
            #line 79 "..\..\Views\QLThuViec\Index.cshtml"
                               Write(Html.Display(dr, dt.Columns["SoNgayLamViec"]));

            
            #line default
            #line hidden
WriteLiteral("</mark>\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 82 "..\..\Views\QLThuViec\Index.cshtml"
       Write(Html.Display(dr, dt.Columns["NgayThongBao"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 85 "..\..\Views\QLThuViec\Index.cshtml"
       Write(Html.Display(dr, dt.Columns["NgayNhanHoSo"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 88 "..\..\Views\QLThuViec\Index.cshtml"
       Write(Html.Display(dr, dt.Columns["NgayLapToTrinh"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");


            
            #line 91 "..\..\Views\QLThuViec\Index.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("</tbody>\r\n</table>\r\n\r\n<script>\r\n    $(function () {\r\n        $(\"#");


            
            #line 97 "..\..\Views\QLThuViec\Index.cshtml"
       Write(rand);

            
            #line default
            #line hidden
WriteLiteral("\").find(\"th\").attr(\"nowrap\", true);\r\n        $(\"#");


            
            #line 98 "..\..\Views\QLThuViec\Index.cshtml"
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
        $(""#");


            
            #line 110 "..\..\Views\QLThuViec\Index.cshtml"
       Write(LOC);

            
            #line default
            #line hidden
WriteLiteral("\").change(function () {\r\n            location = \"");


            
            #line 111 "..\..\Views\QLThuViec\Index.cshtml"
                   Write(Url.Action("Index", "QLThuViec"));

            
            #line default
            #line hidden
WriteLiteral("\" + \"?");


            
            #line 111 "..\..\Views\QLThuViec\Index.cshtml"
                                                           Write(LOC);

            
            #line default
            #line hidden
WriteLiteral("=\" + (this.checked ? \"");


            
            #line 111 "..\..\Views\QLThuViec\Index.cshtml"
                                                                                      Write(ALL);

            
            #line default
            #line hidden
WriteLiteral("\" : \"NOW\");\r\n        });\r\n    });\r\n</script>\r\n");


        }
    }
}
#pragma warning restore 1591
