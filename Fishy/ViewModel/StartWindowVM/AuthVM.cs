using Fishy.ViewModel.Commands;
using Fishy.ViewModel.Interfaces;
using System.Windows.Input;

namespace Fishy.ViewModel.StartWindowVM
{
    public class AuthVM
    {
        private StartVM mainVM;
        public AuthVM(StartVM main)
        {
            this.mainVM = main;
            OpenRegPage = mainVM.OpenRegPage;
        }
        public ICommand OpenRegPage { get; }

    }
}
