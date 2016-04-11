using System;
using System.Reactive.Linq;
using ReactiveUI;

namespace FundManagerDashboard.Core.Model
{
    public class StockProxy : ReactiveObject
    {
        private decimal _transactionCostEquityCoeff = (decimal) 0.005;
        private decimal _transactionCostBondCoeff = (decimal)0.02;

        private decimal _toleranceEquityCoeff = 200000;
        private decimal _toleranceBondCoeff = 100000;

        public StockProxy(Stock stock)
        {
            if (stock == null) throw new NotSupportedException("Stock null parametr not supported");

            Type = stock.Type;
            Name = stock.Type.ToString() + stock.Id;
            Price = stock.Price;
            Quantity = stock.Quantity;
            TotalMarketValue = MarketValue;

            this.WhenAnyValue(x => x.TotalMarketValue).Where(x=>x != 0).Subscribe(x => StockWeight = (float) (MarketValue/x));
        }

        public StockType Type { get; private set; }

        public string Name { get; private set; }

        public decimal Price { get; private set; }

        public int Quantity { get; private set; }

        public decimal MarketValue => Price*Quantity;

        public decimal TransactionCost => Type == StockType.Equity
            ? MarketValue*_transactionCostEquityCoeff
            : MarketValue*_transactionCostBondCoeff;

        float _stockWeight;
        public float StockWeight
        {
            get { return _stockWeight; }
            set { this.RaiseAndSetIfChanged(ref _stockWeight, value); }
        }

        decimal _totalMarketValue;

        public decimal TotalMarketValue
        {
            get { return _totalMarketValue; }
            set { this.RaiseAndSetIfChanged(ref _totalMarketValue, value); }
        }

        public bool Highlight => MarketValue < 0 || TransactionCost > Tolerance;

        private decimal Tolerance => Type == StockType.Bond ? _toleranceBondCoeff : _toleranceEquityCoeff;
    }
}