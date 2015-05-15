using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OpportunityModels.IBAL;
using OpportunityModels.Model;


namespace OpportunityService.Controllers
{
    public class UserController : ApiController
    {
        private IUsersRepoService _userReporService;

        private UserController(IUsersRepoService userReporService)
        {
            _userReporService = userReporService;
        }

        // GET: api/User
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/User/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/User
        public void AddUser([FromBody]string value)
        {
            ApplicationUserModel userModel = new ApplicationUserModel()
            {
                ID = 1,
                email = "Sunilm@ObjectFrontier.com",
                IsDeleted = false,
                IsRegsitered = true,
                NAME = "Sunil Mehta",
                CreatedOn = DateTime.Now
            };
            _userReporService.RegisterUser(userModel);
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}
