using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class User
    {
        public int UserId { set; get; }

        public string Name { set; get; }
        public byte[] PasswordHash { set; get; }
        public byte[] PasswordSalt { set; get; }
    }
}
