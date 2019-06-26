using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DAL.Models
{
    public class Order
    {
       
        public int OrderId { set; get; }

        public string Name { set; get; }
        public DateTime Arrival { set; get; }
        public DateTime Departure { set; get; }

       
        public ICollection<Client> Clients { set; get; }

        public int FullPrice { set; get; }

        
        public int RoomId { set; get; }
        public Room Room { set; get; }
        
    }
}
