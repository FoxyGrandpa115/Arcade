#pragma checksum "C:\Users\jason\Documents\WOS Enterprises\HW Assignments\Arcade\Views\Arcade\UserDashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44a7553d47bb795d418fb63638268b835bf46b25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Arcade_UserDashboard), @"mvc.1.0.view", @"/Views/Arcade/UserDashboard.cshtml")]
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
#line 1 "C:\Users\jason\Documents\WOS Enterprises\HW Assignments\Arcade\Views\_ViewImports.cshtml"
using Arcade;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jason\Documents\WOS Enterprises\HW Assignments\Arcade\Views\_ViewImports.cshtml"
using Arcade.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44a7553d47bb795d418fb63638268b835bf46b25", @"/Views/Arcade/UserDashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbf67504c3e59dbe35fdc8b89a02570782c179b4", @"/Views/_ViewImports.cshtml")]
    public class Views_Arcade_UserDashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RSVP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-status", "delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-status", "remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-status", "add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("wrap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44a7553d47bb795d418fb63638268b835bf46b254933", async() => {
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <link rel=\"stylesheet\" href=\"/css/styles.css\"/>\n    <title>User Dashboard</title>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<h1>Jason\'s Arcade</h1>\n\n\n\n\n");
#nullable restore
#line 13 "C:\Users\jason\Documents\WOS Enterprises\HW Assignments\Arcade\Views\Arcade\UserDashboard.cshtml"
  
    DateTime Current = DateTime.Now;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"flex\">\n    <div class=\"left\">\n");
