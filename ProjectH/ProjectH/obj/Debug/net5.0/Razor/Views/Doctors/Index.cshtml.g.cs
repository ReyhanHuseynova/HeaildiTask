#pragma checksum "C:\Users\ACER\OneDrive\İş masası\ProjectH\ProjectH\Views\Doctors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ebec7534b8d4a4fb5158d60094b5e21561463e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctors_Index), @"mvc.1.0.view", @"/Views/Doctors/Index.cshtml")]
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
#line 1 "C:\Users\ACER\OneDrive\İş masası\ProjectH\ProjectH\Views\_ViewImports.cshtml"
using ProjectH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ACER\OneDrive\İş masası\ProjectH\ProjectH\Views\_ViewImports.cshtml"
using ProjectH.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ebec7534b8d4a4fb5158d60094b5e21561463e2", @"/Views/Doctors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5833a9675793b1b781100e864154fd2ea05c54a5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Doctors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/doctors-11.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/doctors-12.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/doctors-2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/doctors-3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/doctors-4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!--********************* BREADCRUMB SEC START ********************-->
<section class=""bg-color"">
    <div class=""container"">
        <div class=""row d-flex flex-column justify-content-center align-items-center"">
            <div class=""col-lg-8 info d-flex flex-column justify-content-center align-items-center"">
                <h1>Doctor List</h1>
                <ul class=""breadcrumb"">
                    <li>
                        <a href=""index.html""><i class=""fas fa-home""></i> Home</a>
                    </li>
                    <li><a href=""#"">DOCTORS</a></li>
                    <li class=""active"">Doctor</li>
                </ul>
            </div>
        </div>
    </div>
</section>
<!--********************* BREADCRUMB SEC END *******************-->
<!-- ********************************************************************** -->
<!--**************** DOCTORS-SECTION-START ********************************-->
<section id=""doctors"" class=""sec-pad-y"">
    <div class=""container"">
");
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""doctors d-flex flex-column align-items-center justify-content-center"">
                    <h5>DOCTORS</h5>
                    <h3>Meet Our Experts</h3>
                    <p class=""text-center py-4"">
                        While mirth large of on front. Ye he greater related adapted
                        proceed entered an. Through it examine express promise no.Past
                        add size game cold girl off how old
                    </p>
                </div>
            </div>
        </div>
        <div class=""row"">
            <!--********* BUTT0NS-START **************-->
            <div class=""col-lg-4 mb-3"">
                <div class=""nav flex-column nav-pills""
                     id=""v-pills-tab""
                     role=""tablist""
                     aria-orientation=""vertical"">
                    <a class=""nav-link active""
                       id=""v-pills-home-tab""
