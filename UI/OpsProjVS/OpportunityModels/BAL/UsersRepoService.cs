using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  OpportunityModels.IBAL;
using OpportunityModels.Model;
using AutoMapper;
using OpportunityModels;

namespace OpportunityModels.BAL
{
    public class UsersRepoService: IUsersRepoService
    {

        public bool RegisterUser(ApplicationUserModel applicationUserModel)
        {
           var user = Mapper.Map<USER>(applicationUserModel);
           int success = 0;
           using (dbOpsEntities e = new dbOpsEntities())
           {
               e.USERS.Add(user);
            success =  e.SaveChanges();
           }
            return (success > 0 )?true:false;
        }
    }
}
