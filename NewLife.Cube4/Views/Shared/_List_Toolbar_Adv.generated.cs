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
    
    #line 1 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
    using NewLife.Common;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_List_Toolbar_Adv.cshtml")]
    public partial class _Views_Shared__List_Toolbar_Adv_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__List_Toolbar_Adv_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
  
    //var user = ViewBag.User as IUser ?? User.Identity as IUser;

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"btn-group\"");

WriteLiteral(">\r\n    <button");

WriteLiteral(" data-toggle=\"dropdown\"");

WriteLiteral(" class=\"btn btn-info btn-sm btn-sm-force dropdown-toggle\"");

WriteLiteral(" aria-expanded=\"false\"");

WriteLiteral(">\r\n        高级\r\n        <span");

WriteLiteral(" class=\"ace-icon fa fa-caret-down icon-on-right\"");

WriteLiteral("></span>\r\n    </button>\r\n\r\n    <ul");

WriteLiteral(" class=\"dropdown-menu dropdown-info dropdown-menu-right\"");

WriteLiteral(">\r\n        <li>\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 433), Tuple.Create("\"", 466)
            
            #line 13 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
, Tuple.Create(Tuple.Create("", 440), Tuple.Create<System.Object, System.Int32>(Url.Action("ExportExcel")
            
            #line default
            #line hidden
, 440), false)
);

WriteLiteral(">导出Excel</a>\r\n        </li>\r\n        <li>\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 524), Tuple.Create("\"", 555)
            
            #line 16 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
, Tuple.Create(Tuple.Create("", 531), Tuple.Create<System.Object, System.Int32>(Url.Action("ExportXml")
            
            #line default
            #line hidden
, 531), false)
);

WriteLiteral(">导出Xml</a>\r\n        </li>\r\n        ");

WriteLiteral("\r\n        <li>\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 710), Tuple.Create("\"", 742)
            
            #line 22 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
, Tuple.Create(Tuple.Create("", 717), Tuple.Create<System.Object, System.Int32>(Url.Action("ExportJson")
            
            #line default
            #line hidden
, 717), false)
);

WriteLiteral(">导出Json</a>\r\n        </li>\r\n        ");

WriteLiteral("\r\n");

            
            #line 27 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
        
            
            #line default
            #line hidden
            
            #line 27 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
         if (SysConfig.Current.Develop && User.IsInRole("管理员"))
        {

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"divider\"");

WriteLiteral("></li>\r\n");

WriteLiteral("            <li>\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1023), Tuple.Create("\"", 1050)
            
            #line 31 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
, Tuple.Create(Tuple.Create("", 1030), Tuple.Create<System.Object, System.Int32>(Url.Action("Clear")
            
            #line default
            #line hidden
, 1030), false)
);

WriteLiteral(" onclick=\"return confirm(\'该操作将删除数据表所有数据并不可恢复！\\n确认清空？\');\"");

WriteLiteral(">清空数据表</a>\r\n            </li>\r\n");

            
            #line 33 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 34 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
         if (SysConfig.Current.Develop)
        {

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"divider\"");

WriteLiteral("></li>\r\n");

WriteLiteral("            <li>\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1276), Tuple.Create("\"", 1306)
            
            #line 38 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
, Tuple.Create(Tuple.Create("", 1283), Tuple.Create<System.Object, System.Int32>(Url.Action("MakeList")
            
            #line default
            #line hidden
, 1283), false)
);

WriteLiteral(">生成列表</a>\r\n            </li>\r\n");

WriteLiteral("            <li>\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1373), Tuple.Create("\"", 1403)
            
            #line 41 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
, Tuple.Create(Tuple.Create("", 1380), Tuple.Create<System.Object, System.Int32>(Url.Action("MakeForm")
            
            #line default
            #line hidden
, 1380), false)
);

WriteLiteral(">生成表单</a>\r\n            </li>\r\n");

            
            #line 43 "..\..\Views\Shared\_List_Toolbar_Adv.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\r\n</div><!-- /.btn-group -->");

        }
    }
}
#pragma warning restore 1591
