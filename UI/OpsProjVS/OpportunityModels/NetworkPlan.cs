//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpportunityModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class NetworkPlan
    {
        public int ID { get; set; }
        public Nullable<int> NetworkID { get; set; }
        public Nullable<int> UserNumerID { get; set; }
        public decimal Amount { get; set; }
        public int Validity { get; set; }
        public string MisDescription1 { get; set; }
        public string MisDescription2 { get; set; }
        public string MisDescription3 { get; set; }
        public string MisDescription4 { get; set; }
        public string MisDescription5 { get; set; }
        public string MisDescription6 { get; set; }
        public string MisDescription7 { get; set; }
        public string MisDescription8 { get; set; }
        public string MisDescription9 { get; set; }
        public string MisDescription10 { get; set; }
    
        public virtual Network Network { get; set; }
        public virtual UserNumber UserNumber { get; set; }
    }
}
