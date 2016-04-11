using System.Threading;
using DynamicData;
using FundManagerDashboard.Core.Model;
using ReactiveUI;

namespace FundManagerDashboard.Core.DataServices
{
    public class LocalInMemoryStockService : ReactiveObject, IStockService
    {
        private readonly ISourceCache<Stock, string> _stocksSource;
        IObservableCache<Stock, string> _all;
        IObservableCache<Stock, long> _equity;
        IObservableCache<Stock, long> _bond;

        public LocalInMemoryStockService()
        {
            _lastBondId = 0;
            _lastEquityId = 0;
            _stocksSource = new SourceCache<Stock, string>(stock => stock.Type.ToString() + stock.Id.ToString());

            _all = _stocksSource.AsObservableCache();
            
            _equity = _stocksSource.Connect(stock => stock.Type == StockType.Equity)
                .ToObservableChangeSet(key => key.Current.Id)
                .Transform(selector => selector.Current)
                .AsObservableCache();

            _bond = _stocksSource.Connect(stock => stock.Type == StockType.Bond)
                .ToObservableChangeSet(key => key.Current.Id)
                .Transform(selector => selector.Current)
                .AsObservableCache();
        }

        public IObservableCache<Stock, string> All => _all;
        public IObservableCache<Stock, long> Equity => _equity;
        public IObservableCache<Stock, long> Bond => _bond;

        public void AddStock(StockType type, decimal price, int quantity)
        {
            var id = type == StockType.Equity
                ? Interlocked.Increment(ref _lastEquityId)
                : Interlocked.Increment(ref _lastBondId);
            _stocksSource.AddOrUpdate(new Stock() { Id = id, Type = type, Price = price, Quantity = quantity });
        }

        private long _lastBondId;
        private long _lastEquityId;

        decimal _stockTotalMarket;
        public decimal TotalMarketValue
        {
            get { return _stockTotalMarket; }
            set { this.RaiseAndSetIfChanged(ref _stockTotalMarket, value); }
        }
    }
}