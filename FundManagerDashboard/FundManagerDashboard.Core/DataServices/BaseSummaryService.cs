using System;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using DynamicData;
using DynamicData.Aggregation;
using FundManagerDashboard.Core.Model;
using ReactiveUI;

namespace FundManagerDashboard.Core.DataServices
{
    public class BaseSummaryService<T, TK> : ReactiveObject, ITotalSummaryService
    {
        public BaseSummaryService(IObservableCache<Stock, T> stocks, IObservableCache<Stock, TK> fundStocks, IScheduler scheduler)
        {
            if (stocks == null || fundStocks == null)
                throw new NotSupportedException("stocks or fundStocks null parametr not supported");

            var all = stocks.Connect();
             
            Observable.ObserveOn(all.Count(), scheduler).Subscribe(x => TotalNumber = x);

            Observable.ObserveOn(all.Sum(x => new StockProxy(x).MarketValue), scheduler).Subscribe(x => TotalMarketValue = x);

            Observable.ObserveOn(fundStocks.Connect().Sum(x => new StockProxy(x).MarketValue), scheduler).Subscribe(x =>
            {
                TotalStockWeight = all.Sum(item => new StockProxy(item) {TotalMarketValue = x}.StockWeight).ToProperty(this, item=>item.TotalStockWeight).Value;
            });
        }

        long _totalNumber;
        public long TotalNumber
        {
            get { return _totalNumber; }
            set { this.RaiseAndSetIfChanged(ref _totalNumber, value); }
        }

        decimal _totalMarketValue;
        public decimal TotalMarketValue
        {
            get { return _totalMarketValue; }
            set { this.RaiseAndSetIfChanged(ref _totalMarketValue, value); }
        }

        float _totalStockWeight;
        public float TotalStockWeight
        {
            get { return _totalStockWeight; }
            set { this.RaiseAndSetIfChanged(ref _totalStockWeight, value); }
        }
    }
}