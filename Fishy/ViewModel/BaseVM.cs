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

        //protected void LoadImage(BitmapImage img)
        //{
        //    string filePath;
        //    OpenFileDialog openFileDialog = new OpenFileDialog();
        //    if (openFileDialog.ShowDialog() == true)
        //    {
        //        filePath = openFileDialog.FileName;
        //        if (!String.IsNullOrWhiteSpace(filePath))
        //            img = new BitmapImage(new Uri(filePath));
        //    }
        //}
        //protected void Scroll<T>(RequestType type, object obj, ref int counter, ObservableCollection<T> list, object p)
        //{
        //    ScrollChangedEventArgs e = (ScrollChangedEventArgs)obj;
        //    switch (ScrollTools.GetScrollThumbPosition(e))
        //    {
        //        case ScrollThumbPosition.ReachedTheTop: //Что-то делаем
        //            break;
        //        case ScrollThumbPosition.UntilTheMid: //Что-то делаем
        //            break;
        //        case ScrollThumbPosition.AfterTheMid: //Что-то делаем
        //            break;
        //        case ScrollThumbPosition.ReachedTheBottom: //Что-то делаем
        //            GetItems<T>(type, ref counter, list, p);
        //            break;
        //    }
        //}
        //protected void GetItems<T>(RequestType type, ref int counter, ObservableCollection<T> list, object p)
        //{
        //    try
        //    {
        //        TcpClient client = new TcpClient();
        //        client.Connect(server, port);
        //        NetworkStream stream = client.GetStream();
        //        Request request = new Request(type, p);
        //        BinaryFormatter formatter = new BinaryFormatter();
        //        formatter.Serialize(stream, request);
        //        List<T> responseItems = GetResponse<List<T>>(client);
        //        if (responseItems != null)
        //        {
        //            foreach (T i in responseItems)
        //            {
        //                list.Add(i);
        //            }
        //            if (responseItems.Count != 0)
        //            {
        //                counter++;
        //            }
        //        }
        //        else
        //        {
        //            MyMessageBox.Show("Элементы не загружены", App.Current.Windows[0]);
        //        }
        //        stream.Close();
        //        client.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MyMessageBox.Show(ex.Message, App.Current.Windows[0]);
        //    }

        //}

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }

}
