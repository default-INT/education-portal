#pragma checksum "E:\Other\GSTU\work\hackathon\education-portal\backend\EducationPortal\EducationPortalASP\Views\Home\Course.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17a2ebcb4172f4698c36bc08cfcd81ffbb149925"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Course), @"mvc.1.0.view", @"/Views/Home/Course.cshtml")]
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
#line 1 "E:\Other\GSTU\work\hackathon\education-portal\backend\EducationPortal\EducationPortalASP\Views\_ViewImports.cshtml"
using EducationPortalASP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Other\GSTU\work\hackathon\education-portal\backend\EducationPortal\EducationPortalASP\Views\_ViewImports.cshtml"
using EducationPortalASP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17a2ebcb4172f4698c36bc08cfcd81ffbb149925", @"/Views/Home/Course.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49dfd2525fb7281059d78fb512d256a2f3b05dc7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Course : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EducationPortalASP.ViewModel.HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<content>
    <div class=""course-page"">
        <div class=""course-main-info"">
            <div id=""icon"">
                <i class=""fa fa-book""></i>
                <div class=""inner-fast-info"">
                    <label><i class=""fa fa-money""></i>");
#nullable restore
#line 13 "E:\Other\GSTU\work\hackathon\education-portal\backend\EducationPortal\EducationPortalASP\Views\Home\Course.cshtml"
                                                 Write(Model.CourseItem.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</label>\r\n                    <label><i class=\"fa fa-users\"></i>");
#nullable restore
#line 14 "E:\Other\GSTU\work\hackathon\education-portal\backend\EducationPortal\EducationPortalASP\Views\Home\Course.cshtml"
                                                  Write(new Random().Next(0, 1000));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    <label><i class=\"fa fa-star\"> </i><div>");
#nullable restore
#line 15 "E:\Other\GSTU\work\hackathon\education-portal\backend\EducationPortal\EducationPortalASP\Views\Home\Course.cshtml"
                                                       Write(new Random().Next(0, 100) / 10);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div></label>\r\n                </div>\r\n            </div>\r\n            <div id=\"content\">\r\n                <div id=\"title\">");
#nullable restore
#line 19 "E:\Other\GSTU\work\hackathon\education-portal\backend\EducationPortal\EducationPortalASP\Views\Home\Course.cshtml"
                           Write(Model.CourseItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div id=\"descript\"><p>Описание курса</p>");
#nullable restore
#line 20 "E:\Other\GSTU\work\hackathon\education-portal\backend\EducationPortal\EducationPortalASP\Views\Home\Course.cshtml"
                                                   Write(Model.CourseItem.Descript);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div id=\"source-lib\">\r\n                    <p>Рекоменлованная литература</p>");
#nullable restore
#line 22 "E:\Other\GSTU\work\hackathon\education-portal\backend\EducationPortal\EducationPortalASP\Views\Home\Course.cshtml"
                                                Write(Model.CourseItem.Bibliography);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div id=\"hometask\">\r\n                    <p>Домашние задание</p>\r\n                    ");
#nullable restore
#line 26 "E:\Other\GSTU\work\hackathon\education-portal\backend\EducationPortal\EducationPortalASP\Views\Home\Course.cshtml"
               Write(Model.CourseItem.HomeTask);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
</content>
<content>
    <div class=""course-lesson"">
        <div class=""lesson-content"">
            <div id=""title"">Занятие 1</div>
            <div id=""lesson-icon""><img src=""../img/lesson1.png"" width=""150px""></div>
            <div id=""dificult"">Сложность <i class=""fa fa-star""> </i><i class=""fa fa-star""></i></div>
            <div id=""descript"">Вводное занятие. Изучение основ ООП. Наследование, полиморфизм, инкапсуляция.</div>
        </div>
        <div class=""lesson-content"">
            <div id=""title"">Занятие 2</div>
            <div id=""lesson-icon""><img src=""../img/lesson1.png"" width=""150px""></div>
            <div id=""dificult"">Сложность <i class=""fa fa-star""> </i><i class=""fa fa-star""></i></div>
            <div id=""descript"">Создание иерархии классов. Интерфейсы и абстрактные классы.</div>
        </div>
    </div>
</content>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EducationPortalASP.ViewModel.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
