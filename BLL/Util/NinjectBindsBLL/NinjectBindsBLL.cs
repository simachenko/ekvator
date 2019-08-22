using System;
using System.Collections.Generic;
using System.Text;
using Ninject.Modules;
using AutoMapper;
using BLL.Util.AutoMapper;
using AutoMapper.Configuration;
using AutoMapper;
namespace BLL.Util.NinjectBindsBLL
{
    class NinjectBindsBLL : NinjectModule
    {
        public override void Load()
        {
            Bind<MapperConfigurationExpression>().To<MapperConfigs>();
            Bind<IConfigurationProvider>().To<MapperConfiguration>();
            Bind<IMapper>().To<Mapper>();
            Bind<DAL.DataAccessUOW>().ToSelf();
        }
    }
}
