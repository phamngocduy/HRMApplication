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

namespace HRM.QLBHXH.Views.dmLoaiDieuChinh
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\dmLoaiDieuChinh\Create.cshtml"
    using HRM.QLBHXH.Models;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/dmLoaiDieuChinh/Create.cshtml")]
    public partial class Create : System.Web.Mvc.WebViewPage<HRM.QLBHXH.Models.dmLoaiDieuChinh>
    {
        public Create()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\dmLoaiDieuChinh\Create.cshtml"
  
    HRMDB1Entities db = new HRMDB1Entities();
    ViewBag.Title = "Create";
    //int ltg = (int)ViewBag.ltg;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2>Thêm mới loại điều chỉnh</h2>\r\n\r\n");

            
            #line 12 "..\..\Views\dmLoaiDieuChinh\Create.cshtml"
 using (Html.BeginForm()) {
    
            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\dmLoaiDieuChinh\Create.cshtml"
Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\dmLoaiDieuChinh\Create.cshtml"
                                 


            
            #line default
            #line hidden
WriteLiteral("    <fieldset>\r\n        <legend>dmLoaiDieuChinh</legend>\r\n        ");

WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"editor-label\"");

WriteLiteral(">\r\n            Loại điều chỉnh\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"editor-field\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 30 "..\..\Views\dmLoaiDieuChinh\Create.cshtml"
       Write(Html.EditorFor(model => model.LoaiDieuChinh));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 31 "..\..\Views\dmLoaiDieuChinh\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.LoaiDieuChinh));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"editor-label\"");

WriteLiteral(">\r\n            Ghi chú\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"editor-field\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 38 "..\..\Views\dmLoaiDieuChinh\Create.cshtml"
       Write(Html.EditorFor(model => model.GhiChu));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 39 "..\..\Views\dmLoaiDieuChinh\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.GhiChu));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"editor-label\"");

WriteLiteral(">\r\n            STT\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"editor-field\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 46 "..\..\Views\dmLoaiDieuChinh\Create.cshtml"
       Write(Html.EditorFor(model => model.STT));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 47 "..\..\Views\dmLoaiDieuChinh\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.STT));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <p>\r\n            <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Create\"");

WriteLiteral(" />\r\n        </p>\r\n    </fieldset>\r\n");

            
            #line 54 "..\..\Views\dmLoaiDieuChinh\Create.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<div>\r\n");

WriteLiteral("    ");

            
            #line 57 "..\..\Views\dmLoaiDieuChinh\Create.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n\r\n<script>\r\n    $(\"#idLoaiTangGiam\").combobox();\r\n</script>");

        }
    }
}
#pragma warning restore 1591
