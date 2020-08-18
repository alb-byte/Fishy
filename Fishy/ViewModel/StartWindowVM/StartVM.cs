using Fishy.View;
using Fishy.View.Pages.StartWindowPages;
using Fishy.ViewModel.Commands;
using Fishy.ViewModel.Interfaces;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;

namespace Fishy.ViewModel.StartWindowVM
{
    public class StartVM : BaseVM,IContainerVM
    {
        private Page currentPage;
        private Dictionary<string,Page> pages;
        public StartVM()
        {
            pages = new Dictionary<string, Page>();
            Pages.Add("Auth", new AuthPage(this));
            Pages.Add("Reg", new RegPage(this));
            Pages.Add("Start", new StartPage(this));
            CurrentPage = Pages["Start"];

            OpenAuthPage = new OpenStartPagesCommand(this,Pages["Auth"]);
            OpenRegPage = new OpenStartPagesCommand(this,Pages["Reg"]);
            MainWindow window = new MainWindow();
            window.Show();
        }
        public ICommand OpenAuthPage { get; }
        public ICommand OpenRegPage { get; }
        public ICommand Authorization { get; }
        public ICommand Registration { get; }
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
        public Dictionary<string, Page> Pages
        {
            get
            {
                return pages;
            }
            set
            {
                this.pages = value;
                OnPropertyChanged("Pages");
            }

        }
    }
}
