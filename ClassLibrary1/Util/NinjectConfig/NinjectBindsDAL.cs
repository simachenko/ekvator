using System;
using System.Collections.Generic;
using System.Text;
using Ninject.Modules;
using DAL.IRepos;
using DAL.ReposImplement;
using DAL.Models;

namespace DAL.Util.NinjectConfig
{
    class NinjectBindsDAL : NinjectModule
    {
        public override void Load()
        {
            Bind<DataBaseContext>().ToSelf().InSingletonScope();
            Bind<IGenericRepos<Room>>().To<RoomRepos>();
            Bind<IGenericRepos<Event>>().To<EventRepos>();
            Bind<IGenericRepos<Order>>().To<OrderRepos>();
            Bind<IGenericRepos<Client>>().To<ClientRepos>();
        }
    }
}
