#pragma checksum "C:\Users\Prophesy\Documents\C#2019\Modern_Warfare_2019_WebApp\Modern_Warfare_2019_WebApp\Views\Weapon\ViewKDRatio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a15ca4ed607ba9090fc8ea2b503c67deaf7f6018"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Weapon_ViewKDRatio), @"mvc.1.0.view", @"/Views/Weapon/ViewKDRatio.cshtml")]
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
#line 1 "C:\Users\Prophesy\Documents\C#2019\Modern_Warfare_2019_WebApp\Modern_Warfare_2019_WebApp\Views\_ViewImports.cshtml"
using Modern_Warfare_2019_WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Prophesy\Documents\C#2019\Modern_Warfare_2019_WebApp\Modern_Warfare_2019_WebApp\Views\_ViewImports.cshtml"
using Modern_Warfare_2019_WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a15ca4ed607ba9090fc8ea2b503c67deaf7f6018", @"/Views/Weapon/ViewKDRatio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90edbe9b3172fdfc6b236356170afeacd17d4993", @"/Views/_ViewImports.cshtml")]
    public class Views_Weapon_ViewKDRatio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Modern_Warfare_2019_WebApp.Models.Soldier>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Prophesy\Documents\C#2019\Modern_Warfare_2019_WebApp\Modern_Warfare_2019_WebApp\Views\Weapon\ViewKDRatio.cshtml"
  
    ViewData["Title"] = "ViewKDRatio";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<h1 style=\"text-align: center; color: white;\">View KDRatio</h1>\r\n<br />\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Prophesy\Documents\C#2019\Modern_Warfare_2019_WebApp\Modern_Warfare_2019_WebApp\Views\Weapon\ViewKDRatio.cshtml"
 if (Model.KDRatio > 5.0)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("<h2 style=\"font-weight: bolder; color: white;\">\r\n    Hey ");
#nullable restore
#line 14 "C:\Users\Prophesy\Documents\C#2019\Modern_Warfare_2019_WebApp\Modern_Warfare_2019_WebApp\Views\Weapon\ViewKDRatio.cshtml"
   Write(Model.SoldierName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", you caught ");
#nullable restore
#line 14 "C:\Users\Prophesy\Documents\C#2019\Modern_Warfare_2019_WebApp\Modern_Warfare_2019_WebApp\Views\Weapon\ViewKDRatio.cshtml"
                                  Write(Model.Kills);

#line default
#line hidden
#nullable disable
            WriteLiteral(" bodies <br />\r\n    and got faded ");
#nullable restore
#line 15 "C:\Users\Prophesy\Documents\C#2019\Modern_Warfare_2019_WebApp\Modern_Warfare_2019_WebApp\Views\Weapon\ViewKDRatio.cshtml"
             Write(Model.Deaths);

#line default
#line hidden
#nullable disable
            WriteLiteral(" times. Your KOD ratio was<br />\r\n    ");
#nullable restore
#line 16 "C:\Users\Prophesy\Documents\C#2019\Modern_Warfare_2019_WebApp\Modern_Warfare_2019_WebApp\Views\Weapon\ViewKDRatio.cshtml"
Write(Model.KDRatio);

#line default
#line hidden
#nullable disable
            WriteLiteral("! Your a beast at Modern Warfare!\r\n</h2>\r\n");
#nullable restore
#line 18 "C:\Users\Prophesy\Documents\C#2019\Modern_Warfare_2019_WebApp\Modern_Warfare_2019_WebApp\Views\Weapon\ViewKDRatio.cshtml"

    //<img src="~/pictures/" alt="" height="500" width="500" />

    //<img src="~/pictures/" alt="" height="500" width="500" />

}
else if (Model.KDRatio >= 1.0 && Model.KDRatio <= 5)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2 style=\"font-weight: bolder; color: white;\">\r\n        Hey ");
#nullable restore
#line 28 "C:\Users\Prophesy\Documents\C#2019\Modern_Warfare_2019_WebApp\Modern_Warfare_2019_WebApp\Views\Weapon\ViewKDRatio.cshtml"
       Write(Model.SoldierName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", you caught ");
