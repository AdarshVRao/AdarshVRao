using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiClient.filters;
using Core.Models;
using DataLayer.EF;

namespace WebApiClient.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
   
     
    public class TicketController : ControllerBase
    {
        private readonly DataBaseContext _db;
        public TicketController(DataBaseContext db)
        {
            this._db = db;
        }

        [HttpGet]     
        public IActionResult Get()
        {
            return Ok(_db.Tickets.ToList());
        }

        [HttpGet("{id}")]       
        public IActionResult Get(int id)
        {
            var project = _db.Projects.Find(id);
            if (project == null)
                return NotFound();
            return Ok(project);
        }

        //[HttpGet]
        //[Route("/api/Project/{pid}/tickets")]
        //public IActionResult Get(int pid)
        //{
        //    var ticket = _db.Tickets.Where(d=>d.)
        //    //if(ticket == null)
        //    //{
        //    //    return Ok($"no parameter");
        //    //}
        //    //if (ticket.productId == 0)
        //    //{
        //    //    return Ok($"Reading Get on Product :#{ticket.productId}");
        //    //}
        //    //else
        //    //{
        //    //    return Ok($"Reading Get on Product :#{ticket.productId} and  ticket : #{ticket.TicketId} , Titel : #{ticket.Titel} , name: #{ticket.Name}");
        //    //}

        //}

        [HttpPost]       
        public IActionResult Postv1([FromBody] Tickets ticket)
        {
            return Ok(ticket);
        }

        [HttpPost]
        [Route("/api/v2/Ticket")]
        [Ensure_EndateFilterValidation]
        public IActionResult Postv2([FromBody] Tickets ticket)
        {
            return Ok(ticket);
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
