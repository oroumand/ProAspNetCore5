// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Session16.BindingSample.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "G:\Src\NET 5 Courses\ProAspNetCore5\Session16\Session16.BindingSample\Session16.BindingSample.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Src\NET 5 Courses\ProAspNetCore5\Session16\Session16.BindingSample\Session16.BindingSample.Web\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\Src\NET 5 Courses\ProAspNetCore5\Session16\Session16.BindingSample\Session16.BindingSample.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\Src\NET 5 Courses\ProAspNetCore5\Session16\Session16.BindingSample\Session16.BindingSample.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\Src\NET 5 Courses\ProAspNetCore5\Session16\Session16.BindingSample\Session16.BindingSample.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\Src\NET 5 Courses\ProAspNetCore5\Session16\Session16.BindingSample\Session16.BindingSample.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\Src\NET 5 Courses\ProAspNetCore5\Session16\Session16.BindingSample\Session16.BindingSample.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\Src\NET 5 Courses\ProAspNetCore5\Session16\Session16.BindingSample\Session16.BindingSample.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\Src\NET 5 Courses\ProAspNetCore5\Session16\Session16.BindingSample\Session16.BindingSample.Web\_Imports.razor"
using Session16.BindingSample.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\Src\NET 5 Courses\ProAspNetCore5\Session16\Session16.BindingSample\Session16.BindingSample.Web\_Imports.razor"
using Session16.BindingSample.Web.Shared;

#line default
#line hidden
#nullable disable
    public partial class TowWayTest : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 4 "G:\Src\NET 5 Courses\ProAspNetCore5\Session16\Session16.BindingSample\Session16.BindingSample.Web\Pages\TowWayTest.razor"
       
    [Parameter]
    public string Name { get; set; }
    [Parameter]
    public EventCallback<string> NameChanged { get; set; }
    //public EventCallback<string> NameUpdate { get; set; }
    private async Task ChangeName()
    {
        Name = $"Oroumand {DateTime.Now}";
        await NameChanged.InvokeAsync(Name);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
