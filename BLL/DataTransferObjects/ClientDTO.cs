using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DataTransferObjects
{
    class ClientDTO
    {
        public ClientDTO(double price, int orderId)
        {
            Price = price;
            OrderId = orderId;

        }

        public int ClientId { set; get; }
        public double Price { set; get; }

        public int OrderId { set; get; }

    }
}
