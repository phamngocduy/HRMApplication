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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/QuaTrinhHoc/Edit.cshtml")]
    public partial class Edit : System.Web.Mvc.WebViewPage<HRM.Databases.Models.QuaTrinhHoc>
    {
        public Edit()
        {
        }
        public override void Execute()
        {

WriteLiteral("\r\n");


            
            #line 3 "..\..\Views\QuaTrinhHoc\Edit.cshtml"
  
    ViewBag.Title = "Edit";


            
            #line default
            #line hidden
WriteLiteral("\r\n<h2>Edit</h2>\r\n\r\n");


            
            #line 9 "..\..\Views\QuaTrinhHoc\Edit.cshtml"
 using (Html.BeginForm()) {
    
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\QuaTrinhHoc\Edit.cshtml"
Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\QuaTrinhHoc\Edit.cshtml"
                                 


            
            #line default
            #line hidden
WriteLiteral("    <fieldset>\r\n        <legend>QuaTrinhHoc</legend>\r\n\r\n        ");


            
            #line 15 "..\..\Views\QuaTrinhHoc\Edit.cshtml"
   Write(Html.HiddenFor(model => model.id));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n        <div class=\"editor-label\">\r\n            ");


            
            #line 18 "..\..\Views\QuaTrinhHoc\Edit.cshtml"
       Write(Html.LabelFor(model => model.NV_id));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");


            
            #line 21 "..\..\Views\QuaTrinhHoc\Edit.cshtml"
       Write(Html.EditorFor(model => model.NV_id));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 22 "..\..\Views\QuaTrinhHoc\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.NV_id));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"editor-label\">\r\n            ");


            
            #line 26 "..\..\Views\QuaTrinhHoc\Edit.cshtml"
       Write(Html.LabelFor(model => model.BacHoc));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");


            
            #line 29 "..\..\Views\QuaTrinhHoc\Edit.cshtml"
       Write(Html.EditorFor(model => model.BacHoc));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 30 "..\..\Views\QuaTrinhHoc\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.BacHoc));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-label\">\r\n            ");


            
            #line 33 "..\..\Views\QuaTrinhHoc\Edit.cshtml"
       Write(Html.LabelFor(model => model.TruongHoc));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");


            
            #line 36 "..\..\Views\QuaTrinhHoc\Edit.cshtml"
       Write(Html.EditorFor(model => model.TruongHoc));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 37 "..\..\Views\QuaTrinhHoc\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.TruongHoc));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-label\">\r\n            ");


            
            #line 40 "..\..\Views\QuaTrinhHoc\Edit.cshtml"
       Write(Html.LabelFor(model => model.NamBatDau));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");


            
            #line 43 "..\..\Views\QuaTrinhHoc\Edit.cshtml"
       Write(Html.EditorFor(model => model.NamBatDau));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 44 "..\..\Views\QuaTrinhHoc\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.NamBatDau));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"editor-label\">\r\n            ");


            
            #line 48 "..\..\Views\QuaTrinhHoc\Edit.cshtml"
       Write(Html.LabelFor(model => model.NamKetThuc));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");


            
            #line 51 "..\..\Views\QuaTrinhHoc\Edit.cshtml"
       Write(Html.EditorFor(model => model.NamKetThuc));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 52 "..\..\Views\QuaTrinhHoc\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.NamKetThuc));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"editor-label\">\r\n            ");


            
            #line 56 "..\..\Views\QuaTrinhHoc\Edit.cshtml"
       Write(Html.LabelFor(model => model.GhiChu));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");


            
            #line 59 "..\..\Views\QuaTrinhHoc\Edit.cshtml"
       Write(Html.EditorFor(model => model.GhiChu));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 60 "..\..\Views\QuaTrinhHoc\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.GhiChu));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <p>\r\n            <input type=\"submit\" value=\"Save\" />" +
"\r\n        </p>\r\n    </fieldset>\r\n");


            
            #line 67 "..\..\Views\QuaTrinhHoc\Edit.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<div>\r\n    ");


            
            #line 70 "..\..\Views\QuaTrinhHoc\Edit.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n\r\n");


DefineSection("Scripts", () => {

WriteLiteral("\r\n    ");



WriteLiteral("\r\n");


});

WriteLiteral("\r\n");


        }
    }
}
#pragma warning restore 1591
