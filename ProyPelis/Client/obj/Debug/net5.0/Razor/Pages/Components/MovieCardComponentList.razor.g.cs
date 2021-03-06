#pragma checksum "C:\ProysCicloIII\ProyPelis\Client\Pages\Components\MovieCardComponentList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "444a1907a45f292d93b140d82f00794dc23b7305"
// <auto-generated/>
#pragma warning disable 1591
namespace ProyPelis.Client.Pages.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\ProysCicloIII\ProyPelis\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProysCicloIII\ProyPelis\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ProysCicloIII\ProyPelis\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ProysCicloIII\ProyPelis\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\ProysCicloIII\ProyPelis\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\ProysCicloIII\ProyPelis\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\ProysCicloIII\ProyPelis\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\ProysCicloIII\ProyPelis\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\ProysCicloIII\ProyPelis\Client\_Imports.razor"
using ProyPelis.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\ProysCicloIII\ProyPelis\Client\_Imports.razor"
using ProyPelis.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\ProysCicloIII\ProyPelis\Client\_Imports.razor"
using ProyPelis.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\ProysCicloIII\ProyPelis\Client\_Imports.razor"
using ProyPelis.Client.Services;

#line default
#line hidden
#nullable disable
    public partial class MovieCardComponentList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jumbotron");
            __builder.AddMarkupContent(2, "<h3>Movies List</h3>\r\n    <br>");
#nullable restore
#line 4 "C:\ProysCicloIII\ProyPelis\Client\Pages\Components\MovieCardComponentList.razor"
     foreach (var movie in Movies)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "list-group mb-3");
            __builder.OpenElement(5, "a");
            __builder.AddAttribute(6, "href", "#");
            __builder.AddAttribute(7, "class", "list-group-item list-group-item-action flex-column align-items");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-md-3");
            __builder.OpenElement(12, "img");
            __builder.AddAttribute(13, "src", 
#nullable restore
#line 10 "C:\ProysCicloIII\ProyPelis\Client\Pages\Components\MovieCardComponentList.razor"
                                   movie.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "class", "img-thumbnail");
            __builder.AddAttribute(15, "height", "0px");
            __builder.AddAttribute(16, "width", "200px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col-md-9");
            __builder.OpenElement(20, "h5");
            __builder.AddAttribute(21, "class", "card-title text-center");
            __builder.AddContent(22, 
#nullable restore
#line 13 "C:\ProysCicloIII\ProyPelis\Client\Pages\Components\MovieCardComponentList.razor"
                                                            movie.MovieName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                        <br>\r\n                        ");
            __builder.OpenElement(24, "p");
            __builder.AddAttribute(25, "class", "card-text text-left");
            __builder.AddContent(26, 
#nullable restore
#line 15 "C:\ProysCicloIII\ProyPelis\Client\Pages\Components\MovieCardComponentList.razor"
                                                        movie.Synopsis

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.OpenElement(28, "p");
            __builder.AddAttribute(29, "class", "card-text text-left");
            __builder.AddContent(30, 
#nullable restore
#line 16 "C:\ProysCicloIII\ProyPelis\Client\Pages\Components\MovieCardComponentList.razor"
                                                        movie.Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                        ");
            __builder.OpenElement(32, "p");
            __builder.AddAttribute(33, "class", "card-text text-left");
            __builder.AddContent(34, 
#nullable restore
#line 17 "C:\ProysCicloIII\ProyPelis\Client\Pages\Components\MovieCardComponentList.razor"
                                                        movie.ProductionCompany

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                        ");
            __builder.OpenElement(36, "footer");
            __builder.AddAttribute(37, "class", "blockquote-footer");
            __builder.OpenElement(38, "cite");
            __builder.AddAttribute(39, "class", "text-muted text-center");
            __builder.AddContent(40, 
#nullable restore
#line 19 "C:\ProysCicloIII\ProyPelis\Client\Pages\Components\MovieCardComponentList.razor"
                                                                  movie.ReleaseDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 25 "C:\ProysCicloIII\ProyPelis\Client\Pages\Components\MovieCardComponentList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\ProysCicloIII\ProyPelis\Client\Pages\Components\MovieCardComponentList.razor"
      
    [Parameter] public List<Movie> Movies{get;set;} 

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
