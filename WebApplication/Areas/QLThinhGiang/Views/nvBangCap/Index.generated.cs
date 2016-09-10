﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRM.QLThinhGiang.Views.nvBangCap
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
    
    #line 1 "..\..\Views\nvBangCap\Index.cshtml"
    using HRM.Webpages.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/nvBangCap/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<HRM.QLThinhGiang.Models.nvBangCap>
    {
        public Index()
        {
        }
        public override void Execute()
        {



            
            #line 3 "..\..\Views\nvBangCap\Index.cshtml"
  
    var db = ViewBag.DB as HRM.QLThinhGiang.Models.HRMDB_Entities;
    var d0 = new HRM.Databases.Models.HRMDB0Entities();
    var nvBangCap = db.NhanVien.Find(Model.NV_id).nvBangCaps.Where(n => n.Xoa != true).Where(n => n.SauKhiVeTruong != true).ToList();
    var nvBangCapSau = db.NhanVien.Find(Model.NV_id).nvBangCaps.Where(n => n.Xoa != true).Where(n => n.SauKhiVeTruong == true).ToList();


            
            #line default
            #line hidden

            
            #line 9 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.StatusMessage(TempData["Message"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 10 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.ValidationSummary(TempData["ModelState"]));

            
            #line default
            #line hidden
WriteLiteral(@"
<h3>Văn bằng</h3>
<div style=""overflow:auto"">
<table id=""tmp"" style=""width:1270px"" class=""table-hover"">
<thead>
<tr nowarp>
    <th width=""100px"" >Trình độ</th>
    <th width=""100px"">Danh hiệu</th>
    <td width=""150px""><b>Nhóm chuyên ngành</b></td>
    <th width=""100px"">Chuyên ngành</th>
    <th width=""100px"" >Loại hình</th> 
    <th width=""110px"" >Nơi học</th>
    <th width=""190px"" ></th>
    <th></th>
    <th width=""100px"" >Xếp loại</th>     
    <th width=""100px""> Ngày cấp</th>
    <td width=""20px""><b> DHC </b></td>
    <th width=""100px"" >CNC</th>
    <th width=""100px"" >Ghi chú</th>
    <th></th>
    <th> </th>
    <th> </th>
</tr>
</thead>
<tbody>
<tr>
<td colspan=18 nowrap>
</tr>
");


            
            #line 38 "..\..\Views\nvBangCap\Index.cshtml"
 foreach (var item in nvBangCap)
{
    var prefix = "item" + item.GetHashCode();

            
            #line default
            #line hidden
WriteLiteral("<tr>\r\n\r\n");


            
            #line 43 "..\..\Views\nvBangCap\Index.cshtml"
 using (Html.BeginForm("Update", "nvBangCap"))
{
    
            
            #line default
            #line hidden
            
            #line 45 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.Hidden("Prefix", prefix));

            
            #line default
            #line hidden
            
            #line 45 "..\..\Views\nvBangCap\Index.cshtml"
                                  
    
            
            #line default
            #line hidden
            
            #line 46 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.Hidden("BC_id", item.id));

            
            #line default
            #line hidden
            
            #line 46 "..\..\Views\nvBangCap\Index.cshtml"
                                  
    ViewData.TemplateInfo.HtmlFieldPrefix = prefix;
    
            
            #line default
            #line hidden
            
            #line 48 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.Hidden("false", item.SauKhiVeTruong));

            
            #line default
            #line hidden
            
            #line 48 "..\..\Views\nvBangCap\Index.cshtml"
                                              

            
            #line default
            #line hidden
WriteLiteral("    <td>\r\n    ");


            
            #line 50 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.DropDownListFor(model => item.LoaiBangCap_id, new SelectList(d0.dmLoaiBangCap, "id", "tenloaibangcap", item.LoaiBangCap_id)));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 51 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.ValidationMessageFor(model => item.LoaiBangCap_id));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n");



WriteLiteral("    <td>\r\n    ");


            
            #line 54 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.DropDownListFor(model => item.DanhHieu_id, new SelectList(d0.dmDanhHieu, "id", "tendanhhieu", item.DanhHieu_id)));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 55 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.ValidationMessageFor(model => item.DanhHieu_id));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n");



WriteLiteral("    <td>\r\n    ");


            
            #line 58 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.DropDownListFor(model => item.ChuyenNganh_id, new SelectList(d0.dmChuyenNganh, "id", "tenchuyennganh", item.ChuyenNganh_id)));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 59 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.ValidationMessageFor(model => item.ChuyenNganh_id));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n");



WriteLiteral("    <td>\r\n    ");


            
            #line 62 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.TextBoxFor(model => item.ChuyenNganh, new { Title = item.ChuyenNganh.ToString() }));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 63 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.ValidationMessageFor(model => item.ChuyenNganh));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n");



WriteLiteral("    <td>\r\n    ");


            
            #line 66 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.DropDownListFor(model => item.LoaiHinhDaoTao_id, new SelectList(d0.dmLoaiHinhDaoTao, "id", "tenloaihinhdaotao", item.LoaiHinhDaoTao_id)));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 67 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.ValidationMessageFor(model => item.LoaiHinhDaoTao_id));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n");



WriteLiteral("    <td>\r\n    ");


            
            #line 70 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.TextBoxFor(model => item.TenTruong, new { Title = item.TenTruong.ToString() }));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 71 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.ValidationMessageFor(model => item.TenTruong));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n");



WriteLiteral("    <td>\r\n    ");


            
            #line 74 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.DropDownListFor(model => item.QuocGia_id, new SelectList(d0.dmQuocGia, "id", "tenquocgia", item.QuocGia_id)));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 75 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.ValidationMessageFor(model => item.QuocGia_id));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n");



WriteLiteral("    <td>\r\n    ");


            
            #line 78 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.DropDownListFor(model => item.NoiHoc_id, new SelectList(d0.dmNoiHoc, "id", "tennoihoc", item.NoiHoc_id)));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 79 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.ValidationMessageFor(model => item.NoiHoc_id));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n");



WriteLiteral("    <td>\r\n    ");


            
            #line 82 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.DropDownListFor(model => item.XepLoaiTotNghiep_id, new SelectList(d0.dmXepLoaiTotNghiep, "id", "tenXepLoaiTotNghiep", item.XepLoaiTotNghiep_id)));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 83 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.ValidationMessageFor(model => item.XepLoaiTotNghiep_id));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n");



WriteLiteral("    <td>\r\n    ");


            
            #line 86 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.EditorFor(model => item.NgayTN));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 87 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.ValidationMessageFor(model => item.NgayTN));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n");



WriteLiteral("    <td>\r\n    ");


            
            #line 90 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.CheckBoxFor(model => item.Chuyennganhchinh));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 91 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.ValidationMessageFor(model => item.Chuyennganhchinh));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n");



WriteLiteral("    <td>\r\n    ");


            
            #line 94 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.CheckBoxFor(model => item.DanhHieuChinh));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 95 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.ValidationMessageFor(model => item.DanhHieuChinh));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n");



WriteLiteral("    <td>\r\n    ");


            
            #line 98 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.EditorFor(model => item.GhiChu));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 99 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.ValidationMessageFor(model => item.GhiChu));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n");



WriteLiteral("    <td>\r\n    <input type=\"submit\" value=\"Update\" style=\"position:absolute;left:-" +
"9999px\" />\r\n    </td>\r\n");



WriteLiteral("    <td>\r\n    <a title=\"Sửa\" onclick=\"$(this).hide().parents(\'tr\').find(\'a,input," +
"select\').prop(\'disabled\',false).prop(\'hidden\',false)\"><span class=\"ui-icon ui-ic" +
"on-pencil\" style=\"display:inline-block\"/></a>\r\n    </td>\r\n");



WriteLiteral("    <td>\r\n    <a title=\"Nhấn Enter để Lưu\" onclick=\"$(this).parents(\'tr\').find(\'f" +
"orm\').submit()\" hidden><span class=\"ui-icon ui-icon-disk\" style=\"display:inline-" +
"block\"/></a>\r\n    </td>\r\n");



WriteLiteral("    <td>\r\n    <a title=\"Xóa\" href=\"~/QLTTNhanSu/nvBangCap/Delete/");


            
            #line 111 "..\..\Views\nvBangCap\Index.cshtml"
                                                  Write(item.id);

            
            #line default
            #line hidden
WriteLiteral("\" onclick=\"return confirm(\'Bạn có muốn xóa quá bằng cấp này?\')\"><span class=\"ui-i" +
"con ui-icon-trash\" style=\"display:inline-block\"/></a>\r\n    </td>\r\n");


            
            #line 113 "..\..\Views\nvBangCap\Index.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral(" \r\n</tr>\r\n");


            
            #line 116 "..\..\Views\nvBangCap\Index.cshtml"
ViewData.TemplateInfo.HtmlFieldPrefix = null;
}

            
            #line default
            #line hidden
WriteLiteral("<tr>\r\n");


            
            #line 119 "..\..\Views\nvBangCap\Index.cshtml"
 using (Html.BeginForm("Update", "nvBangCap"))
{
    
            
            #line default
            #line hidden
            
            #line 121 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.Hidden("false", Model.SauKhiVeTruong));

            
            #line default
            #line hidden
            
            #line 121 "..\..\Views\nvBangCap\Index.cshtml"
                                               
    var prefix = "model" + Model.GetHashCode();
    
            
            #line default
            #line hidden
            
            #line 123 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.HiddenFor(model => model.NV_id));

            
            #line default
            #line hidden
            
            #line 123 "..\..\Views\nvBangCap\Index.cshtml"
                                         

            
            #line default
            #line hidden
WriteLiteral("    <td>\r\n    ");


            
            #line 125 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.DropDownListFor(model => model.LoaiBangCap_id, new SelectList(d0.dmLoaiBangCap, "id", "tenloaibangcap", Model.LoaiBangCap_id), string.Empty));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 126 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.ValidationMessageFor(model => model.LoaiBangCap_id));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n");



WriteLiteral("    <td>\r\n    ");


            
            #line 129 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.DropDownListFor(model => model.DanhHieu_id, new SelectList(d0.dmDanhHieu, "id", "tendanhhieu"), string.Empty));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 130 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.ValidationMessageFor(model => model.DanhHieu_id));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n");



WriteLiteral("    <td>\r\n    ");


            
            #line 133 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.DropDownListFor(model => model.ChuyenNganh_id, new SelectList(d0.dmChuyenNganh, "id", "tenchuyennganh"), string.Empty));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 134 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.ValidationMessageFor(model => model.ChuyenNganh_id));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n");



WriteLiteral("    <td>\r\n    ");


            
            #line 137 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.EditorFor(model => model.ChuyenNganh));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 138 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.ValidationMessageFor(model => model.ChuyenNganh));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n");



WriteLiteral("    <td>\r\n    ");


            
            #line 141 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.DropDownListFor(model => model.LoaiHinhDaoTao_id, new SelectList(d0.dmLoaiHinhDaoTao, "id", "tenloaihinhdaotao"), string.Empty));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 142 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.ValidationMessageFor(model => model.LoaiHinhDaoTao_id));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n");



WriteLiteral("    <td>\r\n    ");


            
            #line 145 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.EditorFor(model => model.TenTruong));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 146 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.ValidationMessageFor(model => model.TenTruong));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n");



WriteLiteral("    <td>\r\n    ");


            
            #line 149 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.DropDownListFor(model => model.QuocGia_id, new SelectList(d0.dmQuocGia, "id", "tenquocgia", "Việt Nam"), string.Empty));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 150 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.ValidationMessageFor(model => model.QuocGia_id));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n");



WriteLiteral("    <td>\r\n    ");


            
            #line 153 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.DropDownListFor(model => model.NoiHoc_id, new SelectList(d0.dmNoiHoc, "id", "tennoihoc", Model.NoiHoc_id), string.Empty));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 154 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.ValidationMessageFor(model => model.NoiHoc_id));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n");



WriteLiteral("    <td>\r\n    ");


            
            #line 157 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.DropDownListFor(model => model.XepLoaiTotNghiep_id, new SelectList(d0.dmXepLoaiTotNghiep, "id", "tenXepLoaiTotNghiep"), string.Empty));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 158 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.ValidationMessageFor(model => model.XepLoaiTotNghiep_id));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n");



WriteLiteral("    <td>\r\n    ");


            
            #line 161 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.EditorFor(model => model.NgayTN));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 162 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.ValidationMessageFor(model => model.NgayTN));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n");



WriteLiteral("    <td>\r\n    ");


            
            #line 165 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.CheckBoxFor(model => model.Chuyennganhchinh));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 166 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.ValidationMessageFor(model => model.Chuyennganhchinh));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n");



WriteLiteral("    <td>\r\n    ");


            
            #line 169 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.CheckBoxFor(model => model.DanhHieuChinh));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 170 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.ValidationMessageFor(model => model.DanhHieuChinh));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n");



WriteLiteral("    <td>\r\n    ");


            
            #line 173 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.EditorFor(model => model.GhiChu));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 174 "..\..\Views\nvBangCap\Index.cshtml"
Write(Html.ValidationMessageFor(model => model.GhiChu));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n");



WriteLiteral("    <td>\r\n    <input type=\"submit\" value=\"Update\" style=\"position:absolute;left:-" +
"9999px\" />\r\n    </td>\r\n");



WriteLiteral("    <td>\r\n    <span title=\"Thêm, Nhấn Enter để Lưu\" class=\"ui-icon ui-icon-circle" +
"-plus\" style=\"display:inline-block\"></span>\r\n    </td>\r\n");



WriteLiteral("    <td></td>\r\n");


            
            #line 183 "..\..\Views\nvBangCap\Index.cshtml"
    ViewData.TemplateInfo.HtmlFieldPrefix = null;
}

            
            #line default
            #line hidden
WriteLiteral("\r\n</tr>\r\n</tbody>\r\n</table>\r\n</div>\r\n<style>\r\n\r\ninput { margin: 0 1 1 1 }\r\ninput," +
" textarea {\r\n    border: 0px solid #e2e2e2;\r\n    background: #fff;\r\n    color: #" +
"333;\r\n    font-size: 1.2em;\r\n    margin: 5px 0 6px 0;\r\n    padding: 1px;\r\n    wi" +
"dth: 300px;\r\n  \r\n}\r\n.ui-icon-triangle-1-s { display: none; }\r\n.ui-button-icon-pr" +
"imary { display: none; }\r\nth {\r\n    height: 50px;\r\n}\r\ntr {\r\n    height: 10px;\r\n}" +
"\r\n</style>\r\n\r\n    \r\n<script>\r\n    $(function () {\r\n        var $table = $(\"#tmp\"" +
");\r\n\r\n        $table.find(\"[id^=item]\").prop(\"disabled\", true);\r\n        $table." +
"find(\"input[type=datetime]\").datepicker({ changeMonth: true, changeYear: true })" +
".css(\"width\", \"80px\");\r\n        $table.find(\"input,select\").css(\"border\", \"0\").c" +
"ss(\"border-bottom\", \"1px dotted\");\r\n        $table.find(\"input[type=datetime]\")." +
"css(\"border-bottom\", \"1px dotted\");\r\n        $(\"[id$=TenTruong], [id=TenTruong]\"" +
").css(\"width\", \"100px\");\r\n        $(\"[id$=ChuyenNganh_id],[id$=GhiChu]\").css(\"wi" +
"dth\", \"150px\");\r\n        $(\"[id$=TenTruong], [id=TenTruong]\").css(\"border-bottom" +
"\", \"1px dotted\");\r\n        $(\"[id$=LoaiBangCap_id],[id$=cn1],[id$=NoiHoc_id],[id" +
"$=QuocGia_id],[id$=LoaiHinhDaoTao_id],[id$=XepLoaiTotNghiep_id],[id$=TrongNuoc]," +
"[id$=SoVaoSo],[id$=TrongNuoc],[id$=SoHieu]\").css(\"width\", \"100px\");\r\n//        $" +
"(\'.ui-autocomplete-input\').css(\'width\', \'100px\');\r\n        $table.find(\"input[ty" +
"pe=text]\").on(\"input\", function () {\r\n            $(this).attr(\"size\", $(this).v" +
"al().length + 1);\r\n        }).each(function () {\r\n            $(this).css(\"width" +
"\", \"auto\")\r\n                   .attr(\"size\", $(this).val().length + 1);\r\n       " +
" });\r\n        var bc = $(\"[id$=LoaiBangCap_id]\").combobox();\r\n        var dh = $" +
"(\"[id$=DanhHieu_id]\").combobox();\r\n        var cn = $(\"[id$=ChuyenNganh_id]\").co" +
"mbobox();\r\n        var qg = $(\"[id$=QuocGia_id]\").combobox();\r\n        var lh = " +
"$(\"[id$=LoaiHinhDaoTao_id]\").combobox();\r\n        var nh = $(\"[id$=NoiHoc_id]\")." +
"combobox();\r\n        var xl = $(\"[id$=XepLoaiTotNghiep_id]\").combobox();\r\n      " +
"  lh.parent().find(\"input.ui-autocomplete-input\").css(\"width\", \"70px\").css(\"bord" +
"er-bottom\", \"1px dotted\");\r\n        bc.parent().find(\"input.ui-autocomplete-inpu" +
"t\").css(\"width\", \"70px\").css(\"border-bottom\", \"1px dotted\");\r\n        dh.parent(" +
").find(\"input.ui-autocomplete-input\").css(\"width\", \"70px\").css(\"border-bottom\", " +
"\"1px dotted\");\r\n        cn.parent().find(\"input.ui-autocomplete-input\").css(\"wid" +
"th\", \"140px\").css(\"border-bottom\", \"1px dotted\");\r\n        qg.parent().find(\"inp" +
"ut.ui-autocomplete-input\").css(\"width\", \"70px\").css(\"border-bottom\", \"1px dotted" +
"\");\r\n        nh.parent().find(\"input.ui-autocomplete-input\").css(\"width\", \"70px\"" +
").css(\"border-bottom\", \"1px dotted\");\r\n        xl.parent().find(\"input.ui-autoco" +
"mplete-input\").css(\"width\", \"50px\", \"border\", \"0\");\r\n        $(\".custom-combobox" +
"-input\").css(\"border\", \"1\").css(\"border-bottom\", \"2px dotted\");\r\n        $(\".cus" +
"tom-combobox-input\").removeClass(\"ui-state-default\");\r\n        $(\".custom-combob" +
"ox-input\").removeClass(\"ui-button-icon-primary\");\r\n     //   $(\".ui-icon\").remov" +
"eClass(\"ui-icon ui-icon-triangle-1-s\");\r\n        $(\".ui-button\").removeClass(\"ui" +
"-button-icon-primary\");\r\n   //     $(\".ui-icon\").removeClass(\"ui-button-icon-pri" +
"mary\");\r\n        $(\".custom-combobox-input\").removeClass(\"ui-widget-content\");\r\n" +
"        $(\".custom-combobox-input\").removeClass(\"ui-widget\");\r\n        $(\".custo" +
"m-combobox-width\").removeClass(\"ui-width-default\");\r\n        $(\".custom-combobox" +
"-input\").removeClass(\"ui-corner-left\");\r\n        $(\".custom-combobox-toggle\").re" +
"moveClass(\"ui-state-default\");\r\n    });\r\n</script>\r\n");


        }
    }
}
#pragma warning restore 1591
