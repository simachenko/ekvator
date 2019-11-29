
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DataTransferObjects
{
    public class UserForAuthDTO
    {
        public UserForAuthDTO(string name, string password)
        {
            Name = name;
            Password = password;
        }

        public string Name { set; get; }
        public string Password { set; get; }
    }
}
