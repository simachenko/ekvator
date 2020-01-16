using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Models;
using BLL.DataTransferObjects;
using BLL.ServicesInterfaces;
using AutoMapper;
namespace BLL.SevicesImplementations
{
    class DateTimeValidator : IDateTimeValidation
    {
        private DataAccessUOW DataAccessLayer;
        private IMapper mapper;
        public DateTimeValidator(IMapper mapper, DataAccessUOW dataAccess)
        {
            this.DataAccessLayer = dataAccess;
            this.mapper = mapper;

        }

        public Task<bool> DateTimeValidationAsync(OrderCreationDTO item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderCreationDTO> GetDateTimeOverlay(OrderCreationDTO item)
        {
            List<OrderDTO> orders = new List<OrderDTO>(GetOrderByRoomId(item.RoomId));
            return mapper.Map<IEnumerable<OrderDTO>, IEnumerable<OrderCreationDTO>>(
                orders.FindAll(
                    order => (order.Arrival <= item.Arrival && order.Departure > item.Arrival) || 
                            (order.Arrival < item.Departure && order.Departure > item.Departure)
                    )
                );
        }

        public Task<IEnumerable<OrderCreationDTO>> GetDateTimeOverlayAsync(OrderCreationDTO item)
        {
            throw new NotImplementedException();
        }

        bool IDateTimeValidation.DateTimeValidation(OrderCreationDTO item)
        {
            List<OrderDTO> orders = new List<OrderDTO>(GetOrderByRoomId(item.RoomId));
            if (orders == null) return false;
            return orders.Exists(
                order => (order.Arrival <= item.Arrival && order.Departure > item.Arrival)||
                        (order.Arrival < item.Departure && order.Departure > item.Departure)
                    );
        }
        bool IDateTimeValidation.DateTimeValidation(OrderDTO item)
        {
            List<OrderDTO> orders = new List<OrderDTO>(GetOrderByRoomId(item.RoomId));
            if (orders == null) return false;
            return orders.Exists(
                order => (item.OrderId!=order.OrderId)&&((order.Arrival <= item.Arrival && order.Departure > item.Arrival) ||
                        (order.Arrival < item.Departure && order.Departure > item.Departure))
                    );
        }
        public IEnumerable<OrderDTO> GetOrderByRoomId(int id)
        {
            return mapper.Map<IEnumerable<Order>, IEnumerable<OrderDTO>>(DataAccessLayer.OrderRepos.Get(o => o.RoomId == id)); ;
        }
    }
}
