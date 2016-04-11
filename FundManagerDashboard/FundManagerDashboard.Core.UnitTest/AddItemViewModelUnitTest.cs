using System.Linq;
using FundManagerDashboard.Core.DataServices;
using FundManagerDashboard.Core.Model;
using FundManagerDashboard.Core.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ReactiveUI;

namespace FundManagerDashboard.Core.UnitTest
{
    [TestClass]
    public class AddItemViewModelUnitTest
    {
        [TestMethod]
        public void AddCommandCanExecuteStockPriceNullStockQuantityNullResultFalse()
        {
            var target = new AddItemViewModel(null, null);
            var actual = target.AddCommand.CanExecute(null);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void AddCommandCanExecuteStockPriceNotNullStockQuantityNullResultFalse()
        {
            var target = new AddItemViewModel(null, null) {StockPrice = 10};
            var actual = target.AddCommand.CanExecute(null);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void AddCommandCanExecuteStockPriceNotNullStockQuantityZeroResultFalse()
        {
            var target = new AddItemViewModel(null, null) {StockPrice = 10, StockQuantity = 0};
            var actual = target.AddCommand.CanExecute(null);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void AddCommandCanExecuteStockPriceNotNullStockQuantityHigherThenZeroResultTrue()
        {
            var target = new AddItemViewModel(null, null) { StockPrice = 10, StockQuantity = 5 };
            var actual = target.AddCommand.CanExecute(null);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void AddCommandExecuteStockPriceNotNullStockQuantityHigherThenZeroResultServiceAddStockCalled()
        {
            var service = new Mock<IStockService>();
            var actualType = StockType.Bond;
            decimal actualPrice = 0;
            int actualQuantity = 0;
            service.Setup(s => s.AddStock(It.IsAny<StockType>(), It.IsAny<decimal>(), It.IsAny<int>()))
                .Callback<StockType, decimal, int>(
                    (type, price, quantity) =>
                    {
                        actualType = type;
                        actualPrice = price;
                        actualQuantity = quantity;
                    });

            var target = new AddItemViewModel(null, service.Object) { StockPrice = 10, StockQuantity = 5, StockType = StockType.Equity};
            target.AddCommand.ExecuteAsyncTask().GetAwaiter().GetResult();

            Assert.AreEqual(10, actualPrice);
            Assert.AreEqual(StockType.Equity, actualType);
            Assert.AreEqual(5, actualQuantity);

            service.VerifyAll();
        }

        [TestMethod]
        public void GetStockTypesResultTwoStockType()
        {
            var target = new AddItemViewModel(null, null);
            var actual = target.StockTypes;

            Assert.IsNotNull(actual);
            var actualList = actual.ToList();
            Assert.AreEqual(2, actualList.Count);
            Assert.IsTrue(actualList.Contains(StockType.Equity));
            Assert.IsTrue(actualList.Contains(StockType.Bond));
        }

        [TestMethod]
        public void HostScreenResultSeted()
        {
            var hostScreen = new Mock<IScreen>();
            var target = new AddItemViewModel(hostScreen.Object, null);
            var actual = target.HostScreen;

            Assert.IsNotNull(actual);
            Assert.IsInstanceOfType(actual, typeof(IScreen));
        }

        [TestMethod]
        public void GetUrlPathSegmentResultItemViewText()
        {
            var target = new AddItemViewModel(null, null);
            var actual = target.UrlPathSegment;

            Assert.IsNotNull(actual);
            Assert.AreEqual("ItemView", actual);
        }
    }
}