");
            WriteLiteral(@"                       data-toggle=""pill""
                       href=""#v-pills-home""
                       role=""tab""
                       aria-controls=""v-pills-home""
                       aria-selected=""true""><i class=""fas fa-user-nurse fa-2x mr-4""></i>Home</a>
                    <a class=""nav-link""
                       id=""v-pills-profile-tab""
                       data-toggle=""pill""
                       href=""#v-pills-profile""
                       role=""tab""
                       aria-controls=""v-pills-profile""
                       aria-selected=""false""><i class=""fas fa-user-md fa-2x mr-4""></i>Profile</a>
                    <a class=""nav-link""
                       id=""v-pills-messages-tab""
                       data-toggle=""pill""
                       href=""#v-pills-messages""
                       role=""tab""
                       aria-controls=""v-pills-messages""
                       aria-selected=""false""><i class=""fas fa-user fa-2x mr-4""></i>Settings</a>
       ");
            WriteLiteral(@"             <a class=""nav-link""
                       id=""v-pills-settings-tab""
                       data-toggle=""pill""
                       href=""#v-pills-settings""
                       role=""tab""
                       aria-controls=""v-pills-settings""
                       aria-selected=""false""><i class=""fas fa-user-cog fa-2x""></i>Messages</a>
                </div>
            </div>
            <!--********* BUTTONS-END *************-->
            <!--********* CONTENT-START *************-->
            <div class=""col-lg-8"">
                <div class=""tab-content"" id=""v-pills-tabContent"">
                    <!-- ********CONTENT-COL-START ***************-->
                    <div class=""tab-pane fade show active""
                         id=""v-pills-home""
                         role=""tabpanel""
                         aria-labelledby=""v-pills-home-tab"">
                        <div class=""row"">
                            <div class=""col-lg-6"">
                         ");
            WriteLiteral("       ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2ebec7534b8d4a4fb5158d60094b5e21561463e29962", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <div class=""col-lg-6"">
                                <div class=""info"">
                                    <h5 class=""mt-2 mb-2"">Dr. Jonathom Doe</h5>
                                    <span>MBBS, BMBS, MBChB, MBBCh</span>
                                    <p class=""my-3 mb-5"">
                                        Delightful unreserved impossible few estimating men
                                        favourable see entreaties. She propriety immediate was
                                        improving. He or entrance humoured likewise moderate.
                                    </p>
                                    <a class=""my-4""");
            BeginWriteAttribute("href", " href=\"", 4896, "\"", 4903, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-angle-right\"></i>Read more</a>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"col-lg-6\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2ebec7534b8d4a4fb5158d60094b5e21561463e212261", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <div class=""col-lg-6"">
                                <div class=""info"">
                                    <h5 class=""mt-2 mb-2"">Prof. Hones Park</h5>
                                    <span>MBBS, BMBS, MBChB, MBBCh</span>
                                    <p class=""my-3 mb-5"">
                                        Delightful unreserved impossible few estimating men
                                        favourable see entreaties. She propriety immediate was
                                        improving. He or entrance humoured likewise moderate.
                                    </p>
                                    <a class=""my-4""");
            BeginWriteAttribute("href", " href=\"", 5907, "\"", 5914, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fas fa-angle-right""></i>Read more</a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!--********** CONTENT-COL-END ************-->
                    <!--********** CONTENT-COL-START ************-->
                    <div class=""tab-pane fade""
                         id=""v-pills-profile""
                         role=""tabpanel""
                         aria-labelledby=""v-pills-profile-tab"">
                        <div class=""row"">
                            <div class=""col-lg-6"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2ebec7534b8d4a4fb5158d60094b5e21561463e215007", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <div class=""col-lg-6"">
                                <div class=""info"">
                                    <h5 class=""mt-2 mb-2"">Professor. Sakaoat Amir</h5>
                                    <span>MBBS, BMBS, MBChB, MBBCh</span>
                                    <p class=""my-3 mb-5"">
                                        Delightful unreserved impossible few estimating men
                                        favourable see entreaties. She propriety immediate was
                                        improving. He or entrance humoured likewise moderate.
                                    </p>
                                    <a class=""my-4""");
            BeginWriteAttribute("href", " href=\"", 7367, "\"", 7374, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fas fa-angle-right""></i>Read more</a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!--************** CONTENT-COL-END *************-->
                    <!--************* CONTENT-COL-START ************-->
                    <div class=""tab-pane fade""
                         id=""v-pills-messages""
                         role=""tabpanel""
                         aria-labelledby=""v-pills-messages-tab"">
                        <div class=""row"">
                            <div class=""col-lg-6"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2ebec7534b8d4a4fb5158d60094b5e21561463e217770", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <div class=""col-lg-6"">
                                <div class=""info"">
                                    <h5 class=""mt-2 mb-2"">Dr. Andro kuria</h5>
                                    <span>MBBS, BMBS, MBChB, MBBCh</span>
                                    <p class=""my-3 mb-5"">
                                        Delightful unreserved impossible few estimating men
                                        favourable see entreaties. She propriety immediate was
                                        improving. He or entrance humoured likewise moderate.
                                    </p>
                                    <a class=""my-4""");
            BeginWriteAttribute("href", " href=\"", 8829, "\"", 8836, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fas fa-angle-right""></i>Read more</a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!--************ CONTENT-COL-END *********************-->
                    <!--************ CONTENT-COL-START *******************-->
                    <div class=""tab-pane fade""
                         id=""v-pills-settings""
                         role=""tabpanel""
                         aria-labelledby=""v-pills-settings-tab"">
                        <div class=""row"">
                            <div class=""col-lg-6"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2ebec7534b8d4a4fb5158d60094b5e21561463e220537", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <div class=""col-lg-6"">
                                <div class=""info"">
                                    <h5 class=""mt-2 mb-2"">Professor. Matori Pulas</h5>
                                    <span>MBBS, BMBS, MBChB, MBBCh</span>
                                    <p class=""my-3 mb-5"">
                                        Delightful unreserved impossible few estimating men
                                        favourable see entreaties. She propriety immediate was
                                        improving. He or entrance humoured likewise moderate.
                                    </p>
                                    <a class=""my-4""");
            BeginWriteAttribute("href", " href=\"", 10311, "\"", 10318, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fas fa-angle-right""></i>Read more</a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!--*************** CONTENT-COL-END ***************-->
                </div>
            </div>
            <!--******************* CONTENT-END ******************-->
        </div>
    </div>
</section>
<!--**************** DOCTORS-SECTION-END **********************************-->

");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
