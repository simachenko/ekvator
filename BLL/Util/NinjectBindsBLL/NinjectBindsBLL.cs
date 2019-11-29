using System;
using System.Collections.Generic;
using System.Text;
using Ninject.Modules;
using AutoMapper;
using BLL.Util.AutoMapper;
using BLL.ServicesInterfaces;
using BLL.SevicesImplementations;
using AutoMapper.Configuration;
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
            Bind<IAccessRightsProvider>().To<AccessRightsProvider>();
            Bind<IClientService>().To<ClientSevice>();
            Bind<IDateTimeValidation>().To<DateTimeValidator>();
            Bind<IEventService>().To<EventService>();
            Bind<IOrderService>().To<OrderSevice>();
            Bind<IRoomService>().To<RoomService>();
        }
    }
}
