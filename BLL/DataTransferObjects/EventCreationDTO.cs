using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DataTransferObjects
{
    public class EventCreationDTO
    {
        public EventCreationDTO(string description, int price, DateTime start, DateTime end, int roomId)
        {
            Description = description;
            Price = price;
            Start = start;
            End = end;
            RoomId = roomId;
        }

        public string Description { set; get; }
        public int Price { set; get; }

        public DateTime Start { set; get; }
        public DateTime End { set; get; }


        public int RoomId { set; get; }
    }
}
