#pragma checksum "G:\Src\NET 5 Courses\ProAspNetCore5\Session12\BeginingBlazor\BeginingBlazor\Features\Posts\PostThumbnail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1a8f9b98512096ac275b8fd8384d02b38adbdc3"
// <auto-generated/>
#pragma warning disable 1591
namespace BeginingBlazor.Features.Posts
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "G:\Src\NET 5 Courses\ProAspNetCore5\Session12\BeginingBlazor\BeginingBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Src\NET 5 Courses\ProAspNetCore5\Session12\BeginingBlazor\BeginingBlazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\Src\NET 5 Courses\ProAspNetCore5\Session12\BeginingBlazor\BeginingBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\Src\NET 5 Courses\ProAspNetCore5\Session12\BeginingBlazor\BeginingBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\Src\NET 5 Courses\ProAspNetCore5\Session12\BeginingBlazor\BeginingBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\Src\NET 5 Courses\ProAspNetCore5\Session12\BeginingBlazor\BeginingBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\Src\NET 5 Courses\ProAspNetCore5\Session12\BeginingBlazor\BeginingBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\Src\NET 5 Courses\ProAspNetCore5\Session12\BeginingBlazor\BeginingBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\Src\NET 5 Courses\ProAspNetCore5\Session12\BeginingBlazor\BeginingBlazor\_Imports.razor"
using BeginingBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\Src\NET 5 Courses\ProAspNetCore5\Session12\BeginingBlazor\BeginingBlazor\_Imports.razor"
using BeginingBlazor.Features.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "G:\Src\NET 5 Courses\ProAspNetCore5\Session12\BeginingBlazor\BeginingBlazor\_Imports.razor"
using BeginingBlazor.Features.Posts;

#line default
#line hidden
#nullable disable
    public partial class PostThumbnail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddAttribute(2, "style", "width: 18rem;");
            __builder.OpenElement(3, "img");
            __builder.AddAttribute(4, "src", 
#nullable restore
#line 3 "G:\Src\NET 5 Courses\ProAspNetCore5\Session12\BeginingBlazor\BeginingBlazor\Features\Posts\PostThumbnail.razor"
               Post.URL

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "class", "card-img-top");
            __builder.AddAttribute(6, "alt", "...");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-body");
            __builder.OpenElement(10, "h5");
            __builder.AddAttribute(11, "class", "card-title");
            __builder.AddContent(12, 
#nullable restore
#line 5 "G:\Src\NET 5 Courses\ProAspNetCore5\Session12\BeginingBlazor\BeginingBlazor\Features\Posts\PostThumbnail.razor"
                                 Post.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "p");
            __builder.AddAttribute(15, "class", "card-text");
            __builder.AddContent(16, 
#nullable restore
#line 6 "G:\Src\NET 5 Courses\ProAspNetCore5\Session12\BeginingBlazor\BeginingBlazor\Features\Posts\PostThumbnail.razor"
                              Post.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "a");
            __builder.AddAttribute(19, "href", 
#nullable restore
#line 7 "G:\Src\NET 5 Courses\ProAspNetCore5\Session12\BeginingBlazor\BeginingBlazor\Features\Posts\PostThumbnail.razor"
                  $"/post/{Post.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(20, "class", "btn btn-primary");
            __builder.AddMarkupContent(21, "بیشتر ...");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "G:\Src\NET 5 Courses\ProAspNetCore5\Session12\BeginingBlazor\BeginingBlazor\Features\Posts\PostThumbnail.razor"
       
    [Parameter]
    public Post Post { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
