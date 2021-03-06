﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRM.QLTTNhanSu.Views.nvQTHocTap
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
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\nvQTHocTap\Canhan.cshtml"
    using HRM.Webpages.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/nvQTHocTap/Canhan.cshtml")]
    public partial class Canhan : System.Web.Mvc.WebViewPage<HRM.Databases.Models.nvQTHocTap>
    {
        public Canhan()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\nvQTHocTap\Canhan.cshtml"
  
    
    var db = ViewBag.DB as HRM.Databases.Models.HRMDBEntities;
    var nvqthoctap = db.NhanViens.All.Find(Model.NV_id).nvQTHocTaps.Where(n => n.Xoa != true && n.NV_id==Model.NV_id);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 9 "..\..\Views\nvQTHocTap\Canhan.cshtml"
Write(Html.StatusMessage(TempData["Message"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 10 "..\..\Views\nvQTHocTap\Canhan.cshtml"
Write(Html.ValidationSummary(TempData["ModelState"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" style=\"overflow:auto\"");

WriteLiteral(">\r\n<table");

WriteLiteral(" id=\"QTHocTap\"");

WriteLiteral(@">
<thead>
    <tr>
        <th>BC/CC</th>
        <th>Tên trường</th>
        <th>Bằng cấp</th>
        <th>Chuyên ngành</th>
        <th>Hình thức học</th>
        <th>Nơi học</th>
        <th>Khóa học</th>
        <th>LD đào tạo</th>
        <th>Bắt đầu</th>
        <th>Dự kiến</th>
        <th>Két thúc</th>
        <th>Kết quả</th>
        <th>Xếp loại TN</th>
        <th>Chi phí</th>
        <th>Hỗ trợ</th>
        <th>Số QĐ</th>
        <th>Ngày QĐ</th>
        <th>Cam kết</th>
        <th>Thưởng</th>
        <th>Điều chỉnh lương</th>
        <th>Nộp chứng nhận</th>
        <th>Nộp bằng</th>
        <th>Cấp bằng</th>
        <th>Hiện trạng</th>
        <th>Ghi chú</th>
        <th></th>
    </tr>
</thead>
<tbody>
");

            
            #line 44 "..\..\Views\nvQTHocTap\Canhan.cshtml"
 foreach (var item in nvqthoctap)
{
    

            
            #line default
            #line hidden
WriteLiteral("    <tr>\r\n");

            
            #line 48 "..\..\Views\nvQTHocTap\Canhan.cshtml"
    
            
            #line default
            #line hidden
            
            #line 48 "..\..\Views\nvQTHocTap\Canhan.cshtml"
     using (Html.BeginForm("Update", "nvQTHocTap"))
{
        var prefix = "item" + item.GetHashCode();
    
            
            #line default
            #line hidden
            
            #line 51 "..\..\Views\nvQTHocTap\Canhan.cshtml"
Write(Html.Hidden("Prefix", prefix));

            
            #line default
            #line hidden
            
            #line 51 "..\..\Views\nvQTHocTap\Canhan.cshtml"
                                  
    
            
            #line default
            #line hidden
            
            #line 52 "..\..\Views\nvQTHocTap\Canhan.cshtml"
Write(Html.Hidden("HT_id", item.id));

            
            #line default
            #line hidden
            
            #line 52 "..\..\Views\nvQTHocTap\Canhan.cshtml"
                                  
     
            
            #line default
            #line hidden
            
            #line 53 "..\..\Views\nvQTHocTap\Canhan.cshtml"
Write(Html.Hidden("true", item.HienThi));

            
            #line default
            #line hidden
            
            #line 53 "..\..\Views\nvQTHocTap\Canhan.cshtml"
                                       
        ViewData.TemplateInfo.HtmlFieldPrefix = prefix;

            
            #line default
            #line hidden
WriteLiteral("        <td>");

            
            #line 55 "..\..\Views\nvQTHocTap\Canhan.cshtml"
       Write(Html.DropDownListFor(model => item.LoaiHocTap_id, new SelectList(db.dmLoaiHocTap, "id", "tenloaihoctap")));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("        <td>");

            
            #line 56 "..\..\Views\nvQTHocTap\Canhan.cshtml"
       Write(Html.EditorFor(model => item.TenTruong));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("        <td>");

            
            #line 57 "..\..\Views\nvQTHocTap\Canhan.cshtml"
       Write(Html.DropDownListFor(model => item.LoaiBangCap_id, new SelectList(db.dmLoaiBangCap, "id", "tenloaibangcap")));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("        <td>");

            
            #line 58 "..\..\Views\nvQTHocTap\Canhan.cshtml"
       Write(Html.DropDownListFor(model => item.ChuyenNganh_id, new SelectList(db.dmChuyenNganh, "id", "tenchuyennganh")));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("        <td>");

            
            #line 59 "..\..\Views\nvQTHocTap\Canhan.cshtml"
       Write(Html.DropDownListFor(model => item.NoiHoc_id, new SelectList(db.dmNoiHoc, "id", "tennoihoc")));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("        <td>");

            
            #line 60 "..\..\Views\nvQTHocTap\Canhan.cshtml"
       Write(Html.DropDownListFor(model => item.QuocGia_id, new SelectList(db.dmQuocGia, "id", "tenquocgia")));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("        <td>");

            
            #line 61 "..\..\Views\nvQTHocTap\Canhan.cshtml"
       Write(Html.DropDownListFor(model => item.LoaiKhoaHoc_id, new SelectList(db.dmLoaiKhoaHoc, "id", "tenloaikhoahoc")));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("        <td>");

            
            #line 62 "..\..\Views\nvQTHocTap\Canhan.cshtml"
       Write(Html.DropDownListFor(model => item.LoaiHinhDaoTao_id, new SelectList(db.dmLoaiHinhDaoTao, "id", "tenloaihinhdaotao")));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("        <td>");

            
            #line 63 "..\..\Views\nvQTHocTap\Canhan.cshtml"
       Write(Html.EditorFor(model => item.BatDau));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("        <td>");

            
            #line 64 "..\..\Views\nvQTHocTap\Canhan.cshtml"
       Write(Html.EditorFor(model => item.KetThucDuKien));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("        <td>");

            
            #line 65 "..\..\Views\nvQTHocTap\Canhan.cshtml"
       Write(Html.EditorFor(model => item.KetThucChinhThuc));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("        <td>");

            
            #line 66 "..\..\Views\nvQTHocTap\Canhan.cshtml"
       Write(Html.EditorFor(model => item.KetQua));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("        <td>");

            
            #line 67 "..\..\Views\nvQTHocTap\Canhan.cshtml"
       Write(Html.DropDownListFor(model => item.XepLoaiTotNghiep_id, new SelectList(db.dmXepLoaiTotNghiep, "id", "tenloaitotnghiep")));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("        <td>");

            
            #line 68 "..\..\Views\nvQTHocTap\Canhan.cshtml"
       Write(Html.EditorFor(model => item.ChiPhiDaoTao));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("        <td>");

            
            #line 69 "..\..\Views\nvQTHocTap\Canhan.cshtml"
       Write(Html.EditorFor(model => item.KinhPhiHoTro));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("        <td>");

            
            #line 70 "..\..\Views\nvQTHocTap\Canhan.cshtml"
       Write(Html.EditorFor(model => item.SoQuyetDinh));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("        <td>");

            
            #line 71 "..\..\Views\nvQTHocTap\Canhan.cshtml"
       Write(Html.EditorFor(model => item.NgayCapQuyetDinh));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("        <td>");

            
            #line 72 "..\..\Views\nvQTHocTap\Canhan.cshtml"
       Write(Html.EditorFor(model => item.CamKet));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("        <td>");

            
            #line 73 "..\..\Views\nvQTHocTap\Canhan.cshtml"
       Write(Html.EditorFor(model => item.ThuongHoanThanh));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("        <td>");

            
            #line 74 "..\..\Views\nvQTHocTap\Canhan.cshtml"
       Write(Html.EditorFor(model => item.NgayDieuChinhLuong));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("        <td>");

            
            #line 75 "..\..\Views\nvQTHocTap\Canhan.cshtml"
       Write(Html.EditorFor(model => item.NgayNopChungNhanHoanThanh));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("        <td>");

            
            #line 76 "..\..\Views\nvQTHocTap\Canhan.cshtml"
       Write(Html.EditorFor(model => item.NgayNopBang));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("        <td>");

            
            #line 77 "..\..\Views\nvQTHocTap\Canhan.cshtml"
       Write(Html.EditorFor(model => item.NgayCapBang));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("        <td>");

            
            #line 78 "..\..\Views\nvQTHocTap\Canhan.cshtml"
       Write(Html.DropDownListFor(model => item.HienTrang_id, new SelectList(db.dmHienTrangDiHoc, "id", "tenhientrang")));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("        <td>");

            
            #line 79 "..\..\Views\nvQTHocTap\Canhan.cshtml"
       Write(Html.EditorFor(model => item.GhiChu));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

WriteLiteral("        <td>         \r\n           <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Update\"");

WriteLiteral(" style=\"position:absolute;left:-9999px\"");

WriteLiteral(" />\r\n    <a");

WriteLiteral(" title=\"Sửa\"");

WriteLiteral(" onclick=\"$(this).hide().parents(\'tr\').find(\'a,input,select\').prop(\'disabled\',fal" +
"se).prop(\'hidden\',false)\"");

WriteLiteral("><span");

WriteLiteral(" class=\"ui-icon ui-icon-pencil\"");

WriteLiteral(" style=\"display:inline-block\"");

WriteLiteral("/></a>\r\n    <a");

WriteLiteral(" title=\"Nhấn Enter để Lưu\"");

WriteLiteral(" onclick=\"$(this).parents(\'tr\').find(\'form\').submit()\"");

WriteLiteral(" hidden><span");

WriteLiteral(" class=\"ui-icon ui-icon-disk\"");

WriteLiteral(" style=\"display:inline-block\"");

WriteLiteral("/></a>\r\n            <a");

WriteLiteral(" title=\"Xóa\"");

WriteAttribute("href", Tuple.Create(" href=\"", 4136), Tuple.Create("\"", 4182)
, Tuple.Create(Tuple.Create("", 4143), Tuple.Create<System.Object, System.Int32>(Href("~/QLTTNhanSu/nvQTHocTap/Delete/")
, 4143), false)
            
            #line 84 "..\..\Views\nvQTHocTap\Canhan.cshtml"
, Tuple.Create(Tuple.Create("", 4174), Tuple.Create<System.Object, System.Int32>(item.id
            
            #line default
            #line hidden
, 4174), false)
);

WriteLiteral(" onclick=\"return confirm(\'Bạn có muốn xóa quá trình học tập này?\')\"");

WriteLiteral("><span");

WriteLiteral(" class=\"ui-icon ui-icon-trash\"");

WriteLiteral(" style=\"display:inline-block\"");

WriteLiteral("/></a>\r\n        </td>\r\n");

            
            #line 86 "..\..\Views\nvQTHocTap\Canhan.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("    </tr>\r\n");

            
            #line 88 "..\..\Views\nvQTHocTap\Canhan.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n</tbody>\r\n</table>\r\n</div>\r\n<style>\r\ntd { padding: 0 0 0 0 }\r\ninput { margin: 0" +
" 0 0 0 }\r\n</style>\r\n<script>\r\n    $(document).ready(function () {\r\n     //   $(\"" +
"#QTHocTap\").dataTable();\r\n    });\r\n</script>");

        }
    }
}
#pragma warning restore 1591
