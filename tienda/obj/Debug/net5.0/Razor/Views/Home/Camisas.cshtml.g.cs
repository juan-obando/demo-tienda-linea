#pragma checksum "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "990bb0af87ee4cac67f63ec0a31cc77f4df13ab0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Camisas), @"mvc.1.0.view", @"/Views/Home/Camisas.cshtml")]
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
#line 1 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\_ViewImports.cshtml"
using tienda;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\_ViewImports.cshtml"
using tienda.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"990bb0af87ee4cac67f63ec0a31cc77f4df13ab0", @"/Views/Home/Camisas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7b3ebda0f0ebe31584762ad16b67baf74d6056a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Camisas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml"
  
    ViewData["Title"] = "Camisas";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Camisas</h1>  \r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "990bb0af87ee4cac67f63ec0a31cc77f4df13ab03975", async() => {
                WriteLiteral(@"
    <table style=""border: 1px solid black"" align=""center"">
        <tr>
            <th style=""text-align:center""><b>POSICION</b></th>
            <th style=""text-align:center""><b>CODIGO</b></th>
            <th style=""text-align:center""><b>NOMBRE</b></th>
            <th style=""text-align:center""><b>PRECIO</b></th>
        </tr>
        <tr>
            <td style=""text-align:center"">1</td>
            <td style=""text-align:center"">");
#nullable restore
#line 17 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml"
                                     Write(ViewBag.Codigo1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
#nullable restore
#line 18 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml"
                                     Write(ViewBag.Nombre1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td style=\"text-align:center\">$");
#nullable restore
#line 19 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml"
                                      Write(ViewBag.Precio1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td style=\"text-align:center\">2</td>\r\n            <td style=\"text-align:center\">");
#nullable restore
#line 23 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml"
                                     Write(ViewBag.Codigo2);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
#nullable restore
#line 24 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml"
                                     Write(ViewBag.Nombre2);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td style=\"text-align:center\">$");
#nullable restore
#line 25 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml"
                                      Write(ViewBag.Precio2);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td style=\"text-align:center\">3</td>\r\n            <td style=\"text-align:center\">");
#nullable restore
#line 29 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml"
                                     Write(ViewBag.Codigo3);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
#nullable restore
#line 30 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml"
                                     Write(ViewBag.Nombre3);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td style=\"text-align:center\">$");
#nullable restore
#line 31 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml"
                                      Write(ViewBag.Precio3);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td style=\"text-align:center\">4</td>\r\n            <td style=\"text-align:center\">");
#nullable restore
#line 35 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml"
                                     Write(ViewBag.Codigo4);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
#nullable restore
#line 36 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml"
                                     Write(ViewBag.Nombre4);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td style=\"text-align:center\">$");
#nullable restore
#line 37 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml"
                                      Write(ViewBag.Precio4);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td style=\"text-align:center\">5</td>\r\n            <td style=\"text-align:center\">");
#nullable restore
#line 41 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml"
                                     Write(ViewBag.Codigo5);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
#nullable restore
#line 42 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml"
                                     Write(ViewBag.Nombre5);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td style=\"text-align:center\">$");
#nullable restore
#line 43 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml"
                                      Write(ViewBag.Precio5);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td style=\"text-align:center\">6</td>\r\n            <td style=\"text-align:center\">");
#nullable restore
#line 47 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml"
                                     Write(ViewBag.Codigo6);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
#nullable restore
#line 48 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml"
                                     Write(ViewBag.Nombre6);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td style=\"text-align:center\">$");
#nullable restore
#line 49 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml"
                                      Write(ViewBag.Precio6);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td style=\"text-align:center\">7</td>\r\n            <td style=\"text-align:center\">");
#nullable restore
#line 53 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml"
                                     Write(ViewBag.Codigo7);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
#nullable restore
#line 54 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml"
                                     Write(ViewBag.Nombre7);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td style=\"text-align:center\">$");
