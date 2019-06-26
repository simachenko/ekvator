using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DAL.Models
{
    public class Room
    {
        public int RoomId { set; get; }
        public int Number { set; get; }
        public int Floor { set; get; }
        public DateTime StartExpluatation { set; get; }
        public DateTime EndExpluatation { set; get; }

        
        public ICollection<Order> Orders {set;get;}

        
        public ICollection<Event> Events { set; get; }
    }
}
