using System;
using System.Collections.Generic;
using System.Text;
using BLL.DataTransferObjects;
namespace BLL.ServicesInterfaces
{
     interface IOrderService
     {
        void CreateOrder(string orderName, DateTime arrival, DateTime departure, IEnumerable<ClientDTO> clients, RoomDTO room);
        OrderDTO GetOrder(int id);
        OrderDTO GetOrder(string name);
        OrderDTO GetOrderByArrival(DateTime arrival);
        OrderDTO GetOrderByDeparture(DateTime departure);
        void UpdateOrder(string orderName, DateTime arrival, DateTime departure, IEnumerable<ClientDTO> clients, RoomDTO room);
        void DeleteOrder(int id);
    }
}
