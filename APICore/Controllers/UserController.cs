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
    public class UserController : Controller
    {
        ServiceHub BusinesLogic = new ServiceHub();



        // GET api/<controller>/5
        [HttpGet]
        public UserDTO Login([FromBody]UserForAuthDTO value)
        {
            return BusinesLogic.AuthService.Login(value);
        }

        // POST api/<controller>
        [HttpPost]
        public UserDTO Registration([FromBody]UserForAuthDTO value)
        {
            return BusinesLogic.AuthService.Register(value);
        }


        //    [HttpPut("{id}")]
        //    public void Put(int id, [FromBody]string value)
        //    {
        //    }

        //    
        //    [HttpDelete("{id}")]
        //    public void Delete(int id)
        //    {
        //    }
    }
}
