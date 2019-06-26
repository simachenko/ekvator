using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.IRepos;
using DAL.Models;
using Ninject;
using Microsoft.EntityFrameworkCore;
namespace DAL.ReposImplement
{
    public class AuthRepos : IAuthRepos
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

        public Task<User> GetAsync(string userName)
        {
            return DataBase.Users.FirstOrDefaultAsync(x => x.Name == userName);
        }

        /*need to clean deprecated code*/
        public async Task<bool> CreateAsync(User user)
        {
            await DataBase.Users.AddAsync(user);
            return true; //wtf
        }
    }
}
