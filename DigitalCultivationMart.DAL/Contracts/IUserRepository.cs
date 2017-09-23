using DigitalCultivationMart.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalCultivationMart.DAL.Contracts
{
    public interface IUserRepository
    {
        User AddUser(User user);

        bool DeleteUser(int user);

        User GetUser(string username);

        bool IsUserExists(string uname, string password);
    }
}
