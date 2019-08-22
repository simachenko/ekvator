using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DataTransferObjects
{
    class EventDTO
    {
        public int EventId { set; get; }
        public string Description { set; get; }
        public int Price { set; get; }

        public DateTime Start { set; get; }
        public DateTime End { set; get; }

        
        public int RoomId { set; get; }

    }
}
