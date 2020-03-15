#pragma checksum "C:\Users\mkansim\source\repos\BidvestWeb\BidvestWeb\Views\Profiles\Report.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78cc5a494ab90a080f33f378fe6c9b2f6d147eac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profiles_Report), @"mvc.1.0.view", @"/Views/Profiles/Report.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Profiles/Report.cshtml", typeof(AspNetCore.Views_Profiles_Report))]
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
#line 1 "C:\Users\mkansim\source\repos\BidvestWeb\BidvestWeb\Views\_ViewImports.cshtml"
using BidvestWeb;

#line default
#line hidden
#line 2 "C:\Users\mkansim\source\repos\BidvestWeb\BidvestWeb\Views\_ViewImports.cshtml"
using BidvestWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78cc5a494ab90a080f33f378fe6c9b2f6d147eac", @"/Views/Profiles/Report.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d075fb77ef7faac3972ce163363e93cb0b0f19d", @"/Views/_ViewImports.cshtml")]
    public class Views_Profiles_Report : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BidvestWeb.Models.Organisation>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\mkansim\source\repos\BidvestWeb\BidvestWeb\Views\Profiles\Report.cshtml"
  
    ViewData["Title"] = "Report";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 6 "C:\Users\mkansim\source\repos\BidvestWeb\BidvestWeb\Views\Profiles\Report.cshtml"
 if (Model.Profiles.Count > 0)
{

#line default
#line hidden
            BeginContext(163, 348, true);
            WriteLiteral(@"    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">Id</th>
                <th scope=""col"">First Name</th>
                <th scope=""col"">Last Name</th>
                <th scope=""col"">Gender</th>
                <th scope=""col"">IP Address</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 19 "C:\Users\mkansim\source\repos\BidvestWeb\BidvestWeb\Views\Profiles\Report.cshtml"
             foreach (var profile in Model.Profiles)
            {

#line default
#line hidden
            BeginContext(580, 58, true);
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
            EndContext();
            BeginContext(639, 10, false);
#line 22 "C:\Users\mkansim\source\repos\BidvestWeb\BidvestWeb\Views\Profiles\Report.cshtml"
                               Write(profile.Id);

#line default
#line hidden
            EndContext();
            BeginContext(649, 31, true);
            WriteLiteral("</th>\r\n                    <td>");
            EndContext();
            BeginContext(681, 18, false);
#line 23 "C:\Users\mkansim\source\repos\BidvestWeb\BidvestWeb\Views\Profiles\Report.cshtml"
                   Write(profile.First_name);

#line default
#line hidden
            EndContext();
            BeginContext(699, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(731, 17, false);
#line 24 "C:\Users\mkansim\source\repos\BidvestWeb\BidvestWeb\Views\Profiles\Report.cshtml"
                   Write(profile.Last_name);

#line default
#line hidden
            EndContext();
            BeginContext(748, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(780, 14, false);
#line 25 "C:\Users\mkansim\source\repos\BidvestWeb\BidvestWeb\Views\Profiles\Report.cshtml"
                   Write(profile.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(794, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(826, 18, false);
#line 26 "C:\Users\mkansim\source\repos\BidvestWeb\BidvestWeb\Views\Profiles\Report.cshtml"
                   Write(profile.Ip_address);

#line default
#line hidden
            EndContext();
            BeginContext(844, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 28 "C:\Users\mkansim\source\repos\BidvestWeb\BidvestWeb\Views\Profiles\Report.cshtml"

            }

#line default
#line hidden
            BeginContext(891, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 32 "C:\Users\mkansim\source\repos\BidvestWeb\BidvestWeb\Views\Profiles\Report.cshtml"
}
else
{
    

#line default
#line hidden
            BeginContext(945, 25, true);
            WriteLiteral(" No data found to display");
            EndContext();
#line 35 "C:\Users\mkansim\source\repos\BidvestWeb\BidvestWeb\Views\Profiles\Report.cshtml"
                                          
}

#line default
#line hidden
            BeginContext(982, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BidvestWeb.Models.Organisation> Html { get; private set; }
    }
}
#pragma warning restore 1591
