#pragma warning disable 1591
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
    
    #line 4 "..\..\Views\Home\CertificateList.cshtml"
    using HST.Art.Web;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Home/CertificateList.cshtml")]
    public partial class _Views_Home_CertificateList_cshtml : System.Web.Mvc.WebViewPage<PageListViewModel<ListViewModel>>
    {
        public _Views_Home_CertificateList_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Home\CertificateList.cshtml"
  
    CertType ctype = ViewBag.CertType;

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 7 "..\..\Views\Home\CertificateList.cshtml"
 if (Model == null || Model.Count <= 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <p");

WriteLiteral(" class=\"not-data\"");

WriteLiteral(">暂无数据</p>\r\n");

            
            #line 10 "..\..\Views\Home\CertificateList.cshtml"
}
else
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"dataTables_wrapper\"");

WriteLiteral(">\r\n");

            
            #line 14 "..\..\Views\Home\CertificateList.cshtml"
        
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Home\CertificateList.cshtml"
         if (ctype == CertType.student)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"query_tiele\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" class=\"fl\"");

WriteLiteral(">学员证书</span>\r\n                <p");

WriteLiteral(" class=\"fr\"");

WriteLiteral("><b>");

            
            #line 18 "..\..\Views\Home\CertificateList.cshtml"
                            Write(Model.PageSize);

            
            #line default
            #line hidden
WriteLiteral(" 条数据/页</b> 总数 ");

            
            #line 18 "..\..\Views\Home\CertificateList.cshtml"
                                                         Write(Model.TotalItemCount);

            
            #line default
            #line hidden
WriteLiteral(" 条</p>\r\n            </div>\r\n");

            
            #line 20 "..\..\Views\Home\CertificateList.cshtml"


            
            #line default
            #line hidden
WriteLiteral("            <table");

WriteLiteral(" cellpadding=\"0\"");

WriteLiteral(" cellspacing=\"0\"");

WriteLiteral(">\r\n                <thead>\r\n                    <tr>\r\n                        <th" +
"");

WriteLiteral(" class=\"one\"");

WriteLiteral(">#</th>\r\n                        <th");

WriteLiteral(" style=\"width:20%;\"");

WriteLiteral(">学员姓名</th>\r\n                        <th");

WriteLiteral(" style=\"width:15%;\"");

WriteLiteral(">性别</th>\r\n                        <th");

WriteLiteral(" style=\"width:25%;\"");

WriteLiteral(">证书编号</th>\r\n                        <th");

WriteLiteral(" style=\"width:30%;\"");

WriteLiteral(">所在地区</th>\r\n                    </tr>\r\n                </thead>\r\n                " +
"<tbody>\r\n");

            
            #line 32 "..\..\Views\Home\CertificateList.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 32 "..\..\Views\Home\CertificateList.cshtml"
                     for (int i = 0; i < Model.Count; i++)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <tr>\r\n                            <td");

WriteLiteral(" class=\"one\"");

WriteLiteral(">");

            
            #line 35 "..\..\Views\Home\CertificateList.cshtml"
                                        Write(i + 1);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                            <td");

WriteLiteral(" style=\"width:20%;\"");

WriteLiteral(">");

            
            #line 36 "..\..\Views\Home\CertificateList.cshtml"
                                              Write(Model[i].Name);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                            <td");

WriteLiteral(" style=\"width:15%;\"");

WriteLiteral(">");

            
            #line 37 "..\..\Views\Home\CertificateList.cshtml"
                                              Write(Model[i].Gender);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                            <td");

WriteLiteral(" style=\"width:25%;\"");

WriteLiteral(">");

            
            #line 38 "..\..\Views\Home\CertificateList.cshtml"
                                              Write(Model[i].Number);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                            <td");

WriteLiteral(" style=\"width:30%;\"");

