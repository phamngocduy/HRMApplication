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

namespace HRM.QLDanhMuc.Views.PhuongXa
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
    
    #line 1 "..\..\Views\PhuongXa\Index.cshtml"
    using HRM.Webpages.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/PhuongXa/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<IEnumerable<HRM.Databases.Models.dmPhuongXa>>
    {
        public Index()
        {
        }
        public override void Execute()
        {




WriteLiteral("\r\n<table id=\"phuongxa\">\r\n<thead>\r\n    <tr>\r\n        <th>STT</th>\r\n        <th>Mã<" +
"/th>\r\n        <th>Tên ");


            
            #line 11 "..\..\Views\PhuongXa\Index.cshtml"
           Write(Html.VN("PhuongXa"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n        <th>Tên ");


            
            #line 12 "..\..\Views\PhuongXa\Index.cshtml"
           Write(Html.VN("QuanHuyen"));

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n        <th></th>\r\n    </tr>\r\n</thead>\r\n<tbody>\r\n");


            
            #line 17 "..\..\Views\PhuongXa\Index.cshtml"
 foreach (var item in Model) {

            
            #line default
            #line hidden
WriteLiteral("    <tr>\r\n        <td>\r\n            ");


            
            #line 20 "..\..\Views\PhuongXa\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.stt));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 23 "..\..\Views\PhuongXa\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.maPhuongXa));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");


            
            #line 26 "..\..\Views\PhuongXa\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.tenPhuongXa));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td>\r\n            <span data-tip=\"");


            
            #line 29 "..\..\Views\PhuongXa\Index.cshtml"
                       Write(item.dmQuanHuyen.dmTinhThanh.tenTinhThanh);

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 29 "..\..\Views\PhuongXa\Index.cshtml"
                                                                   Write(item.dmQuanHuyen.tenQuanHuyen);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        </td>\r\n        <td align=\"right\" nowrap>\r\n            <a class=\"" +
"dopost\" href=\"PhuongXa/Delete?id=");


            
            #line 32 "..\..\Views\PhuongXa\Index.cshtml"
                                                  Write(item.id);

            
            #line default
            #line hidden
WriteLiteral("\" title=\"Xóa ");


            
            #line 32 "..\..\Views\PhuongXa\Index.cshtml"
                                                                       Write(Html.VN("PhuongXa"));

            
            #line default
            #line hidden
WriteLiteral("\"><span class=\"ui-icon ui-icon-trash\" style=\"display:inline-block\"/></a>\r\n       " +
"     <a class=\"dialog\" href=\"PhuongXa/Edit?id=");


            
            #line 33 "..\..\Views\PhuongXa\Index.cshtml"
                                                Write(item.id);

            
            #line default
            #line hidden
WriteLiteral("\" title=\"Sửa ");


            
            #line 33 "..\..\Views\PhuongXa\Index.cshtml"
                                                                     Write(Html.VN("PhuongXa"));

            
            #line default
            #line hidden
WriteLiteral("\"><span class=\"ui-icon ui-icon-pencil\" style=\"display:inline-block\"/></a>\r\n      " +
"  </td>\r\n    </tr>\r\n");


            
            #line 36 "..\..\Views\PhuongXa\Index.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("</tbody>\r\n</table>\r\n<script>\r\n    ");


            
            #line 40 "..\..\Views\PhuongXa\Index.cshtml"
Write(Html.dataTables("phuongxa"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</script>\r\n");


        }
    }
}
#pragma warning restore 1591
