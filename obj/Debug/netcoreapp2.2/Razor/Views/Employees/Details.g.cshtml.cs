#pragma checksum "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9ef2277757100daddde4cd31b807ca948a50c7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Details), @"mvc.1.0.view", @"/Views/Employees/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employees/Details.cshtml", typeof(AspNetCore.Views_Employees_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9ef2277757100daddde4cd31b807ca948a50c7a", @"/Views/Employees/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6392e1a380d21b263a05387aff5aaf2d8e24caf2", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ECP.Core.Entities.Employee>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(64, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(93, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9ef2277757100daddde4cd31b807ca948a50c7a4507", async() => {
                BeginContext(99, 89, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Details</title>\r\n");
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
            BeginContext(195, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(197, 5915, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9ef2277757100daddde4cd31b807ca948a50c7a5784", async() => {
                BeginContext(203, 104, true);
                WriteLiteral("\r\n\r\n<div>\r\n    <h4>Employee</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(308, 45, false);
#line 21 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Attrition));

#line default
#line hidden
                EndContext();
                BeginContext(353, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(397, 41, false);
#line 24 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Attrition));

#line default
#line hidden
                EndContext();
                BeginContext(438, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(482, 39, false);
#line 27 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
                EndContext();
                BeginContext(521, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(565, 35, false);
#line 30 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
                EndContext();
                BeginContext(600, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(644, 50, false);
#line 33 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BusinessTravel));

#line default
#line hidden
                EndContext();
                BeginContext(694, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(738, 46, false);
#line 36 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.BusinessTravel));

#line default
#line hidden
                EndContext();
                BeginContext(784, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(828, 45, false);
#line 39 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DailyRate));

#line default
#line hidden
                EndContext();
                BeginContext(873, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(917, 41, false);
#line 42 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.DailyRate));

#line default
#line hidden
                EndContext();
                BeginContext(958, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1002, 46, false);
#line 45 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
                EndContext();
                BeginContext(1048, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1092, 42, false);
#line 48 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Department));

#line default
#line hidden
                EndContext();
                BeginContext(1134, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1178, 52, false);
#line 51 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DistanceFromHome));

#line default
#line hidden
                EndContext();
                BeginContext(1230, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1274, 48, false);
#line 54 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.DistanceFromHome));

#line default
#line hidden
                EndContext();
                BeginContext(1322, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1366, 45, false);
#line 57 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Education));

#line default
#line hidden
                EndContext();
                BeginContext(1411, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1455, 41, false);
#line 60 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Education));

#line default
#line hidden
                EndContext();
                BeginContext(1496, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1540, 50, false);
#line 63 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EducationField));

#line default
#line hidden
                EndContext();
                BeginContext(1590, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1634, 46, false);
#line 66 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.EducationField));

#line default
#line hidden
                EndContext();
                BeginContext(1680, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1724, 59, false);
#line 69 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EnvironmentSatisfaction));

#line default
#line hidden
                EndContext();
                BeginContext(1783, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1827, 55, false);
#line 72 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.EnvironmentSatisfaction));

#line default
#line hidden
                EndContext();
                BeginContext(1882, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1926, 42, false);
#line 75 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
                EndContext();
                BeginContext(1968, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(2012, 38, false);
#line 78 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
                EndContext();
                BeginContext(2050, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(2094, 46, false);
#line 81 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HourlyRate));

#line default
#line hidden
                EndContext();
                BeginContext(2140, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(2184, 42, false);
#line 84 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.HourlyRate));

#line default
#line hidden
                EndContext();
                BeginContext(2226, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(2270, 50, false);
#line 87 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.JobInvolvement));

#line default
#line hidden
                EndContext();
                BeginContext(2320, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(2364, 46, false);
#line 90 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.JobInvolvement));

#line default
#line hidden
                EndContext();
                BeginContext(2410, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(2454, 44, false);
#line 93 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.JobLevel));

#line default
#line hidden
                EndContext();
                BeginContext(2498, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(2542, 40, false);
#line 96 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.JobLevel));

#line default
#line hidden
                EndContext();
                BeginContext(2582, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(2626, 43, false);
#line 99 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.JobRole));

#line default
#line hidden
                EndContext();
                BeginContext(2669, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(2713, 39, false);
#line 102 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.JobRole));

#line default
#line hidden
                EndContext();
                BeginContext(2752, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(2796, 51, false);
#line 105 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.JobSatisfaction));

#line default
#line hidden
                EndContext();
                BeginContext(2847, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(2891, 47, false);
#line 108 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.JobSatisfaction));

#line default
#line hidden
                EndContext();
                BeginContext(2938, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(2982, 49, false);
#line 111 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaritalStatus));

#line default
#line hidden
                EndContext();
                BeginContext(3031, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(3075, 45, false);
#line 114 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaritalStatus));

#line default
#line hidden
                EndContext();
                BeginContext(3120, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(3164, 49, false);
#line 117 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MonthlyIncome));

#line default
#line hidden
                EndContext();
                BeginContext(3213, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(3257, 45, false);
#line 120 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.MonthlyIncome));

#line default
#line hidden
                EndContext();
                BeginContext(3302, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(3346, 47, false);
#line 123 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MonthlyRate));

#line default
#line hidden
                EndContext();
                BeginContext(3393, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(3437, 43, false);
#line 126 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.MonthlyRate));

#line default
#line hidden
                EndContext();
                BeginContext(3480, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(3524, 54, false);
#line 129 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumCompaniesWorked));

#line default
#line hidden
                EndContext();
                BeginContext(3578, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(3622, 50, false);
#line 132 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumCompaniesWorked));

#line default
#line hidden
                EndContext();
                BeginContext(3672, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(3716, 44, false);
#line 135 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OverTime));

#line default
#line hidden
                EndContext();
                BeginContext(3760, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(3804, 40, false);
#line 138 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.OverTime));

#line default
#line hidden
                EndContext();
                BeginContext(3844, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(3888, 53, false);
#line 141 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PercentSalaryHike));

#line default
#line hidden
                EndContext();
                BeginContext(3941, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(3985, 49, false);
#line 144 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.PercentSalaryHike));

#line default
#line hidden
                EndContext();
                BeginContext(4034, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(4078, 53, false);
#line 147 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PerformanceRating));

#line default
#line hidden
                EndContext();
                BeginContext(4131, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(4175, 49, false);
#line 150 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.PerformanceRating));

#line default
#line hidden
                EndContext();
                BeginContext(4224, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(4268, 60, false);
#line 153 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RelationshipSatisfaction));

#line default
#line hidden
                EndContext();
                BeginContext(4328, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(4372, 56, false);
#line 156 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.RelationshipSatisfaction));

#line default
#line hidden
                EndContext();
                BeginContext(4428, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(4472, 52, false);
#line 159 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StockOptionLevel));

#line default
#line hidden
                EndContext();
                BeginContext(4524, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(4568, 48, false);
#line 162 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.StockOptionLevel));

#line default
#line hidden
                EndContext();
                BeginContext(4616, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(4660, 53, false);
#line 165 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalWorkingYears));

#line default
#line hidden
                EndContext();
                BeginContext(4713, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(4757, 49, false);
#line 168 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.TotalWorkingYears));

#line default
#line hidden
                EndContext();
                BeginContext(4806, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(4850, 51, false);
#line 171 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.WorkLifeBalance));

#line default
#line hidden
                EndContext();
                BeginContext(4901, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(4945, 47, false);
#line 174 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.WorkLifeBalance));

#line default
#line hidden
                EndContext();
                BeginContext(4992, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(5036, 50, false);
#line 177 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.YearsAtCompany));

#line default
#line hidden
                EndContext();
                BeginContext(5086, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(5130, 46, false);
#line 180 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.YearsAtCompany));

#line default
#line hidden
                EndContext();
                BeginContext(5176, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(5220, 54, false);
#line 183 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.YearsInCurrentRole));

#line default
#line hidden
                EndContext();
                BeginContext(5274, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(5318, 50, false);
#line 186 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.YearsInCurrentRole));

#line default
#line hidden
                EndContext();
                BeginContext(5368, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(5412, 59, false);
#line 189 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.YearsSinceLastPromotion));

#line default
#line hidden
                EndContext();
                BeginContext(5471, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(5515, 55, false);
#line 192 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.YearsSinceLastPromotion));

#line default
#line hidden
                EndContext();
                BeginContext(5570, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(5614, 56, false);
#line 195 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.YearsWithCurrManager));

#line default
#line hidden
                EndContext();
                BeginContext(5670, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(5714, 52, false);
#line 198 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.YearsWithCurrManager));

#line default
#line hidden
                EndContext();
                BeginContext(5766, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(5810, 45, false);
#line 201 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsTrained));

#line default
#line hidden
                EndContext();
                BeginContext(5855, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(5899, 41, false);
#line 204 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsTrained));

#line default
#line hidden
                EndContext();
                BeginContext(5940, 47, true);
                WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
                EndContext();
                BeginContext(5987, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9ef2277757100daddde4cd31b807ca948a50c7a34431", async() => {
                    BeginContext(6041, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
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
#line 209 "C:\Users\Mihn1\source\DSS\EmployeeChurnPredictive\EmployeeChurnPredictive\Views\Employees\Details.cshtml"
                           WriteLiteral(Model.EmployeeId);

#line default
#line hidden
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
                EndContext();
                BeginContext(6049, 8, true);
                WriteLiteral(" |\r\n    ");
                EndContext();
                BeginContext(6057, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9ef2277757100daddde4cd31b807ca948a50c7a36907", async() => {
                    BeginContext(6079, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6095, 10, true);
                WriteLiteral("\r\n</div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6112, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ECP.Core.Entities.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591