#pragma checksum "C:\Users\Mads\Source\Repos\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\GroupHandins\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7581506b7ff696260f399974d8a560379786e73a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GroupHandins_Details), @"mvc.1.0.view", @"/Views/GroupHandins/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/GroupHandins/Details.cshtml", typeof(AspNetCore.Views_GroupHandins_Details))]
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
#line 1 "C:\Users\Mads\Source\Repos\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\_ViewImports.cshtml"
using BlackBoard;

#line default
#line hidden
#line 2 "C:\Users\Mads\Source\Repos\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\_ViewImports.cshtml"
using BlackBoard.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7581506b7ff696260f399974d8a560379786e73a", @"/Views/GroupHandins/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59e5ca73709498ffda042e8048322b6cd44e68ae", @"/Views/_ViewImports.cshtml")]
    public class Views_GroupHandins_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlackBoard.Models.GroupHandin>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Mads\Source\Repos\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\GroupHandins\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(83, 134, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>GroupHandin</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(218, 46, false);
#line 14 "C:\Users\Mads\Source\Repos\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\GroupHandins\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Assignment));

#line default
#line hidden
            EndContext();
            BeginContext(264, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(328, 57, false);
#line 17 "C:\Users\Mads\Source\Repos\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\GroupHandins\Details.cshtml"
       Write(Html.DisplayFor(model => model.Assignment.AssignmentName));

#line default
#line hidden
            EndContext();
            BeginContext(385, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(448, 41, false);
#line 20 "C:\Users\Mads\Source\Repos\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\GroupHandins\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Group));

#line default
#line hidden
            EndContext();
            BeginContext(489, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(553, 45, false);
#line 23 "C:\Users\Mads\Source\Repos\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\GroupHandins\Details.cshtml"
       Write(Html.DisplayFor(model => model.Group.GroupId));

#line default
#line hidden
            EndContext();
            BeginContext(598, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(661, 43, false);
#line 26 "C:\Users\Mads\Source\Repos\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\GroupHandins\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Teacher));

#line default
#line hidden
            EndContext();
            BeginContext(704, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(768, 49, false);
#line 29 "C:\Users\Mads\Source\Repos\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\GroupHandins\Details.cshtml"
       Write(Html.DisplayFor(model => model.Teacher.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(817, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(880, 64, false);
#line 32 "C:\Users\Mads\Source\Repos\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\GroupHandins\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Assignment.Course.CourseName));

#line default
#line hidden
            EndContext();
            BeginContext(944, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1008, 60, false);
#line 35 "C:\Users\Mads\Source\Repos\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\GroupHandins\Details.cshtml"
       Write(Html.DisplayFor(model => model.Assignment.Course.CourseName));

#line default
#line hidden
            EndContext();
            BeginContext(1068, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1131, 41, false);
#line 38 "C:\Users\Mads\Source\Repos\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\GroupHandins\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Grade));

#line default
#line hidden
            EndContext();
            BeginContext(1172, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1236, 37, false);
#line 41 "C:\Users\Mads\Source\Repos\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\GroupHandins\Details.cshtml"
       Write(Html.DisplayFor(model => model.Grade));

#line default
#line hidden
            EndContext();
            BeginContext(1273, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1320, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7581506b7ff696260f399974d8a560379786e73a8924", async() => {
                BeginContext(1377, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\Mads\Source\Repos\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\GroupHandins\Details.cshtml"
                           WriteLiteral(Model.GroupHandinId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1385, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1393, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7581506b7ff696260f399974d8a560379786e73a11284", async() => {
                BeginContext(1415, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1431, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlackBoard.Models.GroupHandin> Html { get; private set; }
    }
}
#pragma warning restore 1591
