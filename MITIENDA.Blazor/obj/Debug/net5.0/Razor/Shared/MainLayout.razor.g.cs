#pragma checksum "C:\SIEMPRE.NET\CURSO\PROYECTO TIENDA\MITIENDA.Blazor\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "019fe2f1a773f147576720801de8c80bf256df89"
// <auto-generated/>
#pragma warning disable 1591
namespace MITIENDA.Blazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\SIEMPRE.NET\CURSO\PROYECTO TIENDA\MITIENDA.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\SIEMPRE.NET\CURSO\PROYECTO TIENDA\MITIENDA.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\SIEMPRE.NET\CURSO\PROYECTO TIENDA\MITIENDA.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\SIEMPRE.NET\CURSO\PROYECTO TIENDA\MITIENDA.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\SIEMPRE.NET\CURSO\PROYECTO TIENDA\MITIENDA.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\SIEMPRE.NET\CURSO\PROYECTO TIENDA\MITIENDA.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\SIEMPRE.NET\CURSO\PROYECTO TIENDA\MITIENDA.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\SIEMPRE.NET\CURSO\PROYECTO TIENDA\MITIENDA.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\SIEMPRE.NET\CURSO\PROYECTO TIENDA\MITIENDA.Blazor\_Imports.razor"
using MITIENDA.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\SIEMPRE.NET\CURSO\PROYECTO TIENDA\MITIENDA.Blazor\_Imports.razor"
using MITIENDA.Blazor.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-x7nuiavevg");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-x7nuiavevg");
            __builder.OpenComponent<MITIENDA.Blazor.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-x7nuiavevg");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-x7nuiavevg><span b-x7nuiavevg>Nombre de usuario</span>\r\n            <a href=\"/Account/login\" b-x7nuiavevg>Login</a></div>\r\n\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-x7nuiavevg");
            __builder.AddContent(15, 
#nullable restore
#line 15 "C:\SIEMPRE.NET\CURSO\PROYECTO TIENDA\MITIENDA.Blazor\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
