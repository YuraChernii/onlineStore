#pragma checksum "D:\repo\.NetCore\TraineeProj\lab2-onlineStore\Views\Shoes\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39165555db76fe6c02dee5b847c48b121165cca0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shoes_List), @"mvc.1.0.view", @"/Views/Shoes/List.cshtml")]
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
#line 1 "D:\repo\.NetCore\TraineeProj\lab2-onlineStore\Views\_ViewImports.cshtml"
using Tymchak_shop.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\repo\.NetCore\TraineeProj\lab2-onlineStore\Views\Shoes\List.cshtml"
using Tymchak_shop.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39165555db76fe6c02dee5b847c48b121165cca0", @"/Views/Shoes/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46df4dddd821294d88fd5a788e4cd3da52ef312d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shoes_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<h1>All shoes.</h1>\r\n<h3>");
#nullable restore
#line 4 "D:\repo\.NetCore\TraineeProj\lab2-onlineStore\Views\Shoes\List.cshtml"
Write(Model.currCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<div class=\"row mt-5 mb-2\">\r\n");
#nullable restore
#line 6 "D:\repo\.NetCore\TraineeProj\lab2-onlineStore\Views\Shoes\List.cshtml"
      
        foreach (Shoes shoes in Model.allShoes)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\repo\.NetCore\TraineeProj\lab2-onlineStore\Views\Shoes\List.cshtml"
       Write(Html.Partial("AllShoes", shoes));

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\repo\.NetCore\TraineeProj\lab2-onlineStore\Views\Shoes\List.cshtml"
                                            
        }

    

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
