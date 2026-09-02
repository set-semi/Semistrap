using System.Windows;

using Semistrap.UI.ViewModels.About;

namespace Semistrap.UI.Elements.About.Pages
{



    public partial class SupportersPage
    {
        private readonly SupportersViewModel _viewModel = new();

        public SupportersPage()
        {
            DataContext = _viewModel;
            InitializeComponent();
        }

        private void UiPage_SizeChanged(object sender, SizeChangedEventArgs e)
            => _viewModel.WindowResizeEvent?.Invoke(sender, e);
    }
}
