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

namespace HRM.QLDanhMuc.Views.TaiNguyen
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
    
    #line 2 "..\..\Views\TaiNguyen\Index.cshtml"
    using HRM.Databases.Models;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\TaiNguyen\Index.cshtml"
    using HRM.QLDanhMuc.Models;
    
    #line default
    #line hidden
    
    #line 1 "..\..\Views\TaiNguyen\Index.cshtml"
    using HRM.Webpages.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/TaiNguyen/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<IEnumerable<HRM.Databases.Models.TaiNguyen>>
    {
        public Index()
        {
        }
        public override void Execute()
        {





            
            #line 5 "..\..\Views\TaiNguyen\Index.cshtml"
  
    ViewBag.Title = "Index";
    var Path = new List<TaiNguyen>();
    var Parent = new Nullable<int>();
    if (ViewBag.Parent != null)
    {
        Parent = ViewBag.Parent.id;
        while (ViewBag.Parent != null)
        {
            Path.Insert(0, new TaiNguyen()
            {
                id = ViewBag.Parent.id,
                tenTaiNguyen = ViewBag.Parent.tenTaiNguyen
            });
            ViewBag.Parent = (ViewBag.Parent as TaiNguyen).getParent();
        }
    }


            
            #line default
            #line hidden

            
            #line 23 "..\..\Views\TaiNguyen\Index.cshtml"
Write(Html.BeginDiv());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<p>\r\n    ");


            
            #line 26 "..\..\Views\TaiNguyen\Index.cshtml"
Write(Html.ActionLink("Create Folder", "Create", new { parent = Parent, isFolder = true }, null));

            
            #line default
            #line hidden
WriteLiteral(",\r\n    ");


            
            #line 27 "..\..\Views\TaiNguyen\Index.cshtml"
Write(Html.ActionLink("Add File", "Create", new { parent = Parent }, null));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n    <a href=\"Index\"><span class=\"ui-icon ui-icon-home\" style=\"display:inl" +
"ine-block\"/></a>\r\n");


            
            #line 29 "..\..\Views\TaiNguyen\Index.cshtml"
     foreach (var folder in Path)
    {
        
            
            #line default
            #line hidden
            
            #line 31 "..\..\Views\TaiNguyen\Index.cshtml"
   Write(Html.ActionLink(folder.tenTaiNguyen, "Index", new { parent = folder.id }));

            
            #line default
            #line hidden
            
            #line 31 "..\..\Views\TaiNguyen\Index.cshtml"
                                                                                  
    }

            
            #line default
            #line hidden

            
            #line 33 "..\..\Views\TaiNguyen\Index.cshtml"
     if (Session["Selected"] != null)
    {

            
            #line default
            #line hidden
WriteLiteral("        <strong>(");


            
            #line 35 "..\..\Views\TaiNguyen\Index.cshtml"
            Write(Html.ActionLink("Paste here!", "Paste/" + (Session["Selected"] as TaiNguyen).id, new { parent = Parent }, new { id = "Paste" }));

            
            #line default
            #line hidden
WriteLiteral(")</strong>\r\n");



WriteLiteral("        <a href=\"Move?parent=");


            
            #line 36 "..\..\Views\TaiNguyen\Index.cshtml"
                        Write(Parent);

            
            #line default
            #line hidden
WriteLiteral("\" title=\"Cancel\"><span class=\"ui-icon ui-icon-close\" style=\"display:inline-block\"" +
"/></a>\r\n");



WriteLiteral("        <script>\r\n            $(function () {\r\n                $(\"#Paste\").click(" +
"function () {\r\n                    $(\"<form action=\'Paste\' method=\'post\'></form>" +
"\")\r\n                    .append(\"<input type=\'text\' name=\'id\' value=\'");


            
            #line 41 "..\..\Views\TaiNguyen\Index.cshtml"
                                                             Write((Session["Selected"] as TaiNguyen).id);

            
            #line default
            #line hidden
WriteLiteral("\' />\")\r\n                    .append(\"<input type=\'text\' name=\'parent\' value=\'");


            
            #line 42 "..\..\Views\TaiNguyen\Index.cshtml"
                                                                Write(Parent);

            
            #line default
            #line hidden
WriteLiteral("\' />\")\r\n                    .submit();\r\n                    return false;\r\n      " +
"          });\r\n            });\r\n        </script>\r\n");



WriteLiteral("        <font color=\"red\">");


            
            #line 48 "..\..\Views\TaiNguyen\Index.cshtml"
                     Write(TempData["Message"]);

            
            #line default
            #line hidden
WriteLiteral("</font>\r\n");


            
            #line 49 "..\..\Views\TaiNguyen\Index.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n<table id=\"TaiNguyen\">\r\n<thead>\r\n    <tr>\r\n        <th style=\"display:none;" +
"\"></th>\r\n        <th>\r\n            ");


            
            #line 56 "..\..\Views\TaiNguyen\Index.cshtml"
       Write(Html.VN("tenTaiNguyen"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");


            
            #line 59 "..\..\Views\TaiNguyen\Index.cshtml"
       Write(Html.VN("tepDinhKem"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n</thead>\r\n<tbody>\r\n");


            
            #line 65 "..\..\Views\TaiNguyen\Index.cshtml"
 foreach (var item in Model)
{

            
            #line default
            #line hidden
WriteLiteral("    <tr>\r\n        <td style=\"display:none;\">");


            
            #line 68 "..\..\Views\TaiNguyen\Index.cshtml"
                             Write(String.Format("{0}", item.laThuMuc ? "TM" : "TT"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n        <td>\r\n");


            
            #line 70 "..\..\Views\TaiNguyen\Index.cshtml"
             if (item.laThuMuc)
            {

            
            #line default
            #line hidden
WriteLiteral("                <span class=\"ui-icon ui-icon-folder-open\" style=\"display:inline-b" +
"lock\"></span>\r\n");


            
            #line 73 "..\..\Views\TaiNguyen\Index.cshtml"
                
            
            #line default
            #line hidden
            
            #line 73 "..\..\Views\TaiNguyen\Index.cshtml"
           Write(Html.ActionLink(item.tenTaiNguyen, "Index", new { parent = item.id }));

            
            #line default
            #line hidden
            
            #line 73 "..\..\Views\TaiNguyen\Index.cshtml"
                                                                                      
            }
            else
            {

            
            #line default
            #line hidden
WriteLiteral("                <span class=\"ui-icon ui-icon-document\" style=\"display:inline-bloc" +
"k\"></span>\r\n");


            
            #line 78 "..\..\Views\TaiNguyen\Index.cshtml"
                
            
            #line default
            #line hidden
            
            #line 78 "..\..\Views\TaiNguyen\Index.cshtml"
           Write(Html.DisplayFor(model => item.tenTaiNguyen));

            
            #line default
            #line hidden
            
            #line 78 "..\..\Views\TaiNguyen\Index.cshtml"
                                                            
            }

            
            #line default
            #line hidden
WriteLiteral("        </td>\r\n        <td>\r\n");


            
            #line 82 "..\..\Views\TaiNguyen\Index.cshtml"
             if (!item.laThuMuc)
            {

            
            #line default
            #line hidden
WriteLiteral("                <a href=\"Download/tn/");


            
            #line 84 "..\..\Views\TaiNguyen\Index.cshtml"
                                Write(item.id);

            
            #line default
            #line hidden
WriteLiteral("\" title=\"Download\">");


            
            #line 84 "..\..\Views\TaiNguyen\Index.cshtml"
                                                           Write(item.tepDinhKem);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");



WriteLiteral("                <a href=\"Upload/tn/");


            
            #line 85 "..\..\Views\TaiNguyen\Index.cshtml"
                              Write(item.id);

            
            #line default
            #line hidden
WriteLiteral("\" title=\"Upload\"><span class=\"ui-icon ui-icon-image\" style=\"display:inline-block\"" +
"/></a>\r\n");


            
            #line 86 "..\..\Views\TaiNguyen\Index.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </td>\r\n        <td align=\"right\" nowrap>\r\n");


            
            #line 89 "..\..\Views\TaiNguyen\Index.cshtml"
             if (Session["Selected"] == null)
            {

            
            #line default
            #line hidden
WriteLiteral("                <a href=\"Move/tn/");


            
            #line 91 "..\..\Views\TaiNguyen\Index.cshtml"
                            Write(item.id);

            
            #line default
            #line hidden
WriteLiteral("\" title=\"Move\"><span class=\"ui-icon ui-icon-scissors\" style=\"display:inline-block" +
"\"/></a>\r\n");


            
            #line 92 "..\..\Views\TaiNguyen\Index.cshtml"
            }
            else
            {
                var selected = Session["Selected"] as TaiNguyen;
                if (item.id != selected.id)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <a href=\"Move/tn/");


            
            #line 98 "..\..\Views\TaiNguyen\Index.cshtml"
                                Write(item.id);

            
            #line default
            #line hidden
WriteLiteral("\" title=\"Move\"><span class=\"ui-icon ui-icon-scissors\" style=\"display:inline-block" +
"\"/></a>\r\n");


            
            #line 99 "..\..\Views\TaiNguyen\Index.cshtml"
                }
            }

            
            #line default
            #line hidden
WriteLiteral("            <a href=\"Rename/tn/");


            
            #line 101 "..\..\Views\TaiNguyen\Index.cshtml"
                          Write(item.id);

            
            #line default
            #line hidden
WriteLiteral("\" title=\"Rename\"><span class=\"ui-icon ui-icon-pencil\" style=\"display:inline-block" +
"\"/></a>\r\n            <a href=\"Delete/tn/");


            
            #line 102 "..\..\Views\TaiNguyen\Index.cshtml"
                          Write(item.id);

            
            #line default
            #line hidden
WriteLiteral("\" title=\"Delete\"><span class=\"ui-icon ui-icon-trash\" style=\"display:inline-block\"" +
"/></a>\r\n        </td>\r\n    </tr>\r\n");


            
            #line 105 "..\..\Views\TaiNguyen\Index.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("</tbody>\r\n</table>\r\n\r\n<script>\r\n    ");


            
            #line 110 "..\..\Views\TaiNguyen\Index.cshtml"
Write(Html.dataTables("TaiNguyen"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</script>\r\n\r\n");


            
            #line 113 "..\..\Views\TaiNguyen\Index.cshtml"
Write(Html.EndDiv());

            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