WriteLiteral(">");

            
            #line 39 "..\..\Views\Home\CertificateList.cshtml"
                                              Write(Model[i].Area);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        </tr>\r\n");

            
            #line 41 "..\..\Views\Home\CertificateList.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </tbody>\r\n            </table>\r\n");

            
            #line 44 "..\..\Views\Home\CertificateList.cshtml"
        }
        else if (ctype == CertType.member)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"query_tiele\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" class=\"fl\"");

WriteLiteral(">会员单位</span>\r\n                <p");

WriteLiteral(" class=\"fr\"");

WriteLiteral("><b>");

            
            #line 49 "..\..\Views\Home\CertificateList.cshtml"
                            Write(Model.PageSize);

            
            #line default
            #line hidden
WriteLiteral(" 条数据/页</b> 总数 ");

            
            #line 49 "..\..\Views\Home\CertificateList.cshtml"
                                                         Write(Model.TotalItemCount);

            
            #line default
            #line hidden
WriteLiteral(" 条</p>\r\n            </div>\r\n");

            
            #line 51 "..\..\Views\Home\CertificateList.cshtml"


            
            #line default
            #line hidden
WriteLiteral("            <table");

WriteLiteral(" cellpadding=\"0\"");

WriteLiteral(" cellspacing=\"0\"");

WriteLiteral(">\r\n                <thead>\r\n                    <tr>\r\n                        <th" +
"");

WriteLiteral(" class=\"one\"");

WriteLiteral(">#</th>\r\n                        <th");

WriteLiteral(" class=\"two\"");

WriteLiteral(">单位名称</th>\r\n                        <th");

WriteLiteral(" class=\"three\"");

WriteLiteral(">单位编号</th>\r\n                        <th");

WriteLiteral(" class=\"four\"");

WriteLiteral(">单位星级</th>\r\n                        <th");

WriteLiteral(" class=\"five\"");

WriteLiteral(">所在地区</th>\r\n                    </tr>\r\n                </thead>\r\n                " +
"<tbody>\r\n");

            
            #line 63 "..\..\Views\Home\CertificateList.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 63 "..\..\Views\Home\CertificateList.cshtml"
                     for (int i = 0; i < Model.Count; i++)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <tr>\r\n                            <td");

WriteLiteral(" class=\"one\"");

WriteLiteral(">");

            
            #line 66 "..\..\Views\Home\CertificateList.cshtml"
                                        Write(i + 1);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                            <td");

WriteLiteral(" class=\"two\"");

WriteLiteral(">");

            
            #line 67 "..\..\Views\Home\CertificateList.cshtml"
                                       Write(Model[i].Name);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                            <td");

WriteLiteral(" class=\"three\"");

WriteLiteral(">");

            
            #line 68 "..\..\Views\Home\CertificateList.cshtml"
                                         Write(Model[i].Number);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                            <td");

WriteLiteral(" class=\"four\"");

WriteLiteral(">\r\n");

            
            #line 70 "..\..\Views\Home\CertificateList.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 70 "..\..\Views\Home\CertificateList.cshtml"
                                 for (int j = 0; j < Model[i].Star; j++)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <span><img");

WriteLiteral(" src=\"/Content/image/xingxing.png\"");

WriteLiteral(" /></span>\r\n");

            
            #line 73 "..\..\Views\Home\CertificateList.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                                ");

            
            #line 74 "..\..\Views\Home\CertificateList.cshtml"
                                 for (int k = 0; k < (5 - Model[i].Star); k++)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <span><img");

WriteLiteral(" src=\"/Content/image/xingxingh.png\"");

WriteLiteral(" /></span>\r\n");

            
            #line 77 "..\..\Views\Home\CertificateList.cshtml"
                                }                                

            
            #line default
            #line hidden
WriteLiteral("                            </td>\r\n                            <td");

WriteLiteral(" class=\"five\"");

WriteLiteral(">");

            
            #line 79 "..\..\Views\Home\CertificateList.cshtml"
                                        Write(Model[i].Area);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        </tr>\r\n");

            
            #line 81 "..\..\Views\Home\CertificateList.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </tbody>\r\n            </table>\r\n");

            
            #line 84 "..\..\Views\Home\CertificateList.cshtml"
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"query_tiele\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" class=\"fl\"");

