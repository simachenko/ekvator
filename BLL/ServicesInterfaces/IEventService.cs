using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BLL.DataTransferObjects;
namespace BLL.ServicesInterfaces
{
    interface IEventService
    {
        Task CreateEventAsync(EventCreationDTO eventCreation);
       
        void RemoveEvent(int id);


        void UpdateEvent(EventDTO item);
        void CreateEvent(EventCreationDTO eventCreation);

        
        IEnumerable<EventDTO> GetEventByRoomId(int id);
        IEnumerable<EventDTO> GetEventByStart(DateTime start);
        IEnumerable<EventDTO> GetEventByEnd(DateTime end);

    }
}
