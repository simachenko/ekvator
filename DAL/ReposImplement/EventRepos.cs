using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.IRepos;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Ninject;

namespace DAL.ReposImplement 
{
    public class EventRepos : IGenericRepos<Event>
    {
        [Inject]
        private DataBaseContext DataBase;

        public EventRepos(DataBaseContext dataBase)
        {
            this.DataBase = dataBase;
        }
        public void Create(Event item)
        {
            DataBase.Events.Add(item);
        }

        public async Task CreateAsync(Event item)
        {
            await DataBase.Events.AddAsync(item);
        }

        public Event Get(int Id)
        {
            return DataBase.Events.Find(Id);
        }

        public IEnumerable<Event> Get()
        {
            return DataBase.Events;
        }

        public IEnumerable<Event> Get(Func<Event, bool> predicate)
        {
            return DataBase.Events.Where(predicate);
        }

        public async Task<Event> GetAsync(int Id)
        {
            return await DataBase.Events.FindAsync(Id);
        }

        public async Task<IEnumerable<Event>> GetAsync()
        {
            return await DataBase.Events.ToListAsync();
        }

        public void Remove(Event item)
        {
            DataBase.Events.Remove(item);
        }

        public void Remove(int Id)
        {
           Event item = Get(Id);
            if (item != null)
                Remove(item);
        }

        public void Update(Event item)
        {
            DataBase.Entry<Event>(item).State = EntityState.Modified;

        }
    }
}
