#pragma checksum "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Item\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b77c13e0d4f3b0a8c63b871c18bf8dfd9a09bfb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_Index), @"mvc.1.0.view", @"/Views/Item/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b77c13e0d4f3b0a8c63b871c18bf8dfd9a09bfb", @"/Views/Item/Index.cshtml")]
    public class Views_Item_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NerdCraft.Models.item>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Item\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Item\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Item\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Item\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ItemType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Item\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Seller));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Item\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ItemDesc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Item\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Item\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 40 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Item\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Item\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Item\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Item\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ItemType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Item\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Seller));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Item\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ItemDesc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Item\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Item\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1752, "\"", 1779, 1);
#nullable restore
#line 64 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Item\Index.cshtml"
WriteAttributeValue("", 1767, item.ItemID, 1767, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1832, "\"", 1859, 1);
#nullable restore
#line 65 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Item\Index.cshtml"
WriteAttributeValue("", 1847, item.ItemID, 1847, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1914, "\"", 1941, 1);
#nullable restore
#line 66 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Item\Index.cshtml"
WriteAttributeValue("", 1929, item.ItemID, 1929, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 69 "C:\Users\morga\OneDrive\Desktop\FinalProjectPhase\NerdCraft\BackEnd\Views\Item\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NerdCraft.Models.item>> Html { get; private set; }
    }
}
#pragma warning restore 1591
