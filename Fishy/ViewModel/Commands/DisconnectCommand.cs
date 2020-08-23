using Fishy.ViewModel.MainWindowVM;
using System;
using System.Windows.Input;

namespace Fishy.ViewModel.Commands
{
    public class DisconnectCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private MainVM viewModel;
        public DisconnectCommand(MainVM vm)
        {
            viewModel = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            viewModel.Network.Disconnect();
        }
    }
}
