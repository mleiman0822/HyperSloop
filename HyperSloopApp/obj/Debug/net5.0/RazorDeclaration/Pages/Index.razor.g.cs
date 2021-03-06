// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HyperSloopApp.Pages
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\_Imports.razor"
using HyperSloopApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\_Imports.razor"
using HyperSloopApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\_Imports.razor"
using Blazorise.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\_Imports.razor"
using HyperSloopApp.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\Pages\Index.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\Pages\Index.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\Pages\Index.razor"
using HyperSloopApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\Pages\Index.razor"
using HyperSloopApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/charts")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\Pages\Index.razor"
      
    public double AverageTime
    {
        get
        {
            if (RangedEventList == null || RangedEventList.Count() == 0)
            {
                return 0;
            }
            return RangedEventList.Average(x => x.SlideDuration);
        }
    }
    IEnumerable<SlideEvent> EventsList;
    IEnumerable<SlideEvent> RangedEventList;
    IEnumerable<DataItemSlideCount> Slide1;
    IEnumerable<DataItemSlideCount> Slide2;
    IEnumerable<DataItemSlideCount> Slide3;
    IEnumerable<DataItemVerticalAverage> Slide1VerticalAverage;
    IEnumerable<DataItemVerticalAverage> Slide2VerticalAverage;
    IEnumerable<DataItemVerticalAverage> Slide3VerticalAverage;
    IEnumerable<DataItemAverage> Slide1Average;
    IEnumerable<DataItemAverage> Slide2Average;
    IEnumerable<DataItemAverage> Slide3Average;
    string selectedTab = "TotalSlideCount";
    bool smooth = true;
    public DateTime StartRange { get; set; } = DateTime.Now.Date;
    public DateTime EndRange { get; set; } = DateTime.Now.AddDays(1).Date;
    public DateRange Range { get; set; } = DateRange.Today;
    public static IEnumerable<DateRange> DateRanges { get; set; } = Enum.GetValues(typeof(DateRange)).Cast<DateRange>();

    protected override async Task OnInitializedAsync()
    {
        Range = DateRange.Month;
        SetRange(Range);
    }

    public async Task SetRange(DateRange range)
    {
        if (range == DateRange.Today)
        {
            StartRange = DateTime.Now.Date;
            EndRange = DateTime.Now.AddDays(1).Date;
        }
        else if (range == DateRange.Week)
        {
            StartRange = DateTime.Today.AddDays(
            (int)CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek -
            (int)DateTime.Today.DayOfWeek);
            EndRange = DateTime.Now.AddDays(8).Date;
        }
        else if (range == DateRange.Month)
        {
            StartRange = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            EndRange = StartRange.AddMonths(1).AddDays(-1);
        }

        else if (range == DateRange.Year)
        {
            StartRange = new DateTime(DateTime.Now.Year, 1, 1);
            EndRange = StartRange.AddYears(1).AddDays(-1);
        }
        else if (range == DateRange.All_Time)
        {
            StartRange = DateTime.Now.AddYears(-10);
            EndRange = DateTime.Now.AddDays(1).Date;
        }

        Range = range;
        EventsList = hyperSloopService.GetUserSlideEvents().ToList();
        RangedEventList = EventsList.Where(x => x.StartTime >= StartRange && x.EndTime < EndRange).ToList();
        Slide1 = RangedEventList.Where(x => x.SlideId == 1).GroupBy(x => x.StartTime.Date).Select(x => new DataItemSlideCount(x.Key, x.Count())).ToList();
        Slide2 = RangedEventList.Where(x => x.SlideId == 2).GroupBy(x => x.StartTime.Date).Select(x => new DataItemSlideCount(x.Key, x.Count())).ToList();
        Slide3 = RangedEventList.Where(x => x.SlideId == 3).GroupBy(x => x.StartTime.Date).Select(x => new DataItemSlideCount(x.Key, x.Count())).ToList();
        Slide1Average = RangedEventList.Where(x => x.SlideId == 1).GroupBy(x => x.StartTime.Date).Select(x => new DataItemAverage(x.Key, x.Select(x => x.AverageSpeed).First()));
        Slide2Average = RangedEventList.Where(x => x.SlideId == 2).GroupBy(x => x.StartTime.Date).Select(x => new DataItemAverage(x.Key, x.Select(x => x.AverageSpeed).First()));
        Slide3Average = RangedEventList.Where(x => x.SlideId == 3).GroupBy(x => x.StartTime.Date).Select(x => new DataItemAverage(x.Key, x.Select(x => x.AverageSpeed).First()));
        Slide1VerticalAverage = RangedEventList.Where(x => x.SlideId == 1).GroupBy(x => x.StartTime.Date).Select(x => new DataItemVerticalAverage(x.Key, x.Select(x => x.VerticalSpeed).First()));
        Slide2VerticalAverage = RangedEventList.Where(x => x.SlideId == 2).GroupBy(x => x.StartTime.Date).Select(x => new DataItemVerticalAverage(x.Key, x.Select(x => x.VerticalSpeed).First()));
        Slide3VerticalAverage = RangedEventList.Where(x => x.SlideId == 3).GroupBy(x => x.StartTime.Date).Select(x => new DataItemVerticalAverage(x.Key, x.Select(x => x.VerticalSpeed).First()));


    }

    private void OnSelectedTabChanged(string name)
    {
        selectedTab = name;
    }

    public class DataItemSlideCount
    {
        public DataItemSlideCount(DateTime date, double value) { Date = date; Value = value;  }
        public DateTime Date { get; set; }
        public double Value { get; set; }

    }

    public class DataItemAverage
    {
        public DataItemAverage(DateTime date, double? average) { Date = date; Average = average; }
        public DateTime Date { get; set; }
        public double? Average { get; set; }
    }

    public class DataItemVerticalAverage
    {
        public DataItemVerticalAverage(DateTime date, double? average) { Date = date; Average = average; }
        public DateTime Date { get; set; }
        public double? Average { get; set; }
    }

    public enum DateRange
    {
        Today,
        Week,
        Month,
        Year,
        All_Time
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HyperSloopService hyperSloopService { get; set; }
    }
}
#pragma warning restore 1591
