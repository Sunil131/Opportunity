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
    
    public partial class NumberType
    {
        public NumberType()
        {
            this.UserNumbers = new HashSet<UserNumber>();
        }
    
        public int ID { get; set; }
        public Nullable<int> NumberType1 { get; set; }
    
        public virtual ICollection<UserNumber> UserNumbers { get; set; }
    }
}
