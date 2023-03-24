﻿#pragma checksum "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Menu\SiviNavLink.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3d162069f0c424591c88551526b7ae4869f09b36f52a939cdbf84d4b85cabca8"
// <auto-generated/>
#pragma warning disable 1591
namespace SiviComponents.Menu
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\_Imports.razor"
using SiviComponents.Base;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\_Imports.razor"
using SiviComponents.Grid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\_Imports.razor"
using SiviComponents.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\_Imports.razor"
using SiviComponents.EventArgs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\_Imports.razor"
using SiviComponents.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\_Imports.razor"
using SiviComponents.SVDropDownSelect;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\_Imports.razor"
using SiviComponents.SVFormBuilder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\_Imports.razor"
using SiviComponents.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\_Imports.razor"
using SiviComponents.DateComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\_Imports.razor"
using SiviComponents.SVStepper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\_Imports.razor"
using SiviComponents.Timer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Menu\SiviNavLink.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
    public partial class SiviNavLink : SiviDomComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "a");
            __builder.AddAttribute(1, "href", "route");
#nullable restore
#line 6 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Menu\SiviNavLink.razor"
    if (IconLink) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "i");
            __builder.AddAttribute(3, "class", "IconClass");
            __builder.AddAttribute(4, "style", 
#nullable restore
#line 7 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Menu\SiviNavLink.razor"
                                      IconStyles

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 8 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Menu\SiviNavLink.razor"
   } 

#line default
#line hidden
#nullable disable
#nullable restore
#line (9,5)-(9,17) 24 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Menu\SiviNavLink.razor"
__builder.AddContent(5, ChildContent);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Menu\SiviNavLink.razor"
       
	/// <summary>
	/// Parameters
	/// </summary>
	[Parameter] public bool IconLink { get; set; }
	[Parameter] public RenderFragment? ChildContent { get; set; }
	[Parameter] public string IconCssClass { get; set; }
	[Parameter] public string IconStyles  { get; set; }
	[Parameter] public string Uri { get; set; }
	string AbsoluteUri="/";
	bool isActive { get; set; }

	
	protected override void OnInitialized() {
		NavigationManager.LocationChanged += OnLocationChanged;
	}

	public void OnLocationChanged(object? sender, LocationChangedEventArgs args) {
		NavigationManager.ToAbsoluteUri(args.Location);
	}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
