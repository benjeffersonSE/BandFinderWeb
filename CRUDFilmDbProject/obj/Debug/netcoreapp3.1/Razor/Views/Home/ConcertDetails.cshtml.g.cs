#pragma checksum "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\ConcertDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2df2117bdc3bcd6c705fb18760e3e4f179cadf94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ConcertDetails), @"mvc.1.0.view", @"/Views/Home/ConcertDetails.cshtml")]
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
#line 1 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\ConcertDetails.cshtml"
using BandFinder.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2df2117bdc3bcd6c705fb18760e3e4f179cadf94", @"/Views/Home/ConcertDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f41cbba57cce7ea030d100520bb666fbf719c3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ConcertDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BookingDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BandDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\ConcertDetails.cshtml"
  
    ViewData["Title"] = "Concert Details";
    ViewData["PageHeading"] = "Concert Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\ConcertDetails.cshtml"
 foreach (var item in Model.Concerts)
{
    string Time = string.Format("{0:hh\\:mm}", @item.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"BandTitle\">\r\n        <h1>\r\n            ");
#nullable restore
#line 13 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\ConcertDetails.cshtml"
       Write(item.Venue);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h1>\r\n        <br>\r\n        <h2>\r\n            ");
#nullable restore
#line 17 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\ConcertDetails.cshtml"
       Write(item.Date.ToString("MMMM dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 17 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\ConcertDetails.cshtml"
                                        Write(Time);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | &pound;");
#nullable restore
#line 17 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\ConcertDetails.cshtml"
                                                        Write((item.Price).ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 17 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\ConcertDetails.cshtml"
                                                                                          Write(item.Area);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h2>\r\n\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"BandButton\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2df2117bdc3bcd6c705fb18760e3e4f179cadf946495", async() => {
                WriteLiteral("Purchase Tickets");
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
#line 23 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\ConcertDetails.cshtml"
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
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 25 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\ConcertDetails.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 27 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\ConcertDetails.cshtml"
 foreach (var item in Model.Bands)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"BandDetails\">\r\n        <div class=\"mainImage\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2df2117bdc3bcd6c705fb18760e3e4f179cadf949488", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2df2117bdc3bcd6c705fb18760e3e4f179cadf949759", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 879, "~/images/", 879, 9, true);
#nullable restore
#line 32 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\ConcertDetails.cshtml"
AddHtmlAttributeValue("", 888, item.BandImage, 888, 15, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 32 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\ConcertDetails.cshtml"
AddHtmlAttributeValue("", 910, item.BandTitle, 910, 15, false);

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
                WriteLiteral("\r\n            ");
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
#line 31 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\ConcertDetails.cshtml"
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
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"BandInfo\">\r\n            <h2>");
#nullable restore
#line 37 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\ConcertDetails.cshtml"
           Write(item.BandTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <p>");
#nullable restore
#line 38 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\ConcertDetails.cshtml"
          Write(item.BandDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Genre: ");
#nullable restore
#line 39 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\ConcertDetails.cshtml"
                 Write(item.BandGenre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 42 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\ConcertDetails.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 44 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\ConcertDetails.cshtml"
 foreach (var item in Model.Concerts)
{
    string Time = string.Format("{0:hh\\:mm}", @item.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div id=""ConcertHolder"">
        <div class=""ConcertDetails"">
            <div class=""ConcertTitle"">
                <h2>Concert Details</h2>
            </div>
            <div class=""ConcertInfo"">
                <h3>Date:</h3>
                <p>");
#nullable restore
#line 54 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\ConcertDetails.cshtml"
              Write(item.Date.ToString("MMMM dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <h3>Doors:</h3>\r\n                <p>");
#nullable restore
#line 56 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\ConcertDetails.cshtml"
              Write(Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <h3>Costs:</h3>\r\n                <p>&pound;");
#nullable restore
#line 58 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\ConcertDetails.cshtml"
                      Write((item.Price).ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <h3>Tickets Left:</h3>\r\n                <p>");
#nullable restore
#line 60 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\ConcertDetails.cshtml"
              Write(item.RemainingTickets);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n        <div class=\"ConcertDetails\">\r\n            <div class=\"ConcertTitle\">\r\n                <h2>Venue</h2>\r\n            </div>\r\n            <div class=\"ConcertInfo\">\r\n                <p>");
#nullable restore
#line 68 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\ConcertDetails.cshtml"
              Write(item.Venue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <h3>Address:</h3>\r\n                <p>");
#nullable restore
#line 70 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\ConcertDetails.cshtml"
              Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 70 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\ConcertDetails.cshtml"
                             Write(item.PostCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 70 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\ConcertDetails.cshtml"
                                             Write(item.Area);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <h3>Featuring:</h3>\r\n");
#nullable restore
#line 72 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\ConcertDetails.cshtml"
                 foreach (var band in Model.Bands)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>");
#nullable restore
#line 74 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\ConcertDetails.cshtml"
                  Write(band.BandTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 75 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\ConcertDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 79 "C:\Users\benje\Desktop\Web\StarterCRUDFilmDbProject\CRUDFilmDbProject\Views\Home\ConcertDetails.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
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