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

namespace HRM.QLBHXH.Views.QTBHXH
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/QTBHXH/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<IEnumerable<HRM.QLBHXH.Models.nvbhQuaTrinhBHXH>>
    {
        public Index()
        {
        }
        public override void Execute()
        {

WriteLiteral("\r\n");


            
            #line 3 "..\..\Views\QTBHXH\Index.cshtml"
  
    ViewBag.Title = "Index";


            
            #line default
            #line hidden
WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");


            
            #line 10 "..\..\Views\QTBHXH\Index.cshtml"
Write(Html.ActionLink("Create New", "Create"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</p>\r\n<table>\r\n    <tr>\r\n        <th>\r\n            ");



WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");


            
            #line 18 "..\..\Views\QTBHXH\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.ThoiGianBatDau));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");


            
            #line 21 "..\..\Views\QTBHXH\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.ThoiGianKetThuc));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");


            
            #line 24 "..\..\Views\QTBHXH\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.MucLuongDongBHXH));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");


            
            #line 27 "..\..\Views\QTBHXH\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.MucDongBHXH));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");


            
            #line 30 "..\..\Views\QTBHXH\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.MucDongBHTN));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");


            
            #line 33 "..\..\Views\QTBHXH\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.HeSoTienLuongDongBHXH));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");


            
            #line 36 "..\..\Views\QTBHXH\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.MucDongToiThieu));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");


            
            #line 39 "..\..\Views\QTBHXH\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.GhiChu1));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");


            
            #line 42 "..\..\Views\QTBHXH\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.GhiChu2));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n\r\n");


            
            #line 47 "..\..\Views\QTBHXH\Index.cshtml"
 foreach (var item in Model) {

            
            #line default
            #line hidden
WriteLiteral("    <tr>\r\n        <td>\r\n            ");



WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 53 "..\..\Views\QTBHXH\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.ThoiGianBatDau));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 56 "..\..\Views\QTBHXH\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.ThoiGianKetThuc));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 59 "..\..\Views\QTBHXH\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.MucLuongDongBHXH));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 62 "..\..\Views\QTBHXH\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.MucDongBHXH));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 65 "..\..\Views\QTBHXH\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.MucDongBHTN));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 68 "..\..\Views\QTBHXH\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.HeSoTienLuongDongBHXH));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 71 "..\..\Views\QTBHXH\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.MucDongToiThieu));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 74 "..\..\Views\QTBHXH\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.GhiChu1));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 77 "..\..\Views\QTBHXH\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.GhiChu2));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 80 "..\..\Views\QTBHXH\Index.cshtml"
       Write(Html.ActionLink("Edit", "Edit", new { id=item.id }));

            
            #line default
            #line hidden
WriteLiteral(" |\r\n            ");


            
            #line 81 "..\..\Views\QTBHXH\Index.cshtml"
       Write(Html.ActionLink("Details", "Details", new { id=item.id }));

            
            #line default
            #line hidden
WriteLiteral(" |\r\n            ");


            
            #line 82 "..\..\Views\QTBHXH\Index.cshtml"
       Write(Html.ActionLink("Delete", "Delete", new { id=item.id }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");


            
            #line 85 "..\..\Views\QTBHXH\Index.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n</table>\r\n");


        }
    }
}
#pragma warning restore 1591