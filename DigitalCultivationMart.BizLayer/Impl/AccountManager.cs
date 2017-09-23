using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalCultivationMart.BizLayer.Impl
{
    public class AccountManager:Manager, Contracts.IAccountManager
    {
        

        public void CreateAccount(DTO.UserDTO user)
        {
            var obj = AutoMapper.Mapper.Map<DigitalCultivationMart.DAL.Entities.User>(user);
            IsAccountExists(user.UserName, user.Password);
            urepo.AddUser(obj);
        }

        public bool IsAccountExists(string uname, string password)
        {
            if (!urepo.IsUserExists(uname, password))
            {
                throw new Exceptions.UserAccountNotFound();
            }
            return true;
        }
    }
}
