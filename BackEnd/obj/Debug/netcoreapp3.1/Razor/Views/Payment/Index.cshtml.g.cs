#pragma checksum "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Payment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c7d67113bc908423bdd72fc1c2faa32b3da3062"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payment_Index), @"mvc.1.0.view", @"/Views/Payment/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c7d67113bc908423bdd72fc1c2faa32b3da3062", @"/Views/Payment/Index.cshtml")]
    public class Views_Payment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NerdCraft.Models.payment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Payment\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Payment\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CardComp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Payment\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CardName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Payment\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CardNum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Payment\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CardExp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Payment\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CardSec));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Payment\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Address1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Payment\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Address2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Payment\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Payment\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StateProvince));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Payment\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Payment\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PostalID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Payment\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Order));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 55 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Payment\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Payment\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CardComp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Payment\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CardName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Payment\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CardNum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Payment\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CardExp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Payment\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CardSec));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Payment\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Payment\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 79 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Payment\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 82 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Payment\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StateProvince));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 85 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Payment\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 88 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Payment\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PostalID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 91 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Payment\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Order.OrderEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2765, "\"", 2793, 1);
#nullable restore
#line 94 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Payment\Index.cshtml"
WriteAttributeValue("", 2780, item.OrderID, 2780, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2846, "\"", 2874, 1);
#nullable restore
#line 95 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Payment\Index.cshtml"
WriteAttributeValue("", 2861, item.OrderID, 2861, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2929, "\"", 2957, 1);
#nullable restore
#line 96 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Payment\Index.cshtml"
WriteAttributeValue("", 2944, item.OrderID, 2944, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 99 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Payment\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NerdCraft.Models.payment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
