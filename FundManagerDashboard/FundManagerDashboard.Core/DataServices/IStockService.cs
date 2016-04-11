using DynamicData;
using FundManagerDashboard.Core.Model;

namespace FundManagerDashboard.Core.DataServices
{
    public interface IStockService
    {
        IObservableCache<Stock, string> All { get; }
        IObservableCache<Stock, long> Equity { get; }
        IObservableCache<Stock, long> Bond { get; }

        void AddStock(StockType type, decimal price, int quantity);
    }
}
