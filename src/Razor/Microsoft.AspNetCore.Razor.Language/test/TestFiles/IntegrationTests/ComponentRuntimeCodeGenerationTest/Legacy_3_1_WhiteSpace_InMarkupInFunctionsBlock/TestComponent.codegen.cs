// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
using Microsoft.AspNetCore.Components.Rendering;

#line default
#line hidden
#nullable disable
    public partial class TestComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
       
    void MyMethod(RenderTreeBuilder __builder)
    {

#line default
#line hidden
#nullable disable
        __builder.AddContent(0, "        ");
        __builder.OpenElement(1, "ul");
        __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 6 "x:\dir\subdir\Test\TestComponent.cshtml"
             for (var i = 0; i < 100; i++)
            {

#line default
#line hidden
#nullable disable
        __builder.AddContent(3, "                ");
        __builder.OpenElement(4, "li");
        __builder.AddMarkupContent(5, "\r\n                    ");
#nullable restore
#line (9,22)-(9,23) 24 "x:\dir\subdir\Test\TestComponent.cshtml"
__builder.AddContent(6, i);

#line default
#line hidden
#nullable disable
        __builder.AddMarkupContent(7, "\r\n                ");
        __builder.CloseElement();
        __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 11 "x:\dir\subdir\Test\TestComponent.cshtml"
            }

#line default
#line hidden
#nullable disable
        __builder.AddContent(9, "        ");
        __builder.CloseElement();
        __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 13 "x:\dir\subdir\Test\TestComponent.cshtml"
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
