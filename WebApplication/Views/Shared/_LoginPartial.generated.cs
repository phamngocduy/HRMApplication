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

namespace HRM.Webpages.Views.Shared
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
    
    #line 1 "..\..\Views\Shared\_LoginPartial.cshtml"
    using HRM.Webpages.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_LoginPartial.cshtml")]
    public partial class LoginPartial : System.Web.Mvc.WebViewPage<dynamic>
    {
        public LoginPartial()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div>\r\n<div>\r\n");

            
            #line 4 "..\..\Views\Shared\_LoginPartial.cshtml"
 if (Request.IsAuthenticated)
{

            
            #line default
            #line hidden
WriteLiteral("    <a");

WriteLiteral(" id=\"splitButton\"");

WriteAttribute("href", Tuple.Create(" href=\"", 100), Tuple.Create("\"", 123)
, Tuple.Create(Tuple.Create("", 107), Tuple.Create<System.Object, System.Int32>(Href("~/Account/Manage")
, 107), false)
);

WriteLiteral(" class = \"username\" title = \"Manage\">Hello, ");

            
            #line 6 "..\..\Views\Shared\_LoginPartial.cshtml"
                                                                                      Write(User.Identity.Name);

            
            #line default
            #line hidden
WriteLiteral("!</a>\r\n");

            
            #line 7 "..\..\Views\Shared\_LoginPartial.cshtml"
}
else
{

            
            #line default
            #line hidden
WriteLiteral("    <a");

WriteLiteral(" id=\"splitButton\"");

WriteAttribute("href", Tuple.Create(" href=\"", 229), Tuple.Create("\"", 279)
, Tuple.Create(Tuple.Create("", 236), Tuple.Create<System.Object, System.Int32>(Href("~/Account/Login?ReturnUrl=")
, 236), false)
            
            #line 10 "..\..\Views\Shared\_LoginPartial.cshtml"
, Tuple.Create(Tuple.Create("", 262), Tuple.Create<System.Object, System.Int32>(Html.ReturnUrl()
            
            #line default
            #line hidden
, 262), false)
);

WriteLiteral(">Đăng nhập</a>\r\n");

            
            #line 11 "..\..\Views\Shared\_LoginPartial.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("    <button");

WriteLiteral(" id=\"select\"");

WriteLiteral(">Select an action</button>\r\n</div>\r\n<ul>\r\n");

            
            #line 15 "..\..\Views\Shared\_LoginPartial.cshtml"
 if (Request.IsAuthenticated)
{

            
            #line default
            #line hidden
WriteLiteral("    <li>\r\n        <form");

WriteAttribute("action", Tuple.Create(" action=\"", 421), Tuple.Create("\"", 446)
, Tuple.Create(Tuple.Create("", 430), Tuple.Create<System.Object, System.Int32>(Href("~/Account/Logout")
, 430), false)
);

WriteLiteral(" id=\"logoutForm\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(">\r\n            <a");

WriteLiteral(" href=\"javascript:document.getElementById(\'logoutForm\').submit()\"");

WriteLiteral("><mark><strong>Thoát</strong></mark></a>\r\n        </form>\r\n    </li>\r\n");

            
            #line 22 "..\..\Views\Shared\_LoginPartial.cshtml"
}

            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\Shared\_LoginPartial.cshtml"
  
    foreach (var theme in Themes.List)
    {
        if (theme[0].Trim().Equals(Request.Cookies["Theme"].Value))
        {

            
            #line default
            #line hidden
WriteLiteral("            <li><a");

WriteLiteral(" href=\"\"");

WriteLiteral(" class=\"theme\"");

WriteAttribute("style", Tuple.Create(" style=\"", 803), Tuple.Create("\"", 874)
, Tuple.Create(Tuple.Create("", 811), Tuple.Create("background-color:", 811), true)
            
            #line 28 "..\..\Views\Shared\_LoginPartial.cshtml"
, Tuple.Create(Tuple.Create("", 828), Tuple.Create<System.Object, System.Int32>(theme[1]
            
            #line default
            #line hidden
, 828), false)
, Tuple.Create(Tuple.Create("", 837), Tuple.Create(";color:", 837), true)
            
            #line 28 "..\..\Views\Shared\_LoginPartial.cshtml"
  , Tuple.Create(Tuple.Create("", 844), Tuple.Create<System.Object, System.Int32>(theme[2]
            
            #line default
            #line hidden
, 844), false)
, Tuple.Create(Tuple.Create("", 853), Tuple.Create(";pointer-events:none;", 853), true)
);

WriteAttribute("back", Tuple.Create(" back=\"", 875), Tuple.Create("\"", 891)
            
            #line 28 "..\..\Views\Shared\_LoginPartial.cshtml"
                                        , Tuple.Create(Tuple.Create("", 882), Tuple.Create<System.Object, System.Int32>(theme[3]
            
            #line default
            #line hidden
, 882), false)
);

WriteAttribute("fore", Tuple.Create(" fore=\"", 892), Tuple.Create("\"", 908)
            
            #line 28 "..\..\Views\Shared\_LoginPartial.cshtml"
                                                         , Tuple.Create(Tuple.Create("", 899), Tuple.Create<System.Object, System.Int32>(theme[4]
            
            #line default
            #line hidden
, 899), false)
);

WriteLiteral("><strong><u>");

            
            #line 28 "..\..\Views\Shared\_LoginPartial.cshtml"
                                                                                                                                                         Write(theme[0].Trim());

            
            #line default
            #line hidden
WriteLiteral("</u></strong></a></li>\r\n");

            
            #line 29 "..\..\Views\Shared\_LoginPartial.cshtml"
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <li><a");

WriteLiteral(" href=\"\"");

WriteLiteral(" class=\"theme\"");

WriteAttribute("style", Tuple.Create(" style=\"", 1037), Tuple.Create("\"", 1088)
, Tuple.Create(Tuple.Create("", 1045), Tuple.Create("background-color:", 1045), true)
            
            #line 32 "..\..\Views\Shared\_LoginPartial.cshtml"
, Tuple.Create(Tuple.Create("", 1062), Tuple.Create<System.Object, System.Int32>(theme[1]
            
            #line default
            #line hidden
, 1062), false)
, Tuple.Create(Tuple.Create("", 1071), Tuple.Create(";color:", 1071), true)
            
            #line 32 "..\..\Views\Shared\_LoginPartial.cshtml"
 , Tuple.Create(Tuple.Create("", 1078), Tuple.Create<System.Object, System.Int32>(theme[2]
            
            #line default
            #line hidden
, 1078), false)
, Tuple.Create(Tuple.Create("", 1087), Tuple.Create(";", 1087), true)
);

WriteAttribute("back", Tuple.Create(" back=\"", 1089), Tuple.Create("\"", 1105)
            
            #line 32 "..\..\Views\Shared\_LoginPartial.cshtml"
                   , Tuple.Create(Tuple.Create("", 1096), Tuple.Create<System.Object, System.Int32>(theme[3]
            
            #line default
            #line hidden
, 1096), false)
);

WriteAttribute("fore", Tuple.Create(" fore=\"", 1106), Tuple.Create("\"", 1122)
            
            #line 32 "..\..\Views\Shared\_LoginPartial.cshtml"
                                    , Tuple.Create(Tuple.Create("", 1113), Tuple.Create<System.Object, System.Int32>(theme[4]
            
            #line default
            #line hidden
, 1113), false)
);

WriteLiteral(">");

            
            #line 32 "..\..\Views\Shared\_LoginPartial.cshtml"
                                                                                                                          Write(theme[0].Trim());

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 33 "..\..\Views\Shared\_LoginPartial.cshtml"
        }
    }

            
            #line default
            #line hidden
WriteLiteral(@"
    </ul>
</div>
<style>
    .ui-menu { position: absolute; width: 150px; }
</style>
<script>
    $(function () {
        $("".theme"").click(function () {
            $.cookie(""Theme"", $.trim($(this).text()), { expires: 7 });
        });
        $("".theme"").hover(
            function () {
                this.prevBack = $(this).css(""background"");
                this.prevFore = $(this).css(""color"");
                $(this).css(""background"", $(this).attr(""back""));
                $(this).css(""color"", $(this).attr(""fore""));
            },
            function () {
                $(this).css(""background"", this.prevBack);
                $(this).css(""color"", this.prevFore);
            });
    });
    $(""#splitButton"")
    .button().next().button({
        text: false,
        icons: {
            primary: ""ui-icon-triangle-1-s""
        }
    }).click(function () {
        var menu = $(this).parent().next().show().position({
            my: ""left top"",
            at: ""left bottom"",
            of: this
        }).zIndex(9999);
        $(document).one(""click"", function () {
            menu.hide();
        });
        return false;
    }).parent().buttonset().next().hide().menu();
</script>
");

        }
    }
}
#pragma warning restore 1591
