// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Koop.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\AnnaTowpasz\source\repos\Koop\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AnnaTowpasz\source\repos\Koop\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AnnaTowpasz\source\repos\Koop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AnnaTowpasz\source\repos\Koop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AnnaTowpasz\source\repos\Koop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\AnnaTowpasz\source\repos\Koop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\AnnaTowpasz\source\repos\Koop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\AnnaTowpasz\source\repos\Koop\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\AnnaTowpasz\source\repos\Koop\Client\_Imports.razor"
using Koop.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\AnnaTowpasz\source\repos\Koop\Client\_Imports.razor"
using Koop.Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ProductList")]
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 87 "C:\Users\AnnaTowpasz\source\repos\Koop\Client\Pages\ProductList.razor"
            

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Supplier { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
    }

    public List<Product> products { get; set; }

    protected override Task OnInitializedAsync()
    {
        products = new List<Product>();
        Product p1 = new Product() { Id = 1, Name = "Marchewka", Category = "Warzywa", Supplier = "Maszyce", Description = "Marchewka z Maszyc" };
        Product p2 = new Product() { Id = 2, Name = "Kapusta", Category = "Warzywa", Supplier = "Maszyce", Description = "Kapusta z Maszyc" };
        Product p3 = new Product() { Id = 3, Name = "Łuskane orzechy", Category = "Orzechy", Supplier = "Ciocia Kasia", Description = "Orzechy włoskie łuskane" };
        Product p4 = new Product() { Id = 4, Name = "Chleb orkiszowy", Category = "Pieczywo", Supplier = "Jadzia", Description = "Chleb orkiszowy 500 g ciemny" };
        products.Add(p1);
        products.Add(p2);
        products.Add(p3);
        products.Add(p4);

        return base.OnInitializedAsync();
    }

    protected override Task OnAfterRenderAsync(bool firstRender)
    {
        JSRuntime1.InvokeVoidAsync("ProductListScript");
        return base.OnAfterRenderAsync(firstRender);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime1 { get; set; }
    }
}
#pragma warning restore 1591
