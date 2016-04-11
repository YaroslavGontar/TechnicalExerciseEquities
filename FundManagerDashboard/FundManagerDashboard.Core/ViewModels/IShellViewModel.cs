namespace FundManagerDashboard.Core.ViewModels
{
    public interface IShellViewModel
    {
        IAddItemViewModel AddItemViewModel { get; set; }
        IStockListViewModel StockListViewModel { get; set; }
        ITotalSummaryViewModel TotalSummaryViewModel { get; set; }
    }
}