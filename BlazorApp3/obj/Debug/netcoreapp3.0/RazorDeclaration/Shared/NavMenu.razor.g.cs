#pragma checksum "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "318aef9fe1022628a4d6b71dadf58d3a15d1847e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp3.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\_Imports.razor"
using BlazorApp3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\_Imports.razor"
using BlazorApp3.Shared;

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
#line 42 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\Shared\NavMenu.razor"
       
    bool collapseNavMenu = true;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
