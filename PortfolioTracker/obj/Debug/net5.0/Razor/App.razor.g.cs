#pragma checksum "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "650a6f2163a0add7e0a070923b9b6c258180d374"
// <auto-generated/>
#pragma warning disable 1591
namespace PortfolioTracker
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
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(0);
            __builder.AddAttribute(1, "AppAssembly", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 1 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\App.razor"
                      typeof(Program).Assembly

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "PreferExactMatches", 
#nullable restore
#line 1 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\App.razor"
                                                                     true

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder2) => {
                __builder2.OpenComponent<MatBlazor.MatThemeProvider>(4);
                __builder2.AddAttribute(5, "Theme", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MatBlazor.MatTheme>(
#nullable restore
#line 3 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\App.razor"
                                 appTheme

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.RouteView>(7);
                    __builder3.AddAttribute(8, "RouteData", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 4 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\App.razor"
                                   routeData

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(9, "DefaultLayout", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 4 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\App.razor"
                                                              typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(10, "\n            ");
                    __builder3.OpenComponent<MatBlazor.MatPortalHost>(11);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(12, "\n            ");
                    __builder3.OpenComponent<MatBlazor.MatToastContainer>(13);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(14, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.MatThemeProvider>(15);
                __builder2.AddAttribute(16, "Theme", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MatBlazor.MatTheme>(
#nullable restore
#line 10 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\App.razor"
                                 appTheme

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(18);
                    __builder3.AddAttribute(19, "Layout", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 11 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\App.razor"
                                 typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(21, "div");
                        __builder4.AddAttribute(22, "class", "mat-layout-grid mat-layout-grid-align-center");
                        __builder4.OpenElement(23, "div");
                        __builder4.AddAttribute(24, "class", "mat-layout-grid-inner center");
                        __builder4.AddMarkupContent(25, "<div class=\"mat-layout-grid-cell mat-layout-grid-cell-span-2\"></div>\n                        ");
                        __builder4.OpenElement(26, "div");
                        __builder4.AddAttribute(27, "class", "mat-layout-grid-cell mat-layout-grid-cell-span-8");
                        __builder4.OpenComponent<MatBlazor.MatPaper>(28);
                        __builder4.AddAttribute(29, "Elevation", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 17 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\App.razor"
                                                 2

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(30, "style", "padding:1em");
                        __builder4.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(32, "<span>There is nothing at this address.</span>");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(33, "\n                        <div class=\"mat-layout-grid-cell mat-layout-grid-cell-span-2\"></div>");
                        __builder4.CloseElement();
                        __builder4.CloseElement();
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
#line 31 "D:\Ravi\New Changes\PortfolioTracker\PortfolioTracker\App.razor"
 
    // to be used as application's theme
    MatTheme appTheme = new()
    {
        Primary = MatThemeColors.Teal._400.Value
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591