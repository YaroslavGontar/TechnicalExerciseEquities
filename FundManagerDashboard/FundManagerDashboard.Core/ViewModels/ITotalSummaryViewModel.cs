using System.Collections.Generic;
using System.Collections.ObjectModel;
using FundManagerDashboard.Core.DataServices;

namespace FundManagerDashboard.Core.ViewModels
{
    public interface ITotalSummaryViewModel
    {
        ReadOnlyObservableCollection<SummaryTemplateViewModel> Data { get; }
    }
}