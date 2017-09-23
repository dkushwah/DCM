using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalCultivationMart.BizLayer;
using DigitalCultivationMart.DTO;

namespace DigitalCultivationMart.BizLayer.Contracts
{
    public interface IDCMManager
    {
        CultivationDetailDTO AddCultivationDetails(CultivationDetailDTO cultivationdetails);

        bool UpdateCultivationDetails(CultivationDetailDTO cultivationdetails);

        IEnumerable<StateDTO> GetStates();

        IEnumerable<CultivationDetailDTO> GetAllCultivationDetails();
    }
}
