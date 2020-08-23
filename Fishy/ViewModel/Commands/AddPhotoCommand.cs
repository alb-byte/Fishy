using Fishy.ViewModel.MainWindowVM;
using FISHY.View.Resources.UserControls.MyMessageBox;
using Microsoft.Win32;
using System;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Fishy.ViewModel.Commands
{
    public class AddPhotoCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private MainVM viewModel;
        public AddPhotoCommand(MainVM vm)
        {
            viewModel = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            try
            {
                string filePath;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == true)
                {
                    filePath = openFileDialog.FileName;
                    if (!String.IsNullOrWhiteSpace(filePath))
                        viewModel.User.Avatar = new BitmapImage(new Uri(filePath));
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.Show(ex.Message, App.Current.Windows[0]);
            }
        }
    }
}
