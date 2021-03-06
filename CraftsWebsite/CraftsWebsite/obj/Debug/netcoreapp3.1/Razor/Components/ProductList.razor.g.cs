#pragma checksum "D:\CSharpTutorials\CraftsWebsite\CraftsWebsite\Components\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d073928f4251dbe9c1b45b74dd4ff8c7870c11d"
// <auto-generated/>
#pragma warning disable 1591
namespace CraftsWebsite.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\CSharpTutorials\CraftsWebsite\CraftsWebsite\Components\ProductList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CSharpTutorials\CraftsWebsite\CraftsWebsite\Components\ProductList.razor"
using CraftsWebsite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\CSharpTutorials\CraftsWebsite\CraftsWebsite\Components\ProductList.razor"
using CraftsWebsite.Services;

#line default
#line hidden
#nullable disable
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-columns");
#nullable restore
#line 7 "D:\CSharpTutorials\CraftsWebsite\CraftsWebsite\Components\ProductList.razor"
     foreach (var product in ProductService.GetProducts())
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-img");
            __builder.AddAttribute(6, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 10 "D:\CSharpTutorials\CraftsWebsite\CraftsWebsite\Components\ProductList.razor"
                                                                 product.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-body");
            __builder.OpenElement(10, "h5");
            __builder.AddAttribute(11, "class", "card-title");
            __builder.AddContent(12, 
#nullable restore
#line 12 "D:\CSharpTutorials\CraftsWebsite\CraftsWebsite\Components\ProductList.razor"
                                        product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card-footer");
            __builder.OpenElement(15, "small");
            __builder.AddAttribute(16, "class", "text-muted");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "D:\CSharpTutorials\CraftsWebsite\CraftsWebsite\Components\ProductList.razor"
                                  (e => SelectProduct(product.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "data-toggle", "modal");
            __builder.AddAttribute(20, "data-target", "#productModal");
            __builder.AddAttribute(21, "class", "btn btn-primary");
            __builder.AddMarkupContent(22, "\r\n                    More Info\r\n                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 24 "D:\CSharpTutorials\CraftsWebsite\CraftsWebsite\Components\ProductList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n\r\n");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "modal fade");
            __builder.AddAttribute(26, "id", "productModal");
            __builder.AddAttribute(27, "tabindex", "-1");
            __builder.AddAttribute(28, "role", "dialog");
            __builder.AddAttribute(29, "aria-labelledby", "productTitle");
            __builder.AddAttribute(30, "aria-hidden", "true");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(33, "role", "document");
#nullable restore
#line 30 "D:\CSharpTutorials\CraftsWebsite\CraftsWebsite\Components\ProductList.razor"
         if (selectedProduct != null)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "modal-content");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "modal-header");
            __builder.OpenElement(38, "h5");
            __builder.AddAttribute(39, "class", "modal-title");
            __builder.AddAttribute(40, "id", "productTitle");
            __builder.AddContent(41, 
#nullable restore
#line 34 "D:\CSharpTutorials\CraftsWebsite\CraftsWebsite\Components\ProductList.razor"
                                                               selectedProduct.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.AddMarkupContent(43, "<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "modal-body");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "card");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "card-img");
            __builder.AddAttribute(51, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 41 "D:\CSharpTutorials\CraftsWebsite\CraftsWebsite\Components\ProductList.razor"
                                                                             selectedProduct.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                        ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "card-body");
            __builder.OpenElement(55, "p");
            __builder.AddAttribute(56, "class", "card-text");
            __builder.AddContent(57, 
#nullable restore
#line 44 "D:\CSharpTutorials\CraftsWebsite\CraftsWebsite\Components\ProductList.razor"
                                                  selectedProduct.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "modal-footer");
#nullable restore
#line 49 "D:\CSharpTutorials\CraftsWebsite\CraftsWebsite\Components\ProductList.razor"
                     if (voteCount == 0)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(61, "<span>Be the first to vote!</span>");
#nullable restore
#line 52 "D:\CSharpTutorials\CraftsWebsite\CraftsWebsite\Components\ProductList.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(62, "span");
            __builder.AddContent(63, 
#nullable restore
#line 55 "D:\CSharpTutorials\CraftsWebsite\CraftsWebsite\Components\ProductList.razor"
                               voteCount

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(64, " ");
            __builder.AddContent(65, 
#nullable restore
#line 55 "D:\CSharpTutorials\CraftsWebsite\CraftsWebsite\Components\ProductList.razor"
                                          voteLabel

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 56 "D:\CSharpTutorials\CraftsWebsite\CraftsWebsite\Components\ProductList.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "D:\CSharpTutorials\CraftsWebsite\CraftsWebsite\Components\ProductList.razor"
                     for (int i = 1; i <= 5; i++)
                    {
                        var currentStar = i;

                        if (i <= currentRating)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(66, "span");
            __builder.AddAttribute(67, "class", "fa-star fa checked");
            __builder.AddAttribute(68, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "D:\CSharpTutorials\CraftsWebsite\CraftsWebsite\Components\ProductList.razor"
                                                                       (e => SubmitRating(currentStar))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 67 "D:\CSharpTutorials\CraftsWebsite\CraftsWebsite\Components\ProductList.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(69, "span");
            __builder.AddAttribute(70, "class", "fa-star fa");
            __builder.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "D:\CSharpTutorials\CraftsWebsite\CraftsWebsite\Components\ProductList.razor"
                                                               (e => SubmitRating(currentStar))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 71 "D:\CSharpTutorials\CraftsWebsite\CraftsWebsite\Components\ProductList.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 76 "D:\CSharpTutorials\CraftsWebsite\CraftsWebsite\Components\ProductList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n\r\n<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">");
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "D:\CSharpTutorials\CraftsWebsite\CraftsWebsite\Components\ProductList.razor"
 
    Product selectedProduct;
    string selectedProductId;

    void SelectProduct(string productId)
    {
        selectedProductId = productId;
        selectedProduct = ProductService.GetProducts().First(x => x.Id == productId);
        GetCurrentRating();
    }

    int currentRating = 0;
    int voteCount = 0;
    string voteLabel;

    void GetCurrentRating()
    {
        if (selectedProduct.Ratings == null)
        {
            currentRating = 0;
            voteCount = 0;
        }
        else
        {
            voteCount = selectedProduct.Ratings.Count();
            voteLabel = voteCount > 1 ? "Votes" : "Vote";
            currentRating = selectedProduct.Ratings.Sum() / voteCount;
        }

        System.Console.WriteLine($"Current rating for {selectedProduct.Id}: { currentRating }");
    }


    void SubmitRating(int rating)
    {
        System.Console.WriteLine($"Current rating for {selectedProduct.Id}: { rating }");
        ProductService.AddRating(selectedProductId, rating);
        SelectProduct(selectedProductId);


    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileProductsService ProductService { get; set; }
    }
}
#pragma warning restore 1591
