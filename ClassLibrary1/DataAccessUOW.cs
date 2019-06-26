using System;
using System.Collections.Generic;
using System.Text;
using DAL.Util.NinjectConfig;
using DAL.Util.Servis_Locator;
using DAL.IRepos;
using DAL.ReposImplement;
using DAL.Models;
namespace DAL
{
    public class DataAccessUOW :IDisposable
    {

        private DataBaseContext DataBase;

        private bool disposedValue = false; // To detect redundant calls

        private IGenericRepos<Event> _eventRepos;
        private IGenericRepos<Order> _orderRepos;
        private IGenericRepos<Client> _clientRepos;
        private IGenericRepos<Room> _roomRepos;

        public DataAccessUOW()
        {
            DepencyResolver.SeUp(new NinjectBindsDAL());
            DataBase = DepencyResolver.Get<DataBaseContext>();
        }
       
        public IGenericRepos<Event> EventRepos
        {
            get
            {
                if (_eventRepos == null)
                    _eventRepos = DepencyResolver.Get<IGenericRepos<Event>>();
                return _eventRepos;
            }
        }
        public IGenericRepos<Order> OrderRepos
        {
            get
            {
                if (_orderRepos == null)
                    _orderRepos = DepencyResolver.Get<IGenericRepos<Order>>();
                return _orderRepos;
            }
        }
        public IGenericRepos<Client> ClientRepos
        {
            get
            {
                if (_clientRepos == null)
                    _clientRepos = DepencyResolver.Get<IGenericRepos<Client>>();
                return _clientRepos;
            }
        }
        public IGenericRepos<Room> RoomRepos
        {
            get
            {
                if (_roomRepos == null)
                    _roomRepos = DepencyResolver.Get<IGenericRepos<Room>>();
                return _roomRepos;
            }
        }

        public void Save()
        {
            DataBase.SaveChanges();
        }


        #region IDisposable Support
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    DataBase.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~DataAccessUOW() {
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
