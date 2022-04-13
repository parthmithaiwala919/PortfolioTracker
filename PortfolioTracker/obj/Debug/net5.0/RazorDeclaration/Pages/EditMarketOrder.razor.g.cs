// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PortfolioTracker.Pages
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
#line 2 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\Pages\EditMarketOrder.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\Pages\EditMarketOrder.razor"
using Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editmarketorder/{orderId:int}")]
    public partial class EditMarketOrder : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\Pages\EditMarketOrder.razor"
 
    // ID of the order to be edited
    [Parameter]
    public int OrderId { get; set; }

    // order form model
    private OrderForm.OrderFormModel _initialOrderFormModel;

    // portfolio the order will belong to
    private Portfolio _activePortfolio;
    
    // portfolio entry the order will belong to
    private PortfolioEntry _activeEntry;
    
    // edited order
    private MarketOrder _activeMarketOrder;

    protected override void OnInitialized()
    {
        // fetch the order to be edited
        _activeMarketOrder = MarketOrderService.GetMarketOrder(OrderId);

        if (_activeMarketOrder == null)
        {
            NavigationManager.NavigateTo("/notfound");
            return;
        }
            
        _activeEntry = PortfolioEntrySerivce.GetPortfolioEntry(_activeMarketOrder.PortfolioEntryId);
        _activePortfolio = PortfolioService.GetPortfolio(_activeEntry.PortfolioId);
        
        // initialize the order form model
        _initialOrderFormModel = new();
        _initialOrderFormModel.Fee = _activeMarketOrder.Fee;
        _initialOrderFormModel.Size = _activeMarketOrder.Size;
        _initialOrderFormModel.FilledPrice = _activeMarketOrder.FilledPrice;
        _initialOrderFormModel.OrderDate = _activeMarketOrder.Date;
        _initialOrderFormModel.SellOrder = !_activeMarketOrder.Buy;
    }

    private void OnCreateOrderFormSubmit(OrderForm.OrderFormModel formFormModel)
    {
        // update the order
        MarketOrderService.UpdateMarketOrder(_activeMarketOrder with {
            FilledPrice = formFormModel.FilledPrice, 
            Fee = formFormModel.Fee, 
            Size = formFormModel.Size, 
            Date = formFormModel.OrderDate,
            Buy = !formFormModel.SellOrder
            });
        Toaster.Add("Order successfully edited", MatToastType.Success, "", "");
        
        // navigate back to the portfolio entry detail
        NavigationManager.NavigateTo($"/entries/{_activeEntry.Id}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatToaster Toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatDialogService MatDialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMarketOrderService MarketOrderService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPortfolioEntryService PortfolioEntrySerivce { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPortfolioService PortfolioService { get; set; }
    }
}
#pragma warning restore 1591