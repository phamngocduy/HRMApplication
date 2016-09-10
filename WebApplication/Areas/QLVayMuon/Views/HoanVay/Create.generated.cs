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

namespace HRM.QLVayMuon.Views.HoanVay
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
    
    #line 2 "..\..\Views\HoanVay\Create.cshtml"
    using HRM.QLVayMuon.Models;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\HoanVay\Create.cshtml"
    using HRM.Webpages.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/HoanVay/Create.cshtml")]
    public partial class Create : System.Web.Mvc.WebViewPage<HRM.QLVayMuon.Models.HoanVay>
    {
        public Create()
        {
        }
        public override void Execute()
        {




            
            #line 4 "..\..\Views\HoanVay\Create.cshtml"
  
    ViewBag.Title = "Create";
    var db = new HRMDB1Entities();
    var NV_id = (int)ViewBag.NV_id;


            
            #line default
            #line hidden

            
            #line 9 "..\..\Views\HoanVay\Create.cshtml"
Write(Html.BeginDiv());

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 10 "..\..\Views\HoanVay\Create.cshtml"
Write(Html.StatusMessage(TempData["Message"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 11 "..\..\Views\HoanVay\Create.cshtml"
Write(Html.ValidationSummary(TempData["ModelState"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n<h4>\r\nTạo mới hoàn vay cho: ");


            
            #line 13 "..\..\Views\HoanVay\Create.cshtml"
                 Write(db.NhanVienVayMuon.First(k => k.id == NV_id).MaNV);

            
            #line default
            #line hidden
WriteLiteral(" -");


            
            #line 13 "..\..\Views\HoanVay\Create.cshtml"
                                                                     Write(db.NhanVienVayMuon.First(k => k.id == NV_id).HoVaTen);

            
            #line default
            #line hidden
WriteLiteral(" - ");


            
            #line 13 "..\..\Views\HoanVay\Create.cshtml"
                                                                                                                             Write(db.NhanVienVayMuon.First(k => k.id == NV_id).DonVi);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n");


            
            #line 14 "..\..\Views\HoanVay\Create.cshtml"
 using (Html.BeginForm())
{
    
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\HoanVay\Create.cshtml"
Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\HoanVay\Create.cshtml"
                                 

            
            #line default
            #line hidden
WriteLiteral("    <fieldset>\r\n        <legend>HoanVay</legend>\r\n        ");


            
            #line 19 "..\..\Views\HoanVay\Create.cshtml"
   Write(Html.TextBoxFor(model => model.TrangThai, new { @Value = "true", @Type = "hidden" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div class=\"editor-label\">\r\n            ");


            
            #line 21 "..\..\Views\HoanVay\Create.cshtml"
       Write(Html.LabelFor(model => model.idKhoanVay, "Thuộc khoản vay"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");


            
            #line 24 "..\..\Views\HoanVay\Create.cshtml"
       Write(Html.DropDownList("idKhoanVay", "-- Chọn số chứng từ khoản vay --"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 25 "..\..\Views\HoanVay\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.idKhoanVay));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-label\">\r\n            ");


            
            #line 28 "..\..\Views\HoanVay\Create.cshtml"
       Write(Html.LabelFor(model => model.SoChungTu, "Số chứng từ"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");


            
            #line 31 "..\..\Views\HoanVay\Create.cshtml"
       Write(Html.EditorFor(model => model.SoChungTu));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 32 "..\..\Views\HoanVay\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.SoChungTu));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-label\">\r\n            ");


            
            #line 35 "..\..\Views\HoanVay\Create.cshtml"
       Write(Html.LabelFor(model => model.NgayChungTu, "Ngày chứng từ"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");


            
            #line 38 "..\..\Views\HoanVay\Create.cshtml"
       Write(Html.EditorFor(model => model.NgayChungTu));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 39 "..\..\Views\HoanVay\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.NgayChungTu));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-label\">\r\n            ");


            
            #line 42 "..\..\Views\HoanVay\Create.cshtml"
       Write(Html.LabelFor(model => model.DienGiai, "Diễn giải"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");


            
            #line 45 "..\..\Views\HoanVay\Create.cshtml"
       Write(Html.EditorFor(model => model.DienGiai));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 46 "..\..\Views\HoanVay\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.DienGiai));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-label\">\r\n            ");


            
            #line 49 "..\..\Views\HoanVay\Create.cshtml"
       Write(Html.LabelFor(model => model.SoTienHoan, "Số tiền hoàn"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");


            
            #line 52 "..\..\Views\HoanVay\Create.cshtml"
       Write(Html.HiddenFor(model => model.SoTienHoan));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 53 "..\..\Views\HoanVay\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.SoTienHoan));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <input id=\"Hoan\" />\r\n        <div class=\"editor-label\">" +
"\r\n            ");


            
            #line 57 "..\..\Views\HoanVay\Create.cshtml"
       Write(Html.LabelFor(model => model.SoTienLai, "Số tiền lãi"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");



WriteLiteral("\r\n            ");


            
            #line 61 "..\..\Views\HoanVay\Create.cshtml"
       Write(Html.HiddenFor(model => model.SoTienLai, new { @Value = "0" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 62 "..\..\Views\HoanVay\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.SoTienLai));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <input id=\"Lai\" value=\"0\" />\r\n        <p>\r\n            " +
"<input type=\"submit\" value=\"Tạo\" onclick=\"return check();\" />\r\n        </p>\r\n   " +
" </fieldset>\r\n");


            
            #line 69 "..\..\Views\HoanVay\Create.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("<div>\r\n    ");


            
            #line 71 "..\..\Views\HoanVay\Create.cshtml"
Write(Html.ActionLink("Trở về danh sách hoàn vay", "Index", new { NV_id = NV_id }));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");


            
            #line 73 "..\..\Views\HoanVay\Create.cshtml"
Write(Html.EndDiv());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<script>\r\n//tao ra commbobox\r\n    $(\"#NgayChungTu\").datepicker({\r\n        cha" +
"ngeDay: true,\r\n       changeMonth: true,\r\n        changeYear: true,\r\n    });\r\n  " +
"  //tao ra commbobox\r\n    $(\"#idKhoanVay\").combobox();\r\n\r\n//them dau cah vao sot" +
"ien\r\n $(\'#Hoan\').keyup(function (event) {\r\n\r\n        // skip for arrow keys\r\n   " +
"     if (event.which >= 37 && event.which <= 40) {\r\n            event.preventDef" +
"ault();\r\n        }\r\n\r\n        $(this).val(function (index, value) {\r\n           " +
" return value.replace(/\\D/g, \"\").replace(/\\B(?=(\\d{3})+(?!\\d))/g, \".\");\r\n       " +
" });\r\n    });\r\n    $(\"#Hoan\").keyup(function () {\r\n        //Clear the hidden fi" +
"eld\r\n        $(\"#SoTienHoan\").val(\"\");\r\n        //Create char array from phone n" +
"umber field\r\n        var charArray = $(this).val().split(\"\");\r\n        var phone" +
"Number = \"\";\r\n        //Iterate over each character in the char array\r\n        /" +
"/and determine if it is a number\r\n        $.each(charArray, function (index, val" +
"ue) {\r\n            if (!isNaN(value) && value != \" \") {\r\n                phoneNu" +
"mber = phoneNumber + value;\r\n            }\r\n        });\r\n        //Set hidden fi" +
"eld\r\n        $(\"#SoTienHoan\").val(phoneNumber);\r\n    });\r\n //them dau cah vao so" +
"tien   \r\n $(\'#Lai\').keyup(function (event) {\r\n\r\n        // skip for arrow keys\r\n" +
"        if (event.which >= 37 && event.which <= 40) {\r\n            event.prevent" +
"Default();\r\n        }\r\n\r\n        $(this).val(function (index, value) {\r\n        " +
"    return value.replace(/\\D/g, \"\").replace(/\\B(?=(\\d{3})+(?!\\d))/g, \".\");\r\n    " +
"    });\r\n    });\r\n    $(\"#Lai\").keyup(function () {\r\n        //Clear the hidden " +
"field\r\n        $(\"#SoTienLai\").val(\"\");\r\n        //Create char array from phone " +
"number field\r\n        var charArray = $(this).val().split(\"\");\r\n        var phon" +
"eNumber = \"\";\r\n        //Iterate over each character in the char array\r\n        " +
"//and determine if it is a number\r\n        $.each(charArray, function (index, va" +
"lue) {\r\n            if (!isNaN(value) && value != \" \") {\r\n                phoneN" +
"umber = phoneNumber + value;\r\n            }\r\n        });\r\n        //Set hidden f" +
"ield\r\n        $(\"#SoTienLai\").val(phoneNumber);\r\n    });\r\n\r\n       //kiem tra nu" +
"ll cua sotienhoan va sotienlai\r\n     function check()\r\n            {\r\n          " +
"      if (document.getElementById(\'Hoan\').value==\"\"\r\n                 || documen" +
"t.getElementById(\'Hoan\').value==undefined)\r\n                {\r\n                 " +
"   alert (\"Vui lòng nhập số tiền hoàn\");\r\n                    return false;\r\n   " +
"             }\r\n\r\n                if (document.getElementById(\'Lai\').value==\"\"\r\n" +
"                 || document.getElementById(\'Lai\').value==undefined)\r\n          " +
"      {\r\n                    alert (\"Vui lòng nhập số tiền lãi\");\r\n             " +
"       return false;\r\n                }\r\n\r\n                return true;\r\n       " +
"     }\r\n</script>\r\n");


        }
    }
}
#pragma warning restore 1591
