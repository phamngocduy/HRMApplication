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

namespace HRM.QLBHXH.Views.DanhSachDieuChinhChucDanh
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
    
    #line 2 "..\..\Views\DanhSachDieuChinhChucDanh\Index2.cshtml"
    using HRM.Webpages.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DanhSachDieuChinhChucDanh/Index2.cshtml")]
    public partial class Index2 : System.Web.Mvc.WebViewPage<IEnumerable<HRM.QLBHXH.Models.v_ChucDanh>>
    {
        public Index2()
        {
        }
        public override void Execute()
        {



            
            #line 3 "..\..\Views\DanhSachDieuChinhChucDanh\Index2.cshtml"
  
    ViewBag.Title = "Index";
    string ngayBD = ViewBag.NgayBD;
    string ngayKT = ViewBag.NgayKT;
    string Dot = ViewBag.Dot;
    int idmoi = ViewBag.idmoi;
    //int Thang = ViewBag.Thang;


            
            #line default
            #line hidden

            
            #line 11 "..\..\Views\DanhSachDieuChinhChucDanh\Index2.cshtml"
Write(Html.StatusMessage(TempData["Message"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div>\r\n    <a style=\"text-align: right\" title=\"Trở lại danh sách NV BHXH\" oncli" +
"ck=\"location.href=\'");


            
            #line 13 "..\..\Views\DanhSachDieuChinhChucDanh\Index2.cshtml"
                                                                                      Write(Url.Action("index2", "NhanVienBHXH"));

            
            #line default
            #line hidden
WriteLiteral("\'\">\r\n        <span class=\"ui-icon     \r\nui-icon-arrowreturnthick-1-w \" style=\"dis" +
"play: inline-block\" /></a>Đợt của tháng:<input  name=\"From\" title=\"Từ ngày\" id=\"" +
"txt1\" value=");


            
            #line 15 "..\..\Views\DanhSachDieuChinhChucDanh\Index2.cshtml"
                                                                                                                                Write(Dot);

            
            #line default
            #line hidden
WriteLiteral("  />\r\n    <input type=\"button\" value=\"Lọc\" id=\"btnLoc\" />\r\n    ");



WriteLiteral(@"
    <input type=""button"" value=""Thêm điều chỉnh chức danh"" id=""btncreate"" />
    <a style=""text-align: right"" title=""Đóng"" class='btnclose'><span class=""ui-icon ui-icon-closethick""
        style=""display: inline-block"" /></a>
</div>
<div id=""edit"">
</div>
<div id=""create"">
</div>
<div id=""delete"">
</div>
<table id=""dieuchinhCD"">
    <thead>
        <tr>
            <th style=""text-align: center"" nowrap>
                Mới nhất
            </th>
            <th style=""text-align: center"" nowrap>
                Họ và tên
            </th>
            <th style=""text-align: center"" nowrap>
                Chức vụ cũ
            </th>
            <th style=""text-align: center"" nowrap>
                Chức vụ mới
            </th>
            <th style=""text-align: center"" nowrap>
                Từ tháng năm
            </th>
            <th style=""text-align: center"" nowrap>
                Đến tháng năm
            </th>
            <th style=""text-align: center"" nowrap>
                Ghi chú
            </th>
            <th style=""text-align: center"" nowrap>
            </th>
        </tr>
    </thead>
    <tbody>
");


            
            #line 57 "..\..\Views\DanhSachDieuChinhChucDanh\Index2.cshtml"
         foreach (var item in Model)
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <td style=\"text-align: left\" nowrap>\r\n         " +
"           ");


            
            #line 61 "..\..\Views\DanhSachDieuChinhChucDanh\Index2.cshtml"
               Write(Html.DisplayFor(modelItem => item.MoiNhat));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align: left\" nowrap>\r\n  " +
"                  ");


            
            #line 64 "..\..\Views\DanhSachDieuChinhChucDanh\Index2.cshtml"
               Write(Html.DisplayFor(modelItem => item.HoVaTen));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align: center\" nowrap>\r\n" +
"                    ");


            
            #line 67 "..\..\Views\DanhSachDieuChinhChucDanh\Index2.cshtml"
               Write(Html.DisplayFor(modelItem => item.CVCu));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align: left\" nowrap>\r\n  " +
"                  ");


            
            #line 70 "..\..\Views\DanhSachDieuChinhChucDanh\Index2.cshtml"
               Write(Html.DisplayFor(modelItem => item.CVMoi));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align: left\" nowrap>\r\n  " +
"                  ");


            
            #line 73 "..\..\Views\DanhSachDieuChinhChucDanh\Index2.cshtml"
               Write(item.TuThangNam.ToString("MM/yyyy"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align: center\" nowrap>\r\n" +
"");


            
            #line 76 "..\..\Views\DanhSachDieuChinhChucDanh\Index2.cshtml"
                     if (@item.DenThangNam != null)
                    {
                        
            
            #line default
            #line hidden
            
            #line 78 "..\..\Views\DanhSachDieuChinhChucDanh\Index2.cshtml"
                   Write(item.DenThangNam.Value.ToString("MM/yyyy"));

            
            #line default
            #line hidden
            
            #line 78 "..\..\Views\DanhSachDieuChinhChucDanh\Index2.cshtml"
                                                                   
                    }

            
            #line default
            #line hidden
WriteLiteral("                </td>\r\n                <td style=\"text-align: left\" nowrap>\r\n    " +
"                ");


            
            #line 82 "..\..\Views\DanhSachDieuChinhChucDanh\Index2.cshtml"
               Write(Html.DisplayFor(modelItem => item.GhiChu));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align: center\" nowrap>\r\n" +
"                    <a data-val1=\"");


            
            #line 85 "..\..\Views\DanhSachDieuChinhChucDanh\Index2.cshtml"
                             Write(item.id);

            
            #line default
            #line hidden
