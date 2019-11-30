using System;
using System.Collections.Generic;
using System.Text;
using DAL.IRepos;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Ninject;
using System.Linq;

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
            DataBase.SaveChanges();

        }

        public async Task CreateAsync(Client item)
        {
            await DataBase.Clients.AddAsync(item);
            await DataBase.SaveChangesAsync();
        }

        public Client Get(int Id)
        {
            return DataBase.Clients.Find(Id);
        }

        public IEnumerable<Client> Get()
        {
            return DataBase.Clients;
        }

        public IEnumerable<Client> Get(Func<Client,bool> predicate)
        {
            return DataBase.Clients.Where(predicate);
        }

        public async Task<Client> GetAsync(int Id)
        {
            return await DataBase.Clients.FindAsync(Id);
        }

        public async Task<IEnumerable<Client>> GetAsync()
        {
            return await DataBase.Clients.ToListAsync();
        }

        public void Remove(Client item)
        {
            DataBase.Clients.Remove(item);
            DataBase.SaveChanges();

        }

        public void Remove(int Id)
        {
            Client item = Get(Id);
            if (item != null)
            {
                Remove(item);
                DataBase.SaveChanges();
            }
        }

        public void Update(Client item)
        {
            DataBase.Entry<Client>(item).State = EntityState.Modified;
            DataBase.SaveChanges();
        }
    }
}
