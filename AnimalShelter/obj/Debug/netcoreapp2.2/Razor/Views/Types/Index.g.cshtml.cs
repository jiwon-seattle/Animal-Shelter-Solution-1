#pragma checksum "/Users/Guest/Desktop/Animal-Shelter-Solution/AnimalShelter/Views/Types/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbc1d5b6f35c6fa729c54933a563f7bdfc254223"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Types_Index), @"mvc.1.0.view", @"/Views/Types/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Types/Index.cshtml", typeof(AspNetCore.Views_Types_Index))]
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
#line 4 "/Users/Guest/Desktop/Animal-Shelter-Solution/AnimalShelter/Views/Types/Index.cshtml"
using AnimalShelter.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbc1d5b6f35c6fa729c54933a563f7bdfc254223", @"/Views/Types/Index.cshtml")]
    public class Views_Types_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AnimalShelter.Models.Types>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/Animal-Shelter-Solution/AnimalShelter/Views/Types/Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(99, 17, true);
            WriteLiteral("<h1>Types:</h1>\n\n");
            EndContext();
#line 8 "/Users/Guest/Desktop/Animal-Shelter-Solution/AnimalShelter/Views/Types/Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
            BeginContext(141, 43, true);
            WriteLiteral("    <h3>No types have been added yet.</h3>\n");
            EndContext();
#line 11 "/Users/Guest/Desktop/Animal-Shelter-Solution/AnimalShelter/Views/Types/Index.cshtml"
}

#line default
#line hidden
            BeginContext(186, 5, true);
            WriteLiteral("<ul>\n");
            EndContext();
#line 13 "/Users/Guest/Desktop/Animal-Shelter-Solution/AnimalShelter/Views/Types/Index.cshtml"
     foreach (Types types in Model)
    {

#line default
#line hidden
            BeginContext(233, 25, true);
            WriteLiteral("        <li class=\"link\">");
            EndContext();
            BeginContext(259, 69, false);
#line 15 "/Users/Guest/Desktop/Animal-Shelter-Solution/AnimalShelter/Views/Types/Index.cshtml"
                    Write(Html.ActionLink($"{types.Name}", "Details", new {id = types.TypesId}));

#line default
#line hidden
            EndContext();
            BeginContext(328, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 16 "/Users/Guest/Desktop/Animal-Shelter-Solution/AnimalShelter/Views/Types/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(340, 23, true);
            WriteLiteral("</ul>\n\n<p class=\"link\">");
            EndContext();
            BeginContext(364, 42, false);
#line 19 "/Users/Guest/Desktop/Animal-Shelter-Solution/AnimalShelter/Views/Types/Index.cshtml"
           Write(Html.ActionLink("Add new types", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(406, 21, true);
            WriteLiteral("</p>\n<p class=\"link\">");
            EndContext();
            BeginContext(428, 40, false);
#line 20 "/Users/Guest/Desktop/Animal-Shelter-Solution/AnimalShelter/Views/Types/Index.cshtml"
           Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(468, 4, true);
            WriteLiteral("</p>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AnimalShelter.Models.Types>> Html { get; private set; }
    }
}
#pragma warning restore 1591
