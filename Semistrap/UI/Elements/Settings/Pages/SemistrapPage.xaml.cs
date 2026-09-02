using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Semistrap.UI.ViewModels.Settings;

namespace Semistrap.UI.Elements.Settings.Pages
{



    public partial class SemistrapPage
    {
        public SemistrapPage()
        {
            DataContext = new SemistrapViewModel();
            InitializeComponent();
        }
    }
}