WriteLiteral(">教师证书</span>\r\n                <p");

WriteLiteral(" class=\"fr\"");

WriteLiteral("><b>");

            
            #line 89 "..\..\Views\Home\CertificateList.cshtml"
                            Write(Model.PageSize);

            
            #line default
            #line hidden
WriteLiteral(" 条数据/页</b> 总数 ");

            
            #line 89 "..\..\Views\Home\CertificateList.cshtml"
                                                         Write(Model.TotalItemCount);

            
            #line default
            #line hidden
WriteLiteral(" 条</p>\r\n            </div>\r\n");

            
            #line 91 "..\..\Views\Home\CertificateList.cshtml"


            
            #line default
            #line hidden
WriteLiteral("            <table");

WriteLiteral(" cellpadding=\"0\"");

WriteLiteral(" cellspacing=\"0\"");

WriteLiteral(">\r\n                <thead>\r\n                    <tr>\r\n                        <th" +
"");

WriteLiteral(" class=\"one\"");

WriteLiteral(">#</th>\r\n                        <th");

WriteLiteral(" style=\"width:20%;\"");

WriteLiteral(">教师姓名</th>\r\n                        <th");

WriteLiteral(" style=\"width:10%;\"");

WriteLiteral(">性别</th>\r\n                        <th");

WriteLiteral(" style=\"width:20%;\"");

WriteLiteral(">教师级别</th>\r\n                        <th");

WriteLiteral(" style=\"width:20%;\"");

WriteLiteral(">证书编号</th>\r\n                        <th");

WriteLiteral(" style=\"width:20%;\"");

WriteLiteral(">所在地区</th>\r\n                    </tr>\r\n                </thead>\r\n                " +
"<tbody>\r\n");

            
            #line 104 "..\..\Views\Home\CertificateList.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 104 "..\..\Views\Home\CertificateList.cshtml"
                     for (int i = 0; i < Model.Count; i++)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <tr>\r\n                            <td");

WriteLiteral(" class=\"one\"");

WriteLiteral(">");

            
            #line 107 "..\..\Views\Home\CertificateList.cshtml"
                                        Write(i+1);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                            <td");

WriteLiteral(" style=\"width:15%;\"");

WriteLiteral(">");

            
            #line 108 "..\..\Views\Home\CertificateList.cshtml"
                                              Write(Model[i].Name);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                            <td");

WriteLiteral(" style=\"width:10%;\"");

WriteLiteral(">");

            
            #line 109 "..\..\Views\Home\CertificateList.cshtml"
                                              Write(Model[i].Gender);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                            <td");

WriteLiteral(" style=\"width:20%;\"");

WriteLiteral(">");

            
            #line 110 "..\..\Views\Home\CertificateList.cshtml"
                                              Write(Model[i].LevelName);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                            <td");

WriteLiteral(" style=\"width:20%;\"");

WriteLiteral(">");

            
            #line 111 "..\..\Views\Home\CertificateList.cshtml"
                                              Write(Model[i].Number);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                            <td");

WriteLiteral(" style=\"width:25%;\"");

WriteLiteral(">");

            
            #line 112 "..\..\Views\Home\CertificateList.cshtml"
                                              Write(Model[i].Area);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        </tr>\r\n");

            
            #line 114 "..\..\Views\Home\CertificateList.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </tbody>\r\n            </table>\r\n");

            
            #line 117 "..\..\Views\Home\CertificateList.cshtml"


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"dataTables_paginate paging_simple_numbers\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 119 "..\..\Views\Home\CertificateList.cshtml"
           Write(Html.Page(Model.CurrentPageIndex, Model.TotalPageCount, "changePageIndex"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");

            
            #line 121 "..\..\Views\Home\CertificateList.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n");

            
            #line 123 "..\..\Views\Home\CertificateList.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
