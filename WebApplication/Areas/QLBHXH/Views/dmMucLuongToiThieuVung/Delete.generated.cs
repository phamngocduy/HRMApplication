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

namespace HRM.QLBHXH.Views.dmMucLuongToiThieuVung
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
    
    #line 2 "..\..\Views\dmMucLuongToiThieuVung\Delete.cshtml"
    using HRM.Webpages.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/dmMucLuongToiThieuVung/Delete.cshtml")]
    public partial class Delete : System.Web.Mvc.WebViewPage<HRM.QLBHXH.Models.dmMucLuongToiThieuVung>
    {
        public Delete()
        {
        }
        public override void Execute()
        {



            
            #line 3 "..\..\Views\dmMucLuongToiThieuVung\Delete.cshtml"
  
    ViewBag.Title = "Delete";


            
            #line default
            #line hidden
WriteLiteral("<h3>\r\n    Bạn có chắc muốn xoá Mức lương tối thiểu vùng này?</h3>\r\n<fieldset>\r\n  " +
"  <legend>dmMucLuongToiThieuChung</legend>\r\n    <div class=\"display-label\">\r\n   " +
"     ");


            
            #line 11 "..\..\Views\dmMucLuongToiThieuVung\Delete.cshtml"
   Write(Html.VN("Ngày bắt đầu:"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <b>");


            
            #line 12 "..\..\Views\dmMucLuongToiThieuVung\Delete.cshtml"
      Write(Html.DisplayFor(model => model.NgayBatDau));

            
            #line default
            #line hidden
WriteLiteral("</b>\r\n    </div>\r\n    <div class=\"display-label\">\r\n        ");


            
            #line 15 "..\..\Views\dmMucLuongToiThieuVung\Delete.cshtml"
   Write(Html.VN("Ngày kết thúc:"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <b>");


            
            #line 16 "..\..\Views\dmMucLuongToiThieuVung\Delete.cshtml"
      Write(Html.DisplayFor(model => model.NgayKetThuc));

            
            #line default
            #line hidden
WriteLiteral("</b>\r\n    </div>\r\n    <div class=\"display-label\">\r\n        ");


            
            #line 19 "..\..\Views\dmMucLuongToiThieuVung\Delete.cshtml"
   Write(Html.VN("Mức lương tối thiểu vùng (VNĐ):"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <b>");


            
            #line 20 "..\..\Views\dmMucLuongToiThieuVung\Delete.cshtml"
      Write(String.Format("{0:#,##0}", Model.MucLuong));

            
            #line default
            #line hidden
WriteLiteral("</b>\r\n    </div>\r\n    <div class=\"display-label\">\r\n        ");


            
            #line 23 "..\..\Views\dmMucLuongToiThieuVung\Delete.cshtml"
   Write(Html.VN("Thuộc vùng:"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <b>");


            
            #line 24 "..\..\Views\dmMucLuongToiThieuVung\Delete.cshtml"
      Write(Html.DisplayFor(model => model.ThuocVung));

            
            #line default
            #line hidden
WriteLiteral("</b>\r\n    </div>\r\n    <div class=\"display-label\">\r\n        ");


            
            #line 27 "..\..\Views\dmMucLuongToiThieuVung\Delete.cshtml"
   Write(Html.VN("Đang áp dụng "));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <b>");


            
            #line 28 "..\..\Views\dmMucLuongToiThieuVung\Delete.cshtml"
      Write(Html.DisplayFor(model => model.TrangThai));

            
            #line default
            #line hidden
WriteLiteral("</b>\r\n    </div>\r\n    <div class=\"display-label\">\r\n        ");


            
            #line 31 "..\..\Views\dmMucLuongToiThieuVung\Delete.cshtml"
   Write(Html.VN("Ghi chú:"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <b>");


            
            #line 32 "..\..\Views\dmMucLuongToiThieuVung\Delete.cshtml"
      Write(Html.DisplayFor(model => model.GhiChu));

            
            #line default
            #line hidden
WriteLiteral("</b>\r\n    </div>\r\n</fieldset>\r\n");


            
            #line 35 "..\..\Views\dmMucLuongToiThieuVung\Delete.cshtml"
 using (Html.BeginForm())
{

            
            #line default
            #line hidden
WriteLiteral("    <p>\r\n        <input type=\"submit\" value=\"Xoá\" />\r\n        |\r\n        ");


            
            #line 40 "..\..\Views\dmMucLuongToiThieuVung\Delete.cshtml"
   Write(Html.ActionLink("Trở về màn hình Mức lương tối thiểu vùng", "Index"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </p>\r\n");


            
            #line 42 "..\..\Views\dmMucLuongToiThieuVung\Delete.cshtml"
}

            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
