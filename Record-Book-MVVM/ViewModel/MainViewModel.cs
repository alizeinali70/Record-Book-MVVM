using Record_Book_MVVM.Views;
using Record_Book_MVVM.Commands;
using Record_Book_MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace Record_Book_MVVM.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<User> Users { get; set; } //Collection Of Users
        public ICommand ShowWindowCommand { get; set; } // Show popup Window to Add new Command

        public MainViewModel()
        {
            Users = UserManager._GetUsers();
            ShowWindowCommand = new RelayCommand(ShowWindow, CanShowWindow);
        }

        private bool CanShowWindow(object obj)
        {
            return true;
        }
        //This is Our logic
        private void ShowWindow(object obj)
        {           
            AddUser addUserWin = new AddUser();
            addUserWin.ShowDialog();
        }
    }
}
