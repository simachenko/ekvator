using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BLL;
using BLL.DataTransferObjects;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Check2CORE.Controllers
{
    [Route("api/Order")]
    public class OrderController : Controller
    {
        ServiceHub BusinesLogic = new ServiceHub();
        // GET: api/<controller>
        [HttpGet("GetOrderById/{id}")]
        public OrderDTO GetOrderById(int id)
        {
            return BusinesLogic.OrderService.GetOrder(id);
        }
        [HttpGet("GetOrdersByName/{name}")]
        public IEnumerable<OrderDTO> GetOrdersByName(string name)
        {
            return BusinesLogic.OrderService.GetOrder(name);
        }
        [HttpGet("GetOrdersByRoomId/{roomId}")]
        public IEnumerable<OrderDTO> GetOrdersByRoomId(int roomId)
        {
            return BusinesLogic.OrderService.GetOrderByRoomId(roomId);
        }
        [HttpGet("GetOrdersByPrice/{price}")]
        public IEnumerable<OrderDTO> GetOrdersByPrice(int price)
        {
            return BusinesLogic.OrderService.GetOrderByPrice(price);
        }
        [HttpGet("GetOrdersByArrival/{arrival}")]
        public IEnumerable<OrderDTO> GetOrdersByArrival(DateTime arrival)
        {
            return BusinesLogic.OrderService.GetOrderByArrival(arrival);
        }
        [HttpGet("GetOrdersByDeparture/{departure}")]
        public IEnumerable<OrderDTO> GetOrdersByDeparture(DateTime departure)
        {
            return BusinesLogic.OrderService.GetOrderByDeparture(departure);
        }
        // POST api/<controller>
        [HttpPost]
        public void CreateOrder([FromBody] OrderCreationDTO order)
        {
            BusinesLogic.OrderService.CreateOrder(order);
        }
        // PUT api/<controller>/5
        [HttpPut]
        public void UpdateOrder([FromBody]OrderDTO order)
        {
            BusinesLogic.OrderService.UpdateOrder(order);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void DeleteOrder(int id)
        {
            BusinesLogic.OrderService.RemoveOrder(id);
        }
    }
}
