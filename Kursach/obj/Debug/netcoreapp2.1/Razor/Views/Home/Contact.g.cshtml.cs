#pragma checksum "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de8841cd852c9f6b3238d4b2c3979922b8606745"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
#line 1 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/_ViewImports.cshtml"
using Kursach;

#line default
#line hidden
#line 2 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/_ViewImports.cshtml"
using Kursach.Models;

#line default
#line hidden
#line 3 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/_ViewImports.cshtml"
using Kursach.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de8841cd852c9f6b3238d4b2c3979922b8606745", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40d377b205f82e1db98dbbd5931b06db8579f7a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StepOfDevelopmentModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Contact.cshtml"
  
    ViewData["Title"] = "steps";

#line default
#line hidden
            BeginContext(81, 128, true);
            WriteLiteral("\n<nav class=\"navbar navbar-light bg-light\">\n    <span class=\"navbar-brand mb-0 h1\">Users</span>\n</nav>\n\n<ul class=\"list-group\">\n");
            EndContext();
#line 11 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Contact.cshtml"
     foreach (var step in Model)
    {

#line default
#line hidden
            BeginContext(248, 72, true);
            WriteLiteral("        <ul class=\"list-group\">\n            <li class=\"list-group-item\">");
            EndContext();
            BeginContext(321, 22, false);
#line 14 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Contact.cshtml"
                                   Write(step.StepOfDevelopment);

#line default
#line hidden
            EndContext();
            BeginContext(343, 46, true);
            WriteLiteral("</li>\n            <li class=\"list-group-item\">");
            EndContext();
            BeginContext(390, 9, false);
#line 15 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Contact.cshtml"
                                   Write(step.Name);

#line default
#line hidden
            EndContext();
            BeginContext(399, 46, true);
            WriteLiteral("</li>\n            <li class=\"list-group-item\">");
            EndContext();
            BeginContext(446, 16, false);
#line 16 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Contact.cshtml"
                                   Write(step.Description);

#line default
#line hidden
            EndContext();
            BeginContext(462, 46, true);
            WriteLiteral("</li>\n            <li class=\"list-group-item\">");
            EndContext();
            BeginContext(509, 12, false);
#line 17 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Contact.cshtml"
                                   Write(step.EndDate);

#line default
#line hidden
            EndContext();
            BeginContext(521, 46, true);
            WriteLiteral("</li>\n            <li class=\"list-group-item\">");
            EndContext();
            BeginContext(568, 14, false);
#line 18 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Contact.cshtml"
                                   Write(step.ProjectId);

#line default
#line hidden
            EndContext();
            BeginContext(582, 20, true);
            WriteLiteral("</li>\n        </ul>\n");
            EndContext();
#line 20 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/Contact.cshtml"
    }

#line default
#line hidden
            BeginContext(608, 7, true);
            WriteLiteral("       ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StepOfDevelopmentModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591