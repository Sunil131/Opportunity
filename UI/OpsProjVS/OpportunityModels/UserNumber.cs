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
    
    public partial class UserNumber
    {
        public UserNumber()
        {
            this.NetworkPlans = new HashSet<NetworkPlan>();
        }
    
        public int ID { get; set; }
        public Nullable<int> NumerTypeID { get; set; }
        public string Number { get; set; }
        public Nullable<System.DateTime> CreateOn { get; set; }
    
        public virtual ICollection<NetworkPlan> NetworkPlans { get; set; }
        public virtual NumberType NumberType { get; set; }
    }
}