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

namespace HRM.QLVayMuon.Views.KhoanVay
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
    
    #line 2 "..\..\Views\KhoanVay\Create.cshtml"
    using HRM.QLVayMuon.Models;
    
    #line default
    #line hidden
    
    #line 1 "..\..\Views\KhoanVay\Create.cshtml"
    using HRM.Webpages.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/KhoanVay/Create.cshtml")]
    public partial class Create : System.Web.Mvc.WebViewPage<HRM.QLVayMuon.Models.KhoanVay>
    {
        public Create()
        {
        }
        public override void Execute()
        {



WriteLiteral("\r\n\r\n");


            
            #line 6 "..\..\Views\KhoanVay\Create.cshtml"
  
    HRMDB1Entities db = new HRMDB1Entities();
    int NV_id = ViewBag.NV_id;
    int mdsd=(int)ViewBag.mdsd;
 

            
            #line default
            #line hidden

            
            #line 11 "..\..\Views\KhoanVay\Create.cshtml"
Write(Html.BeginDiv());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n <p><b>Khoản vay của:\r\n    ");


            
            #line 14 "..\..\Views\KhoanVay\Create.cshtml"
Write(db.NhanVienVayMuon.FirstOrDefault(kv => kv.id == NV_id).MaNV);

            
            #line default
            #line hidden
WriteLiteral(" -\r\n    ");


            
            #line 15 "..\..\Views\KhoanVay\Create.cshtml"
Write(db.NhanVienVayMuon.FirstOrDefault(kv => kv.id == NV_id).HoVaTen);

            
            #line default
            #line hidden
WriteLiteral(" -\r\n    ");


            
            #line 16 "..\..\Views\KhoanVay\Create.cshtml"
Write(db.NhanVienVayMuon.FirstOrDefault(kv => kv.id == NV_id).DonVi);

            
            #line default
            #line hidden
WriteLiteral("</b>\r\n</p>\r\n");


            
            #line 18 "..\..\Views\KhoanVay\Create.cshtml"
 using (Html.BeginForm())
{
    
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\KhoanVay\Create.cshtml"
Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\KhoanVay\Create.cshtml"
                                 


    

            
            #line default
            #line hidden
WriteLiteral("<fieldset>\r\n        <legend>KhoanVay</legend>\r\n            ");


            
            #line 26 "..\..\Views\KhoanVay\Create.cshtml"
       Write(Html.HiddenFor(model => model.idNhanVienVayMuon, new { @Value = @NV_id}));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div class=\"editor-label\">\r\n            ");


            
            #line 28 "..\..\Views\KhoanVay\Create.cshtml"
       Write(Html.VN("Mục đích sử dụng"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div id=\"Combobox\">\r\n            ");


            
            #line 31 "..\..\Views\KhoanVay\Create.cshtml"
       Write(Html.DropDownListFor(model => model.idMucDichSuDung,new SelectList(db.dmMucDichSuDung, "id", "tenmucdich"),mdsd));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 32 "..\..\Views\KhoanVay\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.idMucDichSuDung));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"editor-label\">\r\n            ");


            
            #line 36 "..\..\Views\KhoanVay\Create.cshtml"
       Write(Html.VN("Số chứng từ"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");


            
            #line 39 "..\..\Views\KhoanVay\Create.cshtml"
       Write(Html.EditorFor(model => model.SoChungTu));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 40 "..\..\Views\KhoanVay\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.SoChungTu));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"editor-label\">\r\n            ");


            
            #line 44 "..\..\Views\KhoanVay\Create.cshtml"
       Write(Html.VN("Ngày chứng từ"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");


            
            #line 47 "..\..\Views\KhoanVay\Create.cshtml"
       Write(Html.EditorFor(model => model.NgayChungTu));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 48 "..\..\Views\KhoanVay\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.NgayChungTu));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"editor-label\">\r\n            ");


            
            #line 52 "..\..\Views\KhoanVay\Create.cshtml"
       Write(Html.VN("Diễn giải"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");


            
            #line 55 "..\..\Views\KhoanVay\Create.cshtml"
       Write(Html.EditorFor(model => model.DienGiai));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 56 "..\..\Views\KhoanVay\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.DienGiai));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"editor-label\">\r\n            ");


            
            #line 60 "..\..\Views\KhoanVay\Create.cshtml"
       Write(Html.VN("Định mức"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");


            
            #line 63 "..\..\Views\KhoanVay\Create.cshtml"
       Write(Html.EditorFor(model => model.DinhMuc));

            
            #line default
            #line hidden
WriteLiteral(" \r\n            ");


            
            #line 64 "..\..\Views\KhoanVay\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.DinhMuc));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"editor-label\">\r\n            ");


            
            #line 68 "..\..\Views\KhoanVay\Create.cshtml"
       Write(Html.VN("Số tiền vay"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");


            
            #line 71 "..\..\Views\KhoanVay\Create.cshtml"
       Write(Html.HiddenFor(model => model.SoTienVay));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 72 "..\..\Views\KhoanVay\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.SoTienVay));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n         <input id=\"Vay\"  value=\"\" />\r\n\r\n        <div class=\"" +
"editor-label\">\r\n            ");


            
            #line 78 "..\..\Views\KhoanVay\Create.cshtml"
       Write(Html.VN("Số tháng"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");


            
            #line 81 "..\..\Views\KhoanVay\Create.cshtml"
       Write(Html.EditorFor(model => model.SoThang));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 82 "..\..\Views\KhoanVay\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.SoThang));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n");



WriteLiteral("\r\n\r\n        <div class=\"editor-label\">\r\n            ");


            
            #line 94 "..\..\Views\KhoanVay\Create.cshtml"
       Write(Html.VN("Trả từ tháng"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");


            
            #line 97 "..\..\Views\KhoanVay\Create.cshtml"
       Write(Html.EditorFor(model => model.TraTuThang));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 98 "..\..\Views\KhoanVay\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.TraTuThang));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"editor-label\">\r\n            ");


            
            #line 102 "..\..\Views\KhoanVay\Create.cshtml"
       Write(Html.VN("Trả đến tháng"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");


            
            #line 105 "..\..\Views\KhoanVay\Create.cshtml"
       Write(Html.EditorFor(model => model.TraDenThang));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 106 "..\..\Views\KhoanVay\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.TraDenThang));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n        <p>\r\n            <input type=\"submit\" value=\"Tạo\" onc" +
"lick=\"return check();\"/>\r\n        </p>\r\n    </fieldset>\r\n");


            
            #line 113 "..\..\Views\KhoanVay\Create.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\r\n");



WriteLiteral("\r\n\r\n<div>\r\n    ");


            
            #line 121 "..\..\Views\KhoanVay\Create.cshtml"
Write(Html.ActionLink("Trở về danh sách khoản vay", "Index", new { NV_id = NV_id }));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");


            
            #line 123 "..\..\Views\KhoanVay\Create.cshtml"
Write(Html.EndDiv());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<script>\r\n    $(\"#NgayChungTu\").datepicker({\r\n        changeDay: true,\r\n     " +
"  changeMonth: true,\r\n        changeYear: true,\r\n    });\r\n    $(\"#TraTuThang\").d" +
"atepicker({\r\n        changeDay: true,\r\n       changeMonth: true,\r\n        change" +
"Year: true,\r\n    });\r\n    $(\"#TraDenThang\").datepicker({\r\n        changeDay: tru" +
"e,\r\n       changeMonth: true,\r\n        changeYear: true,\r\n    });\r\n   \r\n    $(\"#" +
"idMucDichSuDung\").combobox();\r\n\r\n\r\n\r\n\r\n//tu them dau phay vao so\r\n$(\'#Vay\').keyu" +
"p(function(event) {\r\n\r\n  // skip for arrow keys\r\n  if(event.which >= 37 && event" +
".which <= 40){\r\n    event.preventDefault();\r\n  }\r\n\r\n  $(this).val(function(index" +
", value) {\r\n    return value\r\n      .replace(/\\D/g, \"\")\r\n      .replace(/\\B(?=(\\" +
"d{3})+(?!\\d))/g, \".\")\r\n    ;\r\n  });\r\n\r\n\r\n\r\n\r\n});\r\n\r\n\r\n\r\n    $(\"#Vay\").keyup(func" +
"tion () {\r\n\r\n            //Clear the hidden field\r\n            $(\"#SoTienVay\").v" +
"al(\"\");\r\n\r\n            //Create char array from phone number field\r\n            " +
"var charArray = $(this).val().split(\"\");\r\n\r\n            var phoneNumber = \"\";\r\n\r" +
"\n            //Iterate over each character in the char array\r\n            //and " +
"determine if it is a number\r\n            $.each(charArray, function (index, valu" +
"e) {\r\n                if (!isNaN(value) && value != \" \") {\r\n                    " +
"phoneNumber = phoneNumber + value;\r\n                }\r\n            });\r\n\r\n      " +
"      //Set hidden field\r\n            $(\"#SoTienVay\").val(phoneNumber);\r\n       " +
" });\r\n\r\n\r\n        var tratu = $(\"[id$=TraTuThang\");\r\n                var tratu1 " +
"= $(\"[id$=SoThang\");\r\n        tratu.change(function () {\r\n        var str = $(tr" +
"atu).val();\r\n         var str1 = $(tratu1).val();\r\n         ngay1=parseInt(str1)" +
"\r\n\r\nvar res = str.split(\"/\");\r\nka1 = res[0]\r\nka2 = res[1]\r\nka3 = res[2]\r\n\r\n\r\n\r\nn" +
"gay=parseInt(ka1)\r\nthang=parseInt(ka2)+ngay1-1\r\nnam=parseInt(ka3)\r\n\r\n\r\nif(thang>" +
"12){ thang=thang-12; nam=nam+1;}\r\nif(thang>24){ thang=thang-24; nam=nam+2;}\r\nif(" +
"thang>36){ thang=thang-36; nam=nam+3;}\r\n\r\n\r\nii=ngaythangnam=ngay+\"/\"+thang+\"/\"+n" +
"am\r\n $(\"[id$=TraDenThang]\").val(ii);\r\n        });\r\n\r\n\r\n\r\n     function check()\r\n" +
"            {\r\n                if (document.getElementById(\'Vay\').value==\"\"\r\n   " +
"              || document.getElementById(\'Vay\').value==undefined)\r\n             " +
"   {\r\n                    alert (\"Vui lòng nhập số tiền vay\");\r\n                " +
"    return false;\r\n                }\r\n\r\n          \r\n\r\n                return tru" +
"e;\r\n            }\r\n\r\n</script>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");


        }
    }
}
#pragma warning restore 1591
