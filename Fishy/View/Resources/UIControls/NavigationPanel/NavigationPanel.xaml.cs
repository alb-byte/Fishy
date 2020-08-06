using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Fishy.View.Resources.UIControls.NavigationPanel
{
    public partial class NavigationPanel : UserControl
    {
        public NavigationPanel()
        {
            InitializeComponent();
        }
        public ControlTemplate ButtonWindowExpand { get; private set; }
        public ControlTemplate ButtonWindowExpand2 { get; private set; }


        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            parentWindow.Close();
        }

        private void Collapse_Click(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            parentWindow.WindowState = WindowState.Minimized;
        }

        private void UserControl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            parentWindow.DragMove();
        }
    }
}
