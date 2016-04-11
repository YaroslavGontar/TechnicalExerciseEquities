using FundManagerDashboard.Core.DataServices;
using ReactiveUI;

namespace FundManagerDashboard.Core.ViewModels
{
    public class SummaryTemplateViewModel : ReactiveObject, ISummaryTemplateViewModel
    {
        public SummaryTemplateViewModel(string summaryName, ITotalSummaryService servie)
        {
            Title = summaryName;

            _totalNumber = servie.WhenAny(x => x.TotalNumber, change => change.Value)
                .ToProperty(this, modelView => modelView.TotalNumber);

            _totalMarketValue = servie.WhenAny(x => x.TotalMarketValue, change => change.Value)
                .ToProperty(this, modelView => modelView.TotalMarketValue);

            _totalStockWeight = servie.WhenAny(x => x.TotalStockWeight, change => change.Value)
                .ToProperty(this, modelView => modelView.TotalStockWeight);
        }

        public string Title { get; private set; }

        readonly private ObservableAsPropertyHelper<long> _totalNumber;
        readonly private ObservableAsPropertyHelper<decimal> _totalMarketValue;
        readonly private ObservableAsPropertyHelper<float> _totalStockWeight;

        public long TotalNumber => _totalNumber.Value;

        public decimal TotalMarketValue => _totalMarketValue.Value;

        public float TotalStockWeight => _totalStockWeight.Value;
    }
}