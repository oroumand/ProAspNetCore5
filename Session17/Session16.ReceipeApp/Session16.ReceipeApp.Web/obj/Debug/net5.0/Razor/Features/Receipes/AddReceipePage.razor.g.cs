#pragma checksum "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\Features\Receipes\AddReceipePage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddfa23deeeac24dc82f3cad0c4a51d95e98cf329"
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
#line 1 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using Session16.ReceipeApp.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using Session16.ReceipeApp.Web.Features.Receipes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using Session16.ReceipeApp.Web.Features.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using Session16.ReceipeApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\_Imports.razor"
using MediatR;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-receipe")]
    public partial class AddReceipePage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>AddReceipePage</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "EditContext", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Forms.EditContext>(
#nullable restore
#line 4 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\Features\Receipes\AddReceipePage.razor"
                       editContext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 4 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\Features\Receipes\AddReceipePage.razor"
                                                   SaveReceipe

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Blazored.FluentValidation.FluentValidationValidator>(5);
                __builder2.CloseComponent();
#nullable restore
#line 6 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\Features\Receipes\AddReceipePage.razor"
     if (IsSuccess)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "alert alert-success");
                __builder2.AddMarkupContent(8, "\r\n            عملیات ثبت دستور پخت با شناسه  ");
                __builder2.AddContent(9, 
#nullable restore
#line 9 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\Features\Receipes\AddReceipePage.razor"
                                            receipeId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(10, " با موفقت انجام شد.\r\n        ");
                __builder2.CloseElement();
#nullable restore
#line 11 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\Features\Receipes\AddReceipePage.razor"
    }
    else if (!string.IsNullOrEmpty(errorMessage))
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "alert alert-danger");
                __builder2.AddContent(13, 
#nullable restore
#line 15 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\Features\Receipes\AddReceipePage.razor"
             errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 17 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\Features\Receipes\AddReceipePage.razor"
    }

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<Session16.ReceipeApp.Web.Features.Receipes.FormSection>(14);
                __builder2.AddAttribute(15, "Title", "اطلاعات اولیه");
                __builder2.AddAttribute(16, "Description", "در این قسمت اطلاعات اولیه غذا را وارد کنید");
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Session16.ReceipeApp.Web.Features.Receipes.FormControlGroup>(18);
                    __builder3.AddAttribute(19, "LableTitle", "نام غذا");
                    __builder3.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(21);
                        __builder4.AddAttribute(22, "class", "form-control");
                        __builder4.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\Features\Receipes\AddReceipePage.razor"
                                    receipe.Name

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => receipe.Name = __value, receipe.Name))));
                        __builder4.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => receipe.Name));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(26, "\r\n            ");
                        __Blazor.Session16.ReceipeApp.Web.Features.Receipes.AddReceipePage.TypeInference.CreateValidationMessage_0(__builder4, 27, 28, 
#nullable restore
#line 21 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\Features\Receipes\AddReceipePage.razor"
                                    ()=>receipe.Name

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(29, "\r\n        ");
                    __builder3.OpenComponent<Session16.ReceipeApp.Web.Features.Receipes.FormControlGroup>(30);
                    __builder3.AddAttribute(31, "LableTitle", "توضیحات");
                    __builder3.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(33);
                        __builder4.AddAttribute(34, "class", "form-control");
                        __builder4.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\Features\Receipes\AddReceipePage.razor"
                                    receipe.Description

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(36, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => receipe.Description = __value, receipe.Description))));
                        __builder4.AddAttribute(37, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => receipe.Description));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(38, "\r\n            ");
                        __Blazor.Session16.ReceipeApp.Web.Features.Receipes.AddReceipePage.TypeInference.CreateValidationMessage_1(__builder4, 39, 40, 
#nullable restore
#line 25 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\Features\Receipes\AddReceipePage.razor"
                                    ()=>receipe.Description

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\r\n        ");
                    __builder3.OpenComponent<Session16.ReceipeApp.Web.Features.Receipes.FormControlGroup>(42);
                    __builder3.AddAttribute(43, "LableTitle", "دستور پخت");
                    __builder3.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(45);
                        __builder4.AddAttribute(46, "class", "form-control");
                        __builder4.AddAttribute(47, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\Features\Receipes\AddReceipePage.razor"
                                        receipe.Detaile

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(48, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => receipe.Detaile = __value, receipe.Detaile))));
                        __builder4.AddAttribute(49, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => receipe.Detaile));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(50, "\r\n            ");
                        __Blazor.Session16.ReceipeApp.Web.Features.Receipes.AddReceipePage.TypeInference.CreateValidationMessage_2(__builder4, 51, 52, 
#nullable restore
#line 30 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\Features\Receipes\AddReceipePage.razor"
                                    ()=>receipe.Detaile

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n    ");
                __builder2.OpenComponent<Session16.ReceipeApp.Web.Features.Receipes.FormSection>(54);
                __builder2.AddAttribute(55, "Title", "زمان طبخ");
                __builder2.AddAttribute(56, "Description", "در این قسمت اطلاعات مربوط به زمان طبخ را را وارد کنید");
                __builder2.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Session16.ReceipeApp.Web.Features.Receipes.FormControlGroup>(58);
                    __builder3.AddAttribute(59, "LableTitle", "زمان طبخ");
                    __builder3.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Session16.ReceipeApp.Web.Features.Receipes.InputTime>(61);
                        __builder4.AddAttribute(62, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 36 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\Features\Receipes\AddReceipePage.razor"
                                    receipe.PreparationTime

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(63, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => receipe.PreparationTime = __value, receipe.PreparationTime))));
                        __builder4.AddAttribute(64, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Int32>>>(() => receipe.PreparationTime));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\r\n\r\n    ");
                __builder2.OpenComponent<Session16.ReceipeApp.Web.Features.Receipes.FormSection>(66);
                __builder2.AddAttribute(67, "Title", "تصویر خوارکی");
                __builder2.AddAttribute(68, "Description", "یه عکس خوب از غذاتون بگیرید و اینجا با ما به اشتراک بذارید");
                __builder2.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Session16.ReceipeApp.Web.Features.Receipes.FormControlGroup>(70);
                    __builder3.AddAttribute(71, "LableTitle", "انتخاب تصویر");
                    __builder3.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(73);
                        __builder4.AddAttribute(74, "class", "form-control-file");
                        __builder4.AddAttribute(75, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 42 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\Features\Receipes\AddReceipePage.razor"
                                                           ImageChanged

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(76, "\r\n\r\n\r\n    ");
                __builder2.OpenComponent<Session16.ReceipeApp.Web.Features.Receipes.FormSection>(77);
                __builder2.AddAttribute(78, "Title", "مواد لازم");
                __builder2.AddAttribute(79, "Description", "مواد لازم جهت طبخ غذا را وارد کنید");
                __builder2.AddAttribute(80, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(81, "div");
                    __builder3.AddAttribute(82, "class", "col-12");
#nullable restore
#line 49 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\Features\Receipes\AddReceipePage.razor"
             foreach (var item in receipe.Ingridients)
            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(83, "div");
                    __builder3.AddAttribute(84, "class", "row");
                    __builder3.OpenComponent<Session16.ReceipeApp.Web.Features.Receipes.FormControlGroup>(85);
                    __builder3.AddAttribute(86, "LableTitle", "نام ماده تشکیل دهنده");
                    __builder3.AddAttribute(87, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(88);
                        __builder4.AddAttribute(89, "class", "form-control");
                        __builder4.AddAttribute(90, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\Features\Receipes\AddReceipePage.razor"
                                                item.Name

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(91, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => item.Name = __value, item.Name))));
                        __builder4.AddAttribute(92, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => item.Name));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(93, "\r\n                        ");
                        __Blazor.Session16.ReceipeApp.Web.Features.Receipes.AddReceipePage.TypeInference.CreateValidationMessage_3(__builder4, 94, 95, 
#nullable restore
#line 54 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\Features\Receipes\AddReceipePage.razor"
                                                ()=>item.Name

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(96, "\r\n                    ");
                    __builder3.OpenComponent<Session16.ReceipeApp.Web.Features.Receipes.FormControlGroup>(97);
                    __builder3.AddAttribute(98, "LableTitle", "مقدار ماده تشکیل دهنده");
                    __builder3.AddAttribute(99, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(100);
                        __builder4.AddAttribute(101, "class", "form-control");
                        __builder4.AddAttribute(102, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 58 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\Features\Receipes\AddReceipePage.razor"
                                                item.Value

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(103, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => item.Value = __value, item.Value))));
                        __builder4.AddAttribute(104, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => item.Value));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(105, "\r\n                        ");
                        __Blazor.Session16.ReceipeApp.Web.Features.Receipes.AddReceipePage.TypeInference.CreateValidationMessage_4(__builder4, 106, 107, 
#nullable restore
#line 59 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\Features\Receipes\AddReceipePage.razor"
                                                ()=>item.Value

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(108, "\r\n                    ");
                    __builder3.OpenElement(109, "div");
                    __builder3.AddAttribute(110, "class", "col-xl-4");
                    __builder3.OpenElement(111, "button");
                    __builder3.AddAttribute(112, "type", "button");
                    __builder3.AddAttribute(113, "class", "btn btn-danger btn-block");
                    __builder3.AddAttribute(114, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\Features\Receipes\AddReceipePage.razor"
                                                                                           _=>receipe.Ingridients.Remove(item)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(115, "حذف");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
#nullable restore
#line 66 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\Features\Receipes\AddReceipePage.razor"
            }

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(116, "div");
                    __builder3.AddAttribute(117, "class", "row");
                    __builder3.OpenElement(118, "div");
                    __builder3.AddAttribute(119, "class", "text-center mt-5");
                    __builder3.OpenElement(120, "button");
                    __builder3.AddAttribute(121, "class", "btn btn-primary");
                    __builder3.AddAttribute(122, "type", "button");
                    __builder3.AddAttribute(123, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\Features\Receipes\AddReceipePage.razor"
                                                                              _=>receipe.Ingridients.Add(new Ingridient())

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(124, "\r\n                        افزودن مواد لازم\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(125, "\r\n\r\n    ");
                __builder2.OpenElement(126, "div");
                __builder2.AddAttribute(127, "class", "mt-4 mb-5");
                __builder2.OpenElement(128, "div");
                __builder2.AddAttribute(129, "class", "row");
                __builder2.OpenElement(130, "div");
                __builder2.AddAttribute(131, "class", "offset-4 col-8 text-sm-right");
                __builder2.OpenElement(132, "button");
                __builder2.AddAttribute(133, "class", "btn btn-outline-danger");
                __builder2.AddAttribute(134, "type", "button");
                __builder2.AddAttribute(135, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 80 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\Features\Receipes\AddReceipePage.razor"
                                                                               (_=>receipe =  new Receipe())

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(136, "بازنشانی");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(137, "\r\n                ");
                __builder2.AddMarkupContent(138, "<button class=\"btn btn-success\" type=\"submit\">ثبت</button>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 86 "G:\Src\NET 5 Courses\ProAspNetCore5\Session17\Session16.ReceipeApp\Session16.ReceipeApp.Web\Features\Receipes\AddReceipePage.razor"
       
    private Receipe receipe = new Receipe
    {
        PreparationTime = 70
    };
    private EditContext editContext;
    private int receipeId;
    public bool IsSuccess { get; set; }
    public string errorMessage { get; set; }

    protected override void OnInitialized()
    {
        editContext = new EditContext(receipe);
        editContext.SetFieldCssClassProvider(new Session16.ReceipeApp.Web.Infrastructures.BootstrapCssClassProvider());
    }

    private async Task SaveReceipe()
    {
        receipeId = await _mediator.Send(new AddReceipeRequest(receipe));
        if (receipeId == -1)
        {
            IsSuccess = false;
            errorMessage = "یک خطا هنگام واکشی اطلاعات از سرور اتفاق افتاد.";
        }

        IsSuccess = true;
        errorMessage = string.Empty;
        receipe = new Receipe();


    }


    private async Task ImageChanged(InputFileChangeEventArgs args)
    {
        var size = args.File.Size;
        receipe.FoodImage.FileName = args.File.Name;

        using var myStream = args.File.OpenReadStream();
        receipe.FoodImage.Content = new byte[size];
        await myStream.ReadAsync(receipe.FoodImage.Content, 0, (int)size);
        Console.WriteLine(receipe.FoodImage.FileName);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMediator _mediator { get; set; }
    }
}
namespace __Blazor.Session16.ReceipeApp.Web.Features.Receipes.AddReceipePage
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
