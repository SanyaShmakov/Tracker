#pragma checksum "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/AddUserToProject.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b5e86d1ead2f8c5b24863248bb8b22b5c5373c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AddUserToProject), @"mvc.1.0.view", @"/Views/Home/AddUserToProject.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/AddUserToProject.cshtml", typeof(AspNetCore.Views_Home_AddUserToProject))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b5e86d1ead2f8c5b24863248bb8b22b5c5373c1", @"/Views/Home/AddUserToProject.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40d377b205f82e1db98dbbd5931b06db8579f7a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AddUserToProject : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Kursach.Models.UsersInProjectsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SubscribeUsersToProject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/AddUserToProject.cshtml"
  
    //ViewData["Title"] = "AddUserToProject";
    int proj = int.Parse(ViewData["ProjectId"].ToString());
    bool skip = false;
    IList<UsersInProjectsModel> subbed = ViewData["SubscribedUsers"] as IList<UsersInProjectsModel>;

#line default
#line hidden
            BeginContext(279, 46, true);
            WriteLiteral("\n<h2>Управление доступом </h2>\n\n<h4>к проекту ");
            EndContext();
            BeginContext(326, 23, false);
#line 12 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/AddUserToProject.cshtml"
         Write(ViewData["ProjectName"]);

#line default
#line hidden
            EndContext();
            BeginContext(349, 136, true);
            WriteLiteral("</h4>\n<hr />\n<h4>Выберите пользователей, которым будет доступен данный проект</h4>\n<div class=\"row\">\n    <div class=\"col-md-4\">\n        ");
            EndContext();
            BeginContext(485, 2146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fcef2c042c6548c89f25f7ba04bf5860", async() => {
                BeginContext(528, 13, true);
                WriteLiteral("\n            ");
                EndContext();
                BeginContext(541, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ef2933fbe5e4276a9716a3a6e3aba95", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 18 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/AddUserToProject.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(607, 229, true);
                WriteLiteral("\n            <div class=\"form-check\">\n                <ul style=\"max-height: 600px;\n                       margin-bottom: 10px;\n                       overflow:scroll;\n                       -webkit-overflow-scrolling: touch;\">\n\n");
                EndContext();
#line 25 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/AddUserToProject.cshtml"
                     foreach (var user in ViewData["Users"] as IList<UserModel>)
                    {

#line default
#line hidden
                BeginContext(939, 125, true);
                WriteLiteral("                        <il>\n                           \n                            <span class=\"glyphicon glyphicon-user\">\n");
                EndContext();
#line 30 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/AddUserToProject.cshtml"
                                 foreach (var subbedUser in ViewData["SubscribedUsers"] as IList<UsersInProjectsModel>)
                                {
                                    if (subbedUser.UserId == user.Id)
                                    {

#line default
#line hidden
                BeginContext(1326, 106, true);
                WriteLiteral("                                        <input type=\"checkbox\" class=\"form-check-input\" id=\"exampleCheck1\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1432, "\"", 1448, 1);
#line 34 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/AddUserToProject.cshtml"
WriteAttributeValue("", 1440, user.Id, 1440, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1449, 118, true);
                WriteLiteral(" name=\"userlist\" checked>\n                                        <label class=\"form-check-label\" for=\"exampleCheck1\">");
                EndContext();
                BeginContext(1568, 10, false);
#line 35 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/AddUserToProject.cshtml"
                                                                                       Write(user.Email);

#line default
#line hidden
                EndContext();
                BeginContext(1578, 9, true);
                WriteLiteral("</label>\n");
                EndContext();
#line 36 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/AddUserToProject.cshtml"
                                        skip = true;
                                     }


                                 }

#line default
#line hidden
                BeginContext(1716, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 42 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/AddUserToProject.cshtml"
                                 if (skip)
                                {
                                    skip = false;

                                }
                                else
                                {

#line default
#line hidden
                BeginContext(1950, 102, true);
                WriteLiteral("                                    <input type=\"checkbox\" class=\"form-check-input\" id=\"exampleCheck1\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2052, "\"", 2068, 1);
#line 49 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/AddUserToProject.cshtml"
WriteAttributeValue("", 2060, user.Id, 2060, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2069, 106, true);
                WriteLiteral(" name=\"userlist\">\n                                    <label class=\"form-check-label\" for=\"exampleCheck1\">");
                EndContext();
                BeginContext(2176, 10, false);
#line 50 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/AddUserToProject.cshtml"
                                                                                   Write(user.Email);

#line default
#line hidden
                EndContext();
                BeginContext(2186, 9, true);
                WriteLiteral("</label>\n");
                EndContext();
#line 51 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/AddUserToProject.cshtml"
                                }

#line default
#line hidden
                BeginContext(2229, 73, true);
                WriteLiteral("\n                            </span><br />\n                        </il>\n");
                EndContext();
#line 55 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/AddUserToProject.cshtml"
                    }

#line default
#line hidden
                BeginContext(2324, 97, true);
                WriteLiteral("                </ul>\n            </div>\n\n\n\n            <div class=\"form-group\">\n                ");
                EndContext();
                BeginContext(2421, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "68dacea751cc41caa945faec94d54cde", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 62 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/AddUserToProject.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProjectId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
#line 62 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/AddUserToProject.cshtml"
                                                                        WriteLiteral(proj);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2497, 127, true);
                WriteLiteral("\n                <input type=\"submit\" value=\"Обновить настройки доступа\" class=\"btn btn-default\" />\n            </div>\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2631, 30, true);
            WriteLiteral("\n    </div>\n</div>\n\n<div>\n    ");
            EndContext();
            BeginContext(2661, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "036eff84d9df4acb85a7583589475046", async() => {
                BeginContext(2683, 20, true);
                WriteLiteral("Вернуться к проектам");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2707, 9, true);
            WriteLiteral("\n</div>\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2734, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 74 "/Users/SanyaShmakov/Desktop/Kursach-master/Kursach/Views/Home/AddUserToProject.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Kursach.Models.UsersInProjectsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
