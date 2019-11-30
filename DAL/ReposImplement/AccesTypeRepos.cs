using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.IRepos;
using DAL.Models;
using Ninject;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DAL.ReposImplement
{
    public class AccesTypeRepos : IGenericRepos<AccessType>
    {
        [Inject]
        private readonly DataBaseContext DataBase;

        public AccesTypeRepos(DataBaseContext dataBase)
        {
            DataBase = dataBase;
        }

        public void Create(AccessType item)
        {
            DataBase.AccessTypes.Add(item);
            DataBase.SaveChanges();
        }

        public async Task CreateAsync(AccessType item)
        {
            await DataBase.AccessTypes.AddAsync(item);
            await DataBase.SaveChangesAsync();
        }

        public AccessType Get(int Id)
        {
            return DataBase.AccessTypes.Find(Id);
        }

        public IEnumerable<AccessType> Get()
        {
            return DataBase.AccessTypes.ToList();
        }

        public IEnumerable<AccessType> Get(Func<AccessType, bool> predicate)
        {
            return DataBase.AccessTypes.Where(predicate);
        }

        public async Task<AccessType> GetAsync(int Id)
        {
            return await DataBase.AccessTypes.FindAsync(Id);
        }

        public async Task<IEnumerable<AccessType>> GetAsync()
        {
            return await DataBase.AccessTypes.ToListAsync();
        }

        //public async Task<IEnumerable<AccessType>> GetAsync(Func<AccessType, bool> predicate)
        //{
        //    return  DataBase.AccessTypes.Where(predicate).ToListAsync();
        //}

        public void Remove(AccessType item)
        {
            DataBase.AccessTypes.Remove(item);
            DataBase.SaveChanges();
        }

        public void Remove(int Id)
        {
            AccessType type = Get(Id);
            if (type != null)
            {
                DataBase.AccessTypes.Remove(type);
                DataBase.SaveChanges();
            }
            
        }

        //public async Task<bool> RemoveAsync(AccessType item)
        //{
        //    await DataBase.AccessTypes;
        //}

        //public Task<bool> RemoveAsync(int Id)
        //{
            
        //}

        public void Update(AccessType item)
        {
            DataBase.Entry<AccessType>(item).State = EntityState.Modified;
            DataBase.SaveChanges();
        }

        //public Task<bool> UpdateAsync(AccessType item)
        //{
        //    DataBase.en
        //}

        
    }
}
