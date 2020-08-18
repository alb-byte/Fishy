using Fishy.ViewModel.Commands;
using Fishy.ViewModel.Interfaces;
using System.Windows.Input;

namespace Fishy.ViewModel.StartWindowVM
{
    public class RegVM
    {
        //private User user;
        private StartVM mainVM;
        private ICommand registrationCommand;
        public RegVM(StartVM main)
        {
            this.mainVM = main;
            OpenAuthPage = mainVM.OpenAuthPage;
            //user = new User();
        }
        public ICommand OpenAuthPage { get; }

        //public ICommand RegistrationCommand
        //{
        //    get
        //    {
        //        return registrationCommand ?? (registrationCommand = new RelayCommand((obj) => Registration(obj), (obj) => CanExecute));
        //    }
        //}

        //public User User
        //{
        //    get { return user; }
        //    set
        //    {
        //        user = value;
        //        OnPropertyChanged("User");
        //    }
        //}
        //public void Registration(object obj)
        //{
        //    try
        //    {
        //        Tuple<PasswordBox, PasswordBox> passwords = (Tuple<PasswordBox, PasswordBox>)obj;
        //        if (passwords.Item1.Password.Equals(passwords.Item2.Password) && passwords.Item1.Password != String.Empty && passwords.Item2.Password != String.Empty)
        //        {
        //            User u = new User(user);
        //            u.Password = Encryption.GetSHA1HashData(passwords.Item1.Password);
        //            SendUser(u);
        //        }
        //        else
        //        {
        //            MyMessageBox.Show("Введенные пароли не совпадают либо отсутствуют!!!", App.Current.Windows[0]);
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MyMessageBox.Show(ex.Message, App.Current.Windows[0]);
        //    }

        //}
        //private void SendUser(User user)
        //{
        //    try
        //    {
        //        TcpClient client = new TcpClient();
        //        client.Connect(server, port);
        //        NetworkStream stream = client.GetStream();
        //        Request request = new Request(RequestType.Registration, user);
        //        BinaryFormatter formatter = new BinaryFormatter();
        //        formatter.Serialize(stream, request);
        //        if (GetResponse(client))
        //        {
        //            MyMessageBox.Show("Пользователь успешно зарегистрирован", App.Current.Windows[0], true);
        //            User.FirstName = String.Empty;
        //            User.LastName = String.Empty;
        //            User.Email = String.Empty;
        //        }
        //        else
        //        {
        //            MyMessageBox.Show("Пользователь не зарегистрирован", App.Current.Windows[0]);
        //        }
        //        stream.Close();
        //        client.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MyMessageBox.Show(ex.Message, App.Current.Windows[0]);
        //    }
        //}
        //private bool GetResponse(TcpClient client)
        //{
        //    NetworkStream stream = client.GetStream();
        //    BinaryFormatter formatter = new BinaryFormatter();
        //    object obj = formatter.Deserialize(stream);
        //    client.Close();
        //    return (bool)obj;
        //}
        //public bool CanExecute
        //{
        //    get
        //    {
        //        if (!(String.IsNullOrWhiteSpace(User.FirstName) ||
        //             String.IsNullOrWhiteSpace(User.LastName) ||
        //             String.IsNullOrWhiteSpace(User.Email)) &&
        //             String.IsNullOrWhiteSpace(User["FirstName"]) &&
        //             String.IsNullOrWhiteSpace(User["LastName"]) &&
        //             String.IsNullOrWhiteSpace(User["Email"]))
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //}
    }
}
