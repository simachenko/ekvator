using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.IRepos
{
    public interface IAuthRepos
    {
        //Task<User> RegisterAsync(User user, string password);
        //Task<User> Login(string userName, string password);
        Task<bool> UserExistsAsync(string userName);
        Task<User> GetAsync(string userName);
        void Create(User user);
        bool UserExists(string userName);
        User Get(string userName);
        Task CreateAsync(User user);

    }
}
