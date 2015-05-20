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
           var userPassword = Mapper.Map<UserPassword>(applicationUserModel);
           //userPassword.UserID = user.ID;

           int success = 0;
           using (dbOpsEntities e = new dbOpsEntities())
           {
               e.USERS.Add(user);
               success = e.SaveChanges();

               userPassword.UserID = user.ID;
               e.UserPasswords.Add(userPassword);

               e.SaveChanges();
               
           }
            return (success > 0 )?true:false;
        }


        public IEnumerable<ApplicationUserModel> GetUser()
        {
            dbOpsEntities e = new dbOpsEntities();
            IEnumerable<ApplicationUserModel> users =  (IEnumerable<ApplicationUserModel>)(Mapper.Map<IEnumerable<ApplicationUserModel>>(e.USERS.AsEnumerable()));
            return users;
        }
    }
}
