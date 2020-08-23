using Fishy.ViewModel.StartWindowVM;
using FISHY.View.Resources.UserControls.MyMessageBox;
using Fishy_Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Fishy.ViewModel.Commands
{
    public class RegistrationCommand: ICommand
    {
        public event EventHandler CanExecuteChanged;
        private StartVM viewModel;
        public RegistrationCommand(StartVM vm)
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
                Tuple<PasswordBox, PasswordBox> passwords = (Tuple<PasswordBox, PasswordBox>)parameter;
                if (passwords.Item1.Password.Equals(passwords.Item2.Password) && passwords.Item1.Password != String.Empty && passwords.Item2.Password != String.Empty)
                {
                    viewModel.User.Password = Encryption.GetSHA1HashData(passwords.Item1.Password);
                }
                else
                {
                    MyMessageBox.Show("Введенные пароли не совпадают либо отсутствуют!!!", App.Current.Windows[0]);
                }
            }       
            catch
            {
                MyMessageBox.Show("Введите новые пароли", App.Current.Windows[0]);
                return;
            }

            Response response = viewModel.Network.SendRequest(Request.RequestType.CreateUser, viewModel.User);
            if (response == null)
            {
                MyMessageBox.Show("Подключение к сети отсутствует!!!", App.Current.Windows[0]);
                return;
            }
            switch (response.State)
            {
                case Response.ResponseState.NotNull:
                    {
                        MyMessageBox.Show("Вы зарегестрированы!!!", App.Current.Windows[0],true);
                        break;
                    }
                case Response.ResponseState.IsNull:
                    {
                        MyMessageBox.Show("Пользователь с такой почтой уже зарегестрирован!!!", App.Current.Windows[0]);
                        break;
                    }
                case Response.ResponseState.Error:
                    {
                        MyMessageBox.Show("Ошибка регистрции!!!", App.Current.Windows[0]);
                        break;
                    }
            }
        }
    }
}
