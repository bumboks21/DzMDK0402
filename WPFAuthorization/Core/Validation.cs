using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFAuthorization.Model;

namespace WPFAuthorization.Core
{
    public static class Validation
    {
        public static bool ValidationMetod(User user)
        {
            var listUsers = User.GetListUsers();
            foreach (User userOne in listUsers)
            {
                if (user.Login == userOne.Login && user.Password == userOne.Password) return true;
            }
            return false;
        }
    }
}
