#pragma checksum "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Shared\_ECPDelete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83f836903c9e6e8676e4c3fc0451be9dcc913cc5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ECPDelete), @"mvc.1.0.view", @"/Views/Shared/_ECPDelete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ECPDelete.cshtml", typeof(AspNetCore.Views_Shared__ECPDelete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83f836903c9e6e8676e4c3fc0451be9dcc913cc5", @"/Views/Shared/_ECPDelete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6392e1a380d21b263a05387aff5aaf2d8e24caf2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ECPDelete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition skin-blue fixed sidebar-mini"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 19, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n");
            EndContext();
#line 3 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Shared\_ECPDelete.cshtml"
  

    string id = (string)ViewContext.RouteData.Values["id"];
    string name = ViewData["Name"] as string;
    string entityIcon = ViewData["EntityIcon"] as string;
    bool isCanDeleted = true;
    if (ViewData["IsCanDeleted"] != null && (bool)ViewData["IsCanDeleted"] != true)
    {
        isCanDeleted = false;
    }

#line default
#line hidden
            BeginContext(356, 8, true);
            WriteLiteral("<html>\r\n");
            EndContext();
            BeginContext(364, 407, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83f836903c9e6e8676e4c3fc0451be9dcc913cc56239", async() => {
                BeginContext(370, 102, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n\r\n    <title>");
                EndContext();
                BeginContext(473, 17, false);
#line 19 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Shared\_ECPDelete.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(490, 189, true);
                WriteLiteral("</title>\r\n    <!-- Tell the browser to be responsive to screen width -->\r\n    <meta content=\"width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no\" name=\"viewport\">\r\n\r\n    ");
                EndContext();
                BeginContext(680, 31, false);
#line 23 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Shared\_ECPDelete.cshtml"
Write(Html.Partial("_ECPBasicStyles"));

#line default
#line hidden
                EndContext();
                BeginContext(711, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(720, 40, false);
#line 25 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Shared\_ECPDelete.cshtml"
Write(RenderSection("Styles", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(760, 4, true);
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
            BeginContext(771, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(773, 2612, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83f836903c9e6e8676e4c3fc0451be9dcc913cc58893", async() => {
                BeginContext(832, 37, true);
                WriteLiteral("\r\n    <div class=\"wrapper\">\r\n        ");
                EndContext();
                BeginContext(870, 30, false);
#line 30 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Shared\_ECPDelete.cshtml"
   Write(Html.Partial("_ECPMainHeader"));

#line default
#line hidden
                EndContext();
                BeginContext(900, 76, true);
                WriteLiteral("\r\n        <!-- Left side column. contains the logo and sidebar -->\r\n        ");
                EndContext();
                BeginContext(977, 31, false);
#line 32 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Shared\_ECPDelete.cshtml"
   Write(Html.Partial("_ECPMainSidebar"));

#line default
#line hidden
                EndContext();
                BeginContext(1008, 239, true);
                WriteLiteral("\r\n        <!-- Content Wrapper. Contains page content -->\r\n        <div class=\"content-wrapper\">\r\n            <!-- Content Header (Page header) -->\r\n            <section class=\"content-header\">\r\n                <h1>\r\n                    <i");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 1247, "\"", 1279, 2);
#line 38 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Shared\_ECPDelete.cshtml"
WriteAttributeValue("", 1255, entityIcon, 1255, 11, false);

#line default
#line hidden
                WriteAttributeValue(" ", 1266, "text-primary", 1267, 13, true);
                EndWriteAttribute();
                BeginContext(1280, 13, true);
                WriteLiteral("></i> Delete ");
                EndContext();
                BeginContext(1294, 4, false);
#line 38 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Shared\_ECPDelete.cshtml"
                                                               Write(name);

#line default
#line hidden
                EndContext();
                BeginContext(1298, 390, true);
                WriteLiteral(@" ?
                </h1>
            </section>
            <!-- Main content -->
            <section class=""content"">
                <div class=""row"">
                    <div class=""col-md-9"">
                        <!-- Default box -->
                        <div class=""box box-danger"">

                            <div class=""box-body"">
                                ");
                EndContext();
                BeginContext(1689, 12, false);
#line 49 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Shared\_ECPDelete.cshtml"
                           Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(1701, 235, true);
                WriteLiteral("\r\n                            </div>\r\n                            <!-- /.box-body -->\r\n                            <div class=\"box-footer\">\r\n                                <div class=\"form-group\">\r\n                                    ");
                EndContext();
                BeginContext(1936, 511, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83f836903c9e6e8676e4c3fc0451be9dcc913cc512408", async() => {
                    BeginContext(1962, 42, true);
                    WriteLiteral("\r\n                                        ");
                    EndContext();
                    BeginContext(2004, 37, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "83f836903c9e6e8676e4c3fc0451be9dcc913cc512853", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 55 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Shared\_ECPDelete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => id);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2041, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 56 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Shared\_ECPDelete.cshtml"
                                         if (isCanDeleted)
                                        {

#line default
#line hidden
                    BeginContext(2146, 107, true);
                    WriteLiteral("                                            <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n");
                    EndContext();
#line 59 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Shared\_ECPDelete.cshtml"

                                        }

#line default
#line hidden
                    BeginContext(2298, 42, true);
                    WriteLiteral("\r\n                                        ");
                    EndContext();
                    BeginContext(2340, 62, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83f836903c9e6e8676e4c3fc0451be9dcc913cc515620", async() => {
                        BeginContext(2386, 12, true);
                        WriteLiteral("Back to List");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2402, 38, true);
                    WriteLiteral("\r\n                                    ");
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
                BeginContext(2447, 228, true);
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <!-- /.box-footer-->\r\n                        </div>\r\n                        <!-- /.box -->\r\n                    </div>\r\n");
                EndContext();
                BeginContext(3070, 142, true);
                WriteLiteral("                </div>\r\n\r\n            </section>\r\n            <!-- /.content -->\r\n        </div>\r\n        <!-- /.content-wrapper -->\r\n        ");
                EndContext();
                BeginContext(3213, 26, false);
#line 84 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Shared\_ECPDelete.cshtml"
   Write(Html.Partial("_ECPFooter"));

#line default
#line hidden
                EndContext();
                BeginContext(3239, 48, true);
                WriteLiteral("\r\n\r\n    </div>\r\n    <!-- ./wrapper -->\r\n\r\n\r\n    ");
                EndContext();
                BeginContext(3288, 32, false);
#line 90 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Shared\_ECPDelete.cshtml"
Write(Html.Partial("_ECPBasicScripts"));

#line default
#line hidden
                EndContext();
                BeginContext(3320, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(3329, 41, false);
#line 92 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Shared\_ECPDelete.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(3370, 8, true);
                WriteLiteral("\r\n\r\n\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3385, 11, true);
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
