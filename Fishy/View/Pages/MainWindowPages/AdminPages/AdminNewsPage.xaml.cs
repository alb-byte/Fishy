using System.Windows;
using System.Windows.Controls;
using Fishy.ViewModel.MainWindowVM;

namespace FISHY.View.Pages.MainWindowPages.AdminPages
{
    public partial class AdminNewsPage : Page
    {
        public AdminNewsPage(MainVM vm)
        {
            InitializeComponent();
            this.Height = SystemParameters.MaximizedPrimaryScreenHeight - 100;
            this.Width = SystemParameters.MaximizedPrimaryScreenWidth - 550;
            this.MainListBox.Width = this.Width;
            this.MainListBox.MaxHeight = this.Height - this.MainField.Height;
            this.ListBoxCanvas.Height = this.Height - this.MainField.Height;
            this.DataContext = vm;
        }
        private void ListView_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            ((MainVM)this.DataContext).Commands["Scroll"].Execute(e);
        }
    }
}
