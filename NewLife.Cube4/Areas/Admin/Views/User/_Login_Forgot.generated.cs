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
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/User/_Login_Forgot.cshtml")]
    public partial class _Areas_Admin_Views_User__Login_Forgot_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Admin_Views_User__Login_Forgot_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"tab-pane fade\"");

WriteLiteral(" id=\"Forgot\"");

WriteLiteral(">\r\n    <!-- Logo-->\r\n    <div");

WriteLiteral(" class=\"row text-center\"");

WriteLiteral(">\r\n        <i");

WriteLiteral(" class=\"glyphicon glyphicon-cloud login-logo center-block\"");

WriteLiteral("></i>\r\n    </div>\r\n    <!-- 登录-->\r\n");

            
            #line 7 "..\..\Areas\Admin\Views\User\_Login_Forgot.cshtml"
    
            
            #line default
            #line hidden
            
            #line 7 "..\..\Areas\Admin\Views\User\_Login_Forgot.cshtml"
     using (Html.BeginForm("ForgetPassword", "User", new { ReturnUrl = ViewBag.ReturnUrl }, FormMethod.Post, new { @class = "cube-login" }))
    {
        
            
            #line default
            #line hidden
            
            #line 9 "..\..\Areas\Admin\Views\User\_Login_Forgot.cshtml"
   Write(Html.ValidationSummary());

            
            #line default
            #line hidden
            
            #line 9 "..\..\Areas\Admin\Views\User\_Login_Forgot.cshtml"
                                 

            
            #line default
            #line hidden
WriteLiteral("        <span");

WriteLiteral(" class=\"heading text-primary\"");

WriteLiteral(">取回密码</span>\r\n");

WriteLiteral("        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" type=\"email\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" id=\"email\"");

WriteLiteral(" name=\"email\"");

WriteLiteral(" placeholder=\"输入你的邮箱地址\"");

WriteLiteral(">\r\n            <i");

WriteLiteral(" class=\"glyphicon glyphicon-user\"");

WriteLiteral("></i>\r\n        </div>\r\n");

WriteLiteral("        <div");

WriteLiteral(" class=\"form-group text-center\"");

WriteLiteral(">\r\n            <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-default text-center\"");

WriteLiteral(">发送</button>\r\n        </div>\r\n");

            
            #line 18 "..\..\Areas\Admin\Views\User\_Login_Forgot.cshtml"

    }

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"toolbar clearfix text-center\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(" style=\"padding-top:30px;\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"toolbar center\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" href=\"#Login\"");

WriteLiteral(" data-toggle=\"tab\"");

WriteLiteral(">\r\n                        回到登录\r\n                        <i");

WriteLiteral(" class=\"ace-icon fa fa-arrow-right\"");

WriteLiteral("></i>\r\n                    </a>\r\n                </div>\r\n            </div>\r\n    " +
"    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
