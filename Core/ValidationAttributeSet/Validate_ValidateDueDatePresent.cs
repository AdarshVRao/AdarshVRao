using Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.ValidationAttributeSet
{
    public class Validate_ValidateDueDatePresent : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var ticket = validationContext.ObjectInstance as Tickets;

            if (!ticket.ValidateDueDatePresent())
                return new ValidationResult("Report date and owner  is not valid");

            return ValidationResult.Success;
        }
    }
}
