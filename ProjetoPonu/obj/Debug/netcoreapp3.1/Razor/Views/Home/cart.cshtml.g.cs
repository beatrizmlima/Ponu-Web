#pragma checksum "C:\Users\Amanda\Downloads\Projeto\ProjetoPonu\ProjetoPonu\Views\Home\cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "638dbaeb2d232c7dd7fc7fde7b6e2710d8c0b337"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_cart), @"mvc.1.0.view", @"/Views/Home/cart.cshtml")]
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
#line 1 "C:\Users\Amanda\Downloads\Projeto\ProjetoPonu\ProjetoPonu\Views\_ViewImports.cshtml"
using ProjetoPonu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Amanda\Downloads\Projeto\ProjetoPonu\ProjetoPonu\Views\_ViewImports.cshtml"
using ProjetoPonu.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"638dbaeb2d232c7dd7fc7fde7b6e2710d8c0b337", @"/Views/Home/cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24cd16ba6572f18b0fb1b15be0185ab727b64160", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Produto>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/products/c1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/script.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<html lang=\"pt-br\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "638dbaeb2d232c7dd7fc7fde7b6e2710d8c0b3374356", async() => {
                WriteLiteral(@"        
    <!--Colocando o banner/imagem inicial-->
    <section id=""page-header"" class=""about-header"">
        <h2>#Vamos às compraaaaaaas</h2>
        <p><strong>Não é só um cosmético, é um cosmético Pono!</strong></p>
    </section>

    <!--Criando a tabela dos produtos adicionados no carrinho-->
    <section id=""cart"" class=""section-p1"">
        <table width=""100%"">
            <thead>
                <tr>
                    <td>REMOVER</td>
                    <td>IMAGEM</td>
                    <td>PRODUTO</td>
                    <td>PREÇO</td>
                    <td>QUANTIDADE</td>
                    <td>SUBTOTAL</td>
                </tr>
            </thead>

            <tbody>
                <!--Se a ViewBag que é criada quando se clica no botão adicionar ao carrinho não é true, ou, a viewbag que é 
                    alterada quando se clica em remover produto, não é false, o produto não existirá no carrinho
                    (Possivel ponto de melhoria, pois iss");
                WriteLiteral("o não é dinâmico, funciona somente nesse caso)\r\n                -->\r\n");
#nullable restore
#line 30 "C:\Users\Amanda\Downloads\Projeto\ProjetoPonu\ProjetoPonu\Views\Home\cart.cshtml"
                 if (ViewBag.AdcCarrinho == true && ViewBag.RemoverProduto != true)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <!--Formulário que remove o produto do carrinho-->\r\n");
#nullable restore
#line 34 "C:\Users\Amanda\Downloads\Projeto\ProjetoPonu\ProjetoPonu\Views\Home\cart.cshtml"
                         using (Html.BeginForm("RemoverProduto", "Home")) {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <td><button type=\"submit\" class=\"removerProduto\" id=\"removerProduto\"><i class=\"far fa-times-circle\"/></button></td>\r\n                        <td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "638dbaeb2d232c7dd7fc7fde7b6e2710d8c0b3376613", async() => {
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
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 37 "C:\Users\Amanda\Downloads\Projeto\ProjetoPonu\ProjetoPonu\Views\Home\cart.cshtml"
                       Write(ViewBag.nome);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 38 "C:\Users\Amanda\Downloads\Projeto\ProjetoPonu\ProjetoPonu\Views\Home\cart.cshtml"
                       Write(ViewBag.preco);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>\r\n                            <input id=\"quantidade\" class=\"quantidade\" name=\"quantidade\" min=\"1\" type=\"number\"");
                BeginWriteAttribute("value", " value=\"", 1874, "\"", 1908, 1);
#nullable restore
#line 40 "C:\Users\Amanda\Downloads\Projeto\ProjetoPonu\ProjetoPonu\Views\Home\cart.cshtml"
WriteAttributeValue("", 1882, ViewBag.quantidadeProduto, 1882, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly>\r\n                                                    </td>\r\n");
                WriteLiteral("                        <td>");
#nullable restore
#line 43 "C:\Users\Amanda\Downloads\Projeto\ProjetoPonu\ProjetoPonu\Views\Home\cart.cshtml"
                       Write(ViewBag.precoFinal);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>");
#nullable restore
#line 43 "C:\Users\Amanda\Downloads\Projeto\ProjetoPonu\ProjetoPonu\Views\Home\cart.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 45 "C:\Users\Amanda\Downloads\Projeto\ProjetoPonu\ProjetoPonu\Views\Home\cart.cshtml"
                }                

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </tbody>
        </table>
    </section>

    <!--Criando o input de aplicar cupom e total-->
    <section id=""cart-add"" class=""section-p1"">
        <div id=""coupon"">
            <h3>Aplicar cupom</h3>
            <div>
                <input type=""text"" placeholder=""Insira o cupom"">
                <button class=""normal"">Aplicar</button>
            </div>
        </div>

        <div id=""subtotal"">
            <h3>Carrinho</h3>
            <table>
                <tr>
                    <td>Subtotal</td>
                    <td>");
#nullable restore
#line 65 "C:\Users\Amanda\Downloads\Projeto\ProjetoPonu\ProjetoPonu\Views\Home\cart.cshtml"
                   Write(ViewBag.precoFinal);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                </tr>

                <tr>
                    <td>Frete</td>
                    <td>Grátis</td>
                </tr>

                <tr>
                    <td><strong>Total</strong></td>
                    <td><strong>");
#nullable restore
#line 75 "C:\Users\Amanda\Downloads\Projeto\ProjetoPonu\ProjetoPonu\Views\Home\cart.cshtml"
                           Write(ViewBag.precoFinal);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong></td>\r\n                </tr>\r\n            </table>\r\n\r\n            <button class=\"normal\">Finalizar compra</button>\r\n        </div>\r\n    </section>\r\n\r\n  \r\n");
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
            WriteLiteral("\r\n</html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "638dbaeb2d232c7dd7fc7fde7b6e2710d8c0b33712039", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Produto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
