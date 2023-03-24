﻿#pragma checksum "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownSelect.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "252ec170ed0c764bba7dd68e948c66ca5b7e8c8d4b432b3a29cdaa9658d13216"
// <auto-generated/>
#pragma warning disable 1591
namespace SiviComponents.SVDropDownSelect
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
#line 2 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownSelect.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownSelect.razor"
using SiviComponents.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownSelect.razor"
using Utils;

#line default
#line hidden
#nullable disable
    public partial class SVDropDownSelect<TValue> : SVInputBase<TValue>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownSelect.razor"
 if (ConditionalRendering) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", 
#nullable restore
#line 9 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownSelect.razor"
                  WithBlock ? "form-block" : ""

#line default
#line hidden
#nullable disable
            );
            __builder.AddElementReferenceCapture(2, (__value) => {
#nullable restore
#line 9 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownSelect.razor"
                                                        Ref = __value;

#line default
#line hidden
#nullable disable
            }
            );
#nullable restore
#line 10 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownSelect.razor"
         if (Label is not null)
		{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "label");
            __builder.AddAttribute(4, "class", "dropdown-label");
            __builder.AddAttribute(5, "style", "margin-right: 0.5em;");
#nullable restore
#line (12,64)-(12,69) 24 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownSelect.razor"
__builder.AddContent(6, Label);

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, ":");
            __builder.CloseElement();
#nullable restore
#line 13 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownSelect.razor"
		}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "dropdown-content");
#nullable restore
#line 15 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownSelect.razor"
             if (IsDisabled)
			{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn dropdown-toggle");
            __builder.AddAttribute(12, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownSelect.razor"
                                                              Toggle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "id", 
#nullable restore
#line 17 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownSelect.razor"
                                                                           Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "disabled");
#nullable restore
#line (17,78)-(17,97) 25 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownSelect.razor"
__builder.AddContent(15, DropDownPlaceHolder);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 18 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownSelect.razor"
			}
			else
			{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "class", "btn dropdown-toggle");
            __builder.AddEventPreventDefaultAttribute(18, "onclick", 
#nullable restore
#line 21 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownSelect.razor"
                                                                              true

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(19, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownSelect.razor"
                                                                                               Toggle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "id", 
#nullable restore
#line 21 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownSelect.razor"
                                                                                                            Id

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line (21,103)-(21,262) 25 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownSelect.razor"
__builder.AddContent(21, string.IsNullOrEmpty(DropDownDefaultValue) ? (string.IsNullOrEmpty(DropDownPlaceHolder) ? "Seleccione una opción" : DropDownPlaceHolder) : DropDownDefaultValue);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 22 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownSelect.razor"
			}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "ul");
            __builder.AddAttribute(23, "class", "dropdown-menu" + " " + (
#nullable restore
#line 23 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownSelect.razor"
                                       ToggleState ? "show" : ""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddElementReferenceCapture(24, (__value) => {
#nullable restore
#line 23 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownSelect.razor"
                                                                         dropDown = __value;

#line default
#line hidden
#nullable disable
            }
            );
#nullable restore
#line 24 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownSelect.razor"
                 foreach (var d in DropDownListData)
				{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::SiviComponents.SVDropDownSelect.SVDropDownItem<TValue>>(25);
            __builder.AddAttribute(26, "ItemValue", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<TValue>(
#nullable restore
#line 26 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownSelect.razor"
                                                              d

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "GetSelectedValue", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<TValue>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<TValue>(this, 
#nullable restore
#line 26 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownSelect.razor"
                                                                                   GetSelectedValue

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(28, "PropertyName", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 26 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownSelect.razor"
                                                                                                                    PropertyName

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 27 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownSelect.razor"
				}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\t");
            __builder.AddMarkupContent(30, @"<style>
    .dropdown-toggle {
        width: 100%;
        text-align: left !important;
    }                                                                         

    .dropdown-toggle:disabled {
        background-color: #e9ecef;
        opacity: 1;
    }

    .dropdown-toggle:after {
        top: calc(50% - 0.255em / 2);
        position: absolute;
        right: 0.7em;
    }

    .dropdown-content {
        width: 100%;
        position: relative;
    }

    .dropdown-label {
        vertical-align: center;
    }

    .dropdown-menu {
        width: 100%;
        max-height: 300px;
        overflow-y: scroll;
    }

</style>");
#nullable restore
#line 64 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownSelect.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownSelect.razor"
       
	[Parameter] public string DropDownDefaultValue { get; set; }
	[Parameter]
	public string? DropDownPlaceHolder { get; set; }
	[Parameter]
	public List<object>? Data { get; set; } = new List<object>();
	[Parameter]
	public List<TValue> DropDownListData { get; set; }
	[Parameter]
	public TValue? SelectedValue { get; set; }
	[Parameter]
	public string PropertyName { get; set; }
	[Parameter]
	public bool WithBlock { get; set; } = true;
	public bool ToggleState = false;
	public string ToggleClass { get; set; } = "";
	ElementReference dropDown;
	IJSObjectReference module;
	string formBlockClass = "";

	[JSInvokableAttribute("ToggleFromJs")]
	public async Task ToggleFromJs(string click)
	{
		ToggleState = false;
		StateHasChanged();
	}
	public void Toggle()
	{
		if (ToggleState)
		{
			ToggleState = false;

		}
		else
		{
			ToggleState = true;
		}
	}

	public override Task SetParametersAsync(ParameterView parameters) {
		if (typeof(TValue).IsEnum) {
			GetEnumValues();
		}
		if (typeof(TValue) == typeof(object)) {
			if (typeof(TValue).IsEnum) {
				GetEnumValues();
			}
		}
		return base.SetParametersAsync(parameters);
	}

	protected override async Task OnInitializedAsync()
	{
		module = await js.InvokeAsync<IJSObjectReference>("import", "./_content/SiviComponents/js/SVDropDownList.js");
		var objRef = DotNetObjectReference.Create(this);
		await module.InvokeVoidAsync("onClickDomDetect", new object[] { objRef, Id, dropDown });
		///Evaluando tipos
		if (!typeof(TValue).IsEnum) {
			DropDownDefaultValue  = SelectedValue?.GetType().GetProperty(PropertyName)?.GetValue(SelectedValue)?.ToString();
		}
		//if (DropDownDefaultValue is null) {
		//	DropDownDefaultValue= "Selecciona una opción";
		//}
	}
	public async Task GetSelectedValue(TValue val)
	{
		var props = val.GetType().GetProperties().ToList();
		SelectedValue = val;
		if (typeof(TValue).IsEnum) {
			DropDownDefaultValue = val.GetAttribute<StringFieldAttribute>().StringifiedValue;
		}
		if (typeof(TValue)==typeof(string)) {
			DropDownDefaultValue = val.ToString();
		}
		else if (!typeof(TValue).IsEnum && typeof(TValue) != typeof(string))
		{
			var defaultValue = val.GetType().GetProperty(PropertyName)?.GetValue(val)?.ToString();
			if (defaultValue is not null) {
				DropDownDefaultValue = defaultValue;
			}
			
		}
		Console.WriteLine("llego aqui tmb");
		await OnValueChanged(new ChangeEventArgs() { Value = val });
		if (ValueActionChanged is not null)
		{
			ValueActionChanged(Value);
		}

	}
	public void GetEnumValues() {
		List<TValue> lst = new List<TValue>();
		var values = typeof(TValue).GetEnumValues();
		foreach (var v in values) {
			lst.Add((TValue)v);
		}
		DropDownListData = lst;
		SelectedValue = lst.First();
	}
	public void OnReadMode()
	{

	}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
