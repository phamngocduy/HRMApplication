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

namespace HRM.QLTTNhanSu.Views.QuaTrinhHoc
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
    
    #line 1 "..\..\Views\QuaTrinhHoc\Index.cshtml"
    using HRM.Webpages.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/QuaTrinhHoc/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<IEnumerable<HRM.Databases.Models.QuaTrinhHoc>>
    {
        public Index()
        {
        }
        public override void Execute()
        {


WriteLiteral("\r\n");


            
            #line 4 "..\..\Views\QuaTrinhHoc\Index.cshtml"
  
    ViewBag.Title = "Index";


            
            #line default
            #line hidden
WriteLiteral("<p>\r\n");


            
            #line 8 "..\..\Views\QuaTrinhHoc\Index.cshtml"
Write(Html.ActionLink("Thêm bậc học", "Create", new { ViewBag.id }, null));

            
            #line default
            #line hidden
WriteLiteral("\r\n</p>\r\n<table id=\"NhanVien1\">\r\n   <thead>\r\n    <tr>\r\n        <th>");


            
            #line 13 "..\..\Views\QuaTrinhHoc\Index.cshtml"
       Write(Html.VN("BacHoc"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n        <th>");


            
            #line 14 "..\..\Views\QuaTrinhHoc\Index.cshtml"
       Write(Html.VN("TruongHoc"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n        <th>");


            
            #line 15 "..\..\Views\QuaTrinhHoc\Index.cshtml"
       Write(Html.VN("NamBatDau"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n        <th>");


            
            #line 16 "..\..\Views\QuaTrinhHoc\Index.cshtml"
       Write(Html.VN("NamKetThuc"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n        <th>");


            
            #line 17 "..\..\Views\QuaTrinhHoc\Index.cshtml"
       Write(Html.VN("GhiChu"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n        <th></th>\r\n    </tr>\r\n</thead>\r\n<tbody>\r\n");


            
            #line 22 "..\..\Views\QuaTrinhHoc\Index.cshtml"
 foreach (var item in Model) {

            
            #line default
            #line hidden
WriteLiteral("    <tr>\r\n        <td>\r\n            ");


            
            #line 25 "..\..\Views\QuaTrinhHoc\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.BacHoc));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 28 "..\..\Views\QuaTrinhHoc\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.TruongHoc));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 31 "..\..\Views\QuaTrinhHoc\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.NamBatDau));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 34 "..\..\Views\QuaTrinhHoc\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.NamKetThuc));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 37 "..\..\Views\QuaTrinhHoc\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.GhiChu));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 40 "..\..\Views\QuaTrinhHoc\Index.cshtml"
       Write(Html.ActionLink("Edit", "Edit", new { id=item.id }));

            
            #line default
            #line hidden
WriteLiteral(" |\r\n            ");


            
            #line 41 "..\..\Views\QuaTrinhHoc\Index.cshtml"
       Write(Html.ActionLink("Details", "Details", new { id=item.id }));

            
            #line default
            #line hidden
WriteLiteral(" |\r\n            ");


            
            #line 42 "..\..\Views\QuaTrinhHoc\Index.cshtml"
       Write(Html.ActionLink("Delete", "Delete", new { id=item.id }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");


            
            #line 45 "..\..\Views\QuaTrinhHoc\Index.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("</tbody>\r\n</table>\r\n<script>\r\n    $(document).ready(function () {\r\n        $(\"#Nh" +
"anVien1\").dataTable();\r\n    });\r\n</script>");


        }
    }
}
#pragma warning restore 1591
