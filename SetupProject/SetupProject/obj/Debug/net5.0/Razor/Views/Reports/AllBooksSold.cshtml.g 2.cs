#pragma checksum "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject/SetupProject/SetupProject/Views/Reports/AllBooksSold.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0421b20268e0f008eac4128d08b116021c425a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SetupProject.Views.Reports.Views_Reports_AllBooksSold), @"mvc.1.0.view", @"/Views/Reports/AllBooksSold.cshtml")]
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
#line 13 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject/SetupProject/SetupProject/Views/_ViewImports.cshtml"
using SetupProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0421b20268e0f008eac4128d08b116021c425a5", @"/Views/Reports/AllBooksSold.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b83fecce159d15d8c541e247ac1c86be82e1daf3", @"/Views/_ViewImports.cshtml")]
    public class Views_Reports_AllBooksSold : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SetupProject.Models.AllBooksReportViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>\r\n    All Books Report\r\n</h2>\r\n\r\n<p>Displaying ");
#nullable restore
#line 8 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject/SetupProject/SetupProject/Views/Reports/AllBooksSold.cshtml"
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
                Quantity
            </th>
            <th>
                Order Number
            </th>
            <th>
                Customer
            </th>
            <th>
                Selling Price
            </th>
            <th>
                Weighted Average Cost
            </th>
            <th>
                Profit Margin
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 37 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject/SetupProject/SetupProject/Views/Reports/AllBooksSold.cshtml"
         foreach (AllBooksReportViewModel item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>\r\n        ");
#nullable restore
#line 41 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject/SetupProject/SetupProject/Views/Reports/AllBooksSold.cshtml"
   Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 44 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject/SetupProject/SetupProject/Views/Reports/AllBooksSold.cshtml"
   Write(Html.DisplayFor(modelItem => item.BookQuantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 47 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject/SetupProject/SetupProject/Views/Reports/AllBooksSold.cshtml"
   Write(Html.DisplayFor(modelItem => item.OrderNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 50 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject/SetupProject/SetupProject/Views/Reports/AllBooksSold.cshtml"
   Write(Html.DisplayFor(modelItem => item.CustomerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 53 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject/SetupProject/SetupProject/Views/Reports/AllBooksSold.cshtml"
   Write(Html.DisplayFor(modelItem => item.SellingPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 56 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject/SetupProject/SetupProject/Views/Reports/AllBooksSold.cshtml"
   Write(Html.DisplayFor(modelItem => item.WeightedAvgCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 59 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject/SetupProject/SetupProject/Views/Reports/AllBooksSold.cshtml"
   Write(Html.DisplayFor(modelItem => item.ProfitMargin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n</tr>");
#nullable restore
#line 61 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject/SetupProject/SetupProject/Views/Reports/AllBooksSold.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SetupProject.Models.AllBooksReportViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
