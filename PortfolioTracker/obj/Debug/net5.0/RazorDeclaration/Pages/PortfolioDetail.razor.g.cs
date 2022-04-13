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
#line 2 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\Pages\PortfolioDetail.razor"
using Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\Pages\PortfolioDetail.razor"
using Utils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\Pages\PortfolioDetail.razor"
using PortfolioTrackerStatsSource;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\Pages\PortfolioDetail.razor"
using Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/portfolios/{portfolioId:int}")]
    public partial class PortfolioDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 128 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\Pages\PortfolioDetail.razor"
 
    // id of the portfolio whose detail should be shown
    [Parameter]
    public int PortfolioId { get; set; }

    // portfolio whose detail should be shown
    private Portfolio _activePortfolio;

    // summary of the portfolio
    private ISummaryService.Summary _portfolioSummary;

    // entries of the portfolio
    private List<PortfolioEntry> _activePortfolioEntries;

    // rows of the portfolio entry table
    private List<PortfolioEntryRow> _portfolioEntryRows;

    protected record PortfolioEntryRow(string Symbol, decimal CurrentPrice, decimal RelativeChange, decimal Percentage, decimal AbsoluteChange, decimal MarketValue, int EntryId);

    protected override void OnInitialized()
    {
        _activePortfolio = PortfolioService.GetPortfolio(PortfolioId);
        if (_activePortfolio == null)
        {
            NavigationManager.NavigateTo("/notfound");
            return;
        }
        
        _activePortfolioEntries = PortfolioEntryService.GetPortfolioEntries(PortfolioId);
        _loadEntryInfo();
    }


    private async void _loadEntryInfo()
    {
        // resolve names of all portfolio entries 
        await CryptocurrencyResolver.Refresh();
        var portfolioCryptocurrencyEntries = await Task.WhenAll(
            _activePortfolioEntries.Select(
                async entry => (await CryptocurrencyResolver.Resolve(entry.Symbol)))
            );

        // fetch market entries of all entries of the portfolio 
        var marketEntries = await PortfolioTrackerStatsSource.GetMarketEntries(
            _activePortfolio.Currency.ToString(), portfolioCryptocurrencyEntries.Select(c => c.Id).ToArray()
            );

        // create a dictionary where a symbol is mapped to a market entry
        var symbolsToMarketEntries = marketEntries.ToDictionary(entry => entry.Symbol, entry => entry);

        // compute portfolio entry summaries 
        var entrySummaries = _activePortfolioEntries.Select(
            portfolioEntry =>
            {
                // find the evaluation of the entry's asset
                var marketEntry = symbolsToMarketEntries.GetValueOrDefault(portfolioEntry.Symbol);

                // fetch all orders of the currently iterated portfolio entry
                var entryMarketOrders = MarketOrderService.GetPortfolioEntryOrders(portfolioEntry.Id);

                // compute the summary of the entry based on market orders
                return SummaryService.GetPortfolioEntrySummary(entryMarketOrders, marketEntry.CurrentPrice);
            }
            ).ToList();

        // compute portfolio's summary based on summaries of it's entries
        _portfolioSummary = SummaryService.GetPortfolioSummary(entrySummaries);

        // if the cost of the summary is zero, set the relative change to zero
        if (_portfolioSummary.Cost == 0)
        {
            _portfolioSummary = _portfolioSummary with {
                RelativeChange = 0
                };
        }

        // compute the total value of the portfolio by summing market values of all entries
        var portfolioTotalMarketValue = entrySummaries.Sum(summary => summary.MarketValue);

        // create portfolio entry table rows
        _portfolioEntryRows = entrySummaries.Zip(_activePortfolioEntries).Select(
            tuple => new PortfolioEntryRow(
                // symbol of the portfolio entry
                tuple.Second.Symbol,
                // current price of the entry's asset 
                symbolsToMarketEntries[tuple.Second.Symbol].CurrentPrice,
                // asset's price change since the last 24h 
                new decimal(symbolsToMarketEntries[tuple.Second.Symbol].PriceChangePercentage24H ?? 0),
                // percentage within the portfolio entry
                portfolioTotalMarketValue > 0 ? (tuple.First.MarketValue / portfolioTotalMarketValue) * 100 : 0,
                // absolute change within the portfolio entry
                tuple.First.AbsoluteChange,
                // market value
                tuple.First.MarketValue,
                // pass the entry id
                tuple.Second.Id
                )
            ).ToList();

        // update the UI
        StateHasChanged();
    }

    public void SelectionChangedEvent(object row)
    {
        if (row != null)
        {
            // entry row has been clicked, open it's detail
            NavigationManager.NavigateTo($"entries/{((PortfolioEntryRow) row).EntryId}");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICryptocurrencyResolver CryptocurrencyResolver { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISummaryService SummaryService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPortfolioTrackerStatsSource PortfolioTrackerStatsSource { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMarketOrderService MarketOrderService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPortfolioEntryService PortfolioEntryService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPortfolioService PortfolioService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591