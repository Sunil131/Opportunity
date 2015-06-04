using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpportunityModels.IBAL
{
    public interface INetworksAndPlansService
    {
        IEnumerable<NetworkCircle> GetAllNetworkCircles();
        IEnumerable<Network> GetAllNetworks();
    }
}