WriteLiteral("\" title=\"Xóa\" class=\'btnxoa\'><span class=\"ui-icon ui-icon-trash\"\r\n               " +
"         style=\"display: inline-block\" /></a><a data-val1=\"");


            
            #line 86 "..\..\Views\DanhSachDieuChinhChucDanh\Index2.cshtml"
                                                                     Write(item.id);

            
            #line default
            #line hidden
WriteLiteral("\" title=\"Sửa\" class=\'btnedit\'>\r\n                            <span class=\"ui-icon " +
"ui-icon-pencil\" style=\"display: inline-block\" /></a>\r\n                </td>\r\n   " +
"         </tr>\r\n");


            
            #line 90 "..\..\Views\DanhSachDieuChinhChucDanh\Index2.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </tbody>\r\n</table>\r\n");



WriteLiteral(@"
<script src=""/Scripts/datatables/FixedColumns.js""></script>
<script>

    // Script cho bảng
    $(document).ready(function () {
        var oTable = $('#dieuchinhCD').dataTable({
            ""bJQueryUI"": true,
            ""sScrollY"": ""100%"",
            ""sScrollX"": ""100%""
            ,
      
            ""aoColumnDefs"": [
  { ""bSortable"": false, ""aTargets"": [1, 2, 3, 4, 5, 6,7] }
]
 , ""aaSorting"": [[0, ""desc""]]
                      ,
        ""aoColumns"": [ { ""bVisible"": false },null,null,null,null,null,null,null ]
                      ,
            ""fnRowCallback"": function (nRow, aData, iDisplayIndex) {

                if (aData[0] == ");


            
            #line 114 "..\..\Views\DanhSachDieuChinhChucDanh\Index2.cshtml"
                           Write(idmoi);

            
            #line default
            #line hidden
WriteLiteral(") {\r\n                    $(nRow).css(\'background-color\', \'#FFFFCC\');\r\n           " +
"           $(nRow).css(  \'border\', \'1px solid #999\');\r\n                }\r\n      " +
"      }\r\n        });\r\n\r\n        new $.fn.dataTable.FixedColumns(oTable, {\r\n     " +
"       \"iLeftColumns\": 1,\r\n            \"iRightColumns\": 1\r\n        })\r\n    });\r\n" +
"\r\n\r\n    //hide nut dong tat ca cac the div\r\n    $(\".btnclose\").hide();\r\n    //la" +
"y create view cho vao the div create\r\n    $.get(\"../DanhSachDieuChinhChucDanh/Cr" +
"eate\").success(function (data) {\r\n        $(\'#create\').html(data);\r\n    });\r\n   " +
" //chuyen div create thanh tab\r\n    $(\"#create\").tabs();\r\n        $(\"#delete\").t" +
"abs();\r\n        $(\"#edit\").tabs();\r\n\r\n    //ban nut create div create truot xuon" +
"g\r\n    $(\"#btncreate\").click(function () {\r\n   $(\".btnclose\").show(); \r\n        " +
"$(\"#create\").slideToggle(\"medium\");\r\n          $(\"#delete\").slideUp(\"medium\");\r\n" +
"             $(\"#edit\").slideUp(\"medium\");\r\n       $(\'html, body\').animate({ scr" +
"ollTop: 0 }, \'slow\');\r\n  \r\n    });\r\n    //xu ly nut xoa\r\n     $(\"#btnclose\").hid" +
"e();\r\n      $(function () {\r\n        $(\'.btnxoa\').click(function () {\r\n         " +
"   var Val1 = $(this).attr(\"data-val1\");\r\n            //goi delete view len tab\r" +
"\n               $(\".btnclose\").show(); \r\n            $.get(\"../DanhSachDieuChinh" +
"ChucDanh/delete?id=\" + Val1).success(function (data) {\r\n                $(\'#dele" +
"te\').html(data);\r\n                  $(\"#delete\").slideDown(\"medium\");\r\n         " +
"         $(\"#create\").slideUp(\"medium\");\r\n      \r\n       \r\n             $(\'html," +
" body\').animate({ scrollTop: 0 }, \'slow\');\r\n            });\r\n        });\r\n    })" +
";\r\n\r\n\r\n    //xy ly nut edit\r\n          $(function () {\r\n        $(\'.btnedit\').cl" +
"ick(function () {\r\n            var Val1 = $(this).attr(\"data-val1\");\r\n          " +
"  //goi delete view len tab\r\n               $(\".btnclose\").show(); \r\n           " +
" $.get(\"../DanhSachDieuChinhChucDanh/edit?id=\" + Val1).success(function (data) {" +
"\r\n                $(\'#edit\').html(data);\r\n                  $(\"#create\").slideUp" +
"(\"medium\");\r\n        $(\"#delete\").slideUp(\"medium\");\r\n          $(\"#edit\").slide" +
"Down(\"medium\");\r\n       \r\n             $(\'html, body\').animate({ scrollTop: 0 }," +
" \'slow\');\r\n            });\r\n        });\r\n    });\r\n\r\n           //xu li nut close" +
"\r\n    $(function () {\r\n        $(\'.btnclose\').click(function () {\r\n        //an " +
"nut close\r\n            $(\".btnclose\").hide();\r\n            //dong tat ca cac tab" +
"\r\n            $(\"#edit\").slideUp(\"medium\");\r\n            $(\"#delete\").slideUp(\"m" +
"edium\");\r\n             $(\"#create\").slideUp(\"medium\");\r\n            \r\n\r\n        " +
"});\r\n    });\r\n\r\n\r\n       //xu li nut filter\r\n          $(\"#btnLoc\").click(functi" +
"on () {\r\n           var txtVal = $(\"#txt1\").val();\r\n    \r\n            window.loc" +
"ation = \"");


            
            #line 203 "..\..\Views\DanhSachDieuChinhChucDanh\Index2.cshtml"
                          Write(Url.Action("Index2", "DanhSachDieuChinhChucDanh"));

            
            #line default
            #line hidden
WriteLiteral(@""" +""?BD="" + txtVal;
        }); 



        
    //datetime picker CHI CO THANG VA NAM
  $(""#txt1"").datepicker( {
        changeMonth: true,
        changeYear: true,
        showButtonPanel: true
        ,
        dateFormat: 'MM yy',
      
                 onClose: function(dateText, inst) {
      var month = $(""#ui-datepicker-div .ui-datepicker-month :selected"").val();
      var year = $(""#ui-datepicker-div .ui-datepicker-year :selected"").val();
      $(this).val($.datepicker.formatDate('mm/yy', new Date(year, month, 1)));
 
    }

});

$(""#txt1"").focus(function () {
  $("".ui-datepicker-calendar"").hide();
  $(""#ui-datepicker-div"").position({
    my: ""center top"",
    at: ""center bottom"",
    of: $(this)
  });
});

</script>
<style type=""text/css"">
    #create, #delete, #edit
    {
        display: none;
    }
    
    input#txt1
    {
        width: 100px;
    }
    input#txt2
    {
        width: 100px;
    }
</style>
");


        }
    }
}
#pragma warning restore 1591
