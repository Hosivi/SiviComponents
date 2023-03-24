﻿#pragma checksum "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3286ae4c7e6e0ff0461d59350103d3201ba791bac1d107bd93e6066ede501e20"
// <auto-generated/>
#pragma warning disable 1591
namespace SiviComponents.Forms
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
#line 1 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
using SiviComponents.Menu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
    public partial class Button : SiviDomComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
 if (Type.Trim().Contains("primary"))
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "type", "button");
            __builder.AddAttribute(2, "id", 
#nullable restore
#line 10 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
                               Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "class", "btn" + " btn-primary" + " " + (
#nullable restore
#line 10 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
                                                           classList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "style", 
#nullable restore
#line 10 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
                                                                              styles

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
                                                                                                WhenOnclick

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 11 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
         if (NavItem.IfIconNav)
		{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "i");
            __builder.AddAttribute(7, "class", 
#nullable restore
#line 13 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
                       NavItem.IconClass

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 14 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
		}

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
          if (ChildContent is not null) {
			 

#line default
#line hidden
#nullable disable
#nullable restore
#line (15,6)-(15,18) 24 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
__builder.AddContent(8, ChildContent);

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
                          
		 }

#line default
#line hidden
#nullable disable
#nullable restore
#line (17,4)-(17,14) 24 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
__builder.AddContent(9, ButtonText);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 19 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
 if (Type.Trim().Contains("link"))
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "a");
            __builder.AddAttribute(11, "type", "button");
            __builder.AddAttribute(12, "id", 
#nullable restore
#line 22 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
                          Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "class", "btn" + " btn-link" + " " + (
#nullable restore
#line 22 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
                                                   classList

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 22 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
                                                               NavItem.IsActive ? "onactive": ""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "href", 
#nullable restore
#line 22 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
                                                                                                          NavItem.URI

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "style");
#nullable restore
#line 23 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
         if (NavItem.IfIconNav)
		{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "i");
            __builder.AddAttribute(17, "class", 
#nullable restore
#line 25 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
                       NavItem.IconClass

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 26 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
		}

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
         if (NavItem.Text != null)
		{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "span");
#nullable restore
#line (29,11)-(29,23) 25 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
__builder.AddContent(19, NavItem.Text);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 30 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
		}

#line default
#line hidden
#nullable disable
#nullable restore
#line (32,4)-(32,16) 25 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
__builder.AddContent(20, ChildContent);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 34 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
 if (Type.Trim().Contains("submit")) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "type", "submit");
            __builder.AddAttribute(23, "id", 
#nullable restore
#line 36 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
                               Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(24, "class", "btn" + " btn-primary" + " " + (
#nullable restore
#line 36 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
                                                           CustomClassList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "style", 
#nullable restore
#line 36 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
                                                                                     styles

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(26, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
                                                                                                       WhenOnclick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventPreventDefaultAttribute(27, "onclick", 
#nullable restore
#line 36 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
                                                                                                                                             true

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line (37,4)-(37,16) 25 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
__builder.AddContent(28, ChildContent);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 39 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
       

	[Parameter]
	public string Type { get; set; } = "primary";
	

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\Button.razor"
                                                                                                              

	[Parameter]
	public EventCallback<EventArgs> OnclickWithArgs { get; set; }
	[Parameter] public string ButtonText { get; set; }
	[Parameter]
	public EventCallback<Object?> Onclick { get; set; }
	[Parameter]
	public EventCallback<NavItem> OnNavigate { get; set; }

	[Parameter]
	public EventCallback<string> OnclickLinkButton { get; set; }

	[Parameter]
	public Object? ObjectButton { get; set; }
	private string? hrefAbsolute;
	[Parameter]
	public NavItem NavItem { get; set; } = new NavItem();
	protected override void OnInitialized() {
		if (Type.Equals("link")) {
			NavigationManager.LocationChanged += OnNavigateTo;
			hrefAbsolute = NavigationManager.ToAbsoluteUri(NavItem.URI).AbsolutePath;
			Console.WriteLine(hrefAbsolute);
		}
		base.OnInitialized();

	}
	public void OnNavigateTo(object sender, LocationChangedEventArgs args) {
		var hrefActual = NavigationManager.ToAbsoluteUri(NavigationManager.Uri).AbsolutePath;
		if (hrefActual.Trim()==NavItem.URI.Trim()) {
			NavItem.IsActive = true;
			
		} else {
			NavItem.IsActive = false;
		}
		if (OnNavigate.HasDelegate) {
			OnNavigate.InvokeAsync(NavItem);
		}
		StateHasChanged();
	}

	public async Task WhenOnclick() {
		await Onclick.InvokeAsync(ObjectButton); 
	}

	public void Dispose() {
		if (Type.Equals("link")) {
			NavigationManager.LocationChanged -= OnNavigateTo;
		}
	}



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
