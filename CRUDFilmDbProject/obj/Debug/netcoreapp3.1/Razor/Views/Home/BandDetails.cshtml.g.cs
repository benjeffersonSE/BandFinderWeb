#pragma checksum "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\BandDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a2c775d2db95b8e56d69d5f3d6694b0d51a1c05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_BandDetails), @"mvc.1.0.view", @"/Views/Home/BandDetails.cshtml")]
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
#line 1 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\_ViewImports.cshtml"
using BandFinder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\BandDetails.cshtml"
using BandFinder.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a2c775d2db95b8e56d69d5f3d6694b0d51a1c05", @"/Views/Home/BandDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f41cbba57cce7ea030d100520bb666fbf719c3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BandDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BookingDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConcertDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\BandDetails.cshtml"
 foreach (var item in Model.Bands) 
{
    {
        ViewData["Title"] = @item.BandTitle;
        ViewData["PageHeading"] = @item.BandTitle;
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"BandTitle\">\r\n        <h1>\r\n            ");
#nullable restore
#line 13 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\BandDetails.cshtml"
       Write(item.BandTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n        </h1>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"BandButton\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a2c775d2db95b8e56d69d5f3d6694b0d51a1c055007", async() => {
                WriteLiteral("Request Booking");
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
#nullable restore
#line 18 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\BandDetails.cshtml"
                                                               WriteLiteral(item.BandID);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"BandDetails\">\r\n            <div class=\"mainImage\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4a2c775d2db95b8e56d69d5f3d6694b0d51a1c057556", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 555, "~/images/", 555, 9, true);
#nullable restore
#line 23 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\BandDetails.cshtml"
AddHtmlAttributeValue("", 564, item.BandImage, 564, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 23 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\BandDetails.cshtml"
AddHtmlAttributeValue("", 586, item.BandTitle, 586, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"BandInfo\">\r\n                <h2>");
#nullable restore
#line 27 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\BandDetails.cshtml"
               Write(item.BandTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <p>");
#nullable restore
#line 28 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\BandDetails.cshtml"
              Write(item.BandDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Genre: ");
#nullable restore
#line 29 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\BandDetails.cshtml"
                     Write(item.BandGenre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Founded:  ");
#nullable restore
#line 30 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\BandDetails.cshtml"
                        Write(item.BandDate.ToString("yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Location: ");
#nullable restore
#line 31 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\BandDetails.cshtml"
                        Write(item.BandArea);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>Avg Rating: ");
#nullable restore
#line 32 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\BandDetails.cshtml"
                          Write(item.Stars);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / 5</p>\r\n                <p>Hire Price: &pound;");
#nullable restore
#line 33 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\BandDetails.cshtml"
                                  Write((item.BandPrice).ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n            </div>\r\n    </div>\r\n");
#nullable restore
#line 37 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\BandDetails.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"concertTable\">\r\n\r\n    <h1>Concerts</h1>\r\n");
#nullable restore
#line 43 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\BandDetails.cshtml"
     foreach (var item in Model.Concerts)
    {
        if (Model.Concerts.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"concertRow\">\r\n                <div class=\"concertDate\">\r\n                    ");
#nullable restore
#line 49 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\BandDetails.cshtml"
               Write(item.Date.ToString("MMMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <br>\r\n                    ");
#nullable restore
#line 51 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\BandDetails.cshtml"
               Write(item.Date.ToString("dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"concertSummery\">\r\n                    ");
#nullable restore
#line 55 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\BandDetails.cshtml"
               Write(item.Venue);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <br>\r\n                    ");
#nullable restore
#line 57 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\BandDetails.cshtml"
               Write(item.Date.ToString("MMMM dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 57 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\BandDetails.cshtml"
                                                Write(item.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"concertTickets\">\r\n                    <div class=\"BandButton\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a2c775d2db95b8e56d69d5f3d6694b0d51a1c0514130", async() => {
                WriteLiteral("Tickets");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\BandDetails.cshtml"
                                                                               WriteLiteral(item.ConcertID);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 66 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\BandDetails.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\BandDetails.cshtml"
     if (Model.Concerts.Count == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>Oh no! There are no concerts!</h2>\r\n        <p>No need to worry. You can find more concerts and bands in the local area. Even better, book the band.</p>\r\n");
#nullable restore
#line 72 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\BandDetails.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591