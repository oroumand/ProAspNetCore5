// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Session16.ReceipeApp.Web.Features.Receipes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Source\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Source\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Source\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Source\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Source\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Source\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Source\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Source\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Source\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using Session16.ReceipeApp.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Source\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using Session16.ReceipeApp.Web.Features.Receipes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Source\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using Session16.ReceipeApp.Web.Features.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Source\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using Session16.ReceipeApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Source\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Source\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using MediatR;

#line default
#line hidden
#nullable disable
    public partial class InputTime : InputBase<int>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "D:\Source\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\Features\Receipes\InputTime.razor"
       
    private int _hours;

    private int _minuts;

    private void SetHour(ChangeEventArgs args)
    {
        int.TryParse(args.Value.ToString(), out _hours);
    }

    private void SetMinut(ChangeEventArgs args)
    {
        int.TryParse(args.Value.ToString(), out _minuts);
    }
    private void SetCurentvalue()
    {
        CurrentValue = (_hours * 60) + _minuts;
    }


    protected override bool TryParseValueFromString(string value, [System.Diagnostics.CodeAnalysis.MaybeNullWhen(false)] out int result, [System.Diagnostics.CodeAnalysis.NotNullWhen(false)] out string validationErrorMessage)
    {
        throw new NotImplementedException();
    }

    protected override void OnParametersSet()
    {
        _hours = Value / 60;
        _minuts = Value % 60;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
