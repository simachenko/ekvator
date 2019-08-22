using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BLL.DataTransferObjects;

namespace BLL.ServicesInterfaces
{
    interface IAccessRightsProvider
    {
        Task UserRightResolveAsync(UserDTO user);
        Task<AccessTypeDTO> GetAccessTypeAsync(UserDTO user);
        Task<AccessTypeDTO> GetAccessTypeAsync();
        Task<T> GetServiceInstanceAsync<T>(UserDTO user);
        Task<T> GetServiceInstanceAsync<T>(AccessTypeDTO accessType);
        Task<T> GetServiceInstanceAsync<T>();

        void RemoveAccessRights(int id);
        void RemoveAccessRights(AccessTypeDTO item);
        void UpdateAccessRights(AccessTypeDTO item);
        void UserRightResolve(UserDTO user);
        AccessTypeDTO GetAccessType(UserDTO user);
        AccessTypeDTO GetAccessType();
        T GetServiceInstance<T>(UserDTO user);
        T GetServiceInstance<T>(AccessTypeDTO accessType);
        T GetServiceInstance<T>();
    }
}
