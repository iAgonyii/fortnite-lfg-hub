#pragma checksum "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ba867388ad284378dd6e5b37bb7595188ce39a2"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ba867388ad284378dd6e5b37bb7595188ce39a2", @"/Views/Profiles/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6488c9f39a0d2cb16d2388629acb7f83bffadd62", @"/Views/_ViewImports.cshtml")]
    public class Views_Profiles_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Fortnite_LFG_Hub.Models.Profile>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
  
    ViewData["Title"] = "Profile";

#line default
#line hidden
            BeginContext(86, 24, true);
            WriteLiteral("\r\n<h2>Profile</h2>\r\n<h3>");
            EndContext();
            BeginContext(111, 14, false);
#line 8 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
Write(Model.Username);

#line default
#line hidden
            EndContext();
            BeginContext(125, 20, true);
            WriteLiteral("</h3> <br />\r\n<h4>\r\n");
            EndContext();
#line 10 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
 foreach (Achievement achievement in Model.Achievements)
{
        

#line default
#line hidden
            BeginContext(215, 38, false);
#line 12 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
   Write(Html.DisplayFor(a => achievement.Rank));

#line default
#line hidden
            EndContext();
#line 12 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
                                               ;

#line default
#line hidden
            BeginContext(256, 16, true);
            WriteLiteral("        <br />\r\n");
            EndContext();
            BeginContext(281, 39, false);
#line 14 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
   Write(Html.DisplayFor(a => achievement.Event));

#line default
#line hidden
            EndContext();
#line 14 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
                                                ;

#line default
#line hidden
            BeginContext(323, 17, true);
            WriteLiteral("        <br /> \r\n");
            EndContext();
#line 16 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
}

#line default
#line hidden
            BeginContext(343, 11, true);
            WriteLiteral("    <br /> ");
            EndContext();
            BeginContext(355, 14, false);
#line 17 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
      Write(Model.FreeText);

#line default
#line hidden
            EndContext();
            BeginContext(369, 8, true);
            WriteLiteral(" <br /> ");
            EndContext();
            BeginContext(378, 15, false);
#line 17 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Profile.cshtml"
                             Write(Model.SocialURL);

#line default
#line hidden
            EndContext();
            BeginContext(393, 11, true);
            WriteLiteral("</h4>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Fortnite_LFG_Hub.Models.Profile> Html { get; private set; }
    }
}
#pragma warning restore 1591