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

namespace HRM.QLBHXH.Views.dmMucLuongToiThieuChung
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/dmMucLuongToiThieuChung/Edit.cshtml")]
    public partial class Edit : System.Web.Mvc.WebViewPage<HRM.QLBHXH.Models.dmMucLuongToiThieuChung>
    {
        public Edit()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\dmMucLuongToiThieuChung\Edit.cshtml"
  
    ViewBag.Title = "Create";

            
            #line default
            #line hidden
WriteLiteral("\r\n<h2>Chỉnh sửa</h2>\r\n");

            
            #line 7 "..\..\Views\dmMucLuongToiThieuChung\Edit.cshtml"
 using (Html.BeginForm())
{
    
            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\dmMucLuongToiThieuChung\Edit.cshtml"
Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\dmMucLuongToiThieuChung\Edit.cshtml"
                                 


            
            #line default
            #line hidden
WriteLiteral("    <fieldset>\r\n        <legend>dmMucLuongToiThieuChung</legend>\r\n      <b> Ngày " +
"bắt đầu</b>\r\n       \r\n      \r\n");

WriteLiteral("            ");

            
            #line 16 "..\..\Views\dmMucLuongToiThieuChung\Edit.cshtml"
       Write(Html.TextBoxFor(model => model.NgayBatDau, "{0: dd/MM/yyyy}", new { style = "width: 100px",@id = "NgayBatDau1" , @class = "text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 17 "..\..\Views\dmMucLuongToiThieuChung\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.NgayBatDau));

            
            #line default
            #line hidden
WriteLiteral("\r\n        \r\n      <b>Ngày kết thúc</b>\r\n     \r\n");

WriteLiteral("           ");

            
            #line 21 "..\..\Views\dmMucLuongToiThieuChung\Edit.cshtml"
      Write(Html.TextBoxFor(model => model.NgayKetThuc, "{0: dd/MM/yyyy}", new { style = "width: 100px", @id = "NgayKetThuc1", @class = "text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 22 "..\..\Views\dmMucLuongToiThieuChung\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.NgayKetThuc));

            
            #line default
            #line hidden
WriteLiteral("\r\n     \r\n        <div >\r\n        <b>  Mức lương tối thiểu chung (VNĐ)</b>\r\n      " +
" ");

WriteLiteral("\r\n       <input");

WriteLiteral(" id=\"MucLuongTTC1\"");

WriteLiteral(" value=");

WriteLiteral(" ");

            
            #line 27 "..\..\Views\dmMucLuongToiThieuChung\Edit.cshtml"
                                  Write(String.Format("{0:#,##0}", Model.MucLuong));

            
            #line default
            #line hidden
WriteLiteral(" class=\"text\"/>\r\n");

WriteLiteral("            ");

            
            #line 28 "..\..\Views\dmMucLuongToiThieuChung\Edit.cshtml"
       Write(Html.HiddenFor(model => model.MucLuong, new { @id = "MucLuong1" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 29 "..\..\Views\dmMucLuongToiThieuChung\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.MucLuong));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n      <div >\r\n         <b> Ghi chú</b>\r\n       \r\n");

WriteLiteral("            ");

            
            #line 34 "..\..\Views\dmMucLuongToiThieuChung\Edit.cshtml"
       Write(Html.TextBoxFor(model => model.GhiChu, new {  @class = "text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 35 "..\..\Views\dmMucLuongToiThieuChung\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.GhiChu));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div >\r\n          <b>Đang áp dụng</b>\r\n  \r\n");

WriteLiteral("            ");

            
            #line 40 "..\..\Views\dmMucLuongToiThieuChung\Edit.cshtml"
       Write(Html.EditorFor(model => model.TrangThai));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 41 "..\..\Views\dmMucLuongToiThieuChung\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.TrangThai));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    \r\n        <p>\r\n            <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Lưu\"");

WriteLiteral(" />\r\n        </p>\r\n    </fieldset>\r\n");

            
            #line 48 "..\..\Views\dmMucLuongToiThieuChung\Edit.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<script>\r\n\r\n $(\".text\").css(\"background-color\", \"transparent\").css(\"margin\", \"5" +
"px 0 6px 0\").css(\"border\", \"0\").css(\"border-bottom\", \"1px dotted\");\r\n//    $(\".c" +
"ustom-combobox-input\").removeClass(\"ui-state-default\");\r\n//    $(\".custom-combob" +
"ox-input\").removeClass(\"ui-widget-content\");\r\n//    $(\".custom-combobox-input\")." +
"removeClass(\"ui-corner-left\");\r\n//    $(\".custom-combobox-toggle\").removeClass(\"" +
"ui-state-default\");\r\n//    $(\".custom-combobox-input\").css(\"border\", \"0\").css(\"b" +
"order-bottom\", \"1px dotted\");\r\n//    $(\".custom-combobox-input\").css(\"background" +
"-color\", \"transparent\").css(\"margin\", \"5px 0 6px 0\");\r\n\r\n\r\n\r\n$(\"#NgayBatDau1\").d" +
"atepicker({\r\n        changeDay: true,\r\n       changeMonth: true,\r\n        change" +
"Year: true,\r\n    });\r\n    $(\"#NgayKetThuc1\").datepicker({\r\n        changeDay: tr" +
"ue,\r\n       changeMonth: true,\r\n        changeYear: true,\r\n    });\r\n\r\n//tu them " +
"dau phay vao so\r\n$(\'#MucLuongTTC1\').keyup(function(event) {\r\n\r\n  // skip for arr" +
"ow keys\r\n  if(event.which >= 37 && event.which <= 40){\r\n    event.preventDefault" +
"();\r\n  }\r\n\r\n  $(this).val(function(index, value) {\r\n    return value\r\n      .rep" +
"lace(/\\D/g, \"\")\r\n      .replace(/\\B(?=(\\d{3})+(?!\\d))/g, \".\")\r\n    ;\r\n  });\r\n\r\n\r" +
"\n\r\n\r\n});\r\n\r\n\r\n\r\n    $(\"#MucLuongTTC1\").keyup(function () {\r\n\r\n            //Clea" +
"r the hidden field\r\n            $(\"#MucLuong1\").val(\"\");\r\n\r\n            //Create" +
" char array from phone number field\r\n            var charArray = $(this).val().s" +
"plit(\"\");\r\n\r\n            var phoneNumber = \"\";\r\n\r\n            //Iterate over eac" +
"h character in the char array\r\n            //and determine if it is a number\r\n  " +
"          $.each(charArray, function (index, value) {\r\n                if (!isNa" +
"N(value) && value != \" \") {\r\n                    phoneNumber = phoneNumber + val" +
"ue;\r\n                }\r\n            });\r\n\r\n            //Set hidden field\r\n     " +
"       $(\"#MucLuong1\").val(phoneNumber);\r\n        });\r\n\r\n\r\n\r\n\r\n</script>\r\n");

        }
    }
}
#pragma warning restore 1591
