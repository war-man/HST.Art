﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
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
    
    #line 5 "..\..\Views\Shared\_Layout.cshtml"
    using HST.Art.Core;
    
    #line default
    #line hidden
    using HST.Art.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_Layout.cshtml")]
    public partial class _Views_Shared__Layout_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__Layout_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Shared\_Layout.cshtml"
  
    string action = Request.RequestContext.RouteData.GetRequiredString("Action");
    string queryName = string.IsNullOrEmpty(Request.QueryString["qtype"]) ? "" : Request.QueryString["qtype"];

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n<head>\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"renderer\"");

WriteLiteral(" content=\"webkit|ie-comp|ie-stand\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" http-equiv=\"X-UA-Compatible\"");

WriteLiteral(" content=\"IE=edge,chrome=1\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width,initial-scale=1,minimum-scale=1.0,maximum-scale=1.0," +
"user-scalable=no\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" http-equiv=\"Cache-Control\"");

WriteLiteral(" content=\"no-siteapp\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" name=\"keywords\"");

WriteLiteral(" content=\"山东省,职业教育,艺术,艺术培训,艺术指导委员会,教育,教育委员会\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" name=\"description\"");

WriteLiteral(" content=\"山东省艺术职业教育专业建设指导委员会\"");

WriteLiteral(" />\r\n    <title>");

            
            #line 17 "..\..\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n    <link");

WriteLiteral(" rel=\"Shortcut Icon\"");

WriteLiteral(" href=\"/favicon.ico\"");

WriteLiteral(" />\r\n    <!--[if lt IE 9]>\r\n    <script type=\"text/javascript\" src=\"/Content/lib/" +
"html5shiv.js\"></script>\r\n    <script type=\"text/javascript\" src=\"/Content/lib/re" +
"spond.min.js\"></script>\r\n    <![endif]-->\r\n");

WriteLiteral("    ");

            
            #line 23 "..\..\Views\Shared\_Layout.cshtml"
Write(Styles.Render("~/webclient"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 24 "..\..\Views\Shared\_Layout.cshtml"
    
            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\Shared\_Layout.cshtml"
     if (action.Equals("index", StringComparison.InvariantCultureIgnoreCase))
    {
        
            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\Shared\_Layout.cshtml"
                                      

            
            #line default
            #line hidden
WriteLiteral("        <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1221), Tuple.Create("\"", 1256)
, Tuple.Create(Tuple.Create("", 1228), Tuple.Create<System.Object, System.Int32>(Href("~/Content/css/swiper.min.css")
, 1228), false)
);

WriteLiteral(">\r\n");

WriteLiteral("        <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1290), Tuple.Create("\"", 1331)
, Tuple.Create(Tuple.Create("", 1297), Tuple.Create<System.Object, System.Int32>(Href("~/Content/css/owl.carousel.min.css")
, 1297), false)
);

WriteLiteral(">\r\n");

            
            #line 29 "..\..\Views\Shared\_Layout.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("   \r\n");

WriteLiteral("    ");

            
            #line 31 "..\..\Views\Shared\_Layout.cshtml"
Write(Scripts.Render("~/bundles/webclient"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 32 "..\..\Views\Shared\_Layout.cshtml"
Write(Scripts.Render("~/bundles/ajaxAsync"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</head>\r\n<body ");

            
            #line 34 "..\..\Views\Shared\_Layout.cshtml"
  Write(action.Equals("index", StringComparison.InvariantCultureIgnoreCase) ? "style=background:#f2f2f2" : "");

            
            #line default
            #line hidden
WriteLiteral(">\r\n    <header>\r\n        <div");

WriteLiteral(" class=\"top\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"cont top_div\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 38 "..\..\Views\Shared\_Layout.cshtml"
           Write(Html.Action("Header", "Home"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div><!--/top-->\r\n    </header>\r\n    <nav>\r\n      " +
"  <div");

WriteLiteral(" class=\"nav-logo\"");

WriteLiteral(">\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1805), Tuple.Create("\"", 1840)
            
            #line 44 "..\..\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 1812), Tuple.Create<System.Object, System.Int32>(Url.Action("Index", "Home")
            
            #line default
            #line hidden
, 1812), false)
);

WriteLiteral("><img");

WriteLiteral(" src=\"/Content/image/logo.jpg\"");

WriteLiteral(" alt=\"\"");

WriteLiteral("></a>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"nav-menu\"");

WriteLiteral(">\r\n            <span></span>\r\n            <span></span>\r\n            <span></span" +
">\r\n        </div>\r\n\r\n        <ul");

WriteLiteral(" class=\"nav-list\"");

WriteLiteral(">\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2086), Tuple.Create("\"", 2121)
            
            #line 53 "..\..\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 2093), Tuple.Create<System.Object, System.Int32>(Url.Action("Index", "Home")
            
            #line default
            #line hidden
, 2093), false)
);

WriteAttribute("class", Tuple.Create(" class=\"", 2122), Tuple.Create("\"", 2275)
            
            #line 53 "..\..\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 2130), Tuple.Create<System.Object, System.Int32>(action.Equals("index",StringComparison.InvariantCultureIgnoreCase)||action.Equals("certificate",StringComparison.InvariantCulture)?"active":""
            
            #line default
            #line hidden
, 2130), false)
);

