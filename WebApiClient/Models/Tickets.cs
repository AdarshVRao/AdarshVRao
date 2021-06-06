using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApiClient.Models
{
    public class Tickets
    {
        [FromQuery(Name="tid")]
        public int TicketId { get; set; }

        [FromRoute(Name="pid")]
        public int productId { get; set; }

        public string Name { get; set; }

        public string Titel { get; set; }

        
        public DateTime? DataOfbrith { get; set; }

        public DateTime? EnterDate { get; set; }
    }
}
