using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FISHY.View.Resources.UserControls.MyMessageBox
{
    public partial class MyMessageBox : Window
    {
        public MyMessageBox()
        {
            InitializeComponent();
        }
        public static void Show(string message, Window MW)
        {
            var dialog = new MyMessageBox();
            dialog.Owner = MW;
            dialog.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            dialog.MessageContainer.Text = message;
            dialog.Title.Text = "Ошибка";
            dialog.ShowDialog();
        }
        public static void Show(string message, Window MW,bool flag)
        {
            var dialog = new MyMessageBox();
            dialog.Owner = MW;
            dialog.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            dialog.MessageContainer.Text = message;
            if(flag)
                dialog.Title.Text = "Сообщение";
            else
                dialog.Title.Text = "Ошибка";
            dialog.ShowDialog();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

}
