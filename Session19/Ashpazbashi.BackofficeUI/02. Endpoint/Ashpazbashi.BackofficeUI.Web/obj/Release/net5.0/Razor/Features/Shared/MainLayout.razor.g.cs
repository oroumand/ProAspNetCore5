#pragma checksum "D:\Source\ProAspNetCore5\Session19\Ashpazbashi.BackofficeUI\02. Endpoint\Ashpazbashi.BackofficeUI.Web\Features\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a9c7fc2f20a95383eafd65b8fb78bc3ae906ea2"
// <auto-generated/>
#pragma warning disable 1591
namespace Ashpazbashi.BackofficeUI.Web.Features.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Source\ProAspNetCore5\Session19\Ashpazbashi.BackofficeUI\02. Endpoint\Ashpazbashi.BackofficeUI.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Source\ProAspNetCore5\Session19\Ashpazbashi.BackofficeUI\02. Endpoint\Ashpazbashi.BackofficeUI.Web\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Source\ProAspNetCore5\Session19\Ashpazbashi.BackofficeUI\02. Endpoint\Ashpazbashi.BackofficeUI.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Source\ProAspNetCore5\Session19\Ashpazbashi.BackofficeUI\02. Endpoint\Ashpazbashi.BackofficeUI.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Source\ProAspNetCore5\Session19\Ashpazbashi.BackofficeUI\02. Endpoint\Ashpazbashi.BackofficeUI.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Source\ProAspNetCore5\Session19\Ashpazbashi.BackofficeUI\02. Endpoint\Ashpazbashi.BackofficeUI.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Source\ProAspNetCore5\Session19\Ashpazbashi.BackofficeUI\02. Endpoint\Ashpazbashi.BackofficeUI.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Source\ProAspNetCore5\Session19\Ashpazbashi.BackofficeUI\02. Endpoint\Ashpazbashi.BackofficeUI.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Source\ProAspNetCore5\Session19\Ashpazbashi.BackofficeUI\02. Endpoint\Ashpazbashi.BackofficeUI.Web\_Imports.razor"
using Ashpazbashi.BackofficeUI.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Source\ProAspNetCore5\Session19\Ashpazbashi.BackofficeUI\02. Endpoint\Ashpazbashi.BackofficeUI.Web\_Imports.razor"
using Ashpazbashi.BackofficeUI.Web.Features.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Source\ProAspNetCore5\Session19\Ashpazbashi.BackofficeUI\02. Endpoint\Ashpazbashi.BackofficeUI.Web\_Imports.razor"
using Ashpazbashi.BackofficeUI.Web.Features.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Source\ProAspNetCore5\Session19\Ashpazbashi.BackofficeUI\02. Endpoint\Ashpazbashi.BackofficeUI.Web\_Imports.razor"
using Ashpazbashi.BackofficeUI.Web.Features.Tags.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Source\ProAspNetCore5\Session19\Ashpazbashi.BackofficeUI\02. Endpoint\Ashpazbashi.BackofficeUI.Web\_Imports.razor"
using Ashpazbashi.BackofficeUI.Web.Features.Recipes.Models;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "wrapper");
            __builder.AddAttribute(2, "b-6p4fo80tzs");
            __builder.AddMarkupContent(3, "<nav class=\"main-header navbar navbar-expand navbar-white navbar-light\" b-6p4fo80tzs><ul class=\"navbar-nav\" b-6p4fo80tzs><li class=\"nav-item\" b-6p4fo80tzs><a class=\"nav-link\" data-widget=\"pushmenu\" href=\"#\" role=\"button\" b-6p4fo80tzs><i class=\"fas fa-bars\" b-6p4fo80tzs></i></a></li>\r\n            <li class=\"nav-item d-none d-sm-inline-block\" b-6p4fo80tzs><a href=\"../../index3.html\" class=\"nav-link\" b-6p4fo80tzs>Home</a></li>\r\n            <li class=\"nav-item d-none d-sm-inline-block\" b-6p4fo80tzs><a href=\"#\" class=\"nav-link\" b-6p4fo80tzs>Contact</a></li></ul>\r\n\r\n        \r\n        <ul class=\"navbar-nav ml-auto\" b-6p4fo80tzs><li class=\"nav-item\" b-6p4fo80tzs><a class=\"nav-link\" data-widget=\"navbar-search\" href=\"#\" role=\"button\" b-6p4fo80tzs><i class=\"fas fa-search\" b-6p4fo80tzs></i></a>\r\n                <div class=\"navbar-search-block\" b-6p4fo80tzs><form class=\"form-inline\" b-6p4fo80tzs><div class=\"input-group input-group-sm\" b-6p4fo80tzs><input class=\"form-control form-control-navbar\" type=\"search\" placeholder=\"Search\" aria-label=\"Search\" b-6p4fo80tzs>\r\n                            <div class=\"input-group-append\" b-6p4fo80tzs><button class=\"btn btn-navbar\" type=\"submit\" b-6p4fo80tzs><i class=\"fas fa-search\" b-6p4fo80tzs></i></button>\r\n                                <button class=\"btn btn-navbar\" type=\"button\" data-widget=\"navbar-search\" b-6p4fo80tzs><i class=\"fas fa-times\" b-6p4fo80tzs></i></button></div></div></form></div></li>\r\n\r\n            \r\n            <li class=\"nav-item dropdown\" b-6p4fo80tzs><a class=\"nav-link\" data-toggle=\"dropdown\" href=\"#\" b-6p4fo80tzs><i class=\"far fa-comments\" b-6p4fo80tzs></i>\r\n                    <span class=\"badge badge-danger navbar-badge\" b-6p4fo80tzs>3</span></a>\r\n                <div class=\"dropdown-menu dropdown-menu-lg dropdown-menu-right\" b-6p4fo80tzs><a href=\"#\" class=\"dropdown-item\" b-6p4fo80tzs><div class=\"media\" b-6p4fo80tzs><img src=\"../../dist/img/user1-128x128.jpg\" alt=\"User Avatar\" class=\"img-size-50 mr-3 img-circle\" b-6p4fo80tzs>\r\n                            <div class=\"media-body\" b-6p4fo80tzs><h3 class=\"dropdown-item-title\" b-6p4fo80tzs>\r\n                                    Brad Diesel\r\n                                    <span class=\"float-right text-sm text-danger\" b-6p4fo80tzs><i class=\"fas fa-star\" b-6p4fo80tzs></i></span></h3>\r\n                                <p class=\"text-sm\" b-6p4fo80tzs>Call me whenever you can...</p>\r\n                                <p class=\"text-sm text-muted\" b-6p4fo80tzs><i class=\"far fa-clock mr-1\" b-6p4fo80tzs></i> 4 Hours Ago</p></div></div></a>\r\n                    <div class=\"dropdown-divider\" b-6p4fo80tzs></div>\r\n                    <a href=\"#\" class=\"dropdown-item\" b-6p4fo80tzs><div class=\"media\" b-6p4fo80tzs><img src=\"../../dist/img/user8-128x128.jpg\" alt=\"User Avatar\" class=\"img-size-50 img-circle mr-3\" b-6p4fo80tzs>\r\n                            <div class=\"media-body\" b-6p4fo80tzs><h3 class=\"dropdown-item-title\" b-6p4fo80tzs>\r\n                                    John Pierce\r\n                                    <span class=\"float-right text-sm text-muted\" b-6p4fo80tzs><i class=\"fas fa-star\" b-6p4fo80tzs></i></span></h3>\r\n                                <p class=\"text-sm\" b-6p4fo80tzs>I got your message bro</p>\r\n                                <p class=\"text-sm text-muted\" b-6p4fo80tzs><i class=\"far fa-clock mr-1\" b-6p4fo80tzs></i> 4 Hours Ago</p></div></div></a>\r\n                    <div class=\"dropdown-divider\" b-6p4fo80tzs></div>\r\n                    <a href=\"#\" class=\"dropdown-item\" b-6p4fo80tzs><div class=\"media\" b-6p4fo80tzs><img src=\"../../dist/img/user3-128x128.jpg\" alt=\"User Avatar\" class=\"img-size-50 img-circle mr-3\" b-6p4fo80tzs>\r\n                            <div class=\"media-body\" b-6p4fo80tzs><h3 class=\"dropdown-item-title\" b-6p4fo80tzs>\r\n                                    Nora Silvester\r\n                                    <span class=\"float-right text-sm text-warning\" b-6p4fo80tzs><i class=\"fas fa-star\" b-6p4fo80tzs></i></span></h3>\r\n                                <p class=\"text-sm\" b-6p4fo80tzs>The subject goes here</p>\r\n                                <p class=\"text-sm text-muted\" b-6p4fo80tzs><i class=\"far fa-clock mr-1\" b-6p4fo80tzs></i> 4 Hours Ago</p></div></div></a>\r\n                    <div class=\"dropdown-divider\" b-6p4fo80tzs></div>\r\n                    <a href=\"#\" class=\"dropdown-item dropdown-footer\" b-6p4fo80tzs>See All Messages</a></div></li>\r\n            \r\n            <li class=\"nav-item dropdown\" b-6p4fo80tzs><a class=\"nav-link\" data-toggle=\"dropdown\" href=\"#\" b-6p4fo80tzs><i class=\"far fa-bell\" b-6p4fo80tzs></i>\r\n                    <span class=\"badge badge-warning navbar-badge\" b-6p4fo80tzs>15</span></a>\r\n                <div class=\"dropdown-menu dropdown-menu-lg dropdown-menu-right\" b-6p4fo80tzs><span class=\"dropdown-item dropdown-header\" b-6p4fo80tzs>15 Notifications</span>\r\n                    <div class=\"dropdown-divider\" b-6p4fo80tzs></div>\r\n                    <a href=\"#\" class=\"dropdown-item\" b-6p4fo80tzs><i class=\"fas fa-envelope mr-2\" b-6p4fo80tzs></i> 4 new messages\r\n                        <span class=\"float-right text-muted text-sm\" b-6p4fo80tzs>3 mins</span></a>\r\n                    <div class=\"dropdown-divider\" b-6p4fo80tzs></div>\r\n                    <a href=\"#\" class=\"dropdown-item\" b-6p4fo80tzs><i class=\"fas fa-users mr-2\" b-6p4fo80tzs></i> 8 friend requests\r\n                        <span class=\"float-right text-muted text-sm\" b-6p4fo80tzs>12 hours</span></a>\r\n                    <div class=\"dropdown-divider\" b-6p4fo80tzs></div>\r\n                    <a href=\"#\" class=\"dropdown-item\" b-6p4fo80tzs><i class=\"fas fa-file mr-2\" b-6p4fo80tzs></i> 3 new reports\r\n                        <span class=\"float-right text-muted text-sm\" b-6p4fo80tzs>2 days</span></a>\r\n                    <div class=\"dropdown-divider\" b-6p4fo80tzs></div>\r\n                    <a href=\"#\" class=\"dropdown-item dropdown-footer\" b-6p4fo80tzs>See All Notifications</a></div></li>\r\n            <li class=\"nav-item\" b-6p4fo80tzs><a class=\"nav-link\" data-widget=\"fullscreen\" href=\"#\" role=\"button\" b-6p4fo80tzs><i class=\"fas fa-expand-arrows-alt\" b-6p4fo80tzs></i></a></li>\r\n            <li class=\"nav-item\" b-6p4fo80tzs><a class=\"nav-link\" data-widget=\"control-sidebar\" data-slide=\"true\" href=\"#\" role=\"button\" b-6p4fo80tzs><i class=\"fas fa-th-large\" b-6p4fo80tzs></i></a></li></ul></nav>\r\n    \r\n    \r\n    ");
            __builder.OpenElement(4, "aside");
            __builder.AddAttribute(5, "class", "main-sidebar sidebar-dark-primary elevation-4");
            __builder.AddAttribute(6, "b-6p4fo80tzs");
            __builder.AddMarkupContent(7, @"<a href=""../../index3.html"" class=""brand-link"" b-6p4fo80tzs><img src=""../../dist/img/AdminLTELogo.png"" alt=""AdminLTE Logo"" class=""brand-image img-circle elevation-3"" style=""opacity: .8"" b-6p4fo80tzs>
            <span class=""brand-text font-weight-light"" b-6p4fo80tzs>AdminLTE 3</span></a>

        
        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "sidebar");
            __builder.AddAttribute(10, "b-6p4fo80tzs");
            __builder.AddMarkupContent(11, @"<div class=""user-panel mt-3 pb-3 mb-3 d-flex"" b-6p4fo80tzs><div class=""image"" b-6p4fo80tzs><img src=""../../dist/img/user2-160x160.jpg"" class=""img-circle elevation-2"" alt=""User Image"" b-6p4fo80tzs></div>
                <div class=""info"" b-6p4fo80tzs><a href=""#"" class=""d-block"" b-6p4fo80tzs>Alexander Pierce</a></div></div>

            
            ");
            __builder.AddMarkupContent(12, @"<div class=""form-inline"" b-6p4fo80tzs><div class=""input-group"" data-widget=""sidebar-search"" b-6p4fo80tzs><input class=""form-control form-control-sidebar"" type=""search"" placeholder=""Search"" aria-label=""Search"" b-6p4fo80tzs>
                    <div class=""input-group-append"" b-6p4fo80tzs><button class=""btn btn-sidebar"" b-6p4fo80tzs><i class=""fas fa-search fa-fw"" b-6p4fo80tzs></i></button></div></div></div>

            ");
            __builder.OpenComponent<Ashpazbashi.BackofficeUI.Web.Features.Shared.NavMenu>(13);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n    \r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "content-wrapper");
            __builder.AddAttribute(17, "b-6p4fo80tzs");
            __builder.AddContent(18, 
#nullable restore
#line 184 "D:\Source\ProAspNetCore5\Session19\Ashpazbashi.BackofficeUI\02. Endpoint\Ashpazbashi.BackofficeUI.Web\Features\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    \r\n\r\n    ");
            __builder.AddMarkupContent(20, @"<footer class=""main-footer"" b-6p4fo80tzs><div class=""float-right d-none d-sm-block"" b-6p4fo80tzs><b b-6p4fo80tzs>Version</b> 3.1.0
        </div>
        <strong b-6p4fo80tzs>Copyright &copy; 2014-2021 <a href=""https://adminlte.io"" b-6p4fo80tzs>AdminLTE.io</a>.</strong> All rights reserved.
    </footer>

    
    <aside class=""control-sidebar control-sidebar-dark"" b-6p4fo80tzs></aside>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
