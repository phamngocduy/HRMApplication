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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/NhanVienBHXH/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<dynamic>
    {
        public Index()
        {
        }
        public override void Execute()
        {


WriteLiteral("\r\nstyle=\"-webkit-transform: translate(0%, 0%) translateZ(0px); cursor: pointer; -" +
"webkit-transition: 500ms ease; transition: 500ms ease;\"\r\n<!-- Apply blue theme a" +
"s default for all tiles, but use the tiles class to allow the theme to be swappe" +
"d -->\r\n<div class=\"tiles blue tile-group four-wide\" >\r\n    <!-- Sliding Tile tha" +
"t shows 100% of the back tile every 3 seconds -->\r\n    <div class=\"live-tile\" da" +
"ta-speed=\"750\" data-delay=\"3000\" data-bounce=\"true\">\r\n        <span class=\"tile-" +
"title\">slide tile</span>\r\n        <div><img src=\"http://localhost:59714/Scripts/" +
"MetroJs/images/all-new-htc-one-m8-wallpaper-6.jpg\" /></div>\r\n        <div> KHÔNG" +
" ĐƯỢC XÓA HOẶC ĐẶT LẠI TÊN TRONG CÁC SHEET TẠI FILE NÀY, NẾU KHÔNG CÓ DỮ LIỆU TH" +
"Ì KHÔNG CẦN NHẬP!</div>\r\n            </div>\r\n    <!-- Red Flip Tile that flips e" +
"very 4 seconds -->\r\n    <div class=\"red live-tile\" data-mode=\"flip\" data-delay=\"" +
"4000\">            \r\n        <div>\r\n            <img src=\"http://localhost:59714/" +
"Scripts/MetroJs/images/1554526_10152069233959007_331941023901514954_n.jpg\" alt=\"" +
"3\" />\r\n         \r\n            <span class=\"tile-title\">flip tile front</span>\r\n " +
"       </div>\r\n        <div>\r\n            <img src=\"http://localhost:59714/Scrip" +
"ts/MetroJs/images/all-new-htc-one-m8-wallpaper-6.jpg\" alt=\"4\"  />\r\n         \r\n  " +
"          <span class=\"tile-title\">flip tile back</span>\r\n        </div>\r\n    </" +
"div>\r\n    <!-- Carousel Tile that slides 4 tile faces every 2.5 seconds -->\r\n   " +
" <div class=\"live-tile\" data-mode=\"carousel\" data-direction=\"horizontal\" data-de" +
"lay=\"2500\">\r\n        <div>\r\n            <img src=\"http://localhost:59714/Scripts" +
"/MetroJs/images/1979213_10152135107863999_905420545_o.jpg\"  alt=\"1\"/>\r\n         " +
"  \r\n           \r\n            <span class=\"tile-title\">carousel slide 1</span>\r\n " +
"       </div>\r\n        <div>\r\n            <img class=\"full\" src=\"/images/sample/" +
"2t.gif\" alt=\"2\" />\r\n            <span class=\"tile-title accent\">carousel slide 2" +
"</span>\r\n        </div>\r\n        <div>\r\n            <img class=\"full\" src=\"/imag" +
"es/sample/3tw.gif\" alt=\"3\" />\r\n            <span class=\"tile-title\">carousel sli" +
"de 3</span>\r\n        </div>\r\n        <div>\r\n            <img class=\"full\" src=\"/" +
"images/sample/4t.gif\" alt=\"4\" />\r\n            <span class=\"tile-title accent\">ca" +
"rousel slide 4</span>\r\n        </div>\r\n    </div>\r\n    <!-- Mango Flip List that" +
" triggers every 3 seconds -->\r\n    <div class=\"list-tile mango\">\r\n        <span " +
"class=\"tile-title\">flip list</span>\r\n        <ul class=\"flip-list fourTiles\" dat" +
"a-mode=\"flip-list\" data-delay=\"2000\">\r\n            <li>\r\n            \r\n         " +
"       <div><img src=\"http://localhost:59714/Scripts/MetroJs/images/all-new-htc-" +
"one-m8-wallpaper-6.jpg\" alt=\"1\" /></div>\r\n                <div>keroro</div>\r\n   " +
"         </li>\r\n            <li>\r\n                <div><img src=\"http://localhos" +
"t:59714/Scripts/MetroJs/images/all-new-htc-one-m8-wallpaper-6.jpg\" alt=\"2\" /></d" +
"iv>\r\n                <div>nghia</div>\r\n            </li>\r\n            <li>\r\n    " +
"            <div><img src=\"http://localhost:59714/Scripts/MetroJs/images/all-new" +
"-htc-one-m8-wallpaper-6.jpg\" alt=\"3\" /></div>\r\n                <div>le</div>\r\n  " +
"          </li>\r\n            <li data-direction=\"horizontal\">\r\n                <" +
"div><img src=\"http://localhost:59714/Scripts/MetroJs/images/all-new-htc-one-m8-w" +
"allpaper-6.jpg\" alt=\"4\" /></div>\r\n                <div>sims team</div>\r\n        " +
"    </li>\r\n        </ul>\r\n    </div>\r\n    <!-- Green Static Tile -->\r\n    <div c" +
"lass=\"live-tile accent green exclude\">\r\n        <span class=\"tile-title\">static " +
"tile</span>\r\n        <p>Static tiles can take advantage of theming too!</p>\r\n   " +
" </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n<!-- Activate live tiles -->\r\n<script type=\"text/java" +
"script\">\r\n    // apply regular slide universally unless .exclude class is applie" +
"d \r\n    // NOTE: The default options for each liveTile are being pulled from the" +
" \'data-\' attributes\r\n    $(\".live-tile, .flip-list\").not(\".exclude\").liveTile()." +
"click(function () {\r\n        \r\n\r\n         window.location = \"");


            
            #line 321 "..\..\Views\NhanVienBHXH\Index.cshtml"
                       Write(Url.Action("Index2", "NhanVienBHXH"));

            
            #line default
            #line hidden
WriteLiteral("\" ;\r\n    }); ;\r\n \r\n\r\n</script>\r\n<script src=\"http://localhost:59714/Scripts/Metro" +
"Js/MetroJs.min.js\" type=\"text/javascript\"></script>\r\n<script src=\"http://localho" +
"st:59714/Scripts/MetroJs/MetroJs.js\" type=\"text/javascript\"></script>\r\n");


        }
    }
}
#pragma warning restore 1591