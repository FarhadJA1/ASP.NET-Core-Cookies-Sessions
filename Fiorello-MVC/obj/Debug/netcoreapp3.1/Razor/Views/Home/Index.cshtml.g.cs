#pragma checksum "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57d47ed95a18bc64a4d87bda9efeca569999dd81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\_ViewImports.cshtml"
using Fiorello_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\_ViewImports.cshtml"
using Fiorello_MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\_ViewImports.cshtml"
using Fiorello_MVC.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57d47ed95a18bc64a4d87bda9efeca569999dd81", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59a7c8b1fedbd3c6221543f9dc00f6e18b23fb49", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddBasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<main>\r\n\r\n    <!-- SLIDER START -->\r\n\r\n    <section id=\"slider\">\r\n        <div class=\"owl-carousel slider\">\r\n");
#nullable restore
#line 8 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
             foreach (var item in Model.Sliders)
	         {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div> <img");
            BeginWriteAttribute("src", " src=\"", 213, "\"", 234, 2);
            WriteAttributeValue("", 219, "img/", 219, 4, true);
#nullable restore
#line 10 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 223, item.Image, 223, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 235, "\"", 241, 0);
            EndWriteAttribute();
            WriteLiteral("> </div>\r\n");
#nullable restore
#line 11 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
	         }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n            \r\n        </div>\r\n        <div class=\"container context pl-lg-5 ml-lg-3\">\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-5\">\r\n                    <div class=\"text\">\r\n                        ");
#nullable restore
#line 19 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
                   Write(Html.Raw(Model.Detail.Header));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <p class=\"text-black-50 d-none d-sm-block\">\r\n                            ");
#nullable restore
#line 21 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
                       Write(Model.Detail.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                    <div class=\"img\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 782, "\"", 811, 2);
            WriteAttributeValue("", 788, "img/", 788, 4, true);
