using System;
using System.Collections.Generic;
using System.Text;
using BLL.ServicesInterfaces;
using BLL.DataTransferObjects;
using DAL;
using DAL.Models;
using AutoMapper;
using BLL.Util.Exceptions;
using System.Threading.Tasks;

namespace BLL.SevicesImplementations
{
    class OrderSevice : IOrderService
    {
        private DataAccessUOW DataAccessLayer;
        private IMapper mapper;
        IClientService clientService;
        private readonly IDateTimeValidation<OrderCreationDTO> dateTimeValidation;

        public OrderSevice(DataAccessUOW dataAccessLayer, IMapper mapper, IClientService clientService, IDateTimeValidation<OrderCreationDTO> dateTimeValidation)
        {
            DataAccessLayer = dataAccessLayer;
            this.mapper = mapper;
            this.clientService = clientService;
            this.dateTimeValidation = dateTimeValidation;
        }
        public void CreateOrder(OrderCreationDTO order)
        {
            if (!dateTimeValidation.DateTimeValidation(order))
                throw new DateIsBusyExeption();
                DataAccessLayer.OrderRepos.Create(mapper.Map<OrderCreationDTO, Order>(order));

        }

        public async Task CreateOrderAsync(OrderCreationDTO order)
        {
            if (!await dateTimeValidation.DateTimeValidationAsync(order))
                throw new DateIsBusyExeption();
            else
                await DataAccessLayer.OrderRepos.CreateAsync(mapper.Map<OrderCreationDTO, Order>(order));
        }

        public OrderDTO GetOrder(int id)
        {
            OrderDTO order =  mapper.Map<Order,OrderDTO>(DataAccessLayer.OrderRepos.Get(id));
            return CountFullPrice(order);
            
        }

        public IEnumerable<OrderDTO> GetOrder(string name)
        {
            return  mapper.Map<IEnumerable<Order>, IEnumerable<OrderDTO>>(DataAccessLayer.OrderRepos.Get(o=>o.Name==name));
            
        }

       

        public void RemoveOrder(int id)
        {
            DataAccessLayer.OrderRepos.Remove(id);
        }

        public void UpdateOrder(OrderDTO order)
        {
            if (!dateTimeValidation.DateTimeValidation(mapper.Map<OrderDTO, OrderCreationDTO>(order)))
                throw new DateIsBusyExeption();
            DataAccessLayer.OrderRepos.Update(mapper.Map<OrderDTO, Order>(order));
        }

        private OrderDTO CountFullPrice(OrderDTO order) {
            List<ClientDTO> clients = new List<ClientDTO>(clientService.GetClientByOrderId(order.OrderId));
            if(clients.Count>0){
                double summ = 0;
                foreach (ClientDTO client in clients)
                {
                    summ += client.Price;
                }
                if (order.FullPrice != summ)
                {
                    order.FullPrice = summ;
                    DataAccessLayer.OrderRepos.Update(mapper.Map<OrderDTO, Order>(order));
                }
            }
            return order;
        }

        public IEnumerable<OrderDTO> GetOrderByArrival(DateTime arrival)
        {
            return mapper.Map<IEnumerable<Order>, IEnumerable<OrderDTO>>(DataAccessLayer.OrderRepos.Get(o => o.Arrival == arrival));
        }

        public IEnumerable<OrderDTO> GetOrderByDeparture(DateTime departure)
        {
            return mapper.Map<IEnumerable<Order>, IEnumerable<OrderDTO>>(DataAccessLayer.OrderRepos.Get(o => o.Departure == departure));
        }

        public IEnumerable<OrderDTO> GetOrderByRoomId(int id)
        {
            return mapper.Map<IEnumerable<Order>, IEnumerable<OrderDTO>>(DataAccessLayer.OrderRepos.Get(o => o.RoomId == id)); ;
        }

        public IEnumerable<OrderDTO> GetOrderByPrice(int price)
        {
            return mapper.Map<IEnumerable<Order>, IEnumerable<OrderDTO>>(DataAccessLayer.OrderRepos.Get(o => o.FullPrice == price));
        }
    }
}
