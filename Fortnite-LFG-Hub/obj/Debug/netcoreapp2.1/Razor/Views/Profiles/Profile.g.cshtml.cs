#pragma checksum "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24a9fca4618eb09d95f41cd437202f2b208516e8"
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
#line 1 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\_ViewImports.cshtml"
using Fortnite_LFG_Hub;

#line default
#line hidden
#line 2 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\_ViewImports.cshtml"
using Fortnite_LFG_Hub.Models;

#line default
#line hidden
#line 2 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
using Fortnite_LFG_Hub.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
using BusinessLayer.Logic;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24a9fca4618eb09d95f41cd437202f2b208516e8", @"/Views/Profiles/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6488c9f39a0d2cb16d2388629acb7f83bffadd62", @"/Views/_ViewImports.cshtml")]
    public class Views_Profiles_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BusinessLayer.Profile>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profiles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(170, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
  
    ViewData["Title"] = "Profile";

#line default
#line hidden
            BeginContext(215, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(222, 14, false);
#line 10 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
Write(Model.Username);

#line default
#line hidden
            EndContext();
            BeginContext(236, 53, true);
            WriteLiteral("</h1> <!-- Picture should come here too -->\r\n<br />\r\n");
            EndContext();
#line 12 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
  
    if (Model.Region != BusinessLayer.Regions._)
    {

#line default
#line hidden
            BeginContext(350, 42, true);
            WriteLiteral("        <h3 style=\"display:inline-block;\">");
            EndContext();
            BeginContext(393, 23, false);
#line 15 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
                                     Write(Model.Region.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(416, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
#line 16 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(447, 58, true);
            WriteLiteral("        <h3 style=\"display:inline-block;\">No Region</h3>\r\n");
            EndContext();
#line 20 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
    }
    if (Model.Looking)
    {

#line default
#line hidden
            BeginContext(543, 69, true);
            WriteLiteral("        <h3 style=\"display:inline-block;\" color=\"green\"> - LFG</h3>\r\n");
            EndContext();
#line 24 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(636, 71, true);
            WriteLiteral("        <h3 style=\"display:inline-block;\" color=\"red\"> - NOT LFG</h3>\r\n");
            EndContext();
#line 28 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
    }

#line default
#line hidden
            BeginContext(717, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
#line 31 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
 if (Model.Flairs.Count > 0)
{
    foreach (var flair in Model.Flairs)
    {
        string cleanFlair = flair.ToString().Replace("_", " ");

#line default
#line hidden
            BeginContext(871, 39, true);
            WriteLiteral("        <span class=\"badge badge-pill\">");
            EndContext();
            BeginContext(911, 10, false);
#line 36 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
                                  Write(cleanFlair);

#line default
#line hidden
            EndContext();
            BeginContext(921, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 37 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
    }
}

#line default
#line hidden
            BeginContext(940, 15, true);
            WriteLiteral("<br /> <br />\r\n");
            EndContext();
#line 40 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
 foreach (var achievement in Model.Achievements)
{

#line default
#line hidden
            BeginContext(1008, 39, true);
            WriteLiteral("    <h4 style=\"display:inline-block;\">#");
            EndContext();
            BeginContext(1048, 16, false);
#line 42 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
                                  Write(achievement.Rank);

#line default
#line hidden
            EndContext();
            BeginContext(1064, 10, true);
            WriteLiteral(" - </h4>\r\n");
            EndContext();
#line 43 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
    string replacedEvent = achievement.Event.ToString().Replace("_", " ");

#line default
#line hidden
            BeginContext(1150, 38, true);
            WriteLiteral("    <h4 style=\"display:inline-block;\">");
            EndContext();
            BeginContext(1189, 13, false);
#line 44 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
                                 Write(replacedEvent);

#line default
#line hidden
            EndContext();
            BeginContext(1202, 19, true);
            WriteLiteral("</h4>\r\n    <br />\r\n");
            EndContext();
#line 46 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
}

#line default
#line hidden
            BeginContext(1228, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
#line 49 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
    if (!string.IsNullOrWhiteSpace(Model.FreeText))
    {

#line default
#line hidden
            BeginContext(1300, 14, true);
            WriteLiteral("        <span>");
            EndContext();
            BeginContext(1315, 14, false);
#line 51 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
         Write(Model.FreeText);

#line default
#line hidden
            EndContext();
            BeginContext(1329, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 52 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(1362, 74, true);
            WriteLiteral("        <span>This user has not shared any additional information</span>\r\n");
            EndContext();
#line 56 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
    }

#line default
#line hidden
            BeginContext(1443, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
#line 58 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
    if (!string.IsNullOrWhiteSpace(Model.SocialURL))
    {

#line default
#line hidden
            BeginContext(1516, 10, true);
            WriteLiteral("        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1526, "\"", 1549, 1);
#line 60 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
WriteAttributeValue("", 1533, Model.SocialURL, 1533, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1550, 23, true);
            WriteLiteral("><h5>Twitter</h5></a>\r\n");
            EndContext();
#line 61 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(1597, 65, true);
            WriteLiteral("        <span>This user has not linked a social platform</span>\r\n");
            EndContext();
#line 65 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
    }

#line default
#line hidden
            BeginContext(1672, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
#line 68 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
  

    if (HttpContextAccessor.HttpContext.Session != null)
    {
        if (HttpContextAccessor.HttpContext.Session.Get<int>("UserId") != 0)
        {
            if (HttpContextAccessor.HttpContext.Session.Get<int>("UserId") == Model.UserId)
            {
                // If the session UserId is the same as the current profile in the view, we can edit it.

#line default
#line hidden
            BeginContext(2054, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(2070, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04fb7529b7344da2bf33ddd63fcb48ce", async() => {
                BeginContext(2153, 12, true);
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
#line 77 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
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
            BeginContext(2169, 26, true);
            WriteLiteral("\r\n                <br />\r\n");
            EndContext();
#line 79 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
            }

            // If we are logged in we are allowed to comment.
            CommentViewModel comment = new CommentViewModel();

#line default
#line hidden
            BeginContext(2339, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(2351, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "45da4b75da9c4e9fb03c3aef733971ee", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 83 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
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
            BeginContext(2393, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 84 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(2431, 69, true);
            WriteLiteral("            <br />\r\n            <span>Login to post comments</span>\r\n");
            EndContext();
#line 89 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(2521, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
#line 93 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
  
    if(Model.Comments.Count == 0)
    {

#line default
#line hidden
            BeginContext(2575, 38, true);
            WriteLiteral("        <span>No comments yet</span>\r\n");
            EndContext();
#line 97 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
    }
    foreach (var comment in Model.Comments)
    {
        ProfileLogic logic = new ProfileLogic();
        string username = logic.GetUsernameForId(comment.SourceUser);

#line default
#line hidden
            BeginContext(2793, 57, true);
            WriteLiteral("        <div class=\"list-group-item\">\r\n            <span>");
            EndContext();
            BeginContext(2850, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb564426ded943b39b42a2ae0d26a3b8", async() => {
                BeginContext(2936, 8, false);
#line 103 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
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
#line 103 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
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
            BeginContext(2948, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(2952, 18, false);
#line 103 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
                                                                                                                  Write(comment.TimePosted);

#line default
#line hidden
            EndContext();
            BeginContext(2970, 24, true);
            WriteLiteral("</span>\r\n            <p>");
            EndContext();
            BeginContext(2995, 19, false);
#line 104 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
          Write(comment.CommentText);

#line default
#line hidden
            EndContext();
            BeginContext(3014, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 105 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
             if (HttpContextAccessor.HttpContext.Session.Get<int>("UserId") == comment.SourceUser)
            {

#line default
#line hidden
            BeginContext(3135, 22, true);
            WriteLiteral("                <span>");
            EndContext();
            BeginContext(3157, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1333a4da30ac4818869e811590d9eeba", async() => {
                BeginContext(3283, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-commentId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 107 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
                                                                                       WriteLiteral(comment.CommentId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["commentId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-commentId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["commentId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 107 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
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
            BeginContext(3293, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 108 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
            }

#line default
#line hidden
            BeginContext(3317, 32, true);
            WriteLiteral("        </div>\r\n        <br />\r\n");
            EndContext();
#line 111 "C:\Users\iAgonyii\Documents\Skool\S2\Individueel\Project Files\fortnite-lfg-hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
    }

#line default
#line hidden
            BeginContext(3359, 6, true);
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
