using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reactive.Linq;
using System.Windows.Forms;
using FundManagerDashboard.Core.Model;
using FundManagerDashboard.Core.ViewModels;
using ReactiveUI;

namespace FundManagerDashboard.Client.WindowsForms.View
{
    public partial class AddItemView : UserControl, IViewFor<IAddItemViewModel>
    {
        public AddItemView()
        {
            InitializeComponent();

            PanelHeader.Text = Core.Properties.Resources.AddPanelHeader;
            PanelAdd.Text = Core.Properties.Resources.AddPanelAdd;
            PanelStockType.Text = Core.Properties.Resources.AddPanelStockType;
            PanelStockPrice.Text = Core.Properties.Resources.AddPanelStockPrice;
            PanelStockQuantity.Text = Core.Properties.Resources.AddPanelStockQuantity;

            this.WhenAnyValue(x => x.ViewModel)
                .Where(x => x != null)
                .Subscribe(x =>stockType.DataSource = x.StockTypes);

            //Make Watermark on standart TexBox
            Observable.FromEventPattern<EventHandler, EventArgs>(handler => handler.Invoke,
                h => stockPrice.Enter += h, h => stockPrice.Enter -= h)
                .ObserveOn(RxApp.MainThreadScheduler)
                .Subscribe(x =>
                {
                    if (stockPrice.Text == Core.Properties.Resources.AddPanelStockPriceWaterMark)
                    {
                        stockPrice.Text = "";
                        stockPrice.ForeColor = SystemColors.WindowText;
                    }
                    else
                    {
                        if (ViewModel.StockPrice.HasValue)
                            stockPrice.Text = ViewModel.StockPrice.Value.ToString();
                    }
                });

            Observable.FromEventPattern<EventHandler, EventArgs>(handler => handler.Invoke,
                h => stockPrice.Leave += h, h => stockPrice.Leave -= h)
                .ObserveOn(RxApp.MainThreadScheduler)
                .Subscribe(x =>
                {
                    if (string.IsNullOrEmpty(stockPrice.Text))
                    {
                        stockPrice.Text = Core.Properties.Resources.AddPanelStockPriceWaterMark;
                        stockPrice.ForeColor = SystemColors.GrayText;
                    }
                    else
                    {
                        if (ViewModel.StockPrice.HasValue)
                            stockPrice.Text = ViewModel.StockPrice.Value.ToString("C");
                    }
                });

            this.WhenAnyValue(x => x.ViewModel.StockPrice).ObserveOn(RxApp.MainThreadScheduler).Subscribe(x =>
            {
                if(stockPrice.Focused) return;
                if (x != null)
                {
                    stockPrice.ForeColor = SystemColors.WindowText;
                    return;
                }
                stockPrice.Text = Core.Properties.Resources.AddPanelStockPriceWaterMark;
                stockPrice.ForeColor = SystemColors.GrayText;
            });

            Observable.FromEventPattern<EventHandler, EventArgs>(handler => handler.Invoke,
                h => stockQuantity.Enter += h, h => stockQuantity.Enter -= h)
                .ObserveOn(RxApp.MainThreadScheduler)
                .Subscribe(x =>
                {
                    if (stockQuantity.Text == Core.Properties.Resources.AddPanelStockQuantityWaterMark)
                    {
                        stockQuantity.Text = "";
                        stockQuantity.ForeColor = SystemColors.WindowText;
                    }
                });

            Observable.FromEventPattern<EventHandler, EventArgs>(handler => handler.Invoke,
                h => stockQuantity.Leave += h, h => stockQuantity.Leave -= h)
                .ObserveOn(RxApp.MainThreadScheduler)
                .Subscribe(x =>
                {
                    if (string.IsNullOrEmpty(stockQuantity.Text))
                    {
                        stockQuantity.Text = Core.Properties.Resources.AddPanelStockQuantityWaterMark;
                        stockQuantity.ForeColor = SystemColors.GrayText;
                    }
                });

            this.WhenAnyValue(x => x.ViewModel.StockQuantity).ObserveOn(RxApp.MainThreadScheduler).Subscribe(x =>
            {
                if (stockQuantity.Focused) return;
                if (x != null)
                {
                    stockQuantity.ForeColor = SystemColors.WindowText;
                    return;
                }
                stockQuantity.Text = Core.Properties.Resources.AddPanelStockQuantityWaterMark;
                stockQuantity.ForeColor = SystemColors.GrayText;
            });
            // ----------------

            this.WhenAnyValue(x => x.ViewModel.StockType)
                .ObserveOn(RxApp.MainThreadScheduler)
                .Subscribe(x =>
                {
                    stockType.SelectedIndex = ViewModel.StockTypes.ToList().IndexOf(x);
                });

            this.WhenAnyValue(x => x.stockType.SelectedValue)
                .Where(x => x != null)
                .ObserveOn(RxApp.MainThreadScheduler)
                .Subscribe(x =>
                {
                    if (ViewModel != null) ViewModel.StockType = (StockType) x;
                });

            this.Bind(ViewModel, vm => vm.StockPrice, v => v.stockPrice.Text);
            this.Bind(ViewModel, vm => vm.StockQuantity, v => v.stockQuantity.Text);

            this.BindCommand(ViewModel, vm => vm.AddCommand, v => v.PanelAdd);
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (IAddItemViewModel)value; }
        }

        public IAddItemViewModel ViewModel { get; set; }
    }
}
