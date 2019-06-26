using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BLL.DataTransferObjects;
namespace BLL.ServicesInterfaces
{
    interface IAuthService
    {
        Task<UserDTO>  RegisterAsync(string userName, string password);
        Task<UserDTO> LoginAsync(string userName, string password);
    }
}
