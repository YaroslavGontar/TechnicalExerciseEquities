using System;
using System.Linq;
using System.Reactive.Concurrency;
using DynamicData;
using DynamicData.Binding;
using FundManagerDashboard.Core.DataServices;
using FundManagerDashboard.Core.Model;
using Microsoft.Reactive.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FundManagerDashboard.Core.UnitTest
{
    [TestClass]
    public class BaseSummaryServiceUnitTest : ReactiveTest
    {
        [TestMethod]
        [ExpectedException(typeof(NotSupportedException), "stocks or fundStocks null parametr not supported")]
        public void ConstructorNullResultException()
        {
            var target = new BaseSummaryService<long, string>(null, null, null);
        }

        [TestMethod]
        public void StocksEmptyResultTotalNumberZeroTotalMarketValueZeroTotalStockWeightZero()
        {
            var scheduler = new TestScheduler();
            var stocks = new SourceCache<Stock, long>(t => t.Id);
            var fundStocks = new SourceCache<Stock, string>(t => t.Type.ToString() + t.Id);

            var target = new BaseSummaryService<long, string>(stocks, fundStocks, scheduler);

            Assert.AreEqual(0, target.TotalMarketValue);
            Assert.AreEqual(0, target.TotalNumber);
            Assert.AreEqual(0, target.TotalStockWeight);
        }

        [TestMethod]
        public void StocksGeneratedResultTotalNumberNotZeroTotalMarketValueNotZeroTotalStockWeightNotZero()
        {
            var scheduler = new TestScheduler();

            var xs = scheduler.CreateColdObservable(
                OnNext(10, new Stock { Id = 1, Type = StockType.Equity, Price = 100, Quantity = 5 }),
                OnNext(20, new Stock { Id = 2, Type = StockType.Equity, Price = 100, Quantity = 5 }),
                OnNext(30, new Stock { Id = 1, Type = StockType.Bond, Price = 200, Quantity = 5 }),
                OnCompleted<Stock>(40)
                );

            var stocks = new SourceCache<Stock, long>(t => t.Id);
            var fundStocks = new SourceCache<Stock, string>(t => t.Type.ToString() + t.Id);

            scheduler.Schedule(TimeSpan.FromTicks(0),
                () => xs.Subscribe(s =>
                {
                    fundStocks.AddOrUpdate(s);
                    if(s.Type == StockType.Equity)
                        stocks.AddOrUpdate(s);
                }));

            var target = new BaseSummaryService<long, string>(stocks, fundStocks, scheduler);

            var observerTotalNumber = scheduler.CreateObserver<long>();
            target.WhenValueChanged(x => x.TotalNumber).Subscribe(observerTotalNumber);

            var observerTotalMarketValue = scheduler.CreateObserver<decimal>();
            target.WhenValueChanged(x => x.TotalMarketValue).Subscribe(observerTotalMarketValue);

            var observerTotalStockWeight = scheduler.CreateObserver<float>();
            target.WhenValueChanged(x => x.TotalStockWeight).Subscribe(observerTotalStockWeight);

            scheduler.Start();

            observerTotalNumber.Messages.AssertEqual(
                OnNext<long>(0, 0), 
                OnNext<long>(12, 1), 
                OnNext<long>(22, 2));

            observerTotalMarketValue.Messages.AssertEqual(
                OnNext<decimal>(0, 0), 
                OnNext<decimal>(12, 500),
                OnNext<decimal>(22, 1000));

            Assert.IsTrue(observerTotalStockWeight.Messages.Any(w => w.Value.Value == 0));
            Assert.IsTrue(observerTotalStockWeight.Messages.Any(w => w.Value.Value == 1));
            Assert.IsTrue(observerTotalStockWeight.Messages.Any(w => w.Value.Value == .5));
            Assert.IsFalse(observerTotalStockWeight.Messages.Any(w => w.Value.Value != .5 && w.Value.Value != 1 && w.Value.Value != 0));
        }

    }
}