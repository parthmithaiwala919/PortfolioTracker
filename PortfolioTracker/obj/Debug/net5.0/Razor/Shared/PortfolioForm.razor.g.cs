#pragma checksum "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\Shared\PortfolioForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7c2fcb5ec70fb013bee327ccb1d03a0959da1f4"
// <auto-generated/>
#pragma warning disable 1591
namespace PortfolioTracker.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\_Imports.razor"
using PortfolioTracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\_Imports.razor"
using PortfolioTracker.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\Shared\PortfolioForm.razor"
using Utils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\Shared\PortfolioForm.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\Shared\PortfolioForm.razor"
using Model;

#line default
#line hidden
#nullable disable
    public partial class PortfolioForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\Shared\PortfolioForm.razor"
                 FormModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\Shared\PortfolioForm.razor"
                                           OnFormSubmitted

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\n    ");
                __builder2.OpenElement(6, "p");
                __Blazor.PortfolioTracker.Shared.PortfolioForm.TypeInference.CreateMatTextField_0(__builder2, 7, 8, 
#nullable restore
#line 9 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\Shared\PortfolioForm.razor"
                                 true

#line default
#line hidden
#nullable disable
                , 9, "Portfolio name", 10, 
#nullable restore
#line 9 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\Shared\PortfolioForm.razor"
                                                     FormModel.Name

#line default
#line hidden
#nullable disable
                , 11, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => FormModel.Name = __value, FormModel.Name)), 12, () => FormModel.Name);
                __builder2.AddMarkupContent(13, "\n        ");
                __Blazor.PortfolioTracker.Shared.PortfolioForm.TypeInference.CreateValidationMessage_1(__builder2, 14, 15, 
#nullable restore
#line 10 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\Shared\PortfolioForm.razor"
                                  () => FormModel.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\n\n    ");
                __builder2.OpenElement(17, "p");
                __Blazor.PortfolioTracker.Shared.PortfolioForm.TypeInference.CreateMatTextField_2(__builder2, 18, 19, 
#nullable restore
#line 14 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\Shared\PortfolioForm.razor"
                                 true

#line default
#line hidden
#nullable disable
                , 20, "Description", 21, 
#nullable restore
#line 14 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\Shared\PortfolioForm.razor"
                                                     FormModel.Description

#line default
#line hidden
#nullable disable
                , 22, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => FormModel.Description = __value, FormModel.Description)), 23, () => FormModel.Description);
                __builder2.AddMarkupContent(24, "\n        ");
                __Blazor.PortfolioTracker.Shared.PortfolioForm.TypeInference.CreateValidationMessage_3(__builder2, 25, 26, 
#nullable restore
#line 15 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\Shared\PortfolioForm.razor"
                                  () => FormModel.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 17 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\Shared\PortfolioForm.razor"
     if (!Edit)
    {

#line default
#line hidden
#nullable disable
                __Blazor.PortfolioTracker.Shared.PortfolioForm.TypeInference.CreateMatRadioGroup_4(__builder2, 27, 28, 
#nullable restore
#line 19 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\Shared\PortfolioForm.razor"
                                                                         AvailableCurrencies

#line default
#line hidden
#nullable disable
                , 29, 
#nullable restore
#line 19 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\Shared\PortfolioForm.razor"
                                     FormModel.SelectedCurrency

#line default
#line hidden
#nullable disable
                , 30, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => FormModel.SelectedCurrency = __value, FormModel.SelectedCurrency)), 31, () => FormModel.SelectedCurrency, 32, (currencyContext) => (__builder3) => {
                    __builder3.OpenElement(33, "div");
                    __Blazor.PortfolioTracker.Shared.PortfolioForm.TypeInference.CreateMatRadioButton_5(__builder3, 34, 35, 
#nullable restore
#line 22 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\Shared\PortfolioForm.razor"
                                            currencyContext

#line default
#line hidden
#nullable disable
                    , 36, (__builder4) => {
#nullable restore
#line 22 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\Shared\PortfolioForm.razor"
__builder4.AddContent(37, CurrencyUtils.GetCurrencyLabel(currencyContext));

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.CloseElement();
                }
                );
                __builder2.AddMarkupContent(38, "\n        ");
                __Blazor.PortfolioTracker.Shared.PortfolioForm.TypeInference.CreateValidationMessage_6(__builder2, 39, 40, 
#nullable restore
#line 26 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\Shared\PortfolioForm.razor"
                                  () => FormModel.SelectedCurrency

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 27 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\Shared\PortfolioForm.razor"
    }

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MatBlazor.MatCardActions>(41);
                __builder2.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MatBlazor.MatCardActionButtons>(43);
                    __builder3.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MatBlazor.MatButton>(45);
                        __builder4.AddAttribute(46, "Type", "submit");
                        __builder4.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
#nullable restore
#line 31 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\Shared\PortfolioForm.razor"
                 if (Edit)
                {

#line default
#line hidden
#nullable disable
                            __builder5.AddMarkupContent(48, "<span>Save</span>");
#nullable restore
#line 34 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\Shared\PortfolioForm.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
                            __builder5.AddMarkupContent(49, "<span>Create</span>");
#nullable restore
#line 38 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\Shared\PortfolioForm.razor"
                }

#line default
#line hidden
#nullable disable
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(50, "\n\n        ");
                    __builder3.OpenComponent<MatBlazor.MatCardActionIcons>(51);
                    __builder3.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MatBlazor.MatIconButton>(53);
                        __builder4.AddAttribute(54, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 43 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\Shared\PortfolioForm.razor"
                                  MatIconNames.Refresh

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(55, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\Shared\PortfolioForm.razor"
                                                                 (_) => FormModel.Reset()

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
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\Shared\PortfolioForm.razor"
       
    // model of the portfolio form
    [Parameter]
    public PortfolioFormModel FormModel { get; set; } = new (Currency.Usd);
    
    // callback called when the form is submitted
    [Parameter] public EventCallback<PortfolioFormModel> OnSubmitEventHandler { get; set; }
    
    // list of currencies available
    [Parameter]
    public List<Currency> AvailableCurrencies { get; set; }
    
    // default currency to be used
    [Parameter]
    public Currency DefaultCurrency { get; set; } = Currency.Usd;
    
    // flag indicating whether an existing portfolio will be edited or a new one created
    [Parameter] public bool Edit { get; set; }
    
    public class PortfolioFormModel
    {
        // default currency to be used
        private Currency _defaultCurrency;

        public PortfolioFormModel(Currency defaultCurrency)
        {
            _defaultCurrency = defaultCurrency;
            SelectedCurrency = defaultCurrency;
        }

        [Required]
        [MinLength(1)]
        public string Name { get; set; }

        [Required]
        [MinLength(1)]
        public string Description { get; set; }

        [Required] public Currency SelectedCurrency { get; set; }

        public void Reset()
        {
            Name = "";
            Description = "";
            SelectedCurrency = _defaultCurrency;
        }
    }
    
    private async void OnFormSubmitted()
    {
        await OnSubmitEventHandler.InvokeAsync(FormModel);
        FormModel.Reset();
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.PortfolioTracker.Shared.PortfolioForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatTextField_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "FullWidth", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "FullWidth", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMatRadioGroup_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TValue> __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment<TValue> __arg4)
        {
        __builder.OpenComponent<global::MatBlazor.MatRadioGroup<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ItemTemplate", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMatRadioButton_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MatBlazor.MatRadioButton<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
