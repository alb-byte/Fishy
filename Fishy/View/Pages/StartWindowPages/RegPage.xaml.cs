using Fishy.ViewModel.Interfaces;
using Fishy.ViewModel.StartWindowVM;
using System.Windows.Controls;

namespace Fishy.View.Pages.StartWindowPages
{
    public partial class RegPage : Page
    {
        public RegPage(IContainerVM vm)
        {
            InitializeComponent();
            DataContext = new RegVM(vm);
        }
    }
}
