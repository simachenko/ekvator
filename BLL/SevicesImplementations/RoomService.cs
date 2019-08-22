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
    class RoomService : IRoomService
    {
        private DataAccessUOW DataAccessLayer;
        private IMapper mapper;

        public RoomService(DataAccessUOW dataAccessLayer, IMapper mapper)
        {
            DataAccessLayer = dataAccessLayer;
            this.mapper = mapper;
        }

        public void CreateRoom(RoomCreationDTO room)
        {
            DataAccessLayer.RoomRepos.Create(mapper.Map<Room>(room));
        }

        public async Task CreateRoomAsync(RoomCreationDTO room)
        {
            await DataAccessLayer.RoomRepos.CreateAsync(mapper.Map<Room>(room));
        }

        public IEnumerable<RoomDTO> GetRoomAtFloor(int floor)
        {
            return mapper.Map<IEnumerable<RoomDTO>>(DataAccessLayer.RoomRepos.Get(r=>r.Floor==floor));
        }

        public IEnumerable<RoomDTO> GetRoomByEndExpl(DateTime end)
        {
            return mapper.Map<IEnumerable<RoomDTO>>(DataAccessLayer.RoomRepos.Get(r => r.EndExpluatation == end));
        }

        public IEnumerable<RoomDTO> GetRoomByExplRange(DateTime start, DateTime end)
        {
            return mapper.Map<IEnumerable<RoomDTO>>(DataAccessLayer.RoomRepos.Get(r => r.EndExpluatation == end && r.StartExpluatation == start));
        }

        public IEnumerable<RoomDTO> GetRoomByNum(int num)
        {
            return mapper.Map<IEnumerable<RoomDTO>>(DataAccessLayer.RoomRepos.Get(r => r.Number == num));
        }

        public IEnumerable<RoomDTO> GetRoomByStartExpl(DateTime start)
        {
            return mapper.Map<IEnumerable<RoomDTO>>(DataAccessLayer.RoomRepos.Get(r =>r.StartExpluatation == start));
        }

        public void RemoveRoom(int id)
        {
            DataAccessLayer.RoomRepos.Remove(id);
        }

        public void UpdateRoom(RoomDTO room)
        {
            DataAccessLayer.RoomRepos.Update(mapper.Map<Room>(room));
        }
    }
}
