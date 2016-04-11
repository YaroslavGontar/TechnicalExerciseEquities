namespace FundManagerDashboard.Core.DataServices
{
    public interface ITotalSummaryService
    {
        long TotalNumber { get; set; }

        decimal TotalMarketValue { get; set; }

        float TotalStockWeight { get; set; }
    }
}