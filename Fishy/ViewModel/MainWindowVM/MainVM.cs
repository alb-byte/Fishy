using Fishy.ViewModel.Commands;
using Fishy.ViewModel.Interfaces;
using FISHY.View.Pages.MainWindowPages.StandardPages;
using Fishy_Model.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Input;

namespace Fishy.ViewModel.MainWindowVM
{
    public class MainVM : BaseVM, IContainerVM
    {
        private Page leftPage;
        private Page rightPage;
        private Dictionary<string, Page> pages;
        private Collections collections;
        private Dictionary<string,ICommand> commands;
        private void CreatePages()
        {
            Pages.Add("Dialogs", new DialogsPage(this));
            Pages.Add("News", new NewsPage(this));
            Pages.Add("Friends", new FriendsPage(this));
            Pages.Add("Albums", new AlbumsPage(this));
            Pages.Add("Fishes", new FishesPage(this));
            Pages.Add("Inspections", new InspectionsPage(this));
        }
        private void AddObjects()
        {
            NEWS n = new NEWS
            {
                TITLE = "aaa",
                TIME = DateTime.Now,
                CONTENT = "jfjjfjjjf"

            };
            Collections.News.Add(n);
            ALBUM a = new ALBUM
            {
                NAME = "Танцы с бубном",
            };
            Collections.Albums.Add(a);
            FISH f = new FISH
            {
                NAME = "Ерш",
                DESCRIPTION = "blablalalbablalbalbalablalbala"
            };
            Collections.Fishes.Add(f);
            STATE_INSPECTION i = new STATE_INSPECTION
            {
                PHONE = "+5255522",
                ADDRESS = "HHCKFKVKFV",
                REGION = "mINSK"
            };
            Collections.Inspectios.Add(i);
            DIALOG d = new DIALOG
            {
            };
            USER u = new USER
            {
                FIRSTNAME = "alb",
                LASTNAME = "ert"
            };
            Collections.Friends.Add(u);
        }
        private void AddCommands()
        {
            Commands.Add("OpenFishPage", new OpenMainPagesCommand(this, this.Pages["Fishes"], OpenMainPagesCommand.TypePage.RIGHT));
            Commands.Add("OpenNewsPage", new OpenMainPagesCommand(this, this.Pages["News"], OpenMainPagesCommand.TypePage.RIGHT));
            Commands.Add("OpenDialogPage", new OpenMainPagesCommand(this, this.Pages["Dialogs"], OpenMainPagesCommand.TypePage.RIGHT));
            Commands.Add("OpenAlbumPage", new OpenMainPagesCommand(this, this.Pages["Albums"], OpenMainPagesCommand.TypePage.RIGHT));
            Commands.Add("OpenFriendPage", new OpenMainPagesCommand(this, this.Pages["Friends"], OpenMainPagesCommand.TypePage.RIGHT));
            Commands.Add("OpenInspectionPage", new OpenMainPagesCommand(this, this.Pages["Inspections"], OpenMainPagesCommand.TypePage.RIGHT));
        }
        public MainVM()
        {
            commands = new Dictionary<string, ICommand>();
            Commands.Add("Scroll", new RegistrationCommand());

            pages = new Dictionary<string, Page>();
            CreatePages();

            collections = new Collections();
            AddObjects();
            RightPage = Pages["News"];
            AddCommands();

        }
        public Page LeftPage
        {
            get
            {
                return leftPage;
            }
            set
            {
                this.leftPage = value;
                OnPropertyChanged("LeftPage");
            }
        }
        public Page RightPage
        {
            get
            {
                return rightPage;
            }
            set
            {
                this.rightPage = value;
                OnPropertyChanged("RightPage");
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
        public Collections Collections
        {
            get
            {
                return collections;
            }
            set
            {
                collections = value;
                OnPropertyChanged("Collections");
            }
        }
        public Dictionary<string,ICommand> Commands
        {
            get
            {
                return commands;
            }
            set
            {
                commands = value;
                OnPropertyChanged("Commands");
            }
        }

    }
}
