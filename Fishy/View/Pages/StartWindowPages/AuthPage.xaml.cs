using Fishy.ViewModel.StartWindowVM;
using System.Windows.Controls;

namespace Fishy.View.Pages.StartWindowPages
{
    public partial class AuthPage : Page
    {
        public AuthPage(StartVM vm)
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}
