using System;
using System.Collections.Generic;
using System.Text;
using BLL.DataTransferObjects;
using System.Threading.Tasks;
namespace BLL.ServicesInterfaces
{
    interface IClientService
    {
        Task CreateClientAsync(ClientDTO client);
        void CreateClient(ClientDTO client);
        void RemoveClient(int id);
        void UpdateInfo(ClientDTO client);
        ClientDTO GetClientById(int id);
        Task<ClientDTO> GetClientByIdAsync(int id);
        IEnumerable<ClientDTO> GetClientByOrderId(int id);
        //Task<IEnumerable<ClientDTO>> GetClientByOrderIdAsync(int id);

    }
}
