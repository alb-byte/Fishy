using System;
using System.Windows.Input;

namespace Fishy.ViewModel.Commands
{
    public class ClearCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public ClearCommand()
        {
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {

        }
    }
}
