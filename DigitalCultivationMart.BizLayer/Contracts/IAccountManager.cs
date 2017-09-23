using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalCultivationMart.BizLayer.Contracts
{
    public interface IAccountManager
    {
        bool IsAccountExists(string uname, string password);

        void CreateAccount(DTO.UserDTO user);
    }
}
