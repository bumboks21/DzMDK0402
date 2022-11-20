using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAuthorization.Model
{
    public class User
    {
        private string _login;
        private string _password;
        public string Login { get => _login; set => _login = value; }
        public string Password { get => _password; set => _password = value; }
        public static ObservableCollection<User> GetListUsers()
        {
            var ListUsers = new ObservableCollection<User>()
            {
                new User()
                {
                    Login = "qwerty",
                    Password = "87556"
                },

                new User()
                {
                    Login = "painrain",
                    Password = "brain"
                },

                new User()
                {
                    Login = "bumboks",
                    Password = "876r"
                },

                new User()
                {
                    Login = "lifeisgood",
                    Password = "relax"
                }


            };
            return ListUsers;
        }

        public User()
        {
        }
        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
