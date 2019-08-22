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
    class EventService : IEventService
    {
        private DataAccessUOW DataAccessLayer;
        private IMapper mapper;

        public EventService(DataAccessUOW dataAccessLayer, IMapper mapper)
        {

            DataAccessLayer = dataAccessLayer;
            this.mapper = mapper;
        }
        public void CreateEvent(EventCreationDTO eventCreation)
        {
            DataAccessLayer.EventRepos.Create(mapper.Map<EventCreationDTO, Event>(eventCreation));
        }

        public async Task CreateEventAsync(EventCreationDTO eventCreation)
        {
            await DataAccessLayer.EventRepos.CreateAsync(mapper.Map<EventCreationDTO, Event>(eventCreation));
        }

        public IEnumerable<EventDTO> GetEventByEnd(DateTime end)
        {
            return mapper.Map<IEnumerable<Event>, IEnumerable<EventDTO>>(DataAccessLayer.EventRepos.Get(x => x.End == end));
        }

        public IEnumerable<EventDTO> GetEventByRoomId(int id)
        {
            return mapper.Map<IEnumerable<Event>,IEnumerable<EventDTO>>(DataAccessLayer.EventRepos.Get(x => x.RoomId == id));
        }

        public IEnumerable<EventDTO> GetEventByStart(DateTime start)
        {
            return mapper.Map<IEnumerable<Event>, IEnumerable<EventDTO>>(DataAccessLayer.EventRepos.Get(x => x.Start == start));
        }

        //public Task<IEnumerable<EventDTO>> GetEventByRoomIdAsync(int id)
        //{

        //}


        public void RemoveEvent(int id)
        {
            DataAccessLayer.EventRepos.Remove(id);
        }

        public void UpdateEvent(EventDTO item)
        {
            DataAccessLayer.EventRepos.Update(mapper.Map<EventDTO,Event>(item));
        }
    }
}
