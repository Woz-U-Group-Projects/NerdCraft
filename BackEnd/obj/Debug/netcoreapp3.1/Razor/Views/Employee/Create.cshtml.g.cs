#pragma checksum "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Employee\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b2d62f76aab4dd9549fdde405318d61600e4fff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Create), @"mvc.1.0.view", @"/Views/Employee/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b2d62f76aab4dd9549fdde405318d61600e4fff", @"/Views/Employee/Create.cshtml")]
    public class Views_Employee_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NerdCraft.Models.employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Employee\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>employee</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""ID"" class=""control-label""></label>
                <select asp-for=""ID"" class =""form-control"" asp-items=""ViewBag.ID""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""EmployeeEmail"" class=""control-label""></label>
                <input asp-for=""EmployeeEmail"" class=""form-control"" />
                <span asp-validation-for=""EmployeeEmail"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Supervisor"" class=""control-label""></label>
                <select asp-for=""Supervisor"" class =""form-control"" asp-items=""ViewBag.Supervisor""></select>
            </div>
            <div class=""form-group"">
                <l");
            WriteLiteral(@"abel asp-for=""Userpass"" class=""control-label""></label>
                <input asp-for=""Userpass"" class=""form-control"" />
                <span asp-validation-for=""Userpass"" class=""text-danger""></span>
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
#line 45 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Employee\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NerdCraft.Models.employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
