#pragma checksum "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Shared\_ECPDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9de9ada2af690119903c7d8a5e2311285e7e325a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ECPDetails), @"mvc.1.0.view", @"/Views/Shared/_ECPDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ECPDetails.cshtml", typeof(AspNetCore.Views_Shared__ECPDetails))]
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
#line 1 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\_ViewImports.cshtml"
using EmployeeChurnPredictive;

#line default
#line hidden
#line 2 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\_ViewImports.cshtml"
using EmployeeChurnPredictive.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9de9ada2af690119903c7d8a5e2311285e7e325a", @"/Views/Shared/_ECPDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6392e1a380d21b263a05387aff5aaf2d8e24caf2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ECPDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition skin-blue fixed sidebar-mini"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 19, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n");
            EndContext();
#line 3 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Shared\_ECPDetails.cshtml"
  

    string id = (string)ViewContext.RouteData.Values["id"];
    string name = ViewData["Name"] as string;
    string entityIcon = ViewData["EntityIcon"] as string;

#line default
#line hidden
            BeginContext(195, 8, true);
            WriteLiteral("<html>\r\n");
            EndContext();
            BeginContext(203, 407, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9de9ada2af690119903c7d8a5e2311285e7e325a4291", async() => {
                BeginContext(209, 102, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n\r\n    <title>");
                EndContext();
                BeginContext(312, 17, false);
#line 14 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Shared\_ECPDetails.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(329, 189, true);
                WriteLiteral("</title>\r\n    <!-- Tell the browser to be responsive to screen width -->\r\n    <meta content=\"width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no\" name=\"viewport\">\r\n\r\n    ");
                EndContext();
                BeginContext(519, 31, false);
#line 18 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Shared\_ECPDetails.cshtml"
Write(Html.Partial("_ECPBasicStyles"));

#line default
#line hidden
                EndContext();
                BeginContext(550, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(559, 40, false);
#line 20 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Shared\_ECPDetails.cshtml"
Write(RenderSection("Styles", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(599, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(610, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(612, 973, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9de9ada2af690119903c7d8a5e2311285e7e325a6947", async() => {
                BeginContext(671, 37, true);
                WriteLiteral("\r\n    <div class=\"wrapper\">\r\n        ");
                EndContext();
                BeginContext(709, 30, false);
#line 25 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Shared\_ECPDetails.cshtml"
   Write(Html.Partial("_ECPMainHeader"));

#line default
#line hidden
                EndContext();
                BeginContext(739, 76, true);
                WriteLiteral("\r\n        <!-- Left side column. contains the logo and sidebar -->\r\n        ");
                EndContext();
                BeginContext(816, 31, false);
#line 27 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Shared\_ECPDetails.cshtml"
   Write(Html.Partial("_ECPMainSidebar"));

#line default
#line hidden
                EndContext();
                BeginContext(847, 239, true);
                WriteLiteral("\r\n        <!-- Content Wrapper. Contains page content -->\r\n        <div class=\"content-wrapper\">\r\n            <!-- Content Header (Page header) -->\r\n            <section class=\"content-header\">\r\n                <h1>\r\n                    <i");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 1086, "\"", 1118, 2);
#line 33 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Shared\_ECPDetails.cshtml"
WriteAttributeValue("", 1094, entityIcon, 1094, 11, false);

#line default
#line hidden
                WriteAttributeValue(" ", 1105, "text-primary", 1106, 13, true);
                EndWriteAttribute();
                BeginContext(1119, 6, true);
                WriteLiteral("></i> ");
                EndContext();
                BeginContext(1126, 4, false);
#line 33 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Shared\_ECPDetails.cshtml"
                                                        Write(name);

#line default
#line hidden
                EndContext();
                BeginContext(1130, 147, true);
                WriteLiteral(" Details\r\n                </h1>\r\n            </section>\r\n            <!-- Main content -->\r\n            <section class=\"content\">\r\n                ");
                EndContext();
                BeginContext(1278, 12, false);
#line 38 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Shared\_ECPDetails.cshtml"
           Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(1290, 118, true);
                WriteLiteral("\r\n            </section>\r\n            <!-- /.content -->\r\n        </div>\r\n        <!-- /.content-wrapper -->\r\n        ");
                EndContext();
                BeginContext(1409, 26, false);
#line 43 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Shared\_ECPDetails.cshtml"
   Write(Html.Partial("_ECPFooter"));

#line default
#line hidden
                EndContext();
                BeginContext(1435, 48, true);
                WriteLiteral("\r\n\r\n    </div>\r\n    <!-- ./wrapper -->\r\n\r\n\r\n    ");
                EndContext();
                BeginContext(1484, 32, false);
#line 49 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Shared\_ECPDetails.cshtml"
Write(Html.Partial("_ECPBasicScripts"));

#line default
#line hidden
                EndContext();
                BeginContext(1516, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(1525, 41, false);
#line 51 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Shared\_ECPDetails.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(1566, 12, true);
                WriteLiteral("\r\n\r\n    \r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1585, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
