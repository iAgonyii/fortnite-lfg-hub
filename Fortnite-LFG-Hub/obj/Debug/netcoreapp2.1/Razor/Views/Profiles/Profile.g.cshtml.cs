#pragma checksum "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56169e25e86c812f32ea4478158c781abbbacbc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profiles_Profile), @"mvc.1.0.view", @"/Views/Profiles/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Profiles/Profile.cshtml", typeof(AspNetCore.Views_Profiles_Profile))]
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
#line 2 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
using Fortnite_LFG_Hub.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
using BusinessLayer.Logic;

#line default
#line hidden
#line 4 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
using BusinessLayer;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56169e25e86c812f32ea4478158c781abbbacbc9", @"/Views/Profiles/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6488c9f39a0d2cb16d2388629acb7f83bffadd62", @"/Views/_ViewImports.cshtml")]
    public class Views_Profiles_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BusinessLayer.Profile>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profiles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(192, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
  
    ViewData["Title"] = "Profile";

#line default
#line hidden
            BeginContext(237, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(244, 14, false);
#line 11 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
Write(Model.Username);

#line default
#line hidden
            EndContext();
            BeginContext(258, 53, true);
            WriteLiteral("</h1> <!-- Picture should come here too -->\r\n<br />\r\n");
            EndContext();
#line 13 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
  
    if (Model.Region != BusinessLayer.Regions._)
    {

#line default
#line hidden
            BeginContext(372, 42, true);
            WriteLiteral("        <h3 style=\"display:inline-block;\">");
            EndContext();
            BeginContext(415, 23, false);
#line 16 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
                                     Write(Model.Region.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(438, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
#line 17 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(469, 58, true);
            WriteLiteral("        <h3 style=\"display:inline-block;\">No Region</h3>\r\n");
            EndContext();
#line 21 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
    }
    if (Model.Looking)
    {

#line default
#line hidden
            BeginContext(565, 69, true);
            WriteLiteral("        <h3 style=\"display:inline-block;\" color=\"green\"> - LFG</h3>\r\n");
            EndContext();
#line 25 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(658, 71, true);
            WriteLiteral("        <h3 style=\"display:inline-block;\" color=\"red\"> - NOT LFG</h3>\r\n");
            EndContext();
#line 29 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
    }

#line default
#line hidden
            BeginContext(739, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
#line 32 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
 if (Model.Flairs.Count > 0)
{
    foreach (var flair in Model.Flairs)
    {
        string cleanFlair = flair.ToString().Replace("_", " ");
        if (flair == Flairs.Top_50 || flair == Flairs.Top_25)
        {

#line default
#line hidden
            BeginContext(967, 46, true);
            WriteLiteral("            <span class=\"label label-success\">");
            EndContext();
            BeginContext(1014, 10, false);
#line 39 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
                                         Write(cleanFlair);

#line default
#line hidden
            EndContext();
            BeginContext(1024, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 40 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(1069, 42, true);
            WriteLiteral("        <span class=\"label label-primary\">");
            EndContext();
            BeginContext(1112, 10, false);
#line 43 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
                                     Write(cleanFlair);

#line default
#line hidden
            EndContext();
            BeginContext(1122, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 44 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
        }
    }
}

#line default
#line hidden
            BeginContext(1152, 16, true);
            WriteLiteral("<br />\r\n<br />\r\n");
            EndContext();
#line 49 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
 foreach (var achievement in Model.Achievements)
{

#line default
#line hidden
            BeginContext(1221, 39, true);
            WriteLiteral("    <h4 style=\"display:inline-block;\">#");
            EndContext();
            BeginContext(1261, 16, false);
#line 51 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
                                  Write(achievement.Rank);

#line default
#line hidden
            EndContext();
            BeginContext(1277, 10, true);
            WriteLiteral(" - </h4>\r\n");
            EndContext();
#line 52 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
    string replacedEvent = achievement.Event.ToString().Replace("_", " ");

#line default
#line hidden
            BeginContext(1363, 38, true);
            WriteLiteral("    <h4 style=\"display:inline-block;\">");
            EndContext();
            BeginContext(1402, 13, false);
#line 53 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
                                 Write(replacedEvent);

#line default
#line hidden
            EndContext();
            BeginContext(1415, 19, true);
            WriteLiteral("</h4>\r\n    <br />\r\n");
            EndContext();
#line 55 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
}

#line default
#line hidden
            BeginContext(1441, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
#line 58 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
    if (!string.IsNullOrWhiteSpace(Model.FreeText))
    {

#line default
#line hidden
            BeginContext(1513, 14, true);
            WriteLiteral("        <span>");
            EndContext();
            BeginContext(1528, 14, false);
#line 60 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
         Write(Model.FreeText);

#line default
#line hidden
            EndContext();
            BeginContext(1542, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 61 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(1575, 74, true);
            WriteLiteral("        <span>This user has not shared any additional information</span>\r\n");
            EndContext();
#line 65 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
    }

#line default
#line hidden
            BeginContext(1656, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
#line 67 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
    if (!string.IsNullOrWhiteSpace(Model.SocialURL))
    {

#line default
#line hidden
            BeginContext(1729, 10, true);
            WriteLiteral("        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1739, "\"", 1762, 1);
#line 69 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
WriteAttributeValue("", 1746, Model.SocialURL, 1746, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1763, 23, true);
            WriteLiteral("><h5>Twitter</h5></a>\r\n");
            EndContext();
#line 70 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(1810, 65, true);
            WriteLiteral("        <span>This user has not linked a social platform</span>\r\n");
            EndContext();
#line 74 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
    }

#line default
#line hidden
            BeginContext(1885, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
#line 77 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
  

    if (HttpContextAccessor.HttpContext.Session != null)
    {
        if (HttpContextAccessor.HttpContext.Session.Get<int>("UserId") != 0)
        {
            if (HttpContextAccessor.HttpContext.Session.Get<int>("UserId") == Model.UserId)
            {
                // If the session UserId is the same as the current profile in the view, we can edit it.

#line default
#line hidden
            BeginContext(2267, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(2283, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9c3950825094f2c9fa83dc2c88e0777", async() => {
                BeginContext(2366, 12, true);
                WriteLiteral("Edit Profile");
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
#line 86 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
                                                                        WriteLiteral(Model.UserId);

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
            BeginContext(2382, 26, true);
            WriteLiteral("\r\n                <br />\r\n");
            EndContext();
#line 88 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
            }

            // If we are logged in we are allowed to comment.
            CommentViewModel comment = new CommentViewModel();

#line default
#line hidden
            BeginContext(2552, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(2564, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "84818dd5f0e144e2ad6dbbafe88de338", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 92 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = comment;

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
            BeginContext(2606, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 93 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(2644, 69, true);
            WriteLiteral("            <br />\r\n            <span>Login to post comments</span>\r\n");
            EndContext();
#line 98 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(2734, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
#line 102 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
  
    if (Model.Comments.Count == 0)
    {

#line default
#line hidden
            BeginContext(2789, 38, true);
            WriteLiteral("        <span>No comments yet</span>\r\n");
            EndContext();
#line 106 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
    }
    foreach (var comment in Model.Comments)
    {
        ProfileLogic logic = new ProfileLogic();
        string username = logic.GetUsernameForId(comment.SourceUser);

#line default
#line hidden
            BeginContext(3007, 57, true);
            WriteLiteral("        <div class=\"list-group-item\">\r\n            <span>");
            EndContext();
            BeginContext(3064, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c961acb5bfa24901b53fb7ed1949dfd4", async() => {
                BeginContext(3150, 8, false);
#line 112 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
                                                                                                  Write(username);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 112 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
                                                                      WriteLiteral(comment.SourceUser);

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
            BeginContext(3162, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(3166, 18, false);
#line 112 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
                                                                                                                  Write(comment.TimePosted);

#line default
#line hidden
            EndContext();
            BeginContext(3184, 24, true);
            WriteLiteral("</span>\r\n            <p>");
            EndContext();
            BeginContext(3209, 19, false);
#line 113 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
          Write(comment.CommentText);

#line default
#line hidden
            EndContext();
            BeginContext(3228, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 114 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
             if (HttpContextAccessor.HttpContext.Session.Get<int>("UserId") == comment.SourceUser)
            {

#line default
#line hidden
            BeginContext(3349, 22, true);
            WriteLiteral("                <span>");
            EndContext();
            BeginContext(3371, 135, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaac0a45aa974177b193f46bbd70b02d", async() => {
                BeginContext(3496, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-commentId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 116 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
                                                                                      WriteLiteral(comment.CommentId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["commentId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-commentId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["commentId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 116 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
                                                                                                                        WriteLiteral(Model.UserId);

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
            BeginContext(3506, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 117 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
            }

#line default
#line hidden
            BeginContext(3530, 32, true);
            WriteLiteral("        </div>\r\n        <br />\r\n");
            EndContext();
#line 120 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
    }

#line default
#line hidden
            BeginContext(3572, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BusinessLayer.Profile> Html { get; private set; }
    }
}
#pragma warning restore 1591
