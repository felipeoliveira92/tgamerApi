#pragma checksum "C:\Users\Felipe\Documents\Projetos\tgamerApi\Views\Conquistas\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de58d2dcaf36eb02e126cd338dbf5d348d34fd26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Conquistas_Create), @"mvc.1.0.view", @"/Views/Conquistas/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de58d2dcaf36eb02e126cd338dbf5d348d34fd26", @"/Views/Conquistas/Create.cshtml")]
    public class Views_Conquistas_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<tgamerApi.Models.Conquistas>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Felipe\Documents\Projetos\tgamerApi\Views\Conquistas\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Conquistas</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""UsuarioId"" class=""control-label""></label>
                <select asp-for=""UsuarioId"" class =""form-control"" asp-items=""ViewBag.UsuarioId""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""acertos"" class=""control-label""></label>
                <input asp-for=""acertos"" class=""form-control"" />
                <span asp-validation-for=""acertos"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""erros"" class=""control-label""></label>
                <input asp-for=""erros"" class=""form-control"" />
                <span asp-validation-for=""erros"" class=""text-danger""></span>
            </div>
            <div class=");
            WriteLiteral(@"""form-group"">
                <label asp-for=""nivel"" class=""control-label""></label>
                <input asp-for=""nivel"" class=""form-control"" />
                <span asp-validation-for=""nivel"" class=""text-danger""></span>
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
#line 46 "C:\Users\Felipe\Documents\Projetos\tgamerApi\Views\Conquistas\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tgamerApi.Models.Conquistas> Html { get; private set; }
    }
}
#pragma warning restore 1591
