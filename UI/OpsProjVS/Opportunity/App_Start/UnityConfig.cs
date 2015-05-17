using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;
using OpportunityModels.BAL;
using OpportunityModels.IBAL;

namespace OpportunityService
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IUsersRepoService>();
            container.RegisterType<IUsersRepoService, UsersRepoService>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}