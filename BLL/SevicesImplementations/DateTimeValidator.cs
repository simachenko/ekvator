using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BLL.DataTransferObjects;
using BLL.ServicesInterfaces;
using DAL;
using AutoMapper;
namespace BLL.SevicesImplementations
{
    class DateTimeValidator : IDateTimeValidation
    {
        IOrderService orderService;
        private IMapper mapper;
        public DateTimeValidator(IMapper mapper, DataAccessUOW dataAccess, IOrderService orderService)
        {
            this.orderService = orderService;
            this.mapper = mapper;

        }

        public Task<bool> DateTimeValidationAsync(OrderCreationDTO item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderCreationDTO> GetDateTimeOverlay(OrderCreationDTO item)
        {
            List<OrderDTO> orders = new List<OrderDTO>(orderService.GetOrderByRoomId(item.RoomId));
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
            List<OrderDTO> orders = new List<OrderDTO>(orderService.GetOrderByRoomId(item.RoomId));
            return orders.Exists(
                order => (order.Arrival <= item.Arrival && order.Departure > item.Arrival)||
                        (order.Arrival < item.Departure && order.Departure > item.Departure)
                    );
        }
    }
}
