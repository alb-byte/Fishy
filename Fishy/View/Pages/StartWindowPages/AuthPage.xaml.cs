using Fishy.ViewModel.Interfaces;
using Fishy.ViewModel.StartWindowVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Fishy.View.Pages.StartWindowPages
{
    public partial class AuthPage : Page
    {
        public AuthPage(IContainerVM vm)
        {
            InitializeComponent();
            DataContext = new AuthVM(vm);
        }
    }
}
