using Fishy.ViewModel.Commands;
using Fishy.ViewModel.Interfaces;
using System.Windows.Input;

namespace Fishy.ViewModel.StartWindowVM
{
    public class AuthVM
    {
        private IContainerVM container;
        private ICommand registrationCommand;
        public AuthVM(IContainerVM container)
        {
            this.container = container;
            OpenRegPage = new OpenRegPageCommand(container);
        }
        public ICommand OpenRegPage { get; }

    }
}
