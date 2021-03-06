// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HyperSloopApp.Pages
{
    #line hidden
    using System;
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
#line 2 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\Pages\PersonalMetrics.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\Pages\PersonalMetrics.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\Pages\PersonalMetrics.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\Pages\PersonalMetrics.razor"
using Blazorise.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\Pages\PersonalMetrics.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\Pages\PersonalMetrics.razor"
using System.Net.Sockets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\Pages\PersonalMetrics.razor"
using System.Linq.Expressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\Pages\PersonalMetrics.razor"
using HyperSloopApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\Pages\PersonalMetrics.razor"
using HyperSloopApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\Pages\PersonalMetrics.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\Pages\PersonalMetrics.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\Pages\PersonalMetrics.razor"
using System.ComponentModel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/personalStats")]
    public partial class PersonalMetrics : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 220 "C:\Users\matthew.leiman\Desktop\Repos\HyperSloop\HyperSloopApp\Pages\PersonalMetrics.razor"
       
    public string selectedTab = "Events";
    public string Email { get; set; }
    public double AverageTime
    {
        get
        {
            if (RangedEventListFiltered == null || RangedEventListFiltered.Count() == 0)
            {
                return 0;
            }
            return RangedEventListFiltered.Average(x => x.SlideDuration);
        }
    }
    public double BestTime
    {
        get
        {
            if (RangedEventListFiltered == null || RangedEventListFiltered.Count() == 0)
            {
                return 0;
            }
            return RangedEventListFiltered.Min(x => x.SlideDuration);
        }
    }
    public double WorstTime
    {
        get
        {
            if (RangedEventListFiltered == null || RangedEventListFiltered.Count() == 0)
            {
                return 0;
            }
            return RangedEventListFiltered.Max(x => x.SlideDuration);
        }
    }
    public bool ResetFilter = false;
    public bool ComparingStats = false;
    public int DurationRank
    {
        get
        {
            if (RangedEventListFiltered == null || RangedEventListFiltered.Count() == 0)
            {
                return 0;
            }
            return RangedEventListFiltered.Select(x => x.Rank).Min();
        }
        set
        {
        }
    }
    public int FilteredSlideId { get; set; }
    public string FilteredSlideName { get; set; }
    public double TotalSlideTaken
    {
        get
        {
            if (RangedEventListFiltered == null || RangedEventListFiltered.Count() == 0)
            {
                return 0;
            }
            return RangedEventListFiltered.Select(x => x.SlideId).Count();
        }
    }
    private Modal modalRef;
    IEnumerable<SlideEvent> EventsList;
    IEnumerable<SlideEvent> RangedEventList;
    IEnumerable<SlideEvent> RangedEventListFiltered;
    IEnumerable<SlideEvent> EventsListCurrentUser;
    IEnumerable<SlideEvent> EventsListComparedUser;
    public string ComparedUser { get; set; }
    public DateTime StartRange { get; set; } = DateTime.Now.Date;
    public DateTime EndRange { get; set; } = DateTime.Now.AddDays(1).Date;
    public DateRange Range { get; set; } = DateRange.Today;
    public static IEnumerable<DateRange> DateRanges { get; set; } = Enum.GetValues(typeof(DateRange)).Cast<DateRange>();

    protected override async Task OnInitializedAsync()
    {
        SetRange(Range);
    }

    private async void SetRange(DateRange range)
    {
        Range = range;
        if (range == DateRange.Today)
        {
            StartRange = DateTime.Now.Date;
            EndRange = DateTime.Now.AddDays(1).Date;
            int value = DateTime.Compare(StartRange, EndRange);
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
        else if (range == DateRange.All)
        {
            StartRange = DateTime.Now.AddYears(-10);
            EndRange = DateTime.Now.AddDays(1).Date;
        }


        Email = httpContextAccessor.HttpContext.User.Identity.Name.ToString();
        EventsList = hyperSloopService.GetUserSlideEvents().ToList();
        EventsListCurrentUser = await appservice._HyperSloopService.GetSlideEventsDataByUserId(Email);
        RangedEventList = EventsListCurrentUser.Where(x => x.StartTime >= StartRange && x.EndTime < EndRange).ToList();
        var i = 1;
        var rankedList = RangedEventList.Where(x => x.StartTime >= StartRange && x.EndTime < EndRange).OrderBy(x => x.SlideDuration).ToList();
        rankedList.ForEach(x => { x.Rank = i; i++; });
        if (FilteredSlideName != null)
        {
            rankedList = rankedList.Where(x => x.Slide.Name == FilteredSlideName).ToList();
        }
        rankedList.ForEach(x => { x.Rank = i; i++; });

        OnSlideFilterChange(FilteredSlideName);
        EventsListComparedUser = await appservice._HyperSloopService.GetComparedUserEventsByName(ComparedUser);
        Email = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Email.ToLower()).ToString().Replace("@Bngholdingsinc.Com", "").Replace(".", " ");


    }

    void OnSlideFilterChange(string currentSlideName)
    {
        if (currentSlideName == null)
        {
            RangedEventListFiltered = RangedEventList.ToList();
        }
        else
        {
            RangedEventListFiltered = RangedEventList.Where(x => x.Slide.Name == currentSlideName);
            InvokeAsync(StateHasChanged);

        }
        ResetFilter = currentSlideName != null;
        FilteredSlideName = currentSlideName;
        InvokeAsync(StateHasChanged);

    }

    void OnCompareStatsChange(object args)
    {
        ComparedUser = args.ToString();
    }

    void OnResetFilter()
    {
        RangedEventListFiltered = RangedEventList.ToList();
        var i = 1;
        ResetFilter = false;
        FilteredSlideName = null;
        //RangedEventListFiltered.ToList().ForEach(x => { x.Rank = i; i++; });
        InvokeAsync(StateHasChanged);
    }

    private void ShowCompareModal()
    {
        modalRef.Show();
    }

    private void CloseModal()
    {
        modalRef.Hide();
        ComparedUser = null;
        ComparingStats = false;
        navigationManager.NavigateTo("/personalStats", forceLoad: true);
    }

    private void OnSelectedTabChanged(string name)
    {
        selectedTab = name;
    }

    public void CompareStats(string comparedUser)
    {
        ComparedUser = comparedUser;
        ComparingStats = true;
        navigationManager.NavigateTo($"/comparedStats/{comparedUser}");
        EventsListComparedUser = EventsList.Where(x => x.User.Name == comparedUser).ToList();
    }

    void CellRender(CellRenderEventArgs<SlideEvent> args)
    {
        args.Attributes.Add("style", $"width: 50% !important");
    }

    public enum DateRange
    {
        Today,
        Week,
        Month,
        Year,
        All,
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppService appservice { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor httpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HyperSloopService hyperSloopService { get; set; }
    }
}
#pragma warning restore 1591
