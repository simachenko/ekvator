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
    public class RoomRepos : IGenericRepos<Room>
    {
        [Inject]
        private DataBaseContext DataBase;

        public RoomRepos(DataBaseContext dataBase)
        {
            this.DataBase = dataBase;
        }
        public void Create(Room item)
        {
            DataBase.Rooms.Add(item);
            DataBase.SaveChanges();
        }

        public async Task CreateAsync(Room item)
        {
            await DataBase.Rooms.AddAsync(item);
        }

        public Room Get(int Id)
        {
            return DataBase.Rooms.Find(Id);
        }

        public IEnumerable<Room> Get()
        {
            return DataBase.Rooms;
        }

        public IEnumerable<Room> Get(Func<Room, bool> predicate)
        {
            return DataBase.Rooms.Where(predicate);
        }

        public async Task<Room> GetAsync(int Id)
        {
            return await DataBase.Rooms.FindAsync(Id);
        }

        public async Task<IEnumerable<Room>> GetAsync()
        {
            return await DataBase.Rooms.ToListAsync();
        }

        public void Remove(Room item)
        {
            DataBase.Rooms.Remove(item);
        }

        public void Remove(int Id)
        {
            Room item = Get(Id);
            if (item != null)        
                Remove(item);
        }
        public void Update(Room item)
        {
            DataBase.Entry<Room>(item).State = EntityState.Modified;
        }
    }
}
