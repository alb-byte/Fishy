using Fishy.ViewModel.Commands;
using FISHY.View.Pages.MainWindowPages.AdminPages;
using Fishy_Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishy.ViewModel.MainWindowVM
{
    public class AdminVM : BaseVM
    {
        private MainVM viewModel;
        private News news;
        private Fish fish;
        private StateInspection inspection;
        protected override void InitializationCommands()
        {
            Commands.Add("OpenNewsConstructPage", new OpenMainPagesCommand(viewModel, this.Pages["NewsConstruct"], OpenMainPagesCommand.TypePage.RIGHT));

        }
        protected override void InitializationPages()
        {
            Pages.Add("AdminNews", new AdminNewsPage(viewModel));
            Pages.Add("NewsConstruct", new AdminNewsConstructPage(viewModel));
        }
        public AdminVM(MainVM vm)
        {
            viewModel = vm;
            InitializationPages();
            InitializationCommands();
        }
        public News News
        {
            get
            {
                return news;
            }
            set
            {
                news = value;
                OnPropertyChanged("News");
            }
        }
        public Fish Fish
        {
            get
            {
                return fish;
            }
            set
            {
                fish = value;
                OnPropertyChanged("Fish");
            }
        }
        public StateInspection Inspection
        {
            get
            {
                return inspection;
            }
            set
            {
                inspection = value;
                OnPropertyChanged("Inspection");
            }
        }
    }
}
