using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;

namespace Core.ValidationAttributeSet
{
    public class Validation_DueDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var ticket = validationContext.ObjectInstance as Tickets;

            if (!ticket.ValidateDueDate())
                return new ValidationResult("Due date is not valid");

            return ValidationResult.Success;
        }
    }
}
