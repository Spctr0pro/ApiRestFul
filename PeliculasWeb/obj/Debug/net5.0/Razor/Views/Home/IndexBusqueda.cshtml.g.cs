#pragma checksum "C:\Users\ivant\Desktop\Proyecto_api_restful\PeliculasWeb\Views\Home\IndexBusqueda.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "023b732b5412bf582c5b21f6fbdcfe71e9b87c4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_IndexBusqueda), @"mvc.1.0.view", @"/Views/Home/IndexBusqueda.cshtml")]
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
#line 1 "C:\Users\ivant\Desktop\Proyecto_api_restful\PeliculasWeb\Views\_ViewImports.cshtml"
using PeliculasWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ivant\Desktop\Proyecto_api_restful\PeliculasWeb\Views\_ViewImports.cshtml"
using PeliculasWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"023b732b5412bf582c5b21f6fbdcfe71e9b87c4f", @"/Views/Home/IndexBusqueda.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4202265a9fcef4b45af732c569546b836f8c81ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_IndexBusqueda : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PeliculasWeb.Models.Pelicula>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ivant\Desktop\Proyecto_api_restful\PeliculasWeb\Views\Home\IndexBusqueda.cshtml"
  
    ViewData["Title"] = "Resultado de búsqueda";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row mt-3\">\r\n");
#nullable restore
#line 8 "C:\Users\ivant\Desktop\Proyecto_api_restful\PeliculasWeb\Views\Home\IndexBusqueda.cshtml"
     if (Model != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ivant\Desktop\Proyecto_api_restful\PeliculasWeb\Views\Home\IndexBusqueda.cshtml"
         foreach (var pelicula in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-sm-4\">\r\n                <div class=\"card\" style=\"width:18rem;\">\r\n");
#nullable restore
#line 14 "C:\Users\ivant\Desktop\Proyecto_api_restful\PeliculasWeb\Views\Home\IndexBusqueda.cshtml"
                     if (pelicula.RutaImagen != null)
                    {
                        var base64 = Convert.ToBase64String(pelicula.RutaImagen);
                        var imgsrc = string.Format("data:image/jpg;base64,{0}", base64);

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=\"", 637, "\"", 650, 1);
#nullable restore
#line 18 "C:\Users\ivant\Desktop\Proyecto_api_restful\PeliculasWeb\Views\Home\IndexBusqueda.cshtml"
WriteAttributeValue("", 643, imgsrc, 643, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" />\r\n");
#nullable restore
#line 19 "C:\Users\ivant\Desktop\Proyecto_api_restful\PeliculasWeb\Views\Home\IndexBusqueda.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 22 "C:\Users\ivant\Desktop\Proyecto_api_restful\PeliculasWeb\Views\Home\IndexBusqueda.cshtml"
                                          Write(pelicula.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"card-text\">Duración: ");
#nullable restore
#line 23 "C:\Users\ivant\Desktop\Proyecto_api_restful\PeliculasWeb\Views\Home\IndexBusqueda.cshtml"
                                                  Write(pelicula.Duracion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\">Clasificación: ");
#nullable restore
#line 24 "C:\Users\ivant\Desktop\Proyecto_api_restful\PeliculasWeb\Views\Home\IndexBusqueda.cshtml"
                                                       Write(pelicula.Clasificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\">Fecha de creación: ");
#nullable restore
#line 25 "C:\Users\ivant\Desktop\Proyecto_api_restful\PeliculasWeb\Views\Home\IndexBusqueda.cshtml"
                                                           Write(pelicula.FechaCreacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\">");
#nullable restore
#line 26 "C:\Users\ivant\Desktop\Proyecto_api_restful\PeliculasWeb\Views\Home\IndexBusqueda.cshtml"
                                        Write(pelicula.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 30 "C:\Users\ivant\Desktop\Proyecto_api_restful\PeliculasWeb\Views\Home\IndexBusqueda.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\ivant\Desktop\Proyecto_api_restful\PeliculasWeb\Views\Home\IndexBusqueda.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>No hay películas para mostrar</p>\r\n");
#nullable restore
#line 35 "C:\Users\ivant\Desktop\Proyecto_api_restful\PeliculasWeb\Views\Home\IndexBusqueda.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PeliculasWeb.Models.Pelicula>> Html { get; private set; }
    }
}
#pragma warning restore 1591
