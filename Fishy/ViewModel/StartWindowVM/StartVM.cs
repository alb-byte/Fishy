using Fishy.View.Pages.StartWindowPages;
using Fishy.ViewModel.Commands;
using Fishy.ViewModel.Interfaces;
using System.Windows.Controls;
using System.Windows.Input;

namespace Fishy.ViewModel.StartWindowVM
{
    public class StartVM : BaseVM,IContainerVM
    {
        private Page currentPage;
        public StartVM()
        {
            CurrentPage = new StartPage(this);
            OpenAuthPage = new OpenAuthPageCommand(this);
            OpenRegPage = new OpenRegPageCommand(this);
        }
        public ICommand OpenAuthPage { get; }
        public ICommand OpenRegPage { get; }
        public Page CurrentPage
        {
            get
            {
                return currentPage;
            }
            set
            {
                this.currentPage = value;
                OnPropertyChanged("CurrentPage");
            }
        }

    }
}
