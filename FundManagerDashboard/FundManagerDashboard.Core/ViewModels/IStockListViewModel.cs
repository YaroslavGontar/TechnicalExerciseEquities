using System.Collections.ObjectModel;
using FundManagerDashboard.Core.Model;

namespace FundManagerDashboard.Core.ViewModels
{
    public interface IStockListViewModel
    {
        ReadOnlyObservableCollection<StockProxy> Data { get; }
    }
}