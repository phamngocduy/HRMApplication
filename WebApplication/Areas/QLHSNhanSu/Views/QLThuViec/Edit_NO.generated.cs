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

namespace HRM.QLTTNhanSu.Views.QLThuViec
{
    using System;
    using System.Collections.Generic;
    
    #line 1 "..\..\Views\QLThuViec\Edit_NO.cshtml"
    using System.Data;
    
    #line default
    #line hidden
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
    
    #line 3 "..\..\Views\QLThuViec\Edit_NO.cshtml"
    using HRM.Databases.Models;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\QLThuViec\Edit_NO.cshtml"
    using HRM.Webpages.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/QLThuViec/Edit_NO.cshtml")]
    public partial class Edit_NO : System.Web.Mvc.WebViewPage<int?>
    {
        public Edit_NO()
        {
        }
        public override void Execute()
        {





            
            #line 5 "..\..\Views\QLThuViec\Edit_NO.cshtml"
  
    var action = "QLThuViec";
    var db = ViewBag.db as HRMDBEntities;
    var dt = db.SqlQuery("select * from nvQLThuViec where id=@p0", Model.Value);
    var dr = dt.Rows.Count > 0 ? dt.Rows[0] : null;
    
    var rand = new Random().Next();


            
            #line default
            #line hidden
WriteLiteral("\r\n<p class=\"ui-state-error\">Không hoàn thành thử việc</p>\r\n\r\n");


            
            #line 16 "..\..\Views\QLThuViec\Edit_NO.cshtml"
 using (Html.BeginForm("UpdateS", action))
{
    
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\QLThuViec\Edit_NO.cshtml"
Write(Html.Hidden("id", Model));

            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\QLThuViec\Edit_NO.cshtml"
                             

            
            #line default
            #line hidden
WriteLiteral("<dl id=\"");


            
            #line 19 "..\..\Views\QLThuViec\Edit_NO.cshtml"
   Write(rand);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"dl-horizontal\">\r\n    <dt>Thời gian kết thúc</dt>\r\n    <dd>");


            
            #line 21 "..\..\Views\QLThuViec\Edit_NO.cshtml"
   Write(Html.Editor(dr, dt.Columns["ThoiGianKetThuc"]));

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n    <dt>Ghi chú</dt>\r\n    <dd>");


            
            #line 23 "..\..\Views\QLThuViec\Edit_NO.cshtml"
   Write(Html.Editor(dr, dt.Columns["GhiChu"]));

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n    <dt></dt>\r\n    <dd>\r\n        <input type=\"submit\" value=\"Save\" />\r\n   " +
"     <a title=\"Close\" class=\"close\" href=\"\">X</a>\r\n    </dd>\r\n</dl>\r\n");


            
            #line 30 "..\..\Views\QLThuViec\Edit_NO.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<script>\r\n    var form = $(\"#");


            
            #line 33 "..\..\Views\QLThuViec\Edit_NO.cshtml"
              Write(rand);

            
            #line default
            #line hidden
WriteLiteral("\");\r\n    form.find(\"[type=date]\").datepicker({\r\n        changeMonth: true,\r\n     " +
"   changeYear: true,\r\n        dateFormat: \"dd/mm/yy\"\r\n    }).prop(\"type\", \"text\"" +
");\r\n</script>\r\n");


        }
    }
}
#pragma warning restore 1591
