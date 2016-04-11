using System.Windows.Forms;
using FundManagerDashboard.Core.ViewModels;
using ReactiveUI;

namespace FundManagerDashboard.Client.WindowsForms.View
{
    public partial class ShellView : UserControl, IViewFor<IShellViewModel>
    {
        public ShellView()
        {
            InitializeComponent();

            this.Bind(ViewModel, vm => vm.AddItemViewModel, v => v.AddPanel.ViewModel);
            this.Bind(ViewModel, vm => vm.StockListViewModel, v => v.StocksList.ViewModel);
            this.Bind(ViewModel, vm => vm.TotalSummaryViewModel, v => v.FundSummary.ViewModel);
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (IShellViewModel)value; }
        }

        public IShellViewModel ViewModel { get; set; }
    }
}
