using ReactiveUI;

namespace FundManagerDashboard.Core.ViewModels
{
    public class ShellViewModel: ReactiveObject, IRoutableViewModel, IShellViewModel
    {
        public ShellViewModel(IScreen hostScreen, IAddItemViewModel addItemViewModel, IStockListViewModel stockListViewModel, ITotalSummaryViewModel totalSummaryViewModel)
        {
            HostScreen = hostScreen;

            AddItemViewModel = addItemViewModel;
            StockListViewModel = stockListViewModel;
            TotalSummaryViewModel = totalSummaryViewModel;
        }

        private IAddItemViewModel _addItemViewModel;

        public IAddItemViewModel AddItemViewModel
        {
            get { return _addItemViewModel; }
            set { this.RaiseAndSetIfChanged(ref _addItemViewModel, value); }
        }

        IStockListViewModel _stockListViewModel;
        public IStockListViewModel StockListViewModel
        {
            get { return _stockListViewModel; }
            set { this.RaiseAndSetIfChanged(ref _stockListViewModel, value); }
        }

        ITotalSummaryViewModel _totalSummaryViewModel;
        public ITotalSummaryViewModel TotalSummaryViewModel
        {
            get { return _totalSummaryViewModel; }
            set { this.RaiseAndSetIfChanged(ref _totalSummaryViewModel, value); }
        }

        public string UrlPathSegment => "ShellPage";
        public IScreen HostScreen { get; private set; }
    }
}
