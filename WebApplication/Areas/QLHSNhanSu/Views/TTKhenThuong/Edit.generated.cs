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

namespace HRM.QLTTNhanSu.Views.TTKhenThuong
{
    using System;
    using System.Collections.Generic;
    
    #line 1 "..\..\Views\TTKhenThuong\Edit.cshtml"
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
    
    #line 3 "..\..\Views\TTKhenThuong\Edit.cshtml"
    using HRM.Databases.Models;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\TTKhenThuong\Edit.cshtml"
    using HRM.Webpages.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/TTKhenThuong/Edit.cshtml")]
    public partial class Edit : System.Web.Mvc.WebViewPage<int?>
    {
        public Edit()
        {
        }
        public override void Execute()
        {





            
            #line 5 "..\..\Views\TTKhenThuong\Edit.cshtml"
  
    var action = "TTKhenThuong";
    var NV_id = ViewBag.NV_id as int?;
    var db = ViewBag.db as HRMDBEntities;
    var dt = db.SqlQuery("select * from nvTTKhenThuong where id=@p0", Model.HasValue ? Model.Value : 0);
    var dr = dt.Rows.Count > 0 ? dt.Rows[0] : null;

    var HinhThuc = "HinhThuc_id";
    var HinhThuc_id = dr != null ? dr[HinhThuc] as int? : null;
    
    var rand = new Random().Next();


            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 18 "..\..\Views\TTKhenThuong\Edit.cshtml"
 using (Html.BeginForm(Model.HasValue ? "UpdateS" : "CreateS", action))
{
    
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\TTKhenThuong\Edit.cshtml"
Write(Html.Hidden("id", Model));

            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\TTKhenThuong\Edit.cshtml"
                             
    
            
            #line default
            #line hidden
            
            #line 21 "..\..\Views\TTKhenThuong\Edit.cshtml"
Write(Html.Hidden("NV_id", NV_id.HasValue ? NV_id.Value : dr["NV_id"]));

            
            #line default
            #line hidden
            
            #line 21 "..\..\Views\TTKhenThuong\Edit.cshtml"
                                                                     

            
            #line default
            #line hidden
WriteLiteral("<dl id=\"");


            
            #line 22 "..\..\Views\TTKhenThuong\Edit.cshtml"
   Write(rand);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"dl-horizontal\">\r\n    <dt>Số QĐ</dt>\r\n    <dd>");


            
            #line 24 "..\..\Views\TTKhenThuong\Edit.cshtml"
   Write(Html.Editor(dr, dt.Columns["SoQuyetDinh"]));

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n    <dt>Ngày</dt>\r\n    <dd>");


            
            #line 26 "..\..\Views\TTKhenThuong\Edit.cshtml"
   Write(Html.Editor(dr, dt.Columns["NgayQuyetDinh"]));

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n    <dt>Nơi cấp</dt>\r\n    <dd>");


            
            #line 28 "..\..\Views\TTKhenThuong\Edit.cshtml"
   Write(Html.Editor(dr, dt.Columns["CapKhenThuong"]));

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n    <dt>Hình thức</dt>\r\n    <dd>");


            
            #line 30 "..\..\Views\TTKhenThuong\Edit.cshtml"
   Write(Html.DropDownList(HinhThuc, new SelectList(db.dmHinhThucKhenThuong, "id", "tenHinhThucKhenThuong", HinhThuc_id), String.Empty));

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n    <dt>Nội dung</dt>\r\n    <dd>");


            
            #line 32 "..\..\Views\TTKhenThuong\Edit.cshtml"
   Write(Html.Editor(dr, dt.Columns["NoiDungKhenThuong"]));

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n    <dt>Mức khen thưởng</dt>\r\n    <dd>");


            
            #line 34 "..\..\Views\TTKhenThuong\Edit.cshtml"
   Write(Html.Editor(dr, dt.Columns["MucKhenThuong"]));

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n    <dt>Ghi chú</dt>\r\n    <dd>");


            
            #line 36 "..\..\Views\TTKhenThuong\Edit.cshtml"
   Write(Html.Editor(dr, dt.Columns["GhiChu"]));

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n    <dt></dt>\r\n    <dd>\r\n        <input type=\"submit\" value=\"Save\" />\r\n   " +
"     <a title=\"Close\" class=\"close\" href=\"\">X</a>\r\n    </dd>\r\n</dl>\r\n");


            
            #line 43 "..\..\Views\TTKhenThuong\Edit.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<script>\r\n    var form = $(\"#");


            
            #line 46 "..\..\Views\TTKhenThuong\Edit.cshtml"
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
