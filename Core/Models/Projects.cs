using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
   public class Projects
    {
        public int ProjectId { get; set; }

        public string ProjectName { get; set; }

        public List<Tickets> Tickets { get; set; }
    }
}
