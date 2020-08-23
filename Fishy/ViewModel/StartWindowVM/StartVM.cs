using Fishy.View.Pages.StartWindowPages;
using Fishy.ViewModel.Commands;
using Fishy.ViewModel.Network;
using Fishy_Model.Models;
using System.Windows.Controls;

namespace Fishy.ViewModel.StartWindowVM
{
    public class StartVM : BaseVM
    {
        private Page currentPage;
        private User user;
        public SimpleNetworkTool Network { get; set; }
        public StartVM()
        {
            user = new User();
            Network = new SimpleNetworkTool();
            InitializationPages();
            InitializationCommands();
            CurrentPage = Pages["Start"];
        }
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
        public User User
        {
            get
            {
                return user;
            }
            set
            {
                user = value;
                OnPropertyChanged("User");
            }
        }

        protected override void InitializationCommands()
        {
            Commands.Add("OpenAuthPage", new OpenStartPagesCommand(this, Pages["Auth"]));
            Commands.Add("OpenRegPage", new OpenStartPagesCommand(this, Pages["Reg"]));
            Commands.Add("OpenStartPage", new OpenStartPagesCommand(this,Pages["Start"]));
            Commands.Add("Registration", new RegistrationCommand(this));
            Commands.Add("Authorization", new AuthorizationCommand(this));
        }
        protected override void InitializationPages()
        {
            Pages.Add("Auth", new AuthPage(this));
            Pages.Add("Reg", new RegPage(this));
            Pages.Add("Start", new StartPage(this));
        }

    }
}
