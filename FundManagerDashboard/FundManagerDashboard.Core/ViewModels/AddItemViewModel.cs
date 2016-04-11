using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Threading.Tasks;
using FundManagerDashboard.Core.DataServices;
using FundManagerDashboard.Core.Model;
using ReactiveUI;

namespace FundManagerDashboard.Core.ViewModels
{
    public class AddItemViewModel : ReactiveObject, IRoutableViewModel, IAddItemViewModel
    {
        public AddItemViewModel(IScreen hostScreen, IStockService stockService)
        {
            var canAdd = this.WhenAny(x => x.StockPrice, x => x.StockQuantity,
                (price, qty) => price.Value != null && qty.Value != null && qty.Value > 0);
            AddCommand = ReactiveCommand.CreateAsyncObservable(canAdd,
                _ =>
                    Observable.FromAsync(
                        async () =>
                            await
                                Task.Run(() => stockService.AddStock(StockType, StockPrice.Value, StockQuantity.Value))));
            Observable.ObserveOn(AddCommand, RxApp.MainThreadScheduler).Subscribe(res => Reset());

            HostScreen = hostScreen;
        }

        private void Reset()
        {
            StockType = StockType.Equity;
            StockPrice = null;
            StockQuantity = null;
        }

        public ReactiveCommand<Unit> AddCommand { get; private set; }

        StockType _stockType;
        public StockType StockType
        {
            get { return _stockType; }
            set { this.RaiseAndSetIfChanged(ref _stockType, value); }
        }

        public IEnumerable<StockType> StockTypes => Enum.GetValues(typeof (StockType)).Cast<StockType>();

        decimal? _stockPrice;
        public decimal? StockPrice
        {
            get { return _stockPrice; }
            set { this.RaiseAndSetIfChanged(ref _stockPrice, value); }
        }

        int? _stockQuantity;
        public int? StockQuantity
        {
            get { return _stockQuantity; }
            set { this.RaiseAndSetIfChanged(ref _stockQuantity, value); }
        }

        public string UrlPathSegment => "ItemView";
        public IScreen HostScreen { get; private set; }
    }
}