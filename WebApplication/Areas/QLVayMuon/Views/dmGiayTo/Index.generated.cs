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

namespace HRM.QLVayMuon.Views.dmGiayTo
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
    
    #line 2 "..\..\Views\dmGiayTo\Index.cshtml"
    using HRM.Webpages.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/dmGiayTo/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<IEnumerable<HRM.QLVayMuon.Models.dmGiayTo>>
    {
        public Index()
        {
        }
        public override void Execute()
        {



            
            #line 3 "..\..\Views\dmGiayTo\Index.cshtml"
  
    ViewBag.Title = "Danh mục Giấy tờ";


            
            #line default
            #line hidden
WriteLiteral("\r\n   <div>\r\n    ");


            
            #line 8 "..\..\Views\dmGiayTo\Index.cshtml"
Write(Html.ActionLink("Trở về màn hình Danh Sách Nhân Viên Vay Mượn", "Index", "NhanVienVayMuon"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <p>\r\n    ");


            
            #line 11 "..\..\Views\dmGiayTo\Index.cshtml"
Write(Html.ActionLink("Thêm giấy tờ", "Create"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </p>\r\n   <p> <h3 align =center><font>Danh sách Giấy tờ vay mượn</font></h3>" +
"</p>\r\n");


            
            #line 14 "..\..\Views\dmGiayTo\Index.cshtml"
Write(Html.StatusMessage(TempData["Message"]));

            
            #line default
            #line hidden
WriteLiteral(@"
<table id=""dmGiayTo"">
    <thead>
        <tr>
        <th style=""text-align: center"" nowrap>
                STT
            </th>
            <th style=""text-align: center"" nowrap>
                Tên giấy tờ
            </th>
            <th style=""text-align: center"" nowrap>
                Thuộc mục đích
            </th>
            
            <th>
            </th>
        </tr>
    </thead>
    <tbody>
");


            
            #line 33 "..\..\Views\dmGiayTo\Index.cshtml"
         foreach (var item in Model)
        {
                

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n            <td style=\"text-align: center\" nowrap>\r\n           " +
"         ");


            
            #line 38 "..\..\Views\dmGiayTo\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.stt));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align: left\" nowrap>\r\n  " +
"                  ");


            
            #line 41 "..\..\Views\dmGiayTo\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TenGiayTo));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n               <td style=\"text-align: left\" nowrap>\r\n   " +
"                 ");


            
            #line 44 "..\..\Views\dmGiayTo\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.dmMucDichSuDung.TenMucDich));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                \r\n                <td>\r\n            <a h" +
"ref=\"dmGiayTo/Delete?id=");


            
            #line 48 "..\..\Views\dmGiayTo\Index.cshtml"
                                   Write(item.id);

            
            #line default
            #line hidden
WriteLiteral("\" title=\"Xoá\"><span class=\"ui-icon ui-icon-trash\" style=\"display:inline-block\"/><" +
"/a>\r\n            <a href=\"dmGiayTo/Edit?id=");


            
            #line 49 "..\..\Views\dmGiayTo\Index.cshtml"
                                 Write(item.id);

            
            #line default
            #line hidden
WriteLiteral("\" title=\"Chỉnh sửa\"><span class=\"ui-icon ui-icon-pencil\" style=\"display:inline-bl" +
"ock\"/></a>\r\n            </td>\r\n               </tr>\r\n");


            
            #line 52 "..\..\Views\dmGiayTo\Index.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral(@"    </tbody>
</table>
<script src=""/Scripts/datatables/FixedColumns.js""></script>
<script src=""/Content/datatables/DataTableFixedHeader.js""></script>
<script>
    $(document).ready(function () {
        var oTable = $('#dmGiayTo').dataTable({
            ""bJQueryUI"": true,
            ""sScrollY"": ""100%"",
            ""sScrollX"": ""100%""


        });
        //        new FixedHeader(oTable, { ""bottom"": true });

        new $.fn.dataTable.FixedColumns(oTable, {
            ""iLeftColumns"": 2,
            ""iRightColumns"": 1
        });

    });
</script>
<style type=""text/css"">
    #panel
    {
        text-align: left;
        background-color: #e5eecc;
        border: solid 1px #c3c3c3;
    }
    #panel
    {
        display: none;
    }
</style>");


        }
    }
}
#pragma warning restore 1591
