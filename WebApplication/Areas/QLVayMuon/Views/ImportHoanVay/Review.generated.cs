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

namespace HRM.QLVayMuon.Views.ImportHoanVay
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
    
    #line 1 "..\..\Views\ImportHoanVay\Review.cshtml"
    using HRM.QLVayMuon.Controllers;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\ImportHoanVay\Review.cshtml"
    using HRM.QLVayMuon.Models;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\ImportHoanVay\Review.cshtml"
    using HRM.Webpages.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ImportHoanVay/Review.cshtml")]
    public partial class Review : System.Web.Mvc.WebViewPage<dynamic>
    {
        public Review()
        {
        }
        public override void Execute()
        {




            
            #line 4 "..\..\Views\ImportHoanVay\Review.cshtml"
  
    ViewBag.Title = "Review";
    string link = ViewBag.link;


            
            #line default
            #line hidden

            
            #line 8 "..\..\Views\ImportHoanVay\Review.cshtml"
Write(Html.ActionLink("Trở về nhập dữ liệu hoàn vay","Index", "ImportHoanVay"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div >  <a  href=\"../importhoanvay/Importexcel?link=");


            
            #line 10 "..\..\Views\ImportHoanVay\Review.cshtml"
                                               Write(link);

            
            #line default
            #line hidden
WriteLiteral("\" > \r\n<input type=\"button\" name=\"Go\" id=\"Go\" value=\"Nhập dữ liệu\"  /></a> \r\n</div" +
">\r\n\r\n\r\n\r\n\r\n<h3 align=\"center\">Danh sách hoàn vay từ tệp tin Excel</h3>\r\n\r\n<table" +
" id = \"HoanVay\" border=\"1\">\r\n    <thead>\r\n        <tr>\r\n");


            
            #line 22 "..\..\Views\ImportHoanVay\Review.cshtml"
             foreach (System.Data.DataColumn col in Model.Columns) { 

            
            #line default
            #line hidden
WriteLiteral("                <th>");


            
            #line 23 "..\..\Views\ImportHoanVay\Review.cshtml"
               Write(col.Caption);

            
            #line default
            #line hidden
WriteLiteral(" </th>\r\n");


            
            #line 24 "..\..\Views\ImportHoanVay\Review.cshtml"
            } 

            
            #line default
            #line hidden
WriteLiteral("        </tr>\r\n    </thead>\r\n\r\n    <tbody>\r\n");


            
            #line 29 "..\..\Views\ImportHoanVay\Review.cshtml"
         foreach(System.Data.DataRow row in Model.Rows) { 

            
            #line default
            #line hidden
WriteLiteral("        <tr>\r\n");


            
            #line 31 "..\..\Views\ImportHoanVay\Review.cshtml"
             foreach (var cell in row.ItemArray) {


            
            #line default
            #line hidden
WriteLiteral("                <td>");


            
            #line 33 "..\..\Views\ImportHoanVay\Review.cshtml"
               Write(cell.ToString());

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");


            
            #line 34 "..\..\Views\ImportHoanVay\Review.cshtml"
            } 

            
            #line default
            #line hidden
WriteLiteral("        </tr>\r\n");


            
            #line 36 "..\..\Views\ImportHoanVay\Review.cshtml"
    }          

            
            #line default
            #line hidden
WriteLiteral(@"    </tbody>
</table>


<script>
    $(document).ready(function () {
        $(""#HoanVay"").dataTable({
            ""bAutoWidth"": true,
            ""bStateSave"": true,
            ""aLengthMenu"": [[10, 25, 50, -1], [10, 25, 50, ""All""]]
        });
    });
</script>");


        }
    }
}
#pragma warning restore 1591
