#pragma checksum "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.DataTransfer\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc697934b96a657fdfe5bec89b9a19650551f9bc"
// <auto-generated/>
#pragma warning disable 1591
namespace Session13Components.DataTransfer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.DataTransfer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.DataTransfer\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.DataTransfer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.DataTransfer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.DataTransfer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.DataTransfer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.DataTransfer\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.DataTransfer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.DataTransfer\_Imports.razor"
using Session13Components.DataTransfer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.DataTransfer\_Imports.razor"
using Session13Components.DataTransfer.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-6");
            __builder.AddMarkupContent(4, "<h1>والد</h1>\r\n        <hr>\r\n        ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.DataTransfer\Pages\Index.razor"
                                  _inputText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _inputText = __value, _inputText));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
#nullable restore
#line 8 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.DataTransfer\Pages\Index.razor"
         if (ChildTexts.Count > 0)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "ul");
#nullable restore
#line 11 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.DataTransfer\Pages\Index.razor"
                 foreach (var item in ChildTexts)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "li");
            __builder.AddContent(11, 
#nullable restore
#line 13 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.DataTransfer\Pages\Index.razor"
                         item

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 14 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.DataTransfer\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 16 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.DataTransfer\Pages\Index.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "<div class=\" alert alert-danger\">هنوز متنی از کامپوننت فرزند ارسال نشده است.</div>");
#nullable restore
#line 20 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.DataTransfer\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "<hr>");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col-6");
            __builder.AddMarkupContent(17, "<h1>فرزند</h1>\r\n        <hr>\r\n        ");
            __builder.OpenComponent<Session13Components.DataTransfer.Pages.Child>(18);
            __builder.AddAttribute(19, "InputText", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.DataTransfer\Pages\Index.razor"
                           _inputText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "OutputTextChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 26 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.DataTransfer\Pages\Index.razor"
                                                          GetChildText

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n");
            __builder.OpenComponent<Session13Components.DataTransfer.Shared.SurveyPrompt>(22);
            __builder.AddAttribute(23, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "G:\Src\NET 5 Courses\ProAspNetCore5\Session13\Session13Components\Session13Components.DataTransfer\Pages\Index.razor"
 
    private string _inputText;
    private List<string> ChildTexts = new List<string>();
    private void GetChildText(string text)
    {
        if (!string.IsNullOrEmpty(text))
        {
            ChildTexts.Add(text);
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
