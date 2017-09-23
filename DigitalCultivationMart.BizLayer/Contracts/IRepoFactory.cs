using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalCultivationMart.BizLayer.Contracts
{
    public interface IRepoFactory
    {
        DigitalCultivationMart.DAL.Contracts.IUserRepository UserRepo { get; }
        DigitalCultivationMart.DAL.Contracts.IDCMRepository DCMRepo { get; }
    }
}
