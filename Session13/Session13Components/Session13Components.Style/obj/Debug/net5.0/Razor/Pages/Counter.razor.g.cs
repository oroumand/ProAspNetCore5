#pragma checksum "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.Style\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c1c51ed803d37edfaeb999b81e4eeacef4a5d39"
// <auto-generated/>
#pragma warning disable 1591
namespace Session13Components.Style.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.Style\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.Style\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.Style\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.Style\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.Style\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.Style\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.Style\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.Style\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.Style\_Imports.razor"
using Session13Components.Style;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.Style\_Imports.razor"
using Session13Components.Style.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 b-sxe2acrsbh>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddAttribute(2, "b-sxe2acrsbh");
            __builder.AddContent(3, "Current count: ");
            __builder.AddContent(4, 
#nullable restore
#line 5 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.Style\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "class", "btn btn-primary");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.Style\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "b-sxe2acrsbh");
            __builder.AddContent(10, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.AddMarkupContent(12, "<h6 b-sxe2acrsbh>متن در صفحه شمارنده</h6>");
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.Style\Pages\Counter.razor"
       
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
