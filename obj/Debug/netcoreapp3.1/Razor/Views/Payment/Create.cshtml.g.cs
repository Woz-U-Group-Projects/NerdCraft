#pragma checksum "C:\Users\morga\Desktop\FinalProjectPhase\NerdCraft\Views\Payment\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9242ddecb88e28134497d5419930849a19bbb7f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payment_Create), @"mvc.1.0.view", @"/Views/Payment/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9242ddecb88e28134497d5419930849a19bbb7f7", @"/Views/Payment/Create.cshtml")]
    public class Views_Payment_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NerdCraft.Models.payment>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\morga\Desktop\FinalProjectPhase\NerdCraft\Views\Payment\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>payment</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""OrderID"" class=""control-label""></label>
                <select asp-for=""OrderID"" class =""form-control"" asp-items=""ViewBag.OrderID""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""CardComp"" class=""control-label""></label>
                <input asp-for=""CardComp"" class=""form-control"" />
                <span asp-validation-for=""CardComp"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CardName"" class=""control-label""></label>
                <input asp-for=""CardName"" class=""form-control"" />
                <span asp-validation-for=""CardName"" class=""text-danger""></span>
            </div>
            <div cla");
            WriteLiteral(@"ss=""form-group"">
                <label asp-for=""CardNum"" class=""control-label""></label>
                <input asp-for=""CardNum"" class=""form-control"" />
                <span asp-validation-for=""CardNum"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CardExp"" class=""control-label""></label>
                <input asp-for=""CardExp"" class=""form-control"" />
                <span asp-validation-for=""CardExp"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CardSec"" class=""control-label""></label>
                <input asp-for=""CardSec"" class=""form-control"" />
                <span asp-validation-for=""CardSec"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Address1"" class=""control-label""></label>
                <input asp-for=""Address1"" class=""form-control"" />
                <span asp-validati");
            WriteLiteral(@"on-for=""Address1"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Address2"" class=""control-label""></label>
                <input asp-for=""Address2"" class=""form-control"" />
                <span asp-validation-for=""Address2"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
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
   ");
            WriteLiteral(@"             <input asp-for=""Country"" class=""form-control"" />
                <span asp-validation-for=""Country"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""PostalID"" class=""control-label""></label>
                <input asp-for=""PostalID"" class=""form-control"" />
                <span asp-validation-for=""PostalID"" class=""text-danger""></span>
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
#line 86 "C:\Users\morga\Desktop\FinalProjectPhase\NerdCraft\Views\Payment\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NerdCraft.Models.payment> Html { get; private set; }
    }
}
#pragma warning restore 1591
