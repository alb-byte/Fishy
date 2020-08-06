using Fishy.View.Pages.StartWindowPages;
using Fishy.ViewModel.Interfaces;
using Fishy.ViewModel.StartWindowVM;
using System;
using System.Windows.Input;

namespace Fishy.ViewModel.Commands
{
    public class OpenAuthPageCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private IContainerVM viewModel;
        public OpenAuthPageCommand(IContainerVM vm)
        {
            viewModel = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
             viewModel.CurrentPage = new AuthPage(viewModel);
        }
    }
}
