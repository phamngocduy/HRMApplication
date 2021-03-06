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

namespace HRM.Webpages.Areas.Account.Views.Login
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
    
    #line 1 "..\..\Areas\Account\Views\Login\Index.cshtml"
    using HRM.Webpages.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Account/Views/Login/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<HRM.Accounts.Models.LoginModel>
    {
        public Index()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Areas\Account\Views\Login\Index.cshtml"
  
    ViewBag.Title = "Log in HRM";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<hgroup");

WriteLiteral(" class=\"title\"");

WriteLiteral(">\r\n    <h1>Đăng nhập Hệ thống.</h1>\r\n</hgroup>\r\n\r\n<article>\r\n");

            
            #line 13 "..\..\Areas\Account\Views\Login\Index.cshtml"
 using (Html.BeginForm(new { ReturnUrl = ViewBag.ReturnUrl })) {

            
            #line default
            #line hidden
            
            #line 14 "..\..\Areas\Account\Views\Login\Index.cshtml"
Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 14 "..\..\Areas\Account\Views\Login\Index.cshtml"
                             

            
            #line default
            #line hidden
            
            #line 15 "..\..\Areas\Account\Views\Login\Index.cshtml"
Write(Html.StatusMessage());

            
            #line default
            #line hidden
            
            #line 15 "..\..\Areas\Account\Views\Login\Index.cshtml"
                     

            
            #line default
            #line hidden
WriteLiteral("<fieldset>\r\n    <legend>Log in Form</legend>\r\n    <ol>\r\n        <li>\r\n");

WriteLiteral("            ");

            
            #line 20 "..\..\Areas\Account\Views\Login\Index.cshtml"
       Write(Html.LabelFor(m => m.UserName, "Tài khoản"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 21 "..\..\Areas\Account\Views\Login\Index.cshtml"
       Write(Html.TextBoxFor(m => m.UserName));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 22 "..\..\Areas\Account\Views\Login\Index.cshtml"
       Write(Html.ValidationMessageFor(m => m.UserName));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </li>\r\n        <li>\r\n");

WriteLiteral("            ");

            
            #line 25 "..\..\Areas\Account\Views\Login\Index.cshtml"
       Write(Html.LabelFor(m => m.Password, "Mật khẩu"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 26 "..\..\Areas\Account\Views\Login\Index.cshtml"
       Write(Html.PasswordFor(m => m.Password));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 27 "..\..\Areas\Account\Views\Login\Index.cshtml"
       Write(Html.ValidationMessageFor(m => m.Password));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </li>\r\n        <li>\r\n");

WriteLiteral("            ");

            
            #line 30 "..\..\Areas\Account\Views\Login\Index.cshtml"
       Write(Html.CheckBoxFor(m => m.RememberMe));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 31 "..\..\Areas\Account\Views\Login\Index.cshtml"
       Write(Html.LabelFor(m => m.RememberMe, "Ghi nhớ?", new { @class = "checkbox" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </li>\r\n    </ol>\r\n    <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Đăng nhập\"");

WriteLiteral(" />\r\n</fieldset>\r\n");

            
            #line 36 "..\..\Areas\Account\Views\Login\Index.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("</article>\r\n\r\n<aside>\r\n    <h3>Chưa có tài khoản Đăng nhập?</h3>\r\n    <p>\r\n      " +
"  Xin vui lòng liên hệ <a");

WriteLiteral(" href=\"mailto:lehuuphuoc\"");

WriteLiteral(">Administrator</a> để tạo Tài khoản.\r\n    </p>\r\n</aside>\r\n");

        }
    }
}
#pragma warning restore 1591
