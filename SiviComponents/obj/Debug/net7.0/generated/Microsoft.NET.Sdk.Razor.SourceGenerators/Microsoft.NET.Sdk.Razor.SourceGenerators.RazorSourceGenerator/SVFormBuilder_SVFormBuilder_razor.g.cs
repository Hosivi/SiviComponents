﻿#pragma checksum "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c6d5b3bd70ceebe88f43e7ef01ce3d12306803d295dbd9b74ca0685368bb15f1"
// <auto-generated/>
#pragma warning disable 1591
namespace SiviComponents.SVFormBuilder
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
#line 1 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
using System.Reflection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
using System.Xml.Schema;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
using FluentValidation.Results;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
using Microsoft.AspNetCore.Components.CompilerServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
using Microsoft.AspNetCore.Components.Rendering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
using SiviComponents.FormBuilder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
using SiviComponents.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
using Utils;

#line default
#line hidden
#nullable disable
    public partial class SVFormBuilder<TModel> : global::Microsoft.AspNetCore.Components.ComponentBase, IFormBuilder
    where TModel : class
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            global::__Blazor.SiviComponents.SVFormBuilder.SVFormBuilder.TypeInference.CreateCascadingValue_0(__builder, 0, 1, 
#nullable restore
#line 14 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                       this

#line default
#line hidden
#nullable disable
            , 2, "FormBuilder", 3, (__builder2) => {
                __builder2.OpenComponent<global::SiviComponents.Base.SVSpinner>(4);
                __builder2.AddAttribute(5, "ExternalRendering", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 15 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::SiviComponents.Forms.SVForm>(7);
                    __builder3.AddAttribute(8, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 16 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                         FormModel

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(9, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(10, "div");
                        __builder4.AddAttribute(11, "class", "form-block");
                        __builder4.OpenElement(12, "h5");
                        __builder4.AddAttribute(13, "class", "h5 text-center");
#nullable restore
#line (17,65)-(17,75) 26 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
__builder4.AddContent(14, FormTittle);

#line default
#line hidden
#nullable disable
                        __builder4.CloseElement();
                        __builder4.CloseElement();
#nullable restore
#line 18 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
             if (Configuration.Columns == 1) {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                 if (Configuration.FieldSets.Any()) {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                     foreach (var fs in Configuration.FieldSets) {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<global::SiviComponents.Forms.SVFieldSet<TModel>>(15);
                        __builder4.AddAttribute(16, "Title", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 23 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                                      fs.FormTitle

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(17, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
#nullable restore
#line 24 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                             foreach (var f in fs.FormControls) {

#line default
#line hidden
#nullable disable
                            __builder5.OpenComponent<global::SiviComponents.SVFormBuilder.SVFormElement<TModel>>(18);
                            __builder5.AddAttribute(19, "FieldConfiguration", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::SiviComponents.SVFormBuilder.FieldConfiguration<TModel>>(
#nullable restore
#line 27 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                                                           f

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(20, "FormModel", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<TModel>(
#nullable restore
#line 28 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                                                  FormModel

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(21, "FormMode", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::SiviComponents.SVFormBuilder.FormMode>(
#nullable restore
#line 29 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                                                 FormMode

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
#nullable restore
#line 30 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                            }

#line default
#line hidden
#nullable disable
                        }
                        ));
                        __builder4.CloseComponent();
#nullable restore
#line 32 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                     
                } else {
                    foreach (var f in Configuration.FormControls) {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<global::SiviComponents.SVFormBuilder.SVFormElement<TModel>>(22);
                        __builder4.AddAttribute(23, "FieldConfiguration", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::SiviComponents.SVFormBuilder.FieldConfiguration<TModel>>(
#nullable restore
#line 37 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                                                   f

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(24, "FormModel", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<TModel>(
#nullable restore
#line 38 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                                          FormModel

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(25, "FormMode", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::SiviComponents.SVFormBuilder.FormMode>(
#nullable restore
#line 39 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                                         FormMode

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
#nullable restore
#line 40 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                    }
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                 
            } else {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                 if (Configuration.FieldSets.Any()) {

#line default
#line hidden
#nullable disable
                        __builder4.OpenElement(26, "div");
                        __builder4.AddAttribute(27, "class", "flex-multicolumn-container");
#nullable restore
#line 46 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                         foreach (var fs in Configuration.FieldSets) {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<global::SiviComponents.Forms.SVFieldSet<TModel>>(28);
                        __builder4.AddAttribute(29, "Title", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 49 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                                          fs.FormTitle

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(30, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenElement(31, "div");
                            __builder5.AddAttribute(32, "class", "flex-multicolumn-subcontainer");
#nullable restore
#line 52 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                                     foreach (var f in fs.FormControls) {

#line default
#line hidden
#nullable disable
                            __builder5.OpenComponent<global::SiviComponents.SVFormBuilder.SVFormElement<TModel>>(33);
                            __builder5.AddAttribute(34, "FieldConfiguration", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::SiviComponents.SVFormBuilder.FieldConfiguration<TModel>>(
#nullable restore
#line 55 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                                                                   f

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(35, "FormModel", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<TModel>(
#nullable restore
#line 56 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                                                          FormModel

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(36, "FormMode", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::SiviComponents.SVFormBuilder.FormMode>(
#nullable restore
#line 57 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                                                         FormMode

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
#nullable restore
#line 58 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                                    }

#line default
#line hidden
#nullable disable
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(37, "\r\n                                ");
                            __builder5.OpenElement(38, "style");
                            __builder5.AddMarkupContent(39, "\r\n\t\t\t\t\t\t\t\t.flex-multicolumn-subcontainer {\r\n\t\t\t\t\t\t\t\t\tdisplay: inline-grid;\r\n\t\t\t\t\t\t\t\t\tgrid-template-columns: repeat(");
#nullable restore
#line (63,42)-(63,57) 26 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
__builder5.AddContent(40, $"{fs.Columns}");

#line default
#line hidden
#nullable disable
                            __builder5.AddMarkupContent(41, ", 1fr);\r\n\t\t\t\t\t\t\t\t\tcolumn-gap: 1rem;\r\n\t\t\t\t\t\t\t\t\twidth: 100%;\r\n\t\t\t\t\t\t\t\t}\r\n\t\t\t\t\t\t\t");
                            __builder5.CloseElement();
                        }
                        ));
                        __builder4.CloseComponent();
#nullable restore
#line 69 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                        }

#line default
#line hidden
#nullable disable
                        __builder4.CloseElement();
#nullable restore
#line 71 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                } else {

#line default
#line hidden
#nullable disable
                        __builder4.OpenElement(42, "div");
                        __builder4.AddAttribute(43, "class", "flex-multicolumn-container");
#nullable restore
#line 74 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                         foreach (var f in Configuration.FormControls) {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<global::SiviComponents.SVFormBuilder.SVFormElement<TModel>>(44);
                        __builder4.AddAttribute(45, "FieldConfiguration", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::SiviComponents.SVFormBuilder.FieldConfiguration<TModel>>(
#nullable restore
#line 77 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                                                       f

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(46, "FormModel", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<TModel>(
#nullable restore
#line 78 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                                              FormModel

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(47, "FormMode", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::SiviComponents.SVFormBuilder.FormMode>(
#nullable restore
#line 79 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                                             FormMode

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
#nullable restore
#line 80 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                        }

#line default
#line hidden
#nullable disable
                        __builder4.CloseElement();
#nullable restore
#line 82 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                }

#line default
#line hidden
#nullable disable
                        __builder4.OpenElement(48, "style");
                        __builder4.AddMarkupContent(49, "\r\n\t\t\t\t.flex-multicolumn-container {\r\n\t\t\t\t\tdisplay: grid;\r\n\t\t\t\t\tgrid-template-columns: repeat(");
#nullable restore
#line (86,38)-(86,64) 26 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
__builder4.AddContent(50, $"{Configuration.Columns}");

#line default
#line hidden
#nullable disable
                        __builder4.AddMarkupContent(51, ", 1fr);\r\n\t\t\t\t\tcolumn-gap: 1rem;\r\n\t\t\t\t}\r\n\t\t\t");
                        __builder4.CloseElement();
#nullable restore
#line 90 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
             if (FormModel is not null) {


#line default
#line hidden
#nullable disable
                        __builder4.OpenElement(52, "div");
                        __builder4.AddAttribute(53, "class", "form-block text-center");
#nullable restore
#line 95 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                     if (FormMode == FormMode.Create) {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<global::SiviComponents.Forms.Button>(54);
                        __builder4.AddAttribute(55, "Type", "primary");
                        __builder4.AddAttribute(56, "Onclick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Object>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Object>(this, 
#nullable restore
#line 98 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                                         async () => await Submit()

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(57, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
#nullable restore
#line (98,73)-(98,89) 26 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
__builder5.AddContent(58, SubmitButtonText);

#line default
#line hidden
#nullable disable
                        }
                        ));
                        __builder4.CloseComponent();
#nullable restore
#line 99 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                    } else if (FormMode == FormMode.Edit) {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<global::SiviComponents.Forms.Button>(59);
                        __builder4.AddAttribute(60, "Type", "primary");
                        __builder4.AddAttribute(61, "Onclick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Object>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Object>(this, 
#nullable restore
#line 102 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                                         async () => await Submit()

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(62, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
#nullable restore
#line (102,73)-(102,87) 26 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
__builder5.AddContent(63, EditButtonText);

#line default
#line hidden
#nullable disable
                        }
                        ));
                        __builder4.CloseComponent();
#nullable restore
#line 103 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                    } else if (FormMode == FormMode.Read) {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<global::SiviComponents.Forms.Button>(64);
                        __builder4.AddAttribute(65, "Type", "primary");
                        __builder4.AddAttribute(66, "Onclick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Object>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Object>(this, 
#nullable restore
#line 106 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                                        OnEditMode

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(67, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(68, "Cambiar a modo edición");
                        }
                        ));
                        __builder4.CloseComponent();
#nullable restore
#line 107 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                    }

#line default
#line hidden
#nullable disable
                        __builder4.CloseElement();
#nullable restore
#line 109 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                 if (IsHaveValidation) {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<global::SiviComponents.Forms.ValidationComponent<TModel>>(69);
                        __builder4.AddAttribute(70, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<TModel>(
#nullable restore
#line 112 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                                 FormModel

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddComponentReferenceCapture(71, (__value) => {
#nullable restore
#line 113 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                                validationComponent = (SiviComponents.Forms.ValidationComponent<TModel>)__value;

#line default
#line hidden
#nullable disable
                        }
                        );
                        __builder4.CloseComponent();
#nullable restore
#line 114 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                }

#line default
#line hidden
#nullable disable
                        __builder4.AddMarkupContent(72, "<div class=\"form-container\"></div>");
#nullable restore
#line 118 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
            }

#line default
#line hidden
#nullable disable
                        __builder4.AddMarkupContent(73, "<style>\r\n\t\t\t.form-container { width: 100%; }\r\n\t\t</style>");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddComponentReferenceCapture(74, (__value) => {
#nullable restore
#line 15 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
                     Spin = (SiviComponents.Base.SVSpinner)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 131 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\SVFormBuilder\SVFormBuilder.razor"
       

	[Parameter]
	public TModel FormModel { get; set; }

	[Parameter]
	public FormConfiguration<TModel> Configuration { get; set; }

	[Parameter]
	public string? SubmitButtonText { get; set; }

	[Parameter]
	public string? EditButtonText { get; set; } = "Editar";

	[Parameter]
	public string? FormTittle { get; set; }

	[Parameter]
	public EventCallback<TModel> OnSubmit { get; set; }

	[Parameter]
	public FormMode FormMode { get; set; }

	[Parameter]
	public bool IsHaveValidation { get; set; } = true;

	[Parameter]
	public EventCallback OnEditMode { get; set; }

	SVSpinner Spin;
	public delegate void WhenModelChange(SVFormBuilder<TModel> builder, SVFormElement<TModel> formElement, (string modelProperty, object? x) modelAndProperty);
	public event WhenModelChange OnModelWasChanged;  
	public Dictionary<IFieldBuilder, object?> InputsCollection { get; set; } = new Dictionary<IFieldBuilder, object>();
	private RenderFragment? FormRendered { get; set; }
	bool thereAreErrors = false;
	ValidationResult validationResult;
	ValidationComponent<TModel> validationComponent;
	bool shouldRender = true;
	int counter = 0;

	public void ChangeFormMode(FormMode formMode) {
		if (OnEditMode.HasDelegate) {
			OnEditMode.InvokeAsync();
		} else {
			FormMode = formMode;
		}
	}

	protected override void OnInitialized() {
	}

	protected override void OnAfterRender(bool firstRender) {
		if (firstRender) {
			Spin.RenderChild();	
		}
		base.OnAfterRender(firstRender);
	}

	public async Task Submit() {
		if (IsHaveValidation) {
			validationComponent.OnValidate();
			if (validationComponent.IsValid) {
				await OnSubmit.InvokeAsync(FormModel);
			}
		} else {
			await OnSubmit.InvokeAsync(FormModel);
		}
	}

	public async Task OnReadMode(TModel model) {
		FormMode = FormMode.Read;
	}

	public void Tester() {
	// StateHasChanged();
		Console.WriteLine("esto es el buton");
	}


	protected override bool ShouldRender() {
		return shouldRender;
	}

	public void WhenModelWasChanged(string modelProperty, object value) {
	    ///Este evento refresca todos los componentes
		foreach (var ic in InputsCollection) {
		ic.Key.Refresh();	
		}
		var inp = InputsCollection.SingleOrDefault(x => {
			var t = x.Key;
			return t.ModelProperty == modelProperty; 
		});
		 
		///Aquí conozco la propiedad y el camvio de la propiedad
		var x=inp.Value.GetType().GetProperty("Value")?.GetValue(inp.Value);
		if (OnModelWasChanged is not null) {
			OnModelWasChanged.Invoke(this,(SVFormElement<TModel>)inp.Key,(modelProperty,x));	
		}
		Console.WriteLine($"desde el fbuilder inp que se cambio: {inp.Key.ModelProperty} y eñ valor es {x}" );
		
	}

	public void SubscribeInput(IFieldBuilder fieldBuilder) {
		InputsCollection.TryAdd(fieldBuilder, fieldBuilder.InputElementChild);
	}


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.SiviComponents.SVFormBuilder.SVFormBuilder
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::System.String __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "ChildContent", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