#nullable restore
#line 55 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml"
                                      Write(ViewBag.Precio7);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td style=\"text-align:center\">8</td>\r\n            <td style=\"text-align:center\">");
#nullable restore
#line 59 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml"
                                     Write(ViewBag.Codigo8);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
#nullable restore
#line 60 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml"
                                     Write(ViewBag.Nombre8);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td style=\"text-align:center\">$");
#nullable restore
#line 61 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml"
                                      Write(ViewBag.Precio8);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td style=\"text-align:center\">9</td>\r\n            <td style=\"text-align:center\">");
#nullable restore
#line 65 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml"
                                     Write(ViewBag.Codigo9);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
#nullable restore
#line 66 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml"
                                     Write(ViewBag.Nombre9);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td style=\"text-align:center\">$");
#nullable restore
#line 67 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml"
                                      Write(ViewBag.Precio9);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td style=\"text-align:center\">10</td>\r\n            <td style=\"text-align:center\">");
#nullable restore
#line 71 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml"
                                     Write(ViewBag.Codigo10);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td style=\"text-align:center\">");
#nullable restore
#line 72 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml"
                                     Write(ViewBag.Nombre10);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td style=\"text-align:center\">$");
#nullable restore
#line 73 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml"
                                      Write(ViewBag.Precio10);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>       \r\n    </table>\r\n    <p> </p>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "990bb0af87ee4cac67f63ec0a31cc77f4df13ab015915", async() => {
                WriteLiteral("\r\n        <p> </p>\r\n        <div>\r\n            <p>");
#nullable restore
#line 82 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml"
          Write(ViewBag.Tardo1);

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml"
                         Write(ViewBag.Tiempo1);

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml"
                                         Write(ViewBag.Mensaje1);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
            <button type=""submit"" value=""Ordenar1"" name=""ordenar1"" class=""btn-group"">Ordenar por codigo</button>
            <button type=""submit"" value=""Ordenar2"" name=""ordenar2"" class=""btn-group"">Ordenar por precio</button>
        </div>        
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<div class=\"text-center\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "990bb0af87ee4cac67f63ec0a31cc77f4df13ab018425", async() => {
                WriteLiteral(@"
        <div>
            <p> </p>
            <input type=""text"" class=""form-control"" name=""pos"" placeholder=""Introducir la posicion del objeto a comprar""/>
        </div>
            <p> </p>
        <div>
            <button type=""submit"" value=""Comprar"" name=""comprar"" class=""btn-group"">Comprar</button>
        </div>        
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<div class=\"text-center\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "990bb0af87ee4cac67f63ec0a31cc77f4df13ab020260", async() => {
                WriteLiteral(@"
        <div>
            <p> </p>
            <p> </p>
            <input type=""text"" class=""form-control"" name=""pos2"" placeholder=""Introducir la posicion del objeto a editar""/>
            <p> </p>
            <input type=""text"" class=""form-control"" name=""codigo"" placeholder=""Introducir el codigo del objeto por el que lo quiere cambiar""/>
            </div>
            <p> </p>
            <div>
            <button type=""submit"" value = ""Editar"" name=""editar"" class=""btn-group"">Editar</button>
        </div>        
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<div class=\"text-center\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "990bb0af87ee4cac67f63ec0a31cc77f4df13ab022298", async() => {
                WriteLiteral("\r\n        <div>\r\n            <p> </p>\r\n            <p>");
#nullable restore
#line 119 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml"
          Write(ViewBag.Buscar);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 119 "C:\Users\Drago\Desktop\Proyects\project\demo-tienda-linea\tienda\Views\Home\Camisas.cshtml"
                          Write(ViewBag.Buscar2);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
            <input type=""text"" class=""form-control"" name=""codigo2"" placeholder=""Introducir el codigo del objeto que quiere buscar""/>
        </div>
            <p> </p>
        <div>
            <button type=""submit"" value=""Buscar"" name=""buscar"" class=""btn-group"">Buscar</button>
        </div>        
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
