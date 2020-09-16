#pragma checksum "C:\Code\GitHub\Apress.Videos.Debugging.Blazor\DebuggingFeatures\DebuggingFeatures.Components\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80d61ebdba97942bba4beab5e156b38ab2fcf9f1"
// <auto-generated/>
#pragma warning disable 1591
namespace DebuggingFeatures.Components.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Code\GitHub\Apress.Videos.Debugging.Blazor\DebuggingFeatures\DebuggingFeatures.Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Code\GitHub\Apress.Videos.Debugging.Blazor\DebuggingFeatures\DebuggingFeatures.Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Code\GitHub\Apress.Videos.Debugging.Blazor\DebuggingFeatures\DebuggingFeatures.Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Code\GitHub\Apress.Videos.Debugging.Blazor\DebuggingFeatures\DebuggingFeatures.Components\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Code\GitHub\Apress.Videos.Debugging.Blazor\DebuggingFeatures\DebuggingFeatures.Components\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Code\GitHub\Apress.Videos.Debugging.Blazor\DebuggingFeatures\DebuggingFeatures.Components\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Code\GitHub\Apress.Videos.Debugging.Blazor\DebuggingFeatures\DebuggingFeatures.Components\_Imports.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Code\GitHub\Apress.Videos.Debugging.Blazor\DebuggingFeatures\DebuggingFeatures.Components\_Imports.razor"
using DebuggingFeatures.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Code\GitHub\Apress.Videos.Debugging.Blazor\DebuggingFeatures\DebuggingFeatures.Components\_Imports.razor"
using DebuggingFeatures.Components.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Code\GitHub\Apress.Videos.Debugging.Blazor\DebuggingFeatures\DebuggingFeatures.Components\Pages\FetchData.razor"
using DebuggingFeatures.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from the server.</p>\r\n\r\n");
#nullable restore
#line 11 "C:\Code\GitHub\Apress.Videos.Debugging.Blazor\DebuggingFeatures\DebuggingFeatures.Components\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 14 "C:\Code\GitHub\Apress.Videos.Debugging.Blazor\DebuggingFeatures\DebuggingFeatures.Components\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th>Date</th>\r\n                <th>Temp. (C)</th>\r\n                <th>Temp. (F)</th>\r\n                <th>Summary</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 27 "C:\Code\GitHub\Apress.Videos.Debugging.Blazor\DebuggingFeatures\DebuggingFeatures.Components\Pages\FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 30 "C:\Code\GitHub\Apress.Videos.Debugging.Blazor\DebuggingFeatures\DebuggingFeatures.Components\Pages\FetchData.razor"
                         forecast.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 31 "C:\Code\GitHub\Apress.Videos.Debugging.Blazor\DebuggingFeatures\DebuggingFeatures.Components\Pages\FetchData.razor"
                         forecast.TemperatureC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 32 "C:\Code\GitHub\Apress.Videos.Debugging.Blazor\DebuggingFeatures\DebuggingFeatures.Components\Pages\FetchData.razor"
                         forecast.TemperatureF

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 33 "C:\Code\GitHub\Apress.Videos.Debugging.Blazor\DebuggingFeatures\DebuggingFeatures.Components\Pages\FetchData.razor"
                         forecast.Summary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 35 "C:\Code\GitHub\Apress.Videos.Debugging.Blazor\DebuggingFeatures\DebuggingFeatures.Components\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
            __builder.AddContent(30, "    ");
            __builder.OpenElement(31, "div");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Code\GitHub\Apress.Videos.Debugging.Blazor\DebuggingFeatures\DebuggingFeatures.Components\Pages\FetchData.razor"
                           DemoObjectID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, "Object ID");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 40 "C:\Code\GitHub\Apress.Videos.Debugging.Blazor\DebuggingFeatures\DebuggingFeatures.Components\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Code\GitHub\Apress.Videos.Debugging.Blazor\DebuggingFeatures\DebuggingFeatures.Components\Pages\FetchData.razor"
       
    private IEnumerable<WeatherForecast> forecasts;

    protected override async Task OnInitializedAsync()
    {
      forecasts = await weatherService.GetForecastAsync(DateTime.Now);

      WeatherForecast first = forecasts.First();

      foreach(var forecast in forecasts)
      {
        try
        {
          forecastProcessor.Process(forecast);
        }
        catch(Exception ex)
        {
          string msg = ex.Message;
        }
      }
    }

    private void DemoObjectID()
    {

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherProcessor forecastProcessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWeatherForecastService weatherService { get; set; }
    }
}
#pragma warning restore 1591