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
    public class AuthRepos : IAuthRepos , IGenericRepos<User>
    {
        [Inject]
        private readonly DataBaseContext DataBase;

        public AuthRepos(DataBaseContext dataBase)
        {
            this.DataBase = dataBase;
        }
        
        public async Task<bool> UserExistsAsync(string userName)
        {
            if (await DataBase.Users.AnyAsync(x => x.Name == userName))
                return true;
            return false;
        }
        public bool UserExists(string userName)
        {
            if (DataBase.Users.Any(x => x.Name == userName))
                return true;
            return false;
        }
        public Task<User> GetAsync(string userName)
        {
            return DataBase.Users.FirstOrDefaultAsync(x => x.Name == userName);
        }
        public User Get(string userName)
        {
            return DataBase.Users.FirstOrDefault(x => x.Name == userName);
        }
        /**/
        public async Task CreateAsync(User user)
        {
             await DataBase.Users.AddAsync(user);
             await DataBase.SaveChangesAsync();
        }

        public User Get(int Id)
        {
            return DataBase.Users.Find(Id);
        }

        public void Create(User item)
        {
            DataBase.Users.Add(item);
            DataBase.SaveChanges();
        }

        public IEnumerable<User> Get()
        {
            return DataBase.Users;
        }

        public void Remove(User item)
        {
            DataBase.Users.Remove(item);
            DataBase.SaveChanges();

        }

        public void Remove(int Id)
        {
            User item = Get(Id);
            if (item != null)
            {
                Remove(item);
                DataBase.SaveChanges();
            }
        }

        public void Update(User item)
        {
            DataBase.Entry<User>(item).State = EntityState.Modified;
            DataBase.SaveChanges();

        }

        public IEnumerable<User> Get(Func<User, bool> predicate)
        {
            return DataBase.Users.Where(predicate);
        }

        public async Task<User> GetAsync(int Id)
        {
            return await DataBase.Users.FindAsync(Id);
        }

        public async Task<IEnumerable<User>> GetAsync()
        {
            return await DataBase.Users.ToListAsync();
        }
    }
}
