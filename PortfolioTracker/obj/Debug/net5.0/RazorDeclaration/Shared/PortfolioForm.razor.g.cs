// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#pragma warning restore 1591
