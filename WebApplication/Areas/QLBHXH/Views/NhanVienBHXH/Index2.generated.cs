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
    
    #line 1 "..\..\Views\NhanVienBHXH\Index2.cshtml"
    using HRM.Webpages.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/NhanVienBHXH/Index2.cshtml")]
    public partial class Index2 : System.Web.Mvc.WebViewPage<IEnumerable<HRM.QLBHXH.Models.v_nvbhNhanVienBHXH>>
    {
        public Index2()
        {
        }
        public override void Execute()
        {



            
            #line 3 "..\..\Views\NhanVienBHXH\Index2.cshtml"
  
    ViewBag.Title = "BHXH";
    ViewBag.iddsdonvi = ViewBag.dsdonvi;
    var ngaybhxh = ViewBag.ngaybhxh;
    var apdungbhxh = ViewBag.bhxhApDung;
    var apdungttv = ViewBag.ttvApDung;
    var apdungttc = ViewBag.ttcApDung;


    var ngayttc = ViewBag.ngayttc;

    var ngayttv = ViewBag.ngayttv;
    var bhxhTre = ViewBag.bhxhTre;
    var ttvTre = ViewBag.ttvTre;
    var ttcTre = ViewBag.ttvTre;


            
            #line default
            #line hidden
WriteLiteral("<p style=\"background: #FFFFCC\">\r\n    Danh sách NVBHXH</p>\r\n");


            
            #line 21 "..\..\Views\NhanVienBHXH\Index2.cshtml"
 if (ngaybhxh <= 10 && ngaybhxh > 0)
{


            
            #line default
            #line hidden
WriteLiteral("    <span style=\"background: #FFFF00\">Còn ");


            
            #line 24 "..\..\Views\NhanVienBHXH\Index2.cshtml"
                                     Write(ngaybhxh);

            
            #line default
            #line hidden
WriteLiteral(" ngày nữa là áp dụng TL BHXH mới</span>\r\n");



WriteLiteral("    <a href=\"../dmTyLeDongBH/index2\" target=\"_blank\" title=\"Mẫu A01-TS\"><span cla" +
"ss=\"ui-icon     \r\nui-icon-play\" style=\"display: inline-block\" /></a>\r\n");


            
            #line 27 "..\..\Views\NhanVienBHXH\Index2.cshtml"
}

            
            #line default
            #line hidden

            
            #line 28 "..\..\Views\NhanVienBHXH\Index2.cshtml"
 if (ngaybhxh == 0 && apdungbhxh == false)
{

            
            #line default
            #line hidden
WriteLiteral("    <span style=\"background: #FF9933\">Áp dụng TL BHXH mới!</span>\r\n");



WriteLiteral("    <a href=\"../dmTyLeDongBH/index2\" target=\"_blank\" title=\"Mẫu A01-TS\"><span cla" +
"ss=\"ui-icon     \r\nui-icon-play\" style=\"display: inline-block\" /></a>\r\n");


            
            #line 33 "..\..\Views\NhanVienBHXH\Index2.cshtml"
}

            
            #line default
            #line hidden

            
            #line 34 "..\..\Views\NhanVienBHXH\Index2.cshtml"
 if (ngaybhxh < 0 && apdungbhxh == false)
{

            
            #line default
            #line hidden
WriteLiteral("    <span style=\"background: #FF9933\">Áp dụng TL BHXH mới! (trễ ");


            
            #line 36 "..\..\Views\NhanVienBHXH\Index2.cshtml"
                                                           Write(bhxhTre);

            
            #line default
            #line hidden
WriteLiteral(" ngày)</span>\r\n");



WriteLiteral("    <a href=\"../dmTyLeDongBH/index2\" target=\"_blank\" title=\"Mẫu A01-TS\"><span cla" +
"ss=\"ui-icon     \r\nui-icon-play\" style=\"display: inline-block\" /></a>\r\n");


            
            #line 39 "..\..\Views\NhanVienBHXH\Index2.cshtml"
}

            
            #line default
            #line hidden

            
            #line 40 "..\..\Views\NhanVienBHXH\Index2.cshtml"
 if (ngayttc <= 10 && ngayttc > 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <span style=\"background: #FFFF00\">Còn ");


            
            #line 42 "..\..\Views\NhanVienBHXH\Index2.cshtml"
                                     Write(ngayttc);

            
            #line default
            #line hidden
WriteLiteral(" ngày nữa là áp dụng ML TTC mới</span>\r\n");



WriteLiteral("    <a href=\"../dmMucLuongToiThieuChung/index2\" target=\"_blank\" title=\"Mẫu A01-TS" +
"\"><span\r\n        class=\"ui-icon     \r\nui-icon-play\" style=\"display: inline-block" +
"\" /></a>\r\n");


            
            #line 46 "..\..\Views\NhanVienBHXH\Index2.cshtml"
 
}

            
            #line default
            #line hidden

            
            #line 48 "..\..\Views\NhanVienBHXH\Index2.cshtml"
 if (ngayttc == 0 && apdungttc == false)
{

            
            #line default
            #line hidden
WriteLiteral("    <span style=\"background: #FF9933\">Áp dụng ML TTC mới!</span>\r\n");



WriteLiteral("    <a href=\"../dmMucLuongToiThieuChung/index2\" target=\"_blank\" title=\"Mẫu A01-TS" +
"\"><span\r\n        class=\"ui-icon     \r\nui-icon-play\" style=\"display: inline-block" +
"\" /></a>\r\n");


            
            #line 54 "..\..\Views\NhanVienBHXH\Index2.cshtml"
}

            
            #line default
            #line hidden

            
            #line 55 "..\..\Views\NhanVienBHXH\Index2.cshtml"
 if (ngayttc < 0 && apdungttc == false)
{

            
            #line default
            #line hidden
WriteLiteral("    <span style=\"background: #FF9933\">Áp dụng ML TTC mới!(trễ ");


            
            #line 57 "..\..\Views\NhanVienBHXH\Index2.cshtml"
                                                         Write(ttcTre);

            
            #line default
            #line hidden
WriteLiteral(" ngày)</span>\r\n");



WriteLiteral("    <a href=\"../dmTyLeDongBH/index2\" target=\"_blank\" title=\"Mẫu A01-TS\"><span cla" +
"ss=\"ui-icon     \r\nui-icon-play\" style=\"display: inline-block\" /></a>\r\n");


            
            #line 60 "..\..\Views\NhanVienBHXH\Index2.cshtml"
}

            
            #line default
            #line hidden

            
            #line 61 "..\..\Views\NhanVienBHXH\Index2.cshtml"
 if (ngayttv <= 10 && ngayttv > 0)
{
    

            
            #line default
            #line hidden
WriteLiteral("    <span style=\"background: #FFFF00\">Còn ");


            
            #line 64 "..\..\Views\NhanVienBHXH\Index2.cshtml"
                                     Write(ngayttv);

            
            #line default
            #line hidden
WriteLiteral(" ngày nữa là áp dụng ML TTV mới</span>\r\n");


            
            #line 65 "..\..\Views\NhanVienBHXH\Index2.cshtml"


            
            #line default
            #line hidden
WriteLiteral("    <a href=\"../dmMucLuongToiThieuVung/index2\" target=\"_blank\" title=\"Mẫu A01-TS\"" +
"><span\r\n        class=\"ui-icon     \r\nui-icon-play\" style=\"display: inline-block\"" +
" /></a>\r\n");


            
            #line 69 "..\..\Views\NhanVienBHXH\Index2.cshtml"
}

            
            #line default
            #line hidden

            
            #line 70 "..\..\Views\NhanVienBHXH\Index2.cshtml"
 if (ngayttv == 0 && apdungttv == false)
{

            
            #line default
            #line hidden
WriteLiteral("    <span style=\"background: #FF9933\">Áp dụng ML TTV mới!</span>\r\n");



WriteLiteral("    <a href=\"../dmMucLuongToiThieuVung/index2\" target=\"_blank\" title=\"Mẫu A01-TS\"" +
"><span\r\n        class=\"ui-icon     \r\nui-icon-play\" style=\"display: inline-block\"" +
" /></a>\r\n");


            
            #line 76 "..\..\Views\NhanVienBHXH\Index2.cshtml"
}

            
            #line default
            #line hidden

            
            #line 77 "..\..\Views\NhanVienBHXH\Index2.cshtml"
 if (ngayttv < 0 && apdungttv == false)
{

            
            #line default
            #line hidden
WriteLiteral("    <span style=\"background: #FF9933\">Áp dụng ML TTV mới!(trễ ");


            
            #line 79 "..\..\Views\NhanVienBHXH\Index2.cshtml"
                                                         Write(ttvTre);

            
            #line default
            #line hidden
WriteLiteral(" ngày)</span>\r\n");



WriteLiteral("    <a href=\"../dmTyLeDongBH/index2\" target=\"_blank\" title=\"Mẫu A01-TS\"><span cla" +
"ss=\"ui-icon     \r\nui-icon-play\" style=\"display: inline-block\" /></a>\r\n");


            
            #line 82 "..\..\Views\NhanVienBHXH\Index2.cshtml"
}

            
            #line default
            #line hidden

            
            #line 83 "..\..\Views\NhanVienBHXH\Index2.cshtml"
Write(Html.StatusMessage(TempData["Message"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div>\r\n    <input type=\"button\" value=\"Thêm mới NV BHXH\" id=\"TaoMoi\" />\r\n    <i" +
"nput type=\"button\" value=\"ĐC tăng giảm\" onClick=\"window.open(\'");


            
            #line 86 "..\..\Views\NhanVienBHXH\Index2.cshtml"
                                                               Write(Url.Action("index2", "DanhSachDieuChinhTangGiam"));

            
            #line default
            #line hidden
WriteLiteral("\',\'pwin\')\">\r\n    <input type=\"button\" value=\"ĐC chức danh\" onClick=\"window.open(\'" +
"");


            
            #line 87 "..\..\Views\NhanVienBHXH\Index2.cshtml"
                                                               Write(Url.Action("index2", "DanhSachDieuChinhChucDanh"));

            
            #line default
            #line hidden
WriteLiteral("\',\'pwin2\')\">\r\n    <input type=\"button\" value=\"Danh mục\" id=\"DM\" />\r\n    <input ty" +
"pe=\"button\" value=\"Quá Trình BHXH\" onclick=\"window.open(\'../QTBHXH/Index2?id=-1\'" +
",\'pwin4\')\">\r\n\r\n   \r\n");



WriteLiteral("\r\n    \r\n    \r\n  <a style=\"text-align: right\" title=\"Đóng\" class=\'button2\'>\r\n     " +
"   <span class=\"ui-icon ui-icon-closethick\" style=\"display: inline-block\" />\r\n  " +
"  </a>\r\n</div>\r\n<div id=\"DSDanhMuc\">\r\n    ");


            
            #line 100 "..\..\Views\NhanVienBHXH\Index2.cshtml"
Write(Html.ActionLink("Mức lương tối thiểu chung", "Index2", "dmMucLuongToiThieuChung"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 101 "..\..\Views\NhanVienBHXH\Index2.cshtml"
Write(Html.ActionLink("Mức lương tối thiểu vùng", "Index2", "dmMucLuongToiThieuVung"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 102 "..\..\Views\NhanVienBHXH\Index2.cshtml"
Write(Html.ActionLink("Tỷ lệ đóng bảo hiểm", "Index2", "dmTyLeDongBH"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 103 "..\..\Views\NhanVienBHXH\Index2.cshtml"
Write(Html.ActionLink("Nơi KCB", "Index2", "dmNoiKCB"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");



WriteLiteral(@"
<div id=""delete"">
</div>
<div id=""tabs"">
    <div align=""center"">
        
        <img src=""/../../Forms/HRM1/Images/bar-large-green.gif"" id=""imgProg1"" visible=""false"" /></div>
    <p id=""imgProg1"" visible=""false"" align=""center"">
        ĐANG TẢI...</p>
</div>
<div id=""edit"">
    <div align=""center"">
        <img src=""/../../Forms/HRM1/Images/bar-large-green.gif"" id=""imgProg"" visible=""false"" /></div>
    <p id=""imgProg"" visible=""false"" align=""center"">
        ĐANG TẢI...</p>
</div>
<table id=""NVBHXH"">
    <thead>
        <tr>
            <th style=""text-align: center"" nowrap rowspan=""2"">
                Tình trạng
            </th>
            <th style=""text-align: center"" nowrap rowspan=""2"">
                Họ và tên
            </th>
            <th style=""text-align: center"" nowrap rowspan=""2"">
                Số ngày còn lại
            </th>
            ");



WriteLiteral(@"
            <th style=""text-align: center; border-right: 1.5px solid gray;"" nowrap colspan=""2"">
                BHXH
            </th>
            <th style=""text-align: center; border-right: 1.5px solid gray;"" nowrap colspan=""2"">
                BHTN
            </th>
            <th style=""text-align: center"" nowrap rowspan=""2"">
                Mã NV
            </th>
            <th style=""text-align: center"" nowrap rowspan=""2"">
                Đơn vị
            </th>
            <th style=""text-align: center"" nowrap rowspan=""2"">
                Số BHXH
            </th>
            <th style=""text-align: center"" nowrap rowspan=""2"">
                Số KCB
            </th>
            <th style=""text-align: center"" nowrap rowspan=""2"">
                Ngày sinh
            </th>
            <th style=""text-align: center"" nowrap rowspan=""2"">
                Nữ
            </th>
            <th style=""text-align: center"" nowrap rowspan=""2"">
                CMND
            </th>
            <th style=""text-align: center"" nowrap rowspan=""2"">
                Chức danh nghề nghiệp
            </th>
            <th style=""text-align: center"" nowrap rowspan=""2"">
                Địa chỉ TT
            </th>
            <th style=""text-align: center"" nowrap rowspan=""2"">
                Nơi KCB
            </th>
            <th style=""text-align: center"" nowrap rowspan=""2"">
                HS lương
            </th>
            ");



WriteLiteral(@"
            <th rowspan=""2"">
                <a title=""Sửa""><span class=""ui-icon ui-icon-grip-dotted-horizontal"" style=""display: inline-block"" />
                </a>
            </th>
        </tr>
        <tr>
            <th style=""text-align: center"" nowrap>
                Năm
            </th>
            <th style=""text-align: center"" nowrap>
                Tháng
            </th>
            <th style=""text-align: center"" nowrap>
                Năm
            </th>
            <th style=""text-align: center"" nowrap>
                Tháng
            </th>
        </tr>
    </thead>
    <tbody>
");


            
            #line 197 "..\..\Views\NhanVienBHXH\Index2.cshtml"
         foreach (var item in Model)
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <td style=\"text-align: left\" nowrap>\r\n         " +
"           ");



WriteLiteral("\r\n");


            
            #line 202 "..\..\Views\NhanVienBHXH\Index2.cshtml"
                     if (item.ngayNghiViec == null)
                    {
                        if (item.TinhTrang == null)
                        {

            
            #line default
            #line hidden
WriteLiteral("                        <span>Đang làm việc </span>\r\n");


            
            #line 207 "..\..\Views\NhanVienBHXH\Index2.cshtml"
                                 
                        }

                        if (item.TinhTrang == "TS")
                        {

            
            #line default
            #line hidden
WriteLiteral("                        <span>Nghỉ TS </span>\r\n");


            
            #line 213 "..\..\Views\NhanVienBHXH\Index2.cshtml"
                        }
                        if (item.TinhTrang == "OF_1")
                        {

            
            #line default
            #line hidden
WriteLiteral("                        <span>Nghỉ ngắn hạn </span>\r\n");


            
            #line 217 "..\..\Views\NhanVienBHXH\Index2.cshtml"
                        }
                        if (item.TinhTrang == "OF_2")
                        {

            
            #line default
            #line hidden
WriteLiteral("                        <span>Nghỉ dài hạn </span>\r\n");


            
            #line 221 "..\..\Views\NhanVienBHXH\Index2.cshtml"
                        }
                        if (item.TinhTrang == "ON")
                        {

            
            #line default
            #line hidden
WriteLiteral("                        <span>Nghỉ đi làm lại</span>\r\n");


            
            #line 225 "..\..\Views\NhanVienBHXH\Index2.cshtml"
                        }

                    }
                    else
                    {
                        if (item.ngayNghiViec != null)
                        {

            
            #line default
            #line hidden
WriteLiteral("                        <span>Nghỉ việc </span>\r\n");


            
            #line 233 "..\..\Views\NhanVienBHXH\Index2.cshtml"
                        }
                    }

            
            #line default
            #line hidden
WriteLiteral("                </td>\r\n                <td style=\"text-align: left\" nowrap>\r\n    " +
"                ");


            
            #line 237 "..\..\Views\NhanVienBHXH\Index2.cshtml"
               Write(Html.DisplayFor(modelItem => item.HoVaTen));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align: left\" nowrap>\r\n");


            
            #line 240 "..\..\Views\NhanVienBHXH\Index2.cshtml"
                     if (item.ThangNghiTS <= 15 && item.ThangNghiTS >= 0)
                    {
                        
            
            #line default
            #line hidden
            
            #line 242 "..\..\Views\NhanVienBHXH\Index2.cshtml"
                   Write(item.ThangNghiTS);

            
            #line default
            #line hidden
            
            #line 242 "..\..\Views\NhanVienBHXH\Index2.cshtml"
                                         
                    }
                    else
                    {
            
            #line default
            #line hidden
WriteLiteral("<span></span> ");


            
            #line 245 "..\..\Views\NhanVienBHXH\Index2.cshtml"
                                   }

            
            #line default
            #line hidden
WriteLiteral("                </td>\r\n                <td style=\"text-align: left\" nowrap>\r\n    " +
"                ");


            
            #line 248 "..\..\Views\NhanVienBHXH\Index2.cshtml"
               Write(Html.DisplayFor(modelItem => item.SoNamThamGiaBHXH));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align: left\" nowrap>\r\n  " +
"                  ");


            
            #line 251 "..\..\Views\NhanVienBHXH\Index2.cshtml"
               Write(Html.DisplayFor(modelItem => item.SoThangThamGiaBHXH));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align: left\" nowrap>\r\n  " +
"                  ");


            
            #line 254 "..\..\Views\NhanVienBHXH\Index2.cshtml"
               Write(Html.DisplayFor(modelItem => item.SoNamThamGiaBHTNT));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align: left\" nowrap>\r\n  " +
"                  ");


            
            #line 257 "..\..\Views\NhanVienBHXH\Index2.cshtml"
               Write(Html.DisplayFor(modelItem => item.SoThangThamGiaBHTN));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align: left\" nowrap>\r\n  " +
"                  ");


            
            #line 260 "..\..\Views\NhanVienBHXH\Index2.cshtml"
               Write(Html.DisplayFor(modelItem => item.MANV));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align: left\" nowrap>\r\n  " +
"                  ");


            
            #line 263 "..\..\Views\NhanVienBHXH\Index2.cshtml"
               Write(Html.DisplayFor(modelItem => item.tenDonVi));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align: left\" nowrap>\r\n  " +
"                  ");


            
            #line 266 "..\..\Views\NhanVienBHXH\Index2.cshtml"
               Write(Html.DisplayFor(modelItem => item.SoBHXH));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align: left\" nowrap>\r\n  " +
"                  ");


            
            #line 269 "..\..\Views\NhanVienBHXH\Index2.cshtml"
               Write(Html.DisplayFor(modelItem => item.SoKCB));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align: left\" nowrap>\r\n");


            
            #line 272 "..\..\Views\NhanVienBHXH\Index2.cshtml"
                     if (@item.NgaySinh != null)
                    {
                        
            
            #line default
            #line hidden
            
            #line 274 "..\..\Views\NhanVienBHXH\Index2.cshtml"
                   Write(item.NgaySinh.GetValueOrDefault().ToShortDateString());

            
            #line default
            #line hidden
            
            #line 274 "..\..\Views\NhanVienBHXH\Index2.cshtml"
                                                                              
                    }

            
            #line default
            #line hidden
WriteLiteral("                </td>\r\n                <td style=\"text-align: left\" nowrap>\r\n");


            
            #line 278 "..\..\Views\NhanVienBHXH\Index2.cshtml"
                     if (item.Nu == true)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <span>\r\n                            ");


            
            #line 281 "..\..\Views\NhanVienBHXH\Index2.cshtml"
                       Write(Html.CheckBox("check1", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </span>\r\n");


            
            #line 283 "..\..\Views\NhanVienBHXH\Index2.cshtml"
                    }
                    else
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <span>\r\n                            ");


            
            #line 287 "..\..\Views\NhanVienBHXH\Index2.cshtml"
                       Write(Html.CheckBox("check1", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </span>\r\n");


            
            #line 289 "..\..\Views\NhanVienBHXH\Index2.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </td>\r\n                <td style=\"text-align: left\" nowrap>\r\n    " +
"                ");


            
            #line 292 "..\..\Views\NhanVienBHXH\Index2.cshtml"
               Write(Html.DisplayFor(modelItem => item.CMND));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align: left\" nowrap>\r\n  " +
"                  ");


            
            #line 295 "..\..\Views\NhanVienBHXH\Index2.cshtml"
               Write(Html.DisplayFor(modelItem => item.chucdanh));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                ");



WriteLiteral("\r\n                <td style=\"text-align: left\" nowrap>\r\n                    ");


            
            #line 301 "..\..\Views\NhanVienBHXH\Index2.cshtml"
               Write(Html.DisplayFor(modelItem => item.diachi));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align: left\" nowrap>\r\n  " +
"                  ");


            
            #line 304 "..\..\Views\NhanVienBHXH\Index2.cshtml"
               Write(Html.DisplayFor(modelItem => item.MaBV));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align: left\" nowrap>\r\n  " +
"                  ");


            
            #line 307 "..\..\Views\NhanVienBHXH\Index2.cshtml"
               Write(Html.DisplayFor(modelItem => item.HeSoLuong));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                ");



WriteLiteral("\r\n                <td nowrap>\r\n                    <a  title=\"Sửa\" data-val1=\"");


            
            #line 313 "..\..\Views\NhanVienBHXH\Index2.cshtml"
                                          Write(item.id);

            
            #line default
            #line hidden
WriteLiteral("\"  class=\'button1\'><span class=\"ui-icon ui-icon-pencil\"\r\n                        " +
"style=\"display: inline-block\" /></a>\r\n                        <a href=\"../QTBHXH" +
"/Index2?id=");


            
            #line 315 "..\..\Views\NhanVienBHXH\Index2.cshtml"
                                                Write(item.NV_id);

            
            #line default
            #line hidden
WriteLiteral("\" title=\"Quá trình tham gia BHXH\" target=\"_blank\" >\r\n                         <sp" +
"an class=\"ui-icon ui-icon-clipboard\" style=\"display: inline-block\" />\r\n         " +
"           </a>\r\n                    <a data-val1=\"");


            
            #line 318 "..\..\Views\NhanVienBHXH\Index2.cshtml"
                             Write(item.id);

            
            #line default
            #line hidden
WriteLiteral("\" title=\"Xóa\" class=\'button3\'><span class=\"ui-icon ui-icon-trash\"\r\n              " +
"          style=\"display: inline-block\" /></a>\r\n                </td>\r\n         " +
"   </tr>\r\n");


            
            #line 322 "..\..\Views\NhanVienBHXH\Index2.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral(@"    </tbody>
</table>
<script src=""/Scripts/datatables/FixedColumns.js""></script>
<script src=""/Content/datatables/https://www.google.com.vn/url?sa=i&rct=j&q=&esrc=s&source=images&cd=&docid=LMvACRxg8z0CnM&tbnid=_1ECO1EzWG_1NM:&ved=0CAUQjRw&url=http%3A%2F%2Fviz4u.net%2Fblog%2F%3Fp%3D4419&ei=xv83U-uIJ6OFiAfl2IC4DA&bvm=bv.63808443,d.aGc&psig=AFQjCNEV_KWNVRJ-2Y6B1uEePclGXKkDuQ&ust=1396265283208328DataTableFixedHeader.js""></script>
");


DefineSection("scripts", () => {

WriteLiteral("\r\n    <script>\r\n\r\n\r\n\r\n\r\n    //load truoc cac view de tang toc do khi slide cac ta" +
"b\r\n    $.get(\"../NhanVienBHXH/Create\").success(function (data) {\r\n        $(\'#ta" +
"bs\').html(data);\r\n         $(\"#imgProg1\").hide();\r\n    });\r\n\r\n//    $.get(\"../Nh" +
"anVienBHXH/edit?id=1\").success(function (data) {\r\n//        $(\'#edit\').html(data" +
");\r\n//       \r\n//    });\r\n\r\n    $.get(\"../NhanVienBHXH/delete?id=1\").success(fun" +
"ction (data) {\r\n        $(\'#delete\').html(data);\r\n   \r\n    });\r\n\r\n      $(\"#imgP" +
"rog\").hide();\r\n//an nut close mac dinh\r\n    $(\".button2\").hide();\r\n    //xu li n" +
"ut edit\r\n    $(function () {\r\n        $(\'.button1\').click(function () {\r\n       " +
"     var Val1 = $(this).attr(\"data-val1\");\r\n            var $t4 = $(\'#DSDanhMuc\'" +
");\r\n            var $t5 = $(\'#tabs\');\r\n            var $t6 = $(\'#delete\');\r\n    " +
"        //dong cac tab con lai dang open\r\n            if ($t4.is(\':visible\')) {\r" +
"\n                $t4.slideUp();\r\n                // Other stuff to do on slideUp" +
"\r\n            }\r\n            if ($t5.is(\':visible\')) {\r\n                $t5.slid" +
"eUp();\r\n                // Other stuff to do on slideUp\r\n            }\r\n        " +
"    if ($t6.is(\':visible\')) {\r\n                $t6.slideUp();\r\n                /" +
"/ Other stuff to do on slideUp\r\n            }\r\n            //get trang edit len " +
"tab\r\n    \r\n        $(\"#imgProg\").show();\r\n\r\n             $(\"#edit\").slideDown(\"m" +
"edium\");\r\n         \r\n            $.get(\"../NhanVienBHXH/edit?id=\" + Val1).succes" +
"s(function (data) {\r\n                $(\'#edit\').html(data);\r\n                  $" +
"(\"#imgProg\").hide();\r\n            });\r\n            $(\".button2\").show();\r\n      " +
"      //back to top of the page\r\n            $(\'html, body\').animate({ scrollTop" +
": 0 }, \'slow\');\r\n\r\n\r\n        });\r\n    });\r\n    //xu li nut close\r\n    $(function" +
" () {\r\n        $(\'.button2\').click(function () {\r\n        //an nut close\r\n      " +
"      $(\".button2\").hide();\r\n            //dong tat ca cac tab\r\n            $(\"#" +
"edit\").slideUp(\"medium\");\r\n            $(\"#DSDanhMuc\").slideUp(\"medium\");\r\n     " +
"       $(\"#tabs\").slideUp(\"medium\");\r\n            $(\"#delete\").slideUp(\"medium\")" +
";\r\n\r\n\r\n        });\r\n    });\r\n    //xu li nut delete\r\n    $(function () {\r\n      " +
"  $(\'.button3\').click(function () {\r\n            var Val1 = $(this).attr(\"data-v" +
"al1\");\r\n            //goi delete view len tab\r\n            $.get(\"../NhanVienBHX" +
"H/delete?id=\" + Val1).success(function (data) {\r\n                $(\'#delete\').ht" +
"ml(data);\r\n                $(\"#delete\").slideDown(\"medium\");\r\n            });\r\n " +
"           //hien ra nut close\r\n            $(\".button2\").show();\r\n            /" +
"/dong cac tab con lai dang open\r\n            var $t4 = $(\'#DSDanhMuc\');\r\n       " +
"     var $t5 = $(\'#tabs\');\r\n            var $t6 = $(\'#edit\');\r\n            if ($" +
"t4.is(\':visible\')) {\r\n                $t4.slideUp();\r\n                // Other s" +
"tuff to do on slideUp\r\n            }\r\n            if ($t5.is(\':visible\')) {\r\n   " +
"             $t5.slideUp();\r\n                // Other stuff to do on slideUp\r\n  " +
"          }\r\n            if ($t6.is(\':visible\')) {\r\n                $t6.slideUp(" +
");\r\n                // Other stuff to do on slideUp\r\n            }\r\n            " +
"$(\'html, body\').animate({ scrollTop: 0 }, \'slow\');\r\n\r\n\r\n        });\r\n    });\r\n\r\n" +
"\r\n    //datatable\r\n    $(document).ready(function () {\r\n\r\n\r\n\r\n        var oTable" +
" = $(\'#NVBHXH\').dataTable({\r\n\r\n            \"bJQueryUI\": true,\r\n            \"sScr" +
"ollY\": \"100%\",\r\n            \"sScrollX\": \"100%\"\r\n            , \"aaSorting\": [],\r\n" +
"  \r\n     \r\n            \"fnRowCallback\": function (nRow, aData, iDisplayIndex) {\r" +
"\n\r\n                if (aData[2] <=15 ) {\r\n                    $(nRow).css(\'backg" +
"round-color\', \'#CCFFFF\');\r\n                    $(nRow).css(\'border\', \'1px solid " +
"#999\');\r\n                 \r\n           \r\n                   \r\n                \r\n" +
"                }\r\n            }\r\n\r\n\r\n     \r\n        });\r\n\r\n\r\n\r\n        //fix co" +
"lumn\r\n        new $.fn.dataTable.FixedColumns(oTable, {\r\n            \"iLeftColum" +
"ns\": 2,\r\n            \"iRightColumns\": 1\r\n        });\r\n\r\n//         $(\'#NVBHXH tb" +
"ody\').on(\'click\', \'tr\', function () {\r\n//        var id = this.id;\r\n//        va" +
"r index = $.inArray(id, selected);\r\n// \r\n//        if ( index === -1 ) {\r\n//    " +
"        selected.push( id );\r\n//        } else {\r\n//            selected.splice(" +
" index, 1 );\r\n//        }\r\n// \r\n//        $(this).toggleClass(\'selected\');\r\n//  " +
"  } );\r\n    });\r\n\r\n    //add tabs\r\n    $(\"#delete\").tabs();\r\n    $(\"#tabs\").tabs" +
"();\r\n    $(\"#DSDanhMuc\").tabs();\r\n    $(\"#edit\").tabs();\r\n\r\n\r\n    //xu li nut da" +
"nh muc\r\n    $(\"#DM\").click(function () {\r\n        $(\".button2\").show();\r\n       " +
" $(\"#DSDanhMuc\").slideToggle(\"fast\");\r\n        var $t = $(\'#tabs\');\r\n        var" +
" $t2 = $(\'#edit\');\r\n        var $t3 = $(\'#delete\');\r\n        //dong cac tab con " +
"lai dang open\r\n        if ($t.is(\':visible\')) {\r\n            $t.slideUp();\r\n    " +
"        // Other stuff to do on slideUp\r\n        }\r\n        if ($t2.is(\':visible" +
"\')) {\r\n            $t2.slideUp();\r\n            // Other stuff to do on slideUp\r\n" +
"        }\r\n        if ($t3.is(\':visible\')) {\r\n            $t3.slideUp();\r\n      " +
"      // Other stuff to do on slideUp\r\n        }\r\n    });\r\n\r\n    //xu li nut tao" +
" moi\r\n    $(\"#TaoMoi\").click(function () {\r\n\r\n     $(\"#imgProg1\").show();\r\n     " +
"   $(\"#tabs\").slideToggle(\"medium\");\r\n\r\n        $(\".button2\").show();\r\n\r\n     \r\n" +
"               \r\n        var $t1 = $(\'#DSDanhMuc\');\r\n        var $t3 = $(\'#edit\'" +
");\r\n        var $t4 = $(\'#delete\');\r\n        //dong cac tab con lai dang open\r\n " +
"       if ($t1.is(\':visible\')) {\r\n            $t1.slideUp();\r\n            // Oth" +
"er stuff to do on slideUp\r\n        }\r\n        if ($t3.is(\':visible\')) {\r\n       " +
"     $t3.slideUp();\r\n            // Other stuff to do on slideUp\r\n        }\r\n   " +
"     if ($t4.is(\':visible\')) {\r\n            $t4.slideUp();\r\n            // Other" +
" stuff to do on slideUp\r\n        }\r\n    });\r\n\r\n\r\n//    $(\"#id\").datepicker({\r\n//" +
"        changeMonth: true,\r\n//        changeYear: true,\r\n//        showButtonPan" +
"el: true,\r\n//        dateFormat: \'MM/yy\',\r\n//        onClose: function (dateText" +
", inst) {\r\n//            var month = $(\"#ui-datepicker-div .ui-datepicker-month " +
":selected\").val();\r\n//            var year = $(\"#ui-datepicker-div .ui-datepicke" +
"r-year :selected\").val();\r\n//            $(this).datepicker(\'setDate\', new Date(" +
"year, month, 4));\r\n//        }\r\n//    });\r\n\r\n   // Xử lý nút Lọc ( id = filter)\r" +
"\n\r\n   var dv1 = $(\"[id$=iddsdonvi]\").combobox();\r\n\r\n\r\n//khi chon khoa tren combb" +
"ox tu dong load\r\n\r\n    dv1.change(function () {\r\n           var txtVal = dv1.val" +
"();\r\n            window.location = \"");


            
            #line 568 "..\..\Views\NhanVienBHXH\Index2.cshtml"
                          Write(Url.Action("Index2", "NhanVienBHXH"));

            
            #line default
            #line hidden
WriteLiteral("\" +\"?dv=\" + txtVal;\r\n    });\r\n    \r\n \r\n    </script>\r\n");


});

WriteLiteral(@"
<style type=""text/css"">
    #DSDanhMuc
    {
        text-align: left;
    }
    #tabs
    {
        text-align: left;
    }
    #DSDanhMuc, #tabs, #edit, #delete
    {
        display: none;
    }
    
     .dataTables_wrapper tbody tr:hover {
    background-color: #FFFF00!important;
    cursor: pointer;
    * cursor: hand;}
    .DataTables_sort_icon { display:none;}
</style>
");


        }
    }
}
#pragma warning restore 1591
