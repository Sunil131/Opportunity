using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OpportunityModels.Model
{
    public class ApplicationUserModel
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        public string NAME { get; set; }

        public int UserID { get; set; }
        public string Password { get; set; }
        public bool IsRegsitered { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
