﻿using Fishy.ViewModel.Interfaces;
using Fishy.ViewModel.StartWindowVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Fishy.ViewModel.Commands
{
    public class OpenStartPagesCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private StartVM viewModel;
        private Page newPage;
        public OpenStartPagesCommand(StartVM vm,Page page)
        {
            viewModel = vm;
            newPage = page;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            viewModel.CurrentPage = newPage;
        }
    }
}
