using System.Collections.Generic;
using System.Reactive;
using FundManagerDashboard.Core.Model;
using ReactiveUI;

namespace FundManagerDashboard.Core.ViewModels
{
    public interface IAddItemViewModel
    {
        ReactiveCommand<Unit> AddCommand { get; }
        StockType StockType { get; set; }
        IEnumerable<StockType> StockTypes { get; }
        decimal? StockPrice { get; set; }
        int? StockQuantity { get; set; }
    }
}