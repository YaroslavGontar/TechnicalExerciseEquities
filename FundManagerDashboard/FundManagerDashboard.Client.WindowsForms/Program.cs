using System;
using System.Windows.Forms;
using FundManagerDashboard.Client.WindowsForms.View;
using FundManagerDashboard.Core;
using FundManagerDashboard.Core.ViewModels;
using ReactiveUI;

namespace FundManagerDashboard.Client.WindowsForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            RxApp.SuspensionHost.CreateNewAppState = () => new AppBootstrapper()
                .RegisterPart<IViewFor<ShellViewModel>, ShellView>()
                .RegisterPart<IViewFor<AddItemViewModel>, AddItemView>()
                .RegisterPart<IViewFor<StockListViewModel>, StockListView>()
                .RegisterPart<IViewFor<TotalSummaryViewModel>, TotalSummaryView>();
            RxApp.SuspensionHost.SetupDefaultSuspendResume();

            Application.Run(new MainForm());
        }
    }
}
