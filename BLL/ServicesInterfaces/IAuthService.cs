using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BLL.DataTransferObjects;
namespace BLL.ServicesInterfaces
{
    public interface IAuthService
    {
        UserDTO  Register(UserForAuthDTO user);
        UserDTO Login(UserForAuthDTO user);

    }
}
