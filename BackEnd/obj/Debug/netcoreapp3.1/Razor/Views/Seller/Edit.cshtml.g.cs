#pragma checksum "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Seller\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ace60cc156ce8aa572556ab7d9ab62d50e93333"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Seller_Edit), @"mvc.1.0.view", @"/Views/Seller/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ace60cc156ce8aa572556ab7d9ab62d50e93333", @"/Views/Seller/Edit.cshtml")]
    public class Views_Seller_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NerdCraft.Models.seller>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Seller\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>seller</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""SellerID"" class=""control-label""></label>
                <input asp-for=""SellerID"" class=""form-control"" />
                <span asp-validation-for=""SellerID"" class=""text-danger""></span>
            </div>
            <input type=""hidden"" asp-for=""ID"" />
            <div class=""form-group"">
                <label asp-for=""ItemID"" class=""control-label""></label>
                <input asp-for=""ItemID"" class=""form-control"" />
                <span asp-validation-for=""ItemID"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""SellerName"" class=""control-label""></label>
                <input asp-for=""SellerName"" class=""form-control"" />
                <span asp-valida");
            WriteLiteral(@"tion-for=""SellerName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""SellerDesc"" class=""control-label""></label>
                <input asp-for=""SellerDesc"" class=""form-control"" />
                <span asp-validation-for=""SellerDesc"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""SellerEmail"" class=""control-label""></label>
                <input asp-for=""SellerEmail"" class=""form-control"" />
                <span asp-validation-for=""SellerEmail"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""SellerPhone"" class=""control-label""></label>
                <input asp-for=""SellerPhone"" class=""form-control"" />
                <span asp-validation-for=""SellerPhone"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" c");
            WriteLiteral("lass=\"btn btn-primary\" />\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 58 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Seller\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NerdCraft.Models.seller> Html { get; private set; }
    }
}
#pragma warning restore 1591
