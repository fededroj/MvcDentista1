#pragma checksum "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "724c7cb6709ce3ae52d70dde645f65846e1055f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dientes_Details), @"mvc.1.0.view", @"/Views/Dientes/Details.cshtml")]
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
#line 1 "C:\Users\feded\Downloads\MvcDentista1\Views\_ViewImports.cshtml"
using MvcDentista1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\feded\Downloads\MvcDentista1\Views\_ViewImports.cshtml"
using MvcDentista1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"724c7cb6709ce3ae52d70dde645f65846e1055f8", @"/Views/Dientes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85b105d3d3621560dc254bc6c8d4c8c5a8c29d92", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Dientes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcDentista1.Models.Diente>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pacientes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalles</h1>\r\n\r\n<div>\r\n    \r\n    <hr/>\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdPaciente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdPaciente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diente1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diente1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diente2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diente2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diente3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diente3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diente4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diente4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diente5));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diente5));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diente6));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diente6));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diente7));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diente7));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diente8));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diente8));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diente9));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diente9));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diente10));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diente10));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diente11));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diente11));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diente12));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diente12));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 92 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diente13));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 95 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diente13));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 98 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diente14));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 101 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diente14));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 104 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diente15));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 107 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diente15));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 110 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diente16));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 113 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diente16));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 116 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diente17));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 119 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diente17));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 122 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diente18));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 125 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diente18));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 128 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diente19));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 131 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diente19));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 134 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diente20));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 137 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diente20));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 140 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diente21));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 143 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diente21));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 146 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diente22));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 149 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diente22));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 152 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diente23));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 155 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diente23));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 158 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diente24));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 161 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diente24));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 164 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diente25));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 167 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diente25));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 170 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diente26));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 173 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diente26));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 176 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diente27));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 179 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diente27));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 182 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diente28));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 185 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diente28));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 188 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diente29));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 191 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diente29));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 194 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diente30));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 197 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diente30));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 200 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diente31));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 203 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diente31));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 206 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diente32));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 209 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diente32));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "724c7cb6709ce3ae52d70dde645f65846e1055f825446", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 214 "C:\Users\feded\Downloads\MvcDentista1\Views\Dientes\Details.cshtml"
                                                WriteLiteral(Model.Id);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "724c7cb6709ce3ae52d70dde645f65846e1055f827683", async() => {
                WriteLiteral("Devuelta al Inicio");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcDentista1.Models.Diente> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
