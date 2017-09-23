using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalCultivationMart.BizLayer.Exceptions
{
    public class UserAccountNotFound : Exception
    {
        public UserAccountNotFound() : base("Account with provided details does not exists")
        {

        }
    }
}
