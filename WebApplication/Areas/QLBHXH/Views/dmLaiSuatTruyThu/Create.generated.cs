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

namespace HRM.QLBHXH.Views.dmLaiSuatTruyThu
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/dmLaiSuatTruyThu/Create.cshtml")]
    public partial class Create : System.Web.Mvc.WebViewPage<HRM.QLBHXH.Models.dmLaiSuatTruyThu>
    {
        public Create()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\dmLaiSuatTruyThu\Create.cshtml"
  
    ViewBag.Title = "Create";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2>Thêm mới lãi suất truy thu</h2>\r\n\r\n");

            
            #line 9 "..\..\Views\dmLaiSuatTruyThu\Create.cshtml"
 using (Html.BeginForm()) {
    
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\dmLaiSuatTruyThu\Create.cshtml"
Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\dmLaiSuatTruyThu\Create.cshtml"
                                 


            
            #line default
            #line hidden
WriteLiteral("    <fieldset>\r\n        <legend>dmLaiSuatTruyThu</legend>\r\n\r\n        <div");

WriteLiteral(" class=\"editor-label\"");

WriteLiteral(">\r\n            Ngày áp dụng\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"editor-field\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 19 "..\..\Views\dmLaiSuatTruyThu\Create.cshtml"
       Write(Html.EditorFor(model => model.NgayApDung));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 20 "..\..\Views\dmLaiSuatTruyThu\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.NgayApDung, "NgayApDung"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"editor-label\"");

WriteLiteral(">\r\n            Ngày kết thúc\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"editor-field\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 27 "..\..\Views\dmLaiSuatTruyThu\Create.cshtml"
       Write(Html.EditorFor(model => model.NgayKetThuc));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 28 "..\..\Views\dmLaiSuatTruyThu\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.NgayKetThuc, "NgayKetThuc"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"editor-label\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 32 "..\..\Views\dmLaiSuatTruyThu\Create.cshtml"
       Write(Html.LabelFor(model => model.BHXH));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"editor-field\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 35 "..\..\Views\dmLaiSuatTruyThu\Create.cshtml"
       Write(Html.EditorFor(model => model.BHXH));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 36 "..\..\Views\dmLaiSuatTruyThu\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.BHXH));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"editor-label\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 40 "..\..\Views\dmLaiSuatTruyThu\Create.cshtml"
       Write(Html.LabelFor(model => model.BHYT));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"editor-field\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 43 "..\..\Views\dmLaiSuatTruyThu\Create.cshtml"
       Write(Html.EditorFor(model => model.BHYT));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 44 "..\..\Views\dmLaiSuatTruyThu\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.BHYT));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"editor-label\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 48 "..\..\Views\dmLaiSuatTruyThu\Create.cshtml"
       Write(Html.LabelFor(model => model.BHTN));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"editor-field\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 51 "..\..\Views\dmLaiSuatTruyThu\Create.cshtml"
       Write(Html.EditorFor(model => model.BHTN));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 52 "..\..\Views\dmLaiSuatTruyThu\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.BHTN));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"editor-label\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 56 "..\..\Views\dmLaiSuatTruyThu\Create.cshtml"
       Write(Html.LabelFor(model => model.STT));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"editor-field\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 59 "..\..\Views\dmLaiSuatTruyThu\Create.cshtml"
       Write(Html.EditorFor(model => model.STT));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 60 "..\..\Views\dmLaiSuatTruyThu\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.STT));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <p>\r\n            <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Create\"");

WriteLiteral(" />\r\n        </p>\r\n    </fieldset>\r\n");

            
            #line 67 "..\..\Views\dmLaiSuatTruyThu\Create.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<div>\r\n");

WriteLiteral("    ");

            
            #line 70 "..\..\Views\dmLaiSuatTruyThu\Create.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

            
            #line default
            #line hidden
WriteLiteral(@"
</div>

<script>
    $(""#NgayApDung"").datepicker({
        changeDay: true,
       changeMonth: true,
        changeYear: true,
    });
        $(""#NgayKetThuc"").datepicker({
        changeDay: true,
       changeMonth: true,
        changeYear: true,
    });
</script>");

        }
    }
}
#pragma warning restore 1591
