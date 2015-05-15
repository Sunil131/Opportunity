using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using OpportunityModels.BAL;
using OpportunityModels.IBAL;
using OpportunityModels.Model;


namespace OpportunityModels.Configs
{
    public class AutoMapperConfig
    {
        public static void MapObjects()
        {
            Mapper.CreateMap<ApplicationUserModel, USER>();
            Mapper.CreateMap<ApplicationUserModel, UserPassword>();

        }
    }
}
