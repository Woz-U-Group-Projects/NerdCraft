#pragma checksum "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Shipment\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fa0a63204b5bce958fba7f33c1886adea2e33f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shipment_Create), @"mvc.1.0.view", @"/Views/Shipment/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fa0a63204b5bce958fba7f33c1886adea2e33f1", @"/Views/Shipment/Create.cshtml")]
    public class Views_Shipment_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NerdCraft.Models.shipment>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Shipment\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>shipment</h4>
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
                <label asp-for=""Address1"" class=""control-label""></label>
                <input asp-for=""Address1"" class=""form-control"" />
                <span asp-validation-for=""Address1"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Address2"" class=""control-label""></label>
                <input asp-for=""Address2"" class=""form-control"" />
                <span asp-validation-for=""Address2"" class=""text-danger""></span>
            </div>
            <div cl");
            WriteLiteral(@"ass=""form-group"">
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
                <span as");
            WriteLiteral(@"p-validation-for=""PostalID"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Fee"" class=""control-label""></label>
                <input asp-for=""Fee"" class=""form-control"" />
                <span asp-validation-for=""Fee"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Company"" class=""control-label""></label>
                <input asp-for=""Company"" class=""form-control"" />
                <span asp-validation-for=""Company"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ShipName"" class=""control-label""></label>
                <input asp-for=""ShipName"" class=""form-control"" />
                <span asp-validation-for=""ShipName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
       ");
            WriteLiteral("     </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 76 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Shipment\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NerdCraft.Models.shipment> Html { get; private set; }
    }
}
#pragma warning restore 1591
