using Semistrap.Integrations;
using Semistrap.UI.ViewModels.ContextMenu;

namespace Semistrap.UI.Elements.ContextMenu
{



    public partial class ServerHistory
    {
        public ServerHistory(ActivityWatcher watcher)
        {
            var viewModel = new ServerHistoryViewModel(watcher);

            viewModel.RequestCloseEvent += (_, _) => Close();

            DataContext = viewModel;
            InitializeComponent();
        }
    }
}
