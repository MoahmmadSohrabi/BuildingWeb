#pragma checksum "C:\Users\Mohammad\Documents\Visual Stdio 2010\Projects\Asp.NetCore\Building.Web\Building.Web\Views\Home\ShowBulletin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb1ffef8fafeaceb41b31a30d99815e1193bb868"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowBulletin), @"mvc.1.0.view", @"/Views/Home/ShowBulletin.cshtml")]
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
#line 1 "C:\Users\Mohammad\Documents\Visual Stdio 2010\Projects\Asp.NetCore\Building.Web\Building.Web\Views\_ViewImports.cshtml"
using Building;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Mohammad\Documents\Visual Stdio 2010\Projects\Asp.NetCore\Building.Web\Building.Web\Views\Home\ShowBulletin.cshtml"
using Building.Core.Convertors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mohammad\Documents\Visual Stdio 2010\Projects\Asp.NetCore\Building.Web\Building.Web\Views\Home\ShowBulletin.cshtml"
using Building.DataLayer.Entities.Course;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb1ffef8fafeaceb41b31a30d99815e1193bb868", @"/Views/Home/ShowBulletin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e27aa01fc834ab08ceef07fc837d10343ae7fc7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowBulletin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Building.DataLayer.Entities.Course.Bulletin>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Mohammad\Documents\Visual Stdio 2010\Projects\Asp.NetCore\Building.Web\Building.Web\Views\Home\ShowBulletin.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Mohammad\Documents\Visual Stdio 2010\Projects\Asp.NetCore\Building.Web\Building.Web\Views\Home\ShowBulletin.cshtml"
 foreach (var item in Model) {


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"item\">\r\n    <h4>");
#nullable restore
#line 10 "C:\Users\Mohammad\Documents\Visual Stdio 2010\Projects\Asp.NetCore\Building.Web\Building.Web\Views\Home\ShowBulletin.cshtml"
   Write(item.BulletinHeader);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <div class=\"icon\"><img src=\"/assets/images/service-icon-01.png\"");
            BeginWriteAttribute("alt", " alt=\"", 317, "\"", 323, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n    <p>");
#nullable restore
#line 12 "C:\Users\Mohammad\Documents\Visual Stdio 2010\Projects\Asp.NetCore\Building.Web\Building.Web\Views\Home\ShowBulletin.cshtml"
  Write(item.BulletinText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n");
#nullable restore
#line 14 "C:\Users\Mohammad\Documents\Visual Stdio 2010\Projects\Asp.NetCore\Building.Web\Building.Web\Views\Home\ShowBulletin.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Building.DataLayer.Entities.Course.Bulletin>> Html { get; private set; }
    }
}
#pragma warning restore 1591
