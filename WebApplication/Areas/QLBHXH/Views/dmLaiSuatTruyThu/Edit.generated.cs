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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/dmLaiSuatTruyThu/Edit.cshtml")]
    public partial class Edit : System.Web.Mvc.WebViewPage<HRM.QLBHXH.Models.dmLaiSuatTruyThu>
    {
        public Edit()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\dmLaiSuatTruyThu\Edit.cshtml"
  
    ViewBag.Title = "Edit";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2>Sửa lãi suất truy thu</h2>\r\n\r\n");

            
            #line 9 "..\..\Views\dmLaiSuatTruyThu\Edit.cshtml"
 using (Html.BeginForm()) {
    
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\dmLaiSuatTruyThu\Edit.cshtml"
Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\dmLaiSuatTruyThu\Edit.cshtml"
                                 


            
            #line default
            #line hidden
WriteLiteral("    <fieldset>\r\n        <legend>dmLaiSuatTruyThu</legend>\r\n\r\n");

WriteLiteral("        ");

            
            #line 15 "..\..\Views\dmLaiSuatTruyThu\Edit.cshtml"
   Write(Html.HiddenFor(model => model.id));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n        <div");

WriteLiteral(" class=\"editor-label\"");

WriteLiteral(">\r\n            Ngày áp dụng\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"editor-field\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 21 "..\..\Views\dmLaiSuatTruyThu\Edit.cshtml"
       Write(Html.EditorFor(model => model.NgayApDung));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 22 "..\..\Views\dmLaiSuatTruyThu\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.NgayApDung, "NgayApDung"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"editor-label\"");

WriteLiteral(">\r\n            Ngày kết thúc\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"editor-field\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 29 "..\..\Views\dmLaiSuatTruyThu\Edit.cshtml"
       Write(Html.EditorFor(model => model.NgayKetThuc));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 30 "..\..\Views\dmLaiSuatTruyThu\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.NgayKetThuc, "NgayKetThuc"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"editor-label\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 34 "..\..\Views\dmLaiSuatTruyThu\Edit.cshtml"
       Write(Html.LabelFor(model => model.BHXH));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"editor-field\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 37 "..\..\Views\dmLaiSuatTruyThu\Edit.cshtml"
       Write(Html.EditorFor(model => model.BHXH));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 38 "..\..\Views\dmLaiSuatTruyThu\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.BHXH));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"editor-label\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 42 "..\..\Views\dmLaiSuatTruyThu\Edit.cshtml"
       Write(Html.LabelFor(model => model.BHYT));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"editor-field\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 45 "..\..\Views\dmLaiSuatTruyThu\Edit.cshtml"
       Write(Html.EditorFor(model => model.BHYT));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 46 "..\..\Views\dmLaiSuatTruyThu\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.BHYT));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"editor-label\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 50 "..\..\Views\dmLaiSuatTruyThu\Edit.cshtml"
       Write(Html.LabelFor(model => model.BHTN));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"editor-field\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 53 "..\..\Views\dmLaiSuatTruyThu\Edit.cshtml"
       Write(Html.EditorFor(model => model.BHTN));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 54 "..\..\Views\dmLaiSuatTruyThu\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.BHTN));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"editor-label\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 58 "..\..\Views\dmLaiSuatTruyThu\Edit.cshtml"
       Write(Html.LabelFor(model => model.STT));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"editor-field\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 61 "..\..\Views\dmLaiSuatTruyThu\Edit.cshtml"
       Write(Html.EditorFor(model => model.STT));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 62 "..\..\Views\dmLaiSuatTruyThu\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.STT));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <p>\r\n            <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Save\"");

WriteLiteral(" />\r\n        </p>\r\n    </fieldset>\r\n");

            
            #line 69 "..\..\Views\dmLaiSuatTruyThu\Edit.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<div>\r\n");

WriteLiteral("    ");

            
            #line 72 "..\..\Views\dmLaiSuatTruyThu\Edit.cshtml"
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
