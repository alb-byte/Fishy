using Fishy.ViewModel.Commands;
using Fishy.ViewModel.Network;
using FISHY.View.Pages.MainWindowPages.StandardPages;
using Fishy_Model.Models;
using Fishy_Model.Request;
using System;
using System.Windows.Controls;

namespace Fishy.ViewModel.MainWindowVM
{
    public class MainVM : BaseVM
    {
        private Page leftPage;
        private Page rightPage;
        private Collections collections;
        private User user;
        private bool elementsEnabled = false;
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
        protected override void InitializationPages()
        {
            Pages.Add("Dialogs", new DialogsPage(this));
            Pages.Add("News", new NewsPage(this));
            Pages.Add("Friends", new FriendsPage(this));
            Pages.Add("Albums", new AlbumsPage(this));
            Pages.Add("Fishes", new FishesPage(this));
            Pages.Add("Inspections", new InspectionsPage(this));
            Pages.Add("MyAccount", new MyAccountPage(this));
        }
        protected override void InitializationCommands()
        {
            Commands.Add("OpenFishPage", new OpenMainPagesCommand(this, this.Pages["Fishes"], OpenMainPagesCommand.TypePage.RIGHT));
            Commands.Add("OpenNewsPage", new OpenMainPagesCommand(this, this.Pages["News"], OpenMainPagesCommand.TypePage.RIGHT));
            Commands.Add("OpenDialogPage", new OpenMainPagesCommand(this, this.Pages["Dialogs"], OpenMainPagesCommand.TypePage.RIGHT));
            Commands.Add("OpenAlbumPage", new OpenMainPagesCommand(this, this.Pages["Albums"], OpenMainPagesCommand.TypePage.RIGHT));
            Commands.Add("OpenFriendPage", new OpenMainPagesCommand(this, this.Pages["Friends"], OpenMainPagesCommand.TypePage.RIGHT));
            Commands.Add("OpenInspectionPage", new OpenMainPagesCommand(this, this.Pages["Inspections"], OpenMainPagesCommand.TypePage.RIGHT));
            Commands.Add("AddPhoto", new AddPhotoCommand(this));
            Commands.Add("EditInfo", new EditInfoCommand(this));
        }
        public MainVM()
        {

        }
        public MainVM(User user)
        {
            User = user;
            Commands.Add("Scroll", new ClearCommand());
            LastRequest = new Request(Request.RequestType.Connect, null);
            InitializationPages();

            collections = new Collections();
            Network = new DifficultNetworkTool();
            Network.Connect(this,user);
            AddObjects();
            RightPage = Pages["News"];
            LeftPage = Pages["MyAccount"];
            InitializationCommands();

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
        public Request LastRequest { get; set; }
        public DifficultNetworkTool Network { get; set; }
        public bool ElementsEnabled
        {
            get
            {
                return elementsEnabled;
            }
            set
            {
                elementsEnabled = value;
                OnPropertyChanged("ElementsEnabled");
            }
        }
    }
}
