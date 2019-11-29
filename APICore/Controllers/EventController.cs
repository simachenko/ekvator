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
    [Route("api/[controller]")]
    public class EventController : Controller
    {
        ServiceHub BusinesLogic = new ServiceHub();
        [HttpGet("GetEventsByRoomId/{roomId}")]
        public IEnumerable<EventDTO> GetEventsByRoomId(int roomId)
        {
            return BusinesLogic.EventService.GetEventByRoomId(roomId);
        }
        [HttpGet("GetEventsByEndDate/{end}")]
        public IEnumerable<EventDTO> GetEventsByEndDate(DateTime end)
        {
            return BusinesLogic.EventService.GetEventByEnd(end);
        }
        [HttpGet("GetEventsByStartDate/{start}")]
        public IEnumerable<EventDTO> GetEventsByStartDate(DateTime start)
        {
            return BusinesLogic.EventService.GetEventByStart(start);
        }
        [HttpPost]
        public void CreateEvent([FromBody]EventCreationDTO item)
        {
            BusinesLogic.EventService.CreateEvent(item);
        }

        [HttpPut]
        public void UpdateEvent( [FromBody]EventDTO  value)
        {
            BusinesLogic.EventService.UpdateEvent(value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            BusinesLogic.EventService.RemoveEvent(id);
        }
    }
}
