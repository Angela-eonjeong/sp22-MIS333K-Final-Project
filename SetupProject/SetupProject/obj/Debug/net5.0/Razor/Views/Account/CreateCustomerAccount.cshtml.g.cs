#pragma checksum "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Account/CreateCustomerAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a298d6e114d6af59d031d435b13db6638d7c98e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SetupProject.Views.Account.Views_Account_CreateCustomerAccount), @"mvc.1.0.view", @"/Views/Account/CreateCustomerAccount.cshtml")]
namespace SetupProject.Views.Account
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a298d6e114d6af59d031d435b13db6638d7c98e", @"/Views/Account/CreateCustomerAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b83fecce159d15d8c541e247ac1c86be82e1daf3", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_CreateCustomerAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Account/CreateCustomerAccount.cshtml"
  
    ViewBag.Title = "Create New Customer Account";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 6 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Account/CreateCustomerAccount.cshtml"
 using (Html.BeginForm("CreateCustomerAccount", "Account", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Account/CreateCustomerAccount.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>Create a new account.</h4>\n    <hr />\n");
#nullable restore
#line 11 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Account/CreateCustomerAccount.cshtml"
Write(Html.ValidationSummary("", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>");
#nullable restore
#line 12 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Account/CreateCustomerAccount.cshtml"
   Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 14 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Account/CreateCustomerAccount.cshtml"
   Write(Html.LabelFor(m => m.Email, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 16 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Account/CreateCustomerAccount.cshtml"
       Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 20 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Account/CreateCustomerAccount.cshtml"
   Write(Html.LabelFor(m => m.FirstName, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 22 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Account/CreateCustomerAccount.cshtml"
       Write(Html.TextBoxFor(m => m.FirstName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 26 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Account/CreateCustomerAccount.cshtml"
   Write(Html.LabelFor(m => m.LastName, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 28 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Account/CreateCustomerAccount.cshtml"
       Write(Html.TextBoxFor(m => m.LastName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 32 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Account/CreateCustomerAccount.cshtml"
   Write(Html.LabelFor(m => m.Address, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 34 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Account/CreateCustomerAccount.cshtml"
       Write(Html.TextBoxFor(m => m.Address, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 38 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Account/CreateCustomerAccount.cshtml"
   Write(Html.LabelFor(m => m.City, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 40 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Account/CreateCustomerAccount.cshtml"
       Write(Html.TextBoxFor(m => m.City, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 44 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Account/CreateCustomerAccount.cshtml"
   Write(Html.LabelFor(m => m.State, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 46 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Account/CreateCustomerAccount.cshtml"
       Write(Html.TextBoxFor(m => m.State, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 50 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Account/CreateCustomerAccount.cshtml"
   Write(Html.LabelFor(m => m.Zip, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 52 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Account/CreateCustomerAccount.cshtml"
       Write(Html.TextBoxFor(m => m.Zip, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 56 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Account/CreateCustomerAccount.cshtml"
   Write(Html.LabelFor(m => m.PhoneNumber, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 58 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Account/CreateCustomerAccount.cshtml"
       Write(Html.TextBoxFor(m => m.PhoneNumber, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 62 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Account/CreateCustomerAccount.cshtml"
   Write(Html.LabelFor(m => m.Password, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 64 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Account/CreateCustomerAccount.cshtml"
       Write(Html.PasswordFor(m => m.Password, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 68 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Account/CreateCustomerAccount.cshtml"
   Write(Html.LabelFor(m => m.ConfirmPassword, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 70 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Account/CreateCustomerAccount.cshtml"
       Write(Html.PasswordFor(m => m.ConfirmPassword, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n    <div class=\"form-group\">\n        <div class=\"col-md-offset-2 col-md-10\">\n            <button type=\"submit\" class=\"btn btn-warning\">Create User <i class=\"fas fa-user-plus\"></i></button>\n        </div>\n    </div>\n");
#nullable restore
#line 78 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/Final/spr22team12finalproject 2/SetupProject/SetupProject/Views/Account/CreateCustomerAccount.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
