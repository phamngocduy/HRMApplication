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

namespace HRM.HDLaoDong.Views.DSHDSapHetHan
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
    
    #line 2 "..\..\Views\DSHDSapHetHan\Index.cshtml"
    using HRM.Databases.Models;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\DSHDSapHetHan\Index.cshtml"
    using HRM.Databases_HDLaoDong.Models;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DSHDSapHetHan/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<IEnumerable<HRM.Databases_HDLaoDong.Models.hdChiTietHDLD>>
    {
        public Index()
        {
        }
        public override void Execute()
        {




            
            #line 4 "..\..\Views\DSHDSapHetHan\Index.cshtml"
  
    ViewBag.Title = "Index";
    var db0 = new HRM.Databases.Models.HRMDB0Entities();   


            
            #line default
            #line hidden
WriteLiteral("\r\n<b style=\"margin-left:30%;font-size:large\">Danh sách hợp đồng lao động sắp hết " +
"hạn</b>\r\n<p><br /></p>\r\n<div id=\"HDLD1\" style=\"padding: 0; width:1000px;margin-l" +
"eft:-13%;font-size:small\">\r\n<p>");


            
            #line 12 "..\..\Views\DSHDSapHetHan\Index.cshtml"
Write(Html.ActionLink("Quay lại", "Index", "HDNguoiLaoDong"));

            
            #line default
            #line hidden
WriteLiteral(@"</p>
<table id =""HDTV"">
<thead>
    <tr>
        <th style=""text-align:center"" nowrap>
            STT
        </th>
        <th style=""text-align:center"" nowrap>
            Số HĐ
        </th>
        <th style=""text-align:center"" nowrap>
            Họ và tên
        </th>
        <th style=""text-align:center"" nowrap>
            Đơn vị
        </th>
        <th style=""text-align:center"" nowrap>
            Vị trí<br />công tác
        </th>
        <th style=""text-align:center"" nowrap>
            Loại HĐ
        </th>
        <th style=""text-align:center"" nowrap>
            Thời hạn
        </th>
        <th style=""text-align:center"" nowrap>
            Ngày<br />hiệu lực
        </th>
        <th style=""text-align:center"" nowrap>
            Ngày hết<br />hiệu lực
        </th>
    </tr>
</thead>
<tbody>
");


            
            #line 46 "..\..\Views\DSHDSapHetHan\Index.cshtml"
  int count = 0;

            
            #line default
            #line hidden

            
            #line 47 "..\..\Views\DSHDSapHetHan\Index.cshtml"
 foreach (var item in Model)
{
    count = count + 1;

            
            #line default
            #line hidden
WriteLiteral("    <tr>\r\n    <td style=\"text-align: center\">\r\n    ");


            
            #line 52 "..\..\Views\DSHDSapHetHan\Index.cshtml"
Write(count);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n    <td style=\"text-align: center\" nowrap>\r\n");


            
            #line 55 "..\..\Views\DSHDSapHetHan\Index.cshtml"
     if (item.LoaiHD == "Thử việc")
    {
    
            
            #line default
            #line hidden
            
            #line 57 "..\..\Views\DSHDSapHetHan\Index.cshtml"
Write(Html.ActionLink(item.SoHD, "Details_HDThuViec", "ThemMoiHD", new { id = item.id }, null));

            
            #line default
            #line hidden
            
            #line 57 "..\..\Views\DSHDSapHetHan\Index.cshtml"
                                                                                             
    }
    else if (item.LoaiHD == "Hợp đồng cơ hữu")
    {
    
            
            #line default
            #line hidden
            
            #line 61 "..\..\Views\DSHDSapHetHan\Index.cshtml"
Write(Html.ActionLink(item.SoHD, "Details_HDCoHuu", "ThemMoiHD", new { id = item.id }, null));

            
            #line default
            #line hidden
            
            #line 61 "..\..\Views\DSHDSapHetHan\Index.cshtml"
                                                                                           
    }
    else if (item.LoaiHD == "Hợp đồng dài hạn")
    {
    
            
            #line default
            #line hidden
            
            #line 65 "..\..\Views\DSHDSapHetHan\Index.cshtml"
Write(Html.ActionLink(item.SoHD, "Details_HDDaiHan", "ThemMoiHD", new { id = item.id }, null));

            
            #line default
            #line hidden
            
            #line 65 "..\..\Views\DSHDSapHetHan\Index.cshtml"
                                                                                            
    }

            
            #line default
            #line hidden
WriteLiteral("    </td>\r\n    <td style=\"text-align: center\" nowrap>\r\n    ");


            
            #line 69 "..\..\Views\DSHDSapHetHan\Index.cshtml"
Write(Html.ActionLink(item.HotenNLD, "Index", "QTKyHDTungNguoi", new { NLD_id = item.NLD_id }, null));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n");


            
            #line 71 "..\..\Views\DSHDSapHetHan\Index.cshtml"
        string tenDonVi = "";
                if (item.Donvi_id != null)
                {
                    int? Donvi_id = item.Donvi_id;
                    tenDonVi = db0.dmDonVi.Where(dv => dv.id == Donvi_id).First().tenDonVi;
                }
            

            
            #line default
            #line hidden
WriteLiteral("    <td style=\"text-align: center\" data-tip=\"");


            
            #line 78 "..\..\Views\DSHDSapHetHan\Index.cshtml"
                                        Write(tenDonVi);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n");


            
            #line 79 "..\..\Views\DSHDSapHetHan\Index.cshtml"
        string maDonVi = "";
        if (item.Donvi_id != null)
        {
            int? Donvi_id = item.Donvi_id;
            maDonVi = db0.dmDonVi.Where(dv => dv.id == Donvi_id).First().maDonVi;
        }
        
            
            #line default
            #line hidden
            
            #line 85 "..\..\Views\DSHDSapHetHan\Index.cshtml"
   Write(Html.DisplayFor(model => maDonVi));

            
            #line default
            #line hidden
            
            #line 85 "..\..\Views\DSHDSapHetHan\Index.cshtml"
                                          
    

            
            #line default
            #line hidden
WriteLiteral("    </td>\r\n    <td style=\"text-align: center\">\r\n");


            
            #line 89 "..\..\Views\DSHDSapHetHan\Index.cshtml"
        string tenChucDanh = "";
        if (item.Chucdanh_id != null)
        {
            int? ChucDanh_id = item.Chucdanh_id;
            tenChucDanh = db0.dmChucDanhChuyenMon.Where(dv => dv.id == ChucDanh_id).First().tenChucDanhChuyenMon;
        }
        
            
            #line default
            #line hidden
            
            #line 95 "..\..\Views\DSHDSapHetHan\Index.cshtml"
   Write(Html.Raw(tenChucDanh));

            
            #line default
            #line hidden
            
            #line 95 "..\..\Views\DSHDSapHetHan\Index.cshtml"
                              
    

            
            #line default
            #line hidden
WriteLiteral("    </td>\r\n    <td style=\"text-align: center\">\r\n    ");


            
            #line 99 "..\..\Views\DSHDSapHetHan\Index.cshtml"
Write(Html.DisplayFor(model => item.LoaiHD));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n    <td style=\"text-align: center\">\r\n    ");


            
            #line 102 "..\..\Views\DSHDSapHetHan\Index.cshtml"
Write(Html.DisplayFor(model => item.dmThoiHanHD.tenThoiHanHD));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n    <td style=\"text-align: center\">\r\n    ");


            
            #line 105 "..\..\Views\DSHDSapHetHan\Index.cshtml"
Write(item.NgayHL.ToShortDateString());

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n    <td style=\"text-align: center\">\r\n");


            
            #line 108 "..\..\Views\DSHDSapHetHan\Index.cshtml"
     try{
        
            
            #line default
            #line hidden
            
            #line 109 "..\..\Views\DSHDSapHetHan\Index.cshtml"
   Write(item.NgayhetHL.Value.ToShortDateString());

            
            #line default
            #line hidden
            
            #line 109 "..\..\Views\DSHDSapHetHan\Index.cshtml"
                                                 
        }catch{
            }

            
            #line default
            #line hidden
WriteLiteral("    </td>\r\n    </tr>\r\n");


            
            #line 114 "..\..\Views\DSHDSapHetHan\Index.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral(@"</tbody>
</table>
</div>
<script>
    $(document).ready(function () {
        $(""#HDTV"").dataTable({
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