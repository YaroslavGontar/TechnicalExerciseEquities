using ReactiveUI;

namespace FundManagerDashboard.Core.DataServices
{
    public class FundSummaryService : BaseSummaryService<string, string>, ITotalSummaryService
    {
        public FundSummaryService(IStockService service) : base(service.All, service.All, RxApp.MainThreadScheduler)
        {
        }
    }
}