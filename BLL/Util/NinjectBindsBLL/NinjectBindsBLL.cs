using System;
using System.Collections.Generic;
using System.Text;
using Ninject.Modules;
namespace BLL.Util.NinjectBindsBLL
{
    class NinjectBindsBLL : NinjectModule
    {
        public override void Load()
        {
            Bind<DAL.DataAccessUOW>().ToSelf();
        }
    }
}
