﻿#pragma checksum "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Timer\SVTimer.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e3ff927fb0205647e3894439ee96e497739e47d884591c28aa264811adc793b9"
// <auto-generated/>
#pragma warning disable 1591
namespace SiviComponents.Timer
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
#line 1 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Timer\SVTimer.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
    public partial class SVTimer : global::Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "span");
#nullable restore
#line (4,8)-(4,21) 24 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Timer\SVTimer.razor"
__builder.AddContent(1, dateTimeValue);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\Timer\SVTimer.razor"
           public Timer Timer;    string dateTimeValue;    protected override void OnInitialized() {        base.OnInitialized();        dateTimeValue = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");        Timer = new Timer();        Timer.Interval=1000;        Timer.Elapsed += OnTimerElapsed;        Timer.Enabled = true;    }    private void OnTimerElapsed(object? sender, ElapsedEventArgs e) {        dateTimeValue = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");        InvokeAsync(() => {            StateHasChanged();        });    }    public void Dispose() {        Timer.Dispose();    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
