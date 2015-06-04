using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OpportunityModels.IBAL;
using OpportunityModels.Model;
using OpportunityModels;


namespace OpportunityService.Controllers
{
    public class NetworksAndPlansController : ApiController
    {

        private INetworksAndPlansService _netPlanService;

        public NetworksAndPlansController(INetworksAndPlansService netPlanService)
        {
            _netPlanService = netPlanService;
        }

        [HttpGet]
        public IHttpActionResult GetAllNetworkCircles()
        {
            var networkCircles = _netPlanService. GetAllNetworkCircles();
            return Ok(networkCircles);
        }

        [HttpGet]
        public IHttpActionResult GetAllNetworks()
        {
            var allNetworks = _netPlanService.GetAllNetworks();
            return Ok(allNetworks);
        }
        
    }
}
