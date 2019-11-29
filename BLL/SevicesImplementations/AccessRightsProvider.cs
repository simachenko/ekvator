using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BLL.DataTransferObjects;
using BLL.ServicesInterfaces;
namespace BLL.SevicesImplementations
{
    class AccessRightsProvider : IAccessRightsProvider
    {
        public AccessTypeDTO GetAccessType(UserDTO user)
        {
            throw new NotImplementedException();
        }

        public AccessTypeDTO GetAccessType()
        {
            throw new NotImplementedException();
        }

        public Task<AccessTypeDTO> GetAccessTypeAsync(UserDTO user)
        {
            throw new NotImplementedException();
        }

        public Task<AccessTypeDTO> GetAccessTypeAsync()
        {
            throw new NotImplementedException();
        }

        public T GetServiceInstance<T>(UserDTO user)
        {
            throw new NotImplementedException();
        }

        public T GetServiceInstance<T>(AccessTypeDTO accessType)
        {
            throw new NotImplementedException();
        }

        public T GetServiceInstance<T>()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetServiceInstanceAsync<T>(UserDTO user)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetServiceInstanceAsync<T>(AccessTypeDTO accessType)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetServiceInstanceAsync<T>()
        {
            throw new NotImplementedException();
        }

        public void RemoveAccessRights(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveAccessRights(AccessTypeDTO item)
        {
            throw new NotImplementedException();
        }

        public void UpdateAccessRights(AccessTypeDTO item)
        {
            throw new NotImplementedException();
        }

        public void UserRightResolve(UserDTO user)
        {
            throw new NotImplementedException();
        }

        public Task UserRightResolveAsync(UserDTO user)
        {
            throw new NotImplementedException();
        }
    }
}

