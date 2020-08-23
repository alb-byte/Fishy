using Fishy.ViewModel.MainWindowVM;
using Fishy_Model.Models;
using System.Windows;

namespace Fishy.View
{
    public partial class MainWindow : Window
    {
        public MainWindow(User user)
        {
            InitializeComponent();
            this.Width = WindowParameters.Width;
            this.Height = WindowParameters.Height;
            ResizeMode = WindowParameters.ResizeMode;
            WindowStyle = WindowParameters.WindowStyle;
            WindowStartupLocation = WindowParameters.WindowStartupLocation;
            AllowsTransparency = WindowParameters.AllowsTransparency;
            this.DataContext = new MainVM(user);
            //this.Closing += ((MainVM)this.DataContext).OnWindowClosing;
        }
    }
}
