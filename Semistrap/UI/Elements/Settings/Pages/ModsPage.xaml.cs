using Semistrap.UI.ViewModels.Settings;

namespace Semistrap.UI.Elements.Settings.Pages
{



    public partial class ModsPage
    {
        public ModsPage()
        {
            DataContext = new ModsViewModel();
            InitializeComponent();
        }
    }
}
