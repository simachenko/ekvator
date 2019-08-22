using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DataTransferObjects
{
    public class UserDTO
    {
        public UserDTO(string name, byte[] passwordHash, byte[] passwordSalt, int accessTypeId)
        {
            Name = name;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
            AccessTypeId = accessTypeId;
        }

        public int UserId { set; get; }

        public string Name { set; get; }
        public byte[] PasswordHash { set; get; }
        public byte[] PasswordSalt { set; get; }

        public int AccessTypeId { set; get; }

    }
}
