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

namespace HRM.HDLaoDong.Views.QTKyHDTungNguoi
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
    
    #line 2 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
    using HRM.Databases.Models;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
    using HRM.Databases_HDLaoDong.Models;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/QTKyHDTungNguoi/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<IEnumerable<HRM.Databases_HDLaoDong.Models.hdChiTietHDLD>>
    {
        public Index()
        {
        }
        public override void Execute()
        {




            
            #line 4 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
  
    ViewBag.Title = "Index";
    var db0 = new HRM.Databases.Models.HRMDB0Entities();
    var db = new HRMDB2Entities();


            
            #line default
            #line hidden
WriteLiteral("<div style=\"padding: 0; width: 1000px; margin-left: -13%; font-size: small\">\r\n   " +
" <b style=\"margin-left: 40%; font-size: large\">Các hợp đồng đã ký</b>\r\n    <p st" +
"yle=\"font-size: medium\">\r\n        <b>");


            
            #line 12 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
      Write(Model.First().HotenNLD);

            
            #line default
            #line hidden
WriteLiteral("</b><a title=\"Quay lại\" href=\"~/HDLaoDong/HDNguoiLaoDong/Index\"><span\r\n          " +
"  class=\"ui-icon ui-icon-arrowreturnthick-1-w\" style=\"display: inline-block; wid" +
"th: 20px;\r\n            height: 12px\"></span></a>\r\n            ");


            
            #line 15 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
       Write(Html.ActionLink("Thêm hợp đồng", "Create_Exeption", "ThemMoiHD", new { NLD_id = Model.FirstOrDefault().NLD_id,onclick = "$(this).parents('form').first().submit();" },null));

            
            #line default
            #line hidden
WriteLiteral(@"
    </p>
    <table id=""TableQTKyHD"">
        <thead>
            <tr>
                <th style=""text-align: center"" nowrap>
                    STT
                </th>
                <th style=""text-align: center"" nowrap>
                    Số HĐ
                </th>
                <th style=""text-align: center"" nowrap>
                    Loại HĐ
                </th>
                <th style=""text-align: center"" nowrap>
                    Đơn vị
                </th>
                <th style=""text-align: center"" nowrap>
                    Chức danh<br />
                    CM
                </th>
                <th style=""text-align: center"" nowrap>
                    Thời hạn
                </th>
                <th style=""text-align: center"" nowrap>
                    Ngày hiệu<br />
                    lực
                </th>
                <th style=""text-align: center"" nowrap>
                    Ngày hết<br />
                    hiệu lực
                </th>
                <th style=""text-align: center"" nowrap>
                    PLHĐ<br />
                    đi kèm
                </th>
                <th style=""text-align: center"" nowrap>
                    Hoàn<br />
                    thành
                </th>
            </tr>
        </thead>
        <tbody>
");


            
            #line 58 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
              int count = 0;

            
            #line default
            #line hidden

            
            #line 59 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
             foreach (var item in Model)
            {
                count = count + 1;

            
            #line default
            #line hidden
WriteLiteral("                <tr>\r\n                    <td style=\"text-align: center\">\r\n      " +
"                  ");


            
            #line 64 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                   Write(count);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                    <td style=\"text-align: center\">\r" +
"\n");


            
            #line 67 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                         if (count == 1)
                        {
                            if (item.LoaiHD.ToLower() == "Thử việc".ToLower())
                            {

            
            #line default
            #line hidden
WriteLiteral("                            <span data-tip=\"HĐLĐ cuối\"><b>");


            
            #line 71 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                                                     Write(Html.ActionLink(item.SoHD, "Details_HDThuViec", "ThemMoiHD", new { id = item.id }, null));

            
            #line default
            #line hidden
WriteLiteral("</b></span>\r\n");


            
            #line 72 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                            }
                            else if (item.LoaiHD.ToLower() == "Hợp đồng cơ hữu".ToLower())
                            {

            
            #line default
            #line hidden
WriteLiteral("                            <span data-tip=\"HĐLĐ cuối\"><b>");


            
            #line 75 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                                                     Write(Html.ActionLink(item.SoHD, "Details_HDCoHuu", "ThemMoiHD", new { id = item.id }, null));

            
            #line default
            #line hidden
WriteLiteral("</b></span>\r\n");


            
            #line 76 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                            }
                            else if (item.LoaiHD.ToLower() == "Hợp đồng dài hạn".ToLower() || item.LoaiHD.ToLower() == "Hợp đồng dài hạn".ToLower())
                            {

            
            #line default
            #line hidden
WriteLiteral("                            <span data-tip=\"HĐLĐ cuối\"><b>");


            
            #line 79 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                                                     Write(Html.ActionLink(item.SoHD, "Details_HDDaiHan", "ThemMoiHD", new { id = item.id }, null));

            
            #line default
            #line hidden
WriteLiteral("</b></span>\r\n");


            
            #line 80 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                            }
                        }
                        else
                        {
                            if (item.LoaiHD == "Thử việc")
                            {
                            
            
            #line default
            #line hidden
            
            #line 86 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                       Write(Html.ActionLink(item.SoHD, "Details_HDThuViec", "ThemMoiHD", new { id = item.id }, null));

            
            #line default
            #line hidden
            
            #line 86 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                                                                                                                     
                            }
                            else if (item.LoaiHD == "Hợp đồng cơ hữu")
                            {
                            
            
            #line default
            #line hidden
            
            #line 90 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                       Write(Html.ActionLink(item.SoHD, "Details_HDCoHuu", "ThemMoiHD", new { id = item.id }, null));

            
            #line default
            #line hidden
            
            #line 90 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                                                                                                                   
                            }
                            else if (item.LoaiHD == "Hợp đồng dài hạn")
                            {
                            
            
            #line default
            #line hidden
            
            #line 94 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                       Write(Html.ActionLink(item.SoHD, "Details_HDDaiHan", "ThemMoiHD", new { id = item.id }, null));

            
            #line default
            #line hidden
            
            #line 94 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                                                                                                                    
                            }
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </td>\r\n                    <td style=\"text-align: center\">\r\n " +
"                       ");


            
            #line 99 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                   Write(Html.DisplayFor(model => item.LoaiHD));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n");


            
            #line 101 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                        string tenDonVi = "";
                        if (item.Donvi_id != null)
                        {
                            int? Donvi_id = item.Donvi_id;
                            tenDonVi = db0.dmDonVi.Where(dv => dv.id == Donvi_id).First().tenDonVi;
                        }
                    

            
            #line default
            #line hidden
WriteLiteral("                    <td style=\"text-align: center\" data-tip=\"");


            
            #line 108 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                                                        Write(tenDonVi);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n");


            
            #line 109 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                            string maDonVi = "";
                            if (item.Donvi_id != null)
                            {
                                int? Donvi_id = item.Donvi_id;
                                maDonVi = db0.dmDonVi.Where(dv => dv.id == Donvi_id).First().maDonVi;
                            }
                            
            
            #line default
            #line hidden
            
            #line 115 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                       Write(Html.DisplayFor(model => maDonVi));

            
            #line default
            #line hidden
            
            #line 115 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                                                              
                        

            
            #line default
            #line hidden
WriteLiteral("                    </td>\r\n                    <td style=\"text-align: center\">\r\n");


            
            #line 119 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                            string tenChucDanh = "";
                            if (item.Chucdanh_id != null)
                            {
                                int? ChucDanh_id = item.Chucdanh_id;
                                tenChucDanh = db0.dmChucDanhChuyenMon.Where(dv => dv.id == ChucDanh_id).First().tenChucDanhChuyenMon;
                            }
                            
            
            #line default
            #line hidden
            
            #line 125 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                       Write(Html.Raw(tenChucDanh));

            
            #line default
            #line hidden
            
            #line 125 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                                                  
                        

            
            #line default
            #line hidden
WriteLiteral("                    </td>\r\n                    <td style=\"text-align: center\">\r\n " +
"                       ");


            
            #line 129 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                   Write(Html.DisplayFor(model => item.dmThoiHanHD.tenThoiHanHD));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                    <td style=\"text-align: center\">\r" +
"\n                        ");


            
            #line 132 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                   Write(item.NgayHL.ToShortDateString());

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                    <td style=\"text-align: center\">\r" +
"\n");


            
            #line 135 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                         try
                        {
                            
            
            #line default
            #line hidden
            
            #line 137 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                       Write(item.NgayhetHL.Value.ToShortDateString());

            
            #line default
            #line hidden
            
            #line 137 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                                                                     
                        }
                        catch
                        {
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </td>\r\n");


            
            #line 143 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                      
                        int HD_id = item.id;
                        var pl1 = db.hdPhuLucHD12LuuFile.Where(pl => pl.HD_id == HD_id && pl.LoaiPL == "PLSo1");
                        var pl2 = db.hdPhuLucHD12LuuFile.Where(pl => pl.HD_id == HD_id && pl.LoaiPL == "PLSo2");
                
                    

            
            #line default
            #line hidden
WriteLiteral("                    <td style=\"text-align: center\">\r\n");


            
            #line 150 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                         if (pl1.Count() > 0)
                        {
                            
            
            #line default
            #line hidden
            
            #line 152 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                       Write(Html.Raw("PL Hơp đồng số 1, "));

            
            #line default
            #line hidden
            
            #line 152 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                                                           
                        }

            
            #line default
            #line hidden

            
            #line 154 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                         if (pl2.Count() > 0)
                        {
                            
            
            #line default
            #line hidden
            
            #line 156 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                       Write(Html.Raw("PL Hơp đồng số 2"));

            
            #line default
            #line hidden
            
            #line 156 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                                                         
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </td>\r\n                    <td style=\"text-align: center\">\r\n");


            
            #line 160 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                          
                        string status = "";
                        if (item.QT_NgayNLDky != null || (item.QT_NLDky != null && item.QT_NLDky != ""))
                        {
                            status = "NLĐ đã ký";
                            if (item.QT_NgayTrinhHT != null || (item.QT_TrinhHT != null && item.QT_TrinhHT != ""))
                            {
                                status = "Đã trình HT";
                                if (item.QT_NgayHTky != null || (item.QT_HTky != null && item.QT_HTky != ""))
                                {
                                    status = "HT đã ký";
                                    if (item.QT_NgayLuuHS != null || (item.QT_LuuHS != null && item.QT_LuuHS != ""))
                                    {
                                        status = "Đã lưu HS";
                                        if (item.QT_NgayTraNLD != null || (item.QT_TraNLD != null && item.QT_TraNLD != ""))
                                        {
                                            status = "Hoàn thành";
                                        }
                                    }
                                }
                            }
                        }
                        

            
            #line default
            #line hidden
WriteLiteral("                        ");


            
            #line 183 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
                   Write(Html.Raw(status));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");


            
            #line 186 "..\..\Views\QTKyHDTungNguoi\Index.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral(@"        </tbody>
    </table>
</div>
<script>
    $(document).ready(function () {
        $(""#TableQTKyHD"").dataTable({
            ""bAutoWidth"": false,
            ""bStateSave"": true,
            ""aLengthMenu"": [[10, 25, 50, -1], [10, 25, 50, ""All""]]
        });
    });
</script>
");


        }
    }
}
#pragma warning restore 1591
