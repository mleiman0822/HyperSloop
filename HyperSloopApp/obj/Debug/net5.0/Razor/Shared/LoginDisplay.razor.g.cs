#pragma checksum "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e53c5d099c408e8b911fe087df890dd3de54b46"
// <auto-generated/>
#pragma warning disable 1591
namespace HyperSloopApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\_Imports.razor"
using HyperSloopApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\_Imports.razor"
using HyperSloopApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\_Imports.razor"
using Blazorise.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\_Imports.razor"
using HyperSloopApp.Services;

#line default
#line hidden
#nullable disable
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        Hello, ");
                __builder2.AddContent(3, 
#nullable restore
#line 3 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\Shared\LoginDisplay.razor"
                context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(4, "!\r\n        ");
                __builder2.AddMarkupContent(5, "<a href=\"MicrosoftIdentity/Account/SignOut\">Log out</a>");
            }
            ));
            __builder.AddAttribute(6, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(7, "<a href=\"MicrosoftIdentity/Account/SignIn\">Log in</a>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
