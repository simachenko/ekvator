using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DataTransferObjects
{
    public class UserDTO
    {
        public int UserId { set; get; }

        public string Name { set; get; }
        public byte[] PasswordHash { set; get; }
        public byte[] PasswordSalt { set; get; }
    }
}
