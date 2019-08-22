using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BLL.DataTransferObjects;
namespace BLL.ServicesInterfaces
{
    interface IAuthService
    {
        Task<UserDTO>  RegisterAsync(UserForAuthDTO user);
        Task<UserDTO> LoginAsync(UserForAuthDTO user);

    }
}
