using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalCultivationMart.DTO;
using DigitalCultivationMart.DAL.Contracts;
using DigitalCultivationMart.DAL.Impl;
using DigitalCultivationMart.DAL.Entities;
using DigitalCultivationMart.BizLayer.Contracts;

namespace DigitalCultivationMart.BizLayer.Impl
{
    public class DCMManager : Manager, IDCMManager
    {
        public CultivationDetailDTO AddCultivationDetails(CultivationDetailDTO cultivationdetail)
        {
            var model = AutoMapper.Mapper.Map<CultivationDetail>(cultivationdetail);
            model = dcmrepo.AddCultivationDetails(model);
            cultivationdetail.ID = model.Id;
            return cultivationdetail;
        }

        public IEnumerable<CultivationDetailDTO> GetAllCultivationDetails()
        {
            var list = dcmrepo.GetAllCultivationDetails();
            return AutoMapper.Mapper.Map<IEnumerable<CultivationDetailDTO>>(list);
        }

        public IEnumerable<StateDTO> GetStates()
        {
            var list = dcmrepo.GetStates();
            return AutoMapper.Mapper.Map<IEnumerable<StateDTO>>(list);
        }

        public bool UpdateCultivationDetails(CultivationDetailDTO cultivationdetail)
        {
            var model = AutoMapper.Mapper.Map<CultivationDetail>(cultivationdetail);
            return dcmrepo.UpdateCultivationDetails(model);
        }
    }
}
