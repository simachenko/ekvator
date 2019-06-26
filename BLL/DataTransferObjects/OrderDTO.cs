using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DataTransferObjects
{
    class OrderDTO
    {
        public int OrderId { set; get; }

        public string Name { set; get; }
        public DateTime Arrival { set; get; }
        public DateTime Departure { set; get; }


        public ICollection<ClientDTO> Clients { set; get; }

        public int FullPrice { set; get; }


        public int RoomId { set; get; }
        public RoomDTO Room { set; get; }

    }
}
