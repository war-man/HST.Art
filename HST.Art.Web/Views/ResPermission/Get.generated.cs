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
    using cncbk_resource;
    
    #line 1 "..\..\Views\ResPermission\Get.cshtml"
    using cncbk_resource.Common;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\ResPermission\Get.cshtml"
    using cncbk_resource.Models;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\ResPermission\Get.cshtml"
    using Newtonsoft.Json;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ResPermission/Get.cshtml")]
    public partial class _Views_ResPermission_Get_cshtml : System.Web.Mvc.WebViewPage<PageListViewModel<ResourceViewModel>>
    {
        public _Views_ResPermission_Get_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\ResPermission\Get.cshtml"
  int num = 1; 
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<table");

WriteLiteral(" id=\"tbTable\"");

WriteLiteral(" class=\"table table-border table-bordered table-bg table-sort dataTable no-footer" +
"\"");

WriteLiteral(">\r\n    <thead>\r\n        <tr");

WriteLiteral(" class=\"text-c\"");

WriteLiteral(">\r\n            <th");

WriteLiteral(" width=\"8%\"");

WriteLiteral(">序号</th>\r\n            <th");

WriteLiteral(" width=\"18%\"");

WriteLiteral(">标题</th>\r\n            <th");

WriteLiteral(" width=\"11%\"");

WriteLiteral(">所属资料包</th>\r\n");

            
            #line 13 "..\..\Views\ResPermission\Get.cshtml"
            
            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\ResPermission\Get.cshtml"
             foreach (KeyValueViewModel item in ViewBag.memberTypes)
            {

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" width=\"10%\"");

WriteLiteral(">");

            
            #line 15 "..\..\Views\ResPermission\Get.cshtml"
                           Write(item.Value);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n");

            
            #line 16 "..\..\Views\ResPermission\Get.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <th");

WriteLiteral(" width=\"13%\"");

WriteLiteral(">管理</th>\r\n        </tr>\r\n    </thead>\r\n\r\n    <tbody>\r\n");

            
            #line 22 "..\..\Views\ResPermission\Get.cshtml"
        
            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\ResPermission\Get.cshtml"
         foreach (var m in Model)
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr");

WriteLiteral(" class=\"text-c\"");

WriteAttribute("id", Tuple.Create(" id=\"", 716), Tuple.Create("\"", 734)
, Tuple.Create(Tuple.Create("", 721), Tuple.Create("tb_tr_", 721), true)
            
            #line 24 "..\..\Views\ResPermission\Get.cshtml"
, Tuple.Create(Tuple.Create("", 727), Tuple.Create<System.Object, System.Int32>(m.Id
            
            #line default
            #line hidden
, 727), false)
);

WriteLiteral(">\r\n                <td>");

            
            #line 25 "..\..\Views\ResPermission\Get.cshtml"
                Write((Model.CurrentPageIndex - 1)*Model.PageSize + num);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 26 "..\..\Views\ResPermission\Get.cshtml"
               Write(m.Title);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 27 "..\..\Views\ResPermission\Get.cshtml"
               Write(m.PackageName);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 28 "..\..\Views\ResPermission\Get.cshtml"
                
            
            #line default
            #line hidden
            
            #line 28 "..\..\Views\ResPermission\Get.cshtml"
                 foreach (KeyValueViewModel item in ViewBag.memberTypes)
                {
                    MemberTypeViewModel mtvm = m.MemberTypes.Where(g => g.Id == item.Key).FirstOrDefault();


            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" data-id=\"tb_td_");

            
            #line 32 "..\..\Views\ResPermission\Get.cshtml"
                                  Write(m.Id);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-bind=\"");

            
            #line 32 "..\..\Views\ResPermission\Get.cshtml"
                                                    Write(item.Key);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n                        <select");

WriteLiteral(" class=\"selectpicker form-control\"");

WriteLiteral(" multiple");

WriteLiteral(" title=\"请选择权限\"");

WriteLiteral(" data-live-search=\"false\"");

WriteLiteral(" data-selected-text-format=\"count > 4\"");

WriteLiteral(">\r\n");

            
            #line 34 "..\..\Views\ResPermission\Get.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 34 "..\..\Views\ResPermission\Get.cshtml"
                             foreach (KeyValueViewModel per in ViewBag.permissions)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <option");

