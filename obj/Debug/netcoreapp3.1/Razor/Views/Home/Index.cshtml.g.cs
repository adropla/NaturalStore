#pragma checksum "C:\Users\adropla\source\repos\Natural-Store\NaturalStore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41597710809efc13c1d88b4c3bcfeea182e708cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 2 "C:\Users\adropla\source\repos\Natural-Store\NaturalStore\Views\_ViewImports.cshtml"
using NaturalStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\adropla\source\repos\Natural-Store\NaturalStore\Views\_ViewImports.cshtml"
using NaturalStore.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\adropla\source\repos\Natural-Store\NaturalStore\Views\_ViewImports.cshtml"
using NaturalStore.Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\adropla\source\repos\Natural-Store\NaturalStore\Views\_ViewImports.cshtml"
using NaturalStore.Models.ViewComponents;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41597710809efc13c1d88b4c3bcfeea182e708cb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0c59a76fbbbc76f7c975b3f1b7da5e6596b0cef", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TextField>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\adropla\source\repos\Natural-Store\NaturalStore\Views\Home\Index.cshtml"
  
    ViewBag.Title = Model.MetaTitle;
    ViewBag.Description = Model.MetaDescription;
    ViewBag.Keywords = Model.MetaKeywords;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <div id=""banner"" class=""box container"">
        <div class=""row"">
            <div class=""col-7 col-12-medium"">
                <h2>Natural Store</h2>
                <p style=""font-size: 1em;"">
                    Группа энтузиастов, которые хотят сделать твою жизнь приятнее. Весь товар мы собираем и обрабатываем самостоятельно, следуя лучшим известным технологиям

                    Наши предложения высочайшего качества, идеальны для жителей пыльных мегаполисов, которые хотят снизить стресс и улучшить память

                    В скором времени будут организованы выездные лесные ретриты. А записаться можно уже сейчас. Мы будем рады каждому!
                </p>
            </div>
            <div class=""col-5 col-12-medium"">
                <img src=""/images/logo.png"" width=""400"" height=""400"" alt=""Alternate Text"" />
            </div>
        </div>
    </div>
    <h3 style=""padding: 2em 0 1.5em 0;"">Отзывы наших клиентов</h3>
    <div class=""row"">
        <div class=""col-4 ");
            WriteLiteral("col-12-medium\">\r\n\r\n            <!-- Box -->\r\n            <section class=\"box feature\">\r\n                <a href=\"#\" class=\"image featured\"><img src=\"/images/pic01.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1348, "\"", 1354, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                <div class=""inner"">
                    <header>
                        <h2>Грибник Григорий</h2>
                        <p>г. Грозный, Кауказ</p>
                    </header>
                    <p>Мухоморы потрясающие. шляпки цельные, высушены хорошо. В баню с друзьями самое то</p>
                </div>
            </section>

        </div>
        <div class=""col-4 col-12-medium"">

            <!-- Box -->
            <section class=""box feature"">
                <a href=""#"" class=""image featured""><img src=""/images/pic02.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1931, "\"", 1937, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                <div class=""inner"">
                    <header>
                        <h2>Алексей</h2>
                        <p>Где-то из леса</p>
                    </header>
                    <p>Это не только отличный товар, но и отличная служба доставки. Поговорил с курьером 5 минут и узнал столько интересной информации, что готов заказать ещё ради второй встречи с ним</p>
                </div>
            </section>

        </div>
        <div class=""col-4 col-12-medium"">

            <!-- Box -->
            <section class=""box feature"">
                <a href=""#"" class=""image featured""><img src=""/images/pic03.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2597, "\"", 2603, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                <div class=""inner"">
                    <header>
                        <h2>Васёк</h2>
                        <p>Живу по кайфу ежжжжи</p>
                    </header>
                    <p>Доволен как слон. Эффект от ежовика выше всяких похвал, наконец бошка начала работать</p>
                </div>
            </section>

        </div>
    </div>
    ");
#nullable restore
#line 74 "C:\Users\adropla\source\repos\Natural-Store\NaturalStore\Views\Home\Index.cshtml"
Write(Html.Raw(Model.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TextField> Html { get; private set; }
    }
}
#pragma warning restore 1591
