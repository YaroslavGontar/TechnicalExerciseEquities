using System;
using System.Collections.ObjectModel;
using System.Reactive.Linq;
using DynamicData;
using FundManagerDashboard.Core.DataServices;
using FundManagerDashboard.Core.Model;
using ReactiveUI;

namespace FundManagerDashboard.Core.ViewModels
{
    public class StockListViewModel : ReactiveObject, IRoutableViewModel, IStockListViewModel
    {
        public StockListViewModel(IScreen hostScreen, IStockService service, ITotalSummaryService summaryService)
        {
            Observable.ObserveOn(
                service.All.Connect()
                    .Transform(stock => new StockProxy(stock) {TotalMarketValue = summaryService.TotalMarketValue}),
                RxApp.MainThreadScheduler).Bind(out _data).DisposeMany().Subscribe();

            Observable.ObserveOn(summaryService.ObservableForProperty(x => x.TotalMarketValue), RxApp.MainThreadScheduler).Subscribe(x =>
            {
                foreach (var stockProxy in Data)
                {
                    stockProxy.TotalMarketValue = x.Value;
                }
            });

            HostScreen = hostScreen;
        }

        private readonly ReadOnlyObservableCollection<StockProxy> _data;

        public ReadOnlyObservableCollection<StockProxy> Data => _data;

        public string UrlPathSegment => "ListView";
        public IScreen HostScreen { get; private set; }
    }
}