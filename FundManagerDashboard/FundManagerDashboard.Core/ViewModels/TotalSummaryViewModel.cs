using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive.Linq;
using DynamicData;
using FundManagerDashboard.Core.DataServices;
using ReactiveUI;

namespace FundManagerDashboard.Core.ViewModels
{
    public class TotalSummaryViewModel : ReactiveObject, IRoutableViewModel, ITotalSummaryViewModel
    {
        public TotalSummaryViewModel(IScreen hostScreen, ITotalSummaryService fundSummaryService, ITotalSummaryService equitySummaryService, ITotalSummaryService bondSummaryService)
        {
            var myList = new SourceList<SummaryTemplateViewModel>();
            myList.Add(new SummaryTemplateViewModel("Equity", equitySummaryService));
            myList.Add(new SummaryTemplateViewModel("Bond", bondSummaryService));
            myList.Add(new SummaryTemplateViewModel("Fund", fundSummaryService));

            Observable.ObserveOn(myList.Connect(), RxApp.MainThreadScheduler).Bind(out _data).DisposeMany().Subscribe();

            HostScreen = hostScreen;
        }

        private readonly ReadOnlyObservableCollection<SummaryTemplateViewModel> _data;

        public ReadOnlyObservableCollection<SummaryTemplateViewModel> Data => _data;

        public string UrlPathSegment => "SummaryView";
        public IScreen HostScreen { get; private set; }
    }
}