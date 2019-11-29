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
    public class ClientController : Controller
    {
        ServiceHub BusinesLogic = new ServiceHub();
        [HttpGet("GetClientsByOrderId/{orderId}")]
        public IEnumerable<ClientDTO> GetClientsByOrderId(int orderId)
        {
            return BusinesLogic.ClientService.GetClientByOrderId(orderId);
        }

        [HttpGet("GetClientById/{id}")]
        public ClientDTO GetClientById(int id)
        {
            return BusinesLogic.ClientService.GetClientById(id);
        }
        [HttpPost]
        public void CreateClient([FromBody]ClientDTO value)
        {
            BusinesLogic.ClientService.CreateClient(value);
        }

        [HttpPut]
        public void Put([FromBody]ClientDTO value)
        {
            BusinesLogic.ClientService.UpdateInfo(value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
