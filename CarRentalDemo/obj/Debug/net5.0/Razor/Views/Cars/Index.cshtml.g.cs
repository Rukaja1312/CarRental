#pragma checksum "C:\Users\User\Desktop\05.09Edit\CarRentalDemo\CarRentalDemo\Views\Cars\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1afd47e0bbaeed46710a1a570bb2e232d0598a10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_Index), @"mvc.1.0.view", @"/Views/Cars/Index.cshtml")]
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
#line 1 "C:\Users\User\Desktop\05.09Edit\CarRentalDemo\CarRentalDemo\Views\_ViewImports.cshtml"
using CarRentalDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\05.09Edit\CarRentalDemo\CarRentalDemo\Views\_ViewImports.cshtml"
using CarRentalDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\User\Desktop\05.09Edit\CarRentalDemo\CarRentalDemo\Views\Cars\Index.cshtml"
using CarRentalDemo.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\05.09Edit\CarRentalDemo\CarRentalDemo\Views\Cars\Index.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1afd47e0bbaeed46710a1a570bb2e232d0598a10", @"/Views/Cars/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bee2ca4089012ddf10af0c8d1fab99e882f48400", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cars_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CarRentalDemo.DTOs.CarViewDTO>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cars", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\User\Desktop\05.09Edit\CarRentalDemo\CarRentalDemo\Views\Cars\Index.cshtml"
  
    ViewData["Title"] = "All Cars";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\User\Desktop\05.09Edit\CarRentalDemo\CarRentalDemo\Views\Cars\Index.cshtml"
  
    var brand = context.SearchByBrands.ToList();

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>All Cars</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1afd47e0bbaeed46710a1a570bb2e232d0598a105331", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\User\Desktop\05.09Edit\CarRentalDemo\CarRentalDemo\Views\Cars\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Brand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\User\Desktop\05.09Edit\CarRentalDemo\CarRentalDemo\Views\Cars\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\User\Desktop\05.09Edit\CarRentalDemo\CarRentalDemo\Views\Cars\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\User\Desktop\05.09Edit\CarRentalDemo\CarRentalDemo\Views\Cars\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\User\Desktop\05.09Edit\CarRentalDemo\CarRentalDemo\Views\Cars\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
#nullable restore
#line 40 "C:\Users\User\Desktop\05.09Edit\CarRentalDemo\CarRentalDemo\Views\Cars\Index.cshtml"
             if (User.IsInRole("Admin"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th>\r\n                    Options\r\n                </th>\r\n");
#nullable restore
#line 45 "C:\Users\User\Desktop\05.09Edit\CarRentalDemo\CarRentalDemo\Views\Cars\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 50 "C:\Users\User\Desktop\05.09Edit\CarRentalDemo\CarRentalDemo\Views\Cars\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "C:\Users\User\Desktop\05.09Edit\CarRentalDemo\CarRentalDemo\Views\Cars\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Brand.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "C:\Users\User\Desktop\05.09Edit\CarRentalDemo\CarRentalDemo\Views\Cars\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 60 "C:\Users\User\Desktop\05.09Edit\CarRentalDemo\CarRentalDemo\Views\Cars\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 63 "C:\Users\User\Desktop\05.09Edit\CarRentalDemo\CarRentalDemo\Views\Cars\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 66 "C:\Users\User\Desktop\05.09Edit\CarRentalDemo\CarRentalDemo\Views\Cars\Index.cshtml"
                     if (item.Image != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=\"", 1776, "\"", 1842, 2);
            WriteAttributeValue("", 1782, "data:image/jpeg;base64,", 1782, 23, true);
#nullable restore
#line 68 "C:\Users\User\Desktop\05.09Edit\CarRentalDemo\CarRentalDemo\Views\Cars\Index.cshtml"
WriteAttributeValue("", 1805, Convert.ToBase64String(item.Image), 1805, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:180px;height:180px;\" />\r\n");
#nullable restore
#line 69 "C:\Users\User\Desktop\05.09Edit\CarRentalDemo\CarRentalDemo\Views\Cars\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n");
#nullable restore
#line 71 "C:\Users\User\Desktop\05.09Edit\CarRentalDemo\CarRentalDemo\Views\Cars\Index.cshtml"
                 if (User.IsInRole("Admin"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1afd47e0bbaeed46710a1a570bb2e232d0598a1011780", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "C:\Users\User\Desktop\05.09Edit\CarRentalDemo\CarRentalDemo\Views\Cars\Index.cshtml"
                                                                     WriteLiteral(item.Id);

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
            WriteLiteral(" |\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1afd47e0bbaeed46710a1a570bb2e232d0598a1014194", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "C:\Users\User\Desktop\05.09Edit\CarRentalDemo\CarRentalDemo\Views\Cars\Index.cshtml"
                                                                       WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 77 "C:\Users\User\Desktop\05.09Edit\CarRentalDemo\CarRentalDemo\Views\Cars\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 79 "C:\Users\User\Desktop\05.09Edit\CarRentalDemo\CarRentalDemo\Views\Cars\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ApplicationDbContext context { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CarRentalDemo.DTOs.CarViewDTO>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591