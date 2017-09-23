using DigitalCultivationMart.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalCultivationMart.DAL.Contracts
{
    public interface IDCMRepository
    {
        CultivationDetail AddCultivationDetails(CultivationDetail cultivationdetails);

        bool UpdateCultivationDetails(CultivationDetail cultivationdetails);

        IEnumerable<State> GetStates();

        IEnumerable<CultivationDetail> GetAllCultivationDetails();
    }
}
