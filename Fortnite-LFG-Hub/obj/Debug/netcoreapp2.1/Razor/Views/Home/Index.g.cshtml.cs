#pragma checksum "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a088ab1eed59a9f64c4f20a3fe334db034042b82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\_ViewImports.cshtml"
using Fortnite_LFG_Hub;

#line default
#line hidden
#line 2 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\_ViewImports.cshtml"
using Fortnite_LFG_Hub.Models;

#line default
#line hidden
#line 2 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Home\Index.cshtml"
using BusinessLayer;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a088ab1eed59a9f64c4f20a3fe334db034042b82", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6488c9f39a0d2cb16d2388629acb7f83bffadd62", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BusinessLayer.Profile>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profiles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
            BeginContext(99, 25, true);
            WriteLiteral("\r\n<h2>Home</h2>\r\n<br />\r\n");
            EndContext();
            BeginContext(124, 176, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf910f2a69534d9db5fb70e1e0b2549e", async() => {
                BeginContext(184, 109, true);
                WriteLiteral("\r\n    <input type=\"text\" name=\"search\" placeholder=\"Search...\">\r\n    <input type=\"submit\" value=\"Search\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(300, 12, true);
            WriteLiteral("\r\n<br />\r\n\r\n");
            EndContext();
#line 15 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Home\Index.cshtml"
 foreach (Profile profile in Model)
{

#line default
#line hidden
            BeginContext(352, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(356, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ac6b59c2d62440caa499da6bf3f107d", async() => {
                BeginContext(437, 4, true);
                WriteLiteral("<h4>");
                EndContext();
                BeginContext(442, 16, false);
#line 17 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Home\Index.cshtml"
                                                                                    Write(profile.Username);

#line default
#line hidden
                EndContext();
                BeginContext(458, 5, true);
                WriteLiteral("</h4>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 17 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Home\Index.cshtml"
                                                        WriteLiteral(profile.UserId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(467, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 18 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Home\Index.cshtml"
    if (profile.Region != Regions._)
    {

#line default
#line hidden
            BeginContext(514, 14, true);
            WriteLiteral("        <span>");
            EndContext();
            BeginContext(529, 25, false);
#line 20 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Home\Index.cshtml"
         Write(profile.Region.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(554, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 21 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Home\Index.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(587, 32, true);
            WriteLiteral("        <span>No Region</span>\r\n");
            EndContext();
#line 25 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Home\Index.cshtml"
    }
    if (profile.Looking)
    {

#line default
#line hidden
            BeginContext(659, 29, true);
            WriteLiteral("        <span> - LFG</span>\r\n");
            EndContext();
#line 29 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Home\Index.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(712, 33, true);
            WriteLiteral("        <span> - NOT LFG</span>\r\n");
            EndContext();
#line 33 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(752, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
#line 35 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Home\Index.cshtml"
    if (profile.Flairs.Count > 0)
    {
        foreach (Flairs flair in profile.Flairs)
        {
            string cleanFlair = flair.ToString().Replace("_", " ");

#line default
#line hidden
            BeginContext(936, 43, true);
            WriteLiteral("            <span class=\"badge badge-pill\">");
            EndContext();
            BeginContext(980, 10, false);
#line 40 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Home\Index.cshtml"
                                      Write(cleanFlair);

#line default
#line hidden
            EndContext();
            BeginContext(990, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 41 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Home\Index.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(1017, 24, true);
            WriteLiteral("    <br />\r\n    <br />\r\n");
            EndContext();
#line 45 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Home\Index.cshtml"
    if (profile.Achievements.Count > 0)
    {
        foreach (Achievement achievement in profile.Achievements)
        {
            string replacedEvent = achievement.Event.ToString().Replace("_", " ");
            

#line default
#line hidden
            BeginContext(1264, 38, false);
#line 50 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Home\Index.cshtml"
       Write(Html.DisplayFor(a => achievement.Rank));

#line default
#line hidden
            EndContext();
            BeginContext(1302, 18, true);
            WriteLiteral(" <span> - </span> ");
            EndContext();
            BeginContext(1321, 35, false);
#line 50 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Home\Index.cshtml"
                                                                Write(Html.DisplayFor(e => replacedEvent));

#line default
#line hidden
            EndContext();
            BeginContext(1358, 20, true);
            WriteLiteral("            <br />\r\n");
            EndContext();
#line 52 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Home\Index.cshtml"
        }
    }
    else
    {

#line default
#line hidden
            BeginContext(1413, 80, true);
            WriteLiteral("        <span>This user has not shared any achievements</span>\r\n        <br />\r\n");
            EndContext();
#line 58 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1500, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
#line 60 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Home\Index.cshtml"
    if (!string.IsNullOrWhiteSpace(profile.FreeText))
    {

#line default
#line hidden
            BeginContext(1574, 14, true);
            WriteLiteral("        <span>");
            EndContext();
            BeginContext(1589, 16, false);
#line 62 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Home\Index.cshtml"
         Write(profile.FreeText);

#line default
#line hidden
            EndContext();
            BeginContext(1605, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 63 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Home\Index.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(1638, 74, true);
            WriteLiteral("        <span>This user has not shared any additional information</span>\r\n");
            EndContext();
#line 67 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1719, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
#line 69 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Home\Index.cshtml"
    if (!string.IsNullOrWhiteSpace(profile.SocialURL))
    {

#line default
#line hidden
            BeginContext(1794, 10, true);
            WriteLiteral("        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1804, "\"", 1829, 1);
#line 71 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Home\Index.cshtml"
WriteAttributeValue("", 1811, profile.SocialURL, 1811, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1830, 14, true);
            WriteLiteral(">Twitter</a>\r\n");
            EndContext();
#line 72 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Home\Index.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(1868, 65, true);
            WriteLiteral("        <span>This user has not linked a social platform</span>\r\n");
            EndContext();
#line 76 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1940, 24, true);
            WriteLiteral("    <br />\r\n    <br />\r\n");
            EndContext();
#line 79 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Home\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BusinessLayer.Profile>> Html { get; private set; }
    }
}
#pragma warning restore 1591
