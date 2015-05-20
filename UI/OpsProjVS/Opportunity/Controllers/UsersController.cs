using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OpportunityModels.IBAL;
using OpportunityModels.Model;
using OpportunityModels.Configs;
using OpportunityModels;



namespace OpportunityService.Controllers
{
    public class UsersController : ApiController
    {
        private IUsersRepoService _userRepoService;

        public UsersController(IUsersRepoService userRepoService)
        {
            _userRepoService = userRepoService;
        }

        // GET api/users
        //public IEnumerable<ApplicationUserModel> Get()
        //{
        //    //return new string[] { "value1", "value2" };
        //    var users = _userRepoService.GetUser();
        //    return users;
        //}
        public HttpResponseMessage Get()
        {
            //return new string[] { "value1", "value2" };
            var users = _userRepoService.GetUser();
            return Request.CreateResponse(HttpStatusCode.OK, users);
        }

        // GET api/users/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/users
        public bool Post([FromBody]string value)
        {
            var model = new ApplicationUserModel()
            {
                 NAME = "Sunil Mehta",
                 Password = "test@123",
                 IsRegsitered = false,
                 IsDeleted = false,
                 email = "sm@gmail.com",
                 CreatedOn = DateTime.Now
            };
            return _userRepoService.RegisterUser(model);
        }

        // PUT api/users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/users/5
        public void Delete(int id)
        {
        }
    }
}
