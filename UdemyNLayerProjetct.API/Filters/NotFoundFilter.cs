using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyNLayerProjetct.API.DTOs;
using UdemyNLayerProjetct.Core.Services;

namespace UdemyNLayerProjetct.API.Filters
{
    
    public class NotFoundFilter: ActionFilterAttribute
    {
        private readonly IProductService _productService;
        public NotFoundFilter(IProductService productService)
        {
            _productService = productService;
        }
        public async override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            int id =(int) context.ActionArguments.Values.FirstOrDefault();
            var product = await _productService.GetByIdAsync(id);
            if (product!=null)
            {
                await next();
            }
            else
            {
                ErrorDto errorDto = new();
                errorDto.Status = 404;
                errorDto.Errors.Add($"id'si {id} olan ürün veri tabanında bulunamadı");
                context.Result = new NotFoundObjectResult(errorDto);

            }
        }
    }
}
