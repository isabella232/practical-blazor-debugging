#pragma checksum "c:\Code\GitHub\Apress.Videos.Debugging.Blazor\DebuggingFeatures\DebuggingFeatures.Components\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67099726f7960120f45e9cc6d8a4a01130165437"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DebuggingFeatures.Components.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Code\GitHub\Apress.Videos.Debugging.Blazor\DebuggingFeatures\DebuggingFeatures.Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Code\GitHub\Apress.Videos.Debugging.Blazor\DebuggingFeatures\DebuggingFeatures.Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Code\GitHub\Apress.Videos.Debugging.Blazor\DebuggingFeatures\DebuggingFeatures.Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Code\GitHub\Apress.Videos.Debugging.Blazor\DebuggingFeatures\DebuggingFeatures.Components\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Code\GitHub\Apress.Videos.Debugging.Blazor\DebuggingFeatures\DebuggingFeatures.Components\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Code\GitHub\Apress.Videos.Debugging.Blazor\DebuggingFeatures\DebuggingFeatures.Components\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Code\GitHub\Apress.Videos.Debugging.Blazor\DebuggingFeatures\DebuggingFeatures.Components\_Imports.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Code\GitHub\Apress.Videos.Debugging.Blazor\DebuggingFeatures\DebuggingFeatures.Components\_Imports.razor"
using DebuggingFeatures.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Code\GitHub\Apress.Videos.Debugging.Blazor\DebuggingFeatures\DebuggingFeatures.Components\_Imports.razor"
using DebuggingFeatures.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Code\GitHub\Apress.Videos.Debugging.Blazor\DebuggingFeatures\DebuggingFeatures.Components\_Imports.razor"
using DebuggingFeatures.Components.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "c:\Code\GitHub\Apress.Videos.Debugging.Blazor\DebuggingFeatures\DebuggingFeatures.Components\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
