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

namespace HRM.QLBHXH.Views.NhanVienBHXH
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
    
    #line 2 "..\..\Views\NhanVienBHXH\Delete.cshtml"
    using HRM.QLBHXH.Models;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/NhanVienBHXH/Delete.cshtml")]
    public partial class Delete : System.Web.Mvc.WebViewPage<HRM.QLBHXH.Models.nvbhNhanVienBHXH>
    {
        public Delete()
        {
        }
        public override void Execute()
        {



            
            #line 3 "..\..\Views\NhanVienBHXH\Delete.cshtml"
  
    ViewBag.Title = "Delete";
    var db = new HRMDB1Entities();
    int idnv = ViewBag.idnv;


            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2><font color=\"red\">Bạn có muốn xóa thông tin nhân viên?</font></h2>\r\n\r\n <b" +
">Mã NV:</b> ");


            
            #line 12 "..\..\Views\NhanVienBHXH\Delete.cshtml"
          Write(db.nvbhNhanVienBHXH.First(k => k.id == idnv).MANV);

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n <b>Họ và tên:</b> ");


            
            #line 13 "..\..\Views\NhanVienBHXH\Delete.cshtml"
              Write(db.nvbhNhanVienBHXH.First(k => k.id == idnv).HoVaTen);

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n <b>Đơn vị:</b> ");


            
            #line 14 "..\..\Views\NhanVienBHXH\Delete.cshtml"
           Write(db.nvbhNhanVienBHXH.First(k => k.id == idnv).DonVi);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\r\n\r\n");



WriteLiteral("\r\n");


            
            #line 24 "..\..\Views\NhanVienBHXH\Delete.cshtml"
 using (Html.BeginForm()) {

            
            #line default
            #line hidden
WriteLiteral("    <p>\r\n        <input type=\"submit\" value=\"Xóa\" /> \r\n         <input type=\"butt" +
"on\" value=\"Không đồng ý\" onclick=\"location.href=\'");


            
            #line 27 "..\..\Views\NhanVienBHXH\Delete.cshtml"
                                                                      Write(Url.Action("index2", "NhanVienBHXH"));

            
            #line default
            #line hidden
WriteLiteral("\'\" />\r\n     \r\n   \r\n    </p>\r\n");


            
            #line 31 "..\..\Views\NhanVienBHXH\Delete.cshtml"
}

            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
