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

namespace HRM.QLBHXH.Views.NhanVienBHXH
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/NhanVienBHXH/Details.cshtml")]
    public partial class Details : System.Web.Mvc.WebViewPage<HRM.QLBHXH.Models.nvbhNhanVienBHXH>
    {
        public Details()
        {
        }
        public override void Execute()
        {

WriteLiteral("\r\n");


            
            #line 3 "..\..\Views\NhanVienBHXH\Details.cshtml"
  
    ViewBag.Title = "Details";


            
            #line default
            #line hidden
WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<fieldset>\r\n    <legend>nvbhNhanVienBHXH</legend>\r\n\r\n    <d" +
"iv class=\"display-label\">\r\n         ");


            
            #line 13 "..\..\Views\NhanVienBHXH\Details.cshtml"
    Write(Html.DisplayNameFor(model => model.id));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div class=\"display-field\">\r\n        ");


            
            #line 16 "..\..\Views\NhanVienBHXH\Details.cshtml"
   Write(Html.DisplayFor(model => model.id));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    ");



WriteLiteral("\r\n    <div class=\"display-label\">\r\n         ");


            
            #line 27 "..\..\Views\NhanVienBHXH\Details.cshtml"
    Write(Html.DisplayNameFor(model => model.MucLuongDongBHXHVaBHYT));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div class=\"display-field\">\r\n        ");


            
            #line 30 "..\..\Views\NhanVienBHXH\Details.cshtml"
   Write(Html.DisplayFor(model => model.MucLuongDongBHXHVaBHYT));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    ");



WriteLiteral("\r\n    <div class=\"display-label\">\r\n         ");


            
            #line 83 "..\..\Views\NhanVienBHXH\Details.cshtml"
    Write(Html.DisplayNameFor(model => model.GhiChu));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div class=\"display-field\">\r\n        ");


            
            #line 86 "..\..\Views\NhanVienBHXH\Details.cshtml"
   Write(Html.DisplayFor(model => model.GhiChu));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    ");



WriteLiteral("\r\n    <div class=\"display-label\">\r\n         ");


            
            #line 97 "..\..\Views\NhanVienBHXH\Details.cshtml"
    Write(Html.DisplayNameFor(model => model.ThoiGianThamGiaBHXHTaiTruong));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div class=\"display-field\">\r\n        ");


            
            #line 100 "..\..\Views\NhanVienBHXH\Details.cshtml"
   Write(Html.DisplayFor(model => model.ThoiGianThamGiaBHXHTaiTruong));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"display-label\">\r\n         ");


            
            #line 104 "..\..\Views\NhanVienBHXH\Details.cshtml"
    Write(Html.DisplayNameFor(model => model.SoNamThamGiaBHXH));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div class=\"display-field\">\r\n        ");


            
            #line 107 "..\..\Views\NhanVienBHXH\Details.cshtml"
   Write(Html.DisplayFor(model => model.SoNamThamGiaBHXH));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</fieldset>\r\n<p>\r\n    ");


            
            #line 111 "..\..\Views\NhanVienBHXH\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id=Model.id }));

            
            #line default
            #line hidden
WriteLiteral(" |\r\n    ");


            
            #line 112 "..\..\Views\NhanVienBHXH\Details.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</p>\r\n");


        }
    }
}
#pragma warning restore 1591