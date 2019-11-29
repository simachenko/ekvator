using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BLL.DataTransferObjects;
namespace BLL.ServicesInterfaces
{
    public interface IRoomService
    {
        Task CreateRoomAsync(RoomCreationDTO room);
        void RemoveRoom(int id);
        void UpdateRoom(RoomDTO room);
     

        IEnumerable<RoomDTO> GetRoomAtFloor(int floor);
        IEnumerable<RoomDTO> GetRoomByNum(int num);
        IEnumerable<RoomDTO> GetRoomByStartExpl(DateTime start);
        IEnumerable<RoomDTO> GetRoomByEndExpl(DateTime end);
        IEnumerable<RoomDTO> GetRoomByExplRange(DateTime start, DateTime end);
        void CreateRoom(RoomCreationDTO room);
    }
}
