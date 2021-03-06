// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Session14.BalzorRouterSample.Features.Posts
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "G:\Src\NET 5 Courses\ProAspNetCore5\Session14\Session14.BalzorRouterSample\Session14.BalzorRouterSample\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Src\NET 5 Courses\ProAspNetCore5\Session14\Session14.BalzorRouterSample\Session14.BalzorRouterSample\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\Src\NET 5 Courses\ProAspNetCore5\Session14\Session14.BalzorRouterSample\Session14.BalzorRouterSample\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\Src\NET 5 Courses\ProAspNetCore5\Session14\Session14.BalzorRouterSample\Session14.BalzorRouterSample\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\Src\NET 5 Courses\ProAspNetCore5\Session14\Session14.BalzorRouterSample\Session14.BalzorRouterSample\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\Src\NET 5 Courses\ProAspNetCore5\Session14\Session14.BalzorRouterSample\Session14.BalzorRouterSample\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\Src\NET 5 Courses\ProAspNetCore5\Session14\Session14.BalzorRouterSample\Session14.BalzorRouterSample\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\Src\NET 5 Courses\ProAspNetCore5\Session14\Session14.BalzorRouterSample\Session14.BalzorRouterSample\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\Src\NET 5 Courses\ProAspNetCore5\Session14\Session14.BalzorRouterSample\Session14.BalzorRouterSample\_Imports.razor"
using Session14.BalzorRouterSample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\Src\NET 5 Courses\ProAspNetCore5\Session14\Session14.BalzorRouterSample\Session14.BalzorRouterSample\_Imports.razor"
using Session14.BalzorRouterSample.Features.Posts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "G:\Src\NET 5 Courses\ProAspNetCore5\Session14\Session14.BalzorRouterSample\Session14.BalzorRouterSample\_Imports.razor"
using Session14.BalzorRouterSample.Features.Shared;

#line default
#line hidden
#nullable disable
    public partial class FilterPosts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "G:\Src\NET 5 Courses\ProAspNetCore5\Session14\Session14.BalzorRouterSample\Session14.BalzorRouterSample\Features\Posts\FilterPosts.razor"
       
    private int maxAge;
    private int minAge;
    [Parameter]
    public string SearchTerm { get; set; }
    private void Filter()
    {
        var queryCollection = System.Web.HttpUtility.ParseQueryString("");
        var queryString = string.Empty;

        if(maxAge > 0)
        {
            queryCollection.Add("maxAge", maxAge.ToString());
        }

        if (minAge > 0)
        {
            queryCollection.Add("minAge", minAge.ToString());
        }


        queryString = queryCollection.ToString();
        if (string.IsNullOrEmpty(queryString))
        {
            return;
        }

        _navigationManager.NavigateTo($"/search/{SearchTerm}?{queryString}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591
