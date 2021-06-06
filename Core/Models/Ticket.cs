using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.ValidationAttributeSet;

namespace Core.Models
{
   public class Tickets
    {
      
        public int TicketId { get; set; }

     
        public int productId { get; set; }

        public string OwnerName { get; set; }

        public string Titel { get; set; }

      
        public DateTime? DataOfbrith { get; set; }

        [Validation_DueDateAttribute]
        [Validate_ValidateDueDatePresent]
        [Validate_ValidatrDueandReportDate]
        public DateTime? DueDate { get; set; }

        [Validate_ReportDate]
        public DateTime? ReportDate { get; set; }

        public Projects Projects { get; set; }

       
        /// <summary>
        /// Due date has to be in feture date
        /// </summary>
        /// <returns></returns>
        public bool ValidateDueDate()
        {
           
            if (!DueDate.HasValue == true) return true;

            return DueDate.Value > DateTime.Now;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool validatwReportdate()
        {
            if (string.IsNullOrEmpty(OwnerName)) return true;

            return ReportDate.HasValue;
        }

        public bool ValidateDueDatePresent()
        {
            if (string.IsNullOrEmpty(OwnerName)) return true;

            return DueDate.HasValue;
        }

        public bool ValidatrDueandReportDate()
        {
            if (!DueDate.HasValue || !ReportDate.HasValue) return true;

            return DueDate.Value >= ReportDate.Value;
        }
    }
}
