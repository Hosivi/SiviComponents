﻿#pragma checksum "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownItem.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c66f59c2207b7f9b6e8b3a6e509f8e100f3fc033543e8cb34133b300edaa858e"
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
#line 1 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownItem.razor"
using System.Reflection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownItem.razor"
using Utils;

#line default
#line hidden
#nullable disable
    public partial class SVDropDownItem<TItem> : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownItem.razor"
 if (typeof(TItem) == typeof(string))
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "li");
            __builder.AddAttribute(1, "class", "dropdown-item");
            __builder.AddAttribute(2, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownItem.razor"
                                          async ()=>await GetSelectedValue.InvokeAsync(ItemValue)

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line (6,100)-(6,172) 24 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownItem.razor"
__builder.AddContent(3, string.IsNullOrEmpty(ItemValue?.ToString()) ? "" : ItemValue?.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 7 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownItem.razor"
} 

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownItem.razor"
 if (typeof(TItem).IsEnum) {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "li");
            __builder.AddAttribute(5, "class", "dropdown-item");
            __builder.AddAttribute(6, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownItem.razor"
                                          async ()=>await GetSelectedValue.InvokeAsync(ItemValue)

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line (10,100)-(10,164) 24 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownItem.razor"
__builder.AddContent(7, ItemValue?.GetAttribute<StringFieldAttribute>().StringifiedValue);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 11 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownItem.razor"
}
else {
	if (PropertyName is not null) {
		var propValue = ItemValue?.GetType().GetProperty(PropertyName)?.GetValue(ItemValue) ;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "li");
            __builder.AddAttribute(9, "class", "dropdown-item");
            __builder.AddAttribute(10, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownItem.razor"
                                              async ()=>await GetSelectedValue.InvokeAsync(ItemValue)

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line (15,101)-(15,173) 25 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownItem.razor"
__builder.AddContent(11, string.IsNullOrEmpty(propValue?.ToString()) ? "" : propValue?.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 16 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownItem.razor"
	}
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVDropDownSelect\SVDropDownItem.razor"
       
 	[Parameter] public TItem? ItemValue { get; set; }
 	[Parameter] public string? PropertyName { get; set; }
 	[Parameter] public EventCallback<TItem?> GetSelectedValue { get; set; }
 	protected override void OnInitialized() {
 		base.OnInitialized();
 	}
 
 

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
