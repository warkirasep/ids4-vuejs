#pragma checksum "D:\IDS4\VueApi\QuickstartIdentityServer\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dac13dd24c97bf9b7bab2ff7570ffad14bd0cc65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
#line 1 "D:\IDS4\VueApi\QuickstartIdentityServer\Views\_ViewImports.cshtml"
using IdentityServer4.Quickstart.UI;

#line default
#line hidden
#line 1 "D:\IDS4\VueApi\QuickstartIdentityServer\Views\Shared\Error.cshtml"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dac13dd24c97bf9b7bab2ff7570ffad14bd0cc65", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57b49bb18fbe88f2fb7e20eb130e64338d7f2c37", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(94, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "D:\IDS4\VueApi\QuickstartIdentityServer\Views\Shared\Error.cshtml"
  
    var error = Model?.Error?.Error;
    var errorDescription = host.IsDevelopment() ? Model?.Error?.ErrorDescription : null;
    var request_id = Model?.Error?.RequestId;

#line default
#line hidden
            BeginContext(278, 243, true);
            WriteLiteral("\r\n<div class=\"error-page\">\r\n    <div class=\"page-header\">\r\n        <h1>Error</h1>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-6\">\r\n            <div class=\"alert alert-danger\">\r\n                Sorry, there was an error\r\n\r\n");
            EndContext();
#line 21 "D:\IDS4\VueApi\QuickstartIdentityServer\Views\Shared\Error.cshtml"
                 if (error != null)
                {

#line default
#line hidden
            BeginContext(577, 90, true);
            WriteLiteral("                    <strong>\r\n                        <em>\r\n                            : ");
            EndContext();
            BeginContext(668, 5, false);
#line 25 "D:\IDS4\VueApi\QuickstartIdentityServer\Views\Shared\Error.cshtml"
                         Write(error);

#line default
#line hidden
            EndContext();
            BeginContext(673, 64, true);
            WriteLiteral("\r\n                        </em>\r\n                    </strong>\r\n");
            EndContext();
#line 28 "D:\IDS4\VueApi\QuickstartIdentityServer\Views\Shared\Error.cshtml"

                    if (errorDescription != null)
                    {

#line default
#line hidden
            BeginContext(813, 29, true);
            WriteLiteral("                        <div>");
            EndContext();
            BeginContext(843, 16, false);
#line 31 "D:\IDS4\VueApi\QuickstartIdentityServer\Views\Shared\Error.cshtml"
                        Write(errorDescription);

#line default
#line hidden
            EndContext();
            BeginContext(859, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 32 "D:\IDS4\VueApi\QuickstartIdentityServer\Views\Shared\Error.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(909, 22, true);
            WriteLiteral("            </div>\r\n\r\n");
            EndContext();
#line 36 "D:\IDS4\VueApi\QuickstartIdentityServer\Views\Shared\Error.cshtml"
             if (request_id != null)
            {

#line default
#line hidden
            BeginContext(984, 52, true);
            WriteLiteral("                <div class=\"request-id\">Request Id: ");
            EndContext();
            BeginContext(1037, 10, false);
#line 38 "D:\IDS4\VueApi\QuickstartIdentityServer\Views\Shared\Error.cshtml"
                                               Write(request_id);

#line default
#line hidden
            EndContext();
            BeginContext(1047, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 39 "D:\IDS4\VueApi\QuickstartIdentityServer\Views\Shared\Error.cshtml"
            }

#line default
#line hidden
            BeginContext(1070, 36, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHostingEnvironment host { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
