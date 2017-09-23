using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalCultivationMart.DAL.Entities;
using DigitalCultivationMart.DAL.Contracts;

namespace DigitalCultivationMart.DAL.Impl
{
   public class DCMRepository : IDCMRepository
    {
        private readonly IList<State> States = new List<State>()
        {
            new State { Id = 1, Name = "Madhya Pradesh" },
            new State { Id = 1, Name = "odisha" },
            new State { Id = 1, Name = "Karnataka" },
            new State { Id = 1, Name = "Andhra Pradesh" }

        };
        private static IList<CultivationDetail> cultivationdetails = new List<CultivationDetail>();

        public IEnumerable<CultivationDetail> GetAllCultivationDetails()
        {
            return cultivationdetails;
        }

        public IEnumerable<State> GetStates()
        {
            return States;
        }

        public CultivationDetail AddCultivationDetails(CultivationDetail cultivationdetail)
        {
            cultivationdetail.Id = cultivationdetails.Count() + 1;
            cultivationdetails.Add(cultivationdetail);
            return cultivationdetail;
        }

        public bool UpdateCultivationDetails(CultivationDetail clvdetail)
        {
            var updated = false;
            var detail = cultivationdetails.FirstOrDefault(t => t.Id == clvdetail.Id);
            if (detail != null)
            {
                detail = clvdetail;
                updated = true;
            }
            return updated;
        }
    }
}
