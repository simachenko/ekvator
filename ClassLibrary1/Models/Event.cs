using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DAL.Models
{
    public class Event
    {
        public int EventId { set; get; }
        public string Description { set; get; }
        public int Price { set; get; }

        public DateTime Start { set; get; }
        public DateTime End { set; get; }

        
        public int RoomId { set; get; }
        public Room Room { set; get; }
    }
}
