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

namespace HRM.QLBHXH.Views.dmTyLeDongBH
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
    
    #line 2 "..\..\Views\dmTyLeDongBH\Delete.cshtml"
    using HRM.Webpages.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/dmTyLeDongBH/Delete.cshtml")]
    public partial class Delete : System.Web.Mvc.WebViewPage<HRM.QLBHXH.Models.dmTyLeDongBHXH>
    {
        public Delete()
        {
        }
        public override void Execute()
        {



            
            #line 3 "..\..\Views\dmTyLeDongBH\Delete.cshtml"
  
    ViewBag.Title = "Delete";


            
            #line default
            #line hidden
WriteLiteral("<h3>\r\n    Bạn có chắc muốn xoá Tỷ lệ đóng Bảo hiểm này?</h3>\r\n<fieldset>\r\n    <le" +
"gend>dmTyLeDongBHXH</legend>\r\n    <div class=\"display-label\">\r\n        ");


            
            #line 11 "..\..\Views\dmTyLeDongBH\Delete.cshtml"
   Write(Html.VN("Ngày áp dụng:"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <b>");


            
            #line 12 "..\..\Views\dmTyLeDongBH\Delete.cshtml"
      Write(Html.DisplayFor(model => model.NgayApDung));

            
            #line default
            #line hidden
WriteLiteral("</b>\r\n    </div>\r\n    <div class=\"display-label\">\r\n        ");


            
            #line 15 "..\..\Views\dmTyLeDongBH\Delete.cshtml"
   Write(Html.VN("Ngày kết thúc:"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <b>");


            
            #line 16 "..\..\Views\dmTyLeDongBH\Delete.cshtml"
      Write(Html.DisplayFor(model => model.NgayKetThuc));

            
            #line default
            #line hidden
WriteLiteral("</b>\r\n    </div>\r\n    <div class=\"display-label\">\r\n        ");


            
            #line 19 "..\..\Views\dmTyLeDongBH\Delete.cshtml"
   Write(Html.VN("Tỷ lệ đóng BHXH - Doanh nghiệp (%):"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <b>");


            
            #line 20 "..\..\Views\dmTyLeDongBH\Delete.cshtml"
      Write(Html.DisplayFor(model => model.DoanhNghiepBHXH));

            
            #line default
            #line hidden
WriteLiteral("</b>\r\n    </div>\r\n    <div class=\"display-label\">\r\n        ");


            
            #line 23 "..\..\Views\dmTyLeDongBH\Delete.cshtml"
   Write(Html.VN("Tỷ lệ đóng BHXH - Người lao động (%):"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <b>");


            
            #line 24 "..\..\Views\dmTyLeDongBH\Delete.cshtml"
      Write(Html.DisplayFor(model => model.NguoiLDBHXH));

            
            #line default
            #line hidden
WriteLiteral("</b>\r\n    </div>\r\n    <div class=\"display-label\">\r\n        ");


            
            #line 27 "..\..\Views\dmTyLeDongBH\Delete.cshtml"
   Write(Html.VN("Tổng tỷ lệ đóng BHXH (%):"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <b>");


            
            #line 28 "..\..\Views\dmTyLeDongBH\Delete.cshtml"
      Write(Html.DisplayFor(model => model.TongBHXH));

            
            #line default
            #line hidden
WriteLiteral("</b>\r\n    </div>\r\n    <div class=\"display-label\">\r\n        ");


            
            #line 31 "..\..\Views\dmTyLeDongBH\Delete.cshtml"
   Write(Html.VN("Tỷ lệ đóng BHYT - Doanh nghiệp (%):"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <b>");


            
            #line 32 "..\..\Views\dmTyLeDongBH\Delete.cshtml"
      Write(Html.DisplayFor(model => model.DoanhNghiepBHYT));

            
            #line default
            #line hidden
WriteLiteral("</b>\r\n    </div>\r\n    <div class=\"display-label\">\r\n        ");


            
            #line 35 "..\..\Views\dmTyLeDongBH\Delete.cshtml"
   Write(Html.VN("Tỷ lệ đóng BHYT - Người lao động (%):"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <b>");


            
            #line 36 "..\..\Views\dmTyLeDongBH\Delete.cshtml"
      Write(Html.DisplayFor(model => model.NguoiLDBHYT));

            
            #line default
            #line hidden
WriteLiteral("</b>\r\n    </div>\r\n    <div class=\"display-label\">\r\n        ");


            
            #line 39 "..\..\Views\dmTyLeDongBH\Delete.cshtml"
   Write(Html.VN("Tổng tỷ lệ đóng BHYT (%):"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <b>");


            
            #line 40 "..\..\Views\dmTyLeDongBH\Delete.cshtml"
      Write(Html.DisplayFor(model => model.TongBHYT));

            
            #line default
            #line hidden
WriteLiteral("</b>\r\n    </div>\r\n    <div class=\"display-label\">\r\n        ");


            
            #line 43 "..\..\Views\dmTyLeDongBH\Delete.cshtml"
   Write(Html.VN("Tỷ lệ đóng BHTN - Doanh nghiệp (%):"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <b>");


            
            #line 44 "..\..\Views\dmTyLeDongBH\Delete.cshtml"
      Write(Html.DisplayFor(model => model.DoanhNghiepBHTN));

            
            #line default
            #line hidden
WriteLiteral("</b>\r\n    </div>\r\n    <div class=\"display-label\">\r\n        ");


            
            #line 47 "..\..\Views\dmTyLeDongBH\Delete.cshtml"
   Write(Html.VN("Tỷ lệ đóng BHTN - Người lao động (%):"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <b>");


            
            #line 48 "..\..\Views\dmTyLeDongBH\Delete.cshtml"
      Write(Html.DisplayFor(model => model.NguoiLDBHTN));

            
            #line default
            #line hidden
WriteLiteral("</b>\r\n    </div>\r\n    <div class=\"display-label\">\r\n        ");


            
            #line 51 "..\..\Views\dmTyLeDongBH\Delete.cshtml"
   Write(Html.VN("Tổng tỷ lệ đóng BHTN (%):"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <b>");


            
            #line 52 "..\..\Views\dmTyLeDongBH\Delete.cshtml"
      Write(Html.DisplayFor(model => model.TongBHTN));

            
            #line default
            #line hidden
WriteLiteral("</b>\r\n    </div>\r\n    <div class=\"display-label\">\r\n        ");


            
            #line 55 "..\..\Views\dmTyLeDongBH\Delete.cshtml"
   Write(Html.VN("Tổng tỷ lệ đóng Bảo hiểm (%):"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <b>");


            
            #line 56 "..\..\Views\dmTyLeDongBH\Delete.cshtml"
      Write(Html.DisplayFor(model => model.TongCong));

            
            #line default
            #line hidden
WriteLiteral("</b>\r\n    </div>\r\n    <div class=\"display-label\">\r\n        ");


            
            #line 59 "..\..\Views\dmTyLeDongBH\Delete.cshtml"
   Write(Html.VN("Đang áp dụng "));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <b>");


            
            #line 60 "..\..\Views\dmTyLeDongBH\Delete.cshtml"
      Write(Html.DisplayFor(model => model.TrangThai));

            
            #line default
            #line hidden
WriteLiteral("</b>\r\n    </div>\r\n</fieldset>\r\n");


            
            #line 63 "..\..\Views\dmTyLeDongBH\Delete.cshtml"
 using (Html.BeginForm())
{

            
            #line default
            #line hidden
WriteLiteral("    <p>\r\n        <input type=\"submit\" value=\"Xoá\" />\r\n        |\r\n        ");


            
            #line 68 "..\..\Views\dmTyLeDongBH\Delete.cshtml"
   Write(Html.ActionLink("Trở về màn hình Tỷ lệ đóng Bảo hiểm", "Index"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </p>\r\n");


            
            #line 70 "..\..\Views\dmTyLeDongBH\Delete.cshtml"
}

            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
