#pragma checksum "C:\Users\itsybatc\source\repos\OnlineStore\OnlineStore\Pages\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec46473a8d6bee5d488a812fa1ba4a5b19ea29a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OnlineStore.Pages.Pages_Cart), @"mvc.1.0.razor-page", @"/Pages/Cart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Cart.cshtml", typeof(OnlineStore.Pages.Pages_Cart), null)]
namespace OnlineStore.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\itsybatc\source\repos\OnlineStore\OnlineStore\Pages\_ViewImports.cshtml"
using OnlineStore;

#line default
#line hidden
#line 2 "C:\Users\itsybatc\source\repos\OnlineStore\OnlineStore\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec46473a8d6bee5d488a812fa1ba4a5b19ea29a8", @"/Pages/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa4633429b14b6a9ab1f6dc33f423b7eb1287182", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Cart : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private global::OnlineStore.Pages.Pages_Cart.__Generated__CartViewComponentTagHelper __CartViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/apple.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 60, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h2>Big cart component</h2>\r\n");
            EndContext();
#line 8 "C:\Users\itsybatc\source\repos\OnlineStore\OnlineStore\Pages\Cart.cshtml"
     foreach (var product in Model.Cart)
    {

#line default
#line hidden
            BeginContext(159, 138, true);
            WriteLiteral("        <div class=\"level\">\r\n            <div class=\"level-item\">\r\n                <figure class=\"image is-128x128\">\r\n                    ");
            EndContext();
            BeginContext(297, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ec46473a8d6bee5d488a812fa1ba4a5b19ea29a84164", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(329, 142, true);
            WriteLiteral("\r\n                </figure>\r\n            </div>\r\n            <div class=\"level-item\">\r\n                <p class=\"title\">\r\n                    ");
            EndContext();
            BeginContext(472, 12, false);
#line 18 "C:\Users\itsybatc\source\repos\OnlineStore\OnlineStore\Pages\Cart.cshtml"
               Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(484, 101, true);
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n            <div class=\"level-item\">\r\n                <p>");
            EndContext();
            BeginContext(586, 11, false);
#line 22 "C:\Users\itsybatc\source\repos\OnlineStore\OnlineStore\Pages\Cart.cshtml"
              Write(product.Qty);

#line default
#line hidden
            EndContext();
            BeginContext(597, 83, true);
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"level-item\">\r\n                <p>");
            EndContext();
            BeginContext(681, 13, false);
#line 25 "C:\Users\itsybatc\source\repos\OnlineStore\OnlineStore\Pages\Cart.cshtml"
              Write(product.Value);

#line default
#line hidden
            EndContext();
            BeginContext(694, 104, true);
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"level-item\">\r\n\r\n            </div>\r\n\r\n        </div>\r\n");
            EndContext();
#line 32 "C:\Users\itsybatc\source\repos\OnlineStore\OnlineStore\Pages\Cart.cshtml"
    
    }

#line default
#line hidden
            BeginContext(811, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(823, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:cart", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec46473a8d6bee5d488a812fa1ba4a5b19ea29a87024", async() => {
            }
            );
            __CartViewComponentTagHelper = CreateTagHelper<global::OnlineStore.Pages.Pages_Cart.__Generated__CartViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__CartViewComponentTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("Small");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __CartViewComponentTagHelper.view = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("view", __CartViewComponentTagHelper.view, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineStore.Pages.CartModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OnlineStore.Pages.CartModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OnlineStore.Pages.CartModel>)PageContext?.ViewData;
        public OnlineStore.Pages.CartModel Model => ViewData.Model;
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:cart")]
        public class __Generated__CartViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper _helper = null;
            public __Generated__CartViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                _helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public System.String view { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output)
            {
                (_helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var content = await _helper.InvokeAsync("Cart", new { view });
                output.TagName = null;
                output.Content.SetHtmlContent(content);
            }
        }
    }
}
#pragma warning restore 1591
