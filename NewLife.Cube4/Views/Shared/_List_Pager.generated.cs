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
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    using NewLife.Cube;
    using NewLife.Reflection;
    
    #line 1 "..\..\Views\Shared\_List_Pager.cshtml"
    using NewLife.Web;
    
    #line default
    #line hidden
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_List_Pager.cshtml")]
    public partial class _Views_Shared__List_Pager_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__List_Pager_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Shared\_List_Pager.cshtml"
  
    var page = ViewBag.Page as Pager;
    //page.PageUrlTemplate = page.PageUrlTemplate.Replace("{链接}", Url.Action("Index") + "{链接}");
    // 没有总记录数的时候不显示分页，可以认为不启用分页

    var act = ViewBag.Action as String;
    if (act.IsNullOrEmpty()) { act = Url.Action("Index"); }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 10 "..\..\Views\Shared\_List_Pager.cshtml"
 if (page.TotalCount > 0)
{
            
            #line default
            #line hidden
WriteLiteral("<form");

WriteAttribute("action", Tuple.Create(" action=\"", 341), Tuple.Create("\"", 390)
            
            #line 11 "..\..\Views\Shared\_List_Pager.cshtml"
, Tuple.Create(Tuple.Create("", 350), Tuple.Create<System.Object, System.Int32>(act
            
            #line default
            #line hidden
, 350), false)
, Tuple.Create(Tuple.Create("", 354), Tuple.Create("?", 354), true)
            
            #line 11 "..\..\Views\Shared\_List_Pager.cshtml"
, Tuple.Create(Tuple.Create("", 355), Tuple.Create<System.Object, System.Int32>(page.GetBaseUrl(true, true, false)
            
            #line default
            #line hidden
, 355), false)
);

WriteLiteral(" method=\"post\"");

WriteLiteral(" role=\"form\"");

WriteLiteral(">\r\n    共<span>");

            
            #line 12 "..\..\Views\Shared\_List_Pager.cshtml"
      Write(page.TotalCount.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</span>条&nbsp;\r\n    每页<span>");

            
            #line 13 "..\..\Views\Shared\_List_Pager.cshtml"
       Write(page.PageSize);

            
            #line default
            #line hidden
WriteLiteral("</span>条&nbsp;\r\n    当前第<span>");

            
            #line 14 "..\..\Views\Shared\_List_Pager.cshtml"
        Write(page.PageIndex.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</span>页/共<span>");

            
            #line 14 "..\..\Views\Shared\_List_Pager.cshtml"
                                                      Write(page.PageCount.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</span>页&nbsp;\r\n");

WriteLiteral("    ");

            
            #line 15 "..\..\Views\Shared\_List_Pager.cshtml"
Write(Html.Raw(page.GetPage("首页")));

            
            #line default
            #line hidden
WriteLiteral("&nbsp;\r\n");

WriteLiteral("    ");

            
            #line 16 "..\..\Views\Shared\_List_Pager.cshtml"
Write(Html.Raw(page.GetPage("上一页")));

            
            #line default
            #line hidden
WriteLiteral("&nbsp;\r\n");

WriteLiteral("    ");

            
            #line 17 "..\..\Views\Shared\_List_Pager.cshtml"
Write(Html.Raw(page.GetPage("下一页")));

            
            #line default
            #line hidden
WriteLiteral("&nbsp;\r\n");

WriteLiteral("    ");

            
            #line 18 "..\..\Views\Shared\_List_Pager.cshtml"
Write(Html.Raw(page.GetPage("尾页")));

            
            #line default
            #line hidden
WriteLiteral(" &nbsp;\r\n    转到第<input");

WriteLiteral(" name=\"PageIndex\"");

WriteLiteral(" type=\"text\"");

WriteAttribute("value", Tuple.Create(" value=\"", 834), Tuple.Create("\"", 857)
            
            #line 19 "..\..\Views\Shared\_List_Pager.cshtml"
, Tuple.Create(Tuple.Create("", 842), Tuple.Create<System.Object, System.Int32>(page.PageIndex
            
            #line default
            #line hidden
, 842), false)
);

WriteLiteral(" class=\"input-sm\"");

WriteLiteral(" style=\"width:40px;text-align:right;\"");

WriteLiteral(" />页\r\n    <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"GO\"");

WriteLiteral(" class=\"btn btn-deafult btn-sm\"");

WriteLiteral(" />\r\n    页大小\r\n    <select");

WriteLiteral(" id=\"PageSize\"");

WriteLiteral(" name=\"PageSize\"");

WriteLiteral(" onchange=\"$(this).parents(\'form\').submit();\"");

WriteLiteral(">\r\n        <option");

WriteLiteral(" value=\"5\"");

WriteLiteral(">5</option>\r\n        <option");

WriteLiteral(" value=\"10\"");

WriteLiteral(">10</option>\r\n        <option");

WriteLiteral(" value=\"20\"");

WriteLiteral(">20</option>\r\n        <option");

WriteLiteral(" value=\"30\"");

WriteLiteral(">30</option>\r\n        <option");

WriteLiteral(" value=\"50\"");

WriteLiteral(">50</option>\r\n        <option");

WriteLiteral(" value=\"100\"");

WriteLiteral(">100</option>\r\n    </select>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        $(function () {\r\n            $(\'#PageSize\').val(");

            
            #line 32 "..\..\Views\Shared\_List_Pager.cshtml"
                          Write(page.PageSize);

            
            #line default
            #line hidden
WriteLiteral(");\r\n        });\r\n    </script>\r\n</form>");

            
            #line 35 "..\..\Views\Shared\_List_Pager.cshtml"
              }
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
