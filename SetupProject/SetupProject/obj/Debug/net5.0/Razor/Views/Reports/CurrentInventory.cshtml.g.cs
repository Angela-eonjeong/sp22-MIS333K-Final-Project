#pragma checksum "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Reports/CurrentInventory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8b6b0ad4b5a943aee1b72fcb67aabc116d92667"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SetupProject.Views.Reports.Views_Reports_CurrentInventory), @"mvc.1.0.view", @"/Views/Reports/CurrentInventory.cshtml")]
namespace SetupProject.Views.Reports
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
#line 13 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/_ViewImports.cshtml"
using SetupProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8b6b0ad4b5a943aee1b72fcb67aabc116d92667", @"/Views/Reports/CurrentInventory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b83fecce159d15d8c541e247ac1c86be82e1daf3", @"/Views/_ViewImports.cshtml")]
    public class Views_Reports_CurrentInventory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SetupProject.Models.InventoryReportVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChooseReport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Inventory Report</h2>\r\n\r\n<p>Displaying ");
#nullable restore
#line 5 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Reports/CurrentInventory.cshtml"
         Write(ViewBag.SelectedRecords);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Records </p>

<table class=""table"">
    <thead>
        <tr>
            <th>
                Title
            </th>
            <th>
                Ammount In Stock
            </th>
            <th>
                Average Cost
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 23 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Reports/CurrentInventory.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>\r\n        ");
#nullable restore
#line 27 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Reports/CurrentInventory.cshtml"
   Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 30 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Reports/CurrentInventory.cshtml"
   Write(Html.DisplayFor(modelItem => item.BooksInInventory));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 33 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Reports/CurrentInventory.cshtml"
   Write(Html.DisplayFor(modelItem => item.WeightedAvgCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n</tr>");
#nullable restore
#line 35 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Reports/CurrentInventory.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<p>The Total Cost of the Inventory is: $");
#nullable restore
#line 39 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Reports/CurrentInventory.cshtml"
                                   Write(ViewBag.TotalCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </p>\r\n<p>The Total Value of the Inventory when sold is: $");
#nullable restore
#line 40 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Reports/CurrentInventory.cshtml"
                                              Write(ViewBag.TotalValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </p>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8b6b0ad4b5a943aee1b72fcb67aabc116d926677450", async() => {
                WriteLiteral("Back to Reports");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SetupProject.Models.InventoryReportVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
