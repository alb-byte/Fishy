using Fishy.ViewModel.MainWindowVM;
using System.Windows.Controls;


namespace FISHY.View.Pages.MainWindowPages.StandardPages
{
    public partial class FriendsPage : Page
    {
        public FriendsPage(MainVM mainVM)
        {
            InitializeComponent();
            DataContext = mainVM;
        }
        private void ListView_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            ((MainVM)this.DataContext).Commands["Scroll"].Execute(e);
        }
    }
}
