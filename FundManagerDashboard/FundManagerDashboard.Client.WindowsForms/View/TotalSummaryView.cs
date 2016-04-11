using System;
using System.Drawing;
using System.Linq;
using System.Reactive.Linq;
using System.Windows.Forms;
using BrightIdeasSoftware;
using FundManagerDashboard.Core.ViewModels;
using ReactiveUI;
using ReactiveUI.Winforms;

namespace FundManagerDashboard.Client.WindowsForms.View
{
    public partial class TotalSummaryView : UserControl, IViewFor<ITotalSummaryViewModel>
    {
        public TotalSummaryView()
        {
            InitializeComponent();

            this.WhenAnyValue(x => x.ViewModel)
                .Where(x => x != null)
                .ObserveOn(RxApp.MainThreadScheduler)
                .Subscribe(x =>
                {
                    x.Data.ToList()
                        .ForEach(vm => flowSummaryPanel.Controls.Add(new SummaryTemplateView {ViewModel = vm}));
                });
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (ITotalSummaryViewModel)value; }
        }

        public ITotalSummaryViewModel ViewModel { get; set; }
    }
}
