#pragma checksum "G:\Src\NET 5 Courses\ProAspNetCore5\Session16\Session16.BindingSample\Session16.BindingSample.Web\Pages\Level02.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f98f9001fad37c5222d8254706e634077142f67"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class Level02 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddAttribute(1, "class", "text-danger");
            __builder.AddContent(2, 
#nullable restore
#line 1 "G:\Src\NET 5 Courses\ProAspNetCore5\Session16\Session16.BindingSample\Session16.BindingSample.Web\Pages\Level02.razor"
                         Level02FullName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenElement(4, "h3");
            __builder.AddAttribute(5, "class", "text-danger");
            __builder.AddContent(6, 
#nullable restore
#line 2 "G:\Src\NET 5 Courses\ProAspNetCore5\Session16\Session16.BindingSample\Session16.BindingSample.Web\Pages\Level02.razor"
                         Level02FullName02

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n<hr>\r\n");
            __Blazor.Session16.BindingSample.Web.Pages.Level02.TypeInference.CreateCascadingValue_0(__builder, 8, 9, 
#nullable restore
#line 4 "G:\Src\NET 5 Courses\ProAspNetCore5\Session16\Session16.BindingSample\Session16.BindingSample.Web\Pages\Level02.razor"
                        Level03LastName

#line default
#line hidden
#nullable disable
            , 10, "LastName", 11, (__builder2) => {
                __builder2.OpenComponent<Session16.BindingSample.Web.Pages.Level03>(12);
                __builder2.CloseComponent();
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "G:\Src\NET 5 Courses\ProAspNetCore5\Session16\Session16.BindingSample\Session16.BindingSample.Web\Pages\Level02.razor"
       
    [CascadingParameter]
    public string Level02FullName { get; set; }
    [CascadingParameter(Name = "LastName")]
    public string Level02FullName02 { get; set; }

    public string Level03LastName { get; set; } = "Rezaee";

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Session16.BindingSample.Web.Pages.Level02
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::System.String __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "ChildContent", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
