#pragma checksum "C:\Users\Shayne Maravillo\source\repos\AdvanceWebHayna\AdvanceWebHayna.Web\Views\Product\UpdateDescription.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d097edb8d20a41ab6cffe22d8504498e97a69fe8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_UpdateDescription), @"mvc.1.0.view", @"/Views/Product/UpdateDescription.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/UpdateDescription.cshtml", typeof(AspNetCore.Views_Product_UpdateDescription))]
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
#line 1 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebHayna\AdvanceWebHayna.Web\Views\_ViewImports.cshtml"
using AdvanceWebHayna.Web;

#line default
#line hidden
#line 2 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebHayna\AdvanceWebHayna.Web\Views\_ViewImports.cshtml"
using AdvanceWebHayna.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d097edb8d20a41ab6cffe22d8504498e97a69fe8", @"/Views/Product/UpdateDescription.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0288ab599797c49e962bef6079b299d85d2e859e", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_UpdateDescription : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdvanceWebHayna.Web.ViewModels.Products.UpdateDescriptionViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/home/products/update-description"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebHayna\AdvanceWebHayna.Web\Views\Product\UpdateDescription.cshtml"
  
    ViewData["Title"] = "UpdateDescription";
    Layout = "~/Views/Shared/_PublicLayout.cshtml";

#line default
#line hidden
            BeginContext(181, 30, true);
            WriteLiteral("\r\n<br />\r\n<h3>Update Product \"");
            EndContext();
            BeginContext(212, 10, false);
#line 8 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebHayna\AdvanceWebHayna.Web\Views\Product\UpdateDescription.cshtml"
               Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(222, 65, true);
            WriteLiteral("\"</h3>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        ");
            EndContext();
            BeginContext(287, 522, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6155c6119c5242d389b87fbddf0690d7", async() => {
                BeginContext(351, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(366, 24, false);
#line 13 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebHayna\AdvanceWebHayna.Web\Views\Product\UpdateDescription.cshtml"
       Write(Html.ValidationSummary());

#line default
#line hidden
                EndContext();
                BeginContext(390, 51, true);
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"ProductId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 441, "\"", 466, 1);
#line 14 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebHayna\AdvanceWebHayna.Web\Views\Product\UpdateDescription.cshtml"
WriteAttributeValue("", 449, Model.CategoryId, 449, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(467, 201, true);
                WriteLiteral(" />\r\n            <div class=\"form-group\">\r\n                <label for=\"Description\">Description</label>\r\n                <textarea id=\"description\" name=\"Description\" style=\"height:800px;width:700px;\">");
                EndContext();
                BeginContext(669, 17, false);
#line 17 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebHayna\AdvanceWebHayna.Web\Views\Product\UpdateDescription.cshtml"
                                                                                           Write(Model.Description);

#line default
#line hidden
                EndContext();
                BeginContext(686, 116, true);
                WriteLiteral("</textarea>\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-default\">Submit</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(809, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdvanceWebHayna.Web.ViewModels.Products.UpdateDescriptionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
