#pragma checksum "C:\Users\morga\Desktop\FinalProjectPhase\NerdCraft\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55a61ba1419846d21c5faec9a4425f8a6be01e24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55a61ba1419846d21c5faec9a4425f8a6be01e24", @"/Views/Employee/Index.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NerdCraft.Models.employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\morga\Desktop\FinalProjectPhase\NerdCraft\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\morga\Desktop\FinalProjectPhase\NerdCraft\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Userpass));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\morga\Desktop\FinalProjectPhase\NerdCraft\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IDNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\morga\Desktop\FinalProjectPhase\NerdCraft\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SupervisorNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\morga\Desktop\FinalProjectPhase\NerdCraft\Views\Employee\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\morga\Desktop\FinalProjectPhase\NerdCraft\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Userpass));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\morga\Desktop\FinalProjectPhase\NerdCraft\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IDNavigation.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\morga\Desktop\FinalProjectPhase\NerdCraft\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SupervisorNavigation.EmployeeEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1028, "\"", 1062, 1);
#nullable restore
#line 40 "C:\Users\morga\Desktop\FinalProjectPhase\NerdCraft\Views\Employee\Index.cshtml"
WriteAttributeValue("", 1043, item.EmployeeEmail, 1043, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1115, "\"", 1149, 1);
#nullable restore
#line 41 "C:\Users\morga\Desktop\FinalProjectPhase\NerdCraft\Views\Employee\Index.cshtml"
WriteAttributeValue("", 1130, item.EmployeeEmail, 1130, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1204, "\"", 1238, 1);
#nullable restore
#line 42 "C:\Users\morga\Desktop\FinalProjectPhase\NerdCraft\Views\Employee\Index.cshtml"
WriteAttributeValue("", 1219, item.EmployeeEmail, 1219, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 45 "C:\Users\morga\Desktop\FinalProjectPhase\NerdCraft\Views\Employee\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NerdCraft.Models.employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