WriteLiteral(">首页</a></li>\r\n            <li>\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2326), Tuple.Create("\"", 2360)
            
            #line 55 "..\..\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 2333), Tuple.Create<System.Object, System.Int32>(Url.Action("About","Home")
            
            #line default
            #line hidden
, 2333), false)
);

WriteAttribute("class", Tuple.Create(" class=\"", 2361), Tuple.Create("\"", 2450)
            
            #line 55 "..\..\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 2369), Tuple.Create<System.Object, System.Int32>(action.Equals("about",StringComparison.InvariantCultureIgnoreCase)?"active":""
            
            #line default
            #line hidden
, 2369), false)
);

WriteLiteral(">协会概况</a>\r\n                <ul");

WriteLiteral(" class=\"menu\"");

WriteLiteral(">\r\n                    <li");

WriteAttribute("class", Tuple.Create(" class=\"", 2520), Tuple.Create("\"", 2615)
            
            #line 57 "..\..\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 2528), Tuple.Create<System.Object, System.Int32>(queryName.Equals("Synopsis",StringComparison.InvariantCultureIgnoreCase)?"active":""
            
            #line default
            #line hidden
, 2528), false)
);

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2619), Tuple.Create("\"", 2686)
            
            #line 57 "..\..\Views\Shared\_Layout.cshtml"
                                                 , Tuple.Create(Tuple.Create("", 2626), Tuple.Create<System.Object, System.Int32>(Url.Action("About","Home", new { qtype = QSType.synopsis })
            
            #line default
            #line hidden
, 2626), false)
);

WriteLiteral(">协会简介</a></li>\r\n                    <li");

WriteAttribute("class", Tuple.Create(" class=\"", 2726), Tuple.Create("\"", 2818)
            
            #line 58 "..\..\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 2734), Tuple.Create<System.Object, System.Int32>(queryName.Equals("Frame",StringComparison.InvariantCultureIgnoreCase)?"active":""
            
            #line default
            #line hidden
, 2734), false)
);

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2822), Tuple.Create("\"", 2886)
            
            #line 58 "..\..\Views\Shared\_Layout.cshtml"
                                              , Tuple.Create(Tuple.Create("", 2829), Tuple.Create<System.Object, System.Int32>(Url.Action("About","Home", new { qtype = QSType.frame })
            
            #line default
            #line hidden
, 2829), false)
);

WriteLiteral(">组织架构</a></li>\r\n                    <li");

WriteAttribute("class", Tuple.Create(" class=\"", 2926), Tuple.Create("\"", 3159)
            
            #line 59 "..\..\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 2934), Tuple.Create<System.Object, System.Int32>(action.Equals("about",StringComparison.InvariantCultureIgnoreCase)&&(queryName.Equals("List",StringComparison.InvariantCultureIgnoreCase)||queryName.Equals("Detail",StringComparison.InvariantCultureIgnoreCase))?"active":""
            
            #line default
            #line hidden
, 2934), false)
);

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 3163), Tuple.Create("\"", 3226)
            
            #line 59 "..\..\Views\Shared\_Layout.cshtml"
                                                                                                                                                                                           , Tuple.Create(Tuple.Create("", 3170), Tuple.Create<System.Object, System.Int32>(Url.Action("About","Home", new { qtype = QSType.list })
            
            #line default
            #line hidden
, 3170), false)
);

WriteLiteral(">协会会员</a></li>\r\n                </ul>\r\n            </li>\r\n            <li>\r\n     " +
"           <a");

WriteAttribute("class", Tuple.Create(" class=\"", 3321), Tuple.Create("\"", 3413)
            
            #line 63 "..\..\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 3329), Tuple.Create<System.Object, System.Int32>(action.Equals("industry",StringComparison.InvariantCultureIgnoreCase)?"active":""
            
            #line default
            #line hidden
, 3329), false)
);

WriteAttribute("href", Tuple.Create(" href=\"", 3414), Tuple.Create("\"", 3444)
            
            #line 63 "..\..\Views\Shared\_Layout.cshtml"
                                      , Tuple.Create(Tuple.Create("", 3421), Tuple.Create<System.Object, System.Int32>(Url.Action("industry")
            
            #line default
            #line hidden
, 3421), false)
);

WriteLiteral(">行业资讯</a>\r\n");

WriteLiteral("                ");

            
            #line 64 "..\..\Views\Shared\_Layout.cshtml"
           Write(Html.Action("SecondMenu", "Home", new { sectionType = CategoryType.Industry }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </li>\r\n            <li>\r\n                <a");

WriteAttribute("class", Tuple.Create(" class=\"", 3608), Tuple.Create("\"", 3703)
            
            #line 67 "..\..\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 3616), Tuple.Create<System.Object, System.Int32>(action.Equals("association",StringComparison.InvariantCultureIgnoreCase)?"active":""
            
            #line default
            #line hidden
, 3616), false)
);

