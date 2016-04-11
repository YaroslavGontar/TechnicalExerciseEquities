using System;
using FundManagerDashboard.Core.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FundManagerDashboard.Core.UnitTest
{
    [TestClass]
    public class StockProxyUnitTest
    {
        [TestMethod]
        [ExpectedException(typeof(NotSupportedException), "Stock null parametr not supported")]
        public void ConstructorNullResultException()
        {
            var target = new StockProxy(null);
        }

        [TestMethod]
        public void ConstructorStockNotNullResultStockProxyFilledFromStock()
        {
            var stock = new Stock {Type = StockType.Bond, Id = 10, Price = 1000, Quantity = 10};

            var target = new StockProxy(stock);

            Assert.AreEqual(StockType.Bond, target.Type);
            Assert.AreEqual("Bond10", target.Name);
            Assert.AreEqual(1000, target.Price);
            Assert.AreEqual(10, target.Quantity);
            Assert.AreEqual(10000, target.MarketValue);
            Assert.AreEqual(10000, target.TotalMarketValue);
            Assert.AreEqual((decimal)(10000*0.02), target.TransactionCost);
            Assert.AreEqual(1, target.StockWeight);
        }

        [TestMethod]
        public void CheckBondTransactionCostCoefResult0_02()
        {
            var stock = new Stock { Type = StockType.Bond, Id = 10, Price = 1000, Quantity = 10 };

            var target = new StockProxy(stock);

            var coef = target.TransactionCost/target.TotalMarketValue;
            Assert.AreEqual((decimal)0.02, coef);
        }

        [TestMethod]
        public void CheckEquityTransactionCostCoefResult0_005()
        {
            var stock = new Stock { Type = StockType.Equity, Id = 10, Price = 1000, Quantity = 10 };

            var target = new StockProxy(stock);

            var coef = target.TransactionCost / target.TotalMarketValue;
            Assert.AreEqual((decimal)0.005, coef);
        }

        [TestMethod]
        public void TotalMarketValueSetZeroResultStockWeightNotChanged()
        {
            var stock = new Stock { Type = StockType.Equity, Id = 10, Price = 1000, Quantity = 10 };

            var target = new StockProxy(stock);

            Assert.AreEqual(1, target.StockWeight);
            target.TotalMarketValue = 0;
            Assert.AreEqual(1, target.StockWeight);
        }

        [TestMethod]
        public void TotalMarketValueSet20000ResultStockWeight0_5()
        {
            var stock = new Stock { Type = StockType.Equity, Id = 10, Price = 1000, Quantity = 10 };

            var target = new StockProxy(stock);

            Assert.AreEqual(1, target.StockWeight);
            target.TotalMarketValue = 20000;
            Assert.AreEqual(0.5, target.StockWeight);
        }

        [TestMethod]
        public void MarketValueLessZeroResultHighlightTrue()
        {
            var stock = new Stock { Type = StockType.Equity, Id = 10, Price = -1000, Quantity = 10 };

            var target = new StockProxy(stock);

            Assert.IsTrue(target.Highlight);
        }

        [TestMethod]
        public void NormalObjectResultHighlightFalse()
        {
            var stock = new Stock { Type = StockType.Equity, Id = 10, Price = 1000, Quantity = 10 };

            var target = new StockProxy(stock);

            Assert.IsFalse(target.Highlight);
        }

        [TestMethod]
        public void EquityTransactionCostGreatToleranceResultHighlightTrue()
        {
            var stock = new Stock { Type = StockType.Equity, Id = 10, Price = (decimal)(20000/ 0.005), Quantity = 11 };

            var target = new StockProxy(stock);

            Assert.IsTrue(target.Highlight);
        }

        [TestMethod]
        public void BondTransactionCostGreatToleranceResultHighlightTrue()
        {
            var stock = new Stock { Type = StockType.Bond, Id = 10, Price = (decimal)(10000 / 0.02), Quantity = 11 };

            var target = new StockProxy(stock);

            Assert.IsTrue(target.Highlight);
        }
    }
}