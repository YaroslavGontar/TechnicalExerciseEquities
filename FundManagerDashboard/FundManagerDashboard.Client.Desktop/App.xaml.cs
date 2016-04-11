using System.Windows;
using FundManagerDashboard.Client.Desktop.View;
using FundManagerDashboard.Core;
using FundManagerDashboard.Core.ViewModels;
using ReactiveUI;

namespace FundManagerDashboard.Client.Desktop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            RxApp.SuspensionHost.CreateNewAppState =
                () =>
                    new AppBootstrapper()
                        .RegisterPart<IViewFor<ShellViewModel>, ShellView>()
                        .RegisterPart<IViewFor<AddItemViewModel>, AddItemView>()
                        .RegisterPart<IViewFor<StockListViewModel>, StockListView>()
                        .RegisterPart<IViewFor<TotalSummaryViewModel>, TotalSummaryView>();
            RxApp.SuspensionHost.SetupDefaultSuspendResume();
        }
    }
}
