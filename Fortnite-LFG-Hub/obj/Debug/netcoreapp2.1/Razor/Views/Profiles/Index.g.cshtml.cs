#pragma checksum "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6685d9095e92f73eb0ffbe1f533216e0fb0e303f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profiles_Index), @"mvc.1.0.view", @"/Views/Profiles/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Profiles/Index.cshtml", typeof(AspNetCore.Views_Profiles_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6685d9095e92f73eb0ffbe1f533216e0fb0e303f", @"/Views/Profiles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6488c9f39a0d2cb16d2388629acb7f83bffadd62", @"/Views/_ViewImports.cshtml")]
    public class Views_Profiles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Fortnite_LFG_Hub.Models.Profile>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(91, 83, true);
            WriteLiteral("<br />\r\n\r\n<h2>List of active profiles</h2>\r\n\r\n<p>I want you to fuck my wife</p>\r\n\r\n");
            EndContext();
#line 13 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Index.cshtml"
 foreach (Profile profile in Model)
{
    

#line default
#line hidden
            BeginContext(219, 34, false);
#line 15 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Index.cshtml"
Write(Html.DisplayFor(m => profile.name));

#line default
#line hidden
            EndContext();
#line 15 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Index.cshtml"
                                       ;

#line default
#line hidden
            BeginContext(256, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
            BeginContext(273, 41, false);
#line 17 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Index.cshtml"
Write(Html.DisplayFor(m => profile.achievement));

#line default
#line hidden
            EndContext();
#line 17 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Index.cshtml"
                                              ;

#line default
#line hidden
            BeginContext(317, 24, true);
            WriteLiteral("    <br />\r\n    <br />\r\n");
            EndContext();
#line 20 "C:\Users\Roy\Documents\Skool\HBO-ICT\S2\Individueel\! Project File\Fortnite-LFG-Hub\Fortnite-LFG-Hub\Views\Profiles\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Fortnite_LFG_Hub.Models.Profile>> Html { get; private set; }
    }
}
#pragma warning restore 1591
