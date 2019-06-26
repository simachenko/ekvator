using System;
using System.Collections.Generic;
using System.Text;
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
        }

        public Room Get(int Id)
        {
            return DataBase.Rooms.Find(Id);
        }

        public IEnumerable<Room> Get()
        {
            return DataBase.Rooms;
        }

        //public ICollection<Room> Get(Func<Room, bool> predicate)
        //{
        //    return DataBase.Rooms;
        //}

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
