using ReactiveUI;

namespace FundManagerDashboard.Core.DataServices
{
    public class BondSummaryService : BaseSummaryService<long, string>, ITotalSummaryService
    {
        public BondSummaryService(IStockService service) : base(service.Bond, service.All, RxApp.MainThreadScheduler)
        {
        }
    }
}