using Fishy.ViewModel.MainWindowVM;
using System;
using System.Windows;
using System.Windows.Controls;


namespace FISHY.View.Resources.UserControls.StandardUserControls
{
    /// <summary>
    /// Логика взаимодействия для Photo.xaml
    /// </summary>
    public partial class Photo : UserControl
    {
        public Photo()
        {
            InitializeComponent();
            this.Height = SystemParameters.MaximizedPrimaryScreenHeight - 200;
            this.Width = 750;
            this.MainStackPanel.Width = this.Width;
            this.MainStackPanel.Height = this.Height;
            this.MainCanvas.Width = this.Width;
            this.MainCanvas.Height = this.Height - this.entryCommentPanel.Height - 220;
            this.MainListBox.Width = this.Width;
            this.MainListBox.MaxHeight = this.Height - this.entryCommentPanel.Height - 220;
 
        }
        private void ListView_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            if (this.mainImg.Tag!=null)
            {
                ((MainVM)this.MainListBox.DataContext).Commands["Scroll"].Execute(e);
            }
        }
        private void BtnClick(object sender,EventArgs e)
        {
            this.MainListBox.DataContext = new MainVM();
            this.showCommentsButton.Visibility = Visibility.Collapsed;
            this.entryCommentPanel.Visibility = Visibility.Visible;
        }
    }
}
