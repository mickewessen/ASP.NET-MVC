#pragma checksum "C:\Users\Micke\Desktop\EC-WIN20\ASP.NET MVC\Inlämningsuppgift\UniversityPortal\UniversityPortal\Views\Shared\_StudentCardPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11590279e9c4c5d3020a8617f72a370e9ed8452d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__StudentCardPartial), @"mvc.1.0.view", @"/Views/Shared/_StudentCardPartial.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Micke\Desktop\EC-WIN20\ASP.NET MVC\Inlämningsuppgift\UniversityPortal\UniversityPortal\Views\_ViewImports.cshtml"
using UniversityPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Micke\Desktop\EC-WIN20\ASP.NET MVC\Inlämningsuppgift\UniversityPortal\UniversityPortal\Views\_ViewImports.cshtml"
using UniversityPortal.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Micke\Desktop\EC-WIN20\ASP.NET MVC\Inlämningsuppgift\UniversityPortal\UniversityPortal\Views\_ViewImports.cshtml"
using UniversityPortal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Micke\Desktop\EC-WIN20\ASP.NET MVC\Inlämningsuppgift\UniversityPortal\UniversityPortal\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Micke\Desktop\EC-WIN20\ASP.NET MVC\Inlämningsuppgift\UniversityPortal\UniversityPortal\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11590279e9c4c5d3020a8617f72a370e9ed8452d", @"/Views/Shared/_StudentCardPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e66ddca803fe136962acb8342ebe6d56c42c488", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__StudentCardPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UserViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    <div class=\"row row-cols-1 row-cols-md-4 g-4\">\r\n");
#nullable restore
#line 5 "C:\Users\Micke\Desktop\EC-WIN20\ASP.NET MVC\Inlämningsuppgift\UniversityPortal\UniversityPortal\Views\Shared\_StudentCardPartial.cshtml"
         foreach (var user in Model)
        {
            if (user.Roles.Contains("Student"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div id=""student"" class=""col text-center"" style=""width:20rem"">
                    <div class=""card"">
                        <img class=""card-img-top img-circle rounded-circle"" src=""https://upload.wikimedia.org/wikipedia/en/thumb/3/3b/SpongeBob_SquarePants_character.svg/1280px-SpongeBob_SquarePants_character.svg.png"" alt=""Card image cap"">

                        <div class=""card-block container"">
                            <h4 class=""card-title"">");
#nullable restore
#line 14 "C:\Users\Micke\Desktop\EC-WIN20\ASP.NET MVC\Inlämningsuppgift\UniversityPortal\UniversityPortal\Views\Shared\_StudentCardPartial.cshtml"
                                              Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "C:\Users\Micke\Desktop\EC-WIN20\ASP.NET MVC\Inlämningsuppgift\UniversityPortal\UniversityPortal\Views\Shared\_StudentCardPartial.cshtml"
                                                              Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <p class=\"card-text\">");
#nullable restore
#line 15 "C:\Users\Micke\Desktop\EC-WIN20\ASP.NET MVC\Inlämningsuppgift\UniversityPortal\UniversityPortal\Views\Shared\_StudentCardPartial.cshtml"
                                            Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 16 "C:\Users\Micke\Desktop\EC-WIN20\ASP.NET MVC\Inlämningsuppgift\UniversityPortal\UniversityPortal\Views\Shared\_StudentCardPartial.cshtml"
                             foreach (var role in user.Roles)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"card-position mr-1\">");
#nullable restore
#line 18 "C:\Users\Micke\Desktop\EC-WIN20\ASP.NET MVC\Inlämningsuppgift\UniversityPortal\UniversityPortal\Views\Shared\_StudentCardPartial.cshtml"
                                                            Write(role);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n");
#nullable restore
#line 19 "C:\Users\Micke\Desktop\EC-WIN20\ASP.NET MVC\Inlämningsuppgift\UniversityPortal\UniversityPortal\Views\Shared\_StudentCardPartial.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n\r\n                        <div class=\"d-flex justify-content-between mt-2\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11590279e9c4c5d3020a8617f72a370e9ed8452d8659", async() => {
                WriteLiteral("<i class=\"fas fa-pen-square\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "C:\Users\Micke\Desktop\EC-WIN20\ASP.NET MVC\Inlämningsuppgift\UniversityPortal\UniversityPortal\Views\Shared\_StudentCardPartial.cshtml"
                                                     WriteLiteral(user.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11590279e9c4c5d3020a8617f72a370e9ed8452d11018", async() => {
                WriteLiteral("\r\n                                <button type=\"submit\" class=\"btn\"><i class=\"fas fa-trash\"></i></button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\Users\Micke\Desktop\EC-WIN20\ASP.NET MVC\Inlämningsuppgift\UniversityPortal\UniversityPortal\Views\Shared\_StudentCardPartial.cshtml"
                                                        WriteLiteral(user.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n \r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 32 "C:\Users\Micke\Desktop\EC-WIN20\ASP.NET MVC\Inlämningsuppgift\UniversityPortal\UniversityPortal\Views\Shared\_StudentCardPartial.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UserViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
