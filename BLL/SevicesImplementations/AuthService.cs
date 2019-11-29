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
        
        private DataAccessUOW context;
        private IMapper mapper;
        public AuthService(DataAccessUOW Context, IMapper mapper)
        {
            this.context = Context;
            this.mapper = mapper;
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

        public UserDTO Register(UserForAuthDTO user)
        {
            user.Name = user.Name.ToLower();
            if (context.AuthRepos.UserExists(user.Name))
                throw new UserAlreadyExistException();

            byte[] passwordHash,
                    passwordSalt;

            CreatePasswordHash(user.Password, out passwordHash, out passwordSalt);

            UserDTO registr = new UserDTO(user.Name,passwordHash,passwordSalt,0);
           
            context.AuthRepos.Create(mapper.Map<UserDTO, User>(registr));
            return registr;
        }

        public UserDTO Login(UserForAuthDTO user)
        {
            User userGet = context.AuthRepos.Get(user.Name);
            if (user == null)
                throw new UserNoExistException();
            if (!VerifyPasswordHash(user.Password, userGet.PasswordHash, userGet.PasswordSalt))
                throw new WrongPasswordException();
            return mapper.Map<User, UserDTO>(userGet);
        }

    
    }
}
