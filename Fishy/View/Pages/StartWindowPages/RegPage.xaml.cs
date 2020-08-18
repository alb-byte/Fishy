using Fishy.ViewModel.Interfaces;
using Fishy.ViewModel.StartWindowVM;
using System.Windows.Controls;

namespace Fishy.View.Pages.StartWindowPages
{
    public partial class RegPage : Page
    {
        public RegPage(StartVM vm)
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}
