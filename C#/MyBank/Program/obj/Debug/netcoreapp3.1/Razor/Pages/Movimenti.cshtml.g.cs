#pragma checksum "C:\Users\Studente\Desktop\C_Exercises\C#\MyBank\Program\Pages\Movimenti.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "946a8cb2db171f497edf17ef8ce7587231c643a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyBank.Pages.Pages_Movimenti), @"mvc.1.0.razor-page", @"/Pages/Movimenti.cshtml")]
namespace MyBank.Pages
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
#line 1 "C:\Users\Studente\Desktop\C_Exercises\C#\MyBank\Program\Pages\_ViewImports.cshtml"
using MyBank;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"946a8cb2db171f497edf17ef8ce7587231c643a9", @"/Pages/Movimenti.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ff3d72701c3dd563708cbecb3740d9e8e2a8f33", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Movimenti : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Studente\Desktop\C_Exercises\C#\MyBank\Program\Pages\Movimenti.cshtml"
  
    ViewData["Title"] = "Movimenti";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--Intestazione-->
<div class=""container"" id=""intestazione"">
    <div class=""row justify-content-center"">
        <!--Colonna sinistra-->
        <div class=""col-3"">
         
        </div>
        <!--Colonna centrale-->
        <div class=""col-6"">
            <br><h3>");
#nullable restore
#line 16 "C:\Users\Studente\Desktop\C_Exercises\C#\MyBank\Program\Pages\Movimenti.cshtml"
               Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3><br>
        </div>
        <!--Colonna destra-->
        <div class=""col-3"">
        </div>
    </div>
</div>

<!--Centrale-->
<div class=""container"" id=""centrale"">
    <div class=""row justify-content-center"">
        <!--Colonna sinistra-->
        <div class=""col-3"">
        </div>
        <!--Colonna centrale-->
        <div class=""col-6"">
        </div>
        <!--Colonna destra-->
        <div class=""col-3"">
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyBank.Pages.MovimentiModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyBank.Pages.MovimentiModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyBank.Pages.MovimentiModel>)PageContext?.ViewData;
        public MyBank.Pages.MovimentiModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
