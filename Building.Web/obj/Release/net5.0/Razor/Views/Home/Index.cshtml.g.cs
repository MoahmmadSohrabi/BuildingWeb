#pragma checksum "C:\Users\Mohammad\Documents\Visual Stdio 2010\Projects\Asp.NetCore\Building.Web\Building.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cee4c189078a6f6971bf7dd3d670788623078c1e"
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
#line 1 "C:\Users\Mohammad\Documents\Visual Stdio 2010\Projects\Asp.NetCore\Building.Web\Building.Web\Views\_ViewImports.cshtml"
using Building;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cee4c189078a6f6971bf7dd3d670788623078c1e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e27aa01fc834ab08ceef07fc837d10343ae7fc7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Building.DataLayer.Entities.Course.Bulletin>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_BoxPicture", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-mode", new global::Microsoft.AspNetCore.Html.HtmlString("replace"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-update", new global::Microsoft.AspNetCore.Html.HtmlString("#listComment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-success", new global::Microsoft.AspNetCore.Html.HtmlString("Success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/jquery.unobtrusive-ajax.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Mohammad\Documents\Visual Stdio 2010\Projects\Asp.NetCore\Building.Web\Building.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "خانه";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main-banner"" id=""top"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""row"">
                    <div class=""col-lg-6 align-self-center"">
                        <div class=""owl-carousel owl-banner"">
                            <div class=""item header-text"">
                                <h6>به سایت ساختمانی ما خوش آمدید</h6>
                                <h2>سایت <em>ساختمانی</em> بندرعباس <span>همراه با امکانات</span>!!!</h2>
                                <p>این سایت برای راحتی انجام امورات ساختمانی ساکنین آماده شده است</p>
                                <div class=""down-buttons"">
                                    <div class=""main-blue-button-hover"">
                                        <a href=""#contact"">پیام به ما</a>
                                    </div>
                                    <div class=""call-button"">
                                        <a href=""#""><i class=""fa fa-phone"">");
            WriteLiteral(@"</i> 076-33753886</a>
                                    </div>
                                </div>
                            </div>
                            <div class=""item header-text"">
                                <h6>پرداخت شارژ</h6>
                                <h2>شارژ ساختمانی <em>را به راحتی</em> با استفده از ساماه زرین پال <span>به صورت انلاین پرداخت کنید</span></h2>
                                <p>با شارژ کردن کیف پول انلاین خود می توانید به راحتی شارژ و اجاره ساختمانی و ... را پرداخت کنید</p>
                                <div class=""down-buttons"">
                                    <div class=""main-blue-button-hover"">
                                        <a href=""#services"">خدمات ما</a>
                                    </div>
                                    <div class=""call-button"">
                                        <a href=""#""><i class=""fa fa-phone""></i> 09928401625</a>
                                    </div>
                                ");
            WriteLiteral(@"</div>
                            </div>
                            <div class=""item header-text"">
                                <h6>ویدیو های آموزشی</h6>
                                <h2>ویدیو های آموزشی <em>،آموزش های کاربردی</em> برای شما <span>و اعضای خانواده</span></h2>
                                <p>لطفا <a rel=""nofollow"" href=""https://www.paypal.me/templatemo"" target=""_blank"">حمایت ما</a> آموزش های ما را دنبال کنید و نظرتون را برای ما اشتراک بگذارید.با سپساس فراوان</p>
                                <div class=""down-buttons"">
                                    <div class=""main-blue-button-hover"">
                                        <a href=""#video"">تماشای ویدیو</a>
                                    </div>
                                    <div class=""call-button"">
                                        <a href=""#""><i class=""fa fa-phone""></i>09928401625</a>
                                    </div>
                                </div>
                            </");
            WriteLiteral(@"div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div id=""services"" class=""our-services section"">
    <div class=""services-right-dec"">
        <img src=""/assets/images/services-right-dec.png""");
            BeginWriteAttribute("alt", " alt=\"", 3471, "\"", 3477, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n    <div class=\"container\">\r\n        <div class=\"services-left-dec\">\r\n            <img src=\"/assets/images/services-left-dec.png\"");
            BeginWriteAttribute("alt", " alt=\"", 3622, "\"", 3628, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        </div>
        <div class=""row"">
            <div class=""col-lg-6 offset-lg-3"">
                <div class=""section-heading"">
                    <h2>ما <em>بهترین</em> سایت ساختمانی را برای راحتی  شما <span>آماده ساخته ایم</span></h2>
                    <span>همراه با امکانات</span>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""owl-carousel owl-services listShowBulletin"" id=""listShowBulletin"">
");
#nullable restore
#line 80 "C:\Users\Mohammad\Documents\Visual Stdio 2010\Projects\Asp.NetCore\Building.Web\Building.Web\Views\Home\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cee4c189078a6f6971bf7dd3d670788623078c1e11610", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 82 "C:\Users\Mohammad\Documents\Visual Stdio 2010\Projects\Asp.NetCore\Building.Web\Building.Web\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 83 "C:\Users\Mohammad\Documents\Visual Stdio 2010\Projects\Asp.NetCore\Building.Web\Building.Web\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    
                </div>
            </div>
        </div>
    </div>
</div>

<div id=""about"" class=""about-us section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6 align-self-center"">
                <div class=""left-image"">
                    <img src=""/assets/images/about-left-image.png"" alt=""Two Girls working together"">
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class=""section-heading"">
                    <h2>اطلاعات کلی <em>در مورد ساختمان بندرعباس</em> &amp; <span>با در نظر گرفتن</span> تمام موارد امکانات و غیره</h2>
                    <p>ساختمان 20 طبقه بندرعباس واقع در خیابان دانشگاه بندرعباس  چهارراه اتوبوسرانی </p>
                    <div class=""row"">
                        <div class=""col-lg-4"">
                            <div class=""fact-item"">
                                <div class=""count-area-content"">
                                    <div class=");
            WriteLiteral("\"icon\">\r\n                                        <img src=\"/assets/images/service-icon-01.png\"");
            BeginWriteAttribute("alt", " alt=\"", 5436, "\"", 5442, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""count-digit"">40</div>
                                    <div class=""count-title"">تعداد واحد</div>
                                    <p>هر واحد به متراژ130 متر</p>
                                </div>
                            </div>
                        </div>
                        <div class=""col-lg-4"">
                            <div class=""fact-item"">
                                <div class=""count-area-content"">
                                    <div class=""icon"">
                                        <img src=""/assets/images/service-icon-02.png""");
            BeginWriteAttribute("alt", " alt=\"", 6124, "\"", 6130, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""count-digit"">100</div>
                                    <div class=""count-title"">تعداد ساکنین</div>
                                    <p>شامل حدود 100 ساکن </p>
                                </div>
                            </div>
                        </div>
                        <div class=""col-lg-4"">
                            <div class=""fact-item"">
                                <div class=""count-area-content"">
                                    <div class=""icon"">
                                        <img src=""/assets/images/service-icon-03.png""");
            BeginWriteAttribute("alt", " alt=\"", 6811, "\"", 6817, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""count-digit"">1396</div>
                                    <div class=""count-title"">سال ساخت</div>
                                    <p>این ساختمان در سال 1396 زیر نظر مجرب ترین ساختمان سازان ساخته شده</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div id=""portfolio"" class=""our-portfolio section"">
    <div class=""portfolio-left-dec"">
        <img src=""/assets/images/portfolio-left-dec.png""");
            BeginWriteAttribute("alt", " alt=\"", 7489, "\"", 7495, 0);
            EndWriteAttribute();
            WriteLiteral(@">
    </div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6 offset-lg-3"">
                <div class=""section-heading"">
                    <h2>گالری <em>تصاویر</em> &amp; مکان های محبوب  <span>اطراف مجتمع</span></h2>
                    <span>شامل:رستوران،کافی شاپ،سوپرمارکت و غیره</span>
                </div>
            </div>
        </div>
    </div>
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""owl-carousel owl-portfolio"">
                    <div class=""item"">
                        <div class=""thumb"">
                            <img src=""/assets/images/portfolio-01.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8218, "\"", 8224, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""hover-effect"">
                                <div class=""inner-content"">
                                    <a rel=""sponsored"" href=""https://templatemo.com/tm-564-plot-listing"" target=""_parent""><h4>پارک دانشگاه</h4></a>
                                    <span>واقع در کوچه دانشگاه 11</span>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""thumb"">
                            <img src=""/assets/images/portfolio-02.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8859, "\"", 8865, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""hover-effect"">
                                <div class=""inner-content"">
                                    <a href=""#""><h4>پارک کودکان</h4></a>
                                    <span>واقع در حیاط مجتمع</span>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""thumb"">
                            <img src=""/assets/images/portfolio-03.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 9420, "\"", 9426, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""hover-effect"">
                                <div class=""inner-content"">
                                    <a rel=""sponsored"" href=""https://templatemo.com/tm-562-space-dynamic"" target=""_parent""><h4>سوپرمارکت سعید</h4></a>
                                    <span>ابتدای کوچه دانشگاه 10</span>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""thumb"">
                            <img src=""/assets/images/portfolio-04.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 10063, "\"", 10069, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""hover-effect"">
                                <div class=""inner-content"">
                                    <a href=""#""><h4>آرایشگاه هیراد</h4></a>
                                    <span>انتهای کوچه دانشگاه 10 جنب فست فودی</span>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""thumb"">
                            <img src=""/assets/images/portfolio-01.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 10644, "\"", 10650, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""hover-effect"">
                                <div class=""inner-content"">
                                    <a href=""#""><h4>پارک دانشگاه</h4></a>
                                    <span>واقع در کوچه دانشگاه 11</span>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""thumb"">
                            <img src=""/assets/images/portfolio-02.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 11211, "\"", 11217, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""hover-effect"">
                                <div class=""inner-content"">
                                    <a href=""#""><h4>پارک کودکان</h4></a>
                                    <span>واقع در حیاط مجتمع</span>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""thumb"">
                            <img src=""/assets/images/portfolio-03.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 11772, "\"", 11778, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""hover-effect"">
                                <div class=""inner-content"">
                                    <a href=""#""><h4>سوپرمارکت سعید</h4></a>
                                    <span>ابتدای کوچه دانشگاه 10</span>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""thumb"">
                            <img src=""/assets/images/portfolio-04.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 12340, "\"", 12346, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""hover-effect"">
                                <div class=""inner-content"">
                                    <a href=""#""><h4>آرایشگاه هیراد</h4></a>
                                    <span>انتهای کوچه دانشگاه 10 جنب فست فودی</span>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>
</div>

<div id=""pricing"" class=""pricing-tables"">
    <div class=""tables-left-dec"">
        <img src=""/assets/images/tables-left-dec.png""");
            BeginWriteAttribute("alt", " alt=\"", 12981, "\"", 12987, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n    <div class=\"tables-right-dec\">\r\n        <img src=\"/assets/images/tables-right-dec.png\"");
            BeginWriteAttribute("alt", " alt=\"", 13093, "\"", 13099, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            WriteLiteral(@"
<div id=""contact"" class=""contact-us section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-7"">
                <div class=""section-heading"">
                    <h2>ثبت نظرات شما <em>برای سایت</em> مجتمع ساختمانی <span>برای بهبود کارایی سایت</span></h2>
                    <div id=""map"">
                        <iframe src=""https://www.google.com/maps/embed?pb=!1m14!1m12!1m3!1d463.20380195269956!2d56.34370389801358!3d27.202730729177244!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!5e0!3m2!1sen!2s!4v1641112149291!5m2!1sen!2s"" width=""100%"" height=""360"" frameborder=""0"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 20747, "\"", 20765, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\"></iframe>\r\n");
            WriteLiteral(@"                    </div>
                    <div class=""info"">
                        <span><i class=""fa fa-phone""></i> <a href=""#"">09928401628<br>076-33336952</a></span>
                        <span><i class=""fa fa-envelope""></i> <a href=""#"">محمدحسین سهرابی<br>M.sohrabi1378.ms@gmail.com</a></span>
                    </div>
                </div>
            </div>
            <div class=""col-lg-5 align-self-center"">

");
#nullable restore
#line 398 "C:\Users\Mohammad\Documents\Visual Stdio 2010\Projects\Asp.NetCore\Building.Web\Building.Web\Views\Home\Index.cshtml"
                 if (User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cee4c189078a6f6971bf7dd3d670788623078c1e26080", async() => {
                WriteLiteral(@"

                        <div class=""row"">
                            <div class=""col-md-12 col-sm-12 col-xs-12"">
                                <div class=""form-group"">
                                    <textarea class=""form-control"" id=""comment_CommentText"" name=""comment.CommentText"" placeholder=""متن نظر""></textarea>
                                </div>

                            </div>
                            <div class=""col-xs-12"">
                                <button type=""submit"" class=""btn btn-success""> ثبت دیدگاه </button>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 419 "C:\Users\Mohammad\Documents\Visual Stdio 2010\Projects\Asp.NetCore\Building.Web\Building.Web\Views\Home\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-danger\">\r\n                        جهت درج نظر باید وارد سایت شوید\r\n                    </div>\r\n");
#nullable restore
#line 425 "C:\Users\Mohammad\Documents\Visual Stdio 2010\Projects\Asp.NetCore\Building.Web\Building.Web\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <!-- row -->
                <div class=""comment-row listComment"" dir=""rtl"" id=""listComment"">

                </div>
                <!-- /row -->
            </div>
        </div>
    </div>
    <div class=""contact-dec"">
        <img src=""/assets/images/contact-dec.png""");
            BeginWriteAttribute("alt", " alt=\"", 23066, "\"", 23072, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n    <div class=\"contact-left-dec\">\r\n        <img src=\"/assets/images/contact-left-dec.png\"");
            BeginWriteAttribute("alt", " alt=\"", 23178, "\"", 23184, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cee4c189078a6f6971bf7dd3d670788623078c1e30228", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    function Success() {
        $(""#comment_CommentText"").val("""");
    }

    $(function () {
        $(""#listComment"").load(""/Home/ShowComment/"");
    });
    $(function () {
        $(""#listShowBulletin"").load(""/Home/ShowBulletin/"");
    });


</script>


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Building.DataLayer.Entities.Course.Bulletin>> Html { get; private set; }
    }
}
#pragma warning restore 1591
