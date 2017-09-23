using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalCultivationMart.DAL.Entities;
using DigitalCultivationMart.DAL.Contracts;

namespace DigitalCultivationMart.DAL.Impl
{
    public class UserRepository :IUserRepository
    {
        public readonly IList<User> users = new List<User>();

        public User AddUser(User user)
        {
            user.Id = users.Count() + 1;
            users.Add(user);
            return user;
        }

        public bool DeleteUser(int id)
        {
            bool deleted = false;
            var user = users.FirstOrDefault(t => t.Id == id);
            if (user != null)
            {
                users.Remove(user);
                deleted = true;
            }
            return deleted;
        }

        public User GetUser(string username)
        {
            return users.FirstOrDefault(t => t.UserName.Equals(username, StringComparison.CurrentCultureIgnoreCase));
        }

        public bool IsUserExists(string uname, string password)
        {
            return users.FirstOrDefault(t => t.UserName.Equals(uname, StringComparison.CurrentCultureIgnoreCase) && t.Password.Equals(password, StringComparison.CurrentCultureIgnoreCase)) != null;
        }
        
    }
}
