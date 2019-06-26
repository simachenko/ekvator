using System;
using System.Collections.Generic;
using System.Text;
using Ninject;
using Ninject.Modules;
namespace DAL.Util.Servis_Locator
{
    public static class DepencyResolver
    {
        public static IKernel kernel;
        public static void SeUp(params INinjectModule[] configs)
        {
            kernel = new StandardKernel(configs);

        }
        public static T Get<T>()
        {
            return kernel.Get<T>();
        }

    }
}