#nullable restore
#line 17 "C:\Users\jason\Documents\WOS Enterprises\HW Assignments\Arcade\Views\Arcade\UserDashboard.cshtml"
Write(Current.ToString("hh:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n <div class=\"right\">\n<a href=\"/\">Logout</a>\n    </div>\n</div>\n");
            WriteLiteral("<h3>Welcome ");
#nullable restore
#line 25 "C:\Users\jason\Documents\WOS Enterprises\HW Assignments\Arcade\Views\Arcade\UserDashboard.cshtml"
       Write(ViewBag.ThisUser.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h3>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44a7553d47bb795d418fb63638268b835bf46b257124", async() => {
                WriteLiteral("\n    \n<div class=\"flex\">\n    <div class=\"navleft\">\n        <a");
                BeginWriteAttribute("href", " href=\"", 602, "\"", 639, 2);
                WriteAttributeValue("", 609, "/Game/", 609, 6, true);
#nullable restore
#line 30 "C:\Users\jason\Documents\WOS Enterprises\HW Assignments\Arcade\Views\Arcade\UserDashboard.cshtml"
WriteAttributeValue("", 615, ViewBag.ThisUser.userId, 615, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">New Game</a>\n    </div>\n<div class=\"right\">\n    <ul>\n");
#nullable restore
#line 34 "C:\Users\jason\Documents\WOS Enterprises\HW Assignments\Arcade\Views\Arcade\UserDashboard.cshtml"
          
            if(ViewBag.AllGamesCount != 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\jason\Documents\WOS Enterprises\HW Assignments\Arcade\Views\Arcade\UserDashboard.cshtml"
                 foreach(var game in ViewBag.AllGames)
                {
                        var list = ((IEnumerable<dynamic>)game.Authors);
                        var likes = ((IEnumerable<dynamic>)game.Likes);
                        var count = list.Count();
                        //var count_L = likes.Count();
                        //var likes_count = likes.Count();

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <table id=\"List\">\n                    <tr>\n                        <th>Image</th>\n                        <th>Title</th>\n");
                WriteLiteral("                        <th>Likes</th> \n                        <th>Action</th>\n                    </tr>\n                    <tr>\n                        <td>");
#nullable restore
#line 53 "C:\Users\jason\Documents\WOS Enterprises\HW Assignments\Arcade\Views\Arcade\UserDashboard.cshtml"
                              
                            if(@game.Imagename != null){

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <img class=\"resize\"");
                BeginWriteAttribute("src", " src=\"", 1612, "\"", 1638, 2);
                WriteAttributeValue("", 1618, "/img/", 1618, 5, true);
#nullable restore
#line 55 "C:\Users\jason\Documents\WOS Enterprises\HW Assignments\Arcade\Views\Arcade\UserDashboard.cshtml"
WriteAttributeValue("", 1623, game.Imagename, 1623, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Game Image\">\n");
#nullable restore
#line 56 "C:\Users\jason\Documents\WOS Enterprises\HW Assignments\Arcade\Views\Arcade\UserDashboard.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </td>\n                        <td><a");
                BeginWriteAttribute("href", " href=\"", 1775, "\"", 1829, 4);
                WriteAttributeValue("", 1782, "/viewgame/", 1782, 10, true);
#nullable restore
#line 60 "C:\Users\jason\Documents\WOS Enterprises\HW Assignments\Arcade\Views\Arcade\UserDashboard.cshtml"
WriteAttributeValue("", 1792, game.GameId, 1792, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1804, "/", 1804, 1, true);
#nullable restore
#line 60 "C:\Users\jason\Documents\WOS Enterprises\HW Assignments\Arcade\Views\Arcade\UserDashboard.cshtml"
WriteAttributeValue("", 1805, ViewBag.ThisUser.userId, 1805, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 60 "C:\Users\jason\Documents\WOS Enterprises\HW Assignments\Arcade\Views\Arcade\UserDashboard.cshtml"
                                                                                 Write(game.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\n");
                WriteLiteral("                        <td>");
#nullable restore
#line 62 "C:\Users\jason\Documents\WOS Enterprises\HW Assignments\Arcade\Views\Arcade\UserDashboard.cshtml"
                       Write(count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                        <td>\n");
#nullable restore
#line 64 "C:\Users\jason\Documents\WOS Enterprises\HW Assignments\Arcade\Views\Arcade\UserDashboard.cshtml"
                              
                            var a = ((IEnumerable<dynamic>)game.Authors).Any(r => r.UserId == @ViewBag.ThisUser.userId);

                            if(game.UserId == ViewBag.ThisUser.userId)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44a7553d47bb795d418fb63638268b835bf46b2512321", async() => {
                    WriteLiteral("DELETE");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-gameId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\Users\jason\Documents\WOS Enterprises\HW Assignments\Arcade\Views\Arcade\UserDashboard.cshtml"
                                                           WriteLiteral(game.GameId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gameId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-gameId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gameId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\Users\jason\Documents\WOS Enterprises\HW Assignments\Arcade\Views\Arcade\UserDashboard.cshtml"
                                                                                           WriteLiteral(ViewBag.ThisUser.userId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-status", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["status"] = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                <a");
                BeginWriteAttribute("href", " href=\"", 2457, "\"", 2507, 5);
                WriteAttributeValue("", 2464, "/", 2464, 1, true);
#nullable restore
#line 70 "C:\Users\jason\Documents\WOS Enterprises\HW Assignments\Arcade\Views\Arcade\UserDashboard.cshtml"
WriteAttributeValue("", 2465, game.GameId, 2465, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2477, "/", 2477, 1, true);
#nullable restore
#line 70 "C:\Users\jason\Documents\WOS Enterprises\HW Assignments\Arcade\Views\Arcade\UserDashboard.cshtml"
WriteAttributeValue("", 2478, ViewBag.ThisUser.userId, 2478, 24, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2502, "/edit", 2502, 5, true);
                EndWriteAttribute();
                WriteLiteral(">EDIT</a>\n");
#nullable restore
#line 71 "C:\Users\jason\Documents\WOS Enterprises\HW Assignments\Arcade\Views\Arcade\UserDashboard.cshtml"
                            }
                             else if(a)   

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\jason\Documents\WOS Enterprises\HW Assignments\Arcade\Views\Arcade\UserDashboard.cshtml"
                                                                                                             
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44a7553d47bb795d418fb63638268b835bf46b2517508", async() => {
                    WriteLiteral("Remove Like");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-gameId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "C:\Users\jason\Documents\WOS Enterprises\HW Assignments\Arcade\Views\Arcade\UserDashboard.cshtml"
                                                           WriteLiteral(game.GameId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gameId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-gameId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gameId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "C:\Users\jason\Documents\WOS Enterprises\HW Assignments\Arcade\Views\Arcade\UserDashboard.cshtml"
                                                                                           WriteLiteral(ViewBag.ThisUser.userId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-status", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["status"] = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 75 "C:\Users\jason\Documents\WOS Enterprises\HW Assignments\Arcade\Views\Arcade\UserDashboard.cshtml"
                            }
                            else
                            {                                

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44a7553d47bb795d418fb63638268b835bf46b2521536", async() => {
                    WriteLiteral("Like");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-gameId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Users\jason\Documents\WOS Enterprises\HW Assignments\Arcade\Views\Arcade\UserDashboard.cshtml"
                                                           WriteLiteral(game.GameId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gameId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-gameId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gameId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Users\jason\Documents\WOS Enterprises\HW Assignments\Arcade\Views\Arcade\UserDashboard.cshtml"
                                                                                           WriteLiteral(ViewBag.ThisUser.userId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-status", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["status"] = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 79 "C:\Users\jason\Documents\WOS Enterprises\HW Assignments\Arcade\Views\Arcade\UserDashboard.cshtml"
                            }
                            

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </td>\n                    </tr>\n                    </table>\n");
#nullable restore
#line 84 "C:\Users\jason\Documents\WOS Enterprises\HW Assignments\Arcade\Views\Arcade\UserDashboard.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\jason\Documents\WOS Enterprises\HW Assignments\Arcade\Views\Arcade\UserDashboard.cshtml"
                  
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p>No Games Here.</p>\n");
#nullable restore
#line 89 "C:\Users\jason\Documents\WOS Enterprises\HW Assignments\Arcade\Views\Arcade\UserDashboard.cshtml"
            }
        

#line default
#line hidden
#nullable disable
                WriteLiteral("    \n    </ul>\n</div>\n</div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
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
