﻿#pragma checksum "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\ValidationComponent.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "86ae1f350ba699d289789bda957762dd07644b82bc594eeb1378934e2580e60f"
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
#line 1 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\ValidationComponent.razor"
using FluentValidation.Results;

#line default
#line hidden
#nullable disable
    public partial class ValidationComponent<TValue> : global::Microsoft.AspNetCore.Components.ComponentBase
    where TValue: class
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-block");
#nullable restore
#line 5 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\ValidationComponent.razor"
     if (!IsValid)
	{
		

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\ValidationComponent.razor"
         foreach (var error in validationResult.Errors)
		{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "p");
#nullable restore
#line (9,8)-(9,26) 24 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\ValidationComponent.razor"
__builder.AddContent(3, error.ErrorMessage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 10 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\ValidationComponent.razor"
		}

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\ValidationComponent.razor"
         
	}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\ValidationComponent.razor"
       
	[Parameter] public TValue Model { get; set; }
	[Parameter] public bool IsValid { get; set; } = true;
	[Parameter] public bool FirstTime { get; set; } = true;
	

	public ValidationResult? validationResult;
	protected override void OnAfterRender(bool firstRender)
	{
		if (firstRender)
		{
			FirstTime = false;
		}
	}

	protected override void OnParametersSet()
	{
		if (!FirstTime)
		{
			OnValidate();
		}
	}

	public void OnValidate()
	{
		validationResult = ValidationService.ValidateModel(Model);
		if (!validationResult.IsValid)
		{
			IsValid = false;
		}
		else
		{
			IsValid = true;
		}

	}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IValidationService ValidationService { get; set; }
    }
}
#pragma warning restore 1591
