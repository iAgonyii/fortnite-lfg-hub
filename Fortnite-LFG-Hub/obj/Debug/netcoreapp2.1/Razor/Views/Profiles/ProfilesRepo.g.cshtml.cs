#pragma checksum "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\ProfilesRepo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5672041923bdf08211da61d21d8bf1df8176aa2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profiles_ProfilesRepo), @"mvc.1.0.view", @"/Views/Profiles/ProfilesRepo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Profiles/ProfilesRepo.cshtml", typeof(AspNetCore.Views_Profiles_ProfilesRepo))]
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
#line 2 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\ProfilesRepo.cshtml"
using BusinessLayer;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5672041923bdf08211da61d21d8bf1df8176aa2a", @"/Views/Profiles/ProfilesRepo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6488c9f39a0d2cb16d2388629acb7f83bffadd62", @"/Views/_ViewImports.cshtml")]
    public class Views_Profiles_ProfilesRepo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BusinessLayer.Profile>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profiles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\ProfilesRepo.cshtml"
  
    ViewData["Title"] = "ProfilesRepo";

#line default
#line hidden
            BeginContext(107, 25, true);
            WriteLiteral("\r\n<h2>ProfilesRepo</h2>\r\n");
            EndContext();
#line 8 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\ProfilesRepo.cshtml"
 foreach (Profile profile in Model)
{

#line default
#line hidden
            BeginContext(172, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(176, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18bcbd2c0dc04d46bbafa179ac18b1d9", async() => {
                BeginContext(260, 38, false);
#line 10 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\ProfilesRepo.cshtml"
                                                                                  Write(Html.DisplayFor(p => profile.Username));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 10 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\ProfilesRepo.cshtml"
                                                        WriteLiteral(profile.Username);

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
            BeginContext(302, 14, true);
            WriteLiteral("\r\n    <br />\r\n");
            EndContext();
#line 12 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\ProfilesRepo.cshtml"
    foreach (Achievement achievement in profile.Achievements)
    {
        string replacedEvent = achievement.Event.ToString().Replace("_", " ");
        

#line default
#line hidden
            BeginContext(475, 38, false);
#line 15 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\ProfilesRepo.cshtml"
   Write(Html.DisplayFor(a => achievement.Rank));

#line default
#line hidden
            EndContext();
            BeginContext(513, 18, true);
            WriteLiteral(" <span> - </span> ");
            EndContext();
            BeginContext(532, 35, false);
#line 15 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\ProfilesRepo.cshtml"
                                                            Write(Html.DisplayFor(e => replacedEvent));

#line default
#line hidden
            EndContext();
            BeginContext(569, 16, true);
            WriteLiteral("        <br />\r\n");
            EndContext();
#line 17 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\ProfilesRepo.cshtml"
    }
    if (!string.IsNullOrWhiteSpace(profile.FreeText))
    {
        

#line default
#line hidden
            BeginContext(663, 38, false);
#line 20 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\ProfilesRepo.cshtml"
   Write(Html.DisplayFor(p => profile.FreeText));

#line default
#line hidden
            EndContext();
#line 20 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\ProfilesRepo.cshtml"
                                               
    }
    else
    {

#line default
#line hidden
            BeginContext(727, 74, true);
            WriteLiteral("        <span>This user has not shared any additional information</span>\r\n");
            EndContext();
#line 25 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\ProfilesRepo.cshtml"
    }

#line default
#line hidden
            BeginContext(808, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
#line 27 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\ProfilesRepo.cshtml"
    if (!string.IsNullOrWhiteSpace(profile.SocialURL))
    {
        

#line default
#line hidden
            BeginContext(892, 39, false);
#line 29 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\ProfilesRepo.cshtml"
   Write(Html.DisplayFor(p => profile.SocialURL));

#line default
#line hidden
            EndContext();
#line 29 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\ProfilesRepo.cshtml"
                                                
    }
    else
    {

#line default
#line hidden
            BeginContext(957, 65, true);
            WriteLiteral("        <span>This user has not linked a social platform</span>\r\n");
            EndContext();
#line 34 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\ProfilesRepo.cshtml"
    }

#line default
#line hidden
            BeginContext(1029, 24, true);
            WriteLiteral("    <br />\r\n    <br />\r\n");
            EndContext();
#line 37 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\ProfilesRepo.cshtml"
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
