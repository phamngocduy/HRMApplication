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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DanhHieu/Delete.cshtml")]
    public partial class Delete : System.Web.Mvc.WebViewPage<HRM.Databases.Models.DanhHieu>
    {
        public Delete()
        {
        }
        public override void Execute()
        {

WriteLiteral("\r\n");


            
            #line 3 "..\..\Views\DanhHieu\Delete.cshtml"
  
    ViewBag.Title = "Delete";


            
            #line default
            #line hidden
WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<fieldset>\r\n" +
"    <legend>DanhHieu</legend>\r\n\r\n    <div class=\"display-label\">\r\n         ");


            
            #line 14 "..\..\Views\DanhHieu\Delete.cshtml"
    Write(Html.DisplayNameFor(model => model.NhanVien.MaNV));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div class=\"display-field\">\r\n        ");


            
            #line 17 "..\..\Views\DanhHieu\Delete.cshtml"
   Write(Html.DisplayFor(model => model.NhanVien.MaNV));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"display-label\">\r\n         ");


            
            #line 21 "..\..\Views\DanhHieu\Delete.cshtml"
    Write(Html.DisplayNameFor(model => model.dmDanhHieu.tenDanhHieu));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div class=\"display-field\">\r\n        ");


            
            #line 24 "..\..\Views\DanhHieu\Delete.cshtml"
   Write(Html.DisplayFor(model => model.dmDanhHieu.tenDanhHieu));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"display-label\">\r\n         ");


            
            #line 28 "..\..\Views\DanhHieu\Delete.cshtml"
    Write(Html.DisplayNameFor(model => model.NgayDatDanhHieu));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div class=\"display-field\">\r\n        ");


            
            #line 31 "..\..\Views\DanhHieu\Delete.cshtml"
   Write(Html.DisplayFor(model => model.NgayDatDanhHieu));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"display-label\">\r\n         ");


            
            #line 35 "..\..\Views\DanhHieu\Delete.cshtml"
    Write(Html.DisplayNameFor(model => model.SoQDCongNhan));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div class=\"display-field\">\r\n        ");


            
            #line 38 "..\..\Views\DanhHieu\Delete.cshtml"
   Write(Html.DisplayFor(model => model.SoQDCongNhan));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"display-label\">\r\n         ");


            
            #line 42 "..\..\Views\DanhHieu\Delete.cshtml"
    Write(Html.DisplayNameFor(model => model.NoiCap));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div class=\"display-field\">\r\n        ");


            
            #line 45 "..\..\Views\DanhHieu\Delete.cshtml"
   Write(Html.DisplayFor(model => model.NoiCap));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"display-label\">\r\n         ");


            
            #line 49 "..\..\Views\DanhHieu\Delete.cshtml"
    Write(Html.DisplayNameFor(model => model.GhiChu));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div class=\"display-field\">\r\n        ");


            
            #line 52 "..\..\Views\DanhHieu\Delete.cshtml"
   Write(Html.DisplayFor(model => model.GhiChu));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</fieldset>\r\n");


            
            #line 55 "..\..\Views\DanhHieu\Delete.cshtml"
 using (Html.BeginForm()) {

            
            #line default
            #line hidden
WriteLiteral("    <p>\r\n        <input type=\"submit\" value=\"Delete\" /> |\r\n        ");


            
            #line 58 "..\..\Views\DanhHieu\Delete.cshtml"
   Write(Html.ActionLink("Back to List", "Index"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </p>\r\n");


            
            #line 60 "..\..\Views\DanhHieu\Delete.cshtml"
}

            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
