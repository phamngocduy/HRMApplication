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

namespace HRM.QLTTNhanSu.Views.DanhHieu
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DanhHieu/Details.cshtml")]
    public partial class Details : System.Web.Mvc.WebViewPage<HRM.Databases.Models.DanhHieu>
    {
        public Details()
        {
        }
        public override void Execute()
        {

WriteLiteral("\r\n");


            
            #line 3 "..\..\Views\DanhHieu\Details.cshtml"
  
    ViewBag.Title = "Details";


            
            #line default
            #line hidden
WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<fieldset>\r\n    <legend>DanhHieu</legend>\r\n\r\n    <div class" +
"=\"display-label\">\r\n         ");


            
            #line 13 "..\..\Views\DanhHieu\Details.cshtml"
    Write(Html.DisplayNameFor(model => model.NhanVien.MaNV));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div class=\"display-field\">\r\n        ");


            
            #line 16 "..\..\Views\DanhHieu\Details.cshtml"
   Write(Html.DisplayFor(model => model.NhanVien.MaNV));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"display-label\">\r\n         ");


            
            #line 20 "..\..\Views\DanhHieu\Details.cshtml"
    Write(Html.DisplayNameFor(model => model.dmDanhHieu.tenDanhHieu));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div class=\"display-field\">\r\n        ");


            
            #line 23 "..\..\Views\DanhHieu\Details.cshtml"
   Write(Html.DisplayFor(model => model.dmDanhHieu.tenDanhHieu));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"display-label\">\r\n         ");


            
            #line 27 "..\..\Views\DanhHieu\Details.cshtml"
    Write(Html.DisplayNameFor(model => model.NgayDatDanhHieu));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div class=\"display-field\">\r\n        ");


            
            #line 30 "..\..\Views\DanhHieu\Details.cshtml"
   Write(Html.DisplayFor(model => model.NgayDatDanhHieu));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"display-label\">\r\n         ");


            
            #line 34 "..\..\Views\DanhHieu\Details.cshtml"
    Write(Html.DisplayNameFor(model => model.SoQDCongNhan));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div class=\"display-field\">\r\n        ");


            
            #line 37 "..\..\Views\DanhHieu\Details.cshtml"
   Write(Html.DisplayFor(model => model.SoQDCongNhan));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"display-label\">\r\n         ");


            
            #line 41 "..\..\Views\DanhHieu\Details.cshtml"
    Write(Html.DisplayNameFor(model => model.NoiCap));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div class=\"display-field\">\r\n        ");


            
            #line 44 "..\..\Views\DanhHieu\Details.cshtml"
   Write(Html.DisplayFor(model => model.NoiCap));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"display-label\">\r\n         ");


            
            #line 48 "..\..\Views\DanhHieu\Details.cshtml"
    Write(Html.DisplayNameFor(model => model.GhiChu));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div class=\"display-field\">\r\n        ");


            
            #line 51 "..\..\Views\DanhHieu\Details.cshtml"
   Write(Html.DisplayFor(model => model.GhiChu));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</fieldset>\r\n<p>\r\n    ");


            
            #line 55 "..\..\Views\DanhHieu\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id=Model.id }));

            
            #line default
            #line hidden
WriteLiteral(" |\r\n    ");


            
            #line 56 "..\..\Views\DanhHieu\Details.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</p>\r\n");


        }
    }
}
#pragma warning restore 1591