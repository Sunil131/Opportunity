using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpportunityModels.IBAL;
using AutoMapper;

namespace OpportunityModels.BAL
{
    public class NetworkAndPlanService: INetworksAndPlansService
    {
        public IEnumerable<NetworkCircle> GetAllNetworkCircles()
        {
            var dbContext = new dbOpsEntities();
            //IEnumerable<NetworkCircle> circles = (IEnumerable<NetworkCircle>)(Mapper.Map<NetworkCircle>(dbContext.NetworkCircles.AsEnumerable<NetworkCircle>()));
            return dbContext.NetworkCircles.AsEnumerable<NetworkCircle>();
        }
    }
}
