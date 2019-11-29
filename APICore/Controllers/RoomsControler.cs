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
    [Route("api/Rooms")]
    public class RoomsControler : Controller
    {
        ServiceHub BusinesLogic = new ServiceHub();

        [HttpGet]
        public IEnumerable<RoomDTO> Get()
        {
            return BusinesLogic.RoomService.GetRoomAtFloor(1);
        }
        [HttpGet("GetRoomAtFloor/{floor}")]
        public IEnumerable<RoomDTO> GetRoomAtFloor(int floor)
        {
            return BusinesLogic.RoomService.GetRoomAtFloor(floor);
        }
        [HttpGet("GetRoomByStartExpl/{startExpl}")]
        public IEnumerable<RoomDTO> GetRoomByStartExpl(DateTime startExpl)
        {
            return BusinesLogic.RoomService.GetRoomByStartExpl(startExpl);
        }
        [HttpGet("GetRoomByEndExpl/{endExpl}")]
        public IEnumerable<RoomDTO> GetRoomByEndExpl(DateTime endExpl)
        {
            return BusinesLogic.RoomService.GetRoomByEndExpl(endExpl);
        }
        [HttpGet("GetRoomByEndExpl/{startExpl}/{endExpl}")]
        public IEnumerable<RoomDTO> GetRoomByExplRange(DateTime startExpl, DateTime endExpl)
        {
            return BusinesLogic.RoomService.GetRoomByExplRange(startExpl, endExpl);
        }
        [HttpGet("GetRoomByNum/{num}")]
        public IEnumerable<RoomDTO> GetRoomByNum(int num)
        {
            return BusinesLogic.RoomService.GetRoomByNum(num);
        }
        [HttpPost]
        public void CreateRoom([FromBody] RoomCreationDTO room)
        {
            BusinesLogic.RoomService.CreateRoom(room);
        }
        [HttpPut("UpdateRoom")]
        public void UpdateRoom([FromBody]RoomDTO room)
        {
            BusinesLogic.RoomService.UpdateRoom(room);
        }
        [HttpDelete("{id}")]
        public void DeleteRoom(int id)
        {
            BusinesLogic.RoomService.RemoveRoom(id);
        }
    }
}
