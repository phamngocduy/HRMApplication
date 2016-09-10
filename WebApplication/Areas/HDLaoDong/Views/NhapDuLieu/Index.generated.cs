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

namespace HRM.HDLaoDong.Views.NhapDuLieu
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
    
    #line 3 "..\..\Views\NhapDuLieu\Index.cshtml"
    using HRM.Databases.Models;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\NhapDuLieu\Index.cshtml"
    using HRM.Databases_HDLaoDong.Models;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\NhapDuLieu\Index.cshtml"
    using HRM.Webpages.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/NhapDuLieu/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<IEnumerable<HRM.Databases_HDLaoDong.Models.hdChiTietHDLD>>
    {
        public Index()
        {
        }
        public override void Execute()
        {





            
            #line 5 "..\..\Views\NhapDuLieu\Index.cshtml"
  
    ViewBag.Title = "Index";
    var db0 = new HRM.Databases.Models.HRMDB0Entities();
    var db = new HRMDB2Entities();
    var listCTHD = (List<hdChiTietHDLD>)TempData["lisHDCTHDLD"];
    
    


            
            #line default
            #line hidden
WriteLiteral("<div style=\"padding: 0; width:1000px;margin-left:-13%\">\r\n");


            
            #line 14 "..\..\Views\NhapDuLieu\Index.cshtml"
 using (Html.BeginForm("ImportToExcel", "NhapDuLieu", FormMethod.Post, new { enctype = "multipart/form-data" }))
{

            
            #line default
            #line hidden
WriteLiteral("    <input type=\"file\" id=\"FileUpload1\" name=\"FileUpload1\" style=\"width: auto\" />" +
"\r\n");



WriteLiteral("    <input type=\"hidden\" name=\"path\" value=\"");


            
            #line 17 "..\..\Views\NhapDuLieu\Index.cshtml"
                                       Write(TempData["path"]);

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n");



WriteLiteral("    <input type=\"submit\" id=\"view\" name=\"view\" value=\"Xem trước\" />\r\n");



WriteLiteral("    <input type=\"submit\" id=\"import\" name=\"import\" value=\"Import\" />\r\n");


            
            #line 20 "..\..\Views\NhapDuLieu\Index.cshtml"
}

            
            #line default
            #line hidden

            
            #line 21 "..\..\Views\NhapDuLieu\Index.cshtml"
Write(Html.StatusMessage(TempData["Message_Error"]));

            
            #line default
            #line hidden
WriteLiteral(@"
<table id =""ViewImportTable"">
<thead>
    <tr>
        <th style=""text-align:center"" >
            STT
        </th>
        <th style=""text-align:center"">
            Họ và tên
        </th>
        <th style=""text-align:center"" >
            Đơn<br />vị
        </th>
        <th style=""text-align:center"" >
            Chức danh CM
        </th>
        <th style=""text-align:center"" >
            Số HĐ
        </th>
        <th style=""text-align:center"" >
            Loại HĐ
        </th>
        <th style=""text-align:center"" >
            Ngày hiệu<br />lực
        </th>
        <th style=""text-align:center"" >
            Ngày hết<br />hiệu lực
        </th>
        <th style=""text-align:center"" >
            Ngày NLĐ ký
        </th>
        <th style=""text-align:center"" >
            Ngày lưu
        </th>
        <th style=""text-align:center"" >
            Ngày trả
        </th>
        <th style=""text-align:center"" >
            Lương cơ bản
        </th>
        <th style=""text-align:center"" >
            Hệ số lương
        </th>
        <th style=""text-align:center"" >
            Bậc 
        </th>
        <th style=""text-align:center"" >
            Ngạch
        </th>
        <th style=""text-align:center"" >
            Nhóm
        </th>
        <th style=""text-align:center"" >
            Bảng lương
        </th>
    </tr>
</thead>
<tbody>
");


            
            #line 79 "..\..\Views\NhapDuLieu\Index.cshtml"
  int count = 0;
  var cts = new List<hdChiTietHDLD>();
  if(listCTHD != null){
      cts = listCTHD;
  }
  

            
            #line default
            #line hidden

            
            #line 85 "..\..\Views\NhapDuLieu\Index.cshtml"
 foreach (var item in cts)
{
    count = count + 1;

            
            #line default
            #line hidden
WriteLiteral("    <tr>\r\n    <td style=\"text-align:center\">\r\n    ");


            
            #line 90 "..\..\Views\NhapDuLieu\Index.cshtml"
Write(count);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n    <td style=\"text-align:center\"  >\r\n    ");


            
            #line 93 "..\..\Views\NhapDuLieu\Index.cshtml"
Write(Html.DisplayFor(model => item.HotenNLD));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n");


            
            #line 95 "..\..\Views\NhapDuLieu\Index.cshtml"
        string tenDonVi = "";
        if (item.Donvi_id != null)
        {
            int? Donvi_id = item.Donvi_id;
            tenDonVi = db0.dmDonVi.Where(dv => dv.id == Donvi_id).First().tenDonVi;
        }
    

            
            #line default
            #line hidden
WriteLiteral("    <td style=\"text-align: center\" data-tip=\"");


            
            #line 102 "..\..\Views\NhapDuLieu\Index.cshtml"
                                        Write(tenDonVi);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n");


            
            #line 103 "..\..\Views\NhapDuLieu\Index.cshtml"
        string maDonVi = "";
        if (item.Donvi_id != null)
        {
            int? Donvi_id = item.Donvi_id;
            maDonVi = db0.dmDonVi.Where(dv => dv.id == Donvi_id).First().maDonVi;
        }
        
            
            #line default
            #line hidden
            
            #line 109 "..\..\Views\NhapDuLieu\Index.cshtml"
   Write(Html.DisplayFor(model => maDonVi));

            
            #line default
            #line hidden
            
            #line 109 "..\..\Views\NhapDuLieu\Index.cshtml"
                                          
    

            
            #line default
            #line hidden
WriteLiteral("    </td>\r\n    <td style=\"text-align:center\"  >\r\n");


            
            #line 113 "..\..\Views\NhapDuLieu\Index.cshtml"
        string tenChucDanh = "";
        if (item.Chucdanh_id != null)
        {
            int? ChucDanh_id = item.Chucdanh_id;
            tenChucDanh = db0.dmChucDanhChuyenMon.Where(dv => dv.id == ChucDanh_id).First().tenChucDanhChuyenMon;
        }
        
            
            #line default
            #line hidden
            
            #line 119 "..\..\Views\NhapDuLieu\Index.cshtml"
   Write(Html.Raw(tenChucDanh));

            
            #line default
            #line hidden
            
            #line 119 "..\..\Views\NhapDuLieu\Index.cshtml"
                              
    

            
            #line default
            #line hidden
WriteLiteral("    </td>\r\n    <td style=\"text-align:center\"  >\r\n        ");


            
            #line 123 "..\..\Views\NhapDuLieu\Index.cshtml"
   Write(Html.DisplayFor(model => item.SoHD));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n    <td style=\"text-align:center\"  >\r\n        ");


            
            #line 126 "..\..\Views\NhapDuLieu\Index.cshtml"
   Write(Html.DisplayFor(model => item.LoaiHD));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n    <td style=\"text-align:center\">\r\n        ");


            
            #line 129 "..\..\Views\NhapDuLieu\Index.cshtml"
   Write(item.NgayHL.ToShortDateString());

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n    <td style=\"text-align:center\">\r\n        ");


            
            #line 132 "..\..\Views\NhapDuLieu\Index.cshtml"
   Write(item.NgayhetHL);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n    <td style=\"text-align:center\">\r\n        ");


            
            #line 135 "..\..\Views\NhapDuLieu\Index.cshtml"
   Write(item.QT_NgayNLDky);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n    <td style=\"text-align:center\">\r\n        ");


            
            #line 138 "..\..\Views\NhapDuLieu\Index.cshtml"
   Write(item.QT_NgayLuuHS);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n    <td style=\"text-align:center\">\r\n        ");


            
            #line 141 "..\..\Views\NhapDuLieu\Index.cshtml"
   Write(item.QT_NgayTraNLD);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n    <td style=\"text-align:center\">\r\n        ");


            
            #line 144 "..\..\Views\NhapDuLieu\Index.cshtml"
   Write(item.Mucluongchinh);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n");


            
            #line 146 "..\..\Views\NhapDuLieu\Index.cshtml"
      
        double? HeSo = null;
        var Bac = "";
        var Ngach = "";
        var Nhom = "";


        int? nHSLuong_id = item.HSLuong_id;
        int? nNgach_id = item.Ngach_id;
        int? nNhom_id = item.Nhom_id;
        try
        {
            HeSo = db0.dmBangLuong.Where(bl => bl.id == nHSLuong_id).FirstOrDefault().hesoLuong;
        }
        catch
        {
        }
        try
        {
            Bac = db0.dmBangLuong.Where(bl => bl.id == nHSLuong_id).FirstOrDefault().bacLuong;
        }
        catch
        {
        }
        try
        {
            Ngach = db0.dmNgachVienChuc.Where(bl => bl.id == nNgach_id).FirstOrDefault().tenNgachVienChuc;
        }
        catch
        {
        }
        try
        {
            Nhom = db0.dmNhomNgachVienChuc.Where(bl => bl.id == nNhom_id).FirstOrDefault().tenNhomNgachVienChuc;
        }
        catch
        {
        }


            
            #line default
            #line hidden
