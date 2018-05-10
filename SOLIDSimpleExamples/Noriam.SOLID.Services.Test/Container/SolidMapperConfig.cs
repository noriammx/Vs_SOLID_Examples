using AutoMapper;
using Noriam.SOLID.Model;
using Noriam.SOLID.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noriam.SOLID.Services.Test.Container
{
    public static class SolidMapperConfig
    {
        public static void InitializeAutomapper()
        {
            Mapper.Initialize(config =>
            {
                //config.CreateMap<Data.Models.Customer, Web.ViewModels.Customer>();
            });

        }
    }
}
