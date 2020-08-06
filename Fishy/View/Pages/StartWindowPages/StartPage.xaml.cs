using Fishy.ViewModel.StartWindowVM;
using System.Windows.Controls;

namespace Fishy.View.Pages.StartWindowPages
{
    public partial class StartPage : Page
    {
        public StartPage(StartVM startVM)
        {
            InitializeComponent();
            DataContext = startVM;
        }
    }
}
