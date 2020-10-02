#pragma checksum "C:\Users\drnda_000\Desktop\Worldtech\WorldtechConsumeAPI\Worldtech\Views\Order\CheckoutComplete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95a55f32c4e052d0452bddfb84dd68aef96fa468"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_CheckoutComplete), @"mvc.1.0.view", @"/Views/Order/CheckoutComplete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/CheckoutComplete.cshtml", typeof(AspNetCore.Views_Order_CheckoutComplete))]
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
#line 1 "C:\Users\drnda_000\Desktop\Worldtech\WorldtechConsumeAPI\Worldtech\Views\_ViewImports.cshtml"
using Services;

#line default
#line hidden
#line 2 "C:\Users\drnda_000\Desktop\Worldtech\WorldtechConsumeAPI\Worldtech\Views\_ViewImports.cshtml"
using Domain;

#line default
#line hidden
#line 3 "C:\Users\drnda_000\Desktop\Worldtech\WorldtechConsumeAPI\Worldtech\Views\_ViewImports.cshtml"
using Presentation.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\drnda_000\Desktop\Worldtech\WorldtechConsumeAPI\Worldtech\Views\_ViewImports.cshtml"
using Worldtech.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95a55f32c4e052d0452bddfb84dd68aef96fa468", @"/Views/Order/CheckoutComplete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0eb2f35b265834ea9676fb9f529e77b70cb52b78", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_CheckoutComplete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Shared/PartialViews/OrderDetail/_CurrentOrderDetail.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 73, true);
            WriteLiteral("\r\n\r\n<div class=\"row checkoutComplete\">\r\n    <h3 class=\"text-center\">Dear ");
            EndContext();
            BeginContext(97, 15, false);
#line 5 "C:\Users\drnda_000\Desktop\Worldtech\WorldtechConsumeAPI\Worldtech\Views\Order\CheckoutComplete.cshtml"
                            Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(112, 35, true);
            WriteLiteral(", we sent a transaction request to ");
            EndContext();
            BeginContext(148, 11, false);
#line 5 "C:\Users\drnda_000\Desktop\Worldtech\WorldtechConsumeAPI\Worldtech\Views\Order\CheckoutComplete.cshtml"
                                                                               Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(159, 529, true);
            WriteLiteral(@".</h3> <br />
    <h4 class=""text-center"">Thank you, your order was successfully completed!</h4>

    <table class=""table table-dark"">
        <thead>
            <tr>
                <th scope=""col"" class=""text-left"">First name</th>
                <th scope=""col"">Last name</th>
                <th scope=""col"">Country</th>
                <th scope=""col"">Email</th>
                <th scope=""col"">Total</th>
            </tr>
        </thead>

        <tbody>
            <tr scope=""row"">
                <td>");
            EndContext();
            BeginContext(689, 15, false);
#line 21 "C:\Users\drnda_000\Desktop\Worldtech\WorldtechConsumeAPI\Worldtech\Views\Order\CheckoutComplete.cshtml"
               Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(704, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(732, 14, false);
#line 22 "C:\Users\drnda_000\Desktop\Worldtech\WorldtechConsumeAPI\Worldtech\Views\Order\CheckoutComplete.cshtml"
               Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(746, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(774, 13, false);
#line 23 "C:\Users\drnda_000\Desktop\Worldtech\WorldtechConsumeAPI\Worldtech\Views\Order\CheckoutComplete.cshtml"
               Write(Model.Country);

#line default
#line hidden
            EndContext();
            BeginContext(787, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(815, 11, false);
#line 24 "C:\Users\drnda_000\Desktop\Worldtech\WorldtechConsumeAPI\Worldtech\Views\Order\CheckoutComplete.cshtml"
               Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(826, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(854, 30, false);
#line 25 "C:\Users\drnda_000\Desktop\Worldtech\WorldtechConsumeAPI\Worldtech\Views\Order\CheckoutComplete.cshtml"
               Write(Model.OrderTotal.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(884, 62, true);
            WriteLiteral("</td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n\r\n\r\n");
            EndContext();
#line 31 "C:\Users\drnda_000\Desktop\Worldtech\WorldtechConsumeAPI\Worldtech\Views\Order\CheckoutComplete.cshtml"
     if (Model.OrderDetails.Count != 0)
    {

#line default
#line hidden
            BeginContext(994, 85, true);
            WriteLiteral("        <br /><br />\r\n        <h2 class=\"text-center\">Your ordered Product(s):</h2>\r\n");
            EndContext();
#line 36 "C:\Users\drnda_000\Desktop\Worldtech\WorldtechConsumeAPI\Worldtech\Views\Order\CheckoutComplete.cshtml"
         foreach (var orderDetail in Model.OrderDetails)
        {

#line default
#line hidden
            BeginContext(1158, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(1170, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "87d9610cedc94ba886d067f654901099", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 38 "C:\Users\drnda_000\Desktop\Worldtech\WorldtechConsumeAPI\Worldtech\Views\Order\CheckoutComplete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = orderDetail;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1275, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 39 "C:\Users\drnda_000\Desktop\Worldtech\WorldtechConsumeAPI\Worldtech\Views\Order\CheckoutComplete.cshtml"
        }

#line default
#line hidden
#line 39 "C:\Users\drnda_000\Desktop\Worldtech\WorldtechConsumeAPI\Worldtech\Views\Order\CheckoutComplete.cshtml"
         

    }

#line default
#line hidden
            BeginContext(1295, 9, true);
            WriteLiteral(";\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
