using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpportunityModels
{
    public class NetworkPlan
    {
        public int Id { get; set; }
        public int NetworkId { get; set; }
        public int NetworkTypeID { get; set; }
        public string PlanName { get; set; }
        public decimal Amount { get; set; }
        public int validity { get; set; }
        public string MiscDescription1 { get; set; }
        public string MiscDescription2 { get; set; }
        public string MiscDescription3 { get; set; }
        public string MiscDescription4 { get; set; }
        public string MiscDescription5 { get; set; }
        public string MiscDescription6 { get; set; }
        public string MiscDescription7 { get; set; }
        public string MiscDescription8 { get; set; }
        public string MiscDescription9 { get; set; }
        public string MiscDescription10 { get; set; }

    }
}