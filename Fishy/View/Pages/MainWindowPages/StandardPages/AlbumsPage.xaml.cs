using Fishy.ViewModel.MainWindowVM;
using System;
using System.Windows;
using System.Windows.Controls;

namespace FISHY.View.Pages.MainWindowPages.StandardPages
{
    public partial class AlbumsPage : Page
    {
        public AlbumsPage(MainVM mainVM)
        {
            InitializeComponent();
            this.Height = SystemParameters.MaximizedPrimaryScreenHeight - 100;
            this.Width = SystemParameters.MaximizedPrimaryScreenWidth - 550;
            this.MainListBox.Width = this.Width - 20;
            this.MainListBox.MaxHeight = this.Height - this.EntryDialogCanvas.Height;
            this.DataContext = mainVM;
        }
        private void ListView_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            ((MainVM)this.DataContext).Commands["Scroll"].Execute(e);
        }

    }
}

