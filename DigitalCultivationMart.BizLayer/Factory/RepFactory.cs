using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalCultivationMart.BizLayer.Contracts;
using DigitalCultivationMart.DAL.Contracts;

namespace DigitalCultivationMart.BizLayer.Factory
{
   
    public class RepFactory:Contracts.IRepoFactory
    {
        

      public  IUserRepository UserRepo
        {
            get
            {
                return new DigitalCultivationMart.DAL.Impl.UserRepository();
            }
        }

       public IDCMRepository DCMRepo
        {
            get
            {
                return new DigitalCultivationMart.DAL.Impl.DCMRepository();
            }
        }
    }
}
