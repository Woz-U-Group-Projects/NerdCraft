#pragma checksum "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\WishList\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abc57cb6ec2ebcf3fed94385e129e00da4dfef95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WishList_Create), @"mvc.1.0.view", @"/Views/WishList/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abc57cb6ec2ebcf3fed94385e129e00da4dfef95", @"/Views/WishList/Create.cshtml")]
    public class Views_WishList_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NerdCraft.Models.wishlist>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\WishList\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>wishlist</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""CustomerID"" class=""control-label""></label>
                <select asp-for=""CustomerID"" class =""form-control"" asp-items=""ViewBag.CustomerID""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""ItemID"" class=""control-label""></label>
                <select asp-for=""ItemID"" class =""form-control"" asp-items=""ViewBag.ItemID""></select>
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
#line 35 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\WishList\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NerdCraft.Models.wishlist> Html { get; private set; }
    }
}
#pragma warning restore 1591
