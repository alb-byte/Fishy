using System.Windows;

namespace Fishy.View
{
    public class WindowParameters:Window
    {
        public static new double Height = SystemParameters.MaximizedPrimaryScreenHeight;
        public static new double Width = SystemParameters.MaximizedPrimaryScreenWidth;
        public static new ResizeMode ResizeMode = ResizeMode.NoResize;
        public static new WindowStartupLocation WindowStartupLocation = WindowStartupLocation.CenterScreen;
        public static new WindowStyle WindowStyle = WindowStyle.None;
        public static new bool AllowsTransparency = true;
    }
}
