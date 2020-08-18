using System.Windows;
using System.Windows.Controls;

namespace FISHY.View.Resources.UserControls.StandardUserControls
{
    public partial class Album : UserControl
    {
        public Album()
        {
            InitializeComponent();
            this.Width = SystemParameters.MaximizedPrimaryScreenWidth - 600;
        }
    }
}