WriteLiteral("    <td style=\"text-align:center\">\r\n    ");


            
            #line 186 "..\..\Views\NhapDuLieu\Index.cshtml"
Write(Html.Raw(HeSo));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n    <td style=\"text-align:center\">\r\n    ");


            
            #line 189 "..\..\Views\NhapDuLieu\Index.cshtml"
Write(Html.Raw(Bac));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n    <td style=\"text-align:center\">\r\n    ");


            
            #line 192 "..\..\Views\NhapDuLieu\Index.cshtml"
Write(Html.Raw(Ngach));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n    <td style=\"text-align:center\">\r\n    ");


            
            #line 195 "..\..\Views\NhapDuLieu\Index.cshtml"
Write(Html.Raw(Ngach));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n    <td style=\"text-align:center\">\r\n    ");


            
            #line 198 "..\..\Views\NhapDuLieu\Index.cshtml"
Write(item.Bangluong_id);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n    </tr>\r\n");


            
            #line 201 "..\..\Views\NhapDuLieu\Index.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral(@"</tbody>
</table>
</div>
<style>
    table
    {
        overflow: auto;
        width: 100%;
        display: block;
    }
    input
    {
        margin: 0 0 0 0;
    }
    td
    {
        padding: 0;
    }
    .ui-state-hover
    {
        font-weight: normal !important;
    }
</style>
<style>
    td
    {
        padding: 0 0 0 0;
    }
    input
    {
        margin: 0 0 0 0;
        width: auto;
    }
</style>
<script>
    var message = '<%=ViewData[""mymessage""]%>';
    if (message.length > 0)
        windows.alert(message);
</script>

<script>
    $().ready(function () {
        var table$ = $(""#ViewImportTable"");
        table$.find(""th"").each(function () {
            $(this).addClass(""ui-state-default"");
        });
        table$.find(""td"").each(function () {
            $(this).addClass(""ui-widget-content"");
        });

    });
</script>
");


        }
    }
}
#pragma warning restore 1591
