#pragma checksum "C:\Backend Projects\WorldtechWithAPIRefactored\WorldtechWithAPI\Worldtech\Views\Shared\PartialViews\Comments\_UserComment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99781b10a3dd4ac3d0e5342d5a1052ba2978b161"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_PartialViews_Comments__UserComment), @"mvc.1.0.view", @"/Views/Shared/PartialViews/Comments/_UserComment.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/PartialViews/Comments/_UserComment.cshtml", typeof(AspNetCore.Views_Shared_PartialViews_Comments__UserComment))]
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
#line 1 "C:\Backend Projects\WorldtechWithAPIRefactored\WorldtechWithAPI\Worldtech\Views\_ViewImports.cshtml"
using Services;

#line default
#line hidden
#line 2 "C:\Backend Projects\WorldtechWithAPIRefactored\WorldtechWithAPI\Worldtech\Views\_ViewImports.cshtml"
using Domain;

#line default
#line hidden
#line 3 "C:\Backend Projects\WorldtechWithAPIRefactored\WorldtechWithAPI\Worldtech\Views\_ViewImports.cshtml"
using Presentation.ViewModels;

#line default
#line hidden
#line 4 "C:\Backend Projects\WorldtechWithAPIRefactored\WorldtechWithAPI\Worldtech\Views\_ViewImports.cshtml"
using Worldtech.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99781b10a3dd4ac3d0e5342d5a1052ba2978b161", @"/Views/Shared/PartialViews/Comments/_UserComment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0eb2f35b265834ea9676fb9f529e77b70cb52b78", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_Comments__UserComment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CommentVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(18, 89, true);
            WriteLiteral("\r\n\r\n<br /><br /><hr />\r\n<li class=\"text-wheat\"><span class=\"text-yellowish\">User:</span> ");
            EndContext();
            BeginContext(108, 10, false);
#line 5 "C:\Backend Projects\WorldtechWithAPIRefactored\WorldtechWithAPI\Worldtech\Views\Shared\PartialViews\Comments\_UserComment.cshtml"
                                                            Write(Model.User);

#line default
#line hidden
            EndContext();
            BeginContext(118, 72, true);
            WriteLiteral("</li>\r\n<li class=\"text-wheat\"><span class=\"text-yellowish\">Date:</span> ");
            EndContext();
            BeginContext(191, 10, false);
#line 6 "C:\Backend Projects\WorldtechWithAPIRefactored\WorldtechWithAPI\Worldtech\Views\Shared\PartialViews\Comments\_UserComment.cshtml"
                                                            Write(Model.Date);

#line default
#line hidden
            EndContext();
            BeginContext(201, 75, true);
            WriteLiteral("</li>\r\n<li class=\"text-wheat\"><span class=\"text-yellowish\">Message:</span> ");
            EndContext();
            BeginContext(277, 13, false);
#line 7 "C:\Backend Projects\WorldtechWithAPIRefactored\WorldtechWithAPI\Worldtech\Views\Shared\PartialViews\Comments\_UserComment.cshtml"
                                                               Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(290, 7, true);
            WriteLiteral("</li>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CommentVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
