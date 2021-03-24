#pragma checksum "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Address\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afa34e06b45d8fc9cdb7342f89a60945248ef20d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Address_Create), @"mvc.1.0.view", @"/Views/Address/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afa34e06b45d8fc9cdb7342f89a60945248ef20d", @"/Views/Address/Create.cshtml")]
    public class Views_Address_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NerdCraft.Models.address>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Address\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>address</h4>
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
                <label asp-for=""Address1"" class=""control-label""></label>
                <input asp-for=""Address1"" class=""form-control"" />
                <span asp-validation-for=""Address1"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Address2"" class=""control-label""></label>
                <input asp-for=""Address2"" class=""form-control"" />
                <span asp-validation-for=""Address2"" class=""text-danger""></span>
            </div>
           ");
            WriteLiteral(@" <div class=""form-group"">
                <label asp-for=""City"" class=""control-label""></label>
                <input asp-for=""City"" class=""form-control"" />
                <span asp-validation-for=""City"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""StateProvince"" class=""control-label""></label>
                <input asp-for=""StateProvince"" class=""form-control"" />
                <span asp-validation-for=""StateProvince"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Country"" class=""control-label""></label>
                <input asp-for=""Country"" class=""form-control"" />
                <span asp-validation-for=""Country"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""PostalID"" class=""control-label""></label>
                <input asp-for=""PostalID"" class=""form-control"" />
                ");
            WriteLiteral(@"<span asp-validation-for=""PostalID"" class=""text-danger""></span>
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
#line 61 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Address\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NerdCraft.Models.address> Html { get; private set; }
    }
}
#pragma warning restore 1591
