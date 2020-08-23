using Fishy.View;
using Fishy.ViewModel.StartWindowVM;
using FISHY.View.Resources.UserControls.MyMessageBox;
using Fishy_Model.Models;
using Fishy_Model.Request;
using System;
using System.Windows.Controls;
using System.Windows.Input;

namespace Fishy.ViewModel.Commands
{
    public class AuthorizationCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private StartVM viewModel;

        public AuthorizationCommand(StartVM vm)
        {
            this.viewModel = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            try
            {
                if (!String.IsNullOrEmpty(((PasswordBox)parameter).Password))
                {
                    viewModel.User.Password = Encryption.GetSHA1HashData(((PasswordBox)parameter).Password);
                }
            }
            catch
            {
                MyMessageBox.Show("Введите другой пароль", App.Current.Windows[0]);
                return;
            }
            Response response = viewModel.Network.SendRequest(Request.RequestType.GetUser, viewModel.User);
            if(response == null)
            {
                MyMessageBox.Show("Подключение к сети отсутствует!!!", App.Current.Windows[0]);
                return;
            }
            switch (response.State)
            {
                case Response.ResponseState.NotNull:
                    {
                        MainWindow window = new MainWindow((User)response.Body);
                        window.Show();
                        App.Current.Windows[0].Close();
                        break;
                    }
                case Response.ResponseState.IsNull:
                    {
                        MyMessageBox.Show("Неверный логин или пароль!!!", App.Current.Windows[0]);
                        break;
                    }
                case Response.ResponseState.Error:
                    {
                        MyMessageBox.Show("Ошибка авторизации!!!", App.Current.Windows[0]);
                        break;
                    }
            }
        }
    }
}
