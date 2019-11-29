using System;
using System.Collections.Generic;
using System.Text;
using Ninject;
using BLL.Util.NinjectBindsBLL;
using BLL.ServicesInterfaces;
namespace BLL
{
    public class ServiceHub : IDisposable
    {
        IKernel dependencyResolver;
        public ServiceHub() {
            dependencyResolver = new StandardKernel(new NinjectBindsBLL());
        }
        private IAccessRightsProvider accessRightsProviderService;
        private IAuthService authService;
        private IClientService clientService;
        private IDateTimeValidation dateTimeValidation;
        private IEventService eventService;
        private IOrderService orderService;
        private IRoomService roomService;

        public IAccessRightsProvider AccessRightsProviderService
        {
            get
            {
                if (accessRightsProviderService == null)
                    accessRightsProviderService = dependencyResolver.Get<IAccessRightsProvider>();
                return accessRightsProviderService;
            }
        }
        public IAuthService AuthService
        {
            get
            {
                if (authService == null)
                    authService = dependencyResolver.Get<IAuthService>();
                return authService;
            }
        }
        public IClientService ClientService
        {
            get
            {
                if (clientService == null)
                    clientService = dependencyResolver.Get<IClientService>();
                return clientService;
            }
        }
        public IDateTimeValidation DateTimeValidation
        {
            get
            {
                if (dateTimeValidation == null)
                    dateTimeValidation = dependencyResolver.Get<IDateTimeValidation>();
                return dateTimeValidation;
            }
        }
        public IEventService EventService
        {
            get
            {
                if (eventService == null)
                    eventService = dependencyResolver.Get<IEventService>();
                return eventService;
            }
        }
        public IRoomService RoomService
        {
            get
            {
                if (roomService == null)
                    roomService = dependencyResolver.Get<IRoomService>();
                return roomService;
            }
        }
        public IOrderService OrderService
        {
            get
            {
                if (orderService == null)
                    orderService = dependencyResolver.Get<IOrderService>();
                return orderService;
            }
        }
        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~ServiceHub()
        // {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
