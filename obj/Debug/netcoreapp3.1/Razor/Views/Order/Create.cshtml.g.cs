#pragma checksum "C:\Users\morga\Desktop\FinalProjectPhase\NerdCraft\Views\Order\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a87fadd8ff6f27ec93b58ec28e386823c63c8966"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Create), @"mvc.1.0.view", @"/Views/Order/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a87fadd8ff6f27ec93b58ec28e386823c63c8966", @"/Views/Order/Create.cshtml")]
    public class Views_Order_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NerdCraft.Models.order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\morga\Desktop\FinalProjectPhase\NerdCraft\Views\Order\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>order</h4>
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
                <label asp-for=""OrderDate"" class=""control-label""></label>
                <input asp-for=""OrderDate"" class=""form-control"" />
                <span asp-validation-for=""OrderDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Completed"" class=""control-label""></label>
                <input asp-for=""Completed"" class=""form-control"" />
                <span asp-validation-for=""Completed"" class=""text-danger""></span>
            </div>
       ");
            WriteLiteral(@"     <div class=""form-group"">
                <label asp-for=""OrderName"" class=""control-label""></label>
                <input asp-for=""OrderName"" class=""form-control"" />
                <span asp-validation-for=""OrderName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""OrderEmail"" class=""control-label""></label>
                <input asp-for=""OrderEmail"" class=""form-control"" />
                <span asp-validation-for=""OrderEmail"" class=""text-danger""></span>
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
#line 51 "C:\Users\morga\Desktop\FinalProjectPhase\NerdCraft\Views\Order\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NerdCraft.Models.order> Html { get; private set; }
    }
}
#pragma warning restore 1591
