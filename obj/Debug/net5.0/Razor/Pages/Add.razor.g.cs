#pragma checksum "C:\Users\Csharp\Desktop\Pedro Marini Nave\Desafio\Desafio\Pages\Add.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85b031f05978710ccd4ab248d1cdeda3124df6c7"
// <auto-generated/>
#pragma warning disable 1591
namespace Desafio.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Csharp\Desktop\Pedro Marini Nave\Desafio\Desafio\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Csharp\Desktop\Pedro Marini Nave\Desafio\Desafio\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Csharp\Desktop\Pedro Marini Nave\Desafio\Desafio\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Csharp\Desktop\Pedro Marini Nave\Desafio\Desafio\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Csharp\Desktop\Pedro Marini Nave\Desafio\Desafio\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Csharp\Desktop\Pedro Marini Nave\Desafio\Desafio\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Csharp\Desktop\Pedro Marini Nave\Desafio\Desafio\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Csharp\Desktop\Pedro Marini Nave\Desafio\Desafio\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Csharp\Desktop\Pedro Marini Nave\Desafio\Desafio\_Imports.razor"
using Desafio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Csharp\Desktop\Pedro Marini Nave\Desafio\Desafio\_Imports.razor"
using Desafio.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Csharp\Desktop\Pedro Marini Nave\Desafio\Desafio\Pages\Add.razor"
using Desafio.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/add")]
    public partial class Add : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Adicionar Pessoa</h2>\r\n<hr>\r\n");
            __builder.OpenElement(1, "form");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-8");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group");
            __builder.AddMarkupContent(8, "<label for=\"NomeCompleto\" class=\"control-label\">Nome</label>\r\n                ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "form", "NomeCompleto");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\Csharp\Desktop\Pedro Marini Nave\Desafio\Desafio\Pages\Add.razor"
                                                                        pessoa.NomeCompleto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => pessoa.NomeCompleto = __value, pessoa.NomeCompleto));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group");
            __builder.AddMarkupContent(17, "<label for=\"DataNascimento\" class=\"control-label\">Data de Nascimento</label>\r\n                ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "form", "DataNascimento");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\Csharp\Desktop\Pedro Marini Nave\Desafio\Desafio\Pages\Add.razor"
                                                                          pessoa.DataNascimento

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => pessoa.DataNascimento = __value, pessoa.DataNascimento));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "form-group");
            __builder.AddMarkupContent(26, "<label for=\"Cidade\" class=\"control-label\">Cidade</label>\r\n                ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "form", "Cidade");
            __builder.AddAttribute(29, "class", "form-control");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\Csharp\Desktop\Pedro Marini Nave\Desafio\Desafio\Pages\Add.razor"
                                                                  pessoa.Cidade

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => pessoa.Cidade = __value, pessoa.Cidade));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n            ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "form-group");
            __builder.AddMarkupContent(35, "<label for=\"Estado\" class=\"control-label\">Estado</label>\r\n                ");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "form", "Estado");
            __builder.AddAttribute(38, "class", "form-control");
            __builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\Csharp\Desktop\Pedro Marini Nave\Desafio\Desafio\Pages\Add.razor"
                                                                  pessoa.Estado

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => pessoa.Estado = __value, pessoa.Estado));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n            ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "form-group");
            __builder.AddMarkupContent(44, "<label for=\"Telefone\" class=\"control-label\">Telefone</label>\r\n                ");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "form", "Telefone");
            __builder.AddAttribute(47, "class", "form-control");
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Users\Csharp\Desktop\Pedro Marini Nave\Desafio\Desafio\Pages\Add.razor"
                                                                    pessoa.Telefone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => pessoa.Telefone = __value, pessoa.Telefone));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n    ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "row");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "col-md-4");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "form-group");
            __builder.OpenElement(57, "input");
            __builder.AddAttribute(58, "type", "button");
            __builder.AddAttribute(59, "class", "btn btn-primary");
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\Csharp\Desktop\Pedro Marini Nave\Desafio\Desafio\Pages\Add.razor"
                                                                        Create

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "value", "Salvar");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                ");
            __builder.OpenElement(63, "input");
            __builder.AddAttribute(64, "type", "button");
            __builder.AddAttribute(65, "class", "btn btn-primary");
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\Csharp\Desktop\Pedro Marini Nave\Desafio\Desafio\Pages\Add.razor"
                                                                        Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "value", "Cancelar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\Csharp\Desktop\Pedro Marini Nave\Desafio\Desafio\Pages\Add.razor"
       
    Pessoa pessoa = new Pessoa();

    void Create()
    {
        service.Create(pessoa);
        navigationManager.NavigateTo("pessoas");
    }

    void Cancel()
    {
        navigationManager.NavigateTo("pessoas");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PessoaService service { get; set; }
    }
}
#pragma warning restore 1591
