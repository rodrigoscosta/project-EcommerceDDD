#pragma checksum "C:\Users\est_ab1214210\Downloads\EcommerceDDD\Web_ECommerce\Views\Produtos\ListarProdutosCarrinhoUsuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbd842c91bfdde75bd621f429b99d580dcd1414d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produtos_ListarProdutosCarrinhoUsuario), @"mvc.1.0.view", @"/Views/Produtos/ListarProdutosCarrinhoUsuario.cshtml")]
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
#line 1 "C:\Users\est_ab1214210\Downloads\EcommerceDDD\Web_ECommerce\Views\_ViewImports.cshtml"
using Web_ECommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\est_ab1214210\Downloads\EcommerceDDD\Web_ECommerce\Views\_ViewImports.cshtml"
using Web_ECommerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbd842c91bfdde75bd621f429b99d580dcd1414d", @"/Views/Produtos/ListarProdutosCarrinhoUsuario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"684f3d0ac3ee691da11a2a86cebab3ec537bc857", @"/Views/_ViewImports.cshtml")]
    public class Views_Produtos_ListarProdutosCarrinhoUsuario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Entities.Entities.Produto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CompraUsuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FinalizarCompra", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\est_ab1214210\Downloads\EcommerceDDD\Web_ECommerce\Views\Produtos\ListarProdutosCarrinhoUsuario.cshtml"
  
    ViewData["Title"] = "ListarProdutosCarrinhoUsuario";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Listar de Produtos do Carrinho</h1>\r\n\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbd842c91bfdde75bd621f429b99d580dcd1414d4866", async() => {
                WriteLiteral("Comprar do carrinho");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\est_ab1214210\Downloads\EcommerceDDD\Web_ECommerce\Views\Produtos\ListarProdutosCarrinhoUsuario.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>Imagem</th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\est_ab1214210\Downloads\EcommerceDDD\Web_ECommerce\Views\Produtos\ListarProdutosCarrinhoUsuario.cshtml"
           Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\est_ab1214210\Downloads\EcommerceDDD\Web_ECommerce\Views\Produtos\ListarProdutosCarrinhoUsuario.cshtml"
           Write(Html.DisplayNameFor(model => model.Observacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\est_ab1214210\Downloads\EcommerceDDD\Web_ECommerce\Views\Produtos\ListarProdutosCarrinhoUsuario.cshtml"
           Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\est_ab1214210\Downloads\EcommerceDDD\Web_ECommerce\Views\Produtos\ListarProdutosCarrinhoUsuario.cshtml"
           Write(Html.DisplayNameFor(model => model.QtdCompra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 38 "C:\Users\est_ab1214210\Downloads\EcommerceDDD\Web_ECommerce\Views\Produtos\ListarProdutosCarrinhoUsuario.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "C:\Users\est_ab1214210\Downloads\EcommerceDDD\Web_ECommerce\Views\Produtos\ListarProdutosCarrinhoUsuario.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n");
#nullable restore
#line 47 "C:\Users\est_ab1214210\Downloads\EcommerceDDD\Web_ECommerce\Views\Produtos\ListarProdutosCarrinhoUsuario.cshtml"
                      
                        if (!string.IsNullOrWhiteSpace(item.Url))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img width=\"80\" height=\"80\"");
            BeginWriteAttribute("src", " src=", 1307, "", 1321, 1);
#nullable restore
#line 50 "C:\Users\est_ab1214210\Downloads\EcommerceDDD\Web_ECommerce\Views\Produtos\ListarProdutosCarrinhoUsuario.cshtml"
WriteAttributeValue("", 1312, item.Url, 1312, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 51 "C:\Users\est_ab1214210\Downloads\EcommerceDDD\Web_ECommerce\Views\Produtos\ListarProdutosCarrinhoUsuario.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "C:\Users\est_ab1214210\Downloads\EcommerceDDD\Web_ECommerce\Views\Produtos\ListarProdutosCarrinhoUsuario.cshtml"
               Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "C:\Users\est_ab1214210\Downloads\EcommerceDDD\Web_ECommerce\Views\Produtos\ListarProdutosCarrinhoUsuario.cshtml"
               Write(Html.DisplayFor(modelItem => item.Observacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 62 "C:\Users\est_ab1214210\Downloads\EcommerceDDD\Web_ECommerce\Views\Produtos\ListarProdutosCarrinhoUsuario.cshtml"
               Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 66 "C:\Users\est_ab1214210\Downloads\EcommerceDDD\Web_ECommerce\Views\Produtos\ListarProdutosCarrinhoUsuario.cshtml"
               Write(Html.DisplayFor(modelItem => item.QtdCompra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n\r\n                    ");
#nullable restore
#line 71 "C:\Users\est_ab1214210\Downloads\EcommerceDDD\Web_ECommerce\Views\Produtos\ListarProdutosCarrinhoUsuario.cshtml"
               Write(Html.ActionLink("Remover", "RemoverCarrinho", new { id = item.IdProdutoCarrinho }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 74 "C:\Users\est_ab1214210\Downloads\EcommerceDDD\Web_ECommerce\Views\Produtos\ListarProdutosCarrinhoUsuario.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Entities.Entities.Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591