#pragma checksum "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.Life\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1089040b3b7b4dcb6a1cd0852de3e5e04e35c643"
// <auto-generated/>
#pragma warning disable 1591
namespace Session13Components.Life.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.Life\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.Life\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.Life\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.Life\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.Life\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.Life\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.Life\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.Life\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.Life\_Imports.razor"
using Session13Components.Life;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.Life\_Imports.razor"
using Session13Components.Life.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n");
            __builder.OpenElement(1, "ul");
#nullable restore
#line 7 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.Life\Pages\Index.razor"
     foreach (var message in MyMessages)
    {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "li");
            __builder.AddContent(3, 
#nullable restore
#line 10 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.Life\Pages\Index.razor"
             message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 11 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.Life\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenComponent<Session13Components.Life.Shared.SurveyPrompt>(5);
            __builder.AddAttribute(6, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.Life\Pages\Index.razor"
 
    public List<string> MyMessages { get; set; } = new List<string>();

    protected override async Task OnInitializedAsync()
    {
        await Task.Delay(2000);
        MyMessages.Add("سلام");
        await Task.Delay(2000);
        MyMessages.Add("حالت خوبه؟");
        await Task.Delay(2000);
        MyMessages.Add("مواظب خودت باش");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591