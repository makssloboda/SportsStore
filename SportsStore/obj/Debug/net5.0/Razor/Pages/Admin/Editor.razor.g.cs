#pragma checksum "C:\Local Disk (D)\Projects\C#\ASP\Adam Freeman\SportsSln\SportsStore\Pages\Admin\Editor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1e9fe7fbb335adee78de6ced7644606a2e45a68"
// <auto-generated/>
#pragma warning disable 1591
namespace SportsStore.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Local Disk (D)\Projects\C#\ASP\Adam Freeman\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Local Disk (D)\Projects\C#\ASP\Adam Freeman\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Local Disk (D)\Projects\C#\ASP\Adam Freeman\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Local Disk (D)\Projects\C#\ASP\Adam Freeman\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Local Disk (D)\Projects\C#\ASP\Adam Freeman\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Local Disk (D)\Projects\C#\ASP\Adam Freeman\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using SportsStore.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/products/edit/{id:long}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/products/create")]
    public partial class Editor : OwningComponentBase<IStoreRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    div.validation-message {\r\n        color: rgb(220, 53, 69);\r\n        font-weight: 500\r\n    }\r\n</style>\r\n\r\n");
            __builder.OpenElement(1, "h3");
            __builder.AddAttribute(2, "class", "bg-" + (
#nullable restore
#line 12 "C:\Local Disk (D)\Projects\C#\ASP\Adam Freeman\SportsSln\SportsStore\Pages\Admin\Editor.razor"
               ThemeColor

#line default
#line hidden
#nullable disable
            ) + " text-white" + " text-center" + " p-1");
            __builder.AddContent(3, 
#nullable restore
#line 12 "C:\Local Disk (D)\Projects\C#\ASP\Adam Freeman\SportsSln\SportsStore\Pages\Admin\Editor.razor"
                                                       TitleText

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " a Product");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "C:\Local Disk (D)\Projects\C#\ASP\Adam Freeman\SportsSln\SportsStore\Pages\Admin\Editor.razor"
                 Product

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "C:\Local Disk (D)\Projects\C#\ASP\Adam Freeman\SportsSln\SportsStore\Pages\Admin\Editor.razor"
                                         SaveProduct

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
#nullable restore
#line 16 "C:\Local Disk (D)\Projects\C#\ASP\Adam Freeman\SportsSln\SportsStore\Pages\Admin\Editor.razor"
     if (Product.ProductID != 0)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group");
                __builder2.AddMarkupContent(13, "<label>ID</label>\r\n            ");
                __builder2.OpenElement(14, "input");
                __builder2.AddAttribute(15, "class", "form-control");
                __builder2.AddAttribute(16, "disabled");
                __builder2.AddAttribute(17, "value", 
#nullable restore
#line 20 "C:\Local Disk (D)\Projects\C#\ASP\Adam Freeman\SportsSln\SportsStore\Pages\Admin\Editor.razor"
                                                         Product.ProductID

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 22 "C:\Local Disk (D)\Projects\C#\ASP\Adam Freeman\SportsSln\SportsStore\Pages\Admin\Editor.razor"
    }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group");
                __builder2.AddMarkupContent(20, "<label>Name</label>\r\n        ");
                __Blazor.SportsStore.Pages.Admin.Editor.TypeInference.CreateValidationMessage_0(__builder2, 21, 22, 
#nullable restore
#line 25 "C:\Local Disk (D)\Projects\C#\ASP\Adam Freeman\SportsSln\SportsStore\Pages\Admin\Editor.razor"
                                  () => Product.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "class", "form-control");
                __builder2.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Local Disk (D)\Projects\C#\ASP\Adam Freeman\SportsSln\SportsStore\Pages\Admin\Editor.razor"
                                                     Product.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.Name = __value, Product.Name))));
                __builder2.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Product.Name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n    ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-group");
                __builder2.AddMarkupContent(32, "<label>Description</label>\r\n        ");
                __Blazor.SportsStore.Pages.Admin.Editor.TypeInference.CreateValidationMessage_1(__builder2, 33, 34, 
#nullable restore
#line 30 "C:\Local Disk (D)\Projects\C#\ASP\Adam Freeman\SportsSln\SportsStore\Pages\Admin\Editor.razor"
                                  () => Product.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(35, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(36);
                __builder2.AddAttribute(37, "class", "form-control");
                __builder2.AddAttribute(38, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Local Disk (D)\Projects\C#\ASP\Adam Freeman\SportsSln\SportsStore\Pages\Admin\Editor.razor"
                                                     Product.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.Description = __value, Product.Description))));
                __builder2.AddAttribute(40, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Product.Description));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n    ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-group");
                __builder2.AddMarkupContent(44, "<label>Category</label>\r\n        ");
                __Blazor.SportsStore.Pages.Admin.Editor.TypeInference.CreateValidationMessage_2(__builder2, 45, 46, 
#nullable restore
#line 35 "C:\Local Disk (D)\Projects\C#\ASP\Adam Freeman\SportsSln\SportsStore\Pages\Admin\Editor.razor"
                                  () => Product.Category

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(47, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(48);
                __builder2.AddAttribute(49, "class", "form-control");
                __builder2.AddAttribute(50, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\Local Disk (D)\Projects\C#\ASP\Adam Freeman\SportsSln\SportsStore\Pages\Admin\Editor.razor"
                                                     Product.Category

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.Category = __value, Product.Category))));
                __builder2.AddAttribute(52, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Product.Category));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n    ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "form-group");
                __builder2.AddMarkupContent(56, "<label>Price</label>\r\n        ");
                __Blazor.SportsStore.Pages.Admin.Editor.TypeInference.CreateValidationMessage_3(__builder2, 57, 58, 
#nullable restore
#line 40 "C:\Local Disk (D)\Projects\C#\ASP\Adam Freeman\SportsSln\SportsStore\Pages\Admin\Editor.razor"
                                  () => Product.Price

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(59, "\r\n        ");
                __Blazor.SportsStore.Pages.Admin.Editor.TypeInference.CreateInputNumber_4(__builder2, 60, 61, "form-control", 62, 
#nullable restore
#line 41 "C:\Local Disk (D)\Projects\C#\ASP\Adam Freeman\SportsSln\SportsStore\Pages\Admin\Editor.razor"
                                                       Product.Price

#line default
#line hidden
#nullable disable
                , 63, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.Price = __value, Product.Price)), 64, () => Product.Price);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n    ");
                __builder2.OpenElement(66, "button");
                __builder2.AddAttribute(67, "type", "submit");
                __builder2.AddAttribute(68, "class", "btn" + " btn-" + (
#nullable restore
#line 43 "C:\Local Disk (D)\Projects\C#\ASP\Adam Freeman\SportsSln\SportsStore\Pages\Admin\Editor.razor"
                                          ThemeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(69, "Save");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(71);
                __builder2.AddAttribute(72, "class", "btn btn-secondary");
                __builder2.AddAttribute(73, "href", "/admin/products");
                __builder2.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(75, "Cancel");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Local Disk (D)\Projects\C#\ASP\Adam Freeman\SportsSln\SportsStore\Pages\Admin\Editor.razor"
 
    public IStoreRepository Repository => Service;

    [Inject]
    public NavigationManager NavManager { get; set; }

    [Parameter]
    public long Id { get; set; } = 0;

    public Product Product { get; set; } = new Product();

    protected override void OnParametersSet()
    {
        if (Id != 0)
        {
            Product = Repository.Products.FirstOrDefault(p => p.ProductID == Id);
        }
    }

    public void SaveProduct()
    {
        if (Id == 0)
        {
            Repository.CreateProduct(Product);
        }
        else
        {
            Repository.SaveProduct(Product);
        }
        NavManager.NavigateTo("/admin/products");
    }

    public string ThemeColor => Id == 0 ? "primary" : "warning";
    public string TitleText => Id == 0 ? "Create" : "Edit";

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.SportsStore.Pages.Admin.Editor
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
