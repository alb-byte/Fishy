using Fishy.ViewModel.MainWindowVM;
using System.Windows.Controls;


namespace FISHY.View.Pages.MainWindowPages.StandardPages
{
    public partial class InspectionsPage : Page
    {
        public InspectionsPage(MainVM mainVM)
        {
            InitializeComponent();
            this.DataContext = mainVM;
        }
        private void ListView_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            ((MainVM)this.DataContext).Commands["Scroll"].Execute(e);
        }
    }
}
