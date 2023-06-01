using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Record_Book_MVVM.Models
{
    public class UserManager
    {
        public UserManager() { }
        public static ObservableCollection<User> _DatabaseUsers = new ObservableCollection<User>()
        {
            new User(){Name="Ali", Email="azeinali@gmail.com"}
        };

        public static ObservableCollection<User> _GetUsers()
        {
            return _DatabaseUsers;
        }

        public static void AddUser(User user)
        { 
            _DatabaseUsers.Add(user);
        }
    }
}
