#pragma checksum "E:\SpotifyPro\SpotifyPro\Views\ListaReproduccion\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96bf31f8cd086d4412622b14579b8cb2a44f136b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ListaReproduccion_Index), @"mvc.1.0.view", @"/Views/ListaReproduccion/Index.cshtml")]
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
#nullable restore
#line 1 "E:\SpotifyPro\SpotifyPro\Views\_ViewImports.cshtml"
using SpotifyPro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\SpotifyPro\SpotifyPro\Views\_ViewImports.cshtml"
using SpotifyPro.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96bf31f8cd086d4412622b14579b8cb2a44f136b", @"/Views/ListaReproduccion/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88a206ae07e03808d4133b90afc5efdb027fb695", @"/Views/_ViewImports.cshtml")]
    public class Views_ListaReproduccion_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\SpotifyPro\SpotifyPro\Views\ListaReproduccion\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script src=""/lib/jquery/dist/jquery.min.js""></script>
<script src=""/lib/bootstrap/dist/js/bootstrap.bundle.min.js""></script>
<script src=""/js/site.js?v=4q1jwFhaPaZgr8WAUSrux6hAuh0XDg9kPS3xIVq36I0""></script>

<script>
    $(document).ready(function (e) {
        $.get(""/ListaReproduccion/_index?busqueda="" + $(""#busqueda"").val(), function (respuesta) {
            $(""#tbody"").html(respuesta);
        });
        e.preventDefault();
    });
</script>

<input class=""form-control"" type=""text"" id=""busqueda"" name=""busqueda"" placeholder=""Buscar Lista Reproduccion"" />
<a href=""/Usuario/Index"">Volver al Index</a>
<div id=""tbody"">

</div>

<script>
    $(""#busqueda"").keyup(function (e) {
             $.get(""/ListaReproduccion/_index?busqueda="" + $(""#busqueda"").val(), function (respuesta) {
                $(""#tbody"").html(respuesta);
            });
            e.preventDefault();
        });
  </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591