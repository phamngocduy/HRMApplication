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

namespace HRM.QLVayMuon.Views.dmMucDichSuDung
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/dmMucDichSuDung/Edit.cshtml")]
    public partial class Edit : System.Web.Mvc.WebViewPage<HRM.QLVayMuon.Models.dmMucDichSuDung>
    {
        public Edit()
        {
        }
        public override void Execute()
        {


            
            #line 2 "..\..\Views\dmMucDichSuDung\Edit.cshtml"
  
    ViewBag.Title = "Edit";


            
            #line default
            #line hidden
WriteLiteral("<h2>\r\n    Chỉnh sửa</h2>\r\n");


            
            #line 7 "..\..\Views\dmMucDichSuDung\Edit.cshtml"
 using (Html.BeginForm())
{
    
            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\dmMucDichSuDung\Edit.cshtml"
Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\dmMucDichSuDung\Edit.cshtml"
                                 


            
            #line default
            #line hidden
WriteLiteral("    <fieldset>\r\n        <legend>dmMucDichSuDung</legend>\r\n        ");


            
            #line 13 "..\..\Views\dmMucDichSuDung\Edit.cshtml"
   Write(Html.HiddenFor(model => model.id));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div class=\"editor-label\">\r\n            ");


            
            #line 15 "..\..\Views\dmMucDichSuDung\Edit.cshtml"
       Write(Html.LabelFor(model => model.MaMucDich, "Mã mục đích"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");


            
            #line 18 "..\..\Views\dmMucDichSuDung\Edit.cshtml"
       Write(Html.EditorFor(model => model.MaMucDich));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 19 "..\..\Views\dmMucDichSuDung\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.MaMucDich));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-label\">\r\n            ");


            
            #line 22 "..\..\Views\dmMucDichSuDung\Edit.cshtml"
       Write(Html.LabelFor(model => model.TenMucDich, "Tên mục đích"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");


            
            #line 25 "..\..\Views\dmMucDichSuDung\Edit.cshtml"
       Write(Html.EditorFor(model => model.TenMucDich));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 26 "..\..\Views\dmMucDichSuDung\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.TenMucDich));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-label\">\r\n            ");


            
            #line 29 "..\..\Views\dmMucDichSuDung\Edit.cshtml"
       Write(Html.LabelFor(model => model.HanMucToiDa, "Hạn mức tối đa (VNĐ)"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");


            
            #line 32 "..\..\Views\dmMucDichSuDung\Edit.cshtml"
       Write(Html.HiddenFor(model => model.HanMucToiDa));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 33 "..\..\Views\dmMucDichSuDung\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.HanMucToiDa));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <input id=\"HanMuc\"  value= ");


            
            #line 35 "..\..\Views\dmMucDichSuDung\Edit.cshtml"
                              Write(String.Format("{0:#,##0}", Model.HanMucToiDa));

            
            #line default
            #line hidden
WriteLiteral(" />\r\n        <div class=\"editor-label\">\r\n            ");


            
            #line 37 "..\..\Views\dmMucDichSuDung\Edit.cshtml"
       Write(Html.LabelFor(model => model.ThoiGianHoanTien, "Thời gian hoàn tiền"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");


            
            #line 40 "..\..\Views\dmMucDichSuDung\Edit.cshtml"
       Write(Html.EditorFor(model => model.ThoiGianHoanTien));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 41 "..\..\Views\dmMucDichSuDung\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.ThoiGianHoanTien));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-label\">\r\n            ");


            
            #line 44 "..\..\Views\dmMucDichSuDung\Edit.cshtml"
       Write(Html.LabelFor(model => model.DonViThoiGian, "Đơn vị thời gian"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");


            
            #line 47 "..\..\Views\dmMucDichSuDung\Edit.cshtml"
       Write(Html.EditorFor(model => model.DonViThoiGian));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 48 "..\..\Views\dmMucDichSuDung\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.DonViThoiGian));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-label\">\r\n            ");


            
            #line 51 "..\..\Views\dmMucDichSuDung\Edit.cshtml"
       Write(Html.LabelFor(model => model.GhiChu, "Ghi chú"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div class=\"editor-field\">\r\n            ");


            
            #line 54 "..\..\Views\dmMucDichSuDung\Edit.cshtml"
       Write(Html.EditorFor(model => model.GhiChu));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 55 "..\..\Views\dmMucDichSuDung\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.GhiChu));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <p>\r\n            <input type=\"submit\" value=\"Lưu\" />\r\n " +
"       </p>\r\n    </fieldset>\r\n");


            
            #line 61 "..\..\Views\dmMucDichSuDung\Edit.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("<div>\r\n    ");


            
            #line 63 "..\..\Views\dmMucDichSuDung\Edit.cshtml"
Write(Html.ActionLink("Trở về màn hình Danh sách Mục đích sử dụng", "Index"));

            
            #line default
            #line hidden
WriteLiteral(@"
</div>
<script>
    

    //tu them dau phay vao so
    $('#HanMuc').keyup(function (event) {

        // skip for arrow keys
        if (event.which >= 37 && event.which <= 40) {
            event.preventDefault();
        }

        $(this).val(function (index, value) {
            return value
      .replace(/\D/g, """")
      .replace(/\B(?=(\d{3})+(?!\d))/g, ""."");
        });
    });

    $(""#HanMuc"").keyup(function () {

        //Clear the hidden field
        $(""#HanMucToiDa"").val("""");

        //Create char array from phone number field
        var charArray = $(this).val().split("""");

        var phoneNumber = """";

        //Iterate over each character in the char array
        //and determine if it is a number
        $.each(charArray, function (index, value) {
            if (!isNaN(value) && value != "" "") {
                phoneNumber = phoneNumber + value;
            }
        });

        //Set hidden field
        $(""#HanMucToiDa"").val(phoneNumber);
    });
</script>
");


        }
    }
}
#pragma warning restore 1591
