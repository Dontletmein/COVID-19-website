#pragma checksum "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8bf8581be833ef7ebab7ea17c0b62bc7a77a3be"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp3.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\_Imports.razor"
using BlazorApp3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\_Imports.razor"
using BlazorApp3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\Pages\Index.razor"
using BlazorApp3.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\Pages\Index.razor"
using ChartJs.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\Pages\Index.razor"
using ChartJs.Blazor.ChartJS.PolarAreaChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\Pages\Index.razor"
using ChartJs.Blazor.ChartJS.Common.Properties;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\Pages\Index.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style type=\"text/css\">\r\n        h1{\r\n            margin-bottom:20px;\r\n        }\r\n        body {\r\n            \r\n            background-color: #F2F4F4;\r\n        }\r\n\r\n        \r\n        .card {\r\n            margin-top: 10px;\r\n            margin-bottom: 10px;\r\n\r\n            display: flex;\r\n            flex-direction: row;\r\n            flex-wrap: warp;\r\n            justify-content: space-around;\r\n        }\r\n\r\n        .card div {\r\n            margin-top: 0.4rem;\r\n            margin-bottom: 0.4rem;\r\n            margin-left: 50px;\r\n            margin-right: 50px;\r\n            border-radius: 6px;\r\n            white-space: nowrap;\r\n            background: #F2F4F4;\r\n        }\r\n        .idk {\r\n            background-color: white;\r\n            text-align: center;\r\n        }\r\n        .type{\r\n            font-size: 12px;\r\n        }\r\n        .number{\r\n            font-size:19px;\r\n        }\r\n        .increase{\r\n            font-size: 11px;\r\n        }\r\n        .wrap {\r\n            display: flex;\r\n            justify-content: space-between;\r\n            background: #ffffff;\r\n            margin-top: 10px;\r\n            margin-bottom: 10px;\r\n        }\r\n\r\n        .left, .right, .middle {\r\n            position: relative;\r\n            height: 800px;\r\n        }\r\n\r\n        .left {\r\n            width: 50%;\r\n            background: #ffffff;\r\n        }\r\n\r\n        .right {\r\n            width: 50%;\r\n            background: #ffffff;\r\n        }\r\n\r\n        .middle {\r\n            background: #ffffff;\r\n            width: 1%;\r\n            margin: 0 0px;\r\n        }\r\n    </style>\r\n\r\n    ");
            __builder.AddMarkupContent(1, "<h1 style=\"text-align: center\">New Zealand Covid-19 Current Status</h1>\r\n\r\n    ");
            __builder.OpenElement(2, "body");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "idk");
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.AddMarkupContent(10, "<div class=\"type\">Confirmed</div>\r\n                ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "number");
            __builder.AddAttribute(13, "style", "color: rgb(255, 96, 60)");
            __builder.AddContent(14, 
#nullable restore
#line 90 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\Pages\Index.razor"
                                                                     cseStatsData[0].ConfirmedCasesTotal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "increase");
            __builder.AddAttribute(18, "style", "color: rgb(255, 96, 60)");
            __builder.AddContent(19, 
#nullable restore
#line 91 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\Pages\Index.razor"
                                                                       cseStatsData[0].RecoveredCasesNew24h

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(20, " today");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "idk");
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.AddMarkupContent(26, "<div class=\"type\">Probable </div>\r\n                ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "number");
            __builder.AddAttribute(29, "style", "color: rgb(0, 124, 242)");
            __builder.AddContent(30, 
#nullable restore
#line 95 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\Pages\Index.razor"
                                                                     cseStatsData[0].ProbableCasesTotal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "increase");
            __builder.AddAttribute(34, "style", "color: rgb(0, 124, 242)");
            __builder.AddContent(35, 
#nullable restore
#line 96 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\Pages\Index.razor"
                                                                       cseStatsData[0].ProbableCasesNew24h

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(36, " today");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "idk");
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.AddMarkupContent(42, "<div class=\"type\">Recovered </div>\r\n                ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "number");
            __builder.AddAttribute(45, "style", "color: rgb(0, 193, 119)");
            __builder.AddContent(46, 
#nullable restore
#line 100 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\Pages\Index.razor"
                                                                     cseStatsData[0].RecoveredCasesTotal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "increase");
            __builder.AddAttribute(50, "style", "color: rgb(0, 193, 119)");
            __builder.AddContent(51, 
#nullable restore
#line 101 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\Pages\Index.razor"
                                                                       cseStatsData[0].RecoveredCasesNew24h

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(52, " today");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n            ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "idk");
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.AddMarkupContent(58, "<div class=\"type\">in Hospital </div>\r\n                ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "number");
            __builder.AddAttribute(61, "style", "color: rgb(157, 113, 234)");
            __builder.AddContent(62, 
#nullable restore
#line 105 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\Pages\Index.razor"
                                                                       cseStatsData[0].HospitalisedCasesTotal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "increase");
            __builder.AddAttribute(66, "style", "color: rgb(157, 113, 234)");
            __builder.AddContent(67, 
#nullable restore
#line 106 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\Pages\Index.razor"
                                                                         cseStatsData[0].HospitalisedCasesNew24h

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(68, " today");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n            ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "idk");
            __builder.AddMarkupContent(73, "\r\n                ");
            __builder.AddMarkupContent(74, "<div class=\"type\">Deaths </div>\r\n                ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "number");
            __builder.AddAttribute(77, "style", "color: rgb(193, 23, 0)");
            __builder.AddContent(78, 
#nullable restore
#line 110 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\Pages\Index.razor"
                                                                    cseStatsData[0].DeathCasesTotal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "increase");
            __builder.AddAttribute(82, "style", "color: rgb(193, 23, 0)");
            __builder.AddContent(83, 
#nullable restore
#line 111 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\Pages\Index.razor"
                                                                      cseStatsData[0].DeathCasesNew24h

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(84, " today");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n        ");
            __builder.OpenElement(88, "div");
            __builder.AddAttribute(89, "class", "wrap");
            __builder.AddMarkupContent(90, "\r\n            ");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "id", "map");
            __builder.AddAttribute(93, "class", "left");
            __builder.AddMarkupContent(94, "\r\n                ");
            __builder.OpenComponent<ChartJs.Blazor.Charts.ChartJsPolarAreaChart>(95);
            __builder.AddAttribute(96, "Config", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ChartJs.Blazor.ChartJS.PolarAreaChart.PolarAreaConfig>(
#nullable restore
#line 116 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\Pages\Index.razor"
                                                                     _config

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(97, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 116 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\Pages\Index.razor"
                                                                                     500

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(98, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 116 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\Pages\Index.razor"
                                                                                                  500

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(99, (__value) => {
#nullable restore
#line 116 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\Pages\Index.razor"
                                             _polarChartJs = (ChartJs.Blazor.Charts.ChartJsPolarAreaChart)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(100, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n            ");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "id", "map");
            __builder.AddAttribute(104, "class", "right");
            __builder.AddMarkupContent(105, "\r\n                ");
            __builder.OpenComponent<ChartJs.Blazor.Charts.ChartJsPolarAreaChart>(106);
            __builder.AddAttribute(107, "Config", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ChartJs.Blazor.ChartJS.PolarAreaChart.PolarAreaConfig>(
#nullable restore
#line 120 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\Pages\Index.razor"
                                                                       _config24

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(108, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 120 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\Pages\Index.razor"
                                                                                         500

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(109, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 120 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\Pages\Index.razor"
                                                                                                      500

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(110, (__value) => {
#nullable restore
#line 120 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\Pages\Index.razor"
                                             _polarChartJs24 = (ChartJs.Blazor.Charts.ChartJsPolarAreaChart)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(111, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 126 "D:\All_documents\Github\BlazorApp3\COVID-19-website\BlazorApp3\Pages\Index.razor"
           
        private PolarAreaConfig _config;
        private ChartJsPolarAreaChart _polarChartJs;

        private PolarAreaConfig _config24;
        private ChartJsPolarAreaChart _polarChartJs24;

        private string caseStatsUrl = "https://nzcovid19api.xerra.nz/casestats/json";

        private PolarAreaConfig initCofig(string textString)
        {

            PolarAreaConfig _configTemp = new PolarAreaConfig
            {
                Options = new PolarAreaOptions
                {
                    Title = new OptionsTitle
                    {
                        Display = true,
                        Text = textString,
                    },
                    Responsive = true,
                    Animation = new ArcAnimation
                    {
                        AnimateRotate = true,
                        AnimateScale = true
                    }
                }
            };

            return _configTemp;
        }

        private PolarAreaDataset initPolarAreaSet(double[] areaSetData)
        {

            PolarAreaDataset polarAreaSet = new PolarAreaDataset
            {
                BackgroundColor = new[] { "red", "yellow", "blue", "green", "black" },
                BorderWidth = 2,
                HoverBackgroundColor = ColorUtil.RandomColorString(),
                HoverBorderColor = ColorUtil.RandomColorString(),
                HoverBorderWidth = 2,
                BorderColor = "#ffffff",
            };

            polarAreaSet.Data.AddRange(areaSetData);

            return polarAreaSet;
        }

        NZC19CaseStatsData[] cseStatsData;
        protected override async void OnInitialized()
        {
            _config = initCofig("TOTAL CASES");
            _config24 = initCofig("CASES NEW in 24 HOURS");


            _config.Data.Labels.AddRange(new[] { "ConfirmedCasesTotal", "ProbableCasesTotal", "RecoveredCasesTotal", "HospitalisedCasesTotal", "DeathCasesTotal" });
            _config24.Data.Labels.AddRange(new[] { "ConfirmedCasesNew24h", "ProbableCasesNew24h", "RecoveredCasesNew24h", "HospitalisedCasesNew24h", "DeathCasesNew24h" });

            cseStatsData = await CaseStatsService.GetCaseStatsAsync(DateTime.Now, caseStatsUrl);


            var polarAreaSet = initPolarAreaSet(new double[] { cseStatsData[0].ConfirmedCasesTotal, cseStatsData[0].ProbableCasesTotal, cseStatsData[0].RecoveredCasesTotal,
                        cseStatsData[0].HospitalisedCasesTotal, cseStatsData[0].DeathCasesTotal });
            _config.Data.Datasets.Add(polarAreaSet);


            var polarAreaSet24 = initPolarAreaSet(new double[] { cseStatsData[0].ConfirmedCasesNew24h, cseStatsData[0].ProbableCasesNew24h, cseStatsData[0].RecoveredCasesNew24h,
                        cseStatsData[0].HospitalisedCasesNew24h, cseStatsData[0].DeathCasesNew24h });
            _config24.Data.Datasets.Add(polarAreaSet24);

            StateHasChanged();
        }

      

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NZC19CaseStatsService CaseStatsService { get; set; }
    }
}
#pragma warning restore 1591
