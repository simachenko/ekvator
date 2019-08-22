using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DataTransferObjects
{
    class OrderCreationDTO
    {
        public OrderCreationDTO(string name, DateTime arrival, DateTime departure, int roomId)
        {
            Name = name;
            Arrival = arrival;
            Departure = departure;
            RoomId = roomId;
        }

        public string Name { set; get; }
        public DateTime Arrival { set; get; }
        public DateTime Departure { set; get; }
        public int RoomId { set; get; }
    }
}
