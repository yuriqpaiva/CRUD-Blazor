#pragma checksum "/Volumes/HDD/macOs/Faculdade/Programação Web/blazor_DB/Shared/MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8837edcfa5b03aa0567fc3c7aad751f1a30b065a"
// <auto-generated/>
#pragma warning disable 1591
namespace blazor_DB.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Volumes/HDD/macOs/Faculdade/Programação Web/blazor_DB/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Volumes/HDD/macOs/Faculdade/Programação Web/blazor_DB/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Volumes/HDD/macOs/Faculdade/Programação Web/blazor_DB/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Volumes/HDD/macOs/Faculdade/Programação Web/blazor_DB/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Volumes/HDD/macOs/Faculdade/Programação Web/blazor_DB/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Volumes/HDD/macOs/Faculdade/Programação Web/blazor_DB/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Volumes/HDD/macOs/Faculdade/Programação Web/blazor_DB/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Volumes/HDD/macOs/Faculdade/Programação Web/blazor_DB/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Volumes/HDD/macOs/Faculdade/Programação Web/blazor_DB/_Imports.razor"
using blazor_DB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Volumes/HDD/macOs/Faculdade/Programação Web/blazor_DB/_Imports.razor"
using blazor_DB.Shared;

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
            __builder.AddAttribute(2, "b-7mjokoozi7");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-7mjokoozi7");
            __builder.OpenComponent<blazor_DB.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-7mjokoozi7");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-7mjokoozi7><a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\" b-7mjokoozi7><button type=\"button\" class=\"btn btn-light\" b-7mjokoozi7>Sobre</button></a></div>\r\n\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-7mjokoozi7");
            __builder.AddContent(15, 
#nullable restore
#line 15 "/Volumes/HDD/macOs/Faculdade/Programação Web/blazor_DB/Shared/MainLayout.razor"
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
