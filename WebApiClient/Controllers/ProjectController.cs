using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiClient.Models;

namespace WebApiClient.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProjectController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Reading Get");
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok($"Reading Get on :#{id}");
        }

        /// <summary>
        /// api/Projects/{pid}/tickets?={eid}
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        //[HttpGet]
        //[Route("/api/Project/{pid}/tickets")]
        //public IActionResult Get(int pid, int tid)
        //{
        //    if(tid == 0)
        //    {
        //        return Ok($"Reading Get on Product :#{pid}");
        //    }
        //    else
        //    {
        //        return Ok($"Reading Get on Product :#{pid} and  ticket : #{tid}");
        //    }
            
        //}

        [HttpGet]
        [Route("/api/Project/{pid}/tickets")]
        public IActionResult Get([FromQuery] Tickets ticket)
        {
            if(ticket == null)
            {
                return Ok($"no parameter");
            }
            if (ticket.productId == 0)
            {
                return Ok($"Reading Get on Product :#{ticket.productId}");
            }
            else
            {
                return Ok($"Reading Get on Product :#{ticket.productId} and  ticket : #{ticket.TicketId} , Titel : #{ticket.Titel} , name: #{ticket.Name}");
            }

        }

        [HttpPost]
        public IActionResult Post([FromBody]Tickets tickess )
        {
            return Ok(tickess);
        }
       
        [HttpPut]
        public IActionResult Put()
        {
            return Ok("update Post");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Delete Post #{id}");
        }
    }
}
