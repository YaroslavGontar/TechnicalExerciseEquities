using System;
using System.Reactive.Linq;
using System.Windows.Controls;
using FundManagerDashboard.Core.ViewModels;
using ReactiveUI;

namespace FundManagerDashboard.Client.Desktop.View
{
    /// <summary>
    /// Interaction logic for StockListView.xaml
    /// </summary>
    public partial class StockListView : UserControl, IViewFor<IStockListViewModel>
    {
        public StockListView()
        {
            InitializeComponent();

            this.WhenAnyValue(x => x.ViewModel).Subscribe(x => DataContext = x);

            this.WhenAnyValue(x => x.ViewModel)
                .Where(x => x != null)
                .Subscribe(x => mainStockGrid.ItemsSource = x.Data);
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (IStockListViewModel)value; }
        }

        public IStockListViewModel ViewModel { get; set; }
    }
}
