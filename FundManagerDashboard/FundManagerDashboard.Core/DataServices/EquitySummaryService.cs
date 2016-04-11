using ReactiveUI;

namespace FundManagerDashboard.Core.DataServices
{
    public class EquitySummaryService : BaseSummaryService<long, string>, ITotalSummaryService
    {
        public EquitySummaryService(IStockService service) : base(service.Equity, service.All, RxApp.MainThreadScheduler)
        {
        }
    }
}