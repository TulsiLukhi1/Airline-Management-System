#pragma checksum "C:\Users\admin\source\repos\AirlineManagementSystem\AirlineManagementSystem\Views\FlightBooking\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0a84c5844718d5c4ed0d2058dbea9bf0b67016d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FlightBooking_Search), @"mvc.1.0.view", @"/Views/FlightBooking/Search.cshtml")]
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
#line 1 "C:\Users\admin\source\repos\AirlineManagementSystem\AirlineManagementSystem\Views\_ViewImports.cshtml"
using AirlineManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\source\repos\AirlineManagementSystem\AirlineManagementSystem\Views\_ViewImports.cshtml"
using AirlineManagementSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\source\repos\AirlineManagementSystem\AirlineManagementSystem\Views\FlightBooking\Search.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0a84c5844718d5c4ed0d2058dbea9bf0b67016d", @"/Views/FlightBooking/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9d2dc3884bca324bd3bde850423915cddd5aaff", @"/Views/_ViewImports.cshtml")]
    public class Views_FlightBooking_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AirlineManagementSystem.Models.FlightDetailsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "fid", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Booking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "FlightBooking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    \r\n");
#nullable restore
#line 4 "C:\Users\admin\source\repos\AirlineManagementSystem\AirlineManagementSystem\Views\FlightBooking\Search.cshtml"
      
        ViewData["Title"] = "Search";
        Layout = "~/Views/Shared/_UserLayout.cshtml";
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


    <div class=""main-panel"">
        <div class=""content-wrapper"">
            <div class=""row"">
                <div class=""col-lg-12 grid-margin stretch-card"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <h4 class=""card-title"">Book Flight</h4>
                            <p class=""card-description"">

                            </p>
                            <div class=""table-responsive"">
                                <table class=""table table-hover"">
                                    <thead>
                                        <tr>
                                            <th>");
#nullable restore
#line 25 "C:\Users\admin\source\repos\AirlineManagementSystem\AirlineManagementSystem\Views\FlightBooking\Search.cshtml"
                                           Write(Html.DisplayNameFor(model => model.ResFrom));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <th>");
#nullable restore
#line 26 "C:\Users\admin\source\repos\AirlineManagementSystem\AirlineManagementSystem\Views\FlightBooking\Search.cshtml"
                                           Write(Html.DisplayNameFor(model => model.ResTo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <th>");
#nullable restore
#line 27 "C:\Users\admin\source\repos\AirlineManagementSystem\AirlineManagementSystem\Views\FlightBooking\Search.cshtml"
                                           Write(Html.DisplayNameFor(model => model.ResDepDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <th>");
#nullable restore
#line 28 "C:\Users\admin\source\repos\AirlineManagementSystem\AirlineManagementSystem\Views\FlightBooking\Search.cshtml"
                                           Write(Html.DisplayNameFor(model => model.ResTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <th>");
#nullable restore
#line 29 "C:\Users\admin\source\repos\AirlineManagementSystem\AirlineManagementSystem\Views\FlightBooking\Search.cshtml"
                                           Write(Html.DisplayNameFor(model => model.PlaneSeat));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <th>");
#nullable restore
#line 30 "C:\Users\admin\source\repos\AirlineManagementSystem\AirlineManagementSystem\Views\FlightBooking\Search.cshtml"
                                           Write(Html.DisplayNameFor(model => model.ResTicketPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <th>");
#nullable restore
#line 31 "C:\Users\admin\source\repos\AirlineManagementSystem\AirlineManagementSystem\Views\FlightBooking\Search.cshtml"
                                           Write(Html.DisplayNameFor(model => model.ResPlaneType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                                        </tr>\r\n                                    </thead>\r\n                                    <tbody>\r\n");
            WriteLiteral("\r\n                                        <tr>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 40 "C:\Users\admin\source\repos\AirlineManagementSystem\AirlineManagementSystem\Views\FlightBooking\Search.cshtml"
                                           Write(ViewBag.ss.ResFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 43 "C:\Users\admin\source\repos\AirlineManagementSystem\AirlineManagementSystem\Views\FlightBooking\Search.cshtml"
                                           Write(ViewBag.ss.ResTo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 46 "C:\Users\admin\source\repos\AirlineManagementSystem\AirlineManagementSystem\Views\FlightBooking\Search.cshtml"
                                           Write(ViewBag.ss.ResDepDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 49 "C:\Users\admin\source\repos\AirlineManagementSystem\AirlineManagementSystem\Views\FlightBooking\Search.cshtml"
                                           Write(ViewBag.ss.ResTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 52 "C:\Users\admin\source\repos\AirlineManagementSystem\AirlineManagementSystem\Views\FlightBooking\Search.cshtml"
                                           Write(ViewBag.ss.PlaneSeat);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 55 "C:\Users\admin\source\repos\AirlineManagementSystem\AirlineManagementSystem\Views\FlightBooking\Search.cshtml"
                                           Write(ViewBag.ss.ResTicketPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 58 "C:\Users\admin\source\repos\AirlineManagementSystem\AirlineManagementSystem\Views\FlightBooking\Search.cshtml"
                                           Write(ViewBag.ss.ResPlaneType);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </td>
                                        </tr>

                                        <tr>
                                        </tr>

                                    </tbody>


                                </table>
                                <div style=""margin:20px"">

                                </div>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0a84c5844718d5c4ed0d2058dbea9bf0b67016d12350", async() => {
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c0a84c5844718d5c4ed0d2058dbea9bf0b67016d12645", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 73 "C:\Users\admin\source\repos\AirlineManagementSystem\AirlineManagementSystem\Views\FlightBooking\Search.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ResID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    <input type=\"submit\" value=\"Book Flight\" class=\"btn btn-primary\" />\r\n                                   \r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AirlineManagementSystem.Models.FlightDetailsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591