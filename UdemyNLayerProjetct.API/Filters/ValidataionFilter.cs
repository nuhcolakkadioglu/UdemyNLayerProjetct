using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyNLayerProjetct.API.DTOs;

namespace UdemyNLayerProjetct.API.Filters
{
    public class ValidataionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                ErrorDto errorDto = new();
                errorDto.Status = 400;
                IEnumerable<ModelError> modelError = context.ModelState.Values.SelectMany(m => m.Errors);
                modelError.ToList().ForEach(m => {
                    errorDto.Errors.Add(m.ErrorMessage);
                });
                context.Result = new BadRequestObjectResult(errorDto);

            }
        }
    }
}
