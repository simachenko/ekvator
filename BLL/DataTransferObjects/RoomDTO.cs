using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DataTransferObjects
{
    class RoomDTO
    {
        public int RoomId { set; get; }
        public int Number { set; get; }
        public int Floor { set; get; }
        public DateTime StartExpluatation { set; get; }
        public DateTime EndExpluatation { set; get; }


        public ICollection<OrderDTO> Orders { set; get; }


        public ICollection<EventDTO> Events { set; get; }
    }
}
