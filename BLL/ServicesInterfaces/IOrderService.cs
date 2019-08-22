using System;
using System.Collections.Generic;
using System.Text;
using BLL.DataTransferObjects;
using System.Threading.Tasks;
namespace BLL.ServicesInterfaces
{
     interface IOrderService
     {
        Task CreateOrderAsync(OrderCreationDTO order);
        //Task<OrderDTO> GetOrderAsync(int id);
        //Task<OrderDTO> GetOrderAsync(string name);
        //Task<OrderDTO> GetOrderByArrivalAsync(DateTime arrival);
        //Task<OrderDTO> GetOrderByDepartureAsync(DateTime departure);
        //Task<OrderDTO> GetOrderByRoomIdAsync(int id);
        //Task<OrderDTO> GetOrderByPriceAsync(int price);
        void UpdateOrder(OrderDTO order);
        void RemoveOrder(int id);
        void CreateOrder(OrderCreationDTO order);
        OrderDTO GetOrder(int id);
        IEnumerable<OrderDTO> GetOrder(string name);
        IEnumerable<OrderDTO> GetOrderByArrival(DateTime arrival);
        IEnumerable<OrderDTO> GetOrderByDeparture(DateTime departure);
        IEnumerable<OrderDTO> GetOrderByRoomId(int id);
        IEnumerable<OrderDTO> GetOrderByPrice(int price);
        
    }
}
