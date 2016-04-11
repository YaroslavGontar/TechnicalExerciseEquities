using System;
using System.Reactive.Linq;
using System.Windows.Controls;
using FundManagerDashboard.Core.ViewModels;
using ReactiveUI;

namespace FundManagerDashboard.Client.Desktop.View
{
    /// <summary>
    /// Interaction logic for TotalSummaryView.xaml
    /// </summary>
    public partial class TotalSummaryView : UserControl, IViewFor<ITotalSummaryViewModel>
    {
        public TotalSummaryView()
        {
            InitializeComponent();

            this.WhenAnyValue(x => x.ViewModel).Subscribe(x => DataContext = x);

            this.WhenAnyValue(x => x.ViewModel)
                .Where(x => x != null)
                .Subscribe(x => summaryList.ItemsSource = x.Data);
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (ITotalSummaryViewModel)value; }
        }

        public ITotalSummaryViewModel ViewModel { get; set; }
    }
}
