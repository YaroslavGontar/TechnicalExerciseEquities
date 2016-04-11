using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reactive.Linq;
using System.Windows.Forms;
using BrightIdeasSoftware;
using FundManagerDashboard.Core.Model;
using FundManagerDashboard.Core.ViewModels;
using ReactiveUI;
using ReactiveUI.Winforms;

namespace FundManagerDashboard.Client.WindowsForms.View
{
    public partial class StockListView : UserControl, IViewFor<IStockListViewModel>
    {
        public StockListView()
        {
            InitializeComponent();
            var resDict = new Dictionary<string, string>
            {
                {"Type", "ListHeaderType"},
                {"Name", "ListHeaderName"},
                {"Price", "ListHeaderPrice"},
                {"Quantity", "ListHeaderQuantity"},
                {"MarketValue", "ListHeaderMarketValue"},
                {"TransactionCost", "ListHeaderTransactionCost"},
                {"StockWeight", "ListHeaderStockWeight"}
            };

            MainStockGrid.AllColumns.ForEach(
                c =>
                    c.Text =
                        resDict.ContainsKey(c.AspectName)
                            ? Core.Properties.Resources.ResourceManager.GetString(resDict[c.AspectName])
                            : c.AspectName);

            MainStockGrid.RebuildColumns();

            this.WhenAnyValue(x => x.ViewModel)
                .Where(x => x != null)
                .ObserveOn(RxApp.MainThreadScheduler)
                .Subscribe(x =>
                {
                    MainStockGrid.DataSource = x.Data.CreateDerivedBindingList(b => b);
                });

            Observable.FromEventPattern<EventHandler<FormatCellEventArgs>, FormatCellEventArgs>(handler => handler.Invoke,
                h => MainStockGrid.FormatCell += h, h => MainStockGrid.FormatCell -= h)
                .Where(x => x.EventArgs.Column.AspectName == "Name")
                .Subscribe(x =>
                {
                    var stock = (StockProxy)x.EventArgs.Model;
                    if (stock.Highlight)
                        x.EventArgs.SubItem.ForeColor = Color.Red;
                });
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (IStockListViewModel)value; }
        }

        public IStockListViewModel ViewModel { get; set; }
    }
}