#nullable restore
#line 25 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 792, Model.Detail.Image, 792, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 812, "\"", 818, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- SLIDER END -->
    <!-- PRODUCTS START -->

    <section id=""products"">
        <div class=""container"">
            <div class=""row pt-5"">
                <div class=""col-12 d-flex justify-content-between"">
                    <ul class=""category-mobile d-md-none list-unstyled"">
                        <li>
                            <a");
            BeginWriteAttribute("href", " href=\"", 1285, "\"", 1292, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"categories mr-2\">Categories</a>\r\n                            <i class=\"fas fa-caret-down\"></i>\r\n                            <ul class=\"category list-unstyled\" style=\"display: none;\">\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1523, "\"", 1530, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n");
#nullable restore
#line 45 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
                                 foreach (var item in Model.Categories)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1710, "\"", 1717, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 47 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
                                                       Write(item.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 47 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
                                                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 48 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </ul>\r\n                        </li>\r\n                    </ul>\r\n                    <ul class=\"category d-none d-md-flex list-unstyled\">\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2005, "\"", 2012, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n");
#nullable restore
#line 55 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
                         foreach (var item in Model.Categories)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2168, "\"", 2175, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 57 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
                                               Write(item.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 57 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
                                                                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 58 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </ul>\r\n                    <ul class=\"list-unstyled\">\r\n                        <li>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2393, "\"", 2400, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\">Filter</a>\r\n                            <i class=\"fas fa-caret-down\"></i>\r\n                        </li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 70 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
                 foreach (var product in Model.Products)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-sm-6 col-md-4 col-lg-3 mt-3\">\r\n                        <div class=\"product-item text-center\" data-id=\"");
#nullable restore
#line 73 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
                                                                  Write(product.Category.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                            <div class=\"img\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2955, "\"", 2962, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 3006, "\"", 3053, 2);
            WriteAttributeValue("", 3012, "img/", 3012, 4, true);
#nullable restore
#line 76 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 3016, product.Images.FirstOrDefault().Name, 3016, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 3072, "\"", 3078, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                </a>\r\n                            </div>\r\n                            <div class=\"title mt-3\">\r\n                                <h6>");
#nullable restore
#line 80 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
                               Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            </div>\r\n                            <div class=\"price\">\r\n                                <span class=\"text-black-50\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57d47ed95a18bc64a4d87bda9efeca569999dd8114020", async() => {
                WriteLiteral("Add to cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
                                                                                      WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                                </span>\r\n                                <span class=\"text-black-50\">$");
#nullable restore
#line 86 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
                                                        Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 90 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            </div>
        </div>
    </section>

    <!-- PRODUCTS END -->
    <!-- ABOUT START -->

    <section id=""about"">
        <div class=""container py-5"">
            <div class=""row py-5"">
                <div class=""col-lg-6"">
                    <div class=""img"">
                        <img src=""img/h3-video-img.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 4146, "\"", 4152, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""player position-absolute rounded-circle d-flex align-items-center justify-content-center"">
                            <i class=""fas fa-play fa-lg""></i>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-6"">
                    <div class=""about-text mt-5 mt-lg-0 px-lg-5"">
                        <h1>Suprise Your <span>Valentine!</span> Let us arrange a smile.</h1>
                        <p class=""py-3"">
                            Where flowers are our inspiration to create lasting memories. Whatever the
                            occasion...
                        </p>
                        <ul class=""list-unstyled"">
                            <li class=""mt-3"">
                                <img src=""img/h1-custom-icon.png"" class=""mr-2""");
            BeginWriteAttribute("alt", " alt=\"", 5027, "\"", 5033, 0);
            EndWriteAttribute();
            WriteLiteral("> Hand picked just\r\n                                for you.\r\n                            </li>\r\n                            <li class=\"mt-3\">\r\n                                <img src=\"img/h1-custom-icon.png\" class=\"mr-2\"");
            BeginWriteAttribute("alt", " alt=\"", 5256, "\"", 5262, 0);
            EndWriteAttribute();
            WriteLiteral("> Unique flower\r\n                                arrangements\r\n                            </li>\r\n                            <li class=\"mt-3\">\r\n                                <img src=\"img/h1-custom-icon.png\" class=\"mr-2\"");
            BeginWriteAttribute("alt", " alt=\"", 5486, "\"", 5492, 0);
            EndWriteAttribute();
            WriteLiteral(@"> Best way to say
                                you care.
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- ABOUT END -->
    <!-- EXPERTS START -->

    <section id=""experts"">
        <div class=""container"">
            <div class=""row py-5"">
                <div class=""offset-lg-3 col-lg-6"">
                    <div class=""section-title"">
                        <h1>");
#nullable restore
#line 146 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
                       Write(Model.ExpertsText.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <p class=\"text-black-50\">\r\n                            ");
#nullable restore
#line 148 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
                       Write(Model.ExpertsText.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row pb-5\">\r\n");
#nullable restore
#line 154 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
                 foreach (var expert in Model.Experts)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-6 col-lg-3\">\r\n                        <div class=\"item text-center\">\r\n                            <div class=\"img\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 6555, "\"", 6578, 2);
            WriteAttributeValue("", 6561, "img/", 6561, 4, true);
#nullable restore
#line 159 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 6565, expert.Image, 6565, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid rounded-circle\"");
            BeginWriteAttribute("alt", " alt=\"", 6612, "\"", 6618, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                            <div class=\"text mt-3\">\r\n                                <h6>");
#nullable restore
#line 162 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
                               Write(expert.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <p class=\"text-black-50\">");
#nullable restore
#line 163 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
                                                    Write(expert.Profession);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 167 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                <div class=""col-lg-3""></div>
                <div class=""col-lg-3""></div>
                <div class=""col-lg-3""></div>
            </div>
        </div>
    </section>

    <!-- EXPERTS END -->
    <!-- SUBSCRIBE START -->

    <section id=""subscribe"">
        <div class=""container py-5"">
            <div class=""row py-5"">
                <div class=""col-12"">
                    <div class=""content text-center py-5"">
                        <h3>Join The Colorful Bunch!</h3>
                        <div class=""form-group d-flex justify-content-center flex-wrap mt-5"">
                            <input type=""email"" placeholder=""Email Address"" class=""form-control-lg rounded-0"">
                            <button class=""btn btn-danger btn-lg rounded-0 px-5 mt-3 mt-sm-0"">Subscribe</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- SUBSCRIBE END -->
    <!-- BLOG START --");
            WriteLiteral(">\r\n\r\n    <section id=\"blog\">\r\n        <div class=\"container\">\r\n            <div class=\"row py-5\">\r\n                <div class=\"offset-lg-3 col-lg-6\">\r\n                    <div class=\"section-title\">\r\n                        <h1>");
#nullable restore
#line 204 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
                       Write(Model.BlogHeader.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <p class=\"text-black-50\">\r\n                           ");
#nullable restore
#line 206 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
                      Write(Model.BlogHeader.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row pb-5\">\r\n");
#nullable restore
#line 212 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
                 foreach (var blog in Model.Blogs)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-6 col-lg-4\">\r\n                        <div class=\"item\">\r\n                            <div class=\"img position-relative\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 8761, "\"", 8782, 2);
            WriteAttributeValue("", 8767, "img/", 8767, 4, true);
#nullable restore
#line 217 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 8771, blog.Image, 8771, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 8801, "\"", 8807, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <div class=\"date rounded bg-light position-absolute py-1 px-2\">\r\n                                    <span>");
#nullable restore
#line 219 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
                                     Write(blog.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"text mt-3 text-center px-5\">\r\n                                <h5>");
#nullable restore
#line 223 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
                               Write(blog.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <p class=\"text-black-50\">\r\n                                    ");
#nullable restore
#line 225 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
                               Write(blog.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 230 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            </div>
        </div>
    </section>

    <!-- BLOG END -->
    <!-- SAY START -->

    <section id=""say"">
        <div class=""container"">
            <div class=""row py-5 justify-content-center"">
                <div class=""col-md-8 col-xl-6"">
                    <div class=""owl-carousel say"">
");
#nullable restore
#line 245 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
                         foreach (var testimonial in Model.Testimonials)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div>\r\n                            <div class=\"item text-center\">\r\n                                <div class=\"img d-flex justify-content-center\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 10045, "\"", 10073, 2);
            WriteAttributeValue("", 10051, "img/", 10051, 4, true);
#nullable restore
#line 250 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 10055, testimonial.Image, 10055, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 10074, "\"", 10080, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                </div>\r\n                                <div class=\"text text-muted pt-3 pb-5\">\r\n                                    <i>\r\n                                        ");
#nullable restore
#line 254 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
                                   Write(testimonial.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </i>\r\n                                </div>\r\n                                <div class=\"author\">\r\n                                    <h6>");
#nullable restore
#line 258 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
                                   Write(testimonial.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                    <p class=\"text-black-50\">");
#nullable restore
#line 259 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
                                                        Write(testimonial.Profession);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 263 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- SAY END -->
    <!-- INSTAGRAM START -->

    <section id=""instagram"">
        <div class=""owl-carousel instagram"">
");
#nullable restore
#line 276 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
             foreach (var instagram in Model.Instagrams)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div><img");
            BeginWriteAttribute("src", " src=\"", 11047, "\"", 11073, 2);
            WriteAttributeValue("", 11053, "img/", 11053, 4, true);
#nullable restore
#line 278 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 11057, instagram.Image, 11057, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 11092, "\"", 11098, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n");
#nullable restore
#line 279 "C:\Users\ASUS\Desktop\ASPI.NET CORE Examples\Basket - SessionStorage,Cookies\Fiorello-MVC\Views\Home\Index.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n            \r\n        </div>\r\n        <div class=\"hastag bg-light text-muted py-2 px-3\">\r\n            #FIORELLO\r\n        </div>\r\n    </section>\r\n\r\n    <!-- INSTAGRAM END -->\r\n\r\n</main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
