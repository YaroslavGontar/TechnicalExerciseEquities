namespace FundManagerDashboard.Core.ViewModels
{
    public interface ISummaryTemplateViewModel
    {
        string Title { get; }
        long TotalNumber { get; }
        decimal TotalMarketValue { get; }
        float TotalStockWeight { get; }
    }
}