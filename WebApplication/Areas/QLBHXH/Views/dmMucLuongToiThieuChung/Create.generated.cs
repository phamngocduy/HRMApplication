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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/dmMucLuongToiThieuChung/Create.cshtml")]
    public partial class Create : System.Web.Mvc.WebViewPage<HRM.QLBHXH.Models.dmMucLuongToiThieuChung>
    {
        public Create()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\dmMucLuongToiThieuChung\Create.cshtml"
  
    ViewBag.Title = "Create";

            
            #line default
            #line hidden
WriteLiteral("\r\n<h2>Thêm mới</h2>\r\n");

            
            #line 7 "..\..\Views\dmMucLuongToiThieuChung\Create.cshtml"
 using (Html.BeginForm())
{
    
            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\dmMucLuongToiThieuChung\Create.cshtml"
Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\dmMucLuongToiThieuChung\Create.cshtml"
                                 


            
            #line default
            #line hidden
WriteLiteral("    <fieldset>\r\n        <legend>dmMucLuongToiThieuChung</legend>\r\n      <b> Ngày " +
"bắt đầu</b>\r\n       \r\n      \r\n");

WriteLiteral("            ");

            
            #line 16 "..\..\Views\dmMucLuongToiThieuChung\Create.cshtml"
       Write(Html.TextBoxFor(model => model.NgayBatDau, new { style = "width: 100px"}));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 17 "..\..\Views\dmMucLuongToiThieuChung\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.NgayBatDau));

            
            #line default
            #line hidden
WriteLiteral("\r\n        \r\n      <b>Ngày kết thúc</b>\r\n     \r\n");

WriteLiteral("           ");

            
            #line 21 "..\..\Views\dmMucLuongToiThieuChung\Create.cshtml"
      Write(Html.TextBoxFor(model => model.NgayKetThuc, new { style = "width: 100px"}));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 22 "..\..\Views\dmMucLuongToiThieuChung\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.NgayKetThuc));

            
            #line default
            #line hidden
WriteLiteral("\r\n     \r\n        <div >\r\n        <b>  Mức lương tối thiểu chung (VNĐ)</b>\r\n      " +
"      <input");

WriteLiteral(" id=\"MucLuongTTC\"");

WriteLiteral(" value=\"\"");

WriteLiteral(" />\r\n    \r\n");

WriteLiteral("            ");

            
            #line 28 "..\..\Views\dmMucLuongToiThieuChung\Create.cshtml"
       Write(Html.HiddenFor(model => model.MucLuong));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 29 "..\..\Views\dmMucLuongToiThieuChung\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.MucLuong));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n      <div >\r\n         <b> Ghi chú</b>\r\n       \r\n");

WriteLiteral("            ");

            
            #line 34 "..\..\Views\dmMucLuongToiThieuChung\Create.cshtml"
       Write(Html.EditorFor(model => model.GhiChu));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 35 "..\..\Views\dmMucLuongToiThieuChung\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.GhiChu));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div >\r\n          <b>Đang áp dụng</b>\r\n  \r\n");

WriteLiteral("            ");

            
            #line 40 "..\..\Views\dmMucLuongToiThieuChung\Create.cshtml"
       Write(Html.EditorFor(model => model.TrangThai));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 41 "..\..\Views\dmMucLuongToiThieuChung\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.TrangThai));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    \r\n        <p>\r\n            <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Tạo\"");

WriteLiteral(" />\r\n        </p>\r\n    </fieldset>\r\n");

            
            #line 48 "..\..\Views\dmMucLuongToiThieuChung\Create.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral(@"
<script>
$(""#NgayBatDau"").datepicker({
        changeDay: true,
       changeMonth: true,
        changeYear: true,
    });
    $(""#NgayKetThuc"").datepicker({
        changeDay: true,
       changeMonth: true,
        changeYear: true,
    });

//tu them dau phay vao so
$('#MucLuongTTC').keyup(function(event) {

  // skip for arrow keys
  if(event.which >= 37 && event.which <= 40){
    event.preventDefault();
  }

  $(this).val(function(index, value) {
    return value
      .replace(/\D/g, """")
      .replace(/\B(?=(\d{3})+(?!\d))/g, ""."")
    ;
  });




});



    $(""#MucLuongTTC"").keyup(function () {

            //Clear the hidden field
            $(""#MucLuong"").val("""");

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
            $(""#MucLuong"").val(phoneNumber);
        });




</script>
");

        }
    }
}
#pragma warning restore 1591
