#pragma checksum "/home/rafael/Área de Trabalho/Projeto integrador/projeto-destino-certo/Views/Home/Listar_Reservas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a237c720ad7c735e979de61d9f67fa679890f495"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Listar_Reservas), @"mvc.1.0.view", @"/Views/Home/Listar_Reservas.cshtml")]
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
#line 1 "/home/rafael/Área de Trabalho/Projeto integrador/projeto-destino-certo/Views/_ViewImports.cshtml"
using projeto_destino_certo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/rafael/Área de Trabalho/Projeto integrador/projeto-destino-certo/Views/_ViewImports.cshtml"
using projeto_destino_certo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/home/rafael/Área de Trabalho/Projeto integrador/projeto-destino-certo/Views/Home/Listar_Reservas.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a237c720ad7c735e979de61d9f67fa679890f495", @"/Views/Home/Listar_Reservas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7317d4c760d2f84c0297249d72e62202191ecda", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Listar_Reservas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Reserva>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("icones-content"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/usuarios-icone.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icone-edit.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icone-close2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/rafael/Área de Trabalho/Projeto integrador/projeto-destino-certo/Views/Home/Listar_Reservas.cshtml"
  
    ViewData["Title"] = "Listagem de Reservas";

#line default
#line hidden
#nullable disable
            WriteLiteral("<main class=\"fundo-color\">\r\n<div class=\"usuarios-content\">  \r\n<div>\r\n    <div class=\"icone-titulo\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a237c720ad7c735e979de61d9f67fa679890f4955147", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"<h3 class=""titulos"">LISTAGEM DE USUÁRIOS</h3></div>
<p class=""paragrafos"">A lista de todos as reservas registradas no sistema está disponível abaixo. Use os botões da direita para realizar a exclusão ou alteração das reservas</p>
<p class=""paragrafos"">ALERTA: Cuidado ao excluir uma reserva. Uma vez excluídos, os dados do registo relacionados a reserva não poderão ser recuperados.</p>
<table class=""table"">
  <thead class=""thead-dark"">
    <tr>
      <th scope=""col"">ID</th>
      <th scope=""col"">NOME</th>
      <th scope=""col"">QUANTIDADE</th>
      <th scope=""col"">PREÇO</th>
      <th scope=""col"">DATA DA RESERVA</th>
      <th scope=""col""></th>
      <th scope=""col""></th>

    </tr>
  </thead>
  <tbody>
");
#nullable restore
#line 26 "/home/rafael/Área de Trabalho/Projeto integrador/projeto-destino-certo/Views/Home/Listar_Reservas.cshtml"
      foreach(Reserva r in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n      <th scope=\"row\">");
#nullable restore
#line 28 "/home/rafael/Área de Trabalho/Projeto integrador/projeto-destino-certo/Views/Home/Listar_Reservas.cshtml"
                 Write(r.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <td>");
#nullable restore
#line 29 "/home/rafael/Área de Trabalho/Projeto integrador/projeto-destino-certo/Views/Home/Listar_Reservas.cshtml"
     Write(r.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 30 "/home/rafael/Área de Trabalho/Projeto integrador/projeto-destino-certo/Views/Home/Listar_Reservas.cshtml"
     Write(r.quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 31 "/home/rafael/Área de Trabalho/Projeto integrador/projeto-destino-certo/Views/Home/Listar_Reservas.cshtml"
     Write(r.preco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 32 "/home/rafael/Área de Trabalho/Projeto integrador/projeto-destino-certo/Views/Home/Listar_Reservas.cshtml"
     Write(r.data_reserva);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td><a");
            BeginWriteAttribute("href", " href=\"", 1209, "\"", 1246, 2);
            WriteAttributeValue("", 1216, "/Home/Alterar_Reserva?id=", 1216, 25, true);
#nullable restore
#line 33 "/home/rafael/Área de Trabalho/Projeto integrador/projeto-destino-certo/Views/Home/Listar_Reservas.cshtml"
WriteAttributeValue("", 1241, r.id, 1241, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a237c720ad7c735e979de61d9f67fa679890f4959008", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n      <td><a");
            BeginWriteAttribute("href", " href=\"", 1322, "\"", 1359, 2);
            WriteAttributeValue("", 1329, "/Home/Excluir_Reserva?id=", 1329, 25, true);
#nullable restore
#line 34 "/home/rafael/Área de Trabalho/Projeto integrador/projeto-destino-certo/Views/Home/Listar_Reservas.cshtml"
WriteAttributeValue("", 1354, r.id, 1354, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a237c720ad7c735e979de61d9f67fa679890f49510583", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a></td>\r\n    </tr>");
#nullable restore
#line 35 "/home/rafael/Área de Trabalho/Projeto integrador/projeto-destino-certo/Views/Home/Listar_Reservas.cshtml"
         } 

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\r\n</table>\r\n\r\n</div>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Reserva>> Html { get; private set; }
    }
}
#pragma warning restore 1591
