using Fishy.View;
using Fishy.ViewModel.MainWindowVM;
using System;
using System.Windows.Input;

namespace Fishy.ViewModel.Commands
{
    public class OpenStartWindowCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private MainVM viewModel;
        public OpenStartWindowCommand(MainVM vm)
        {
            viewModel = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            StartWindow window = new StartWindow();
            window.Show();
            viewModel.Network.Disconnect();
            App.Current.Windows[0].Close();
        }
    }
}
