#pragma checksum "C:\Users\Chris\Desktop\repo\dab\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\Courses\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71a8f1b93d785cfac5757b6ea5a4d0213109e597"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Details), @"mvc.1.0.view", @"/Views/Courses/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Courses/Details.cshtml", typeof(AspNetCore.Views_Courses_Details))]
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
#line 1 "C:\Users\Chris\Desktop\repo\dab\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\_ViewImports.cshtml"
using BlackBoard;

#line default
#line hidden
#line 2 "C:\Users\Chris\Desktop\repo\dab\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\_ViewImports.cshtml"
using BlackBoard.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71a8f1b93d785cfac5757b6ea5a4d0213109e597", @"/Views/Courses/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59e5ca73709498ffda042e8048322b6cd44e68ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Courses_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlackBoard.Models.Course>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CourseContents", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "GroupHandins", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Chris\Desktop\repo\dab\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\Courses\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(78, 127, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Course</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(206, 46, false);
#line 14 "C:\Users\Chris\Desktop\repo\dab\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\Courses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CourseName));

#line default
#line hidden
            EndContext();
            BeginContext(252, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(314, 42, false);
#line 17 "C:\Users\Chris\Desktop\repo\dab\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\Courses\Details.cshtml"
       Write(Html.DisplayFor(model => model.CourseName));

#line default
#line hidden
            EndContext();
            BeginContext(356, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(417, 53, false);
#line 20 "C:\Users\Chris\Desktop\repo\dab\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\Courses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CourseManagements));

#line default
#line hidden
            EndContext();
            BeginContext(470, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(532, 42, false);
#line 23 "C:\Users\Chris\Desktop\repo\dab\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\Courses\Details.cshtml"
       Write(Html.DisplayFor(model => model.CourseName));

#line default
#line hidden
            EndContext();
            BeginContext(574, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(635, 49, false);
#line 26 "C:\Users\Chris\Desktop\repo\dab\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\Courses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ClassDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(684, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(746, 45, false);
#line 29 "C:\Users\Chris\Desktop\repo\dab\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\Courses\Details.cshtml"
       Write(Html.DisplayFor(model => model.ClassDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(791, 28, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n");
            EndContext();
#line 32 "C:\Users\Chris\Desktop\repo\dab\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\Courses\Details.cshtml"
     if (this.Model.CourseManagements != null)
    {
        foreach (var cm in this.Model.CourseManagements)
        {

#line default
#line hidden
            BeginContext(943, 95, true);
            WriteLiteral("            <b>Course teacher(s)</b><br />\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(1039, 56, false);
#line 38 "C:\Users\Chris\Desktop\repo\dab\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\Courses\Details.cshtml"
           Write(Html.DisplayNameFor(modelEnroll => cm.Teacher.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1095, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1169, 52, false);
#line 41 "C:\Users\Chris\Desktop\repo\dab\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\Courses\Details.cshtml"
           Write(Html.DisplayFor(modelEnroll => cm.Teacher.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1221, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(1294, 55, false);
#line 44 "C:\Users\Chris\Desktop\repo\dab\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\Courses\Details.cshtml"
           Write(Html.DisplayNameFor(modelEnroll => cm.Teacher.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1349, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1423, 51, false);
#line 47 "C:\Users\Chris\Desktop\repo\dab\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\Courses\Details.cshtml"
           Write(Html.DisplayFor(modelEnroll => cm.Teacher.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1474, 21, true);
            WriteLiteral("\r\n            </dd>\r\n");
            EndContext();
#line 49 "C:\Users\Chris\Desktop\repo\dab\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\Courses\Details.cshtml"
        }
    }
    else
    {

#line default
#line hidden
            BeginContext(1530, 44, true);
            WriteLiteral("        <b><br />No enrollments.</b><br />\r\n");
            EndContext();
#line 54 "C:\Users\Chris\Desktop\repo\dab\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\Courses\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(1581, 30, true);
            WriteLiteral("    <b>Enrollments</b><br />\r\n");
            EndContext();
#line 56 "C:\Users\Chris\Desktop\repo\dab\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\Courses\Details.cshtml"
     if (this.Model.Enrolls != null)
    {
        foreach (var enroll in this.Model.Enrolls)
        {

#line default
#line hidden
            BeginContext(1719, 51, true);
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(1771, 60, false);
#line 61 "C:\Users\Chris\Desktop\repo\dab\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\Courses\Details.cshtml"
           Write(Html.DisplayNameFor(modelEnroll => enroll.Student.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1831, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1905, 56, false);
#line 64 "C:\Users\Chris\Desktop\repo\dab\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\Courses\Details.cshtml"
           Write(Html.DisplayFor(modelEnroll => enroll.Student.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1961, 41, true);
            WriteLiteral("\r\n            </dd>\r\n            <br />\r\n");
            EndContext();
#line 67 "C:\Users\Chris\Desktop\repo\dab\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\Courses\Details.cshtml"
        }
    }
    else
    {

#line default
#line hidden
            BeginContext(2037, 44, true);
            WriteLiteral("        <b><br />No enrollments.</b><br />\r\n");
            EndContext();
#line 72 "C:\Users\Chris\Desktop\repo\dab\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\Courses\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(2088, 35, true);
            WriteLiteral("\r\n    <b>Course Content</b><br />\r\n");
            EndContext();
#line 75 "C:\Users\Chris\Desktop\repo\dab\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\Courses\Details.cshtml"
     if (this.Model.CourseContents != null)
    {
        foreach (var content in this.Model.CourseContents)
        {

#line default
#line hidden
            BeginContext(2246, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(2258, 176, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71a8f1b93d785cfac5757b6ea5a4d0213109e59713555", async() => {
                BeginContext(2383, 47, false);
#line 80 "C:\Users\Chris\Desktop\repo\dab\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\Courses\Details.cshtml"
                                                               Write(Html.DisplayFor(modelCC => content.ContentName));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 79 "C:\Users\Chris\Desktop\repo\dab\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\Courses\Details.cshtml"
                             WriteLiteral(content.CourseContentId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2434, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
#line 81 "C:\Users\Chris\Desktop\repo\dab\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\Courses\Details.cshtml"
        }
    }
    else
    {

#line default
#line hidden
            BeginContext(2477, 51, true);
            WriteLiteral("        <b><br />No course content yet.</b><br />\r\n");
            EndContext();
#line 86 "C:\Users\Chris\Desktop\repo\dab\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\Courses\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(2535, 34, true);
            WriteLiteral("    <b>Course Hand ins</b><br />\r\n");
            EndContext();
#line 88 "C:\Users\Chris\Desktop\repo\dab\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\Courses\Details.cshtml"
     if (this.Model.Assignments != null)
    {
        foreach (var content in this.Model.Assignments)
        {

#line default
#line hidden
            BeginContext(2686, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(2698, 172, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71a8f1b93d785cfac5757b6ea5a4d0213109e59717579", async() => {
                BeginContext(2816, 50, false);
#line 93 "C:\Users\Chris\Desktop\repo\dab\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\Courses\Details.cshtml"
                                                           Write(Html.DisplayFor(modelCC => content.AssignmentName));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 92 "C:\Users\Chris\Desktop\repo\dab\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\Courses\Details.cshtml"
                             WriteLiteral(content.AssignmentId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2870, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 94 "C:\Users\Chris\Desktop\repo\dab\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\Courses\Details.cshtml"
        }
    }
    else
    {

#line default
#line hidden
            BeginContext(2907, 51, true);
            WriteLiteral("        <b><br />No course content yet.</b><br />\r\n");
            EndContext();
#line 99 "C:\Users\Chris\Desktop\repo\dab\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\Courses\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(2965, 19, true);
            WriteLiteral("</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2984, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71a8f1b93d785cfac5757b6ea5a4d0213109e59721198", async() => {
                BeginContext(3036, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 102 "C:\Users\Chris\Desktop\repo\dab\DAB\DAB BlackBoardRemake\BlackBoard\BlackBoard\Views\Courses\Details.cshtml"
                           WriteLiteral(Model.CourseId);

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
            BeginContext(3044, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3052, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71a8f1b93d785cfac5757b6ea5a4d0213109e59723555", async() => {
                BeginContext(3074, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3090, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlackBoard.Models.Course> Html { get; private set; }
    }
}
#pragma warning restore 1591
