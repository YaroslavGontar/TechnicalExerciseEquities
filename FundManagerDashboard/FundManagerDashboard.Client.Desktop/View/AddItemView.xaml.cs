using System;
using System.Reactive.Linq;
using System.Windows.Controls;
using FundManagerDashboard.Core.ViewModels;
using ReactiveUI;

namespace FundManagerDashboard.Client.Desktop.View
{
    /// <summary>
    /// Interaction logic for AddItemView.xaml
    /// </summary>
    public partial class AddItemView : UserControl, IViewFor<IAddItemViewModel>
    {
        public AddItemView()
        {
            InitializeComponent();

            this.WhenAnyValue(x => x.ViewModel).Subscribe(x => DataContext = x);

            this.WhenAnyValue(x => x.ViewModel)
                .Where(x => x != null)
                .Subscribe(x => StockType.ItemsSource = x.StockTypes);

            this.Bind(ViewModel, vm => vm.StockType, v => v.StockType.SelectedValue);
            this.Bind(ViewModel, vm => vm.StockPrice, v => v.StockPrice.Value);
            this.Bind(ViewModel, vm => vm.StockQuantity, v => v.StockQuantity.Value);

            this.BindCommand(ViewModel, vm => vm.AddCommand, v => v.Add);
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (IAddItemViewModel) value; }
        }

        public IAddItemViewModel ViewModel { get; set; }
    }
}
