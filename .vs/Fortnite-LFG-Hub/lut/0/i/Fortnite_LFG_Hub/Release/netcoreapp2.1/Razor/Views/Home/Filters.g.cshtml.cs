#pragma checksum "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Home\Filters.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "217cd8518c93d07f62ee6bd5728752a96b527d61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Filters), @"mvc.1.0.view", @"/Views/Home/Filters.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Filters.cshtml", typeof(AspNetCore.Views_Home_Filters))]
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
#line 1 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\_ViewImports.cshtml"
using Fortnite_LFG_Hub;

#line default
#line hidden
#line 2 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\_ViewImports.cshtml"
using Fortnite_LFG_Hub.Models;

#line default
#line hidden
#line 2 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Home\Filters.cshtml"
using BusinessLayer;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"217cd8518c93d07f62ee6bd5728752a96b527d61", @"/Views/Home/Filters.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6488c9f39a0d2cb16d2388629acb7f83bffadd62", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Filters : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<bool>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "checkbox", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FilterIndex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(162, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(166, 636, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ab6b4439d80462f87aa618438da52ce", async() => {
                BeginContext(232, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 8 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Home\Filters.cshtml"
       List<Flairs> flairs = Enum.GetValues(typeof(Flairs)).Cast<Flairs>().ToList(); 

#line default
#line hidden
                BeginContext(322, 74, true);
                WriteLiteral("    <table>\r\n        <tr>\r\n            <th>Filters</th>\r\n        </tr>\r\n\r\n");
                EndContext();
#line 14 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Home\Filters.cshtml"
         for (int i = 0; i < Model.Count; i++)
        {

#line default
#line hidden
                BeginContext(455, 44, true);
                WriteLiteral("            <tr>\r\n                <td><span>");
                EndContext();
                BeginContext(500, 20, false);
#line 17 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Home\Filters.cshtml"
                     Write(flairs[i].ToString());

#line default
#line hidden
                EndContext();
                BeginContext(520, 41, true);
                WriteLiteral(" &nbsp;</span></td>\r\n                <td>");
                EndContext();
                BeginContext(561, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "899b44118e0f42c38a58c37c8a81d1ff", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 18 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Home\Filters.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model[i]);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(604, 26, true);
                WriteLiteral("</td>\r\n            </tr>\r\n");
                EndContext();
#line 20 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Home\Filters.cshtml"
        }

#line default
#line hidden
                BeginContext(641, 154, true);
                WriteLiteral("\r\n        <tr>\r\n            <td><input class=\"btn btn-primary btn-block btn-sm\" type=\"submit\" value=\"Apply filters\" /></td>\r\n        </tr>\r\n    </table>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<bool>> Html { get; private set; }
    }
}
#pragma warning restore 1591