WriteAttribute("href", Tuple.Create(" href=\"", 3704), Tuple.Create("\"", 3737)
            
            #line 67 "..\..\Views\Shared\_Layout.cshtml"
                                         , Tuple.Create(Tuple.Create("", 3711), Tuple.Create<System.Object, System.Int32>(Url.Action("association")
            
            #line default
            #line hidden
, 3711), false)
);

WriteLiteral(">协会活动</a>\r\n");

WriteLiteral("                ");

            
            #line 68 "..\..\Views\Shared\_Layout.cshtml"
           Write(Html.Action("SecondMenu", "Home", new { sectionType = CategoryType.Association }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </li>\r\n            <li>\r\n                <a");

WriteAttribute("class", Tuple.Create(" class=\"", 3904), Tuple.Create("\"", 3994)
            
            #line 71 "..\..\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 3912), Tuple.Create<System.Object, System.Int32>(action.Equals("social",StringComparison.InvariantCultureIgnoreCase)?"active":""
            
            #line default
            #line hidden
, 3912), false)
);

WriteAttribute("href", Tuple.Create(" href=\"", 3995), Tuple.Create("\"", 4023)
            
            #line 71 "..\..\Views\Shared\_Layout.cshtml"
                                    , Tuple.Create(Tuple.Create("", 4002), Tuple.Create<System.Object, System.Int32>(Url.Action("social")
            
            #line default
            #line hidden
, 4002), false)
);

WriteLiteral(">社会公益</a>\r\n");

WriteLiteral("                ");

            
            #line 72 "..\..\Views\Shared\_Layout.cshtml"
           Write(Html.Action("SecondMenu", "Home", new { sectionType = CategoryType.Social }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </li>\r\n            <li>\r\n                <a");

WriteAttribute("class", Tuple.Create(" class=\"", 4185), Tuple.Create("\"", 4280)
            
            #line 75 "..\..\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 4193), Tuple.Create<System.Object, System.Int32>(action.Equals("examination",StringComparison.InvariantCultureIgnoreCase)?"active":""
            
            #line default
            #line hidden
, 4193), false)
);

WriteAttribute("href", Tuple.Create(" href=\"", 4281), Tuple.Create("\"", 4314)
            
            #line 75 "..\..\Views\Shared\_Layout.cshtml"
                                         , Tuple.Create(Tuple.Create("", 4288), Tuple.Create<System.Object, System.Int32>(Url.Action("examination")
            
            #line default
            #line hidden
, 4288), false)
);

WriteLiteral(">考级中心</a>\r\n");

WriteLiteral("                ");

            
            #line 76 "..\..\Views\Shared\_Layout.cshtml"
           Write(Html.Action("SecondMenu", "Home", new { sectionType = CategoryType.Examination }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </li>\r\n            <li>\r\n                <a");

WriteAttribute("class", Tuple.Create(" class=\"", 4481), Tuple.Create("\"", 4573)
            
            #line 79 "..\..\Views\Shared\_Layout.cshtml"
, Tuple.Create(Tuple.Create("", 4489), Tuple.Create<System.Object, System.Int32>(action.Equals("download",StringComparison.InvariantCultureIgnoreCase)?"active":""
            
            #line default
            #line hidden
, 4489), false)
);

WriteAttribute("href", Tuple.Create(" href=\"", 4574), Tuple.Create("\"", 4604)
            
            #line 79 "..\..\Views\Shared\_Layout.cshtml"
                                      , Tuple.Create(Tuple.Create("", 4581), Tuple.Create<System.Object, System.Int32>(Url.Action("download")
            
            #line default
            #line hidden
, 4581), false)
);

WriteLiteral(">下载专区</a>\r\n");

WriteLiteral("                ");

            
            #line 80 "..\..\Views\Shared\_Layout.cshtml"
           Write(Html.Action("SecondMenu", "Home", new { sectionType = CategoryType.Download }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </li>\r\n        </ul>\r\n    </nav>\r\n    <div");

WriteLiteral(" class=\"content-wrap\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 85 "..\..\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"foot\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"foot_cont\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 89 "..\..\Views\Shared\_Layout.cshtml"
       Write(Html.Action("Footer", "Home"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <footer>京ICP备13003730号-1</footer>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
        $(document).ready(function () {
            var topMain = $(""header"").height() + 15
            var nav = $(""nav"");
            $(window).scroll(function () {
                if ($(window).scrollTop() > topMain) {
                    nav.addClass(""nav_scroll"");

                } else {
                    nav.removeClass(""nav_scroll"");
                }
            });
        })

        $(document).click(function () {
            $('.nav-list').removeClass('open')
        })
        $('.nav-menu,.nav-list').click(function (e) { e.stopPropagation() })
        $('nav').find('.nav-menu').click(function (e) {
            $('.nav-list').toggleClass('open')
        })
    </script>
");

WriteLiteral("    ");

            
            #line 115 "..\..\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

            
            #line default
            #line hidden
WriteLiteral("\r\n</body>\r\n</html>\r\n");

        }
    }
}
#pragma warning restore 1591
