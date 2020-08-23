using Fishy.ViewModel.MainWindowVM;
using System.Windows.Controls;


namespace FISHY.View.Pages.MainWindowPages.StandardPages
{
    public partial class MyAccountPage : Page
    {
        public MyAccountPage(MainVM vm)
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}
