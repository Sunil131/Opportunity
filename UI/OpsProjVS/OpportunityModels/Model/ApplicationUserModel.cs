using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpportunityModels.Model
{
    public class ApplicationUserModel
    {
        public int ID { get; set; }
        public string email { get; set; }
        public string NAME { get; set; }
        public bool IsRegsitered { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
