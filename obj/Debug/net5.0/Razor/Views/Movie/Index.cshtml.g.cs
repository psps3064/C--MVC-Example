#pragma checksum "C:\Users\Somon\Desktop\MvcMovie\Views\Movie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6c1fab10ff551c4881452630cfbd6feec32d551"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Index), @"mvc.1.0.view", @"/Views/Movie/Index.cshtml")]
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
#line 1 "C:\Users\Somon\Desktop\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Somon\Desktop\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6c1fab10ff551c4881452630cfbd6feec32d551", @"/Views/Movie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"686ad2e38abb871af45be971520cc6c3156da389", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MvcMovie.Models.MovieModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Somon\Desktop\MvcMovie\Views\Movie\Index.cshtml"
  
    ViewData["Title"] = "Movie index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 5 "C:\Users\Somon\Desktop\MvcMovie\Views\Movie\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 6 "C:\Users\Somon\Desktop\MvcMovie\Views\Movie\Index.cshtml"
Write(Html.ActionLink("+ เพิ่ม", "Create", "Movie", null, new { @class = "btn btn-primary", @style = "margin-bottom: 20px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br>
<table class=""table"">
    <tr>
        <th>รหัสภาพยนต์</th>
        <th>ชื่อภาพยนต์</th>
        <th>รูป</th>
        <th>เข้าฉายเมื่อ</th>
        <th>หมวดหมู่</th>
        <th>ความยาว (นาที)</th>
        <th>แก้ไข</th>
        <th>ลบ</th>
    </tr>
");
#nullable restore
#line 19 "C:\Users\Somon\Desktop\MvcMovie\Views\Movie\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class=\"item-id\">");
#nullable restore
#line 22 "C:\Users\Somon\Desktop\MvcMovie\Views\Movie\Index.cshtml"
                           Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\Somon\Desktop\MvcMovie\Views\Movie\Index.cshtml"
           Write(item.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 689, "\"", 709, 1);
#nullable restore
#line 25 "C:\Users\Somon\Desktop\MvcMovie\Views\Movie\Index.cshtml"
WriteAttributeValue("", 695, item.coverImg, 695, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"80px\" />\r\n            </td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\Somon\Desktop\MvcMovie\Views\Movie\Index.cshtml"
           Write(item.releaseDate.Value.ToString("dd MMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\Somon\Desktop\MvcMovie\Views\Movie\Index.cshtml"
           Write(item.genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\Somon\Desktop\MvcMovie\Views\Movie\Index.cshtml"
           Write(item.duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\Somon\Desktop\MvcMovie\Views\Movie\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.id }, new { id = item.id, @class = "btn btn-primary", @style = "margin-bottom: 20px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <input type=\"button\" value=\"Delete\" class=\"btn btn-danger\" />\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 37 "C:\Users\Somon\Desktop\MvcMovie\Views\Movie\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 39 "C:\Users\Somon\Desktop\MvcMovie\Views\Movie\Index.cshtml"
 using (Html.BeginForm("delete", "movie", FormMethod.Post, new { name = "frmMovie", id = "frmMovie" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"hidden\" name=\"id\" />\r\n");
#nullable restore
#line 42 "C:\Users\Somon\Desktop\MvcMovie\Views\Movie\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $("".btn-danger"").click(function () {
            if(!confirm('Do you really want to delete this movie?')) {
                return false;
            }
            var id = $(this).closest(""tr"").find("".item-id"").text();
            document.frmMovie.id.value = id;
            document.getElementById(""frmMovie"").submit();
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MvcMovie.Models.MovieModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591