WriteAttribute("value", Tuple.Create(" value=\"", 1476), Tuple.Create("\"", 1492)
            
            #line 36 "..\..\Views\ResPermission\Get.cshtml"
, Tuple.Create(Tuple.Create("", 1484), Tuple.Create<System.Object, System.Int32>(per.Key
            
            #line default
            #line hidden
, 1484), false)
);

WriteLiteral(" ");

            
            #line 36 "..\..\Views\ResPermission\Get.cshtml"
                                                     Write(mtvm!=null&&mtvm.ResPermissionIds.Contains(per.Key)?"selected":"");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 36 "..\..\Views\ResPermission\Get.cshtml"
                                                                                                                         Write(per.Value);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");

            
            #line 37 "..\..\Views\ResPermission\Get.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </select>\r\n                    </td>\r\n");

            
            #line 40 "..\..\Views\ResPermission\Get.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"td-manage\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteAttribute("onclick", Tuple.Create("  onclick=\"", 1784), Tuple.Create("\"", 1810)
, Tuple.Create(Tuple.Create("", 1795), Tuple.Create("res_save(", 1795), true)
            
            #line 42 "..\..\Views\ResPermission\Get.cshtml"
, Tuple.Create(Tuple.Create("", 1804), Tuple.Create<System.Object, System.Int32>(m.Id
            
            #line default
            #line hidden
, 1804), false)
, Tuple.Create(Tuple.Create("", 1809), Tuple.Create(")", 1809), true)
);

WriteLiteral(" title=\"保存\"");

WriteLiteral(">保存</a>\r\n                    <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 1879), Tuple.Create("\"", 1948)
, Tuple.Create(Tuple.Create("", 1889), Tuple.Create("res_detail(\'资料查看\',\'", 1889), true)
            
            #line 43 "..\..\Views\ResPermission\Get.cshtml"
, Tuple.Create(Tuple.Create("", 1908), Tuple.Create<System.Object, System.Int32>(Url.Action("Detail","Resource")
            
            #line default
            #line hidden
, 1908), false)
, Tuple.Create(Tuple.Create("", 1940), Tuple.Create("\',", 1940), true)
            
            #line 43 "..\..\Views\ResPermission\Get.cshtml"
                               , Tuple.Create(Tuple.Create("", 1942), Tuple.Create<System.Object, System.Int32>(m.Id
            
            #line default
            #line hidden
, 1942), false)
, Tuple.Create(Tuple.Create("", 1947), Tuple.Create(")", 1947), true)
);

WriteLiteral(" title=\"查看\"");

WriteLiteral(">查看</a>\r\n                </td>\r\n            </tr>\r\n");

            
            #line 46 "..\..\Views\ResPermission\Get.cshtml"
            num++;
        }

            
            #line default
            #line hidden
WriteLiteral("    </tbody>\r\n</table>\r\n<div");

WriteLiteral(" class=\"dataTables_info\"");

WriteLiteral(">\r\n    <span");

WriteLiteral(" class=\"pagesStyle\"");

WriteLiteral(">总共<span");

WriteLiteral(" class=\"recordsStyle\"");

WriteLiteral(">");

            
            #line 51 "..\..\Views\ResPermission\Get.cshtml"
                                                     Write(Model.TotalItemCount);

            
            #line default
            #line hidden
WriteLiteral(" 条,计 ");

            
            #line 51 "..\..\Views\ResPermission\Get.cshtml"
                                                                               Write(Model.TotalPageCount);

            
            #line default
            #line hidden
WriteLiteral(" </span>页，当前显示 ");

            
            #line 51 "..\..\Views\ResPermission\Get.cshtml"
                                                                                                                   Write(Model.StartRecordIndex);

            
            #line default
            #line hidden
WriteLiteral(" - ");

            
            #line 51 "..\..\Views\ResPermission\Get.cshtml"
                                                                                                                                             Write(Model.EndRecordIndex);

            
            #line default
            #line hidden
WriteLiteral(" 条记录 </span>\r\n</div>\r\n<div");

WriteLiteral(" class=\"dataTables_paginate paging_simple_numbers\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 54 "..\..\Views\ResPermission\Get.cshtml"
Write(Html.Page(Model.CurrentPageIndex, Model.TotalPageCount, "changePageIndex"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>");

        }
    }
}
#pragma warning restore 1591
