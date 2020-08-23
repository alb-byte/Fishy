using Fishy.ViewModel.MainWindowVM;
using Fishy_Model.Request;
using System;
using System.Windows.Input;

namespace Fishy.ViewModel.Commands
{
    public class EditInfoCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private MainVM viewModel;

        public EditInfoCommand(MainVM vm)
        {
            viewModel = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(viewModel.ElementsEnabled == false)
            {
                viewModel.ElementsEnabled = true;
            }
            else
            {
                viewModel.ElementsEnabled = false;
                viewModel.Network.SendRequest(Request.RequestType.UpdateUser, viewModel.User);
            }
        }
    }
}
