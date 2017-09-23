using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalCultivationMart.BizLayer.Impl
{
   public abstract class Manager
    {
        protected readonly Contracts.IRepoFactory repofactory;
        protected readonly DAL.Contracts.IUserRepository urepo;
        protected readonly DAL.Contracts.IDCMRepository dcmrepo;
        public Manager()
        {
            repofactory = new Factory.RepFactory();
            urepo = repofactory.UserRepo;
            dcmrepo = repofactory.DCMRepo;
        }
    }
}
