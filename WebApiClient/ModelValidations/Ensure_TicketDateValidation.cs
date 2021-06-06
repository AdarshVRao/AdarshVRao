using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApiClient.Models;

namespace WebApiClient.ModelValidations
{
    public class Ensure_TicketDateValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var ticket = validationContext.ObjectInstance as Tickets;

            if(ticket != null && !string.IsNullOrWhiteSpace(ticket.Name))
            {
                if (!ticket.DataOfbrith.HasValue)
                    return new ValidationResult("Date of Brith is required it's from custom validation");
            }

            return ValidationResult.Success;
        }
    }
}
