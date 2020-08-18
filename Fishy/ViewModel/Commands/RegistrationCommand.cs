using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Fishy.ViewModel.Commands
{
    class RegistrationCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public RegistrationCommand()
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
