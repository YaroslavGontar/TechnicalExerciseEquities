using System.Windows.Forms;
using FundManagerDashboard.Core.ViewModels;
using ReactiveUI;

namespace FundManagerDashboard.Client.WindowsForms.View
{
    public partial class SummaryTemplateView : UserControl, IViewFor<ISummaryTemplateViewModel>
    {
        public SummaryTemplateView()
        {
            InitializeComponent();

            titleText.Text = Core.Properties.Resources.SummaryHeader;
            summaryTotalNumber.Text = Core.Properties.Resources.SummaryTotalNumber;
            summaryTotalMarketValue.Text = Core.Properties.Resources.SummaryTotalMarketValue;
            summaryTotalStockWeight.Text = Core.Properties.Resources.SummaryTotalStockWeight;

            this.OneWayBind(ViewModel, vm => vm.Title, v => v.titleName.Text);
            this.OneWayBind(ViewModel, vm => vm.TotalNumber, v => v.totalNumber.Text);
            this.OneWayBind(ViewModel, vm => vm.TotalMarketValue, v => v.totalMarketValue.Text, val => val.ToString("C"));
            this.OneWayBind(ViewModel, vm => vm.TotalStockWeight, v => v.totalStockWeight.Text, val => val.ToString("P"));

            Dock = DockStyle.Fill;
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (ISummaryTemplateViewModel)value; }
        }

        public ISummaryTemplateViewModel ViewModel { get; set; }
    }
}
