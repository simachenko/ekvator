using System;
using System.Collections.Generic;
using System.Text;
using DAL.IRepos;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Ninject;

namespace DAL.ReposImplement
{
    class ClientRepos : IGenericRepos<Client>
    {
        [Inject]
        private DataBaseContext DataBase;

        public ClientRepos(DataBaseContext dataBase)
        {
            this.DataBase = dataBase;
        }

        public void Create(Client item)
        {
            DataBase.Clients.Add(item);
        }

        public Client Get(int Id)
        {
            return DataBase.Clients.Find(Id);
        }

        public IEnumerable<Client> Get()
        {
            return DataBase.Clients;
        }

        public void Remove(Client item)
        {
            DataBase.Clients.Remove(item);
        }

        public void Remove(int Id)
        {
            Client item = Get(Id);
            if (item != null)
                Remove(item);
        }

        public void Update(Client item)
        {
            DataBase.Entry<Client>(item).State = EntityState.Modified;
        }
    }
}
