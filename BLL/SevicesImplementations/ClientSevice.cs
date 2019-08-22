using System;
using System.Collections.Generic;
using System.Text;
using BLL.ServicesInterfaces;
using BLL.DataTransferObjects;
using DAL;
using DAL.Models;
using AutoMapper;
using BLL.Util.Exceptions;
using System.Threading.Tasks;

namespace BLL.SevicesImplementations
{
    class ClientSevice : IClientService
    {
        private DataAccessUOW DataAccessLayer;
        private IMapper mapper;

        public ClientSevice(DataAccessUOW dataAccessLayer, IMapper mapper)
        {
            
            DataAccessLayer = dataAccessLayer;
            this.mapper = mapper;
        }
        public void CreateClient(ClientDTO client)
        {
           
            DataAccessLayer.ClientRepos.Create(mapper.Map<ClientDTO, Client>(client));
        }
        public async Task CreateClientAsync(ClientDTO client)
        {
            await DataAccessLayer.ClientRepos.CreateAsync(mapper.Map<ClientDTO, Client>(client));
        }
        public ClientDTO GetClientById(int id)
        {
            
            return mapper.Map<Client, ClientDTO>(DataAccessLayer.ClientRepos.Get(id));
        }
        public async Task<ClientDTO> GetClientByIdAsync(int id)
        {
            return  mapper.Map<Client, ClientDTO>(await DataAccessLayer.ClientRepos.GetAsync(id));
        }
        public IEnumerable<ClientDTO> GetClientByOrderId(int id)
        {
            return mapper.Map<IEnumerable<Client>, IEnumerable<ClientDTO>>(DataAccessLayer.ClientRepos.Get(x=>x.ClientId==id));
        }
        //public async Task<IEnumerable<ClientDTO>> GetClientByOrderIdAsync(int id)
        //{
        //    return mapper.Map<IEnumerable<Client>, IEnumerable<ClientDTO>>(await DataAccessLayer.ClientRepos.GetAsync(x => x.ClientId == id));
        //}

        public void RemoveClient(int id)
        {
            DataAccessLayer.ClientRepos.Remove(id);
        }
        public void UpdateInfo(ClientDTO client)
        {
            DataAccessLayer.ClientRepos.Update(mapper.Map<ClientDTO, Client>(client));
        }

      
    }
}
