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

namespace HRM.QLTTNhanSu.Views.ChungChi
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
    
    #line 1 "..\..\Views\ChungChi\Index.cshtml"
    using HRM.Webpages.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ChungChi/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<HRM.Databases.Models.ChungChi>
    {
        public Index()
        {
        }
        public override void Execute()
        {



            
            #line 3 "..\..\Views\ChungChi\Index.cshtml"
  
    var db = ViewBag.DB as HRM.Databases.Models.HRMDBEntities;
   
            
            #line default
            #line hidden

            
            #line 5 "..\..\Views\ChungChi\Index.cshtml"
                                                                             
    var ChungChi = db.NhanViens.All.Find(Model.NV_id).ChungChis.Where(n => n.SauKhiVeTruong != true).ToList();
    var ChungChiSau = db.NhanViens.All.Find(Model.NV_id).ChungChis.Where(n => n.SauKhiVeTruong == true).ToList();


            
            #line default
            #line hidden
WriteLiteral(@"
<h3 class=""ignore"">Chứng Chỉ</h3>
<div style=""overflow:auto;"">
<table id=""ChungChi"">
<tr>

    <th nowrap>&nbsp;Tên chứng chỉ</th>
    <th nowrap>&nbsp;Điểm/Xếp loại</th>
    <th nowrap>&nbsp;Ngày cấp</th>
    <th nowrap>&nbsp;Nơi cấp</th>      
    <th nowrap>&nbsp;Hiệu lực</th>
    <th nowrap>&nbsp;Ghi chú</th>
</tr>
<tbody>
<tr>
<td colspan=15 nowrap>
 Trước khi về trường
</tr>
");


            
            #line 27 "..\..\Views\ChungChi\Index.cshtml"
 foreach (var item in ChungChi)
{
    var prefix = "item" + item.GetHashCode();

            
            #line default
            #line hidden
WriteLiteral("<tr>\r\n");


            
            #line 31 "..\..\Views\ChungChi\Index.cshtml"
 using (Html.BeginForm("Update", "ChungChi"))
{

    
            
            #line default
            #line hidden
            
            #line 34 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.Hidden("Prefix", prefix));

            
            #line default
            #line hidden
            
            #line 34 "..\..\Views\ChungChi\Index.cshtml"
                                  
    
            
            #line default
            #line hidden
            
            #line 35 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.Hidden("CC_id", item.id));

            
            #line default
            #line hidden
            
            #line 35 "..\..\Views\ChungChi\Index.cshtml"
                                  
    ViewData.TemplateInfo.HtmlFieldPrefix = prefix;
  

            
            #line default
            #line hidden
WriteLiteral("<td>\r\n    ");


            
            #line 39 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.DropDownListFor(model => item.LoaiChungChi_id, new SelectList(db.dmLoaiChungChi, "id", "tenLoaiChungChi", item.LoaiChungChi_id), String.Empty));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n    ");


            
            #line 40 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.ValidationMessageFor(model => item.LoaiChungChi_id));

            
            #line default
            #line hidden
WriteLiteral("\r\n</td>\r\n");



WriteLiteral("<td>\r\n    ");


            
            #line 43 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.EditorFor(model => item.Capdo));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n    ");


            
            #line 44 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.ValidationMessageFor(model => item.Capdo));

            
            #line default
            #line hidden
WriteLiteral("\r\n</td>\r\n");



WriteLiteral("<td>\r\n    ");


            
            #line 47 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.EditorFor(model => item.NgayCap));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n    ");


            
            #line 48 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.ValidationMessageFor(model => item.NgayCap));

            
            #line default
            #line hidden
WriteLiteral("\r\n</td>\r\n");



WriteLiteral("<td>\r\n    ");


            
            #line 51 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.EditorFor(model => item.NoiCap));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n    ");


            
            #line 52 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.ValidationMessageFor(model => item.NoiCap));

            
            #line default
            #line hidden
WriteLiteral("\r\n</td>\r\n");



WriteLiteral("<td>\r\n    ");


            
            #line 55 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.EditorFor(model => item.HieuLuc));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n    ");


            
            #line 56 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.ValidationMessageFor(model => item.HieuLuc));

            
            #line default
            #line hidden
WriteLiteral("\r\n</td>\r\n");



WriteLiteral("<td>\r\n    ");


            
            #line 59 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.EditorFor(model => item.GhiChu));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n    ");


            
            #line 60 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.ValidationMessageFor(model => item.GhiChu));

            
            #line default
            #line hidden
WriteLiteral("\r\n</td>\r\n");



WriteLiteral(@"<td nowrap>
    <input type=""submit"" style=""position:absolute;left:-9999px"" />
    <a title=""Sửa"" onclick=""$(this).hide().parents('tr').find('a,input,select').prop('disabled',false).prop('hidden',false)""><span class=""ui-icon ui-icon-pencil"" style=""display:inline-block""/></a>
    <a title=""Nhấn Enter để Lưu"" onclick=""$(this).parents('tr').find('form').submit()"" hidden><span class=""ui-icon ui-icon-disk"" style=""display:inline-block""/></a>
    <a title=""Xóa"" href=""~/QLTTNhanSu/ChungChi/Delete/");


            
            #line 66 "..\..\Views\ChungChi\Index.cshtml"
                                                 Write(item.id);

            
            #line default
            #line hidden
WriteLiteral("\" onclick=\"return confirm(\'Bạn có muốn xóa ");


            
            #line 66 "..\..\Views\ChungChi\Index.cshtml"
                                                                                                    Write(item.LoaiChungChi_id);

            
            #line default
            #line hidden
WriteLiteral(" ");


            
            #line 66 "..\..\Views\ChungChi\Index.cshtml"
                                                                                                                          Write(item.Capdo);

            
            #line default
            #line hidden
WriteLiteral(" cấp ngày ");


            
            #line 66 "..\..\Views\ChungChi\Index.cshtml"
                                                                                                                                               Write(item.NgayCap);

            
            #line default
            #line hidden
WriteLiteral("?\')\"><span class=\"ui-icon ui-icon-trash\" style=\"display:inline-block\"/></a>\r\n</td" +
">\r\n");


            
            #line 68 "..\..\Views\ChungChi\Index.cshtml"
    ViewData.TemplateInfo.HtmlFieldPrefix = null;
}

            
            #line default
            #line hidden
WriteLiteral("</tr>\r\n");


            
            #line 71 "..\..\Views\ChungChi\Index.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("<tr>\r\n");


            
            #line 73 "..\..\Views\ChungChi\Index.cshtml"
 using (Html.BeginForm("Update" , "ChungChi"))
{
    var prefix ="model" + Model.GetHashCode();
    
            
            #line default
            #line hidden
            
            #line 76 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.Hidden("Prefix", prefix));

            
            #line default
            #line hidden
            
            #line 76 "..\..\Views\ChungChi\Index.cshtml"
                                  
    ViewData.TemplateInfo.HtmlFieldPrefix = prefix;
    
            
            #line default
            #line hidden
            
            #line 78 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.HiddenFor(model => model.NV_id));

            
            #line default
            #line hidden
            
            #line 78 "..\..\Views\ChungChi\Index.cshtml"
                                         
        Model.SauKhiVeTruong = false;
    
            
            #line default
            #line hidden
            
            #line 80 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.HiddenFor(model => model.SauKhiVeTruong));

            
            #line default
            #line hidden
            
            #line 80 "..\..\Views\ChungChi\Index.cshtml"
                                                  


            
            #line default
            #line hidden
WriteLiteral("<td>\r\n    ");


            
            #line 83 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.DropDownListFor(model => model.LoaiChungChi_id, new SelectList(db.dmLoaiChungChi, "id", "tenLoaiChungChi", Model.LoaiChungChi_id), String.Empty));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n    ");


            
            #line 84 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.ValidationMessageFor(model => model.LoaiChungChi_id));

            
            #line default
            #line hidden
WriteLiteral("\r\n</td>\r\n");



WriteLiteral("<td>\r\n    ");


            
            #line 87 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.EditorFor(model => model.Capdo));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n    ");


            
            #line 88 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.ValidationMessageFor(model => model.Capdo));

            
            #line default
            #line hidden
WriteLiteral("\r\n</td>\r\n");



WriteLiteral("<td>\r\n    ");


            
            #line 91 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.EditorFor(model => model.NgayCap));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n    ");


            
            #line 92 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.ValidationMessageFor(model => model.NgayCap));

            
            #line default
            #line hidden
WriteLiteral("\r\n</td>\r\n");



WriteLiteral("<td>\r\n    ");


            
            #line 95 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.EditorFor(model => model.NoiCap));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n    ");


            
            #line 96 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.ValidationMessageFor(model => model.NoiCap));

            
            #line default
            #line hidden
WriteLiteral("\r\n</td>\r\n");



WriteLiteral("<td>\r\n    ");


            
            #line 99 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.EditorFor(model => model.HieuLuc));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n    ");


            
            #line 100 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.ValidationMessageFor(model => model.HieuLuc));

            
            #line default
            #line hidden
WriteLiteral("\r\n</td>\r\n");



WriteLiteral("<td>\r\n    ");


            
            #line 103 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.EditorFor(model => model.GhiChu));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n    ");


            
            #line 104 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.ValidationMessageFor(model => model.GhiChu));

            
            #line default
            #line hidden
WriteLiteral("\r\n</td>\r\n");



WriteLiteral(@"<td nowrap>
    <input type=""submit"" style=""position:absolute;left:-9999px"" />
    <a title=""Thêm, Nhấn Enter để Lưu"" onclick=""$(this).parents('tr').find('form').submit()""><span class=""ui-icon ui-icon-circle-plus"" style=""display:inline-block""/></a>
</td>
");


            
            #line 110 "..\..\Views\ChungChi\Index.cshtml"
        ViewData.TemplateInfo.HtmlFieldPrefix = null;
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<tr>\r\n<td colspan=18 nowrap>\r\n\r\n<a href=\"~/QLTTNhanSu/nvQTHocTap/QTChungChi\" st" +
"yle=\"color:blue\"> Sau khi về trường </a>\r\n</tr>\r\n");


            
            #line 118 "..\..\Views\ChungChi\Index.cshtml"
 foreach (var item in ChungChiSau)
{
    var prefix = "item" + item.GetHashCode();

            
            #line default
            #line hidden
WriteLiteral("<tr>\r\n");


            
            #line 122 "..\..\Views\ChungChi\Index.cshtml"
 using (Html.BeginForm("Update", "ChungChi"))
{
    
            
            #line default
            #line hidden
            
            #line 124 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.Hidden("Prefix", prefix));

            
            #line default
            #line hidden
            
            #line 124 "..\..\Views\ChungChi\Index.cshtml"
                                  
    
            
            #line default
            #line hidden
            
            #line 125 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.Hidden("CC_id", item.id));

            
            #line default
            #line hidden
            
            #line 125 "..\..\Views\ChungChi\Index.cshtml"
                                  
    ViewData.TemplateInfo.HtmlFieldPrefix = prefix;

            
            #line default
            #line hidden
WriteLiteral("<td>\r\n    ");


            
            #line 128 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.DropDownListFor(model => item.LoaiChungChi_id, new SelectList(db.dmLoaiChungChi, "id", "tenLoaiChungChi", item.LoaiChungChi_id), String.Empty));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n    ");


            
            #line 129 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.ValidationMessageFor(model => item.LoaiChungChi_id));

            
            #line default
            #line hidden
WriteLiteral("\r\n</td>\r\n");



WriteLiteral("<td>\r\n    ");


            
            #line 132 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.EditorFor(model => item.Capdo));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n    ");


            
            #line 133 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.ValidationMessageFor(model => item.Capdo));

            
            #line default
            #line hidden
WriteLiteral("\r\n</td>\r\n");



WriteLiteral("<td>\r\n    ");


            
            #line 136 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.EditorFor(model => item.NgayCap));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n    ");


            
            #line 137 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.ValidationMessageFor(model => item.NgayCap));

            
            #line default
            #line hidden
WriteLiteral("\r\n</td>\r\n");



WriteLiteral("<td>\r\n    ");


            
            #line 140 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.EditorFor(model => item.NoiCap));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n    ");


            
            #line 141 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.ValidationMessageFor(model => item.NoiCap));

            
            #line default
            #line hidden
WriteLiteral("\r\n</td>\r\n");



WriteLiteral("<td>\r\n    ");


            
            #line 144 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.EditorFor(model => item.HieuLuc));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n    ");


            
            #line 145 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.ValidationMessageFor(model => item.HieuLuc));

            
            #line default
            #line hidden
WriteLiteral("\r\n</td>\r\n");



WriteLiteral("<td>\r\n    ");


            
            #line 148 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.EditorFor(model => item.GhiChu));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n    ");


            
            #line 149 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.ValidationMessageFor(model => item.GhiChu));

            
            #line default
            #line hidden
WriteLiteral("\r\n</td>\r\n");



WriteLiteral(@"<td nowrap>
    <input type=""submit"" style=""position:absolute;left:-9999px"" />
    <a title=""Sửa"" onclick=""$(this).hide().parents('tr').find('a,input,select').prop('disabled',false).prop('hidden',false)""><span class=""ui-icon ui-icon-pencil"" style=""display:inline-block""/></a>
    <a title=""Nhấn Enter để Lưu"" onclick=""$(this).parents('tr').find('form').submit()"" hidden><span class=""ui-icon ui-icon-disk"" style=""display:inline-block""/></a>
    <a title=""Xóa"" href=""~/QLTTNhanSu/ChungChi/Delete/");


            
            #line 155 "..\..\Views\ChungChi\Index.cshtml"
                                                 Write(item.id);

            
            #line default
            #line hidden
WriteLiteral("\" onclick=\"return confirm(\'Bạn có muốn xóa ");


            
            #line 155 "..\..\Views\ChungChi\Index.cshtml"
                                                                                                    Write(item.LoaiChungChi_id);

            
            #line default
            #line hidden
WriteLiteral(" ");


            
            #line 155 "..\..\Views\ChungChi\Index.cshtml"
                                                                                                                          Write(item.Capdo);

            
            #line default
            #line hidden
WriteLiteral(" cấp ngày ");


            
            #line 155 "..\..\Views\ChungChi\Index.cshtml"
                                                                                                                                               Write(item.NgayCap);

            
            #line default
            #line hidden
WriteLiteral("?\')\"><span class=\"ui-icon ui-icon-trash\" style=\"display:inline-block\"/></a>\r\n</td" +
">\r\n");


            
            #line 157 "..\..\Views\ChungChi\Index.cshtml"
    ViewData.TemplateInfo.HtmlFieldPrefix = null;
}

            
            #line default
            #line hidden
WriteLiteral("</tr>\r\n");


            
            #line 160 "..\..\Views\ChungChi\Index.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("<tr>\r\n");


            
            #line 162 "..\..\Views\ChungChi\Index.cshtml"
 using (Html.BeginForm("Update", "ChungChi"))
{
    var prefix = "model" + Model.GetHashCode();
    
            
            #line default
            #line hidden
            
            #line 165 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.Hidden("Prefix", prefix));

            
            #line default
            #line hidden
            
            #line 165 "..\..\Views\ChungChi\Index.cshtml"
                                  
    ViewData.TemplateInfo.HtmlFieldPrefix = prefix;
    
            
            #line default
            #line hidden
            
            #line 167 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.HiddenFor(model => model.NV_id));

            
            #line default
            #line hidden
            
            #line 167 "..\..\Views\ChungChi\Index.cshtml"
                                         
       Model.SauKhiVeTruong = true;
    
            
            #line default
            #line hidden
            
            #line 169 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.HiddenFor(model => model.SauKhiVeTruong));

            
            #line default
            #line hidden
            
            #line 169 "..\..\Views\ChungChi\Index.cshtml"
                                                  

            
            #line default
            #line hidden
WriteLiteral("<td>\r\n    ");


            
            #line 171 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.DropDownListFor(model => model.LoaiChungChi_id, new SelectList(db.dmLoaiChungChi, "id", "tenLoaiChungChi", Model.LoaiChungChi_id), String.Empty));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n    ");


            
            #line 172 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.ValidationMessageFor(model => model.LoaiChungChi_id));

            
            #line default
            #line hidden
WriteLiteral("\r\n</td>\r\n");



WriteLiteral("<td>\r\n    ");


            
            #line 175 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.EditorFor(model => model.Capdo));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n    ");


            
            #line 176 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.ValidationMessageFor(model => model.Capdo));

            
            #line default
            #line hidden
WriteLiteral("\r\n</td>\r\n");



WriteLiteral("<td>\r\n    ");


            
            #line 179 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.EditorFor(model => model.NgayCap));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n    ");


            
            #line 180 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.ValidationMessageFor(model => model.NgayCap));

            
            #line default
            #line hidden
WriteLiteral("\r\n</td>\r\n");



WriteLiteral("<td>\r\n    ");


            
            #line 183 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.EditorFor(model => model.NoiCap));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n    ");


            
            #line 184 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.ValidationMessageFor(model => model.NoiCap));

            
            #line default
            #line hidden
WriteLiteral("\r\n</td>\r\n");



WriteLiteral("<td>\r\n    ");


            
            #line 187 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.EditorFor(model => model.HieuLuc));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n    ");


            
            #line 188 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.ValidationMessageFor(model => model.HieuLuc));

            
            #line default
            #line hidden
WriteLiteral("\r\n</td>\r\n");



WriteLiteral("<td>\r\n    ");


            
            #line 191 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.EditorFor(model => model.GhiChu));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n    ");


            
            #line 192 "..\..\Views\ChungChi\Index.cshtml"
Write(Html.ValidationMessageFor(model => model.GhiChu));

            
            #line default
            #line hidden
WriteLiteral("\r\n</td>\r\n");



WriteLiteral(@"<td nowrap>
    <input type=""submit"" style=""position:absolute;left:-9999px"" />
    <a title=""Thêm, Nhấn Enter để Lưu"" onclick=""$(this).parents('tr').find('form').submit()""><span class=""ui-icon ui-icon-circle-plus"" style=""display:inline-block""/></a>
</td>
");


            
            #line 198 "..\..\Views\ChungChi\Index.cshtml"
    ViewData.TemplateInfo.HtmlFieldPrefix = null;
}

            
            #line default
            #line hidden
WriteLiteral(@"</tr>
</table>
</div>
</tbody>
<style>
td { padding: 0 2px 0 0 }
input { margin: 0 0 0 0 }
</style>

<script>
    $(function () {
        var $table = $(""#ChungChi"");
        $table.find(""[id^=item]"").prop(""disabled"", true);
        $table.find(""input[type=datetime]"").datepicker({ changeMonth: true, changeYear: true }).css(""width"", ""80px"");
        $table.find(""input,select"").css(""border"", ""0"").css(""border-bottom"", ""1px dotted"");
        $table.find(""input[type=text]"").on(""input"", function () {
            $(this).attr(""size"", $(this).val().length + 1);
        }).each(function () {
            $(this).css(""width"", ""auto"")
                   .attr(""size"", $(this).val().length + 1);
        });
       
    });
</script>");


        }
    }
}
#pragma warning restore 1591