#nullable restore
#line 28 "C:\Users\Prophesy\Documents\C#2019\Modern_Warfare_2019_WebApp\Modern_Warfare_2019_WebApp\Views\Weapon\ViewKDRatio.cshtml"
                                      Write(Model.Kills);

#line default
#line hidden
#nullable disable
            WriteLiteral(" bodies <br />\r\n        and got faded ");
#nullable restore
#line 29 "C:\Users\Prophesy\Documents\C#2019\Modern_Warfare_2019_WebApp\Modern_Warfare_2019_WebApp\Views\Weapon\ViewKDRatio.cshtml"
                 Write(Model.Deaths);

#line default
#line hidden
#nullable disable
            WriteLiteral(" times. Your KOD ratio was<br />\r\n        ");
#nullable restore
#line 30 "C:\Users\Prophesy\Documents\C#2019\Modern_Warfare_2019_WebApp\Modern_Warfare_2019_WebApp\Views\Weapon\ViewKDRatio.cshtml"
   Write(Model.KDRatio);

#line default
#line hidden
#nullable disable
            WriteLiteral("! You aight! Step your game up next time.\r\n    </h2>\r\n");
#nullable restore
#line 32 "C:\Users\Prophesy\Documents\C#2019\Modern_Warfare_2019_WebApp\Modern_Warfare_2019_WebApp\Views\Weapon\ViewKDRatio.cshtml"

    //<img src="~/pictures/" alt="" height="500" width="500" />

    //<img src="~/pictures/" alt="" height="500" width="500" />

}
else
{


#line default
#line hidden
#nullable disable
            WriteLiteral("<h2 style=\"font-weight: bolder; color: white;\">\r\n    Hey ");
#nullable restore
#line 42 "C:\Users\Prophesy\Documents\C#2019\Modern_Warfare_2019_WebApp\Modern_Warfare_2019_WebApp\Views\Weapon\ViewKDRatio.cshtml"
   Write(Model.SoldierName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", you caught ");
#nullable restore
#line 42 "C:\Users\Prophesy\Documents\C#2019\Modern_Warfare_2019_WebApp\Modern_Warfare_2019_WebApp\Views\Weapon\ViewKDRatio.cshtml"
                                  Write(Model.Kills);

#line default
#line hidden
#nullable disable
            WriteLiteral(" bodies <br />\r\n    and got faded ");
#nullable restore
#line 43 "C:\Users\Prophesy\Documents\C#2019\Modern_Warfare_2019_WebApp\Modern_Warfare_2019_WebApp\Views\Weapon\ViewKDRatio.cshtml"
             Write(Model.Deaths);

#line default
#line hidden
#nullable disable
            WriteLiteral(" times. Your KOD ratio was<br />\r\n    ");
#nullable restore
#line 44 "C:\Users\Prophesy\Documents\C#2019\Modern_Warfare_2019_WebApp\Modern_Warfare_2019_WebApp\Views\Weapon\ViewKDRatio.cshtml"
Write(Model.KDRatio);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"! Bro, my guy, I'm sorry, but i just gotta say,<br />
    you're garbage, trash, no good, terrible! Break the game, <br />
    throw away your system because this is not your game! <br />
    A man with no eyes can shoot better then you! You couldnt <br />
    hit water if you fell out of a boat!
</h2>
");
#nullable restore
#line 50 "C:\Users\Prophesy\Documents\C#2019\Modern_Warfare_2019_WebApp\Modern_Warfare_2019_WebApp\Views\Weapon\ViewKDRatio.cshtml"

    //<img src="~/pictures/" alt="" height="500" width="500" />

    //<img src="~/pictures/" alt="" height="500" width="500" />

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Modern_Warfare_2019_WebApp.Models.Soldier> Html { get; private set; }
    }
}
#pragma warning restore 1591
