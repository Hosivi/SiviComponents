﻿#pragma checksum "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "96f9b55266b9b0039de9a01bfd9d50a5fff9c3e24cf79e6d9521dddf44e98946"
// <auto-generated/>
#pragma warning disable 1591
namespace SiviComponents.DataGrid
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
#line 3 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor"
using System.Linq.Expressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor"
using SharedKernel.Interfaces;

#line default
#line hidden
#nullable disable
    public partial class SVDataGrid<TValue> : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            global::__Blazor.SiviComponents.DataGrid.SVDataGrid.TypeInference.CreateCascadingValue_0(__builder, 0, 1, 
#nullable restore
#line 7 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor"
                       this

#line default
#line hidden
#nullable disable
            , 2, "Grid", 3, (__builder2) => {
                global::__Blazor.SiviComponents.DataGrid.SVDataGrid.TypeInference.CreateCascadingValue_1(__builder2, 4, 5, 
#nullable restore
#line 8 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor"
                           Cols

#line default
#line hidden
#nullable disable
                , 6, "Cols", 7, (__builder3) => {
                    global::__Blazor.SiviComponents.DataGrid.SVDataGrid.TypeInference.CreateCascadingValue_2(__builder3, 8, 9, 
#nullable restore
#line 9 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor"
                               SVColumnList

#line default
#line hidden
#nullable disable
                    , 10, "SVColumns", 11, (__builder4) => {
                        __builder4.OpenComponent<global::SiviComponents.Base.SVSpinner>(12);
                        __builder4.AddAttribute(13, "ExternalRendering", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 10 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor"
                                                      true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(14, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
#nullable restore
#line (11,5)-(11,14) 26 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor"
__builder5.AddContent(15, SVContent);

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor"
             if (ItemContent is not null) {
					

#line default
#line hidden
#nullable disable
#nullable restore
#line (13,7)-(13,25) 26 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor"
__builder5.AddContent(16, ItemContent(Value));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor"
                                       
			}

#line default
#line hidden
#nullable disable
                            __builder5.OpenElement(17, "div");
                            __builder5.AddAttribute(18, "class", "row w-100");
                            __builder5.OpenElement(19, "h5");
                            __builder5.AddAttribute(20, "class", "h4");
#nullable restore
#line (16,22)-(16,31) 26 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor"
__builder5.AddContent(21, GridTitle);

#line default
#line hidden
#nullable disable
                            __builder5.CloseElement();
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(22, "\r\n\t\t\t");
                            __builder5.OpenElement(23, "div");
                            __builder5.AddAttribute(24, "class", "tools-content mb-3");
                            __builder5.AddMarkupContent(25, "<div class=\"filters\"></div>\r\n\t\t\t\t");
                            __builder5.OpenElement(26, "div");
                            __builder5.AddAttribute(27, "class", "tools");
                            __builder5.OpenElement(28, "div");
                            __builder5.AddAttribute(29, "class", "btn-group");
#nullable restore
#line (22,8)-(22,23) 26 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor"
__builder5.AddContent(30, SVDataGridTools);

#line default
#line hidden
#nullable disable
                            __builder5.CloseElement();
                            __builder5.CloseElement();
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(31, "\r\n\t\t\t");
                            __builder5.OpenElement(32, "div");
                            __builder5.AddAttribute(33, "class", "table-container");
                            __builder5.OpenElement(34, "table");
                            __builder5.AddAttribute(35, "class", "table table-sm");
                            __builder5.OpenElement(36, "thead");
#nullable restore
#line (29,7)-(29,16) 26 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor"
__builder5.AddContent(37, SVColumns);

#line default
#line hidden
#nullable disable
                            __builder5.AddMarkupContent(38, "\r\n\t\t\t\t\t");
                            __builder5.OpenComponent<global::SiviComponents.DataGrid.SVRow<TValue>>(39);
                            __builder5.AddAttribute(40, "RowType", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::SiviComponents.DataGrid.RowType>(
#nullable restore
#line 30 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor"
                                                    RowType.Header

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(41, "\r\n\t\t\t\t\t");
                            __builder5.OpenElement(42, "tbody");
#nullable restore
#line 34 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor"
                     if (RenderRows) {
						

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor"
                         if (Data.Count() == 0) {

#line default
#line hidden
#nullable disable
                            __builder5.AddMarkupContent(43, "<p>No hay registros</p>");
#nullable restore
#line 37 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor"
						} else {
							

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor"
                             if (Filtering) {
								

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor"
                                 if (Cols.Any(x => x.Filtering)) {

#line default
#line hidden
#nullable disable
                            __builder5.OpenComponent<global::SiviComponents.DataGrid.SVRow<TValue>>(44);
                            __builder5.AddAttribute(45, "IsHeader", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 40 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor"
                                                                     false

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(46, "RowType", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::SiviComponents.DataGrid.RowType>(
#nullable restore
#line 40 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor"
                                                                                     RowType.Filtering

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
#nullable restore
#line 41 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor"
								}

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor"
                                 
							}

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor"
                             
							foreach (var d in Data) {

#line default
#line hidden
#nullable disable
                            __builder5.OpenComponent<global::SiviComponents.DataGrid.SVRow<TValue>>(47);
                            __builder5.AddAttribute(48, "RowType", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::SiviComponents.DataGrid.RowType>(
#nullable restore
#line 44 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor"
                                                                RowType.Default

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(49, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<TValue>(
#nullable restore
#line 44 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor"
                                                                                         d

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
#nullable restore
#line 45 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor"
							}
						}

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor"
                         
					}

#line default
#line hidden
#nullable disable
                            __builder5.CloseElement();
                            __builder5.CloseElement();
#nullable restore
#line 52 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor"
                 if (RenderRows)
				{

#line default
#line hidden
#nullable disable
                            __builder5.OpenComponent<global::SiviComponents.DataGrid.SVPaginator<TValue>>(50);
                            __builder5.AddAttribute(51, "CountData", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 54 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor"
                                                                             DataSize

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(52, "Radio", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 54 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor"
                                                                                              Radio

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(53, "OnAfterSelectPage", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 54 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor"
                                                                                                                        AllData

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddComponentReferenceCapture(54, (__value) => {
#nullable restore
#line 54 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor"
                                       Paginator = (SiviComponents.DataGrid.SVPaginator<TValue>)__value;

#line default
#line hidden
#nullable disable
                            }
                            );
                            __builder5.CloseComponent();
#nullable restore
#line 55 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor"
				}

#line default
#line hidden
#nullable disable
                            __builder5.CloseElement();
                        }
                        ));
                        __builder4.AddComponentReferenceCapture(55, (__value) => {
#nullable restore
#line 10 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor"
                             Spin = (SiviComponents.Base.SVSpinner)__value;

#line default
#line hidden
#nullable disable
                        }
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(56, "\r\n\t\t\t");
                        __builder4.AddMarkupContent(57, @"<style>
				.tools-content {
					display: flex;
					justify-content: flex-end;
					align-content: center;
					width: 100%;
				}

				.tools {
					display: flex;
					justify-content: flex-end;
					align-items: center;
					width: 50%;
				}

				.filters {
					width: 50%;
				}
			</style>");
                    }
                    );
                }
                );
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "E:\DeveloperRepos2023\SiviComponents\SiviComponents\DataGrid\SVDataGrid.razor"
       
	/// <summary>
	/// DataGrid:
	/// **Modalidades de ingreso y salida de datos:
	/// 1. Desde un conjunto de datos
	/// 2. Desde la base de datos
	/// </summary>

	#region Parámetros
	#region Parámetros Comunes
	[Parameter] public RenderFragment SVColumns { get; set; }
	[Parameter] public RenderFragment? SVContent { get; set; }
	[Parameter] public RenderFragment<TValue>? ItemContent { get; set; }
	[Parameter] public List<TValue> Data { get; set; }
	[Parameter] public SVRow<TValue>? SelectedValue { get; set; }
	[Parameter] public TValue? Value { get; set; }
	[Parameter] public RenderFragment SVDataGridTools { get; set; }
	[Parameter] public Func<Task<int>>? CountDataSize { get; set; }
	[Parameter] public int ItemsForPage { get; set; } = 10;
	[Parameter] public int Radio { get; set; } = 3;
	[Parameter] public int DataSize { get; set; }
	[Parameter] public TValue SearcherValue { get; set; }
	[Parameter] public bool Filtering { get; set; } = true;
	[Parameter]
	public string GridTitle {get; set; }
	#endregion
	/// <summary>
	/// GetDataFunc, es una función que se ejecuta cuando se necesita obtener los datos de la base de datos pasándole la cantidad de items por página
	/// , página seleccionada y el objeto de filtro.
	/// </summary>
	#region Parámetros de Modalidad de funcionamiento
	[Parameter] public DataGridMode DataGridMode { get; set; } = DataGridMode.FromDataBase;
	[Parameter] public Func<int, int, TValue?, Task<List<TValue>>>? GetDataFunc { get; set; }
	[Parameter] public ISpecification<TValue>? Filters { get; set; }
	#endregion
	#endregion
	#region Attributos
	public List<SVColumn> SVColumnList = new List<SVColumn>();
	List<Column> Cols = new List<Column>();
	bool RenderRows = false;
	SVSpinner Spin;
	public SVPaginator<TValue> Paginator;
	public SVPaginator<TValue>.Page SelectedPage = new SVPaginator<TValue>.Page() { IsActualPage = true, NumberOfPage = 1 };
	#endregion
	#region Ciclos de Vida
	protected override async Task OnAfterRenderAsync(bool firstRender)
	{
		if (firstRender)
		{
			RenderRows = true;
			Spin.RenderChild();
			Value = Data.FirstOrDefault();
		}
	}
	protected override async Task OnInitializedAsync()
	{
		Data = new List<TValue>();
		if (Filtering)
		{
			SearcherValue = Activator.CreateInstance<TValue>();
		}
		if (DataGridMode.Equals(DataGridMode.FromDataBase))
		{
			await GetData();
			await CountData();
		}
	}

	protected override async Task OnParametersSetAsync() {
		var props = SearcherValue.GetType().GetProperties();
		foreach (var p in props) {
			Console.WriteLine(p.Name+": "+p.GetValue(SearcherValue));
		}

	}

	#endregion
	#region Eventos
	public async Task GetData()
	{
		if (GetDataFunc is not null)
		{
			Data = await GetDataFunc(SelectedPage.NumberOfPage,ItemsForPage, SearcherValue);
		}
	}

	public async Task CountData()
	{
		if (CountDataSize is not null)
		{
			DataSize = await CountDataSize.Invoke();

		}
	}

	public async Task AllData()
	{
		await GetData();
		await CountData();
		Paginator.GetNumberOfPages();
		Paginator.RenderRadioPages();
		SearcherValue = Activator.CreateInstance<TValue>();
		StateHasChanged();
	}
	public void Filter(List<TValue> data)
	{
		Data = data;
		StateHasChanged();
	}
	#endregion

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.SiviComponents.DataGrid.SVDataGrid
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
        public static void CreateCascadingValue_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::System.String __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "ChildContent", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateCascadingValue_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::System.String __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2)
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
