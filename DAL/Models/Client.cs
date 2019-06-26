using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DAL.Models
{
    public class Client
    {
        public int ClientId { set; get; }
        public double Price { set; get; }

        
        public int OrderId { set; get; }
        public Order Order { set; get; }
    }
}
