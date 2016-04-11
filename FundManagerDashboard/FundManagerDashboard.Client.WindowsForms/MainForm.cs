using System.Windows.Forms;
using ReactiveUI;
using Splat;

namespace FundManagerDashboard.Client.WindowsForms
{
    public partial class MainForm : Form, IViewFor<IScreen>
    {
        public MainForm()
        {
            InitializeComponent();
            ViewModel = (IScreen)Locator.CurrentMutable.GetService(typeof(IScreen));

            this.Bind(ViewModel, x => x.Router, x => x.controlHost.Router);
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (IScreen)value; }
        }

        public IScreen ViewModel { get; set; }
    }
}
