using Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.ValidationAttributeSet
{
   public class Validate_ReportDate : ValidationAttribute
    {        
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                var ticket = validationContext.ObjectInstance as Tickets;

                if (!ticket.validatwReportdate())
                    return new ValidationResult("Report date is not valid");

                return ValidationResult.Success;
            }     
    }
}
