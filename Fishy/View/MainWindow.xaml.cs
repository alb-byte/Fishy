using Fishy.ViewModel.MainWindowVM;
using System.Windows;

namespace Fishy.View
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Width = WindowParameters.Width;
            this.Height = WindowParameters.Height;
            ResizeMode = WindowParameters.ResizeMode;
            WindowStyle = WindowParameters.WindowStyle;
            WindowStartupLocation = WindowParameters.WindowStartupLocation;
            AllowsTransparency = WindowParameters.AllowsTransparency;
            this.DataContext = new MainVM();
            //this.Closing += ((MainVM)this.DataContext).OnWindowClosing;
        }
    }
}
