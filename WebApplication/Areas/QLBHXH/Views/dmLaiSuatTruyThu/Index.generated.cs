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

namespace HRM.QLBHXH.Views.dmLaiSuatTruyThu
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
    
    #line 1 "..\..\Views\dmLaiSuatTruyThu\Index.cshtml"
    using HRM.Webpages.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/dmLaiSuatTruyThu/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<IEnumerable<HRM.QLBHXH.Models.dmLaiSuatTruyThu>>
    {
        public Index()
        {
        }
        public override void Execute()
        {


WriteLiteral("<script src=\"/Scripts/jquery.validate.unobtrusive.js\"></script>\r\n");


            
            #line 4 "..\..\Views\dmLaiSuatTruyThu\Index.cshtml"
  
    ViewBag.Title = "Danh mục lãi suất truy thu";


            
            #line default
            #line hidden
WriteLiteral("\r\n<h2>Danh mục lãi suất truy thu</h2>\r\n\r\n<p>\r\n    ");


            
            #line 11 "..\..\Views\dmLaiSuatTruyThu\Index.cshtml"
Write(Html.ActionLink("Thêm mới", "Create"));

            
            #line default
            #line hidden
WriteLiteral(@"
</p>
<table id=""LaiSuatTruyThu"">
<thead>
    <tr>
        <th nowrap>
           STT
        </th>
        <th nowrap>
            Ngày áp dụng
        </th>
        <th nowrap>
            Ngày kết thúc
        </th>
        <th nowrap> 
            BHXH
        </th>
        <th nowrap>
            ");


            
            #line 29 "..\..\Views\dmLaiSuatTruyThu\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.BHYT));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </th>\r\n        <th nowrap>\r\n            ");


            
            #line 32 "..\..\Views\dmLaiSuatTruyThu\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.BHTN));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </th>\r\n\r\n        <th></th>\r\n        <th></th>\r\n    </tr>\r\n    </thead>\r" +
"\n    <tbody>\r\n    \r\n");


            
            #line 41 "..\..\Views\dmLaiSuatTruyThu\Index.cshtml"
 foreach (var item in Model) {

            
            #line default
            #line hidden
WriteLiteral("    <tr>\r\n            <td>\r\n            ");


            
            #line 44 "..\..\Views\dmLaiSuatTruyThu\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.STT));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 47 "..\..\Views\dmLaiSuatTruyThu\Index.cshtml"
       Write(item.NgayApDung.Value.ToShortDateString());

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 50 "..\..\Views\dmLaiSuatTruyThu\Index.cshtml"
       Write(item.NgayKetThuc.Value.ToShortDateString());

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 53 "..\..\Views\dmLaiSuatTruyThu\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.BHXH));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 56 "..\..\Views\dmLaiSuatTruyThu\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.BHYT));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 59 "..\..\Views\dmLaiSuatTruyThu\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.BHTN));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n\r\n        <td>\r\n<td align=\"right\" nowrap>        \r\n            <" +
"a class=\"dialog\" href=\"dmLaiSuatTruyThu/Edit?id=");


            
            #line 64 "..\..\Views\dmLaiSuatTruyThu\Index.cshtml"
                                                        Write(item.id);

            
            #line default
            #line hidden
WriteLiteral("\" title=\"Chỉnh sửa\"><span class=\"ui-icon ui-icon-pencil\" style=\"display:inline-bl" +
"ock\"/></a>\r\n             <a class=\"dialog\" href=\"dmLaiSuatTruyThu/Delete?id=");


            
            #line 65 "..\..\Views\dmLaiSuatTruyThu\Index.cshtml"
                                                           Write(item.id);

            
            #line default
            #line hidden
WriteLiteral("\" title=\"Xóa\"><span class=\"ui-icon ui-icon-trash\" style=\"display:inline-block\"/><" +
"/a> \r\n        </td>\r\n        </td>>\r\n    </tr>\r\n");


            
            #line 69 "..\..\Views\dmLaiSuatTruyThu\Index.cshtml"
}   

            
            #line default
            #line hidden
WriteLiteral(@"</tbody>
</table>


<script>
    $(document).ready(function () {
        $(""#LaiSuatTruyThu"").dataTable({
            ""bAutoWidth"": false,
            ""bStateSave"": true,
            ""aLengthMenu"": [[10, 25, 50, -1], [10, 25, 50, ""All""]]
        });
    });
  </script>");


        }
    }
}
#pragma warning restore 1591
