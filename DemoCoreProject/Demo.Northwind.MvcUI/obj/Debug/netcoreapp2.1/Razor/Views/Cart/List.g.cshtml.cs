#pragma checksum "C:\Users\TOSHIBA\Documents\GitHub\ASP.NET-Core-MVC\DemoCoreProject\Demo.Northwind.MvcUI\Views\Cart\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8c3d83b878258c81482830a7a3737d7d258983e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_List), @"mvc.1.0.view", @"/Views/Cart/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/List.cshtml", typeof(AspNetCore.Views_Cart_List))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8c3d83b878258c81482830a7a3737d7d258983e", @"/Views/Cart/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0824befe32c1c8d4d661b0778a0b9185b6df925f", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Demo.Northwind.MvcUI.Models.CartListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-xs btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-xs btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Complete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-xs btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\TOSHIBA\Documents\GitHub\ASP.NET-Core-MVC\DemoCoreProject\Demo.Northwind.MvcUI\Views\Cart\List.cshtml"
  
    ViewBag.Title = "title";
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
            BeginContext(133, 205, true);
            WriteLiteral("\r\n<h2>Your Cart</h2>\r\n<table class=\"table\">\r\n    <tr>\r\n        <td>Product Name</td>\r\n        <td>Unit Price</td>\r\n        <td>Units In Stock</td>\r\n        <td>Quantity</td>\r\n        <td></td>\r\n    </tr>\r\n");
            EndContext();
#line 17 "C:\Users\TOSHIBA\Documents\GitHub\ASP.NET-Core-MVC\DemoCoreProject\Demo.Northwind.MvcUI\Views\Cart\List.cshtml"
     foreach (var item in Model.Cart.CartLines)
    {

#line default
#line hidden
            BeginContext(394, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(425, 24, false);
#line 20 "C:\Users\TOSHIBA\Documents\GitHub\ASP.NET-Core-MVC\DemoCoreProject\Demo.Northwind.MvcUI\Views\Cart\List.cshtml"
           Write(item.Product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(449, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(473, 22, false);
#line 21 "C:\Users\TOSHIBA\Documents\GitHub\ASP.NET-Core-MVC\DemoCoreProject\Demo.Northwind.MvcUI\Views\Cart\List.cshtml"
           Write(item.Product.UnitPrice);

#line default
#line hidden
            EndContext();
            BeginContext(495, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(519, 25, false);
#line 22 "C:\Users\TOSHIBA\Documents\GitHub\ASP.NET-Core-MVC\DemoCoreProject\Demo.Northwind.MvcUI\Views\Cart\List.cshtml"
           Write(item.Product.UnitsInStock);

#line default
#line hidden
            EndContext();
            BeginContext(544, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(568, 13, false);
#line 23 "C:\Users\TOSHIBA\Documents\GitHub\ASP.NET-Core-MVC\DemoCoreProject\Demo.Northwind.MvcUI\Views\Cart\List.cshtml"
           Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(581, 42, true);
            WriteLiteral("</td>\r\n            <td class=\"text-right\">");
            EndContext();
            BeginContext(623, 190, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34c8d600c77f492dad7c42ed4bd3e6cc", async() => {
                BeginContext(744, 65, true);
                WriteLiteral("<span class=\"glyphicon glyphicon-remove\"></span> remove from cart");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 24 "C:\Users\TOSHIBA\Documents\GitHub\ASP.NET-Core-MVC\DemoCoreProject\Demo.Northwind.MvcUI\Views\Cart\List.cshtml"
                                                                                                                       WriteLiteral(item.Product.ProductId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(813, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 26 "C:\Users\TOSHIBA\Documents\GitHub\ASP.NET-Core-MVC\DemoCoreProject\Demo.Northwind.MvcUI\Views\Cart\List.cshtml"
    }

#line default
#line hidden
            BeginContext(842, 199, true);
            WriteLiteral("    <tr>\r\n        <td></td>\r\n        <td></td>\r\n        <td></td>\r\n        <td>\r\n            <h3>Total</h3>\r\n        </td>\r\n        <td class=\"text-right\">\r\n            <h3>\r\n                <strong>");
            EndContext();
            BeginContext(1042, 16, false);
#line 36 "C:\Users\TOSHIBA\Documents\GitHub\ASP.NET-Core-MVC\DemoCoreProject\Demo.Northwind.MvcUI\Views\Cart\List.cshtml"
                   Write(Model.Cart.Total);

#line default
#line hidden
            EndContext();
            BeginContext(1058, 152, true);
            WriteLiteral("</strong>\r\n            </h3>\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td> </td>\r\n        <td> </td>\r\n        <td> </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1210, 187, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "096453ae20db4b8aa0b7493c38abc9e7", async() => {
                BeginContext(1288, 105, true);
                WriteLiteral("\r\n                <span class=\"glyphicon glyphicon-shopping-cart\"></span> Continue Shopping\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1397, 62, true);
            WriteLiteral("\r\n        </td>\r\n        <td class=\"text-right\">\r\n            ");
            EndContext();
            BeginContext(1459, 184, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "260db0e467ef4872a9c210be6b845f70", async() => {
                BeginContext(1537, 102, true);
                WriteLiteral("\r\n                <span class=\"glyphicon glyphicon-shopping-play\"></span> Go To Checkout\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1643, 36, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n</table>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Demo.Northwind.MvcUI.Models.CartListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
