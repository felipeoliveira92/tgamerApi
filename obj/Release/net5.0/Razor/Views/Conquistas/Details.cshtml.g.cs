#pragma checksum "C:\Users\Felipe\Documents\Digital-Innovation-One\tgamerApi\Views\Conquistas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69f4676287dd5df41e1b701aadde9a1d0680a9bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Conquistas_Details), @"mvc.1.0.view", @"/Views/Conquistas/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69f4676287dd5df41e1b701aadde9a1d0680a9bb", @"/Views/Conquistas/Details.cshtml")]
    public class Views_Conquistas_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<tgamerApi.Models.Conquistas>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Felipe\Documents\Digital-Innovation-One\tgamerApi\Views\Conquistas\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Conquistas</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Felipe\Documents\Digital-Innovation-One\tgamerApi\Views\Conquistas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Felipe\Documents\Digital-Innovation-One\tgamerApi\Views\Conquistas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Usuario.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Felipe\Documents\Digital-Innovation-One\tgamerApi\Views\Conquistas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.acertos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Felipe\Documents\Digital-Innovation-One\tgamerApi\Views\Conquistas\Details.cshtml"
       Write(Html.DisplayFor(model => model.acertos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Felipe\Documents\Digital-Innovation-One\tgamerApi\Views\Conquistas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.erros));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Felipe\Documents\Digital-Innovation-One\tgamerApi\Views\Conquistas\Details.cshtml"
       Write(Html.DisplayFor(model => model.erros));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Felipe\Documents\Digital-Innovation-One\tgamerApi\Views\Conquistas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.nivel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Felipe\Documents\Digital-Innovation-One\tgamerApi\Views\Conquistas\Details.cshtml"
       Write(Html.DisplayFor(model => model.nivel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1050, "\"", 1074, 1);
#nullable restore
#line 40 "C:\Users\Felipe\Documents\Digital-Innovation-One\tgamerApi\Views\Conquistas\Details.cshtml"
WriteAttributeValue("", 1065, Model.Id, 1065, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tgamerApi.Models.Conquistas> Html { get; private set; }
    }
}
#pragma warning restore 1591