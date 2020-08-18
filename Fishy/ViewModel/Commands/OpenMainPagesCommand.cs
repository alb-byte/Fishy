using Fishy.ViewModel.MainWindowVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Fishy.ViewModel.Commands
{
    public class OpenMainPagesCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public enum TypePage
        {
            LEFT,
            RIGHT
        }
        private MainVM viewModel;
        private Page newPage;
        private TypePage typePage;
        public OpenMainPagesCommand(MainVM vm, Page page,TypePage typePage)
        {
            viewModel = vm;
            newPage = page;
            this.typePage = typePage;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(typePage == TypePage.LEFT)
            {
                viewModel.LeftPage = newPage;
            }
            else
            {
                viewModel.RightPage = newPage;
            }
        }
    }
}
