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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/dmMucLuongToiThieuVung/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<IEnumerable<HRM.QLBHXH.Models.dmMucLuongToiThieuVung>>
    {
        public Index()
        {
        }
        public override void Execute()
        {


            
            #line 2 "..\..\Views\dmMucLuongToiThieuVung\Index.cshtml"
  
    ViewBag.Title = "Danh mục Mức lương tối thiểu vùng - BHXH";


            
            #line default
            #line hidden
WriteLiteral("<h2>\r\n    Mức lương tối thiểu vùng</h2>\r\n<div>\r\n    ");


            
            #line 8 "..\..\Views\dmMucLuongToiThieuVung\Index.cshtml"
Write(Html.ActionLink("Trở về màn hình Nhân viên BHXH", "Index2", "NhanVienBHXH"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n<p>\r\n    ");


            
            #line 11 "..\..\Views\dmMucLuongToiThieuVung\Index.cshtml"
Write(Html.ActionLink("Thêm mức lương tối thiểu vùng - BHXH", "Create"));

            
            #line default
            #line hidden
WriteLiteral(@"
</p>
<table id=""dmMucLuongToiThieuVung"">
    <thead>
        <tr>
            <th style=""text-align: center"" nowrap>
                STT
            </th>
            <th style=""text-align: center"" nowrap>
                Thuộc vùng
            </th>
            <th style=""text-align: center"" nowrap>
                Trạng thái
            </th>
            <th style=""text-align: center"" nowrap>
                Ngày bắt đầu
            </th>
            <th style=""text-align: center"" nowrap>
                Ngày kết thúc
            </th>
            <th style=""text-align: center"" nowrap>
                Mức lương tối thiểu vùng (VNĐ)
            </th>
           
            <th style=""text-align: center"" nowrap>
                Ghi chú
            </th>
            <th>
            </th>
        </tr>
    </thead>
    <tbody>
");


            
            #line 43 "..\..\Views\dmMucLuongToiThieuVung\Index.cshtml"
         foreach (var item in Model)
        {
                

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <td style=\"text-align: center\" nowrap>\r\n       " +
"             ");


            
            #line 48 "..\..\Views\dmMucLuongToiThieuVung\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.STT));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align: center\" nowrap>\r\n" +
"                    ");


            
            #line 51 "..\..\Views\dmMucLuongToiThieuVung\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ThuocVung));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td nowrap>\r\n");


            
            #line 54 "..\..\Views\dmMucLuongToiThieuVung\Index.cshtml"
                     if (item.TrangThai == true)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <span><b>Đang áp dụng</b> </span>\r\n");


            
            #line 57 "..\..\Views\dmMucLuongToiThieuVung\Index.cshtml"
                    }
                    else
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <span></span>\r\n");


            
            #line 61 "..\..\Views\dmMucLuongToiThieuVung\Index.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </td>\r\n                <td style=\"text-align: center\" nowrap>\r\n  " +
"                  ");


            
            #line 64 "..\..\Views\dmMucLuongToiThieuVung\Index.cshtml"
               Write(item.NgayBatDau.ToShortDateString());

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align: center\" nowrap>\r\n" +
"                  \r\n");


            
            #line 68 "..\..\Views\dmMucLuongToiThieuVung\Index.cshtml"
                     if (@item.NgayKetThuc != null)
                    {
                        
            
            #line default
            #line hidden
            
            #line 70 "..\..\Views\dmMucLuongToiThieuVung\Index.cshtml"
                   Write(item.NgayKetThuc.GetValueOrDefault().ToShortDateString());

            
            #line default
            #line hidden
            
            #line 70 "..\..\Views\dmMucLuongToiThieuVung\Index.cshtml"
                                                                                 
                    }

            
            #line default
            #line hidden
WriteLiteral("                </td>\r\n                <td nowrap>\r\n                    ");


            
            #line 74 "..\..\Views\dmMucLuongToiThieuVung\Index.cshtml"
               Write(String.Format("{0:#,##0}", item.MucLuong));

            
            #line default
            #line hidden
WriteLiteral("\r\n                   \r\n                </td>\r\n                <td nowrap>\r\n      " +
"              ");


            
            #line 78 "..\..\Views\dmMucLuongToiThieuVung\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.GhiChu));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td>\r\n            <a href=\"dmMucLuongToi" +
"ThieuVung/Delete?id=");


            
            #line 81 "..\..\Views\dmMucLuongToiThieuVung\Index.cshtml"
                                                 Write(item.id);

            
            #line default
            #line hidden
WriteLiteral("\" title=\"Xoá\"><span class=\"ui-icon ui-icon-trash\" style=\"display:inline-block\"/><" +
"/a>\r\n            <a href=\"dmMucLuongToiThieuVung/Edit?id=");


            
            #line 82 "..\..\Views\dmMucLuongToiThieuVung\Index.cshtml"
                                               Write(item.id);

            
            #line default
            #line hidden
WriteLiteral("\" title=\"Chỉnh sửa\"><span class=\"ui-icon ui-icon-pencil\" style=\"display:inline-bl" +
"ock\"/></a>\r\n            </td>\r\n            </tr>\r\n");


            
            #line 85 "..\..\Views\dmMucLuongToiThieuVung\Index.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral(@"    </tbody>
</table>
<script src=""/Scripts/datatables/FixedColumns.js""></script>
<script src=""/Content/datatables/DataTableFixedHeader.js""></script>
<script>
    $(document).ready(function () {
        var oTable = $(""#dmMucLuongToiThieuVung"").dataTable({
            ""bAutoWidth"": true,
            ""bStateSave"": true,
            ""aLengthMenu"": [[10, 25, 50, -1], [10, 25, 50, ""All""]],
            ""bJQueryUI"": true,
            ""sScrollY"": ""100%"",
            ""sScrollX"": ""100%""
        });

        new $.fn.dataTable.FixedColumns(oTable, {
            ""iLeftColumns"": 3,
            ""iRightColumns"": 1
        });

    });

</script>
");


        }
    }
}
#pragma warning restore 1591
