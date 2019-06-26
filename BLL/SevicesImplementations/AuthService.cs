using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BLL.ServicesInterfaces;
using BLL.DataTransferObjects;
using DAL;
using DAL.Models;
using AutoMapper;
using BLL.Util.Exceptions;
namespace BLL.SevicesImplementations
{
    class AuthService : IAuthService
    {
        DataAccessUOW context;
        public AuthService()
        {
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {

                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i]) return false;
                }
                return true;
            }
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        public async Task<UserDTO> RegisterAsync(string userName, string password)
        {
            userName = userName.ToLower();
            if (await context.AuthRepos.UserExistsAsync(userName))
                throw new UserAlreadyExistException();

            byte[] passwordHash,
                    passwordSalt;

            CreatePasswordHash(password, out passwordHash, out passwordSalt);

            UserDTO user = new UserDTO();
            user.Name = userName;
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<UserDTO,User>()).CreateMapper();
            bool res = await context.AuthRepos.CreateAsync(mapper.Map<UserDTO, User>(user));
            if (!res)
                return null;
            return user;
        }

        public async Task<UserDTO> LoginAsync(string userName, string password)
        {
            User user = await context.AuthRepos.GetAsync(userName);
            if (user == null)
                return null;
            if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
                return null;
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<User, UserDTO>()).CreateMapper();
            return mapper.Map<User, UserDTO>(user);
        }

    
    }
}
