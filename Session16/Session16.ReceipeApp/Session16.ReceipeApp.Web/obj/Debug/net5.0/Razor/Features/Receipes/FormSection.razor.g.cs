#pragma checksum "G:\Src\NET 5 Courses\ProAspNetCore5\Session16\Session16.ReceipeApp\Session16.ReceipeApp.Web\Features\Receipes\FormSection.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfb2e2cc8a75bac835877c251b2addd2d4aa9617"
// <auto-generated/>
#pragma warning disable 1591
namespace Session16.ReceipeApp.Web.Features.Receipes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "G:\Src\NET 5 Courses\ProAspNetCore5\Session16\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Src\NET 5 Courses\ProAspNetCore5\Session16\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\Src\NET 5 Courses\ProAspNetCore5\Session16\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\Src\NET 5 Courses\ProAspNetCore5\Session16\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\Src\NET 5 Courses\ProAspNetCore5\Session16\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\Src\NET 5 Courses\ProAspNetCore5\Session16\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\Src\NET 5 Courses\ProAspNetCore5\Session16\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\Src\NET 5 Courses\ProAspNetCore5\Session16\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\Src\NET 5 Courses\ProAspNetCore5\Session16\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using Session16.ReceipeApp.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\Src\NET 5 Courses\ProAspNetCore5\Session16\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using Session16.ReceipeApp.Web.Features.Receipes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "G:\Src\NET 5 Courses\ProAspNetCore5\Session16\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using Session16.ReceipeApp.Web.Features.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "G:\Src\NET 5 Courses\ProAspNetCore5\Session16\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using Session16.ReceipeApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "G:\Src\NET 5 Courses\ProAspNetCore5\Session16\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
    public partial class FormSection : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card shadow-sm mb-4");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card-body");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "text-center");
            __builder.OpenElement(6, "h4");
            __builder.AddContent(7, 
#nullable restore
#line 4 "G:\Src\NET 5 Courses\ProAspNetCore5\Session16\Session16.ReceipeApp\Session16.ReceipeApp.Web\Features\Receipes\FormSection.razor"
                 Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n            \r\n            ");
            __builder.OpenElement(9, "p");
            __builder.AddAttribute(10, "class", "text-secondary small");
            __builder.AddContent(11, 
#nullable restore
#line 6 "G:\Src\NET 5 Courses\ProAspNetCore5\Session16\Session16.ReceipeApp\Session16.ReceipeApp.Web\Features\Receipes\FormSection.razor"
                                             Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "row mt-5");
            __builder.AddContent(15, 
#nullable restore
#line 9 "G:\Src\NET 5 Courses\ProAspNetCore5\Session16\Session16.ReceipeApp\Session16.ReceipeApp.Web\Features\Receipes\FormSection.razor"
             ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "G:\Src\NET 5 Courses\ProAspNetCore5\Session16\Session16.ReceipeApp\Session16.ReceipeApp.Web\Features\Receipes\FormSection.razor"
           
        [Parameter]
        public string Title { get; set; }
        [Parameter]
        public string Description { get; set; }
        [Parameter]
        public RenderFragment ChildContent { get; set; }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
