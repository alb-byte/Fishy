using Fishy.ViewModel.StartWindowVM;
using System.Windows;

namespace Fishy.View
{
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
            Width = WindowParameters.Width;
            Height = WindowParameters.Height;
            ResizeMode = WindowParameters.ResizeMode;
            WindowStyle = WindowParameters.WindowStyle;
            WindowStartupLocation = WindowParameters.WindowStartupLocation;
            AllowsTransparency = WindowParameters.AllowsTransparency;
            DataContext = new StartVM();
        }
    }
}
