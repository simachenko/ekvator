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
            Bind<DataBaseContext>().ToSelf();
            Bind<IGenericRepos<Room>>().To<RoomRepos>();
            Bind<IGenericRepos<Event>>().To<EventRepos>();
            Bind<IGenericRepos<Order>>().To<OrderRepos>();
            Bind<IGenericRepos<Client>>().To<ClientRepos>();
            Bind<IGenericRepos<User>>().To<AuthRepos>();
            Bind<IAuthRepos>().To<AuthRepos>();
        }
    }
}
