using Fishy.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Fishy.ViewModel.MainWindowVM
{
    public class CommandManager
    {
        private MainVM mainVM;
        public CommandManager(MainVM mainVM)
        {
            this.mainVM = mainVM;
            OpenNewsPage = new OpenMainPagesCommand(mainVM, mainVM.Pages["News"], OpenMainPagesCommand.TypePage.RIGHT);
            OpenDialogPage = new OpenMainPagesCommand(mainVM, mainVM.Pages["Dialogs"], OpenMainPagesCommand.TypePage.RIGHT);
            OpenAlbumPage = new OpenMainPagesCommand(mainVM, mainVM.Pages["Albums"], OpenMainPagesCommand.TypePage.RIGHT);
            OpenFriendPage = new OpenMainPagesCommand(mainVM, mainVM.Pages["Friends"], OpenMainPagesCommand.TypePage.RIGHT);
            OpenFishPage = new OpenMainPagesCommand(mainVM, mainVM.Pages["Fishes"], OpenMainPagesCommand.TypePage.RIGHT);
            OpenInspectionPage = new OpenMainPagesCommand(mainVM, mainVM.Pages["Inspections"], OpenMainPagesCommand.TypePage.RIGHT);

            Scroll = new RegistrationCommand();

        }
        public ICommand OpenNewsPage { get; }
        public ICommand OpenDialogPage { get; }
        public ICommand OpenAlbumPage { get; }
        public ICommand OpenFriendPage { get; }
        public ICommand OpenFishPage { get; }
        public ICommand OpenInspectionPage { get; }
        public ICommand OpenStartPage { get; }

        public ICommand Scroll { get; }




    }
}
