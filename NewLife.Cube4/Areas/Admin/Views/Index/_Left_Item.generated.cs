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
    
    #line 1 "..\..\Areas\Admin\Views\Index\_Left_Item.cshtml"
    using NewLife.Model;
    
    #line default
    #line hidden
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    
    #line 2 "..\..\Areas\Admin\Views\Index\_Left_Item.cshtml"
    using XCode.Membership;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/Index/_Left_Item.cshtml")]
    public partial class _Areas_Admin_Views_Index__Left_Item_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Admin_Views_Index__Left_Item_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Areas\Admin\Views\Index\_Left_Item.cshtml"
  
    var user = ViewBag.User as IUser ?? User.Identity as IUser;

    var fact = ObjectContainer.Current.Resolve<IMenuFactory>();

    var item = Model as IMenu;
    var childs = fact.GetMySubMenus(item.ID).Where(m => m.Visible);
    var url = item.Url.IsNullOrEmpty() ? "" : Url.Content(item.Url);

            
            #line default
            #line hidden
WriteLiteral("\r\n<li>\r\n");

            
            #line 13 "..\..\Areas\Admin\Views\Index\_Left_Item.cshtml"
    
            
            #line default
            #line hidden
            
            #line 13 "..\..\Areas\Admin\Views\Index\_Left_Item.cshtml"
     if (childs.Any())
    {

            
            #line default
            #line hidden
WriteLiteral("        <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"dropdown-toggle\"");

WriteLiteral(">\r\n            <i");

WriteLiteral(" class=\"menu-icon fa fa-caret-right\"");

WriteLiteral("></i>\r\n");

WriteLiteral("            ");

            
            #line 17 "..\..\Areas\Admin\Views\Index\_Left_Item.cshtml"
       Write(item.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("\r\n        </a>\r\n");

            
            #line 19 "..\..\Areas\Admin\Views\Index\_Left_Item.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 580), Tuple.Create("\"", 591)
            
            #line 22 "..\..\Areas\Admin\Views\Index\_Left_Item.cshtml"
, Tuple.Create(Tuple.Create("", 587), Tuple.Create<System.Object, System.Int32>(url
            
            #line default
            #line hidden
, 587), false)
);

WriteLiteral(" target=\"main\"");

WriteLiteral(">\r\n            <i");

WriteLiteral(" class=\"menu-icon fa fa-caret-right\"");

WriteLiteral("></i>\r\n");

WriteLiteral("            ");

            
            #line 24 "..\..\Areas\Admin\Views\Index\_Left_Item.cshtml"
       Write(item.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("\r\n        </a>\r\n");

            
            #line 26 "..\..\Areas\Admin\Views\Index\_Left_Item.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <b");

WriteLiteral(" class=\"arrow\"");

WriteLiteral("></b>\r\n");

WriteLiteral("        <ul");

WriteLiteral(" class=\"submenu\"");

WriteLiteral(">\r\n");

            
            #line 29 "..\..\Areas\Admin\Views\Index\_Left_Item.cshtml"
            
            
            #line default
            #line hidden
            
            #line 29 "..\..\Areas\Admin\Views\Index\_Left_Item.cshtml"
             foreach (var menu in childs)
            {
                
            
            #line default
            #line hidden
            
            #line 31 "..\..\Areas\Admin\Views\Index\_Left_Item.cshtml"
           Write(Html.Partial("_Left_Item", menu));

            
            #line default
            #line hidden
            
            #line 31 "..\..\Areas\Admin\Views\Index\_Left_Item.cshtml"
                                                 ;
            }

            
            #line default
            #line hidden
WriteLiteral("        </ul>\r\n");

            
            #line 34 "..\..\Areas\Admin\Views\Index\_Left_Item.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</li>");

        }
    }
}
#pragma warning restore 1591
