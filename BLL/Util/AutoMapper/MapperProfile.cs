using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using BLL.DataTransferObjects;
using DAL.Models;
namespace BLL.Util.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<AccessTypeDTO, AccessType>();
            CreateMap<AccessType, AccessTypeDTO>();
            CreateMap<ClientDTO, Client>();
            CreateMap<Client, ClientDTO>();
            CreateMap<EventDTO, Event>();
            CreateMap<EventCreationDTO, Event>();
            CreateMap<Event, EventDTO>();
            CreateMap<OrderDTO, Order>();
            CreateMap<OrderDTO, OrderCreationDTO>();
            CreateMap<OrderCreationDTO, Order>();
            CreateMap<Order, OrderDTO>();
            CreateMap<RoomDTO, Room>();
            CreateMap<RoomCreationDTO, Room>();
            CreateMap<Room, RoomDTO>();
            CreateMap<UserDTO, User>();
            CreateMap<User, UserDTO>();
            //CreateMap<IEnumerable<Client>, IEnumerable<ClientDTO>>();
            //CreateMap<IEnumerable<ClientDTO>, IEnumerable<Client>>();
            ////CreateMap<IEnumerable<Room>, IEnumerable<RoomDTO>>();
            ////CreateMap<IEnumerable<RoomDTO>, IEnumerable<Room>>();
            //CreateMap<IEnumerable<Event>, IEnumerable<EventDTO>>();
            //CreateMap<IEnumerable<EventDTO>, IEnumerable<Event>>();
            //CreateMap<IEnumerable<Order>, IEnumerable<OrderDTO>>();
            //CreateMap<IEnumerable<OrderCreationDTO>, IEnumerable<OrderDateValidationDTO>>();
            //CreateMap<IEnumerable<OrderDTO>, IEnumerable<Order>>();
            //CreateMap<IEnumerable<User>, IEnumerable<UserDTO>>();
            //CreateMap<IEnumerable<UserDTO>, IEnumerable<User>>();
            //CreateMap<IEnumerable<AccessType>, IEnumerable<AccessTypeDTO>>();
            //CreateMap<IEnumerable<AccessTypeDTO>, IEnumerable<AccessType>>();
        }
    }
}
