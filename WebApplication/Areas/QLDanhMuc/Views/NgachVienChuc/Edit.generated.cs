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

namespace HRM.QLDanhMuc.Views.NgachVienChuc
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/NgachVienChuc/Edit.cshtml")]
    public partial class Edit : System.Web.Mvc.WebViewPage<HRM.Databases.Models.dmNgachVienChuc>
    {
        public Edit()
        {
        }
        public override void Execute()
        {

WriteLiteral("\r\n");


            
            #line 3 "..\..\Views\NgachVienChuc\Edit.cshtml"
 using (Html.BeginForm()) {
    
            
            #line default
            #line hidden
            
            #line 4 "..\..\Views\NgachVienChuc\Edit.cshtml"
Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 4 "..\..\Views\NgachVienChuc\Edit.cshtml"
                                 


            
            #line default
            #line hidden
WriteLiteral("    <fieldset>\r\n        <legend>dmNgachVienChuc</legend>\r\n\r\n        ");


            
            #line 9 "..\..\Views\NgachVienChuc\Edit.cshtml"
   Write(Html.HiddenFor(model => model.id));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n        <div class=\"editor-label\">\r\n            ");


            
            #line 12 "..\..\Views\NgachVienChuc\Edit.cshtml"
       Write(Html.LabelFor(model => model.maNgachVienChuc, "Mã ngạch"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");


            
            #line 15 "..\..\Views\NgachVienChuc\Edit.cshtml"
       Write(Html.EditorFor(model => model.maNgachVienChuc));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 16 "..\..\Views\NgachVienChuc\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.maNgachVienChuc));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"editor-label\">\r\n            ");


            
            #line 20 "..\..\Views\NgachVienChuc\Edit.cshtml"
       Write(Html.LabelFor(model => model.tenNgachVienChuc, "Tên ngạch"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");


            
            #line 23 "..\..\Views\NgachVienChuc\Edit.cshtml"
       Write(Html.EditorFor(model => model.tenNgachVienChuc));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 24 "..\..\Views\NgachVienChuc\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.tenNgachVienChuc));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"editor-label\">\r\n            ");


            
            #line 28 "..\..\Views\NgachVienChuc\Edit.cshtml"
       Write(Html.LabelFor(model => model.nhomNgachVienChuc, "Nhóm ngạch"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");


            
            #line 31 "..\..\Views\NgachVienChuc\Edit.cshtml"
       Write(Html.DropDownList("nhomNgachVienChuc", String.Empty));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 32 "..\..\Views\NgachVienChuc\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.nhomNgachVienChuc));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"editor-label\">\r\n            ");


            
            #line 36 "..\..\Views\NgachVienChuc\Edit.cshtml"
       Write(Html.LabelFor(model => model.stt, "Số thứ tự"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");


            
            #line 39 "..\..\Views\NgachVienChuc\Edit.cshtml"
       Write(Html.EditorFor(model => model.stt));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 40 "..\..\Views\NgachVienChuc\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.stt));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <p>\r\n            <input class=\"dialog\" type=\"submit\" " +
"value=\"Lưu\" />\r\n        </p>\r\n    </fieldset>\r\n");


            
            #line 47 "..\..\Views\NgachVienChuc\Edit.cshtml"
}

            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
