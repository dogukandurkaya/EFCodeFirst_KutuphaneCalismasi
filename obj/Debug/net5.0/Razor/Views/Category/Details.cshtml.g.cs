#pragma checksum "C:\Users\PATRON\Desktop\Visual Studio\Projeler\Asp.NetCore\EF_CodeFirst\Views\Category\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eea2c88ec90a7a4eb6fe5998f1208633e68293df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Details), @"mvc.1.0.view", @"/Views/Category/Details.cshtml")]
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
#line 1 "C:\Users\PATRON\Desktop\Visual Studio\Projeler\Asp.NetCore\EF_CodeFirst\Views\_ViewImports.cshtml"
using EF_CodeFirst;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PATRON\Desktop\Visual Studio\Projeler\Asp.NetCore\EF_CodeFirst\Views\_ViewImports.cshtml"
using EF_CodeFirst.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eea2c88ec90a7a4eb6fe5998f1208633e68293df", @"/Views/Category/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5db0de14fc8f536bc83b0e73de9d483c54b48efa", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EF_CodeFirst.Models.Entities.Category>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\PATRON\Desktop\Visual Studio\Projeler\Asp.NetCore\EF_CodeFirst\Views\Category\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"bg-dark text-light\">Kategori T??rleri Detaylar??</h1>\r\n\r\n<div class=\"bg-dark text-light\">\r\n    <h4>Kategori T??r??</h4>\r\n    <h5>Kategori ID: </h5>\r\n    <p>");
#nullable restore
#line 11 "C:\Users\PATRON\Desktop\Visual Studio\Projeler\Asp.NetCore\EF_CodeFirst\Views\Category\Details.cshtml"
  Write(Model.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <h5>Kategori Ad??</h5>\r\n    <p>");
#nullable restore
#line 13 "C:\Users\PATRON\Desktop\Visual Studio\Projeler\Asp.NetCore\EF_CodeFirst\Views\Category\Details.cshtml"
  Write(Model.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <h5>Kategori A????klams??</h5>\r\n    <p>");
#nullable restore
#line 15 "C:\Users\PATRON\Desktop\Visual Studio\Projeler\Asp.NetCore\EF_CodeFirst\Views\Category\Details.cshtml"
  Write(Model.CategoryDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <h5>Silinme Durumu</h5>\r\n    <p>");
#nullable restore
#line 17 "C:\Users\PATRON\Desktop\Visual Studio\Projeler\Asp.NetCore\EF_CodeFirst\Views\Category\Details.cshtml"
  Write(Model.IsDeleted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eea2c88ec90a7a4eb6fe5998f1208633e68293df5018", async() => {
                WriteLiteral("Kategori T??rleri Sayfas??na D??n");
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
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EF_CodeFirst.Models.Entities.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
