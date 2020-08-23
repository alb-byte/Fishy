using Fishy.ViewModel.MainWindowVM;
using System.Windows;
using System.Windows.Controls;

namespace FISHY.View.Pages.MainWindowPages.AdminPages
{
    public partial class AdminNewsConstructPage : Page
    {
        public AdminNewsConstructPage(MainVM vm)
        {
            InitializeComponent();
            this.Height = SystemParameters.MaximizedPrimaryScreenHeight - 100;
            this.Width = SystemParameters.MaximizedPrimaryScreenWidth - 550;
            double leftImgMargin = (this.Width - this.newsImg.Width) / 2;
            double leftBtnAddImgMargin = (this.Width - this.addImgBtn.Width)/2;
            double leftTitleLabelMargin = (this.Width - this.titleLabel.Width) / 2;
            double leftTitleTextBoxMargin = (this.Width - this.titleTextBox.Width) / 2;
            double leftContentLabelMargin = (this.Width - this.contentLabel.Width) / 2;
            double leftBtnAddNewsMargin = (this.Width - this.addNewsBtn.Width) / 2;

            Canvas.SetLeft(this.newsImg, leftImgMargin);
            Canvas.SetLeft(this.addImgBtn, leftBtnAddImgMargin);
            Canvas.SetLeft(this.titleLabel, leftTitleLabelMargin);
            Canvas.SetLeft(this.titleTextBox, leftTitleTextBoxMargin);
            Canvas.SetLeft(this.contentLabel, leftContentLabelMargin);
            Canvas.SetLeft(this.addNewsBtn, leftBtnAddNewsMargin);


            this.DataContext = vm;
        }
    }
}
