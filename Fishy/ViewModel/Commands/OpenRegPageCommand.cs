using Fishy.View.Pages.StartWindowPages;
using Fishy.ViewModel.Interfaces;
using System;
using System.Windows.Input;

namespace Fishy.ViewModel.Commands
{
    public class OpenRegPageCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private IContainerVM viewModel;
        public OpenRegPageCommand(IContainerVM vm)
        {
            viewModel = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            viewModel.CurrentPage = new RegPage(viewModel);
        }
    }
}
