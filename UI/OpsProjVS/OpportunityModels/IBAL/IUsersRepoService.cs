using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpportunityModels.Model;

namespace OpportunityModels.IBAL
{
    public interface IUsersRepoService
    {
        bool RegisterUser(ApplicationUserModel userModel);

        IEnumerable<ApplicationUserModel> GetUser();
    }
}
