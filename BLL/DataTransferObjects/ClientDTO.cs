using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DataTransferObjects
{
    class ClientDTO
    {
        public int ClientId { set; get; }
        public double Price { set; get; }

        public int OrderId { set; get; }
        public OrderDTO Order { set; get; }
    }
}
