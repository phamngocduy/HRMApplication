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

namespace HRM.QLDanhMuc.Views.DonVi
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
    
    #line 2 "..\..\Views\DonVi\Index.cshtml"
    using HRM.QLDanhMuc.Models;
    
    #line default
    #line hidden
    
    #line 1 "..\..\Views\DonVi\Index.cshtml"
    using HRM.Webpages.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DonVi/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<IEnumerable<HRM.Databases.Models.dmDonVi>>
    {
        public Index()
        {
        }
        public override void Execute()
        {



WriteLiteral(@"
<p>
    <a class=""dialog"" href=""DonVi/Create"" title=""Thêm"">Thêm đơn vị</a>
</p>
<table id=""listDonVi"">
<thead>
    <tr>
        <th></th>
        <th>Mã</th>
        <th>Tên đơn vị</th>
        <th>Trực thuộc</th>
        <th></th>
    </tr>
</thead>
<tbody>
");


            
            #line 19 "..\..\Views\DonVi\Index.cshtml"
 foreach (var item in Model) {

            
            #line default
            #line hidden
WriteLiteral("    <tr>\r\n        <td>\r\n            ");


            
            #line 22 "..\..\Views\DonVi\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.stt));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 25 "..\..\Views\DonVi\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.maDonVi));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 28 "..\..\Views\DonVi\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.tenDonVi));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 31 "..\..\Views\DonVi\Index.cshtml"
       Write(item.tenDonViChuQuan());

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td align=\"right\">\r\n            <a class=\"dopost\" href=\"" +
"DonVi/Delete?id=");


            
            #line 34 "..\..\Views\DonVi\Index.cshtml"
                                               Write(item.id);

            
            #line default
            #line hidden
WriteLiteral("\" title=\"Xóa\"><span class=\"ui-icon ui-icon-trash\" style=\"display:inline-block\"/><" +
"/a>\r\n            <a class=\"dialog\" href=\"DonVi/Edit?id=");


            
            #line 35 "..\..\Views\DonVi\Index.cshtml"
                                             Write(item.id);

            
            #line default
            #line hidden
WriteLiteral("\" title=\"Sửa\"><span class=\"ui-icon ui-icon-pencil\" style=\"display:inline-block\"/>" +
"</a>\r\n        </td>\r\n    </tr>\r\n");


            
            #line 38 "..\..\Views\DonVi\Index.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("</tbody>\r\n</table>\r\n<script>\r\n    ");


            
            #line 42 "..\..\Views\DonVi\Index.cshtml"
Write(Html.dataTables("listDonVi"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</script>\r\n");


        }
    }
}
#pragma warning restore 1591