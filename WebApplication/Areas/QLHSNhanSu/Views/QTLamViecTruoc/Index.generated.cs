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

namespace HRM.QLTTNhanSu.Views.QTLamViecTruoc
{
    using System;
    using System.Collections.Generic;
    
    #line 1 "..\..\Views\QTLamViecTruoc\Index.cshtml"
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
    
    #line 3 "..\..\Views\QTLamViecTruoc\Index.cshtml"
    using HRM.Databases.Models;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\QTLamViecTruoc\Index.cshtml"
    using HRM.Webpages.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/QTLamViecTruoc/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<int>
    {
        public Index()
        {
        }
        public override void Execute()
        {





            
            #line 5 "..\..\Views\QTLamViecTruoc\Index.cshtml"
  
    ViewBag.Title = "Edit";
    var action = "QTLamViecTruoc";
    var db = ViewBag.db as HRMDBEntities;
    var dt = db.SqlQuery("select * from nvQTLamViecTruoc where NV_id=@p0", Model);
    var rand = new Random();
    var rand1 = rand.Next();
    var rand2 = rand.Next();
    var ThamNienGiangDayT = "qtlvThamNienGiangDayT";


            
            #line default
            #line hidden
WriteLiteral("\r\n<table id=\"");


            
            #line 16 "..\..\Views\QTLamViecTruoc\Index.cshtml"
      Write(rand1);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"table table-hover table-bordered\" style=\"margin:0\">\r\n<thead>\r\n    <tr>\r\n" +
"        <th>\r\n            ");


            
            #line 20 "..\..\Views\QTLamViecTruoc\Index.cshtml"
       Write(Html.Editor4C("~/QLTTNhanSu/"+action+"/EditP?NV_id=" + Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </th>\r\n        <th colspan=2>Thời gian</th>\r\n        <th>Đơn vị công tá" +
"c</th>\r\n        <th>Chức danh/chức vụ</th>\r\n        <th>Ghi chú</th>\r\n    </tr>\r" +
"\n</thead>\r\n<tbody>\r\n");


            
            #line 29 "..\..\Views\QTLamViecTruoc\Index.cshtml"
 foreach (DataRow dr in dt.Rows)
{

            
            #line default
            #line hidden
WriteLiteral("    <tr>\r\n        <td>\r\n            ");


            
            #line 33 "..\..\Views\QTLamViecTruoc\Index.cshtml"
       Write(Html.Editor4U("~/QLTTNhanSu/"+action+"/EditP?id=" + dr["id"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 34 "..\..\Views\QTLamViecTruoc\Index.cshtml"
       Write(Html.Editor4D("~/QLTTNhanSu/"+action+"/DeleteS?id=" + dr["id"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 37 "..\..\Views\QTLamViecTruoc\Index.cshtml"
       Write(Html.Display(dr, dt.Columns["ThoiGianBatDau"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 40 "..\..\Views\QTLamViecTruoc\Index.cshtml"
       Write(Html.Display(dr, dt.Columns["ThoiGianKetThuc"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 43 "..\..\Views\QTLamViecTruoc\Index.cshtml"
       Write(Html.Display(dr, dt.Columns["DonViCongTac"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 46 "..\..\Views\QTLamViecTruoc\Index.cshtml"
       Write(Html.Display(dr, dt.Columns["ChucDanhChucVu"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 49 "..\..\Views\QTLamViecTruoc\Index.cshtml"
       Write(Html.Display(dr, dt.Columns["GhiChu"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");


            
            #line 52 "..\..\Views\QTLamViecTruoc\Index.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("</tbody>\r\n</table>\r\n\r\n");


            
            #line 56 "..\..\Views\QTLamViecTruoc\Index.cshtml"
 using (Html.BeginForm("UpdateThamNien", "QTLamViecTruoc"))
{
    dt = db.SqlQuery("select * from NhanVien where id=@p0", Model);
    var dr = dt.Rows[0];
    
            
            #line default
            #line hidden
            
            #line 60 "..\..\Views\QTLamViecTruoc\Index.cshtml"
Write(Html.Hidden("id", dr["id"]));

            
            #line default
            #line hidden
            
            #line 60 "..\..\Views\QTLamViecTruoc\Index.cshtml"
                                
    var ThamNien = int.Parse(dr[ThamNienGiangDayT].ToString());

            
            #line default
            #line hidden
WriteLiteral("<table id=\"");


            
            #line 62 "..\..\Views\QTLamViecTruoc\Index.cshtml"
      Write(rand2);

            
            #line default
            #line hidden
WriteLiteral("\"><tr><td>\r\n    <label style=\"display:inline\">Thâm niêm giảng dạy: </label>\r\n    " +
"");


            
            #line 64 "..\..\Views\QTLamViecTruoc\Index.cshtml"
Write(Html.TextBox("YEAR", ThamNien / 12, new { type = "number", style = "width:50px" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <span>(năm)</span>\r\n    ");


            
            #line 66 "..\..\Views\QTLamViecTruoc\Index.cshtml"
Write(Html.TextBox("MONTH", ThamNien % 12, new { type = "number", style = "width:50px" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <span>(tháng)</span>\r\n    ");


            
            #line 68 "..\..\Views\QTLamViecTruoc\Index.cshtml"
Write(Html.Hidden(ThamNienGiangDayT, ThamNien));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <input type=\"submit\" value=\"Cập nhật\" />\r\n</td></tr></table>\r\n");


            
            #line 71 "..\..\Views\QTLamViecTruoc\Index.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<script>\r\n    $(function () {\r\n        $(\"#");


            
            #line 75 "..\..\Views\QTLamViecTruoc\Index.cshtml"
       Write(rand1);

            
            #line default
            #line hidden
WriteLiteral("\").find(\"th,td\").attr(\"nowrap\", true);\r\n        $(\"#");


            
            #line 76 "..\..\Views\QTLamViecTruoc\Index.cshtml"
       Write(rand2);

            
            #line default
            #line hidden
WriteLiteral("\").find(\"input[type=submit]\").click(function () {\r\n            var form = $(this)" +
".parents(\"form\");\r\n            var year = parseInt(form.find(\"#YEAR\").val());\r\n " +
"           var month = parseInt(form.find(\"#MONTH\").val());\r\n            form.fi" +
"nd(\"#");


            
            #line 80 "..\..\Views\QTLamViecTruoc\Index.cshtml"
                   Write(ThamNienGiangDayT);

            
            #line default
            #line hidden
WriteLiteral("\").val(year * 12 + month);\r\n        });\r\n    });\r\n</script>\r\n");


        }
    }
}
#pragma warning restore 1591