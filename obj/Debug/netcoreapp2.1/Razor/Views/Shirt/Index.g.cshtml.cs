#pragma checksum "C:\Users\Formation\Desktop\20486D-DevelopingASPNETMVCWebApplications-master\Allfiles\Mod10\Labfiles\01_ShirtStore_begin\ShirtStoreWebsite\Views\Shirt\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c2df442324ced30c30a44b386b5472fab9726aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shirt_Index), @"mvc.1.0.view", @"/Views/Shirt/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shirt/Index.cshtml", typeof(AspNetCore.Views_Shirt_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c2df442324ced30c30a44b386b5472fab9726aa", @"/Views/Shirt/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shirt_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShirtStoreWebsite.Models.Shirt>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_NewShirtForm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\Formation\Desktop\20486D-DevelopingASPNETMVCWebApplications-master\Allfiles\Mod10\Labfiles\01_ShirtStore_begin\ShirtStoreWebsite\Views\Shirt\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(76, 24, true);
            WriteLiteral("<!DOCTYPE html>\n\n<html>\n");
            EndContext();
            BeginContext(100, 280, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15ebbf8c1f8d48a5aeb85de9043d1c43", async() => {
                BeginContext(106, 94, true);
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>Shirt Store</title>\n    ");
                EndContext();
                BeginContext(200, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "30e63f6683614c1da23aa0dec333bf82", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(264, 109, true);
                WriteLiteral("\n    <link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.1.0/css/bootstrap.min.css\">\n");
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
            BeginContext(380, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(381, 2246, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c88f28848e1448e29a0d51cc736cbeae", async() => {
                BeginContext(387, 412, true);
                WriteLiteral(@"
    <div class=""container"">
        <header class=""header"">
            <h1 class=""text-center"">Shirt Store</h1>
        </header>
        <div class=""row"">
            <div class=""col-sm"">
                <h3 class=""text-center"">Shirts in stock</h3>
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>
                                ");
                EndContext();
                BeginContext(800, 40, false);
#line 27 "C:\Users\Formation\Desktop\20486D-DevelopingASPNETMVCWebApplications-master\Allfiles\Mod10\Labfiles\01_ShirtStore_begin\ShirtStoreWebsite\Views\Shirt\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Size));

#line default
#line hidden
                EndContext();
                BeginContext(840, 100, true);
                WriteLiteral("\n                            </th>\n                            <th>\n                                ");
                EndContext();
                BeginContext(941, 41, false);
#line 30 "C:\Users\Formation\Desktop\20486D-DevelopingASPNETMVCWebApplications-master\Allfiles\Mod10\Labfiles\01_ShirtStore_begin\ShirtStoreWebsite\Views\Shirt\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Color));

#line default
#line hidden
                EndContext();
                BeginContext(982, 100, true);
                WriteLiteral("\n                            </th>\n                            <th>\n                                ");
                EndContext();
                BeginContext(1083, 41, false);
#line 33 "C:\Users\Formation\Desktop\20486D-DevelopingASPNETMVCWebApplications-master\Allfiles\Mod10\Labfiles\01_ShirtStore_begin\ShirtStoreWebsite\Views\Shirt\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
                EndContext();
                BeginContext(1124, 100, true);
                WriteLiteral("\n                            </th>\n                            <th>\n                                ");
                EndContext();
                BeginContext(1225, 39, false);
#line 36 "C:\Users\Formation\Desktop\20486D-DevelopingASPNETMVCWebApplications-master\Allfiles\Mod10\Labfiles\01_ShirtStore_begin\ShirtStoreWebsite\Views\Shirt\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Tax));

#line default
#line hidden
                EndContext();
                BeginContext(1264, 160, true);
                WriteLiteral("\n                            </th>\n                            <th></th>\n                        </tr>\n                    </thead>\n                    <tbody>\n");
                EndContext();
#line 42 "C:\Users\Formation\Desktop\20486D-DevelopingASPNETMVCWebApplications-master\Allfiles\Mod10\Labfiles\01_ShirtStore_begin\ShirtStoreWebsite\Views\Shirt\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
                BeginContext(1503, 94, true);
                WriteLiteral("                        <tr>\n                            <td>\n                                ");
                EndContext();
                BeginContext(1598, 39, false);
#line 46 "C:\Users\Formation\Desktop\20486D-DevelopingASPNETMVCWebApplications-master\Allfiles\Mod10\Labfiles\01_ShirtStore_begin\ShirtStoreWebsite\Views\Shirt\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Size));

#line default
#line hidden
                EndContext();
                BeginContext(1637, 100, true);
                WriteLiteral("\n                            </td>\n                            <td>\n                                ");
                EndContext();
                BeginContext(1738, 40, false);
#line 49 "C:\Users\Formation\Desktop\20486D-DevelopingASPNETMVCWebApplications-master\Allfiles\Mod10\Labfiles\01_ShirtStore_begin\ShirtStoreWebsite\Views\Shirt\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Color));

#line default
#line hidden
                EndContext();
                BeginContext(1778, 100, true);
                WriteLiteral("\n                            </td>\n                            <td>\n                                ");
                EndContext();
                BeginContext(1879, 29, false);
#line 52 "C:\Users\Formation\Desktop\20486D-DevelopingASPNETMVCWebApplications-master\Allfiles\Mod10\Labfiles\01_ShirtStore_begin\ShirtStoreWebsite\Views\Shirt\Index.cshtml"
                           Write(item.GetFormattedTaxedPrice());

#line default
#line hidden
                EndContext();
                BeginContext(1908, 100, true);
                WriteLiteral("\n                            </td>\n                            <td>\n                                ");
                EndContext();
                BeginContext(2009, 38, false);
#line 55 "C:\Users\Formation\Desktop\20486D-DevelopingASPNETMVCWebApplications-master\Allfiles\Mod10\Labfiles\01_ShirtStore_begin\ShirtStoreWebsite\Views\Shirt\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Tax));

#line default
#line hidden
                EndContext();
                BeginContext(2047, 100, true);
                WriteLiteral("\n                            </td>\n                            <td>\n                                ");
                EndContext();
                BeginContext(2148, 57, false);
#line 58 "C:\Users\Formation\Desktop\20486D-DevelopingASPNETMVCWebApplications-master\Allfiles\Mod10\Labfiles\01_ShirtStore_begin\ShirtStoreWebsite\Views\Shirt\Index.cshtml"
                           Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
                EndContext();
                BeginContext(2205, 65, true);
                WriteLiteral("\n                            </td>\n                        </tr>\n");
                EndContext();
#line 61 "C:\Users\Formation\Desktop\20486D-DevelopingASPNETMVCWebApplications-master\Allfiles\Mod10\Labfiles\01_ShirtStore_begin\ShirtStoreWebsite\Views\Shirt\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(2296, 201, true);
                WriteLiteral("                    </tbody>\n                </table>\n            </div>\n            <div class=\"col-sm border-left-solid\">\n                <h3 class=\"text-center\">Add a new Shirt</h3>\n                ");
                EndContext();
                BeginContext(2497, 77, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3c4e48164e204a7abad26ee5d608e7b5", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 67 "C:\Users\Formation\Desktop\20486D-DevelopingASPNETMVCWebApplications-master\Allfiles\Mod10\Labfiles\01_ShirtStore_begin\ShirtStoreWebsite\Views\Shirt\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = new ShirtStoreWebsite.Models.Shirt();

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2574, 46, true);
                WriteLiteral("\n            </div>\n        </div>\n    </div>\n");
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
            BeginContext(2627, 9, true);
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ShirtStoreWebsite.Models.Shirt>> Html { get; private set; }
    }
}
#pragma warning restore 1591
