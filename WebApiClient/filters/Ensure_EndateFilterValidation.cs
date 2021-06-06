using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiClient.Models;

namespace WebApiClient.filters
{
    public class Ensure_EndateFilterValidation : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
            var ticket = context.ActionArguments["ticket"] as Tickets;
            if(ticket!= null  && !string.IsNullOrWhiteSpace(ticket.Name)
                && ticket.EnterDate.HasValue == false)
            {
                context.ModelState.AddModelError("EnterDate", "Enter Date is required");
                context.Result = new BadRequestObjectResult(context.ModelState);
            }
        }
    }
}
