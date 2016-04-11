using System.Windows;
using ReactiveUI;
using Splat;

namespace FundManagerDashboard.Client.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IViewFor<IScreen>
    {
        public MainWindow()
        {
            InitializeComponent();

            ViewModel = (IScreen)Locator.CurrentMutable.GetService(typeof(IScreen));

            this.Bind(ViewModel, x => x.Router, x => x.RoutedView.Router);
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (IScreen)value; }
        }

        public IScreen ViewModel { get; set; }
    }
}
