using DigitalCultivationMart.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class DCMController : ApiController
    {
        private readonly DigitalCultivationMart.BizLayer.Contracts.IDCMManager dcmManager;
        private readonly DigitalCultivationMart.BizLayer.Contracts.IAccountManager accountManager;
        public DCMController()
        {
            dcmManager = new DigitalCultivationMart.BizLayer.Impl.DCMManager();
            accountManager = new DigitalCultivationMart.BizLayer.Impl.AccountManager();
        }

        [Route("UserLogin")]
        public async Task<IHttpActionResult> UserLogin(string username, string password)
        {
            var retval = accountManager.IsAccountExists(username, password);
            return Ok();
        }

        [HttpPost]
        [Route("CultivationInfoDetails")]
        public async Task<CultivationDetailDTO> AddCultivationInfoDetails(CultivationDetailDTO cultivationDetails)
        {
            var retval = dcmManager.AddCultivationDetails(cultivationDetails);
            return retval;
        }


        [HttpPut]
        [Route("CultivationInfoDetails")]
        public async Task<IHttpActionResult> UpdateCultivationInfoDetails(CultivationDetailDTO cultivationDetails)
        {
            var retval = dcmManager.UpdateCultivationDetails(cultivationDetails);
            return Ok();
        }

        [HttpGet]
        [Route("CultivationInfoDetails")]
        public IEnumerable<CultivationDetailDTO> GetAllCultivationDetails()
        {
            return dcmManager.GetAllCultivationDetails();
        }

        [HttpGet]
        [Route("GetStates")]
        public IEnumerable<StateDTO> GetStates()
        {
            return dcmManager.GetStates();

        }



    }
}