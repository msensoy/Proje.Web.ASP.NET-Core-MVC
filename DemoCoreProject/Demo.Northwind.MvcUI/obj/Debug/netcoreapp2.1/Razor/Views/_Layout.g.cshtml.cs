#pragma checksum "C:\Users\TOSHIBA\Documents\GitHub\ASP.NET-Core-MVC\DemoCoreProject\Demo.Northwind.MvcUI\Views\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e85dd299368ae1e2cc4de037fdf1bb467e656f10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views__Layout), @"mvc.1.0.view", @"/Views/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/_Layout.cshtml", typeof(AspNetCore.Views__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e85dd299368ae1e2cc4de037fdf1bb467e656f10", @"/Views/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0824befe32c1c8d4d661b0778a0b9185b6df925f", @"/Views/_ViewImports.cshtml")]
    public class Views__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(27, 526, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2eca92e6e44b4f939c0aa1108b7c2458", async() => {
                BeginContext(33, 72, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
                EndContext();
                BeginContext(106, 13, false);
#line 6 "C:\Users\TOSHIBA\Documents\GitHub\ASP.NET-Core-MVC\DemoCoreProject\Demo.Northwind.MvcUI\Views\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(119, 427, true);
                WriteLiteral(@"</title>
    <link href=""/node_modules/bootstrap/dist/css/bootstrap.css"" rel=""stylesheet"" />
    <script src=""/node_modules/jquery/dist/jquery.min.js""></script>
    <script src=""/node_modules/bootstrap/dist/js/bootstrap.js""></script>
    <script src=""/node_modules/jquery-validation/dist/jquery.validate.js""></script>
    <script src=""/node_modules/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(553, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(555, 2077, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f8d2206cbc647388d0c6029be05768e", async() => {
                BeginContext(561, 1044, true);
                WriteLiteral(@"
    <div class=""col-md-12"">
        <nav class=""navbar navbar-default"">
            <div class=""container-fluid"">
                <!-- Brand and toggle get grouped for better mobile display -->
                <div class=""navbar-header"">
                    <button type=""button"" class=""navbar-toggle collapsed"" data-toggle=""collapse"" data-target=""#bs-example-navbar-collapse-1"" aria-expanded=""false"">
                        <span class=""sr-only"">Toggle navigation</span>
                        <span class=""icon-bar""></span>
                        <span class=""icon-bar""></span>
                        <span class=""icon-bar""></span>
                    </button>
                    <a class=""navbar-brand"" href=""#"">Northwind</a>
                </div>

                <!-- Collect the nav links, forms, and other content for toggling -->
                <div class=""collapse navbar-collapse"" id=""bs-example-navbar-collapse-1"">
                    <ul class=""nav navbar-nav"">
                       ");
                WriteLiteral(" <li class=\"active\">");
                EndContext();
                BeginContext(1605, 94, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b49c84a13f54c93a1b0355e179ea7a6", async() => {
                    BeginContext(1652, 43, true);
                    WriteLiteral("Admin<span class=\"sr-only\">(current)</span>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1699, 358, true);
                WriteLiteral(@"</li>
                    </ul>
                    <ul class=""nav navbar-nav navbar-right"">
                        <li class=""dropdown"">
                            <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">Your Cart <span class=""caret""></span></a>
                            ");
                EndContext();
                BeginContext(2058, 42, false);
#line 36 "C:\Users\TOSHIBA\Documents\GitHub\ASP.NET-Core-MVC\DemoCoreProject\Demo.Northwind.MvcUI\Views\_Layout.cshtml"
                       Write(await Component.InvokeAsync("CartSummary"));

#line default
#line hidden
                EndContext();
                BeginContext(2100, 220, true);
                WriteLiteral("\r\n                        </li>\r\n                    </ul>\r\n                </div><!-- /.navbar-collapse -->\r\n            </div><!-- /.container-fluid -->\r\n        </nav>\r\n    </div>\r\n    <div class=\"col-md-2\">\r\n        ");
                EndContext();
                BeginContext(2321, 43, false);
#line 44 "C:\Users\TOSHIBA\Documents\GitHub\ASP.NET-Core-MVC\DemoCoreProject\Demo.Northwind.MvcUI\Views\_Layout.cshtml"
   Write(await Component.InvokeAsync("CategoryList"));

#line default
#line hidden
                EndContext();
                BeginContext(2364, 43, true);
                WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-10\">\r\n");
                EndContext();
#line 47 "C:\Users\TOSHIBA\Documents\GitHub\ASP.NET-Core-MVC\DemoCoreProject\Demo.Northwind.MvcUI\Views\_Layout.cshtml"
         if (TempData["message"] != null)
        {

#line default
#line hidden
                BeginContext(2461, 55, true);
                WriteLiteral("            <div class=\"alert alert-info\" role=\"alert\">");
                EndContext();
                BeginContext(2517, 19, false);
#line 49 "C:\Users\TOSHIBA\Documents\GitHub\ASP.NET-Core-MVC\DemoCoreProject\Demo.Northwind.MvcUI\Views\_Layout.cshtml"
                                                  Write(TempData["message"]);

#line default
#line hidden
                EndContext();
                BeginContext(2536, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
#line 50 "C:\Users\TOSHIBA\Documents\GitHub\ASP.NET-Core-MVC\DemoCoreProject\Demo.Northwind.MvcUI\Views\_Layout.cshtml"
        }

#line default
#line hidden
                BeginContext(2555, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(2564, 12, false);
#line 51 "C:\Users\TOSHIBA\Documents\GitHub\ASP.NET-Core-MVC\DemoCoreProject\Demo.Northwind.MvcUI\Views\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(2576, 49, true);
                WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-12\"></div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2632, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
