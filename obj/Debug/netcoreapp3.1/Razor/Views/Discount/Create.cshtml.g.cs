#pragma checksum "C:\Users\morga\Desktop\FinalProjectPhase\NerdCraft\Views\Discount\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "765a42b165f88a45bb25b7d5c100cbeeed47728b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Discount_Create), @"mvc.1.0.view", @"/Views/Discount/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"765a42b165f88a45bb25b7d5c100cbeeed47728b", @"/Views/Discount/Create.cshtml")]
    public class Views_Discount_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NerdCraft.Models.discount>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\morga\Desktop\FinalProjectPhase\NerdCraft\Views\Discount\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>discount</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""DiscountPercent"" class=""control-label""></label>
                <input asp-for=""DiscountPercent"" class=""form-control"" />
                <span asp-validation-for=""DiscountPercent"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""DiscountCode"" class=""control-label""></label>
                <input asp-for=""DiscountCode"" class=""form-control"" />
                <span asp-validation-for=""DiscountCode"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Valid"" class=""control-label""></label>
                <input asp-for=""Valid"" class=""form-control"" />
                <span asp-validation-for=""Valid");
            WriteLiteral(@""" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 42 "C:\Users\morga\Desktop\FinalProjectPhase\NerdCraft\Views\Discount\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NerdCraft.Models.discount> Html { get; private set; }
    }
}
#pragma warning restore 1591
