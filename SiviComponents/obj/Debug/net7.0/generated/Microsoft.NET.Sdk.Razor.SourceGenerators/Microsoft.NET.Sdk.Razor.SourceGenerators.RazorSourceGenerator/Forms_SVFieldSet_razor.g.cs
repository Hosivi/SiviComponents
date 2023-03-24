﻿#pragma checksum "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\SVFieldSet.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "34139046d6fd7459e267720a5eb8758834879d029833c7157f41ddb1e272285b"
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
    public partial class SVFieldSet<TModel> : SVInputBase<TModel>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\SVFieldSet.razor"
 if (ConditionalRendering) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "fieldset");
            __builder.AddMultipleAttributes(1, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 4 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\SVFieldSet.razor"
                           Attributes

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(2, "legend");
#nullable restore
#line (5,18)-(5,23) 24 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\SVFieldSet.razor"
__builder.AddContent(3, Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r        ");
#nullable restore
#line (6,10)-(6,22) 24 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\SVFieldSet.razor"
__builder.AddContent(5, ChildContent);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 8 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\SVFieldSet.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, @"<style>    legend {        font-size: 1.2rem !important;        float: unset;       padding: 1rem !important;        margin-bottom: 1rem !important;        width: inherit !important;	    text-transform: uppercase;    }    fieldset {        margin: inherit !important;        border: 1px solid black;        padding: 1rem !important;    }</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Forms\SVFieldSet.razor"
           [Parameter]    public string? Title { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
