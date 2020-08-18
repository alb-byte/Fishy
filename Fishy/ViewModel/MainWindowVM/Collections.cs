using Fishy_Model.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Fishy.ViewModel.MainWindowVM
{
    public class Collections:INotifyPropertyChanged
    {
        private ObservableCollection<DIALOG> dialogs;
        private ObservableCollection<NEWS> news;
        private ObservableCollection<USER> friends;
        private ObservableCollection<ALBUM> albums;
        private ObservableCollection<FISH> fishes;
        private ObservableCollection<STATE_INSPECTION> inspections;

        public Collections()
        {
            dialogs = new ObservableCollection<DIALOG>();
            news = new ObservableCollection<NEWS>();
            friends = new ObservableCollection<USER>();
            albums = new ObservableCollection<ALBUM>();
            fishes = new ObservableCollection<FISH>();
            inspections = new ObservableCollection<STATE_INSPECTION>();
        }
        public ObservableCollection<USER> Friends
        {
            get { return friends; }
            set
            {
                friends = value;
                OnPropertyChanged("Friends");
            }
        }
        public ObservableCollection<NEWS> News
        {
            get { return news; }
            set
            {
                news = value;
                OnPropertyChanged("News");
            }
        }
        public ObservableCollection<DIALOG> Dialogs
        {
            get { return dialogs; }
            set
            {
                dialogs = value;
                OnPropertyChanged("Dialogs");
            }
        }
        public ObservableCollection<ALBUM> Albums
        {
            get { return albums; }
            set
            {
                albums = value;
                OnPropertyChanged("Albums");
            }
        }
        public ObservableCollection<FISH> Fishes
        {
            get { return fishes; }
            set
            {
                fishes = value;
                OnPropertyChanged("Fishes");
            }
        }
        public ObservableCollection<STATE_INSPECTION> Inspectios
        {
            get { return inspections; }
            set
            {
                inspections = value;
                OnPropertyChanged("Inspections");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
