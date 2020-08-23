using FISHY.View.Resources.UserControls.MyMessageBox;
using Fishy_Model.Models;
using Fishy_Model.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Controls;
using System.Windows.Input;

namespace Fishy.ViewModel
{
    public abstract class BaseVM : INotifyPropertyChanged
    {
        private Dictionary<string, ICommand> commands;
        private Dictionary<string, Page> pages;
        public BaseVM()
        {
            Pages = new Dictionary<string, Page>();
            Commands = new Dictionary<string, ICommand>();
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
        public Dictionary<string, ICommand> Commands
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
        protected abstract void InitializationPages();
        protected abstract void InitializationCommands();
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }

}
