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

namespace HRM.QLTTNhanSu.Views.QHGiaDinh
{
    using System;
    using System.Collections.Generic;
    
    #line 1 "..\..\Views\QHGiaDinh\Index.cshtml"
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
    
    #line 3 "..\..\Views\QHGiaDinh\Index.cshtml"
    using HRM.Databases.Models;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\QHGiaDinh\Index.cshtml"
    using HRM.Webpages.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/QHGiaDinh/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<int>
    {
        public Index()
        {
        }
        public override void Execute()
        {





            
            #line 5 "..\..\Views\QHGiaDinh\Index.cshtml"
  
    ViewBag.Title = "Edit";
    var db = ViewBag.db as HRMDBEntities;
    var dt = db.SqlQuery("select * from dsQHGiaDinh where NV_id=@p0", Model);


            
            #line default
            #line hidden
WriteLiteral("\r\n<table id=\"qhGiaDinh\" class=\"table table-hover table-bordered\">\r\n<thead>\r\n    <" +
"tr>\r\n        <th>\r\n            ");


            
            #line 15 "..\..\Views\QHGiaDinh\Index.cshtml"
       Write(Html.Editor4C("~/QLTTNhanSu/QHGiaDinh/EditP?NV_id=" + Model));

            
            #line default
            #line hidden
WriteLiteral(@"
        </th>
        <th>Mối<br /> quan hệ</th>
        <th>Họ và tên</th>
        <th>Năm sinh</th>
        <th>Nghề nghiệp</th>
        <th>Nơi công tác</th>
        <th>Nơi cư trú</th>
        <th>Mã số<br /> người phụ thuộc</th>
    </tr>
</thead>
<tbody>
");


            
            #line 27 "..\..\Views\QHGiaDinh\Index.cshtml"
 foreach (DataRow dr in dt.Rows)
{

            
            #line default
            #line hidden
WriteLiteral("    <tr>\r\n        <td>\r\n            ");


            
            #line 31 "..\..\Views\QHGiaDinh\Index.cshtml"
       Write(Html.Editor4U("~/QLTTNhanSu/QHGiaDinh/EditP?id=" + dr["id"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 32 "..\..\Views\QHGiaDinh\Index.cshtml"
       Write(Html.Editor4D("~/QLTTNhanSu/QHGiaDinh/DeleteS?id=" + dr["id"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 35 "..\..\Views\QHGiaDinh\Index.cshtml"
       Write(Html.Display(dr, dt.Columns["tenMoiQuanHe"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 38 "..\..\Views\QHGiaDinh\Index.cshtml"
       Write(Html.Display(dr, dt.Columns["HoTen"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 41 "..\..\Views\QHGiaDinh\Index.cshtml"
       Write(Html.Display(dr, dt.Columns["NgaySinh"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 44 "..\..\Views\QHGiaDinh\Index.cshtml"
       Write(Html.Display(dr, dt.Columns["NgheNghiep"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 47 "..\..\Views\QHGiaDinh\Index.cshtml"
       Write(Html.Display(dr, dt.Columns["CoQuan"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 50 "..\..\Views\QHGiaDinh\Index.cshtml"
       Write(Html.Display(dr, dt.Columns["DiaChi"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 53 "..\..\Views\QHGiaDinh\Index.cshtml"
       Write(Html.Display(dr, dt.Columns["MaSoThue"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");


            
            #line 56 "..\..\Views\QHGiaDinh\Index.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("</tbody>\r\n</table>\r\n\r\n<script>\r\n    $(function () {\r\n        $(\"#qhGiaDinh\").find" +
"(\"th,td\").attr(\"nowrap\", true);\r\n    });\r\n</script>\r\n");


        }
    }
}
#pragma warning restore 1591
